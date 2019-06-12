using System;
using System.Text;

namespace BusinessLayer.Views
{
	public class Lifelength
	{
		/*
		* Свойства
		*/

		#region public int? Cycles { get; set; }
		/// <summary>
		/// Количество циклов
		/// </summary>
		public int? Cycles { get; set; }
		#endregion

		#region public int? Hours { get; set; }
		/// <summary>
		/// Количество часов 
		/// </summary>
		public int? Hours
		{
			get { return TotalMinutes != null ? new int?(TotalMinutes.Value / 60) : null; }
			set
			{
				// Если задаваемое значение null, то просто присваиваем null, не обращая внимания на прошлое заданное значение
				if (value == null)
					TotalMinutes = null;
				// Если прошлое значение не было задано до этого
				else if (TotalMinutes == null)
					TotalMinutes = value.Value * 60;
				// Если значение уже было задано до этого
				else TotalMinutes = value.Value * 60 + Minutes;
			}
		}
		#endregion

		#region public int? Minutes { get; set; }
		/// <summary>
		/// Количество минут 
		/// </summary>
		public int? Minutes
		{
			get { return TotalMinutes != null ? new int?(TotalMinutes.Value % 60) : null; }
			set
			{
				// Если значение null, то просто присваиваем null, не обращая внимания на прошлое заданное значение
				if (value == null)
					TotalMinutes = null;
				// Если не null, но прошлое значение не было задано 
				else if (TotalMinutes == null)
					TotalMinutes = value.Value;
				// Если новое значение не пустое и значение было задано до этого
				else TotalMinutes = Hours * 60 + value.Value;
			}
		}
		#endregion

		#region public int? TotalMinutes { get; set; }
		/// <summary>
		/// Полное количество минут (оно и хранится в базе данных)
		/// </summary>
		public int? TotalMinutes { get; set; }
		#endregion

		#region public int? Days { get; set; }
		/// <summary>
		/// Количество дней
		/// </summary>
		public int? Days
		{
			get { return CalendarSpan.Days; }
			set
			{
				CalendarSpan.CalendarValue = value;
				CalendarSpan.CalendarType = CalendarTypes.Days;
			}
		}
		#endregion

		#region public int? CalendarValue { get; set; }
		/// <summary>
		/// Календарное значение
		/// </summary>
		public int? CalendarValue
		{
			get { return _calendarSpan != null ? _calendarSpan.CalendarValue : null; }
			set { CalendarSpan.CalendarValue = value; }
		}
		#endregion

		#region public CalendarTypes CalendarType { get; set; }
		/// <summary>
		/// Тип календаря
		/// </summary>
		public CalendarTypes CalendarType
		{
			get { return _calendarSpan != null ? _calendarSpan.CalendarType : CalendarTypes.Days; }
			set { CalendarSpan.CalendarType = value; }
		}
		#endregion

		#region public CalendarSpan CalendarSpan { get; set; }

		private CalendarSpan _calendarSpan;

		/// <summary>
		/// Тип календаря
		/// </summary>
		public CalendarSpan CalendarSpan
		{
			get { return _calendarSpan ?? (_calendarSpan = new CalendarSpan()); }
			set { _calendarSpan = value; }
		}
		#endregion

		/*
         * Конструктор 
         */

		#region public Lifelength()
		/// <summary>
		/// Создает наработку (ресурс) с пустыми параметрами
		/// </summary>
		public Lifelength()
		{
		}
		#endregion

		#region public Lifelength(int? days, int? cycles, int? totalMinutes)
		/// <summary>
		/// Создает наработку (ресурс) с известными параметрами
		/// </summary>
		/// <param name="days"></param>
		/// <param name="cycles"></param>
		/// <param name="totalMinutes"></param>
		public Lifelength(int? days, int? cycles, int? totalMinutes)
		{
			Days = days;
			Cycles = cycles;
			TotalMinutes = totalMinutes;
		}
		#endregion

		#region public Lifelength(Lifelength source)
		/// <summary>
		/// Копирует наработку (Создает новую наработку с такими же параметрами)
		/// </summary>
		/// <param name="source"></param>
		public Lifelength(Lifelength source)
		{
			if (source == null) return;
			//
			Cycles = source.Cycles;
			CalendarSpan = new CalendarSpan(source.CalendarSpan);
			TotalMinutes = source.TotalMinutes;
		}
		#endregion


		/*
		* Статические объекты
		*/

