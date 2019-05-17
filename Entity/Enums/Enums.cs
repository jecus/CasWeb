namespace Entity.Enums
{
    #region public enum ProlongationWay

    public enum ProlongationWay
    {
        Unknown = -1,
        Auto = 1,
        Manually = 2
    }

    #endregion

    #region SpecialistPosition

    public enum SpecialistPosition : short
    {
        Unknown = -1,
        Probation = 1,
        Temporary = 2,
        Permanent = 3,
        Student = 4,
        Trainer = 5,
        Contractor = 6,
        InFullTime = 7,
        InLimitTime = 8
    }

    #endregion

    #region SpecialistStatus

    public enum SpecialistStatus : short
    {
        Unknown = -1,
        Dismissed = 1,
        InReserve = 2,
        Holiday = 3,
        Acting = 4,

    }

    #endregion

    #region public enum Gender : short
    /// <summary>
    /// Пол
    /// </summary>
    public enum Gender : short
    {
        /// <summary>
        /// Мужской
        /// </summary>
        Male = 1,
        /// <summary>
        /// Женский
        /// </summary>
        Female = 2,
        /// <summary>
        /// Не применимо
        /// </summary>
        NotApplicable = -1,

    }
    #endregion
}
