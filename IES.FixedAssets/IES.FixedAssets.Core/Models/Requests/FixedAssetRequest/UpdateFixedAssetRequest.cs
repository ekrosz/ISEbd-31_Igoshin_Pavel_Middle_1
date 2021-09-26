using System;
using System.Collections.Generic;
using System.Text;

namespace IES.FixedAssets.Core.Models.Requests.FixedAssetRequest
{
	public sealed class UpdateFixedAssetRequest
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string BalancePrice { get; set; }
	}
}
