namespace IES.FixedAssets.Core.Models.Requests.ReceiptTableRequests
{
	public sealed class CreateReceiptTableRequest
	{
		public string ReceiptId { get; set; }

		public string FixedAssetId { get; set; }

		public string Count { get; set; }
	}
}