		#region public static Lifelength Zero { get; }
		/// <summary>
		/// Возвращает наработку (ресурс) с нулевыми (но не пустыми) параметрами
		/// </summary>
		public static Lifelength Zero
		{
			get
			{
				return new Lifelength(0, 0, 0);
			}
		}
		#endregion

		#region public static Lifelength Null { get; }
		/// <summary>
		/// Возвращает наработку (ресурс) с пустыми параметрами 
		/// </summary>
		public static Lifelength Null
		{
			get
			{
				return new Lifelength();
			}
		}
		#endregion

		#region public static int SerializedDataLength { get; }
		/// <summary>
		/// Gets length of any serialized <see cref="Lifelength"/>
		/// </summary>
		public static int SerializedDataLength
		{
			get { return 21; }
		}
		#endregion

		#region public void CompleteNullParameters (Lifelength source)
		/// <summary>
		/// Дополняет пустые параметры текущего объекта параметрами из источника
		/// </summary>
		/// <param name="source"></param>
		public void CompleteNullParameters(Lifelength source)
		{
			if (Cycles == null) Cycles = source.Cycles;
			if (TotalMinutes == null) TotalMinutes = source.TotalMinutes;
			if (Days == null) Days = source.Days;
		}

		#endregion

		#region public void Add(Lifelength lifelength)

		/// <summary>
		/// Прибавляет заданную наработку к уже существующей
		/// </summary>
		/// <param name="lifelength"></param>
		public void Add(Lifelength lifelength)
		{
			// прибавляем к this
			// null + cycles = cycles
			// cycles + null = cycles
			// null + null = null
			// cycles + cycles = cycles + cycles
			if (Cycles == null && lifelength.Cycles != null) Cycles = lifelength.Cycles;
			else if (Cycles != null && lifelength.Cycles != null) Cycles += lifelength.Cycles;

			if (Days == null && lifelength.Days != null) Days = lifelength.Days;
			else if (Days != null && lifelength.Days != null) Days += lifelength.Days;

			if (TotalMinutes == null && lifelength.TotalMinutes != null) TotalMinutes = lifelength.TotalMinutes;
			else if (TotalMinutes != null && lifelength.TotalMinutes != null) TotalMinutes += lifelength.TotalMinutes;
		}

		#endregion

		#region public void Add(LifelengthSubResource sub, int source)
		/// <summary>
		/// Прибавляет заданную наработку к указанному параметру
		/// </summary>
		public void Add(LifelengthSubResource subResource, int source)
		{
			// прибавляем к this
			// null + cycles = cycles
			// cycles + null = cycles
			// null + null = null
			// cycles + cycles = cycles + cycles
			switch (subResource)
			{
				case LifelengthSubResource.Minutes:
					if (TotalMinutes == null) TotalMinutes = source;
					else TotalMinutes += source;
					break;
				case LifelengthSubResource.Hours:
					if (TotalMinutes == null) TotalMinutes = source * 60;
					else TotalMinutes += source * 60;
					break;
				case LifelengthSubResource.Cycles:
					if (Cycles == null) Cycles = source;
					else Cycles += source;
					break;
				case LifelengthSubResource.Calendar:
					if (Days == null) Days = source;
					else Days += source;
					break;
				default:
					break;
			}
		}

		#endregion

		#region public void Add(Lifelength lifelength)

		/// <summary>
		/// Прибавляет заданную наработку к уже существующей
		/// </summary>
		/// <param name="from"></param>
		/// <param name="lifelength"></param>
		public void Add(DateTime from, Lifelength lifelength)
		{
			// прибавляем к this
			// null + cycles = cycles
			// cycles + null = cycles
			// null + null = null
			// cycles + cycles = cycles + cycles
			if (Cycles == null && lifelength.Cycles != null) Cycles = lifelength.Cycles;
			else if (Cycles != null && lifelength.Cycles != null) Cycles += lifelength.Cycles;

			if (TotalMinutes == null && lifelength.TotalMinutes != null) TotalMinutes = lifelength.TotalMinutes;
			else if (TotalMinutes != null && lifelength.TotalMinutes != null) TotalMinutes += lifelength.TotalMinutes;

			if (CalendarValue == null && lifelength.CalendarValue != null)
			{
				DateTime to = from.AddCalendarSpan(lifelength.CalendarSpan);
				Days = (to - from).Days;
			}
			else if (Days != null && lifelength.Days != null)
			{
				DateTime to = from.AddCalendarSpan(lifelength.CalendarSpan);
				Days += (to - from).Days;
			}
		}

		#endregion

		#region public void Substract(Lifelength lifelength)

