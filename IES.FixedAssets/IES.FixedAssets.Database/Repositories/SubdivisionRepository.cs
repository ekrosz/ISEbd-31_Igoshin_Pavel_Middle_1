using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories
{
	public class SubdivisionRepository : ISubdivisionRepository
	{
		private readonly FixedAssetsContext _fixedAssetsContext;

		public SubdivisionRepository(FixedAssetsContext fixedAssetsContext)
			=> _fixedAssetsContext = fixedAssetsContext;

		public async Task Create(SubdivisionModel entity)
		{
			await _fixedAssetsContext.Subdivisions.AddAsync(entity);

			await _fixedAssetsContext.SaveChangesAsync();
		}

		public async Task Delete(SubdivisionModel entity)
		{
			_fixedAssetsContext.Subdivisions.Remove(entity);

			await _fixedAssetsContext.SaveChangesAsync();
		}

		public async Task<SubdivisionModel> Get(Guid id)
		{
			return await _fixedAssetsContext.Subdivisions
				.AsNoTracking()
				.FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task<IReadOnlyCollection<SubdivisionModel>> GetAll()
		{
			return await _fixedAssetsContext.Subdivisions
				.AsNoTracking()
				.ToArrayAsync();
		}

		public async Task Update(SubdivisionModel entity)
		{
			_fixedAssetsContext.Subdivisions.Update(entity);

			await _fixedAssetsContext.SaveChangesAsync();
		}
	}
}
