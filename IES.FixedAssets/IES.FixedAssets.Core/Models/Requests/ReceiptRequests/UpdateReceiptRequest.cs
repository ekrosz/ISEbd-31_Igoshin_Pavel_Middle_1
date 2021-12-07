using System;

namespace IES.FixedAssets.Core.Models.Requests.ReceiptRequests
{
	public sealed class UpdateReceiptRequest
	{
		public Guid Id { get; set; }

		public string ProviderId { get; set; }

		public string ResponsibleId { get; set; }

		public string SubdivisionId { get; set; }

		public string Sum { get; set; }

		public string ReceiptDate { get; set; }

		public string OperationType { get; set; }

		public string Source { get; set; }
	}
}
