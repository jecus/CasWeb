using System;

namespace BusinessLayer.Views
{
	public interface IThreshold
	{
		#region ThresholdConditionType FirstPerformanceConditionType

		/// <summary>
		/// Возвращает условие первого выполнения директивы
		/// </summary>
		ThresholdConditionType FirstPerformanceConditionType { get; set; }

		#endregion

		#region ThresholdConditionType RepeatPerformanceConditionType

		/// <summary>
		/// Возвращает условие повторного выполнения директивы
		/// </summary>
		ThresholdConditionType RepeatPerformanceConditionType { get; set; }

		#endregion

		#region bool PerformRepeatedly { get; set; }

		/// <summary>
		/// Нужно ли повторять директиву
		/// </summary>
		bool PerformRepeatedly { get; set; }

		#endregion

		#region public EffectiveDate { get; set;}

		/// <summary>
		/// Дата вступления директивы в действие - дата выпуска директивы
		/// </summary>
		DateTime EffectiveDate { get; set; }

		#endregion

		#region Lifelength FirstPerformanceSinceNew{ get; set; }

		/// <summary>
		/// Условие первого выполнения директивы
		/// </summary>
		Lifelength FirstPerformanceSinceNew { get; set; }

		#endregion

		#region Lifelength FirstPerformanceSinceEffectiveDate{ get; set; }

		/// <summary>
		/// Условие выполнения директивы с момента выпуска директивы
		/// </summary>
		Lifelength FirstPerformanceSinceEffectiveDate { get; set; }

		#endregion

		#region Lifelength FirstNotification { get; set; }

		/// <summary>
		/// Ресурс предупреждения о приближающемся выполнении директивы
		/// </summary>
		Lifelength FirstNotification { get; set; }

		#endregion

		#region Lifelength RepeatInterval { get; set; }

		/// <summary>
		/// Интервал выполнения директивы
		/// </summary>
		Lifelength RepeatInterval { get; set; }

		#endregion

		#region Lifelength RepeatNotification { get; set; }

		/// <summary>
		/// Ресурс предупреждения о приближающемся повторном выполнении директивы
		/// </summary>
		Lifelength RepeatNotification { get; set; }

		#endregion

		Lifelength Warranty { get; set; }
		Lifelength WarrantyNotification { get; set; }

		 bool PerformSinceNew { get; set; }
		bool PerformSinceEffectiveDate { get; set; }
	}
}