using IES.FixedAssets.Database.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories.Contracts
{
	public interface IFixedAssetRepository
	{
		Task<IReadOnlyCollection<FixedAssetModel>> GetAll();

		Task<FixedAssetModel> GetById(Guid id);

		Task<FixedAssetModel> GetByName(string name);

		Task Create(FixedAssetModel entity);

		Task Update(FixedAssetModel entity);

		Task Delete(FixedAssetModel entity);
	}
}
