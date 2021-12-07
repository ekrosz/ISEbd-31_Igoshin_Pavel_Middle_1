using System;

namespace IES.FixedAssets.Core.Models.Requests.ReceiptTableRequests
{
	public sealed class UpdateReceiptTableRequest
	{
		public Guid Id { get; set; }

		public string ReceiptId { get; set; }

		public string FixedAssetId { get; set; }

		public string Count { get; set; }
	}
}
