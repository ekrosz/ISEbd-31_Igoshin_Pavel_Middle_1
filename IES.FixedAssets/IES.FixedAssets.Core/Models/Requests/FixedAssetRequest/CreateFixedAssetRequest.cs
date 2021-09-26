using System;
using System.Collections.Generic;
using System.Text;

namespace IES.FixedAssets.Core.Models.Requests.FixedAssetRequest
{
	public sealed class CreateFixedAssetRequest
	{
		public string Name { get; set; }

		public string BalancePrice { get; set; }
	}
}
