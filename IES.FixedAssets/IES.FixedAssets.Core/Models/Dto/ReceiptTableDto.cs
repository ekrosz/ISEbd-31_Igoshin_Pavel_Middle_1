using System;
using System.ComponentModel;

namespace IES.FixedAssets.Core.Models.Dto
{
	public sealed class ReceiptTableDto
	{
		public Guid Id { get; set; }

		public Guid FixedAssetId { get; set; }

		public Guid ReceiptId { get; set; }

		[DisplayName("Основное средство")]
		public string FixedAssetName { get; set; }

		[DisplayName("Сумма")]
		public double Sum { get; set; }

		[DisplayName("Количество")]
		public int Count { get; set; }
	}
}
