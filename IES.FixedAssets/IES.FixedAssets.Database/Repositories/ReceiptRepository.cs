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
	public class ReceiptRepository : IReceiptRepository
	{
		private readonly FixedAssetsContext _context;

		public ReceiptRepository(FixedAssetsContext context)
		{
			_context = context;
		}

		public async Task Create(ReceiptModel entity)
		{
			await _context.Receipts.AddAsync(entity);

			await _context.SaveChangesAsync();
		}

		public async Task Delete(ReceiptModel entity)
		{
			_context.Receipts.Remove(entity);

			await _context.SaveChangesAsync();
		}

		public async Task<ReceiptModel> Get(Guid id)
		{
			return await _context.Receipts
				.SingleOrDefaultAsync(e => e.Id == id);
		}

		public async Task<IReadOnlyCollection<ReceiptModel>> GetAll()
		{
			return await _context.Receipts
				.AsNoTracking()
				.Include(e => e.ReceiptTables)
				.Include(e => e.Responsible)
				.Include(e => e.Subdivision)
				.OrderBy(e => e.ReceiptDate)
				.ToArrayAsync();
		}

		public async Task<IReadOnlyCollection<ReceiptModel>> GetByOperation(OperationType operationType)
		{
			return await _context.Receipts
				.AsNoTracking()
				.Where(e => e.OperationType == operationType)
				.OrderBy(e => e.ReceiptDate)
				.ToArrayAsync();
		}

		public async Task Update(ReceiptModel entity)
		{
			await _context.SaveChangesAsync();
		}
	}
}
