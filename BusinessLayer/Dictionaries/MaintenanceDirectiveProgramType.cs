﻿using System;
using System.Collections.Generic;

namespace BusinessLayer.Dictionaties
{
	public class MaintenanceDirectiveProgramType : StaticDictionary
	{
		#region Properties

		public MSG MSG { get; set; }

		#endregion

		#region private static CommonDictionaryCollection<MaintenanceDirectiveProgrammType> _Items = new CommonDictionaryCollection<MaintenanceDirectiveProgrammType>();
		/// <summary>
		/// Содержит все элементы
		/// </summary>
		private static List<MaintenanceDirectiveProgramType> _Items = new List<MaintenanceDirectiveProgramType>();
		#endregion

		/*
         * Предопределенные типы
         */

		#region public static MaintenanceDirectiveProgramType SystemsAndPowerPlants = new MaintenanceDirectiveProgramType(1, "Systems", "Systems and Power Plants", "", MSG.MSG3);
		/// <summary>
		/// 
		/// </summary>
		public static MaintenanceDirectiveProgramType SystemsAndPowerPlants = new MaintenanceDirectiveProgramType(1, "SYS", "Systems and Power Plants", "", MSG.MSG3);
		#endregion

		#region public static MaintenanceDirectiveProgramType ZonalInspection = new MaintenanceDirectiveProgramType(2, "Zonal", "Zonal Inspection", "", MSG.MSG3);
		/// <summary>
		/// 
		/// </summary>
		public static MaintenanceDirectiveProgramType ZonalInspection = new MaintenanceDirectiveProgramType(2, "Zonal", "Zonal Inspection Program", "", MSG.MSG3);
		#endregion

		#region public static MaintenanceDirectiveProgramType StructuresMaintenance = new MaintenanceDirectiveProgramType(3, "Structures", "Structures Maintenance", "", MSG.MSG3);
		/// <summary>
		/// 
		/// </summary>
		public static MaintenanceDirectiveProgramType StructuresMaintenance = new MaintenanceDirectiveProgramType(3, "STR", "Structures Maintenance", "", MSG.MSG3);
		#endregion

		#region public static MaintenanceDirectiveProgramType WingLet = new MaintenanceDirectiveProgramType(4, "WingLet", "WingLet", "", MSG.MSG3);
		/// <summary>
		/// 
		/// </summary>
		public static MaintenanceDirectiveProgramType WingLet = new MaintenanceDirectiveProgramType(4, "WingLet", "WingLet", "", MSG.MSG3);
		#endregion

		#region public static MaintenanceDirectiveProgramType AWLandCMR = new MaintenanceDirectiveProgramType(5, "AWL + CMR", "AIRWORTHINESS LIMITATION and CERTIFICATION MAINTENANCE REQUIREMENTS", "", MSG.MSG3);
		/// <summary>
		/// 
		/// </summary>
		public static MaintenanceDirectiveProgramType AWLandCMR =
			new MaintenanceDirectiveProgramType(5, "AWL", "Airworthiness Limitation", "", MSG.MSG3);
		#endregion

		#region public static MaintenanceDirectiveProgramType LineMaintenance = new MaintenanceDirectiveProgramType(6, "Line", "Line Maintenance", "", MSG.MSG3);
		/// <summary>
		/// 
		/// </summary>
		public static MaintenanceDirectiveProgramType LineMaintenance = new MaintenanceDirectiveProgramType(6, "Line", "Line Maintenance", "", MSG.MSG3);
		#endregion

		#region public static MaintenanceDirectiveProgramType SystemsMaintenance = new MaintenanceDirectiveProgramType(23, "Systems", "Systems Maintenance", "", MSG.MSG2);
		/// <summary>
		/// 
		/// </summary>
		public static MaintenanceDirectiveProgramType SystemsMaintenance = new MaintenanceDirectiveProgramType(23, "SYS", "Systems Maintenance", "", MSG.MSG2);
		#endregion

		#region public static MaintenanceDirectiveProgramType CPCP = new MaintenanceDirectiveProgramType(24, "CPCP", "CPCP", "CPCP", MSG.MSG2);
		/// <summary>
		/// 
		/// </summary>
		public static MaintenanceDirectiveProgramType CPCP = new MaintenanceDirectiveProgramType(24, "CPCP", "Corrosion Prevention & Control Program ", "CPCP", MSG.MSG2);
		#endregion

		#region public static MaintenanceDirectiveProgramType EngineItems = new MaintenanceDirectiveProgramType(25, "Components", "Components Maintenance", "", MSG.MSG2);
		/// <summary>
		/// 
		/// </summary>
		public static MaintenanceDirectiveProgramType EngineItems = new MaintenanceDirectiveProgramType(25, "Components", "Components Maintenance", "", MSG.MSG2);
		#endregion

		#region public static MaintenanceDirectiveProgramType CorrosionProtection = new MaintenanceDirectiveProgramType(26, "CPP", "Corrosion Protection Program", "", MSG.MSG2);
		/// <summary>
		/// 
		/// </summary>
		public static MaintenanceDirectiveProgramType CorrosionProtection = new MaintenanceDirectiveProgramType(26, "CPP", "Corrosion Protection Program", "", MSG.MSG2);
		#endregion

