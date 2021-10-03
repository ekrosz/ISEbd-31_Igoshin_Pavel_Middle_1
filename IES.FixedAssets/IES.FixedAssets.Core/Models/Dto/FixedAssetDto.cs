using System;
using System.ComponentModel;

namespace IES.FixedAssets.Core.Models.Dto
{
	public sealed class FixedAssetDto
	{
		public Guid Id { get; set; }

		[DisplayName("Наименование")]
		public string Name { get; set; }

		[DisplayName("Балансовая стоимость")]
		public double BalancePrice { get; set; }
	}
}
