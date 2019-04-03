using System;
using System.Collections.Generic;

namespace BusinessLayer.Dictionaties
{
    public class OccurrenceType : StaticDictionary
    {
        #region private static CommonDictionaryCollection<ConsequenceType> _Items = new CommonDictionaryCollection<ConsequenceType>();
        /// <summary>
        /// Содержит все элементы
        /// </summary>
        private static List<OccurrenceType> _Items = new List<OccurrenceType>();
        #endregion


        public static OccurrenceType Cancellation = new OccurrenceType(1, "Cancellation", "Cancellation");
        public static OccurrenceType Delay = new OccurrenceType(2, "Delay", "Delay");
        public static OccurrenceType Diversion = new OccurrenceType(3, "Diversion", "Diversion");
        public static OccurrenceType None = new OccurrenceType(-1, "None", "None");


        /*
         * Методы
         */

        #region public static ConsequenceType GetItemById(Int32 maintenanceTypeId)
        /// <summary>
        /// Возвращает тип диерктивы по его Id
        /// </summary>
        /// <param name="maintenanceTypeId"></param>
        /// <returns></returns>
        public static OccurrenceType GetItemById(Int32 maintenanceTypeId)
        {
            foreach (OccurrenceType t in _Items)
                if (t.ItemId == maintenanceTypeId)
                    return t;
            //
            return None;
        }

        #endregion

        #region static public CommonDictionaryCollection<ConsequenceType> Items
        /// <summary>
        /// Возвращает список  элементов коллекции
        /// </summary>
        public static List<OccurrenceType> Items
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
        #region public ConsequenceType()
        /// <summary>
        /// Конструктор создает объект повреждения
        /// </summary>
        public OccurrenceType()
        {
        }
        #endregion

        #region public ConsequenceType(Int32 itemId, String shortName, String fullName)

        /// <summary>
        /// Конструктор создает объект повреждения
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="shortName"></param>
        /// <param name="fullName"></param>
        public OccurrenceType(Int32 itemId, String shortName, String fullName)
        {
            ItemId = itemId;
            ShortName = shortName;
            FullName = fullName;

            _Items.Add(this);
        }
        #endregion
        
    }
}