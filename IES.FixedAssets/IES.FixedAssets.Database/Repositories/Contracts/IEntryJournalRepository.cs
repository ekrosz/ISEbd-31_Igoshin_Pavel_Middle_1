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

		Task Create(EntryJournalModel entity);

		void Update(EntryJournalModel entity);

		void Delete(EntryJournalModel entity);
	}
}
