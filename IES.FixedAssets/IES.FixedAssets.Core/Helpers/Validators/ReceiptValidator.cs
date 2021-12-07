using IES.FixedAssets.Common.Enums;
using IES.FixedAssets.Core.Models.Requests.ReceiptRequests;
using System;

namespace IES.FixedAssets.Core.Helpers.Validators
{
	public static class ReceiptValidator
	{
		public static void Validate(this CreateReceiptRequest args)
		{
			if (!string.IsNullOrWhiteSpace(args.ProviderId))
			{
				args.ProviderId = Guid.TryParse(args.ProviderId, out var providerId)
					? providerId.ToString()
					: throw new Exception("Выбран неверный формат поставщика!");
			}

			if (!string.IsNullOrWhiteSpace(args.ResponsibleId))
			{
				args.ResponsibleId = Guid.TryParse(args.ResponsibleId, out var responsibleId)
					? responsibleId.ToString()
					: throw new Exception("Выбран неверный формат МОЛ!");
			}

			if (!string.IsNullOrWhiteSpace(args.SubdivisionId))
			{
				args.SubdivisionId = Guid.TryParse(args.SubdivisionId, out var subdivisionId)
					? subdivisionId.ToString()
					: throw new Exception("Выбран неверный формат подразделения!");
			}

			args.ReceiptDate = DateTime.TryParse(args.ReceiptDate, out var receiptDate)
				? receiptDate.ToString()
				: throw new Exception("Выбран неверный формат даты!");

			if (Enum.TryParse<OperationType>(args.OperationType, out var operationType))
			{
				args.OperationType = operationType.ToString();
			}
			else
			{
				switch (args.OperationType)
				{
					case "Ввод в эксплуатацию":
						args.OperationType = OperationType.Commissioning.ToString();
						break;

					case "Поступление":
						args.OperationType = OperationType.Receipt.ToString();
						break;

					default:
						throw new Exception("Выбран неверный формат типа операции!");
				}
			}

			if (!string.IsNullOrEmpty(args.Source))
			{
				if (Enum.TryParse<SourceReceipt>(args.Source, out var source))
				{
					args.Source = source.ToString();
				}
				else
				{
					switch (args.Source?.ToLower())
					{
						case "создано":
							args.Source = SourceReceipt.Created.ToString();
							break;

						case "куплено":
							args.Source = SourceReceipt.Bought.ToString();

							if (string.IsNullOrWhiteSpace(args.ProviderId))
								throw new Exception("Укажите поставщика!");
							break;

						default:
							throw new Exception("Выбран неверный формат источника поступления!");
					}
				}
			}
		}

		public static void Validate(this UpdateReceiptRequest args)
		{
			if (!string.IsNullOrWhiteSpace(args.ProviderId))
			{
				args.ProviderId = Guid.TryParse(args.ProviderId, out var providerId)
					? providerId.ToString()
					: throw new Exception("Выбран неверный формат поставщика!");
			}

			if (!string.IsNullOrWhiteSpace(args.ResponsibleId))
			{
				args.ResponsibleId = Guid.TryParse(args.ResponsibleId, out var responsibleId)
					? responsibleId.ToString()
					: throw new Exception("Выбран неверный формат МОЛ!");
			}

			if (!string.IsNullOrWhiteSpace(args.SubdivisionId))
			{
				args.SubdivisionId = Guid.TryParse(args.SubdivisionId, out var subdivisionId)
					? subdivisionId.ToString()
					: throw new Exception("Выбран неверный формат подразделения!");
			}

			args.ReceiptDate = DateTime.TryParse(args.ReceiptDate, out var receiptDate)
				? receiptDate.ToString()
				: throw new Exception("Выбран неверный формат даты!");

			if (Enum.TryParse<OperationType>(args.OperationType, out var operationType))
			{
				args.OperationType = operationType.ToString();
			}
			else
			{
				switch (args.OperationType)
				{
					case "Ввод в эксплуатацию":
						args.OperationType = OperationType.Commissioning.ToString();
						break;

					case "Поступление":
						args.OperationType = OperationType.Receipt.ToString();
						break;

					default:
						throw new Exception("Выбран неверный формат типа операции!");
				}
			}

			if (!string.IsNullOrWhiteSpace(args.Source))
			{
				if (Enum.TryParse<SourceReceipt>(args.Source, out var source))
				{
					args.Source = source.ToString();
				}
				else
				{
					switch (args.Source.ToLower())
					{
						case "создано":
							args.Source = SourceReceipt.Created.ToString();
							break;

						case "куплено":
							args.Source = SourceReceipt.Bought.ToString();

							if (string.IsNullOrWhiteSpace(args.ProviderId))
								throw new Exception("Укажите поставщика!");

							break;

						default:
							throw new Exception("Выбран неверный формат источника поступления!");
					}
				}
			}
		}
	}
}
