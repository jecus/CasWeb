using System;

namespace BusinessLayer.Views
{
	public class Threshold : IThreshold
	{
		#region Implementation of IThreshold

		public bool PerformSinceNew { get; set; }
		public bool PerformSinceEffectiveDate { get; set; }
		public ThresholdConditionType FirstPerformanceConditionType { get; set; }
		public ThresholdConditionType RepeatPerformanceConditionType { get; set; }
		public bool PerformRepeatedly { get; set; }
		public DateTime EffectiveDate { get; set; }
		public Lifelength FirstPerformanceSinceNew { get; set; }
		public Lifelength FirstPerformanceSinceEffectiveDate { get; set; }
		public Lifelength FirstNotification { get; set; }
		public Lifelength RepeatInterval { get; set; }
		public Lifelength RepeatNotification { get; set; }
		public Lifelength Warranty { get; set; }
		public Lifelength WarrantyNotification { get; set; }

		#endregion

		#region public static Threshold ConvertForComponentDirective(byte[] data)

		public static int SerializedDataLengthComponentDirective
		{
			get
			{
				return sizeof(bool) * 2 + Lifelength.SerializedDataLength * 6;
			}
		}

		/// <summary>
		/// Получает свойства из массива байт
		/// </summary>
		/// <param name="data"></param>
		/// <param name="serializedDataLength"></param>
		public static Threshold ConvertForComponentDirective(byte[] data)
		{
			var item = new Threshold();

			if (data == null) data = new byte[SerializedDataLengthComponentDirective];
			var serializedFirstPerformance = new byte[Lifelength.SerializedDataLength];
			Array.Copy(data, 0, serializedFirstPerformance, 0, Lifelength.SerializedDataLength);

			item.FirstPerformanceSinceNew = Lifelength.ConvertFromByteArray(serializedFirstPerformance);

			var serializedFirstNotification = new byte[Lifelength.SerializedDataLength];
			Array.Copy(data, Lifelength.SerializedDataLength, serializedFirstNotification, 0, Lifelength.SerializedDataLength);

			item.FirstNotification = Lifelength.ConvertFromByteArray(serializedFirstNotification);

			var serializedrepeatPerform = new byte[Lifelength.SerializedDataLength];
			Array.Copy(data, Lifelength.SerializedDataLength * 2, serializedrepeatPerform, 0, Lifelength.SerializedDataLength);

			item.RepeatInterval = Lifelength.ConvertFromByteArray(serializedrepeatPerform);

			var serializedNotification = new byte[Lifelength.SerializedDataLength];
			Array.Copy(data, Lifelength.SerializedDataLength * 3, serializedNotification, 0, Lifelength.SerializedDataLength);

			item.RepeatNotification = Lifelength.ConvertFromByteArray(serializedNotification);

			var serializedWarranty = new byte[Lifelength.SerializedDataLength];
			Array.Copy(data, Lifelength.SerializedDataLength * 4, serializedWarranty, 0, Lifelength.SerializedDataLength);

			item.Warranty = Lifelength.ConvertFromByteArray(serializedWarranty);

			var serializedWarrantyNotification = new byte[Lifelength.SerializedDataLength];
			Array.Copy(data, Lifelength.SerializedDataLength * 5, serializedWarrantyNotification, 0, Lifelength.SerializedDataLength);

			item.WarrantyNotification = Lifelength.ConvertFromByteArray(serializedWarrantyNotification);

			item.PerformRepeatedly = data[Lifelength.SerializedDataLength * 6] == 1;

			item.FirstPerformanceConditionType = data[Lifelength.SerializedDataLength * 6 + 1] == 1 ? ThresholdConditionType.WhicheverLater : ThresholdConditionType.WhicheverFirst;

			// если еще есть данные то рекурсивно считываем и его
			var dataIndex = SerializedDataLengthComponentDirective;
			var dataLeft = data.Length - dataIndex;

			if (dataLeft >= sizeof(long))
			{
				var serializedEffectivityDate = new byte[sizeof(long)];
				Array.Copy(data, dataIndex, serializedEffectivityDate, 0, sizeof(long));

				item.EffectiveDate = new DateTime(DbTypes.Int64FromByteArray(serializedEffectivityDate, 0));
			}

			dataLeft -= sizeof(long);
			dataIndex += sizeof(long);

			if (dataLeft >= Lifelength.SerializedDataLength)
			{
				var serializedRepeatNotificaction = new byte[Lifelength.SerializedDataLength];
				Array.Copy(data, dataIndex, serializedRepeatNotificaction, 0, Lifelength.SerializedDataLength);

				item.FirstPerformanceSinceEffectiveDate = Lifelength.ConvertFromByteArray(serializedRepeatNotificaction);
			}

			return item;
		}
		#endregion

