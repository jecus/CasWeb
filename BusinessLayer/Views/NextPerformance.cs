using System;
using BusinessLayer.Dictionaties;

namespace BusinessLayer.Views
{
	public class NextPerformance
	{
		#region public DateTime? PrevPerformanceDate { get; set; }
		/// <summary>
		/// Приблизительная дата предыдущего выполнения
		/// </summary>
		public DateTime? PrevPerformanceDate { get; set; }
		#endregion

		#region public Lifelength PrevPerformanceSource { get; set; }

		private Lifelength _prevPerformanceSource;
		/// <summary>
		/// Ресурс, на котором произошло (произойдет) пред. выполнение
		/// </summary>
		public Lifelength PrevPerformanceSource
		{
			get { return _prevPerformanceSource ?? (_prevPerformanceSource = Lifelength.Null); }
			set { _prevPerformanceSource = value; }
		}
		#endregion

		#region public DateTime? PerformanceDate { get; set; }
		/// <summary>
		/// Приблизительная дата выполнения
		/// </summary>
		public DateTime? PerformanceDate { get; set; }
		#endregion

		#region public DateTime? NextPerformanceDate { get; set; }
		/// <summary>
		/// Приблизительная дата следующего выполнения
		/// </summary>
		public DateTime? NextPerformanceDate { get; set; }
		#endregion

		#region public Lifelength NextPerformanceSource { get; set; }

		private Lifelength _nextPerformanceSource;
		/// <summary>
		/// Ресурс, на котором произойдет след. выполнение
		/// </summary>
		public Lifelength NextPerformanceSource
		{
			get { return _nextPerformanceSource ?? (_nextPerformanceSource = Lifelength.Null); }
			set { _nextPerformanceSource = value; }
		}
		#endregion

		#region public int PerformanceNum { get; set; }
		/// <summary>
		/// Порядковый номер выполнения
		/// </summary>
		public int PerformanceNum { get; set; }
		#endregion

		#region public Lifelength PerformanceSource { get; set; }

		private Lifelength _performanceSource;
		/// <summary>
		/// Ресурс, на котором произойдет выполнение
		/// </summary>
		public Lifelength PerformanceSource
		{
			get { return _performanceSource ?? (_performanceSource = Lifelength.Null); }
			set { _performanceSource = value; }
		}
		#endregion

		#region public Lifelength Remains { get; set; }
		/// <summary>
		/// остаток до выполнения (до NextPerformanceSource)
		/// </summary>
		public Lifelength Remains { get; set; }
		#endregion

		#region public Lifelength WarrantlyRemains { get; set; }

		public Lifelength WarrantlyRemains { get; set; }

		#endregion

		#region public Lifelength LimitNotify { get; set; }

		public Lifelength LimitNotify { get; set; }

		#endregion

		#region public Lifelength LimitOverdue { get; set; }

		public Lifelength LimitOverdue { get; set; }

		#endregion

		#region public Lifelength BeforeForecastResourceRemain { get; set; }
		/// <summary>
		/// Остаток ресурса между точкой прогноза и последним выполнением(или начальной точки) до прогноза (вычисляется только в прогнозе)
		/// </summary>
		public Lifelength BeforeForecastResourceRemain { get; set; }
		#endregion

		#region public ConditionState Condition { get; set; }
		/// <summary>
		/// Текущее состояние задачи
		/// </summary>
		public ConditionState Condition { get; set; }
		#endregion
		
	}
}