		#region public static MaintenanceDirectiveProgramType StructuralInspection = new MaintenanceDirectiveProgramType(27, "SI", "Structural Inspection", "", MSG.MSG2);
		/// <summary>
		/// 
		/// </summary>
		public static MaintenanceDirectiveProgramType StructuralInspection = new MaintenanceDirectiveProgramType(27, "SIP", "Structural Inspection Program", "", MSG.MSG2);
		#endregion

		#region public static MaintenanceDirectiveProgramType Storage = new MaintenanceDirectiveProgramType(28, "Storage", "Storage", "", MSG.MSG3);
		/// <summary>
		/// 
		/// </summary>
		public static MaintenanceDirectiveProgramType Storage = new MaintenanceDirectiveProgramType(28, "Storage", "Storage", "", MSG.MSG3);
		#endregion

		public static MaintenanceDirectiveProgramType CertificationMaintenanceRequirement = new MaintenanceDirectiveProgramType(29, "CMR", "Certification Maintenance Requirement", "", MSG.MSG3);
		public static MaintenanceDirectiveProgramType FuelTankSystemMaintenanceProgram = new MaintenanceDirectiveProgramType(30, "FTS", "Fuel Tank System Maintenance Program", "", MSG.MSG3);
		public static MaintenanceDirectiveProgramType SupplementalStructuralInspectionProgram = new MaintenanceDirectiveProgramType(31, "SSIP", "Supplemental Structural Inspection Program", "", MSG.MSG3);
		public static MaintenanceDirectiveProgramType ElectricalWipingInterconnectionSystem = new MaintenanceDirectiveProgramType(32, "EWIS", "Electrical Wiping Interconnection System", "", MSG.MSG3);
		public static MaintenanceDirectiveProgramType SupplementaltypeCertificate = new MaintenanceDirectiveProgramType(33, "STC", "Supplemental type Certificate", "", MSG.MSG3);
		public static MaintenanceDirectiveProgramType SpecialCompliance = new MaintenanceDirectiveProgramType(34, "SCIAWL", "Special Compliance Item/Airworthiness Limitation", "", MSG.MSG3);
		public static MaintenanceDirectiveProgramType ISIP = new MaintenanceDirectiveProgramType(35, "ISIP", "Integrated Structural Inspection Program", "", MSG.MSG3);
		public static MaintenanceDirectiveProgramType SupplementaryRequirements = new MaintenanceDirectiveProgramType(36, "SR", "Supplementary Requirements", "", MSG.MSG3);
		public static MaintenanceDirectiveProgramType OptionalMaintenance = new MaintenanceDirectiveProgramType(37, "OM", "Optional Maintenance", "", MSG.MSG3);
		public static MaintenanceDirectiveProgramType MaintenancePractices = new MaintenanceDirectiveProgramType(38, "MP", "Maintenance Practices", "", MSG.MSG3);
		public static MaintenanceDirectiveProgramType Unscheduled = new MaintenanceDirectiveProgramType(39, "US", "Unscheduled", "", MSG.MSG3);
		public static MaintenanceDirectiveProgramType OutOfPhase = new MaintenanceDirectiveProgramType(40, "OOP", "Out of Phase", "", MSG.MSG3);

		#region public static MaintenanceDirectiveProgrammType Unknown = new MaintenanceDirectiveProgrammType(-1, "Unknown", "Unknown", "Unknown", MSG.MSG1);
		/// <summary> 
		/// Неизвестный объект
		/// </summary>
		public static MaintenanceDirectiveProgramType Unknown = new MaintenanceDirectiveProgramType(-1, "Unknown", "Unknown", "Unknown", MSG.Unknown);
		#endregion

		/*
         * Методы
         */

		#region public static MaintenanceDirectiveProgrammType GetItemById(Int32 directiveTypeId)
		/// <summary>
		/// Возвращает тип диерктивы по его Id
		/// </summary>
		/// <param name="directiveTypeId"></param>
		/// <returns></returns>
		public static MaintenanceDirectiveProgramType GetItemById(int directiveTypeId)
		{
			foreach (MaintenanceDirectiveProgramType t in _Items)
				if (t.ItemId == directiveTypeId)
					return t;
			//
			return Unknown;
		}

		#endregion

		#region public static IEnumerable<MaintenanceDirectiveProgramType> Items
		/// <summary>
		/// Возвращает список элементов коллекции
		/// </summary>
		public static IEnumerable<MaintenanceDirectiveProgramType> Items
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
			return $"{FullName} ({ShortName})";
		}
		#endregion

		/*
         * Реализация
         */
		#region public MaintenanceDirectiveProgrammType()
		public MaintenanceDirectiveProgramType()
		{

		}
		#endregion

		#region public MaintenanceDirectiveProgrammType(Int32 itemId, String shortName, String fullName, String commonName, MSG msg)

		/// <summary>
		/// Конструктор создает объект типа директивы
		/// </summary>
		/// <param name="itemId"></param>
		/// <param name="shortName"></param>
		/// <param name="fullName"></param>
		/// <param name="commonName"></param>
		/// <param name="msg"></param>
		public MaintenanceDirectiveProgramType(int itemId, string shortName, string fullName, string commonName,
											   MSG msg)
		{
			ItemId = itemId;
			ShortName = shortName;
			FullName = fullName;
			CommonName = commonName;
			MSG = msg;
			_Items.Add(this);
		}
		#endregion
	}
}