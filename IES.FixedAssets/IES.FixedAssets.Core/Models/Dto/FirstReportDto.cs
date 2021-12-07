using System;
using System.ComponentModel;

namespace IES.FixedAssets.Core.Models.Dto
{
	public class FirstReportDto
	{
		[DisplayName("ОС")]
		public string FixedAsset { get; set; }

		[DisplayName("Балансовая стоимость")]
		public decimal Balance { get; set; }

		[DisplayName("Количество")]
		public int Count { get; set; }

		[DisplayName("Дата поступления")]
		public DateTime ReceiptDate { get; set; }

		[DisplayName("Источник поступления")]
		public string Source { get; set; }
	}
}
