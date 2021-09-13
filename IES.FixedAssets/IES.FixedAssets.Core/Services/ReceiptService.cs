using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.ReceiptRequests;
using IES.FixedAssets.Core.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services
{
	public class ReceiptService : IReceiptService
	{
		public Task Create(CreateReceiptRequest args)
		{
			throw new NotImplementedException();
		}

		public Task Delete(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<ReceiptDto> Get(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<IReadOnlyCollection<ReceiptDto>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task Update(UpdateReceiptRequest args)
		{
			throw new NotImplementedException();
		}
	}
}
