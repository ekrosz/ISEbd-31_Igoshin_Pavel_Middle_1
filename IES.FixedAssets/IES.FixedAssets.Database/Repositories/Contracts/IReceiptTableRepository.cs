using IES.FixedAssets.Database.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories.Contracts
{
	public interface IReceiptTableRepository
	{
		Task<IReadOnlyCollection<ReceiptTableModel>> GetAll();

		Task<ReceiptTableModel> Get(Guid id);

		Task Create(ReceiptTableModel entity);

		void Update(ReceiptTableModel entity);

		void Delete(ReceiptTableModel entity);
	}
}
