using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories
{
	public class EntryJournalRepository : IEntryJournalRepository
	{
		private readonly FixedAssetsContext _context;

		public EntryJournalRepository(FixedAssetsContext context)
		{
			_context = context;
		}

		public async Task Create(EntryJournalModel entity)
		{
			await _context.EntryJournals.AddAsync(entity);

			await _context.SaveChangesAsync();
		}

		public async Task Delete(EntryJournalModel entity)
		{
			_context.EntryJournals.Remove(entity);

			await _context.SaveChangesAsync();
		}

		public async Task<EntryJournalModel> Get(Guid id)
		{
			return await _context.EntryJournals
				.SingleOrDefaultAsync(e => e.Id == id);
		}

		public async Task<IReadOnlyCollection<EntryJournalModel>> GetAll()
		{
			return await _context.EntryJournals
				.AsNoTracking()
				.OrderBy(p => p.DateEntry)
				.ToArrayAsync();
		}

		public Task<EntryJournalModel> GetEntryByReceiptTable(Guid receiptTableId)
		{
			return _context.EntryJournals
				.AsNoTracking()
				.FirstOrDefaultAsync(p => p.ReceiptTableId == receiptTableId);
		}

		public async Task Update(EntryJournalModel entity)
		{
			_context.EntryJournals.Update(entity);

			await _context.SaveChangesAsync();
		}
	}
}
