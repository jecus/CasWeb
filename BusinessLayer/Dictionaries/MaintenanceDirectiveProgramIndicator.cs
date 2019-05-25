using System;
using System.Collections.Generic;

namespace BusinessLayer.Dictionaties
{
	public class MaintenanceDirectiveProgramIndicator : StaticDictionary
	{
		#region private static CommonDictionaryCollection<MaintenanceDirectiveProgramIndicator> _Items = new CommonDictionaryCollection<MaintenanceDirectiveProgramIndicator>();
		/// <summary>
		/// Содержит все элементы
		/// </summary>
		private static List<MaintenanceDirectiveProgramIndicator> _Items = new List<MaintenanceDirectiveProgramIndicator>();
		#endregion

		#region public static MaintenanceDirectiveProgramIndicator Unknown = new MaintenanceDirectiveProgramIndicator(-1, "Unknown", "Unknown", "Unknown");
		/// <summary> 
		/// Неизвестный объект
		/// </summary>
		public static MaintenanceDirectiveProgramIndicator Unknown = new MaintenanceDirectiveProgramIndicator(-1, "N/A", "", "N/A");
		#endregion

		public static MaintenanceDirectiveProgramIndicator Structuresitem = new MaintenanceDirectiveProgramIndicator(1, "S", "Structures Item", "Structures Item");
		public static MaintenanceDirectiveProgramIndicator Fatigueitems = new MaintenanceDirectiveProgramIndicator(2, "F", "Fatigue Items", "Fatigue Items");

		/*
         * Методы
         */

		#region public static MaintenanceDirectiveProgramIndicator GetItemById(Int32 directiveTypeId)
		/// <summary>
		/// Возвращает тип диерктивы по его Id
		/// </summary>
		/// <param name="directiveTypeId"></param>
		/// <returns></returns>
		public static MaintenanceDirectiveProgramIndicator GetItemById(int directiveTypeId)
		{
			foreach (MaintenanceDirectiveProgramIndicator t in _Items)
				if (t.ItemId == directiveTypeId)
					return t;
			//
			return Unknown;
		}

		#endregion

		#region public static IEnumerable<MaintenanceDirectiveProgramIndicator> Items
		/// <summary>
		/// Возвращает список элементов коллекции
		/// </summary>
		public static IEnumerable<MaintenanceDirectiveProgramIndicator> Items
		{
			get { return _Items; }
		}
		#endregion

		#region public override string ToString()
		/// <summary>
		/// Переводит тип директивы в строку
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return $"{FullName} ({ShortName})";
		}
		#endregion

		/*
         * Реализация
         */
		#region public MaintenanceDirectiveProgramIndicator()
		public MaintenanceDirectiveProgramIndicator()
		{

		}
		#endregion

		#region public MaintenanceDirectiveProgramIndicator(Int32 itemId, String shortName, String fullName, String commonName)

		/// <summary>
		/// Конструктор создает объект типа директивы
		/// </summary>
		/// <param name="itemId"></param>
		/// <param name="shortName"></param>
		/// <param name="fullName"></param>
		/// <param name="commonName"></param>
		/// <param name="msg"></param>
		public MaintenanceDirectiveProgramIndicator(int itemId, string shortName, string fullName, string commonName)
		{
			ItemId = itemId;
			ShortName = shortName;
			FullName = fullName;
			CommonName = commonName;
			_Items.Add(this);
		}
		#endregion
	}
}