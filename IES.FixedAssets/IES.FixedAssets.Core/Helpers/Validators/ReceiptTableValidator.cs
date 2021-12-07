using IES.FixedAssets.Core.Models.Requests.ReceiptTableRequests;
using System;

namespace IES.FixedAssets.Core.Helpers.Validators
{
	public static class ReceiptTableValidator
	{
		public static void Validate(this CreateReceiptTableRequest args)
		{
			args.ReceiptId = Guid.TryParse(args.ReceiptId, out var receiptId)
				? args.ReceiptId = receiptId.ToString()
				: throw new Exception("Выбран неверный формат поступления!");

			args.FixedAssetId = Guid.TryParse(args.FixedAssetId, out var fixedAssetId)
				? args.FixedAssetId = fixedAssetId.ToString()
				: throw new Exception("Выбран неверный формат основного средства!");

			args.Count = int.TryParse(args.Count, out var count)
				? args.Count = count.ToString()
				: throw new Exception("Выбран неверный формат количества!");
		}

		public static void Validate(this UpdateReceiptTableRequest args)
		{
			args.ReceiptId = Guid.TryParse(args.ReceiptId, out var receiptId)
				? args.ReceiptId = receiptId.ToString()
				: throw new Exception("Выбран неверный формат поступления!");

			args.FixedAssetId = Guid.TryParse(args.FixedAssetId, out var fixedAssetId)
				? args.FixedAssetId = fixedAssetId.ToString()
				: throw new Exception("Выбран неверный формат основного средства!");

			args.Count = int.TryParse(args.Count, out var count)
				? args.Count = count.ToString()
				: throw new Exception("Выбран неверный формат количества!");
		}
	}
}
