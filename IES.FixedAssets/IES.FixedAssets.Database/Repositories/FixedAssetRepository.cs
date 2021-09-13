using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories
{
	public class FixedAssetRepository : IFixedAssetRepository
	{
		private readonly FixedAssetsContext _context;

		public FixedAssetRepository(FixedAssetsContext context)
		{
			_context = context;
		}

		public async Task Create(FixedAssetModel entity)
		{
			await _context.FixedAssets.AddAsync(entity);
		}

		public void Delete(FixedAssetModel entity)
		{
			_context.FixedAssets.Remove(entity);
		}

		public async Task<FixedAssetModel> Get(Guid id)
		{
			return await _context.FixedAssets
				.SingleOrDefaultAsync(e => e.Id == id);
		}

		public async Task<IReadOnlyCollection<FixedAssetModel>> GetAll()
		{
			return await _context.FixedAssets
				.AsNoTracking()
				.ToArrayAsync();
		}

		public void Update(FixedAssetModel entity)
		{
			_context.FixedAssets.Update(entity);
		}
	}
}
