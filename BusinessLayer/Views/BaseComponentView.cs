using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BusinessLayer.Dictionaties;

namespace BusinessLayer.Views
{
	public class BaseComponentView : BaseView
	{
		private BaseComponentType _baseComponentType;


		public AircraftModelView ModelId { get; set; }

		public string Manufacturer { get; set; }

		public string SerialNumber { get; set; }

		public string PartNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("ManufactureDate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? ManufactureDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("StartDate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? StartDate { get; set; }

		public bool IsBaseComponent { get; set; }

		public int BaseComponentTypeId { get; set; }

		public String Position
		{
			get { return TransferRecords.GetLast() != null ? TransferRecords.GetLast().Position : ""; }
		}

		public BaseComponentType BaseComponentType
		{
			get => BaseComponentType.GetComponentTypeById(BaseComponentTypeId);
		}

		public ComponentModelView Model { get; set; }

		public List<TransferRecordView> TransferRecords { get; set; }




	}
}