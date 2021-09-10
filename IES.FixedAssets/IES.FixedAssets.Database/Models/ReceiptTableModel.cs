using System;
using System.Collections.Generic;

namespace IES.FixedAssets.Database.Models
{
	public class ReceiptTableModel
	{
		public Guid Id { get; set; }

		public Guid ReceiptId { get; set; }

		public Guid FixedAssetId { get; set; }

		public int Count { get; set; }

		public double Sum { get; set; }

		public ReceiptModel Receipt { get; set; }

		public FixedAssetModel FixedAsset { get; set; }

		public List<EntryJournalModel> EntryJournals { get; set; } = new List<EntryJournalModel>();
	}
}
