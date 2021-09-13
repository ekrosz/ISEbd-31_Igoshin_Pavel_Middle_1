using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.EntryJournalRequests;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services.Contracts
{
	public interface IEntryJournalService
	{
		Task<IReadOnlyCollection<EntryJournalDto>> GetAll();

		Task<EntryJournalDto> Get(Guid id);

		Task Create(CreateEntryJournalRequest args);

		Task Update(UpdateEntryJournalRequest args);

		Task Delete(Guid id);
	}
}
