using System;
using System.Collections.Generic;

namespace BusinessLayer.Dictionaties
{
	public class Currency : StaticDictionary
	{
		#region private static CommonDictionaryCollection<Сurrency> _Items = new CommonDictionaryCollection<Сurrency>();
		/// <summary>
		/// Содержит все элементы
		/// </summary>
		private static List<Currency> _Items = new List<Currency>();
		#endregion

		public static Currency AUD = new Currency(1, "AUD", "AUD");
		public static Currency GBP = new Currency(2, "GBP", "GBP");
		public static Currency BYN = new Currency(3, "BYN", "BYN");
		public static Currency DKK = new Currency(4, "DKK", "DKK");
		public static Currency USD = new Currency(5, "USD", "USD");
		public static Currency EUR = new Currency(6, "EUR", "EUR");
		public static Currency KZT = new Currency(7, "KZT", "KZT");
		public static Currency CAD = new Currency(8, "CAD", "CAD");
		public static Currency CNY = new Currency(9, "CNY", "CNY");
		public static Currency NOK = new Currency(10, "NOK", "NOK");
		public static Currency XDR = new Currency(11, "XDR", "XDR");
		public static Currency SGD = new Currency(12, "SGD", "SGD");
		public static Currency TRY = new Currency(13, "TRY", "TRY");
		public static Currency UAH = new Currency(14, "UAH", "UAH");
		public static Currency SEK = new Currency(15, "SEK", "SEK");
		public static Currency CHF = new Currency(16, "CHF", "CHF");
		public static Currency JPY = new Currency(17, "JPY", "JPY");
		public static Currency AZN = new Currency(18, "AZN", "AZN");
		public static Currency AMD = new Currency(19, "AMD", "AMD");
		public static Currency BGN = new Currency(20, "BGN", "BGN");
		public static Currency BRL = new Currency(21, "BRL", "BRL");
		public static Currency HUF = new Currency(22, "HUF", "HUF");
		public static Currency INR = new Currency(23, "INR", "INR");
		public static Currency KGS = new Currency(24, "KGS", "KGS");
		public static Currency MDL = new Currency(25, "MDL", "MDL");
		public static Currency PLN = new Currency(26, "PLN", "PLN");
		public static Currency RON = new Currency(27, "RON", "RON");
		public static Currency TJS = new Currency(28, "TJS", "TJS");
		public static Currency TMT = new Currency(29, "TMT", "TMT");
		public static Currency UZS = new Currency(30, "UZS", "UZS");
		public static Currency CZK = new Currency(31, "CZK", "CZK");
		public static Currency ZAR = new Currency(32, "ZAR", "ZAR");
		public static Currency KRW = new Currency(33, "KRW", "KRW");


		#region public static HumanDamage UNK = new HumanDamage(-1, "UNK", "Unknown", 0);
		/// <summary>
		/// неизвестный
		/// </summary>
		public static Currency UNK = new Currency(-1, "UNK", "UNK");
		#endregion

		#region public static Сurrency GetItemById(Int32 maintenanceTypeId)
		/// <summary>
		/// Возвращает тип диерктивы по его Id
		/// </summary>
		/// <param name="maintenanceTypeId"></param>
		/// <returns></returns>
		public static Currency GetItemById(Int32 maintenanceTypeId)
		{
			foreach (Currency t in _Items)
				if (t.ItemId == maintenanceTypeId)
					return t;
			//
			return UNK;
		}

		#endregion

		#region static public CommonDictionaryCollection<HumanDamage> Items
		/// <summary>
		/// Возвращает список  элементов коллекции
		/// </summary>
		public static List<Currency> Items
		{
			get
			{
				return _Items;
			}
		}
		#endregion

		#region public override string ToString()
		/// <summary>
		/// Переводит тип директивы в строку
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return FullName;
		}
		#endregion

		/*
         * Реализация
         */
		#region public Сurrency()
		/// <summary>
		/// Конструктор создает объект повреждения
		/// </summary>
		public Currency()
		{
		}
		#endregion

		#region public Сurrency(Int32 itemId, String shortName, String fullName)

		/// <summary>
		/// Конструктор создает объект повреждения
		/// </summary>
		/// <param name="itemId"></param>
		/// <param name="shortName"></param>
		/// <param name="fullName"></param>
		/// <param name="weight"></param>
		public Currency(Int32 itemId, String shortName, String fullName)
		{
			ItemId = itemId;
			ShortName = shortName;
			FullName = fullName;

			_Items.Add(this);
		}
		#endregion
	}
}