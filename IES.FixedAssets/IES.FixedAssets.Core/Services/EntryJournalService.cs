using AutoMapper;
using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.EntryJournalRequests;
using IES.FixedAssets.Core.Services.Contracts;
using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services
{
	public class EntryJournalService : IEntryJournalService
	{
		private readonly IMapper _mapper;

		private readonly IEntryJournalRepository _entryJournalRepository;

		public EntryJournalService(IMapper mapper, IEntryJournalRepository entryJournalRepository)
		{
			_mapper = mapper;
			_entryJournalRepository = entryJournalRepository;
		}

		public async Task Create(CreateEntryJournalRequest args)
		{
			var entity = _mapper.Map<CreateEntryJournalRequest, EntryJournalModel>(args);

			await _entryJournalRepository.Create(entity);
		}

		public async Task Delete(Guid id)
		{
			var entity = await _entryJournalRepository.Get(id);

			_entryJournalRepository.Delete(entity);
		}

		public async Task<EntryJournalDto> Get(Guid id)
		{
			var entity = await _entryJournalRepository.Get(id);

			var dto = _mapper.Map<EntryJournalModel, EntryJournalDto>(entity);

			return dto;
		}

		public async Task<IReadOnlyCollection<EntryJournalDto>> GetAll()
		{
			var entities = await _entryJournalRepository.GetAll();

			var dtos = _mapper.Map<IReadOnlyCollection<EntryJournalModel>, IReadOnlyCollection<EntryJournalDto>>(entities);

			return dtos;
		}

		public async Task Update(UpdateEntryJournalRequest args)
		{
			var entity = await _entryJournalRepository.Get(args.Id);

			_mapper.Map(args, entity);

			_entryJournalRepository.Update(entity);
		}
	}
}
