using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;

namespace BusinessLayer.Mapping
{
    public class AircraftProfile : Profile
    {
        public AircraftProfile()
        {
            CreateMap<AircraftView, Aircraft>()
                .ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
                .ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
                .ForMember(dst => dst.RegistrationNumber, src => src.MapFrom(x => x.RegistrationNumber))
                .ForMember(dst => dst.APUFH, src => src.MapFrom(x => x.APUFH))
                .ForMember(dst => dst.OperatorID, src => src.MapFrom(x => x.OperatorID))
                .ForMember(dst => dst.AircraftTypeID, src => src.MapFrom(x => x.AircraftTypeID))
                .ForMember(dst => dst.TypeCertificateNumber, src => src.MapFrom(x => x.TypeCertificateNumber))
                .ForMember(dst => dst.ManufactureDate, src => src.MapFrom(x => x.ManufactureDate))
                .ForMember(dst => dst.SerialNumber, src => src.MapFrom(x => x.SerialNumber))
                .ForMember(dst => dst.VariableNumber, src => src.MapFrom(x => x.VariableNumber))
                .ForMember(dst => dst.LineNumber, src => src.MapFrom(x => x.LineNumber))
                .ForMember(dst => dst.Owner, src => src.MapFrom(x => x.Owner))
                .ForMember(dst => dst.CargoCapacityContainer, src => src.MapFrom(x => x.CargoCapacityContainer))
                .ForMember(dst => dst.Cruise, src => src.MapFrom(x => x.Cruise))
                .ForMember(dst => dst.CruiseFuelFlow, src => src.MapFrom(x => x.CruiseFuelFlow))
                .ForMember(dst => dst.FuelCapacity, src => src.MapFrom(x => x.FuelCapacity))
                .ForMember(dst => dst.MaxCruiseAltitude, src => src.MapFrom(x => x.MaxCruiseAltitude))
                .ForMember(dst => dst.CockpitSeating, src => src.MapFrom(x => x.CockpitSeating))
                .ForMember(dst => dst.Galleys, src => src.MapFrom(x => x.Galleys))
                .ForMember(dst => dst.Lavatory, src => src.MapFrom(x => x.Lavatory))
                .ForMember(dst => dst.Oven, src => src.MapFrom(x => x.Oven))
                .ForMember(dst => dst.Boiler, src => src.MapFrom(x => x.Boiler))
                .ForMember(dst => dst.AirStairDoors, src => src.MapFrom(x => x.AirStairDoors))
                .ForMember(dst => dst.AircraftAddress24Bit, src => src.MapFrom(x => x.AircraftAddress24Bit))
                .ForMember(dst => dst.ELTIdHexCode, src => src.MapFrom(x => x.ELTIdHexCode))
                .ForMember(dst => dst.DeliveryDate, src => src.MapFrom(x => x.DeliveryDate))
                .ForMember(dst => dst.AcceptanceDate, src => src.MapFrom(x => x.AcceptanceDate))
                .ForMember(dst => dst.Schedule, src => src.MapFrom(x => x.Schedule))
                .ForMember(dst => dst.MSG, src => src.MapFrom(x => x.MSG))
                .ForMember(dst => dst.CheckNaming, src => src.MapFrom(x => x.CheckNaming))
                .ForMember(dst => dst.NoiceCategory, src => src.MapFrom(x => x.NoiceCategory))
                .ForMember(dst => dst.FADEC, src => src.MapFrom(x => x.FADEC))
                .ForMember(dst => dst.LandingCategory, src => src.MapFrom(x => x.LandingCategory))
                .ForMember(dst => dst.EFIS, src => src.MapFrom(x => x.EFIS))
                .ForMember(dst => dst.Brakes, src => src.MapFrom(x => x.Brakes))
                .ForMember(dst => dst.Winglets, src => src.MapFrom(x => x.Winglets))
                .ForMember(dst => dst.ApuUtizationPerFlightinMinutes, src => src.MapFrom(x => x.ApuUtizationPerFlightinMinutes))
                .ForMember(dst => dst.BasicEmptyWeight, src => src.MapFrom(x => x.BasicEmptyWeight ?? default(double)))
                .ForMember(dst => dst.MaxLandingWeight, src => src.MapFrom(x => x.MaxLandingWeight ?? default(double)))
                .ForMember(dst => dst.MaxPayloadWeight, src => src.MapFrom(x => x.MaxPayloadWeight ?? default(double)))
                .ForMember(dst => dst.MaxTakeOffCrossWeight, src => src.MapFrom(x => x.MaxTakeOffCrossWeight ?? default(double)))
                .ForMember(dst => dst.MaxTaxiWeight, src => src.MapFrom(x => x.MaxTaxiWeight ?? default(double)))
                .ForMember(dst => dst.MaxZeroFuelWeight, src => src.MapFrom(x => x.MaxZeroFuelWeight ?? default(double)))
                .ForMember(dst => dst.OperationalEmptyWeight, src => src.MapFrom(x => x.OperationalEmptyWeight ?? default(double)))
                .ForMember(dst => dst.SeatingEconomy, src => src.MapFrom(x => x.SeatingEconomy ?? default(double)))
                .ForMember(dst => dst.SeatingBusiness, src => src.MapFrom(x => x.SeatingBusiness ?? default(double)))
                .ForMember(dst => dst.SeatingFirst, src => src.MapFrom(x => x.SeatingFirst ?? default(double)))
                .ForMember(dst => dst.Tanks, src => src.MapFrom(x => x.Tanks ?? default(double)))
                .ForMember(dst => dst.BasicEmptyWeightCargoConfig, src => src.MapFrom(x => x.BasicEmptyWeightCargoConfig ?? default(double)));
        }
    }
}