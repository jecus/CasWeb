using System.Linq;
using BusinessLayer;
using BusinessLayer.Dictionaties;
using BusinessLayer.Views;

namespace WebDevelopment.Infrastructude
{
	public static class GridViewGroupHelper
	{
		public static string GetGroupString(object tag)
		{
			var temp = "";

			IBaseView parent;
			if (tag is IBaseView)
				parent = (IBaseView)tag;
			else parent = null;


			if (parent is DirectiveView)
			{
				var directive = (DirectiveView)parent;
				temp = getDirectiveGroupString(directive);
			}
			else if (parent is BaseComponentView)
			{
				var baseComponent = parent as BaseComponentView;
				temp = getBaseComponentGroup(baseComponent);
			}
			else if (parent is ComponentView)
			{
				var component = parent as ComponentView;
				temp = getComponentGroupString(component);
			}
			else if (parent is ComponentDirectiveView)
			{
				var dd = (ComponentDirectiveView)parent;
				temp = getComponentDirectiveGroupString(dd);
			}
			else if (parent is MaintenanceCheckView)
			{
				var mc = (MaintenanceCheckView)parent;
				temp = getMaintenanceCheckGroupString(mc);
			}
			else if (parent is MaintenanceDirectiveView)
			{
				var md = (MaintenanceDirectiveView)parent;
				temp = getMaintenanceDirectiveGroupString(md);
			}
			else if (tag is NonRoutineJobView)
			{
				temp = "Non-Routine Jobs";
			}

			return temp;
		}

		private static string getMaintenanceCheckGroupString(MaintenanceCheckView maintenanceCheck)
		{
			var currentDestination = GetDestinationStringFromAircraft(maintenanceCheck.ParentAircraft, false, null);
			return $"{currentDestination} | Maintenance checks {(maintenanceCheck.Schedule ? "Schedule" : "Store")}";
		}

		private static string getComponentDirectiveGroupString(ComponentDirectiveView componentDirective)
		{
			string res;

			if (componentDirective.Component != null)
			{
				var title = string.Format("P/N:{0} {1} Pos:{2} S/N:{3}",
					componentDirective.Component.PartNumber,
					componentDirective.Component.Description,
					componentDirective.Component.PositionString,
					componentDirective.Component.SerialNumber);

				//var parentStore = GlobalObjects.StoreCore.GetStoreById(componentDirective.ParentComponent.ParentStoreId);
				var last = componentDirective.Component.TransferRecords.GetLast();
				var bc = GlobalObject.BaseComponent.FirstOrDefault(i => i.Id == last.DestinationObjectID);

				if (bc.ParentAircraftId > 0)
				{
					var currentDestination = GetDestinationStringFromAircraft(bc.ParentAircraftId, false,
						null);
					res = $"{currentDestination} | {title} | Component directives";
				}
				//else if (parentStore != null)
				//	res = $"{parentStore} | {title} | Component directives";
				else res = title + " | Component directives";
			}
			else res = "Component Directives";

			return res;
		}

		private static string getComponentGroupString(ComponentView component)
		{
			var last = component.TransferRecords.GetLast();
			var bc = GlobalObject.BaseComponent.FirstOrDefault(i => i.Id == last.DestinationObjectID);

			var currentDestination = GetDestinationStringFromAircraft(bc.ParentAircraftId, false, null);
			return bc != null ? $"{currentDestination} | {bc} | Components" : "Components";
		}

		private static string getBaseComponentGroup(BaseComponentView baseComponent)
		{
			var currentDestination = GetDestinationStringFromAircraft(baseComponent.ParentAircraftId, false, null);
			return $"{currentDestination} {baseComponent.BaseComponentType} . Component PN {baseComponent.PartNumber}";
		}

		private static string getDirectiveGroupString(DirectiveView directive)
		{
			var res = "";

			var bc = GlobalObject.BaseComponent.FirstOrDefault(i => i.Id == directive.BaseComponentId);

			var currentDestination = bc.ParentAircraftId > 0
				? GetDestinationStringFromAircraft(bc.ParentAircraftId, false,
					bc.Id)
				: GetDestinationStringFromStore(bc.ParentStoreId,
					bc.Id, false);

			if (directive.DirectiveType == DirectiveType.DeferredItems)
				res = $"{currentDestination} | Deffred";
			else if (directive.DirectiveType == DirectiveType.DamagesRequiring)
				res = $"{currentDestination} | Damage";
			else if (directive.DirectiveType == DirectiveType.OutOfPhase)
				res = $"{currentDestination} | Out of phase";
			else
			{
				if (directive.DirectiveType.ItemId == DirectiveType.AirworthenessDirectives.ItemId)
					res = $"{currentDestination} | AD";
				else if (directive.DirectiveType.ItemId == DirectiveType.EngineeringOrders.ItemId)
					res = $"{currentDestination} | Engineering orders";
				else if (directive.DirectiveType.ItemId == DirectiveType.SB.ItemId)
					res = $"{currentDestination} | Service bulletins";
			}

			return res;
		}

		private static string getMaintenanceDirectiveGroupString(MaintenanceDirectiveView maintenanceDirective)
		{
			var bc = GlobalObject.BaseComponent.FirstOrDefault(i => i.Id == maintenanceDirective.ComponentId);
			return bc + " | MPD";
		}


		#region Destination

		public static string GetDestinationStringFromAircraft(int aircraftId, bool includeFrame, int? baseComponentId, char separator = '|')
		{
			var parentAircraft = GlobalObject.Aircraft;
			if (parentAircraft == null)
				return "Can not find aircraft";

			var aircraftFrame = GlobalObject.BaseComponent.FirstOrDefault(i => i.Id == parentAircraft.AircraftFrameId);
			var result = includeFrame ? $"{parentAircraft.RegistrationNumber} {separator} {aircraftFrame} "
				: parentAircraft.RegistrationNumber;

			if (baseComponentId.HasValue)
			{
				var baseComponent = GlobalObject.BaseComponent.FirstOrDefault(i => i.Id == baseComponentId.Value);
				return $"{result} {separator} {baseComponent} ";
			}

			return result;
		}

		public static string GetDestinationStringFromStore(int storeId, int? baseComponentId, bool includeStoreName, char separator = '|')
		{
			return "";
			//var parentStore = GlobalObjects.StoreCore.GetStoreById(storeId);

			//var result = includeStoreName ? $"{parentStore.Name} {separator} {parentStore.Location}" : parentStore.Location;

			//if (baseComponentId.HasValue)
			//{
			//	var baseComponent = GlobalObjects.ComponentCore.GetBaseComponentById(baseComponentId.Value);
			//	return $"{result} {separator} {baseComponent} ";
			//}

			//return result;
		}

		#endregion
	}
}