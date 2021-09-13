using IES.FixedAssets.Database.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories.Contracts
{
	public interface IFixedAssetRepository
	{
		Task<IReadOnlyCollection<FixedAssetModel>> GetAll();

		Task<FixedAssetModel> Get(Guid id);

		Task Create(FixedAssetModel entity);

		void Update(FixedAssetModel entity);

		void Delete(FixedAssetModel entity);
	}
}
