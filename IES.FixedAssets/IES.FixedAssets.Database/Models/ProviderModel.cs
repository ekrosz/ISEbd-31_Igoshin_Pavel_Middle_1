using System;
using System.Collections.Generic;

namespace IES.FixedAssets.Database.Models
{
	public class ProviderModel
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public List<ReceiptModel> Receipts { get; set; } = new List<ReceiptModel>();
	}
}
