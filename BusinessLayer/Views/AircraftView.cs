using System;

namespace BusinessLayer.Views
{
    public class AircraftView : BaseView
    {
		public int AircraftFrameId { get; set; }

		public double APUFH { get; set; }

		public int OperatorID { get; set; }

		public int AircraftTypeID { get; set; }

		public int? ModelId { get; set; }

		public string TypeCertificateNumber { get; set; }

		public DateTime ManufactureDate { get; set; }

		public string RegistrationNumber { get; set; }

		public string SerialNumber { get; set; }

		public string VariableNumber { get; set; }

		public string LineNumber { get; set; }

		public string Owner { get; set; }

		public double? BasicEmptyWeight { get; set; }

		public double? BasicEmptyWeightCargoConfig { get; set; }

		public string CargoCapacityContainer { get; set; }

		public string Cruise { get; set; }

		public string CruiseFuelFlow { get; set; }

		public string FuelCapacity { get; set; }

		public string MaxCruiseAltitude { get; set; }

		public double? MaxLandingWeight { get; set; }

		public double? MaxPayloadWeight { get; set; }

		public double? MaxTakeOffCrossWeight { get; set; }

		public double? MaxTaxiWeight { get; set; }

		public double? MaxZeroFuelWeight { get; set; }

		public double? OperationalEmptyWeight { get; set; }

		public string CockpitSeating { get; set; }

		public string Galleys { get; set; }

		public string Lavatory { get; set; }

		public short? SeatingEconomy { get; set; }

		public short? SeatingBusiness { get; set; }

		public short? SeatingFirst { get; set; }

		public string Oven { get; set; }

		public string Boiler { get; set; }

		public string AirStairDoors { get; set; }

		public int? Tanks { get; set; }

		public string AircraftAddress24Bit { get; set; }

		public string ELTIdHexCode { get; set; }

		public DateTime? DeliveryDate { get; set; }

		public DateTime? AcceptanceDate { get; set; }

		public bool Schedule { get; set; }

		public MSG MSG { get; set; }

		public bool CheckNaming { get; set; }

		public int NoiceCategory { get; set; }

		public bool FADEC { get; set; }

		public int LandingCategory { get; set; }

		public bool EFIS { get; set; }

		public Brakes Brakes { get; set; }

		public bool Winglets { get; set; }

		public short? ApuUtizationPerFlightinMinutes { get; set; }
	}
}