		#region public static Threshold ConvertForCMaintenanceDirective(byte[] data)
		public static int SerializedDataLengthMaintenance
		{
			get
			{
				return sizeof(long) + sizeof(bool) * 3 + Lifelength.SerializedDataLength * 5;
			}
		}
		/// <summary>
		/// Получает свойства из массива байт
		/// </summary>
		/// <param name="data"></param>
		public static Threshold ConvertForCMaintenanceDirective(byte[] data)
		{
			var item = new Threshold();

			if (data == null) data = new byte[SerializedDataLengthMaintenance];
			int currentPos = 0;

			byte[] serializedEffectivityDate = new byte[sizeof(long)];
			Array.Copy(data, currentPos, serializedEffectivityDate, 0, sizeof(long));
			item.EffectiveDate = new DateTime(DbTypes.Int64FromByteArray(serializedEffectivityDate, 0));
			currentPos += sizeof(long);

			byte[] serializedPerformSinceNew = new byte[Lifelength.SerializedDataLength];
			Array.Copy(data, currentPos, serializedPerformSinceNew, 0, Lifelength.SerializedDataLength);
			item.FirstPerformanceSinceNew = Lifelength.ConvertFromByteArray(serializedPerformSinceNew);
			currentPos += Lifelength.SerializedDataLength;

			byte[] serializedSinceEffectivityLifelength = new byte[Lifelength.SerializedDataLength];
			Array.Copy(data, currentPos, serializedSinceEffectivityLifelength, 0, Lifelength.SerializedDataLength);
			item.FirstPerformanceSinceEffectiveDate = Lifelength.ConvertFromByteArray(serializedSinceEffectivityLifelength);
			currentPos += Lifelength.SerializedDataLength;

			byte[] serializedNotification = new byte[Lifelength.SerializedDataLength];
			Array.Copy(data, currentPos, serializedNotification, 0, Lifelength.SerializedDataLength);
			item.FirstNotification = Lifelength.ConvertFromByteArray(serializedNotification);
			currentPos += Lifelength.SerializedDataLength;

			item.FirstPerformanceConditionType = data[currentPos] == 1 ? ThresholdConditionType.WhicheverLater : ThresholdConditionType.WhicheverFirst;
			currentPos += 1;

			item.PerformRepeatedly = data[currentPos] == 1;
			currentPos += 1;

			byte[] serializedrepeatPerform = new byte[Lifelength.SerializedDataLength];
			Array.Copy(data, currentPos, serializedrepeatPerform, 0, Lifelength.SerializedDataLength);
			item.RepeatInterval = Lifelength.ConvertFromByteArray(serializedrepeatPerform);
			currentPos += Lifelength.SerializedDataLength;

			byte[] serializedRepeatNotificaction = new byte[Lifelength.SerializedDataLength];
			Array.Copy(data, currentPos, serializedRepeatNotificaction, 0, Lifelength.SerializedDataLength);
			item.RepeatNotification = Lifelength.ConvertFromByteArray(serializedRepeatNotificaction);
			currentPos += Lifelength.SerializedDataLength;

			item.RepeatPerformanceConditionType = data[currentPos] == 1 ? ThresholdConditionType.WhicheverLater : ThresholdConditionType.WhicheverFirst;

			return item;
		}
		#endregion

