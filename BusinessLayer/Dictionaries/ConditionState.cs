﻿using System;
using System.Collections.Generic;

namespace BusinessLayer.Dictionaties
{
	public class ConditionState : StaticDictionary
	{
		#region private static List<ConditionState> _Items = new List<ConditionState>();
		/// <summary>
		/// Содержит все элементы
		/// </summary>
		private static List<ConditionState> _Items = new List<ConditionState>();
		#endregion
		/*
         * Возможные состояния объекта
         */

		#region public static ConditionState NotEstimated = new ConditionState(1, "N/A", "Not Estimated");
		/// <summary>
		/// Работа не ведется
		/// </summary>
		public static ConditionState NotEstimated = new ConditionState(1, "N/A", "Not Estimated");

		#endregion

		#region  public static ConditionState Satisfactory = new ConditionState(10, "S", "Satisfactory");
		/// <summary>
		/// Работа выполняется своевременно 
		/// </summary>
		public static ConditionState Satisfactory = new ConditionState(10, "S", "Satisfactory");

		#endregion

		#region public static ConditionState Notify = new ConditionState(20, "N", "Notify");
		/// <summary>
		/// Работа должна будет выполнена в скором времени
		/// </summary>
		public static ConditionState Notify = new ConditionState(20, "N", "Notify");

		#endregion

		#region public static ConditionState Overdue = new ConditionState(30, "U", "Overdue");
		/// <summary>
		/// Работа просрочена
		/// </summary>
		public static ConditionState Overdue = new ConditionState(30, "U", "Overdue");

		#endregion

		#region public static ConditionState UNK = new ConditionState(-1, "UNK", "Unknown");
		/// <summary>
		/// 
		/// </summary>
		public static ConditionState UNK = new ConditionState(-1, "UNK", "Unknown");
		#endregion

		/*
         * Свойства
         */

		/*
         * Методы
         */
		#region public static ConditionState GetItemById(Int32 conditionStateId)
		/// <summary>
		/// Возвращает тип диерктивы по его Id
		/// </summary>
		/// <param name="conditionStateId"></param>
		/// <returns></returns>
		public static ConditionState GetItemById(Int32 conditionStateId)
		{
			foreach (var t in _Items)
				if (t.ItemId == conditionStateId)
					return t;
			//
			return UNK;
		}

		#endregion

		#region static public List<ConditionState> Items
		/// <summary>
		/// Возвращает список  элементов коллекции
		/// </summary>
		public static List<ConditionState> Items
		{
			get
			{
				return _Items;
			}
		}
		#endregion

		#region public override string ToString()

		/// <summary>
		/// Возвращает Name
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

		#region public ConditionState()
		/// <summary>
		/// Пустой конструктор
		/// </summary>
		public ConditionState()
		{
		}
		#endregion

		#region public ConditionState(Int32 itemId, String shortName, String fullName)
		/// <summary>
		/// Конструктор создает объект типа директивы
		/// </summary>
		/// <param name="itemId"></param>
		/// <param name="shortName"></param>
		/// <param name="fullName"></param>
		public ConditionState(Int32 itemId, String shortName, String fullName)
		{
			itemId = itemId;
			ShortName = shortName;
			FullName = fullName;

			_Items.Add(this);
		}
		#endregion
	}
}