using IES.FixedAssets.Database.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories.Contracts
{
	public interface IEntryJournalRepository
	{
		Task<IReadOnlyCollection<EntryJournalModel>> GetAll();

		Task<EntryJournalModel> Get(Guid id);

		Task<EntryJournalModel> GetEntryByReceiptTable(Guid receiptTableId);

		Task Create(EntryJournalModel entity);

		Task Update(EntryJournalModel entity);

		Task Delete(EntryJournalModel entity);
	}
}
