using System.Collections.Generic;

namespace BusinessLayer.Dictionaties
{
    public class DocumentType : StaticDictionary
    {
        #region private static List<DocumentType> _Items = new List<DocumentType>();
        /// <summary>
        /// Содержит все элементы
        /// </summary>
        private static List<DocumentType> _Items = new List<DocumentType>();
        #endregion

        /*
         * Предопределенные типы
         */

        #region public static DocumentType Document = new DocumentType(1, "Doc.", "Document");
        /// <summary>
        /// 
        /// </summary>
        public static DocumentType Document = new DocumentType(1, "Doc.", "Document");
        #endregion

        #region public static DocumentType Contract = new DocumentType(2, "Cont.", "Contract");
        /// <summary>
        /// 
        /// </summary>
        public static DocumentType Contract = new DocumentType(2, "Cont.", "Contract");
        #endregion

        #region public static DocumentType Certificate = new DocumentType(3, "Cert", "Certificate");
        /// <summary>
        /// 
        /// </summary>
        public static DocumentType Certificate = new DocumentType(3, "Cert", "Certificate");
        #endregion

        #region public static DocumentType Equipment = new DocumentType(4, "Equip", "Equipment");
        /// <summary>
        /// 
        /// </summary>
        public static DocumentType Equipment = new DocumentType(4, "Equip", "Equipment");
        #endregion

        #region public static DocumentType Forms = new DocumentType(5, "Form", "Forms");
        /// <summary>
        /// 
        /// </summary>
        public static DocumentType Forms = new DocumentType(5, "Form", "Forms");
        #endregion

        #region public static DocumentType Patent = new DocumentType(6, "Patent", "Patent");
        /// <summary>
        /// 
        /// </summary>
        public static DocumentType Patent = new DocumentType(6, "Patent", "Patent");
        #endregion

        #region public static DocumentType License = new DocumentType(7, "License", "License");
        /// <summary>
        /// 
        /// </summary>
        public static DocumentType License = new DocumentType(7, "License", "License");
        #endregion

        #region public static DocumentType Manuals = new DocumentType(8, "Manual", "Manual");
        /// <summary>
        /// 
        /// </summary>
        public static DocumentType Manuals = new DocumentType(8, "Manual", "Manual");
        #endregion

        #region public static DocumentType Requirements = new DocumentType(9, "Requirements", "Requirements");
        /// <summary>
        /// 
        /// </summary>
        public static DocumentType Requirements = new DocumentType(9, "Requirements", "Requirements");
        #endregion

        #region public static DocumentType TechnicalPublication = new DocumentType(10, "Technical Publication", "Technical Publication");
        /// <summary>
        /// 
        /// </summary>
        public static DocumentType TechnicalPublication = new DocumentType(10, "Technical Publication", "Technical Publication");

        #endregion

        #region public static DocumentType Act = new DocumentType(11, "Act", "Act");

        public static DocumentType Act = new DocumentType(11, "Act", "Act");

        #endregion

        #region public static DocumentType Protocol = new DocumentType(12, "Protocol", "Protocol");

        public static DocumentType Protocol = new DocumentType(12, "Protocol", "Protocol");

        #endregion

        #region public static DocumentType Instruction = new DocumentType(13, "Instruction", "Instruction");

        public static DocumentType Instruction = new DocumentType(13, "Instruction", "Instruction");

        #endregion

        #region public static DocumentType Program = new DocumentType(14, "Program", "Program");

        public static DocumentType Program = new DocumentType(14, "Program", "Program");

        #endregion

        #region public static DocumentType Library = new DocumentType(15, "Library", "Library");

        public static DocumentType Library = new DocumentType(15, "Library", "Library");

        #endregion

        #region public static DocumentType RegularPayments = new DocumentType(16, "Regular payments", "Regular payments");

        public static DocumentType RegularPayments = new DocumentType(16, "Regular payments", "Regular payments");

        #endregion

        #region public static DocumentType RequirementsCompany = new DocumentType(17, "Requirements company", "Requirements company");

        public static DocumentType RequirementsCompany = new DocumentType(17, "Requirements company", "Requirements company");

        #endregion

        #region public static DocumentType Letter = new DocumentType(18, "Letter", "Letter");

        public static DocumentType Letter = new DocumentType(18, "Letter", "Letter");

        #endregion

        #region public static DocumentType Order = new DocumentType(19, "Order", "Order");

        public static DocumentType Order = new DocumentType(19, "Order", "Order");

        #endregion

        #region public static DocumentType Explanatory = new DocumentType(20, "Explanatory", "Explanatory");

        public static DocumentType Explanatory = new DocumentType(20, "Explanatory", "Explanatory");

        #endregion

        #region public static DocumentType Statement = new DocumentType(21, "Statement", "Statement");

        public static DocumentType Statement = new DocumentType(21, "Statement", "Statement");

        #endregion

        #region public static DocumentType Report = new DocumentType(22, "Report", "Report");

        public static DocumentType Report = new DocumentType(22, "Report", "Report");

        #endregion

        #region public static DocumentType TechnicalRecords = new DocumentType(23, "Technical records", "Technical records");

        public static DocumentType TechnicalRecords = new DocumentType(23, "Technical records", "Technical records");

        #endregion

        public static DocumentType Permission = new DocumentType(24, "Permission", "Permission");

        #region public static DocumentType Other = new DocumentType(-1, "Oth", "Other");
        /// <summary> 
        /// Неизвестный объект
        /// </summary>
        public static DocumentType Other = new DocumentType(-1, "Oth", "Other");
        #endregion

        /*
         * Методы
         */

        #region public static DocumentType GetDocumentTypeById(Int32 DocumentTypeId)
        /// <summary>
        /// Возвращает тип диерктивы по его Id
        /// </summary>
        /// <param name="documentTypeId"></param>
        /// <returns></returns>
        public static DocumentType GetDocumentTypeById(int documentTypeId)
        {
            for (int i = 0; i < _Items.Count; i++)
                if (_Items[i].ItemId == documentTypeId)
                    return _Items[i];
            //
            return Other;
        }
        #endregion

        #region static public List<DocumentType> Items
        /// <summary>
        /// Возвращает список  элементов коллекции
        /// </summary>
        public static List<DocumentType> Items
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
            return FullName;
        }
        #endregion

        /*
         * Реализация
         */

        #region public DocumentType(Int16 ItemId, String shortName, String fullName)
        /// <summary>
        /// Конструктор создает объект типа директивы
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="shortName"></param>
        /// <param name="fullName"></param>
        public DocumentType(short itemId, string shortName, string fullName)
        {
            ItemId = itemId;
            ShortName = shortName;
            FullName = fullName;
            _Items.Add(this);
        }
        #endregion

        #region public DocumentType()

        public DocumentType()
        {

        }

        #endregion
    }
}