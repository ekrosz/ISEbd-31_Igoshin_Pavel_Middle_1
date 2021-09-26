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

			await _context.SaveChangesAsync();
		}

		public async Task Delete(FixedAssetModel entity)
		{
			_context.FixedAssets.Remove(entity);

			await _context.SaveChangesAsync();
		}

		public async Task<FixedAssetModel> GetById(Guid id)
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

		public async Task Update(FixedAssetModel entity)
		{
			_context.FixedAssets.Update(entity);

			await _context.SaveChangesAsync();
		}

		public async Task<FixedAssetModel> GetByName(string name)
		{
			return await _context.FixedAssets
				.AsNoTracking()
				.FirstOrDefaultAsync(p => EF.Functions.Like(p.Name, name));
		}
	}
}
