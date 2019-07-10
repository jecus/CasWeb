using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Dictionaties;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Extentions;
using Entity.Infrastructure;
using Entity.Models.General;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Repositiry
{
	public class WorkPackageRepository : IWorkPackageRepository
	{
		private readonly IAircraftRepository _aircraftRepository;
		private readonly DatabaseContext _db;

		public WorkPackageRepository(IAircraftRepository aircraftRepository, DatabaseContext db)
		{
			_aircraftRepository = aircraftRepository;
			_db = db;
		}

		public async Task<List<WorkPackageView>> GetWorkPackages(List<int> aircraftIds)
		{
			var res = new List<WorkPackageView>();
			foreach (var aircraftId in aircraftIds)
			{
				var wp = await _db.WorkPackages
					.Where(i => i.ParentId == aircraftId)
					.OnlyActive()
					.AsNoTracking()
					.ToListAsync();

				if(wp.Count == 0)
					continue;

				var view = wp.ToBlView();


				var aircraft = await _aircraftRepository.GetById(aircraftId);

				var airportIds = new List<int>();
				airportIds.AddRange(view.Select(i => i.PerfAfter.AirportFromId));
				airportIds.AddRange(view.Select(i => i.PerfAfter.AirportToId));

				var airports = await _db.AirportCodes
					.Where(i => airportIds.Contains(i.Id))
					.OnlyActive()
					.AsNoTracking()
					.ToListAsync();

				var airportView = airports.ToBlView();

				var flightNumIds = view.Select(i => i.PerfAfter.FlightNumId);
				var flightNums = await _db.FlightNums
					.Where(i => flightNumIds.Contains(i.Id))
					.OnlyActive()
					.AsNoTracking()
					.ToListAsync();

				var flightNum = flightNums.ToBlView();

				foreach (var workPackageView in view)
				{
					await CalculateMh(workPackageView);
					workPackageView.RegistrationNumber = aircraft.RegistrationNumber;
					workPackageView.PerfAfter.AirportFrom = airportView.FirstOrDefault(i => i.Id == workPackageView.PerfAfter.AirportFromId);
					workPackageView.PerfAfter.AirportTo = airportView.FirstOrDefault(i => i.Id == workPackageView.PerfAfter.AirportToId);
					workPackageView.PerfAfter.FlightNum = flightNum.FirstOrDefault(i => i.Id == workPackageView.PerfAfter.FlightNumId);
				}

				res.AddRange(view);
			}
	
			return res.ToList();
		}

		public async Task<List<WorkPackageRecordView>> GetWorkPackageRecordsTask(int wpId)
		{
			var wp = await _db.WorkPackages
				.AsNoTracking()
				.FirstOrDefaultAsync(i => i.Id == wpId);
			var wpr = await _db.WorkPackageRecords
				.AsNoTracking()
				.Where(i => i.WorkPakageId == wpId)
				.ToListAsync();

			var res = wpr.ToBlView();
			var wpView = wp.ToBlView();

			var adWprs = res.Where(w => w.WorkPackageItemType == SmartCoreType.Directive.ItemId).ToList();
			if (adWprs.Count > 0)
			{
				var directivesIds = adWprs.Select(i => i.DirectivesId);
				var directives = await _db.Directives
					.AsNoTracking()
					.Include(i => i.ATAChapter)
					.Where(i => directivesIds.Contains(i.Id))
					.ToListAsync();

				var directiveView = directives.ToBlView();
				foreach (var adWpr in adWprs)
				{
					adWpr.WorkPakage = wpView;
					var directive = directiveView.FirstOrDefault(i => i.Id == adWpr.DirectivesId);

					var firstPerf = "";
					if (directive.Threshold.FirstPerformanceSinceNew != null && !directive.Threshold.FirstPerformanceSinceNew.IsNullOrZero())
						firstPerf = "s/n: " + directive.Threshold.FirstPerformanceSinceNew;
					if (directive.Threshold.FirstPerformanceSinceEffectiveDate != null &&
						!directive.Threshold.FirstPerformanceSinceEffectiveDate.IsNullOrZero())
					{
						if (firstPerf != "") firstPerf += " or ";
						else firstPerf = "";
						firstPerf += "s/e.d: " + directive.Threshold.FirstPerformanceSinceEffectiveDate;
					}


					if (directive != null)
					{
						adWpr.Task = new WprTask()
						{
							Type = "Directive",
							AtaChapterView = directive.AtaString,
							Title = $"{directive.EngineeringOrders} {directive.Title}",
							Description = directive.Description,
							FirstPerformance = firstPerf,
							RepeatInterval = directive.Threshold.RepeatInterval.ToString(),
							WorkType = directive.WorkType.FullName,
							NDT = directive.NDTType.ShortName,
							PerfDate = wpView.PerfAfter.PerformDate.ToUniversalString(),
							MH = directive.ManHours,
							KMH = directive.ManHours * wp.KMH,
							Cost = directive.Cost,
						};
					}
				}
			}

			var detWprs = res.Where(w => w.WorkPackageItemType == SmartCoreType.Component.ItemId).ToList();
			if (detWprs.Count > 0)
			{
				var componentIds = detWprs.Select(i => i.DirectivesId);
				var components = await _db.Components
					.AsNoTracking()
					.Include(i => i.ATAChapter)
					.Where(i => componentIds.Contains(i.Id) && !i.IsBaseComponent)
					.ToListAsync();

				var componentViews = components.ToBlView();
				foreach (var adWpr in detWprs)
				{
					adWpr.WorkPakage = wpView;
					var component = componentViews.FirstOrDefault(i => i.Id == adWpr.DirectivesId);
					if (component != null)
					{
						adWpr.Task = new WprTask()
						{
							Type = "Component",
							AtaChapterView = component.ATAChapterString,
							Title = component.PartNumber,
							Description = component.Description,
							FirstPerformance = component.LifeLimit != null ? component.LifeLimit.ToString() : "",
							RepeatInterval = "",
							WorkType = "Remove",
							NDT = "",
							PerfDate = wpView.PerfAfter.PerformDate.ToUniversalString(),
							MH = component.ManHours,
							KMH = component.ManHours * wp.KMH,
							Cost = component.Cost,
						};
					}
				}
			}

			var baseDetWprs = res.Where(w => w.WorkPackageItemType == SmartCoreType.BaseComponent.ItemId).ToList();
			if (baseDetWprs.Count > 0)
			{
				var componentIds = baseDetWprs.Select(i => i.DirectivesId);
				var components = await _db.Components
					.AsNoTracking()
					.Include(i => i.ATAChapter)
					.Where(i => componentIds.Contains(i.Id) && i.IsBaseComponent)
					.ToListAsync();

				var componentViews = components.ToBlView();
				foreach (var adWpr in baseDetWprs)
				{
					adWpr.WorkPakage = wpView;
					var component = componentViews.FirstOrDefault(i => i.Id == adWpr.DirectivesId);
					if (component != null)
					{
						adWpr.Task = new WprTask()
						{
							Type = "BaseComponent",
							AtaChapterView = component.ATAChapterString,
							Title = component.PartNumber,
							Description = component.Description,
							FirstPerformance = component.LifeLimit != null ? component.LifeLimit.ToString() : "",
							RepeatInterval = "",
							WorkType = "Remove",
							NDT = "",
							PerfDate = wpView.PerfAfter.PerformDate.ToUniversalString(),
							MH = component.ManHours,
							KMH = component.ManHours * wp.KMH,
							Cost = component.Cost,
						};
					}
				}
			}

			var detDirWprs = res.Where(w => w.WorkPackageItemType == SmartCoreType.ComponentDirective.ItemId).ToList();
			if (detDirWprs.Count > 0)
			{
				var componentDirectiveIds = detDirWprs.Select(i => i.DirectivesId);
				var componentDirectives = await _db.ComponentDirectives
					.AsNoTracking()
					.Include(i => i.Component)
					.Include(i => i.Component.ATAChapter)
					.Where(i => componentDirectiveIds.Contains(i.Id))
					.ToListAsync();

				var componentDirectiveViews = componentDirectives.ToBlView();
				foreach (var adWpr in detDirWprs)
				{
					adWpr.WorkPakage = wpView;
					var directive = componentDirectiveViews.FirstOrDefault(i => i.Id == adWpr.DirectivesId);

					var first = "";
					if (directive.Threshold.FirstPerformanceSinceNew != null && !directive.Threshold.FirstPerformanceSinceNew.IsNullOrZero())
					{
						first = "s/n: " + directive.Threshold.FirstPerformanceSinceNew;
					}

					if (directive != null)
					{
						adWpr.Task = new WprTask()
						{
							Type = "Component Directive",
							AtaChapterView = directive.Component.ATAChapterString,
							Title = "",
							Description = directive.Remarks,
							FirstPerformance = first,
							RepeatInterval = directive.Threshold.RepeatInterval?.ToString(),
							WorkType = ComponentRecordType.GetItemById(directive.DirectiveType).ToString(),
							NDT = directive.NDTTypeString,
							PerfDate = wpView.PerfAfter.PerformDate.ToUniversalString(),
							MH = directive.ManHours,
							KMH = directive.ManHours * wp.KMH,
							Cost = directive.Cost,
						};
					}
				}
			}

			var maintCheckWprs =
				res.Where(w => w.WorkPackageItemType == SmartCoreType.MaintenanceCheck.ItemId).ToList();
			if (maintCheckWprs.Count > 0)
			{
				var mcIds = maintCheckWprs.Select(i => i.DirectivesId);
				var mcs = await _db.MaintenanceChecks
					.AsNoTracking()
					.Where(i => mcIds.Contains(i.Id))
					.ToListAsync();

				var componentDirectiveViews = mcs.ToBlView();
				foreach (var adWpr in maintCheckWprs)
				{
					adWpr.WorkPakage = wpView;
					var mc = componentDirectiveViews.FirstOrDefault(i => i.Id == adWpr.DirectivesId);

					if (mc != null)
					{
						adWpr.Task = new WprTask()
						{
							Type = "Maintenance Checks",
							AtaChapterView = "",
							Title = "",
							Description = mc.Name + (mc.Schedule ? " Shedule" : " Unshedule"),
							FirstPerformance = mc.Interval.ToString(),
							RepeatInterval = "",
							WorkType = "",
							NDT = "",
							PerfDate = wpView.PerfAfter.PerformDate.ToUniversalString(),
							MH = mc.ManHours,
							KMH = mc.ManHours * wp.KMH,
							Cost = mc.Cost,
						};
					}
				}
			}

			var mpdWprs = res.Where(w => w.WorkPackageItemType == SmartCoreType.MaintenanceDirective.ItemId).ToList();
			if (mpdWprs.Count > 0)
			{
				var mpdIds = mpdWprs.Select(i => i.DirectivesId);
				var mpds = await _db.MaintenanceDirectives
					.AsNoTracking()
					.Include(i => i.ATAChapter)
					.Where(i => mpdIds.Contains(i.Id))
					.ToListAsync();

				var componentDirectiveViews = mpds.ToBlView();
				foreach (var adWpr in mpdWprs)
				{
					adWpr.WorkPakage = wpView;
					var mpd = componentDirectiveViews.FirstOrDefault(i => i.Id == adWpr.DirectivesId);

					var first = "";
					if (mpd.Threshold.FirstPerformanceSinceNew != null && !mpd.Threshold.FirstPerformanceSinceNew.IsNullOrZero())
					{
						first = "s/n: " + mpd.Threshold.FirstPerformanceSinceNew;
					}
					if (mpd.Threshold.FirstPerformanceSinceEffectiveDate != null &&
						!mpd.Threshold.FirstPerformanceSinceEffectiveDate.IsNullOrZero())
					{
						if (first != "") first += " or ";
						else
						{
							first = "";
						}
						first += "s/e.d: " + mpd.Threshold.FirstPerformanceSinceEffectiveDate;
					}

					if (mpd != null)
					{
						adWpr.Task = new WprTask()
						{
							Type = "Maintenance Directive",
							AtaChapterView = mpd.AtaString,
							Title = $"{mpd.TaskCardNumber} {mpd.TaskNumberCheck} {mpd.Description}",
							Description = mpd.Description,
							FirstPerformance = first,
							RepeatInterval = mpd.Threshold.RepeatInterval?.ToString(),
							WorkType = mpd.WorkType.FullName,
							NDT = mpd.NDTType.ShortName,
							PerfDate = wpView.PerfAfter.PerformDate.ToUniversalString(),
							MH = mpd.ManHours,
							KMH = mpd.ManHours * wp.KMH,
							Cost = mpd.Cost,
						};
					}
				}
			}

			var nrjWprs = res.Where(w => w.WorkPackageItemType == SmartCoreType.NonRoutineJob.ItemId).ToList();
			if (nrjWprs.Count > 0)
			{
				var nrjIds = nrjWprs.Select(i => i.DirectivesId);
				var nrjs = await _db.NonRoutineJobs
					.AsNoTracking()
					.Include(i => i.ATAChapter)
					.Where(i => nrjIds.Contains(i.Id))
					.ToListAsync();

				var nrjViews = nrjs.ToBlView();

				foreach (var adWpr in nrjWprs)
				{
					adWpr.WorkPakage = wpView;
					var nrj = nrjViews.FirstOrDefault(i => i.Id == adWpr.DirectivesId);

					if (nrj != null)
					{
						adWpr.Task = new WprTask()
						{
							Type = "NonRoutineJobs",
							AtaChapterView = nrj.AtaString,
							Title = nrj.Title,
							Description = nrj.Description,
							FirstPerformance = "",
							RepeatInterval = "",
							WorkType = "",
							NDT = "",
							PerfDate = wpView.PerfAfter.PerformDate.ToUniversalString(),
							MH = nrj.ManHours,
							KMH = nrj.ManHours * wp.KMH,
							Cost = nrj.Cost,
						};
					}
				}
			}

			return res.OrderBy(i => i.Task?.Type).ToList();
		}

		private async Task CalculateMh(WorkPackageView view)
		{
			try
			{
				var res =  await _db.ManHourses.FromSql($@"select sum(Manhours) as ManHours 
			from (SELECT manhours 
				  FROM directives 
				  where directives.itemId in (select DirectivesId 
											  from Cas3WorkPakageRecord
											  where Cas3WorkPakageRecord.IsDeleted = 0 and 
													Cas3WorkPakageRecord.WorkPackageItemType = 1 and 
													Cas3WorkPakageRecord.WorkPakageId = {view.Id})
				  UNION ALL
				  SELECT manhours 
				  FROM components 
				  where components.itemId in (select DirectivesId 
											  from Cas3WorkPakageRecord
											  where Cas3WorkPakageRecord.IsDeleted = 0 and 
													Cas3WorkPakageRecord.WorkPackageItemType = 5 and 
													Cas3WorkPakageRecord.WorkPakageId = {view.Id})
				  UNION ALL
				  SELECT manhours 
				  FROM components 
				  where components.itemId in (select DirectivesId 
											  from Cas3WorkPakageRecord
											  where Cas3WorkPakageRecord.IsDeleted = 0 and 
													Cas3WorkPakageRecord.WorkPackageItemType = 6 and 
													Cas3WorkPakageRecord.WorkPakageId = {view.Id})
				  UNION ALL
				  SELECT manhours 
				  FROM componentdirectives 
				  where componentdirectives.ItemId in (select DirectivesId 
											  from Cas3WorkPakageRecord
											  where Cas3WorkPakageRecord.IsDeleted = 0 and 
													Cas3WorkPakageRecord.WorkPackageItemType = 2 and 
													Cas3WorkPakageRecord.WorkPakageId = {view.Id})
				  UNION ALL
				  SELECT manhours 
				  FROM Cas3MaintenanceCheck 
				  where Cas3MaintenanceCheck.itemId in (select DirectivesId 
											  from Cas3WorkPakageRecord
											  where Cas3WorkPakageRecord.IsDeleted = 0 and 
													Cas3WorkPakageRecord.WorkPackageItemType = 3 and 
													Cas3WorkPakageRecord.WorkPakageId = {view.Id})
				  UNION ALL
				  SELECT manhours 
				  FROM dictionaries.NonRoutineJobs 
				  where dictionaries.NonRoutineJobs.itemId in (select DirectivesId 
											  from Cas3WorkPakageRecord
											  where Cas3WorkPakageRecord.IsDeleted = 0 and 
													Cas3WorkPakageRecord.WorkPackageItemType = 4 and 
													Cas3WorkPakageRecord.WorkPakageId = {view.Id})

				  UNION ALL
				  SELECT manhours 
				  FROM MaintenanceDirectives
				  where MaintenanceDirectives.itemId in (select DirectivesId 
											  from Cas3WorkPakageRecord
											  where Cas3WorkPakageRecord.IsDeleted = 0 and 
													Cas3WorkPakageRecord.WorkPackageItemType = 14 and 
													Cas3WorkPakageRecord.WorkPakageId = {view.Id})) MH").ToListAsync();

				view.ManHours = res?.FirstOrDefault()?.ManHours ?? 0;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
	}
}