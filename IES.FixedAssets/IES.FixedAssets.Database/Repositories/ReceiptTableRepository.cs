using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
		}

		public void Delete(ReceiptTableModel entity)
		{
			_context.ReceiptTables.Remove(entity);
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

		public void Update(ReceiptTableModel entity)
		{
			_context.ReceiptTables.Update(entity);
		}
	}
}
