using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebDevelopment.Helper
{
    public class AircraftMainMenu : StaticMenu
    {
        public readonly int _aircraftId;
        public List<AircraftMainMenu> Items = new List<AircraftMainMenu>();

        #region Constructor

        public AircraftMainMenu(IUrlHelper url, int aircraftId)
        {
            _aircraftId = aircraftId;
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
                    new AircraftMainMenu(1, "Modification Status", "#!"),
                    new AircraftMainMenu(2, "Out of Phase Requirements", "#!")

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
                    new AircraftMainMenu(2, "Routine Tasks", "#!"),
                    new AircraftMainMenu(3, "Non-Routine Tasks", "#!"),
                    new AircraftMainMenu(4, "Non-Routine Status", "#!")

                }),

                new AircraftMainMenu(6, "Planning", "#!", "feather icon-clipboard", subMenu: new List<AircraftMainMenu>()
                {
                    new AircraftMainMenu(1, "ATLBs", url.Action("Index", "ATLB", new {aircraftId})),
                    new AircraftMainMenu(2, "Forecast MTOP Report", "#!"),
                    new AircraftMainMenu(3, "Forecast Report Kits", "#!"),
                    new AircraftMainMenu(4, "Monthly Utilization", "#!"),
                    new AircraftMainMenu(5, "Work Packages", "#!")

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