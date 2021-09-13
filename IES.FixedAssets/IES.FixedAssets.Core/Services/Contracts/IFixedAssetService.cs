using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.FixedAssetRequest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services.Contracts
{
	public interface IFixedAssetService
	{
		Task<IReadOnlyCollection<FixedAssetDto>> GetAll();

		Task<FixedAssetDto> Get(Guid id);

		Task Create(CreateFixedAssetRequest args);

		Task Update(UpdateFixedAssetRequest args);

		Task Delete(Guid id);
	}
}
