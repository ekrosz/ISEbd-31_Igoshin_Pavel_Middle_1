using IES.FixedAssets.Database.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories.Contracts
{
	public interface IProviderRepository
	{
		Task<IReadOnlyCollection<ProviderModel>> GetAll();

		Task<ProviderModel> Get(Guid id);

		Task Create(ProviderModel entity);

		void Update(ProviderModel entity);

		void Delete(ProviderModel entity);
	}
}
