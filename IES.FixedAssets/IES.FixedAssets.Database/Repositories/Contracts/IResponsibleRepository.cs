using IES.FixedAssets.Database.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories.Contracts
{
	public interface IResponsibleRepository
	{
		Task Create(ResponsibleModel entity);

		Task Update(ResponsibleModel entity);

		Task<IReadOnlyCollection<ResponsibleModel>> GetAll();

		Task<ResponsibleModel> Get(Guid id);

		Task Delete(ResponsibleModel entity);
	}
}
