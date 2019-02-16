﻿using Entity.Models;

namespace BusinessLayer.Views
{
    public class NomenclatureView : BaseView
    {
        private static NomenclatureView _unknown;

        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public string FullName { get; set; }

        #region public static Nomenclatures Unknown

        public static NomenclatureView Unknown
        {
            get
            {
                return _unknown ?? (_unknown = new NomenclatureView
                {
                    ItemId = -1,
                    FullName = "Unknown",
                    Name = "UNK",
                });
            }
        }

        #endregion
    }
}