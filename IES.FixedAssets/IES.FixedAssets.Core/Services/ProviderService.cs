using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.ProviderRequests;
using IES.FixedAssets.Core.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services
{
	public class ProviderService : IProviderService
	{
		public Task Create(CreateProviderRequest args)
		{
			throw new NotImplementedException();
		}

		public Task Delete(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<ProviderDto> Get(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<IReadOnlyCollection<ProviderDto>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task Update(UpdateProviderRequest args)
		{
			throw new NotImplementedException();
		}
	}
}
