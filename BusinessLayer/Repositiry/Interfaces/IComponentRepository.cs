﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLayer.Views;

namespace BusinessLayer.Repositiry.Interfaces
{
    public interface IComponentRepository
    {
	    Task<List<BaseComponentView>> GetAircraftBaseComponents(int aircraftId);

		Task<List<ComponentView>> GetAllStoreComponent();
        Task<List<ComponentView>> GetStoreComponent(int storeId);
    }
}