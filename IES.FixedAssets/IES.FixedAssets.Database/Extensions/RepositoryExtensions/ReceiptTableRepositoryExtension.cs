using IES.FixedAssets.Common.Enums;
using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using System;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Extensions.RepositoryExtensions
{
	public static class ReceiptTableRepositoryExtension
	{
		public static async Task<ReceiptTableModel> GetReceiptTableOrThrow(this IReceiptTableRepository receiptTableRepository, Guid receiptTableId)
			=> await receiptTableRepository.Get(receiptTableId)
				?? throw new Exception("Данная запись в табличной части не найдена!");

		public static async Task CheckFixedAssetsAvailabilityOrThrow(this IReceiptTableRepository receiptTableRepository, int count, ReceiptModel receiptModel, ReceiptTableModel receiptTableModel)
		{
			if (receiptModel.OperationType == OperationType.Commissioning)
			{
				var check = await receiptTableRepository.FixedAssetsAvailability(receiptTableModel.FixedAssetId, count, receiptModel.ReceiptDate, receiptTableModel.Id);

				if (!check)
					throw new Exception("Недостаточное количество данного основного средства для ввода в эксплуатацию!");
			}
		}
	}
}
