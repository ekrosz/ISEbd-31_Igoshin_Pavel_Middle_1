using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.ReceiptTableRequests;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services.Contracts
{
	public interface IReceiptTableService
	{
		Task<IReadOnlyCollection<ReceiptTableDto>> GetAll();

		Task<IReadOnlyCollection<ReceiptTableDto>> GetReceiptTableByReceipt(Guid receiptId);

		Task<ReceiptTableDto> Get(Guid id);

		Task Create(CreateReceiptTableRequest args);

		Task Update(UpdateReceiptTableRequest args);

		Task Delete(Guid id);
	}
}