		/// <summary>
		/// Отнимает заданную наработку от уже существующей
		/// </summary>
		/// <param name="lifelength"></param>
		public void Substract(Lifelength lifelength)
		{
			Lifelength lifelength2 = new Lifelength(-lifelength.Days, -lifelength.Cycles, -lifelength.TotalMinutes);
			Add(lifelength2);
		}

		#endregion

		#region public bool IsNullOrZero()
		/// <summary> 
		/// Метод возвратит true если все три параметра наработки (ресурса) пусты или равны 0
		/// </summary>
		/// <returns></returns>
		public bool IsNullOrZero()
		{
			// cycles && hours && days == null
			if ((Cycles == null || Cycles == 0) &&
				(Days == null || Days == 0) &&
				(TotalMinutes == null || TotalMinutes == 0)) return true;

			return false;
		}
		#endregion

		#region public void SetMax(Lifelength candidate)
		/// <summary>
		/// По выходу объект будет представлять содержитать максимальные ресурсы от обоих объектов (whichever later)
		/// </summary>
		/// <param name="candidate"></param>
		public void SetMax(Lifelength candidate)
		{
			// Если у кандидата циклы больше чем у текущего объекта - присваиваем максимальные циклы
			if (candidate.Cycles != null && (Cycles == null || Cycles < candidate.Cycles))
				Cycles = candidate.Cycles;

			// то же по часам 
			if (candidate.TotalMinutes != null && (TotalMinutes == null || TotalMinutes < candidate.TotalMinutes))
				TotalMinutes = candidate.TotalMinutes;

			// то же по календарю
			if (candidate.Days != null && (Days == null || Days < candidate.Days))
				Days = candidate.Days;

		}
		#endregion

		#region public void SetMin(Lifelength candidate)
		/// <summary>
		/// По выходу объект будет представлять содержитать минимальных ресурсов от обоих объектов (whichever first)
		/// </summary>
		/// <param name="candidate"></param>
		public void SetMin(Lifelength candidate)
		{
			// Если у кандидата циклы меньше чем у текущего объекта - присваиваем минимальные циклы
			if (candidate.Cycles != null && (Cycles == null || Cycles > candidate.Cycles))
				Cycles = candidate.Cycles;

			// то же по часам 
			if (candidate.TotalMinutes != null && (TotalMinutes == null || TotalMinutes > candidate.TotalMinutes))
				TotalMinutes = candidate.TotalMinutes;

			// то же по календарю
			if (candidate.Days != null && (Days == null || Days > candidate.Days))
				Days = candidate.Days;

		}
		#endregion

		/*
         * Методы
         */
		#region public void Resemble(Lifelength sample)
		/// <summary>
		/// Сделать похожим на заданный ресурс. Т.е. если не заданы часы - сделать часы n/a и т.д.
		/// </summary>
		/// <param name="sample"></param>
		public void Resemble(Lifelength sample)
		{
			if (sample.TotalMinutes == null) TotalMinutes = null;
			if (sample.Cycles == null) Cycles = null;
			if (sample.Days == null) Days = null;
		}
		#endregion

		#region public static Lifelength ConvertFromByteArray(byte[] data)
		/// <summary>
		/// Конвертирует данные из БД в Lifelength
		/// </summary>
		/// <param name="data"></param>
		public static Lifelength ConvertFromByteArray(byte[] data)
		{

			Lifelength item = new Lifelength();

			byte[] binaryData = data;
			if (null == binaryData) return null;

			if (binaryData == null || binaryData.Length != SerializedDataLength)
				return null;//на случай если -1 пришел
							//throw new ArgumentException("Data cannot be converted to Lifelength");

			item.Cycles = DbTypes.Int32FromByteArray(binaryData, 1);

			var calendar = DbTypes.Int64FromByteArray(binaryData, 5);
			var cal = new TimeSpan(calendar);

			item.CalendarSpan = new CalendarSpan(cal.Days, (CalendarTypes)cal.Milliseconds);

			var ticks = DbTypes.Int64FromByteArray(binaryData, 13);
			var ts = new TimeSpan(ticks);
			item.TotalMinutes = ts.Minutes + ((int)ts.TotalHours) * 60;

			if ((binaryData[0] & 1) == 0)
				item.Days = null;
			if ((binaryData[0] >> 1 & 1) == 0)
				item.Cycles = null;
			if ((binaryData[0] >> 2 & 1) == 0)
				item.Hours = null;

			return item;
		}

		#endregion


