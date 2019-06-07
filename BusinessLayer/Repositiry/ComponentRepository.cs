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

        public async Task<List<int>> GetAircraftBaseComponentIds(int aircraftId)
        {
	        var ids = await _db.Components
		        .AsNoTracking()
		        .OnlyActive()
		        .Where(i => i.IsBaseComponent && i.TransferRecords.OrderBy(t => t.TransferDate).FirstOrDefault(t => t.ParentID == i.Id).DestinationObjectID == aircraftId &&
		                    i.TransferRecords.OrderBy(t => t.TransferDate).FirstOrDefault(t => t.ParentID == i.Id).DestinationObjectType == 7)
		        .Select(i => i.Id)
		        .ToListAsync();

	        return ids;
        }

		public async Task<List<BaseComponentView>> GetAircraftBaseComponents(int aircraftId)
        {
	        var baseComponents = await _db.Components
		        .AsNoTracking()
		        .OnlyActive()
		        .Where(i => i.IsBaseComponent && i.TransferRecords.OrderBy(t => t.TransferDate).FirstOrDefault(t => t.ParentID == i.Id).DestinationObjectID == aircraftId &&
		                    i.TransferRecords.OrderBy(t => t.TransferDate).FirstOrDefault(t => t.ParentID == i.Id).DestinationObjectType == 7)
		        .Include(i => i.TransferRecords)
		        .Include(i => i.Model)
		        .ToListAsync();

	        return baseComponents.ToBaseComponentView();
        }

		public async Task<List<ComponentView>> GetStoreComponent(int storeId)
		{
			var stores = await _db.Stores.AsNoTracking()
				.FirstOrDefaultAsync(i => i.Id == storeId);

			var transferRecordId = await _db.TransferRecords
				.Where(i => i.DestinationObjectType == SmartCoreType.Store.ItemId && i.DestinationObjectID == storeId)
				.Select(i => i.ParentID).ToListAsync();

			var components = await _db.Components
				.OnlyActive()
				.AsNoTracking()
				.Include(i => i.ATAChapter)
				.Include(i => i.Model)
				.Include(i => i.Product)
				.Include(i => i.Model.ATAChapter)
				.Include(i => i.Product.ATAChapter)
				.Include(i => i.Location)
				.Include(i => i.Location.LocationsType)
				.Include(i => i.SupplierRelations)
				.Include(i => i.TransferRecords)
				.Include(i => i.FromSupplier)
				.Where(i => transferRecordId.Contains(i.Id))
				.ToListAsync();

			var compIds = components.Select(i => i.Id).ToArray();

			var documents = await _db.Documents
				.Where(i => i.ParentTypeId == SmartCoreType.Component.ItemId && compIds.Contains(i.ParentID.Value))
				.ToListAsync();

			var documentsView = documents.ToBlView();

			var docIds = documents.Select(i => i.Id);
			var fileLinks = await _db.ItemFileLinks
				.AsNoTracking()
				.Where(i => i.ParentTypeId == SmartCoreType.Document.ItemId && docIds.Contains(i.ParentId))
				.ToListAsync();

			foreach (var documentView in documentsView)
				documentView.ItemFileLink = fileLinks.FirstOrDefault(i => i.ParentId == documentView.Id);

			var ids = components.Select(i => i.Id);
			var componentLinks = await _db.ItemFileLinks
				.AsNoTracking()
				.Where(i => ids.Contains(i.ParentId) && i.ParentTypeId == SmartCoreType.Component.ItemId)
				.ToListAsync();

			var crs = await _db.DocumentSubTypes.AsNoTracking().FirstOrDefaultAsync(i => i.Name == "Component CRS Form");
			var shipping = await _db.DocumentSubTypes.AsNoTracking().FirstOrDefaultAsync(i => i.Name == "Shipping document");

			var storeView = stores.ToBlView();
			var result = components.ToBlView();

			foreach (var componentView in result)
			{
				componentView.Files.AddRange(componentLinks.Where(i => i.ParentId == componentView.Id));
				SetDestinations(componentView, new List<StoreView>(){ storeView });


				if (componentView.GoodsClass.IsNodeOrSubNodeOf(GoodsClass.MaintenanceMaterials) ||
					componentView.GoodsClass.IsNodeOrSubNodeOf(GoodsClass.Tools) ||
					componentView.GoodsClass.IsNodeOrSubNodeOf(GoodsClass.Protection))
				{
					componentView.ShippingFileId = componentView.Files.GetFileIdByFileLinkType(FileLinkType.IncomingFile) ?? -1;
					componentView.CRSFileId = componentView.Files.GetFileIdByFileLinkType(FileLinkType.FaaFormFile) ?? -1;
				}
				else
				{
					var docShipping = documentsView.FirstOrDefault(d =>
						d.ParentID == componentView.Id && d.ParentTypeId == SmartCoreType.Component.ItemId &&
						d.SubTypeId == shipping.Id);
					if (docShipping != null)
						componentView.ShippingFileId = docShipping.ItemFileLink?.FileId ?? -1;

					var docCrs = documentsView.FirstOrDefault(d =>
						d.ParentID == componentView.Id &&
						d.ParentTypeId == SmartCoreType.Component.ItemId &&
						d.SubTypeId == crs.Id);
					if (docCrs != null)
						componentView.CRSFileId = docCrs.ItemFileLink?.FileId ?? -1;
				}
			}

			await _stockCalculator.CalculateStock(result, new List<int>{ storeView.Id});

			return result;
		}

		public async Task<List<ComponentView>> GetAllStoreComponent()
        {
	        var stores = await _db.Stores
		        .AsNoTracking()
		        .ToListAsync();

			var transferRecordId = await _db.TransferRecords
				.Where(i => i.DestinationObjectType == SmartCoreType.Store.ItemId)
				.Select(i => i.ParentID).ToListAsync();

			var components = await _db.Components
				.OnlyActive()
				.AsNoTracking()
				.Include(i => i.Location)
				.Include(i => i.ATAChapter)
				.Include(i => i.Location.LocationsType)
				.Include(i => i.SupplierRelations)
				.Include(i => i.TransferRecords)
				.Include(i => i.FromSupplier)
				.Where(i => transferRecordId.Contains(i.Id))
				.ToListAsync();


			var documents = await _db.Documents
				.Where(i => i.ParentTypeId == SmartCoreType.Component.ItemId)
				.ToListAsync();

			var documentsView = documents.ToBlView();

			var docIds = documents.Select(i => i.Id);
			var fileLinks = await _db.ItemFileLinks
				.AsNoTracking()
				.Where(i => i.ParentTypeId == SmartCoreType.Document.ItemId && docIds.Contains(i.ParentId))
				.ToListAsync();

			foreach (var documentView in documentsView)
				documentView.ItemFileLink = fileLinks.FirstOrDefault(i => i.ParentId == documentView.Id);

			var ids = components.Select(i => i.Id);
			var componentLinks = await _db.ItemFileLinks
				.AsNoTracking()
				.Where(i => ids.Contains(i.ParentId) && i.ParentTypeId == SmartCoreType.Component.ItemId)
				.ToListAsync();

			var crs = await _db.DocumentSubTypes.AsNoTracking().FirstOrDefaultAsync(i => i.Name == "Component CRS Form");
			var shipping = await _db.DocumentSubTypes.AsNoTracking().FirstOrDefaultAsync(i => i.Name == "Shipping document");

			var storeView = stores.ToBlView();
			var result = components.ToBlView();

			foreach (var componentView in result)
			{
				componentView.Files.AddRange(componentLinks.Where(i => i.ParentId == componentView.Id));
				SetDestinations(componentView, storeView);


				if (componentView.GoodsClass.IsNodeOrSubNodeOf(GoodsClass.MaintenanceMaterials) ||
					componentView.GoodsClass.IsNodeOrSubNodeOf(GoodsClass.Tools) ||
					componentView.GoodsClass.IsNodeOrSubNodeOf(GoodsClass.Protection))
				{
					componentView.ShippingFileId = componentView.Files.GetFileIdByFileLinkType(FileLinkType.IncomingFile) ?? -1;
					componentView.CRSFileId = componentView.Files.GetFileIdByFileLinkType(FileLinkType.FaaFormFile) ?? -1;
				}
				else
				{
					var docShipping = documentsView.FirstOrDefault(d =>
						d.ParentID == componentView.Id && d.ParentTypeId == SmartCoreType.Component.ItemId &&
						d.SubTypeId == shipping.Id);
					if (docShipping != null)
						componentView.ShippingFileId = docShipping.ItemFileLink?.FileId ?? -1;

					var docCrs = documentsView.FirstOrDefault(d =>
						d.ParentID == componentView.Id &&
						d.ParentTypeId == SmartCoreType.Component.ItemId &&
						d.SubTypeId == crs.Id);
					if (docCrs != null)
						componentView.CRSFileId = docCrs.ItemFileLink?.FileId ?? -1;
				}
			}

			await _stockCalculator.CalculateStock(result, stores.Select(i => i.Id).ToList());

			return result;
		}

		private void SetDestinations(ComponentView component, List<StoreView> storeViews)
        {
            var lastTransfer = component.TransferRecords
                .OrderBy(i => i.TransferDate)
                .LastOrDefault();

            if (lastTransfer == null)
            {
                var msg = $"Component {component.Id} has no transfer records";
                //_logger.LogError(msg);
                throw new Exception(msg);
            }

            if (lastTransfer.DestinationType == SmartCoreType.Store)
            {
                var store = storeViews.FirstOrDefault(i => i.Id == lastTransfer.DestinationObjectID);
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