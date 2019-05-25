﻿using System;
using System.Collections.Generic;

namespace BusinessLayer.Dictionaties
{
    public class DeffectConfirm : StaticDictionary
    {
        #region private static CommonDictionaryCollection<DeffectConfirm> _Items = new CommonDictionaryCollection<DeffectConfirm>();
        /// <summary>
        /// Содержит все элементы
        /// </summary>
        private static List<DeffectConfirm> _Items = new List<DeffectConfirm>();
        #endregion


        public static DeffectConfirm Yes = new DeffectConfirm(1, "Yes", "Yes");
        public static DeffectConfirm No = new DeffectConfirm(2, "No", "No");

        #region public static DeffectConfirm UNK = new DeffectConfirm(-1, "N/A", "Not applicable");
        /// <summary>
        /// неизвестный
        /// </summary>
        public static DeffectConfirm UNK = new DeffectConfirm(-1, "N/A", "Not applicable");
        #endregion

        /*
         * Методы
         */

        #region public static DeffectConfirm GetItemById(Int32 maintenanceTypeId)
        /// <summary>
        /// Возвращает тип диерктивы по его Id
        /// </summary>
        /// <param name="maintenanceTypeId"></param>
        /// <returns></returns>
        public static DeffectConfirm GetItemById(int maintenanceTypeId)
        {
            foreach (DeffectConfirm t in _Items)
                if (t.ItemId == maintenanceTypeId)
                    return t;
            //
            return UNK;
        }

        #endregion

        #region static public CommonDictionaryCollection<DeffectConfirm> Items
        /// <summary>
        /// Возвращает список  элементов коллекции
        /// </summary>
        public static List<DeffectConfirm> Items
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
        #region public DeffectConfirm()
        /// <summary>
        /// Конструктор создает объект повреждения
        /// </summary>
        public DeffectConfirm()
        {
        }
        #endregion

        #region public DeffectConfirm(Int32 itemId, String shortName, String fullName)

        /// <summary>
        /// Конструктор создает объект повреждения
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="shortName"></param>
        /// <param name="fullName"></param>
        public DeffectConfirm(int itemId, string shortName, string fullName)
        {
            ItemId = itemId;
            ShortName = shortName;
            FullName = fullName;

            _Items.Add(this);
        }
        #endregion

    }
}