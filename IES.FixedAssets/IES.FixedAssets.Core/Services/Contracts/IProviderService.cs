using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.ProviderRequests;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services.Contracts
{
	public interface IProviderService
	{
		Task<IReadOnlyCollection<ProviderDto>> GetAll();

		Task<ProviderDto> Get(Guid id);

		Task Create(CreateProviderRequest args);

		Task Update(UpdateProviderRequest args);

		Task Delete(Guid id);
	}
}
