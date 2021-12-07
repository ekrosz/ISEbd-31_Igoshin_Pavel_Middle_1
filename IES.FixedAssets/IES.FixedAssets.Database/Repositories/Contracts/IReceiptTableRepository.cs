using IES.FixedAssets.Database.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories.Contracts
{
	public interface IReceiptTableRepository
	{
		Task<IReadOnlyCollection<ReceiptTableModel>> GetAll();

		Task<IReadOnlyCollection<ReceiptTableModel>> GetReceiptTablesByReceipt(Guid receiptId);

		Task<ReceiptTableModel> GetReceiptTableByFixedAsset(Guid receiptId, Guid fixedAssetId);

		Task<double> GetTotalSumByReceipt(Guid receiptId);

		Task<bool> FixedAssetsAvailability(Guid fixedAssetId, int count, DateTime date, Guid? receiptTableId = null);

		Task<int> GetFixedAssetsCountWithProvider(Guid fixedAssetId, DateTime date);

		Task<int> GetFixedAssetsCountWithoutProvider(Guid fixedAssetId, DateTime date);

		Task<ReceiptTableModel> Get(Guid id);

		Task Create(ReceiptTableModel entity);

		Task Update(ReceiptTableModel entity);

		Task Delete(ReceiptTableModel entity);
	}
}
