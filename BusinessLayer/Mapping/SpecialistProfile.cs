using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;
using Entity.Models.General;

namespace BusinessLayer.Mapping
{
    public class SpecialistProfile : Profile
    {
        public SpecialistProfile()
        {
            CreateMap<SpecialistView, Specialist>()
                .ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
                .ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
                .ForMember(dst => dst.FirstName, src => src.MapFrom(x => x.FirstName))
                .ForMember(dst => dst.ShortName, src => src.MapFrom(x => x.ShortName))
                .ForMember(dst => dst.SpecializationID, src => src.MapFrom(x => x.SpecializationID))
                .ForMember(dst => dst.LastName, src => src.MapFrom(x => x.LastName))
                .ForMember(dst => dst.Gender, src => src.MapFrom(x => x.Gender))
                .ForMember(dst => dst.AGWCategoryId, src => src.MapFrom(x => x.AGWCategoryId))
                .ForMember(dst => dst.DateOfBirth, src => src.MapFrom(x => x.DateOfBirth))
                .ForMember(dst => dst.Nationality, src => src.MapFrom(x => x.Nationality))
                .ForMember(dst => dst.Address, src => src.MapFrom(x => x.Address))
                .ForMember(dst => dst.Photo, src => src.MapFrom(x => x.Photo))
                .ForMember(dst => dst.PhoneMobile, src => src.MapFrom(x => x.PhoneMobile))
                .ForMember(dst => dst.Phone, src => src.MapFrom(x => x.Phone))
                .ForMember(dst => dst.Email, src => src.MapFrom(x => x.Email))
                .ForMember(dst => dst.Skype, src => src.MapFrom(x => x.Skype))
                .ForMember(dst => dst.Information, src => src.MapFrom(x => x.Information))
                .ForMember(dst => dst.EducationId, src => src.MapFrom(x => x.EducationId))
                .ForMember(dst => dst.Location, src => src.MapFrom(x => x.Location))
                .ForMember(dst => dst.Status, src => src.MapFrom(x => x.Status))
                .ForMember(dst => dst.Position, src => src.MapFrom(x => x.Position))
                .ForMember(dst => dst.Sign, src => src.MapFrom(x => x.Sign))
                .ForMember(dst => dst.FamilyStatusId, src => src.MapFrom(x => x.FamilyStatusId))
                .ForMember(dst => dst.Citizenship, src => src.MapFrom(x => x.Citizenship))
                .ForMember(dst => dst.PersonnelCategoryId, src => src.MapFrom(x => x.PersonnelCategoryId))
                .ForMember(dst => dst.ClassNumber, src => src.MapFrom(x => x.ClassNumber))
                .ForMember(dst => dst.ClassIssueDate, src => src.MapFrom(x => x.ClassIssueDate))
                .ForMember(dst => dst.GradeNumber, src => src.MapFrom(x => x.GradeNumber))
                .ForMember(dst => dst.GradeIssueDate, src => src.MapFrom(x => x.GradeIssueDate))
                .ForMember(dst => dst.Additional, src => src.MapFrom(x => x.Additional))
                .ForMember(dst => dst.Combination, src => src.MapFrom(x => x.Combination));
        }
    }
}