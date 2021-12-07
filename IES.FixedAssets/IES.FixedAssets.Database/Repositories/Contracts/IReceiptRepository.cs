using IES.FixedAssets.Common.Enums;
using IES.FixedAssets.Database.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories.Contracts
{
	public interface IReceiptRepository
	{
		Task<IReadOnlyCollection<ReceiptModel>> GetAll();

		Task<IReadOnlyCollection<ReceiptModel>> GetByOperation(OperationType operationType);

		Task<ReceiptModel> Get(Guid id);

		Task Create(ReceiptModel entity);

		Task Update(ReceiptModel entity);

		Task Delete(ReceiptModel entity);
	}
}
