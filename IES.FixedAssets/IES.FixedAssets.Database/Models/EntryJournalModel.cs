using System;
using System.Collections.Generic;

namespace IES.FixedAssets.Database.Models
{
	public sealed class EntryJournalModel
	{
		public Guid Id { get; set; }

		public Guid DebitAccountId { get; set; }

		public Guid CreditAccountId { get; set; }

		public Guid ReceiptTableId { get; set; }

		public int Count { get; set; }

		public double Sum { get; set; }

		public DateTime DateEntry { get; set; }

		public DebitAccountChartModel DebitAccountChart { get; set; }

		public CreditAccountChartModel CreditAccountChart { get; set; }

		public ReceiptTableModel ReceiptTable { get; set; }
	}
}
