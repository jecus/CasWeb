using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Extentions;
using Entity.Infrastructure;
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
	
			return res.OrderBy(i => i.WpWorkType).ToList();
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