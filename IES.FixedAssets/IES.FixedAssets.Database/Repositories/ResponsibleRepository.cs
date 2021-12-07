using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories
{
	public class ResponsibleRepository : IResponsibleRepository
	{
		private readonly FixedAssetsContext _fixedAssetsContext;

		public ResponsibleRepository(FixedAssetsContext fixedAssetsContext)
			=> _fixedAssetsContext = fixedAssetsContext;

		public async Task Create(ResponsibleModel entity)
		{
			await _fixedAssetsContext.Responsibles.AddAsync(entity);

			await _fixedAssetsContext.SaveChangesAsync();
		}

		public async Task Delete(ResponsibleModel entity)
		{
			_fixedAssetsContext.Responsibles.Remove(entity);

			await _fixedAssetsContext.SaveChangesAsync();
		}

		public async Task<ResponsibleModel> Get(Guid id)
		{
			return await _fixedAssetsContext.Responsibles
				.AsNoTracking()
				.FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task<IReadOnlyCollection<ResponsibleModel>> GetAll()
		{
			return await _fixedAssetsContext.Responsibles
				.AsNoTracking()
				.ToArrayAsync();
		}

		public async Task Update(ResponsibleModel entity)
		{
			_fixedAssetsContext.Responsibles.Update(entity);

			await _fixedAssetsContext.SaveChangesAsync();
		}
	}
}
