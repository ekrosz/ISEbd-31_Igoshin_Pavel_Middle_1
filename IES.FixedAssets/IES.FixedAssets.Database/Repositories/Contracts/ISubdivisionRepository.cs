using IES.FixedAssets.Database.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories.Contracts
{
	public interface ISubdivisionRepository
	{
		Task Create(SubdivisionModel entity);

		Task Update(SubdivisionModel entity);

		Task<IReadOnlyCollection<SubdivisionModel>> GetAll();

		Task<SubdivisionModel> Get(Guid id);

		Task Delete(SubdivisionModel entity);
	}
}
