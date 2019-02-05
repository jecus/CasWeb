using System.Collections.Generic;

namespace WebDevelopment.Helper
{
    public class AircraftMainMenu : StaticMenu
    {
        public static List<AircraftMainMenu> Items = new List<AircraftMainMenu>();

        #region Constructor

        public AircraftMainMenu(int order, string header, string url)
        {
            Order = order;
            Header = header;
            Url = url;
        }

        public AircraftMainMenu(int order, string header, string url, string icon, IEnumerable<AircraftMainMenu> subMenu)
        {
            Order = order;
            Header = header;
            Url = url;
            SubMenu = subMenu;
            Icon = icon;

            Items.Add(this);
        }

        #endregion

        private static AircraftMainMenu GeneralInf = new AircraftMainMenu(1, "General Information", "#!", "feather icon-clipboard", subMenu: new List<AircraftMainMenu>()
        {
            new AircraftMainMenu(1, "Aircraft Summary", "#!"),
            new AircraftMainMenu(2, "Documents", "#!")

        });

        private static AircraftMainMenu Components = new AircraftMainMenu(2, "Components", "#!", "feather icon-clipboard", subMenu: new List<AircraftMainMenu>()
        {
            new AircraftMainMenu(1, "Avionics Inventory", "#!"),
            new AircraftMainMenu(2, "Component Tracking", "#!"),
            new AircraftMainMenu(3, "Component Change Status", "#!"),
            new AircraftMainMenu(4, "Landing Gear Status", "#!")

        });
        
        private static AircraftMainMenu Directives = new AircraftMainMenu(3, "Directives", "#!", "feather icon-clipboard", subMenu: new List<AircraftMainMenu>()
        {
            new AircraftMainMenu(1, "Modification Status", "#!"),
            new AircraftMainMenu(2, "Out of Phase Requirements", "#!")

        });

        private static AircraftMainMenu Discrepancies = new AircraftMainMenu(4, "Discrepancies", "#!", "feather icon-clipboard", subMenu: new List<AircraftMainMenu>()
        {
            new AircraftMainMenu(1, "Discrepancies Status", "#!"),
            new AircraftMainMenu(2, "Damages", "#!"),
            new AircraftMainMenu(2, "Deferred Items", "#!")

        });

        private static AircraftMainMenu MaintenanceProg = new AircraftMainMenu(5, "Maintenance Program", "#!", "feather icon-clipboard", subMenu: new List<AircraftMainMenu>()
        {
            new AircraftMainMenu(1, "MTOP", "#!"),
            new AircraftMainMenu(2, "Routine Tasks", "#!"),
            new AircraftMainMenu(3, "Non-Routine Tasks", "#!"),
            new AircraftMainMenu(4, "Non-Routine Status", "#!")

        });

        private static AircraftMainMenu Planning = new AircraftMainMenu(6, "Planning", "#!", "feather icon-clipboard", subMenu: new List<AircraftMainMenu>()
        {
            new AircraftMainMenu(1, "ATLBs", "#!"),
            new AircraftMainMenu(2, "Forecast MTOP Report", "#!"),
            new AircraftMainMenu(3, "Forecast Report Kits", "#!"),
            new AircraftMainMenu(4, "Monthly Utilization", "#!"),
            new AircraftMainMenu(5, "Work Packages", "#!")

        });

        private static AircraftMainMenu Purchase = new AircraftMainMenu(7, "Purchase", "#!", "feather icon-clipboard", subMenu: new List<AircraftMainMenu>()
        {
            new AircraftMainMenu(1, "Equipment and Materials", "#!"),
            new AircraftMainMenu(2, "Initial Orders", "#!"),
            new AircraftMainMenu(3, "Purchase Orders", "#!"),
            new AircraftMainMenu(4, "Quotation Orders", "#!")

        });

        private static AircraftMainMenu SMS = new AircraftMainMenu(7, "SMS", "#!", "feather icon-clipboard", subMenu: new List<AircraftMainMenu>()
        {
            new AircraftMainMenu(1, "Events", "#!")

        });
    }
}