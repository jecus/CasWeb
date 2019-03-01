namespace BusinessLayer
{
	#region public enum MSG : short

	public enum MSG : short
	{
		Unknown = 0,
		MSG2 = 2,
		MSG3 = 3,
	}

	#endregion

	#region public enum Brakes : short

	public enum Brakes : short
	{
		/// <summary>
		/// 
		/// </summary>
		Carbon = 1,
		/// <summary>
		/// 
		/// </summary>
		Steel = 2,
	}

    #endregion

    #region public enum LandingGearMarkType : short
    /// <summary>
    /// Положения стоек шасси 
    /// </summary>
    public enum LandingGearMarkType : short
    {
        /// <summary>
        /// Тип отметки LandingGear - Основное
        /// </summary>
        General = 1,
        /// <summary>
        /// Тип отметки LandingGear - Левое
        /// </summary>
        Left = 2,
        /// <summary>
        /// Тип отметки LandingGear - Правое
        /// </summary>
        Right = 3,
        /// <summary>
        /// Не включено вовсе
        /// </summary>
        None = 0
    }
    #endregion

    #region public enum AvionicsInventoryMarkType: short
    /// <summary>
    /// Типы отметки AvionicsInventory
    /// </summary>
    public enum AvionicsInventoryMarkType : short
    {
        /// <summary>
        /// Тип отметки AvionicsInventory - обязательная
        /// </summary>
        Required = 1,
        /// <summary>
        /// Тип отметки AvionicsInventory - опциональная
        /// </summary>
        Optional = 2,
        /// <summary>
        /// Тип отметки AvionicsInventory - неизвестная
        /// </summary>
        Unknown = 3,
        /// <summary>
        /// Не включено вовсе
        /// </summary>
        None = 0
    }
    #endregion

    #region public enum ComponentStatus : short

    /// <summary>
    /// Перечисления статуса сомпонента (Новый, после Кап. ремонта, после Ремонта, после ТО )
    /// </summary>
    
    public enum ComponentStatus : short
    {
        Unknown = 0,

        New = 1,

        Serviceable = 4,

        Overhaul = 16,

        Repair = 64
    }

	#endregion

	#region public enum FileLinkType

	public enum FileLinkType
	{
		ADFile = 1,
		SBFile = 2,
		EOFile = 3,
		MaintenanceManualFile = 4,
		MaintenanceTaskNumberCheckFile = 5,
		MaintenanceMRBFile = 6,
		MaintenanceTaskCardNumberFile = 7,
		FaaFormFile = 8,
		NonRoutineJobTaskCardFile = 9,
		DocumentAttachedFile = 10,
		WorkPackageAttachedFile = 11,
		ATLBAttachedFile = 12,
		TransferRecordAttachedFile = 13,
		SpecialistResumeFile = 14,
		SpecialistPassportCopyFile = 15,
		DirectiveRecordAttachedFile = 16,
		MaintenanceCheckRecordAttachedFile = 17,
		AuditAttachedFile = 18,
		ProcedureCheckListFile = 19,
		ProcedureFile = 20,
		ComponentLLPCategoryChangeRecordAttachedFile = 21,
		SupplierDocumentAttachedFile = 22,
		DamageChartAttachedFile = 23,
		AircraftFlightAttachedFile = 24,
		ApuFailureDataAttachedFile = 25,
		DamageDocFile = 26,
		InspectionDocumentsFile = 27,
		PurchaseRequestRecordFile = 28,
		InitialOrderAttachedFile = 29,
		PurchaseOrderAttachedFile = 30,
		RequestForQuotationAttachedFile = 31,
		IncomingFile = 32,
		ComponentImageFile = 33,
		TrainingFormFile = 34,
		MailFormFile = 35,
		STCFile = 36,
		ProductFile = 37


	}

	#endregion

}