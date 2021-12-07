using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.SubdivisionRequests;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services.Contracts
{
	public interface ISubdivisionService
	{
		Task<IReadOnlyCollection<SubdivisionDto>> GetAll();

		Task<SubdivisionDto> Get(Guid id);

		Task Create(CreateSubdivisionRequest args);

		Task Update(UpdateSubdivisionRequest args);

		Task Delete(Guid id);
	}
}
