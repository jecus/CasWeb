using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusinessLayer.Dictionaties;

namespace BusinessLayer.Views
{
	public class BaseComponentView : BaseView
	{
		private BaseComponentType _baseComponentType;


		public ModelView ModelId { get; set; }

		public string Manufacturer { get; set; }

		public string SerialNumber { get; set; }

		public string PartNumber { get; set; }

		public DateTime? ManufactureDate { get; set; }

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

		public ModelView Model { get; set; }

		public List<TransferRecordView> TransferRecords { get; set; }




	}
}