using System.Collections.Generic;
using BusinessLayer;
using BusinessLayer.Dictionaties;
using Microsoft.AspNetCore.Mvc;
using WebDevelopment.Infrastructude;

namespace WebDevelopment.Helper
{
    public class AircraftMainMenu : StaticMenu
    {
        public List<AircraftMainMenu> Items = new List<AircraftMainMenu>();

        #region Constructor

        public AircraftMainMenu(IUrlHelper url, int aircraftId)
        {
            Items.AddRange(new[]
            {
                new AircraftMainMenu(1, "General Information", "#!", "feather icon-clipboard",
                    subMenu: new List<AircraftMainMenu>()
                    {
                        new AircraftMainMenu(1, "Aircraft Summary", "#!"),
                        new AircraftMainMenu(2, "Documents", "#!")

                    }),

                new AircraftMainMenu(2, "Components", "#!", "feather icon-clipboard", subMenu: new List<AircraftMainMenu>()
                {
                    new AircraftMainMenu(1, "Avionics Inventory", "#!"),
                    new AircraftMainMenu(2, "Component Tracking", "#!"),
                    new AircraftMainMenu(3, "Component Change Status", "#!"),
                    new AircraftMainMenu(4, "Landing Gear Status", "#!")

                }),

                new AircraftMainMenu(3, "Directives", "#!", "feather icon-clipboard", subMenu: new List<AircraftMainMenu>()
                {
                    new AircraftMainMenu(1, "AD Status All", url.Action("All","Directive", new {GlobalObject.AircraftId, directiveType = DirectiveType.AirworthenessDirectives.ItemId})),
                    new AircraftMainMenu(2, "AD Status AF",  url.Action("All","Directive", new {GlobalObject.AircraftId, directiveType = DirectiveType.AirworthenessDirectives.ItemId, adType = ADType.Airframe})),
                    new AircraftMainMenu(3, "AD Status AP",  url.Action("All","Directive", new {GlobalObject.AircraftId, directiveType = DirectiveType.AirworthenessDirectives.ItemId, adType = ADType.Apliance})),
                    new AircraftMainMenu(5, "EO Status", url.Action("Eo","Directive", new {GlobalObject.AircraftId, directiveType = DirectiveType.EngineeringOrders.ItemId})),
                    new AircraftMainMenu(6, "SB Status", url.Action("Sb","Directive", new {GlobalObject.AircraftId, directiveType = DirectiveType.SB.ItemId}))

                }),

                new AircraftMainMenu(4, "Discrepancies", "#!", "feather icon-clipboard", subMenu: new List<AircraftMainMenu>()
                {
                    new AircraftMainMenu(1, "Discrepancies Status", "#!"),
                    new AircraftMainMenu(2, "Damages", "#!"),
                    new AircraftMainMenu(2, "Deferred Items", "#!")

                }),

                new AircraftMainMenu(5, "Maintenance Program", "#!", "feather icon-clipboard", subMenu: new List<AircraftMainMenu>()
                {
                    new AircraftMainMenu(1, "MTOP", "#!"),
                    new AircraftMainMenu(2, "Routine Tasks", url.Action("Index","MaintenanceDirective",new {GlobalObject.AircraftId})),
                    new AircraftMainMenu(3, "Non-Routine Tasks", "#!"),
                    new AircraftMainMenu(4, "Non-Routine Status", "#!")

                }),

                new AircraftMainMenu(6, "Planning", "#!", "feather icon-clipboard", subMenu: new List<AircraftMainMenu>()
                {
                    new AircraftMainMenu(1, "ATLB Event", url.Action("AtlbEvent", "ATLB", new {GlobalObject.AircraftId})),
                    new AircraftMainMenu(1, "ATLBs", url.Action("Index", "ATLB", new {GlobalObject.AircraftId})),
                    new AircraftMainMenu(2, "Forecast MTOP Report", "#!"),
                    new AircraftMainMenu(3, "Forecast Report Kits", "#!"),
                    new AircraftMainMenu(4, "Monthly Utilization", "#!"),
                    new AircraftMainMenu(5, "Work Packages", url.Action("Index","WorkPackage", new {GlobalObject.AircraftId}))

                }),

                new AircraftMainMenu(7, "Purchase", "#!", "feather icon-clipboard", subMenu: new List<AircraftMainMenu>()
                {
                    new AircraftMainMenu(1, "Equipment and Materials", "#!"),
                    new AircraftMainMenu(2, "Initial Orders", "#!"),
                    new AircraftMainMenu(3, "Purchase Orders", "#!"),
                    new AircraftMainMenu(4, "Quotation Orders", "#!")

                }),

                new AircraftMainMenu(7, "SMS", "#!", "feather icon-clipboard", subMenu: new List<AircraftMainMenu>()
                {
                    new AircraftMainMenu(1, "Events", "#!")

                })
        });
        }

        private AircraftMainMenu(int order, string header, string url)
        {
            Order = order;
            Header = header;
            Url = url;
        }

        private AircraftMainMenu(int order, string header, string url, string icon, IEnumerable<AircraftMainMenu> subMenu)
        {
            Order = order;
            Header = header;
            Url = url;
            SubMenu = subMenu;
            Icon = icon;

            //Items.Add(this);
        }

        #endregion
        
    }
}