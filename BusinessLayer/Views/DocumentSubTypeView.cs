﻿namespace BusinessLayer.Views
{
    public class DocumentSubTypeView : BaseView
    {
        private static DocumentSubTypeView _unknown;
        public int DocumentTypeId { get; set; }

        public string Name { get; set; }

        #region public static DocumentSubType Unknown

        public static DocumentSubTypeView Unknown
        {
            get
            {
                return _unknown ?? (_unknown = new DocumentSubTypeView
                {
                    Id = -1,
                    Name = "Unknown"
                });
            }
        }

        #endregion

        public override string ToString()
        {
            return Name;
        }
    }
}