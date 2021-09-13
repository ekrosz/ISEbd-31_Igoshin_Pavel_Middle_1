using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.FixedAssetRequest;
using IES.FixedAssets.Core.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services
{
	public class FixedAssetService : IFixedAssetService
	{
		public Task Create(CreateFixedAssetRequest args)
		{
			throw new NotImplementedException();
		}

		public Task Delete(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<FixedAssetDto> Get(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<IReadOnlyCollection<FixedAssetDto>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task Update(UpdateFixedAssetRequest args)
		{
			throw new NotImplementedException();
		}
	}
}
