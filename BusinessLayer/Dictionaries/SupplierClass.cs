﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BusinessLayer.Dictionaties
{
	public class SupplierClass : StaticDictionary
	{
		private SupplierClass _parent;
		private SupplierClass _prev;
		private SupplierClass _next;
		private List<SupplierClass> _children;

		#region public new SupplierClass Parent
		/// <summary>
		/// Родительский узел словаря
		/// </summary>
		[JsonIgnore]
		public new SupplierClass Parent
		{
			get { return _parent as SupplierClass; }
		}
		#endregion

		#region public new GoodsClass Prev
		/// <summary>
		/// Предыдущий элемент на уровне
		/// </summary>
		[JsonIgnore]
		public new SupplierClass Prev
		{
			get { return _prev as SupplierClass; }
		}
		#endregion

		#region public new GoodsClass Next
		/// <summary>
		/// Следующий элемент на уровне
		/// </summary>
		[JsonIgnore]
		public new SupplierClass Next
		{
			get { return _next as SupplierClass; }
		}
		#endregion

		#region private static CommonDictionaryCollection<SupplierClass> _Items = new CommonDictionaryCollection<SupplierClass>();
		/// <summary>
		/// Содержит все элементы
		/// </summary>
		private static List<SupplierClass> _Items = new List<SupplierClass>();

		#endregion

		#region private static CommonDictionaryCollection<GoodsClass> _roots = new CommonDictionaryCollection<GoodsClass>();
		/// <summary>
		/// Содержит корневые элементы
		/// </summary>
		private static List<SupplierClass> _roots = new List<SupplierClass>();

		#endregion


		public static SupplierClass Customer = new SupplierClass(1, "Customer", "Customer", "Customer");

		#region Элементы Customers

		public static SupplierClass Client = new SupplierClass(2, "Client", "Client", "Client", Customer);

		#endregion

		public static SupplierClass Vendor = new SupplierClass(3, "Vendor", "Vendor", "Vendor");

		#region Элементы Vendor

		public static SupplierClass Agent = new SupplierClass(4, "Agent", "Agent", "Agent", Vendor);
		public static SupplierClass Broker = new SupplierClass(5, "Broker", "Broker", "Broker", Vendor);
		public static SupplierClass Contractor = new SupplierClass(6, "Contractor", "Contractor", "Contractor", Vendor);
		public static SupplierClass Dealer = new SupplierClass(7, "Dealer", "Dealer", "Dealer", Vendor);
		public static SupplierClass Distributer = new SupplierClass(8, "Distributer", "Distributer", "Distributer", Vendor);
		public static SupplierClass Partner = new SupplierClass(9, "Partner", "Partner", "Partner", Vendor);
		public static SupplierClass Provider = new SupplierClass(10, "Provider", "Provider", "Provider", Vendor);
		public static SupplierClass Shipper = new SupplierClass(11, "Shipper", "Shipper", "Shipper", Vendor);
		public static SupplierClass SubContractor = new SupplierClass(12, "SubContractor", "SubContractor", "SubContractor", Vendor);
		public static SupplierClass Supplier = new SupplierClass(13, "Supplier", "Supplier", "Supplier", Vendor);



		#endregion

		public static SupplierClass Manufacturer = new SupplierClass(14, "Manufacturer", "Manufacturer", "Manufacturer");

		#region public static SupplierClass Unknown = new SupplierClass(-1, "Unknown", "Unknown", "Unknown");
		/// <summary> 
		/// Неизвестный объект
		/// </summary>
		public static SupplierClass Unknown = new SupplierClass(-1, "Unknown", "Unknown", "Unknown");
		#endregion

		/*
		* Методы
		*/

		#region public static SupplierClass GetItemById(Int32 GoodsClassId)
		/// <summary>
		/// Возвращает тип диерктивы по его Id
		/// </summary>
		/// <param name="goodsClassId"></param>
		/// <returns></returns>
		public static SupplierClass GetItemById(int goodsClassId)
		{
			foreach (SupplierClass t in _Items)
				if (t.ItemId == goodsClassId)
					return t;
			//
			return Unknown;
		}

		#endregion

		#region static public List<SupplierClass> Items
		/// <summary>
		/// Возвращает список  элементов коллекции
		/// </summary>
		public static List<SupplierClass> Items
		{
			get { return _Items; }
		}
		#endregion

		#region static public CommonDictionaryCollection<SupplierClass> Roots
		/// <summary>
		/// Возвращает список корневых элементов
		/// </summary>
		public static List<SupplierClass> Roots
		{
			get { return _roots; }
		}
		#endregion

		#region public IDictionaryCollection Children
		/// <summary>
		/// Дочерние элементы словаря
		/// </summary>
		public new List<SupplierClass> Children
		{
			get
			{
				if (_children == null)
					_children = new List<SupplierClass>();
				return (List<SupplierClass>)_children;
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
			return ShortName;
		}
		#endregion

		/*
         * Реализация
         */

		#region public SupplierClass()
		/// <summary>
		/// Консруктор по умолчанию
		/// </summary>
		public SupplierClass()
		{
			
		}
		#endregion

		#region private SupplierClass(Int32 ItemId, String shortName, String fullName, String commonName) : this(itemId, shortName, fullName, commonName, Unknown)

		/// <summary>
		/// Конструктор создает объект типа директивы
		/// </summary>
		/// <param name="itemId"></param>
		/// <param name="shortName"></param>
		/// <param name="fullName"></param>
		/// <param name="commonName"></param>
		private SupplierClass(int itemId, string shortName, string fullName, string commonName)
			: this(itemId, shortName, fullName, commonName, null)
		{
			if (_roots.Count > 0)
			{
				_prev = _roots[_roots.Count - 1];
				_roots[_roots.Count - 1]._next = this;
			}
			_roots.Add(this);
		}
		#endregion

		#region private SupplierClass(Int32 itemId, String shortName, String fullName, String commonName, GoodsClass parent) : this()

		/// <summary>
		/// Конструктор создает объект типа директивы
		/// </summary>
		/// <param name="itemId"></param>
		/// <param name="shortName"></param>
		/// <param name="fullName"></param>
		/// <param name="commonName"></param>
		/// <param name="parent">Родительский узел</param>
		private SupplierClass(int itemId, string shortName, string fullName, string commonName, SupplierClass parent) : this()
		{
			ItemId = itemId;
			ShortName = shortName;
			FullName = fullName;
			CommonName = commonName;
			_parent = parent;

			if (parent != null)
			{
				//Выставление пред. узла на данном уровне для тек. узла
				SupplierClass prevNode = parent.Children.Count > 0
											? parent.Children[parent.Children.Count - 1]
											: null;
				_prev = prevNode;

				//Для пред. узла на данном уровне - выставление след. узла

				if (prevNode != null)
					prevNode._next = this;

				//добавление нового дочернего узла в родительский узел
				parent.Children.Add(this);
			}
			_Items.Add(this);
		}
		#endregion
	}
}