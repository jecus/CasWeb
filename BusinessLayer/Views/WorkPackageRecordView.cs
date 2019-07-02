﻿using System;

namespace BusinessLayer.Views
{
	public class WorkPackageRecordView : BaseView
	{
		public WorkPackageView WorkPakage { get; set; }

		public int DirectivesId { get; set; }

		public int WorkPackageItemType { get; set; }

		public int PerfNumFromStart { get; set; }

		public int PerfNumFromRecord { get; set; }

		public int? FromRecordId { get; set; }

		public int Group { get; set; }

		public int ParentCheckId { get; set; }

		public string JobCardNumber { get; set; }

		public IWprTask Task { get; set; }
	}


	public interface IWprTask
	{
		ATAChapterView AtaChapterView { get; }
		string Title { get; }
		string Description { get; }
		Lifelength FirstPerformance { get; }
		Lifelength RepeatInterval { get; }
		string WorkType { get; }
		string NDT { get; }
		string PerfDate { get; }
		double MH { get; }
		double KMH { get; }
		double Cost { get; }
		string Type { get; }
	}

	public class WprTask:IWprTask
	{
		public ATAChapterView AtaChapterView { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public Lifelength FirstPerformance { get; set; }
		public Lifelength RepeatInterval { get; set; }
		public string WorkType { get; set; }
		public string NDT { get; set; }
		public string PerfDate { get; set; }
		public double MH { get; set; }
		public double KMH { get; set; }
		public double Cost { get; set; }
		public string Type { get; set; }
	}
}