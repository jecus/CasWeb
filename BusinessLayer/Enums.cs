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

}