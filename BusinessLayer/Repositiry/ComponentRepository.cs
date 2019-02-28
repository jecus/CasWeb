using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Dictionaties;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Extentions;
using Entity.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Repositiry
{
    public class ComponentRepository : IComponentRepository
    {
        private readonly DatabaseContext _db;
        private readonly IStockCalculator _stockCalculator;

        public ComponentRepository(DatabaseContext db, IStockCalculator stockCalculator)
        {
	        _db = db;
	        _stockCalculator = stockCalculator;
        }

        public async Task<List<ComponentView>> GetAllStoreComponent()
        {
            var transferRecordId = await _db.TransferRecords
                .Where(i => i.DestinationObjectType == SmartCoreType.Store.ItemId)
                .Select(i => i.ParentID).ToListAsync();

            var components = await _db.Components
                .OnlyActive()
                .AsNoTracking()
                .Include(i => i.Location)
                .Include(i => i.Location.LocationsType)
                .Include(i => i.SupplierRelations)
                .Include(i => i.TransferRecords)
                .Include(i => i.FromSupplier)
                .Where(i => transferRecordId.Contains(i.ItemId))
                .ToListAsync();


            var stores = await _db.Stores
                .AsNoTracking()
                .ToListAsync();

            var documents = await _db.Documents
	            .Where(i => i.ParentTypeId == SmartCoreType.Component.ItemId)
	            .ToListAsync();

            var crs = await _db.DocumentSubTypes.AsNoTracking().FirstOrDefaultAsync(i => i.Name == "Component CRS Form");
            var shipping = await _db.DocumentSubTypes.AsNoTracking().FirstOrDefaultAsync(i => i.Name == "Shipping document");

            var storeView = stores.ToBlView();
            var result = components.ToBlView();

			foreach (var componentView in result)
            {
                SetDestinations(componentView, storeView);

                var docShipping = documents.FirstOrDefault(d =>
	                d.ParentID == componentView.ItemId && d.ParentTypeId == SmartCoreType.Component.ItemId &&
	                d.SubTypeId == shipping.ItemId);
                if (docShipping != null)
	                componentView.DocumentShippingId = docShipping.ItemId;

                var docCrs = documents.FirstOrDefault(d =>
	                d.ParentID == componentView.ItemId && 
	                d.ParentTypeId == SmartCoreType.Component.ItemId && 
	                d.SubTypeId == crs.ItemId);
                if (docCrs != null)
	                componentView.DocumentCRSId = docCrs.ItemId;
			}

			await _stockCalculator.CalculateStock(result, stores.Select(i => i.ItemId).ToList());


			return result;
        }

        private void SetDestinations(ComponentView component, List<StoreView> storeViews)
        {
            var lastTransfer = component.TransferRecords
                .OrderBy(i => i.TransferDate)
                .LastOrDefault();

            if (lastTransfer == null)
            {
                var msg = $"Component {component.ItemId} has no transfer records";
                //_logger.LogError(msg);
                throw new Exception(msg);
            }

            if (lastTransfer.DestinationType == SmartCoreType.Store)
            {
                var store = storeViews.FirstOrDefault(i => i.ItemId == lastTransfer.DestinationObjectID);
                if (store == null)
                {
                    var msg = $"Destination object ID:{lastTransfer.DestinationObjectID} was not found";
                   // _logger.LogError(msg);
                    throw new Exception(msg);
                }
                component.ParentStore = store;
            }
                
        }
    }
}