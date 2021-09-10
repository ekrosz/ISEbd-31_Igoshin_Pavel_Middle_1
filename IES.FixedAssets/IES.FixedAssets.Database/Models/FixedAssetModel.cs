using System;
using System.Collections.Generic;

namespace IES.FixedAssets.Database.Models
{
	public sealed class FixedAssetModel
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public double BalancePrice { get; set; }

		public List<ReceiptTableModel> ReceiptTables { get; set; } = new List<ReceiptTableModel>();
	}
}
