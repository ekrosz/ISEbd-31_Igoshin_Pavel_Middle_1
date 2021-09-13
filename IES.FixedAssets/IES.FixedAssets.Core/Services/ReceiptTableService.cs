using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.ReceiptTableRequests;
using IES.FixedAssets.Core.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services
{
	public class ReceiptTableService : IReceiptTableService
	{
		public Task Create(CreateReceiptTableRequest args)
		{
			throw new NotImplementedException();
		}

		public Task Delete(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<ReceiptTableDto> Get(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<IReadOnlyCollection<ReceiptTableDto>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task Update(UpdateReceiptTableRequest args)
		{
			throw new NotImplementedException();
		}
	}
}
