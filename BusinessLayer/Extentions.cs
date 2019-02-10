using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Views;

namespace BusinessLayer
{
	public static class Extentions
	{
		public static TransferRecordView GetLast(this List<TransferRecordView> Items)
		{
			return Items.Count == 0 ? null : Items.OrderBy(r => r.TransferDate).Last();
		}
	}
}