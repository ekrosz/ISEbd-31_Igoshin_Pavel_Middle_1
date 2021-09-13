using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
		}

		public void Delete(EntryJournalModel entity)
		{
			_context.EntryJournals.Remove(entity);
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
				.ToArrayAsync();
		}

		public void Update(EntryJournalModel entity)
		{
			_context.EntryJournals.Update(entity);
		}
	}
}
