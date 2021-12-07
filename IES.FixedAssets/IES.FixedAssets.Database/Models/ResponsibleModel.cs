using System;
using System.Collections.Generic;

namespace IES.FixedAssets.Database.Models
{
	public class ResponsibleModel
	{
		public Guid Id { get; set; }

		public string Fio { get; set; }

		public List<ReceiptModel> Receipts { get; set; }
	}
}
