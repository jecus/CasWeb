using System;
using System.Collections.Generic;
using System.ComponentModel;
using BusinessLayer.Dictionaties;
using Entity.Models.Dictionaries;
using Entity.Models.General;
using Newtonsoft.Json;

namespace BusinessLayer.Views
{
	public class WorkPackageView : BaseView
	{
		public int? ParentId { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public WorkPackageStatus Status { get; set; }

		public string Author { get; set; }

		public DateTime OpeningDate { get; set; }

		public DateTime? PublishingDate { get; set; }

		public DateTime? ClosingDate { get; set; }

		public string Remarks { get; set; }

		public string PublishingRemarks { get; set; }

		public string ClosingRemarks { get; set; }

		public bool OnceClosed { get; set; }

		public string ReleaseCertificateNo { get; set; }

		public string CheckType { get; set; }

		public string Station { get; set; }

		public string MaintenanceReportNo { get; set; }

		public string Number { get; set; }

		public string Revision { get; set; }

		public DateTime? CreateDate { get; set; }

		public string PublishedBy { get; set; }

		public string ClosedBy { get; set; }

		public string EmployeesRemark { get; set; }
		
		public WpWorkType WpWorkType { get; set; }

		public double ManHours { get; set; }
		public double KMH { get; set; }
		public double KMLW => (KMH * ManHours);

		public double Persent { get; set; }

		public string PerformAfter
		{
			get => JsonConvert.SerializeObject(PerfAfter, Formatting.Indented, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
			set => PerfAfter = JsonConvert.DeserializeObject<PerformAfter>(value ?? "", new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
		}

		public PerformAfter PerfAfter
		{
			get => _perfAfter ?? (_perfAfter = new PerformAfter());
			set => _perfAfter = value;
		}

		public string ProviderJSON
		{
			get => JsonConvert.SerializeObject(ProviderPrice, Formatting.Indented, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
			set => ProviderPrice = JsonConvert.DeserializeObject<List<ProviderPrice>>(value ?? "", new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
		}

		private List<ProviderPrice> _providerPrice;
		private PerformAfter _perfAfter;
		private WorkPackageStatus _status;
		private DateTime _closingDate;
		private DateTime _publishingDate;

		public List<ProviderPrice> ProviderPrice
		{
			get => _providerPrice ?? (_providerPrice = new List<ProviderPrice>());
			set => _providerPrice = value;
		}

		public string WorkTimeString
		{
			get
			{
				string workTime = "";
				if (_status == WorkPackageStatus.Closed)
				{
					TimeSpan time = _closingDate - _publishingDate;
					if (time.TotalDays - time.TotalDays % 1 > 0) workTime += Convert.ToInt32(time.TotalDays - time.TotalDays % 1) + "d ";
					if (time.Hours > 0) workTime += Convert.ToInt32(time.Hours) + "h ";
					if (time.Minutes > 0) workTime += Convert.ToInt32(time.Minutes) + "m ";
				}

				return workTime;
			}
		}

		public string PerformAfterString => PerfAfter.ToString();
		public string RegistrationNumber { get; set; }
	}

	[JsonObject]
	public class PerformAfter
	{
		#region Fields

		private DateTime? _performDate;

		#endregion

		#region Constructor

		public PerformAfter()
		{
			AirportFromId = -1;
			AirportToId = -1;
			FlightNumId = -1;

		}

		#endregion

		[DefaultValue(-1)]
		public int AirportFromId { get; set; }

		[DefaultValue(-1)]
		public int AirportToId { get; set; }

		[DefaultValue(-1)]
		public int FlightNumId { get; set; }

		public DateTime? PerformDate
		{
			get => _performDate < DateTimeExtend.GetCASMinDateTime() ? DateTimeExtend.GetCASMinDateTime() : _performDate;
			set => _performDate = value;
		}

		public string PerformDateString => PerformDate.ToUniversalString();

		[JsonIgnore]
		public FlightNumView FlightNum { get; set; }

		[JsonIgnore]
		public AirportCodeView AirportFrom { get; set; }

		[JsonIgnore]
		public AirportCodeView AirportTo { get; set; }

		#region Overrides of Object

		public override string ToString()
		{
			var res = "";

			if (FlightNum != null)
				res += FlightNum.ToString();
			if (AirportFrom != null)
				res += $" {AirportFrom.Icao}";
			if (AirportTo != null)
				res += $"-{AirportTo.Icao}";
			return res;
		}

		#endregion
	}

	[JsonObject]
	public class ProviderPrice
	{
		[JsonIgnore] public SupplierView Supplier { get; set; }

		[JsonIgnore] public WorkPackageView Parent { get; set; }

		[JsonIgnore]
		public string SupplierName
		{
			get => Supplier?.Name ?? SupplierView.Unknown.Name;
		}

		[JsonProperty]
		public int SupplierId { get; set; }

		[JsonProperty]
		public decimal Offering { get; set; }

		[JsonProperty]
		public decimal Routine { get; set; }

		[JsonProperty]
		public decimal RoutineKMH { get; set; }

		[JsonProperty]
		public decimal NDT { get; set; }

		[JsonProperty]
		public decimal NDTKMH { get; set; }

		[JsonProperty]
		public decimal AD { get; set; }

		[JsonProperty]
		public decimal ADKMH { get; set; }

		[JsonProperty]
		public decimal NRC { get; set; }

		[JsonProperty]
		public decimal NRCKMH { get; set; }

		[DefaultValue(-1)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		public int CurrencyOfferingId { get; set; }

		[JsonIgnore]
		public Currency CurrencyOffering
		{
			get => Currency.GetItemById(CurrencyOfferingId);
			set => CurrencyOfferingId = value.ItemId;
		}
	}
}