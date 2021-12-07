using IES.FixedAssets.Common.Enums;
using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories
{
	public class ReceiptTableRepository : IReceiptTableRepository
	{
		private readonly FixedAssetsContext _context;

		public ReceiptTableRepository(FixedAssetsContext context)
		{
			_context = context;
		}

		public async Task Create(ReceiptTableModel entity)
		{
			await _context.ReceiptTables.AddAsync(entity);

			await _context.SaveChangesAsync();
		}

		public async Task Delete(ReceiptTableModel entity)
		{
			_context.ReceiptTables.Remove(entity);

			await _context.SaveChangesAsync();
		}

		public async Task<ReceiptTableModel> Get(Guid id)
		{
			return await _context.ReceiptTables
				.SingleOrDefaultAsync(e => e.Id == id);
		}

		public async Task<IReadOnlyCollection<ReceiptTableModel>> GetAll()
		{
			return await _context.ReceiptTables
				.AsNoTracking()
				.ToArrayAsync();
		}

		public async Task<ReceiptTableModel> GetReceiptTableByFixedAsset(Guid receiptId, Guid fixedAssetId)
		{
			return await _context.ReceiptTables
				.FirstOrDefaultAsync(e => e.ReceiptId == receiptId && e.FixedAssetId == fixedAssetId);
		}

		public async Task<IReadOnlyCollection<ReceiptTableModel>> GetReceiptTablesByReceipt(Guid receiptId)
		{
			return await _context.ReceiptTables
				.AsNoTracking()
				.Where(e => e.ReceiptId == receiptId)
				.ToArrayAsync();
		}

		public async Task<double> GetTotalSumByReceipt(Guid receiptId)
		{
			return await _context.ReceiptTables
				.AsNoTracking()
				.Where(e => e.ReceiptId == receiptId)
				.SumAsync(e => e.Sum);
		}

		public async Task Update(ReceiptTableModel entity)
		{
			_context.ReceiptTables.Update(entity);

			await _context.SaveChangesAsync();
		}

		public async Task<bool> FixedAssetsAvailability(Guid fixedAssetId, int count, DateTime date, Guid? receiptTableId = null)
		{
			var fixedAssetsCount = await _context.ReceiptTables
				.Include(e => e.Receipt)
				.Where(e => 
					e.Receipt.OperationType == OperationType.Receipt && e.FixedAssetId == fixedAssetId && e.Receipt.ReceiptDate.Date <= date.Date)
				.SumAsync(e => e.Count) 
				- 
				await _context.ReceiptTables
				.Include(e => e.Receipt)
				.Where(e =>
					e.Receipt.OperationType == OperationType.Commissioning && e.FixedAssetId == fixedAssetId && e.Receipt.ReceiptDate.Date <= date.Date && e.Id != receiptTableId)
				.SumAsync(e => e.Count);

			return fixedAssetsCount - count >= 0;
		}

		public async Task<int> GetFixedAssetsCountWithProvider(Guid fixedAssetId, DateTime date)
		{
			return await _context.ReceiptTables
				.Include(e => e.Receipt)
				.Where(e => e.Receipt.OperationType == OperationType.Receipt && e.Receipt.ProviderId.HasValue && e.FixedAssetId == fixedAssetId && e.Receipt.ReceiptDate.Date <= date.Date)
				.Select(e => e.Count)
				.SumAsync();
		}

		public async Task<int> GetFixedAssetsCountWithoutProvider(Guid fixedAssetId, DateTime date)
		{
			return await _context.ReceiptTables
				.Include(e => e.Receipt)
				.Where(e => e.Receipt.OperationType == OperationType.Receipt && !e.Receipt.ProviderId.HasValue && e.FixedAssetId == fixedAssetId && e.Receipt.ReceiptDate.Date <= date.Date)
				.Select(e => e.Count)
				.SumAsync();
		}
	}
}
