using IES.FixedAssets.Database.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories.Contracts
{
	public interface IReceiptRepository
	{
		Task<IReadOnlyCollection<ReceiptModel>> GetAll();

		Task<ReceiptModel> Get(Guid id);

		Task Create(ReceiptModel entity);

		void Update(ReceiptModel entity);

		void Delete(ReceiptModel entity);
	}
}
