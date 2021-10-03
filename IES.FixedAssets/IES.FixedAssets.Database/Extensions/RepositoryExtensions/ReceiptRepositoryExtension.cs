using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using System;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Extensions.RepositoryExtensions
{
	public static class ReceiptRepositoryExtension
	{
		public static async Task<ReceiptModel> GetReceiptOrThrow(this IReceiptRepository receiptRepository, Guid receiptId)
		{
			var entity = await receiptRepository.Get(receiptId);

			if (entity == null)
				throw new Exception("Данная операция не найдена");

			return entity;
		}
	}
}
