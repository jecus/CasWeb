using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Views;
using Entity.Models.General;

namespace BusinessLayer
{
	public static class Extentions
	{
		public static TransferRecordView GetLast(this List<TransferRecordView> Items)
		{
			return Items.Count == 0 ? null : Items.OrderBy(r => r.TransferDate).Last();
		}

		public static int? GetFileIdByFileLinkType(this List<ItemFileLink> files, FileLinkType fileLinkType)
		{
			return files.FirstOrDefault(i => i.LinkType == (short)fileLinkType)?.FileId;
		}

        public static string ToUniversalString(this DateTime? dateTime)
        {
            return dateTime.HasValue ? dateTime.Value.ToString("yyyy.MM.dd") : "";
        }
	}
}