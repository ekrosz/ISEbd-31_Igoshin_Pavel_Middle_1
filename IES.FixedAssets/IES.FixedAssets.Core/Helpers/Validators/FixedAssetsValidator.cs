using IES.FixedAssets.Core.Models.Requests.FixedAssetRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace IES.FixedAssets.Core.Helpers.Validators
{
	public static class FixedAssetsValidator
	{
		public static void Validate(this CreateFixedAssetRequest args)
		{
			if (double.TryParse(args.BalancePrice, out var result))
			{
				args.BalancePrice = Math.Round(result, 2).ToString();

				return;
			}

			//TODO: Create local exception
			throw new Exception("Введен неверный формат числа");
		}

		public static void Validate(this UpdateFixedAssetRequest args)
		{
			if (double.TryParse(args.BalancePrice, out var result))
			{
				args.BalancePrice = Math.Round(result, 2).ToString();

				return;
			}

			//TODO: Create local exception
			throw new Exception("Введен неверный формат числа");
		}
	}
}
