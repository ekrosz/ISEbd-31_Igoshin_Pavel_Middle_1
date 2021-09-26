using System;

namespace IES.FixedAssets.Core.Models.Dto
{
	public sealed class FixedAssetDto
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public double BalancePrice { get; set; }
	}
}
