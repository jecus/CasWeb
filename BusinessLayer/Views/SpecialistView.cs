using System;
using BusinessLayer.Dictionaties;
using Entity.Enums;

namespace BusinessLayer.Views
{
    public class SpecialistView : BaseView
    {
        private LocationsTypeView _facility;
        private FamilyStatus _familyStatus;
        private SpecializationView _specialization;

        public string FirstName { get; set; }

        public string ShortName { get; set; }

        public int SpecializationID { get; set; }

        public string LastName { get; set; }

        public Gender? Gender { get; set; }

        public int? AGWCategoryId { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Nationality { get; set; }

        public string Address { get; set; }

        public byte[] Photo { get; set; }

        public string PhoneMobile { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Skype { get; set; }

        public string Information { get; set; }

        public short EducationId { get; set; }

        public Education Education
        {
            get
            {
                return Education.GetItemById(EducationId) ?? Education.UNK;
            }
        }

        public int Location { get; set; }

        public SpecialistStatus Status { get; set; }

        public SpecialistPosition Position { get; set; }

        public byte[] Sign { get; set; }

        public short FamilyStatusId { get; set; }

        public FamilyStatus FamilyStatus
        {
            get
            {
                return FamilyStatus.GetItemById(FamilyStatusId) ?? FamilyStatus.UNK;
            }
        }

        public short Citizenship { get; set; }

        public int PersonnelCategoryId { get; set; }

        public int ClassNumber { get; set; }

        public DateTime? ClassIssueDate { get; set; }

        public int GradeNumber { get; set; }

        public DateTime? GradeIssueDate { get; set; }

        public string Additional { get; set; }

        public string Combination { get; set; }


        public AGWCategorieView AGWCategory { get; set; }

        public LocationsTypeView Facility
        {
            get => _facility ?? LocationsTypeView.Unknown;
            set => _facility = value;
        }

        public SpecializationView Specialization
        {
            get => _specialization ?? SpecializationView.Unknown;
            set => _specialization = value;
        }
    }
}