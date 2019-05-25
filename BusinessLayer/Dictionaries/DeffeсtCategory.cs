using System;
using System.Collections.Generic;

namespace BusinessLayer.Dictionaties
{
    public class DeffeсtCategory : StaticDictionary
    {
        #region private static CommonDictionaryCollection<DeffeсtCategory> _Items = new CommonDictionaryCollection<DeffeсtCategory>();
        /// <summary>
        /// Содержит все элементы
        /// </summary>
        private static List<DeffeсtCategory> _Items = new List<DeffeсtCategory>();
        #endregion


        public static DeffeсtCategory CAT1 = new DeffeсtCategory(1, "CAT1", "CAT1");
        public static DeffeсtCategory CAT2 = new DeffeсtCategory(2, "CAT2", "CAT2");
        public static DeffeсtCategory CAT3 = new DeffeсtCategory(3, "CAT3", "CAT3");
        public static DeffeсtCategory CAT4 = new DeffeсtCategory(4, "CAT4", "CAT4");

        #region public static DeffeсtCategory UNK = new DeffeсtCategory(-1, "N/A", "Not applicable");
        /// <summary>
        /// неизвестный
        /// </summary>
        public static DeffeсtCategory UNK = new DeffeсtCategory(-1, "N/A", "Not applicable");
        #endregion

        /*
         * Методы
         */

        #region public static DeffeсtCategory GetItemById(Int32 maintenanceTypeId)
        /// <summary>
        /// Возвращает тип диерктивы по его Id
        /// </summary>
        /// <param name="maintenanceTypeId"></param>
        /// <returns></returns>
        public static DeffeсtCategory GetItemById(int maintenanceTypeId)
        {
            foreach (DeffeсtCategory t in _Items)
                if (t.ItemId == maintenanceTypeId)
                    return t;
            //
            return UNK;
        }

        #endregion

        #region static public CommonDictionaryCollection<DeffeсtCategory> Items
        /// <summary>
        /// Возвращает список  элементов коллекции
        /// </summary>
        public static List<DeffeсtCategory> Items
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
        #region public DeffeсtCategory()
        /// <summary>
        /// Конструктор создает объект повреждения
        /// </summary>
        public DeffeсtCategory()
        {
        }
        #endregion

        #region public DeffeсtCategory(Int32 itemId, String shortName, String fullName)

        /// <summary>
        /// Конструктор создает объект повреждения
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="shortName"></param>
        /// <param name="fullName"></param>
        public DeffeсtCategory(int itemId, string shortName, string fullName)
        {
            ItemId = itemId;
            ShortName = shortName;
            FullName = fullName;

            _Items.Add(this);
        }
        #endregion
    }
}