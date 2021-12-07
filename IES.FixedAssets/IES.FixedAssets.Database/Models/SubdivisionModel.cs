using System;
using System.Collections.Generic;

namespace IES.FixedAssets.Database.Models
{
	public sealed class SubdivisionModel
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public List<ReceiptModel> Receipts { get; set; }
	}
}
