using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories
{
	public class ProviderRepository : IProviderRepository
	{
		private readonly FixedAssetsContext _context;

		public ProviderRepository(FixedAssetsContext context)
		{
			_context = context;
		}

		public async Task Create(ProviderModel entity)
		{
			await _context.Providers.AddAsync(entity);

			await _context.SaveChangesAsync();
		}

		public async Task Delete(ProviderModel entity)
		{
			_context.Providers.Remove(entity);

			await _context.SaveChangesAsync();
		}

		public async Task<ProviderModel> Get(Guid id)
		{
			return await _context.Providers
				.SingleOrDefaultAsync(e => e.Id == id);
		}

		public async Task<IReadOnlyCollection<ProviderModel>> GetAll()
		{
			return await _context.Providers
				.AsNoTracking()
				.ToArrayAsync();
		}

		public async Task Update(ProviderModel entity)
		{
			_context.Providers.Update(entity);

			await _context.SaveChangesAsync();
		}
	}
}