		/*
         * Арифметика 
         */
		#region public bool IsGreaterByAnyParameter(Lifelength lifelength)
		/// <summary>
		/// Метод проверяет, является ли данная наработка больше заданной по любому из трех параметров
		/// </summary>
		/// <param name="lifelength"></param>
		/// <returns></returns>
		public bool IsGreaterByAnyParameter(Lifelength lifelength)
		{
			// 10, 10, 10 > 5, 5, 5
			// 10, 10, 10 > 5, 20, 5
			//Cycles
			if (Cycles != null && lifelength.Cycles != null && Cycles > lifelength.Cycles) return true;
			// TotalMinutes
			if (TotalMinutes != null && lifelength.TotalMinutes != null && TotalMinutes > lifelength.TotalMinutes) return true;
			// Days
			if (Days != null && lifelength.Days != null && Days > lifelength.Days) return true;

			return false;
		}
		#endregion

		#region public bool IsOverdue()
		/// <summary>
		/// Просрочен ли ресурс (т.е. меньше ли он нуля)
		/// </summary>
		/// <returns></returns>
		public bool IsOverdue()
		{
			if (Cycles != null && Cycles <= 0) return true;
			if (TotalMinutes != null && TotalMinutes <= 0) return true;
			if (Days != null && Days <= 0) return true;
			//
			return false;
		}
		#endregion

		#region public bool IsAllOverdue()
		/// <summary>
		/// Просрочен ли ресурс по всем параметрам (условие проверки Whichever Later)
		/// </summary>
		/// <returns></returns>
		public bool IsAllOverdue()
		{
			// Если все параметры неопределены - ресурс не просрочен
			if (Cycles == null && TotalMinutes == null && Days == null) return false;
			// Если хотя бы один параметр больше нуля - ресруср не просрочен
			if ((Cycles != null && Cycles > 0) || (TotalMinutes != null && TotalMinutes > 0) || (Days != null && Days > 0)) return false;
			// Ресурс просрочен
			return true;
		}

		#endregion

		#region public bool IsLessByAnyParameter(Lifelength lifelength)
		/// <summary>
		/// Метод проверяет, является ли данная наработка меньше заданной по любому из трех параметров
		/// </summary>
		/// <param name="lifelength"></param>
		/// <returns></returns>
		public bool IsLessByAnyParameter(Lifelength lifelength)
		{
			//Cycles
			if (Cycles != null && lifelength.Cycles != null && Cycles < lifelength.Cycles) return true;
			// TotalMinutes
			if (TotalMinutes != null && lifelength.TotalMinutes != null && TotalMinutes < lifelength.TotalMinutes) return true;
			// Days
			if (Days != null && lifelength.Days != null && Days < lifelength.Days) return true;

			return false;
		}
		#endregion

		#region public bool IsLess(Lifelength lifelength)

		/// <summary>
		/// Метод проверяет, является ли данная наработка строго меньшей заданной по всем трем параметрам
		/// </summary>
		/// <param name="lifelength"></param>
		/// <param name="strictCompare"></param>
		/// <returns></returns>
		public bool IsLess(Lifelength lifelength, bool strictCompare = true)
		{
			if (Cycles != null && lifelength.Cycles != null && Cycles < lifelength.Cycles &&
				TotalMinutes != null && lifelength.TotalMinutes != null && TotalMinutes < lifelength.TotalMinutes &&
				Days != null && lifelength.Days != null && Days < lifelength.Days) return true;
			return false;
		}

		#endregion

		#region public void Reset()
		/// <summary>
		/// приравнивает часы, циклы и дни к null
		/// </summary>
		public void Reset()
		{
			Cycles = Hours = Days = null;
		}
		#endregion


		public override string ToString()
		{
			string sh = Hours != null && Hours != 0 ? Hours + "FH" : "";
			string sc = Cycles != null && Cycles != 0 ? Cycles + "FC" : "";
			//string sd = Days != null ? Days + "d " : "";
			string sd = "";
			if (CalendarValue != null)
			{
				switch (CalendarSpan.CalendarType)
				{
					case CalendarTypes.Years:
						sd = CalendarValue + "Y ";
						break;
					case CalendarTypes.Months:
						sd = CalendarValue + "MO ";
						break;
					case CalendarTypes.Days:
						sd = CalendarValue + "d ";
						break;
				}
			}
			StringBuilder stringBuilder = new StringBuilder();
			if (!string.IsNullOrEmpty(sh))
				stringBuilder.AppendLine(sh);
			if (!string.IsNullOrEmpty(sc))
				stringBuilder.AppendLine(sc);
			if (!string.IsNullOrEmpty(sd))
				stringBuilder.AppendLine(sd);
			return stringBuilder.ToString();
		}
	}
}