using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.ReceiptRequests;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services.Contracts
{
	public interface IReceiptService
	{
		Task<IReadOnlyCollection<ReceiptDto>> GetAll();

		Task<ReceiptDto> Get(Guid id);

		Task Create(CreateReceiptRequest args);

		Task Update(UpdateReceiptRequest args);

		Task Delete(Guid id);
	}
}
