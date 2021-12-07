using IES.FixedAssets.Common.Enums;
using System;
using System.Collections.Generic;

namespace IES.FixedAssets.Database.Models
{
	public sealed class ReceiptModel
	{
		public Guid Id { get; set; }

		public Guid? ProviderId { get; set; }

		public Guid? ResponsibleId { get; set; }

		public Guid? SubdivisionId { get; set; }

		public int OperationNumber { get; set; }

		public double Sum { get; set; }

		public DateTime ReceiptDate { get; set; }

		public OperationType OperationType { get; set; }

		public SourceReceipt? Source { get; set; }

		public ProviderModel Provider { get; set; }

		public ResponsibleModel Responsible { get; set; }

		public SubdivisionModel Subdivision { get; set; }

		public List<ReceiptTableModel> ReceiptTables { get; set; } = new List<ReceiptTableModel>();
	}
}