		#region public static DirectiveThreshold ConvertFromByteArray(byte[] data)
		/// <summary>
		/// Получает свойства из массива байт
		/// </summary>
		/// <param name="data"></param>
		public static Threshold ConvertForDirective(byte[] data)
		{
			Threshold item = new Threshold();

			if (data == null) data = new byte[SerializedDataLength];
			byte[] serializedEffectivityDate = new byte[sizeof(long)];
			Array.Copy(data, 0, serializedEffectivityDate, 0, sizeof(long));

			item.EffectiveDate = new DateTime(DbTypes.Int64FromByteArray(serializedEffectivityDate, 0));

			byte[] serializedPerformSinceNew = new byte[Lifelength.SerializedDataLength];
			Array.Copy(data, sizeof(long), serializedPerformSinceNew, 0, Lifelength.SerializedDataLength);

			item.FirstPerformanceSinceNew = Lifelength.ConvertFromByteArray(serializedPerformSinceNew);

			byte[] serializedrepeatPerform = new byte[Lifelength.SerializedDataLength];
			Array.Copy(data, sizeof(long) + Lifelength.SerializedDataLength, serializedrepeatPerform, 0, Lifelength.SerializedDataLength);

			item.RepeatInterval = Lifelength.ConvertFromByteArray(serializedrepeatPerform);

			byte[] serializedNotification = new byte[Lifelength.SerializedDataLength];
			Array.Copy(data, sizeof(long) + Lifelength.SerializedDataLength * 2, serializedNotification, 0, Lifelength.SerializedDataLength);

			item.FirstNotification = Lifelength.ConvertFromByteArray(serializedNotification);

			item.PerformSinceNew = data[sizeof(long) + Lifelength.SerializedDataLength * 3] == 1;
			item.PerformSinceEffectiveDate = data[sizeof(long) + Lifelength.SerializedDataLength * 3 + 1] == 1;
			item.PerformRepeatedly = data[sizeof(long) + Lifelength.SerializedDataLength * 3 + 2] == 1;

			byte[] serializedSinceEffectivityLifelength = new byte[Lifelength.SerializedDataLength];
			Array.Copy(data, sizeof(long) + Lifelength.SerializedDataLength * 3 + 3, serializedSinceEffectivityLifelength, 0, Lifelength.SerializedDataLength);

			item.FirstPerformanceSinceEffectiveDate = Lifelength.ConvertFromByteArray(serializedSinceEffectivityLifelength);

			// если у нас еще есть данные то рекурсивно считываем и его
			int dataIndex = SerializedDataLength;
			int dataLeft = data.Length - SerializedDataLength;

			if (dataLeft >= Lifelength.SerializedDataLength)
			{
				byte[] serializedRepeatNotificaction = new byte[Lifelength.SerializedDataLength];
				Array.Copy(data, sizeof(long) + Lifelength.SerializedDataLength * 4 + 3, serializedRepeatNotificaction, 0, Lifelength.SerializedDataLength);

				item.RepeatNotification = Lifelength.ConvertFromByteArray(serializedRepeatNotificaction);

				dataLeft -= Lifelength.SerializedDataLength;
				dataIndex += Lifelength.SerializedDataLength;
			}

			if (dataLeft >= sizeof(byte))
			{
				item.FirstPerformanceConditionType = data[dataIndex] == 0
													? ThresholdConditionType.WhicheverFirst
													: ThresholdConditionType.WhicheverLater;
				dataLeft -= sizeof(byte);
				dataIndex += sizeof(byte);
			}

			if (dataLeft >= sizeof(byte))
			{
				item.RepeatPerformanceConditionType = data[dataIndex] == 0
													? ThresholdConditionType.WhicheverFirst
													: ThresholdConditionType.WhicheverLater;
			}

			return item;
		}

		public static int SerializedDataLength
		{
			get
			{
				return sizeof(long) + sizeof(bool) * 3 + Lifelength.SerializedDataLength * 4;
			}
		}

		#endregion
	}
}