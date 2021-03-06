﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLayer.Views;

namespace BusinessLayer.Repositiry.Interfaces
{
	public interface IWorkPackageRepository
	{
		Task<List<WorkPackageView>> GetWorkPackages(List<int> aircraftIds);
		Task<List<WorkPackageRecordView>> GetWorkPackageRecordsTask(int wpId);
	}
}