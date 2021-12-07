using System;
using System.ComponentModel;

namespace IES.FixedAssets.Core.Models.Dto
{
	public class SecondReportDto
	{
		[DisplayName("ОС")]
		public string FixedAsset { get; set; }

		[DisplayName("Балансовая стоимость")]
		public decimal Balance { get; set; }

		[DisplayName("Количество")]
		public int Count { get; set; }

		[DisplayName("Дата ввода в эксплуатацию")]
		public DateTime ComissioningDate { get; set; }

		[DisplayName("Подразделение")]
		public string Subdivision { get; set; }
	}
}
