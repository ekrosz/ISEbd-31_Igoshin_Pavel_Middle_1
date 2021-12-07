using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.ResponsibleRequests;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services.Contracts
{
	public interface IResponsibleService
	{
		Task<IReadOnlyCollection<ResponsibleDto>> GetAll();

		Task<ResponsibleDto> Get(Guid id);

		Task Create(CreateResponsibleRequest args);

		Task Update(UpdateResponsibleRequest args);

		Task Delete(Guid id);
	}
}
