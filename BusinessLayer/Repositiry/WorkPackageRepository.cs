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
					if (directive != null)
					{
						adWpr.Task = new WprTask()
						{
							Type = "Directive",
							AtaChapterView = directive.ATAChapter,
							Title = $"{directive.EngineeringOrders} {directive.Title}",
							Description = directive.Description,
							FirstPerformance = Lifelength.Null,
							RepeatInterval = Lifelength.Null,
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
				var componentIds = adWprs.Select(i => i.DirectivesId);
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
							AtaChapterView = component.ATAChapter,
							Title = component.PartNumber,
							Description = component.Description,
							FirstPerformance = Lifelength.Null,
							RepeatInterval = Lifelength.Null,
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
				var componentIds = adWprs.Select(i => i.DirectivesId);
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
							AtaChapterView = component.ATAChapter,
							Title = component.PartNumber,
							Description = component.Description,
							FirstPerformance = Lifelength.Null,
							RepeatInterval = Lifelength.Null,
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
				var componentDirectiveIds = adWprs.Select(i => i.DirectivesId);
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
					if (directive != null)
					{
						adWpr.Task = new WprTask()
						{
							Type = "Component Directive",
							AtaChapterView = directive.Component.ATAChapter,
							Title = "",
							Description = directive.Remarks,
							FirstPerformance = Lifelength.Null,
							RepeatInterval = Lifelength.Null,
							WorkType = "",
							NDT = NDTType.GetItemById(directive.NDTType).ShortName,
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

			}

			var mpdWprs = res.Where(w => w.WorkPackageItemType == SmartCoreType.MaintenanceDirective.ItemId).ToList();
			if (mpdWprs.Count > 0)
			{
				var mpdIds = adWprs.Select(i => i.DirectivesId);
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
					if (mpd != null)
					{
						adWpr.Task = new WprTask()
						{
							Type = "Maintenance Directive",
							AtaChapterView = mpd.ATAChapter,
							Title = $"{mpd.TaskCardNumber} {mpd.TaskNumberCheck} {mpd.Description}",
							Description = mpd.Description,
							FirstPerformance = Lifelength.Null,
							RepeatInterval = Lifelength.Null,
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

			}

			return res;
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