namespace BusinessLayer
{
	#region public enum ThresholdConditionType

	public enum ThresholdConditionType
	{
		/// <summary>
		/// Директива выполнится при выполнении одного из условий
		/// </summary>
		WhicheverFirst = 0,
		/// <summary>
		/// Директива выполнится при выполнении всех условий 
		/// </summary>
		WhicheverLater = 1,
	}

	#endregion

	#region public enum ADType : short
	public enum ADType : short
	{
		Airframe = 0,
		Apliance = 1,
		None = 2,
		LandingGear = 3,
		Engine = 4,
		APU = 5

	}
	#endregion

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

    #region ATLB

    public enum AtlbStatus
    {
        Opened = 0,
        Closed = 1,
    }

    #endregion

    #region public enum AtlbRecordType : short
    /// <summary>
    /// Тип записи борт-журнала
    /// </summary>
    public enum AtlbRecordType : short
    {
        /// <summary>
        /// Полет
        /// </summary>
        Flight = 1,
        /// <summary>
        /// Тех. обслуживание
        /// </summary>
        Maintenance = 2,
    }
    #endregion

    #region public enum FlightCategory : short
    /// <summary>
    /// Категория Полета (Внутренний рейс, Международный рейс и т.д.)
    /// </summary>
    public enum FlightCategory : short
    {
        /// <summary>
        /// Неизветсный
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Внутренний рейс
        /// </summary>
        DomesticFlight = 1,
        /// <summary>
        /// Международный рейс
        /// </summary>
        InternationalFlight = 2,
        /// <summary>
        /// Ближнее зарубежье
        /// </summary>
        NearAbroad = 3,
    }
    #endregion

    #region public enum FlightAircraftCode : short
    /// <summary>
    /// Код ВС на полет
    /// </summary>
    //[Flags]
    public enum FlightAircraftCode : short
    {
        /// <summary>
        /// Неизвестно
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Пассажирское
        /// </summary>
        P = 1,
        /// <summary>
        /// Грузовое, не перевозящее пассажиров
        /// </summary>
        F = 2,
        /// <summary>
        /// Смешанное (перевозящее пассажиров и груз)
        /// </summary>
        M = 4,
    }
    #endregion

    #region public enum CalendarTypes
    /// <summary>
    /// Типы отображения календарной наработки
    /// </summary>
    public enum CalendarTypes
    {
        /// <summary>
        /// В днях
        /// </summary>
        Days = 0,
        /// <summary>
        /// В месяцах
        /// </summary>
        Months = 1,
        /// <summary>
        /// В годах
        /// </summary>
        Years = 2
    }
    #endregion

    #region public enum CorrectiveActionStatus
    /// <summary>
    /// Статус выполнения корректирующего действия
    /// </summary>
    public enum CorrectiveActionStatus
    {
        /// <summary>
        /// Корректирующее действие не выполнено
        /// </summary>
        Open = 0,
        /// <summary>
        /// Корректирующее действие выполнено
        /// </summary>
        Close = 1,
        Publish = 2
    }
	#endregion

	#region public enum WorkPackageStatus : short
	/// <summary>
	/// Статус (состояние) рабочего пакета
	/// </summary>
	public enum WorkPackageStatus : short
	{
		/// <summary>
		/// Все состояния (открыт, закрыт, на исполнении)
		/// </summary>
		All = 0,
		/// <summary>
		/// Рабочий пакет открыт
		/// </summary>
		Opened = 1,

		/// <summary>
		/// Рабочий пакет отправлен на выполнение
		/// </summary>
		Published = 2,

		/// <summary>
		/// Рабочий пакет закрыт
		/// </summary>
		Closed = 3,

	}
	#endregion

	#region LifelengthSubResource

	public enum LifelengthSubResource
	{
		/// <summary>
		/// минуты
		/// </summary>
		Minutes = 0,

		/// <summary>
		/// часы
		/// </summary>
		Hours = 1,

		/// <summary>
		/// Циклы
		/// </summary>
		Cycles = 2,

		/// <summary>
		/// Дни
		/// </summary>
		Calendar = 3,

	}

	#endregion
}