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
            return dateTime.HasValue ? dateTime.Value.ToString("dd.MM.yyyy") : "";
        }

        #region public static string TimeToString(TimeSpan time)

        /// <summary>
        /// Представляет время в виде строки
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string TimeToString(this TimeSpan time)
        {
            string s1 = IntToString(time.Hours, 2);
            string s2 = IntToString(time.Minutes, 2);
            return s1 + ":" + s2;
        }

        #endregion

        #region public static string IntToString(int i, int length)

        /// <summary>
        /// Возвращает число и дополняет число ведущими нулями до нужной длинны
        /// </summary>
        /// <param name="i"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string IntToString(int i, int length)
        {
            string s = i.ToString();

            if (s.Length < length)
            {
                s = new string('0', length - s.Length) + s;
            }
            return s;
        }

        #endregion
    }
}