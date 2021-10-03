using IES.FixedAssets.Common.Enums;
using IES.FixedAssets.Core.Models.Requests.ReceiptRequests;
using System;

namespace IES.FixedAssets.Core.Helpers.Validators
{
	public static class ReceiptValidator
	{
		public static void Validate(this CreateReceiptRequest args)
		{
			args.ProviderId = Guid.TryParse(args.ProviderId, out var providerId)
				? providerId.ToString()
				: throw new Exception("Выбран неверный формат поставщика!");

			args.ReceiptDate = DateTime.TryParse(args.ReceiptDate, out var receiptDate)
				? receiptDate.ToString()
				: throw new Exception("Выбран неверный формат даты!");

			args.Sum = double.TryParse(args.Sum, out var sum)
				? Math.Round(sum, 2).ToString()
				: throw new Exception("Введен неверный формат суммы!");

			if (Enum.TryParse<OperationType>(args.OperationType, out var operationType))
			{
				args.OperationType = operationType.ToString();
			}
			else
			{
				switch (args.OperationType)
				{
					case "Выбытие":
						args.OperationType = OperationType.Disposal.ToString();
						break;

					case "Поступление":
						args.OperationType = OperationType.Receipt.ToString();
						break;

					default:
						throw new Exception("Выбран неверный формат типа операции!");
				}
			}
		}

		public static void Validate(this UpdateReceiptRequest args)
		{
			args.ProviderId = Guid.TryParse(args.ProviderId, out var providerId)
				? providerId.ToString()
				: throw new Exception("Выбран неверный формат поставщика!");

			args.ReceiptDate = DateTime.TryParse(args.ReceiptDate, out var receiptDate)
				? receiptDate.ToString()
				: throw new Exception("Выбран неверный формат даты!");

			args.Sum = double.TryParse(args.Sum, out var sum)
				? Math.Round(sum, 2).ToString()
				: throw new Exception("Введен неверный формат суммы!");

			if (Enum.TryParse<OperationType>(args.OperationType, out var operationType))
			{
				args.OperationType = operationType.ToString();
			}
			else
			{
				switch (args.OperationType)
				{
					case "Выбытие":
						args.OperationType = OperationType.Disposal.ToString();
						break;

					case "Поступление":
						args.OperationType = OperationType.Receipt.ToString();
						break;

					default:
						throw new Exception("Выбран неверный формат типа операции!");
				}
			}
		}
	}
}
