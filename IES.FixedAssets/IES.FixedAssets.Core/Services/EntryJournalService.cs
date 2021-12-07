using AutoMapper;
using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.EntryJournalRequests;
using IES.FixedAssets.Core.Services.Contracts;
using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services
{
	public class EntryJournalService : IEntryJournalService
	{
		private readonly IMapper _mapper;

		private readonly IEntryJournalRepository _entryJournalRepository;

		private readonly IAccountChartRepository _accountChartRepository;

		private readonly IReceiptRepository _receiptRepository;

		private readonly IReceiptTableRepository _receiptTableRepository;

		public EntryJournalService(IMapper mapper, IEntryJournalRepository entryJournalRepository, IAccountChartRepository accountChartRepository, IReceiptRepository receiptRepository, IReceiptTableRepository receiptTableRepository)
		{
			_mapper = mapper;
			_entryJournalRepository = entryJournalRepository;
			_accountChartRepository = accountChartRepository;
			_receiptRepository = receiptRepository;
			_receiptTableRepository = receiptTableRepository;
		}

		public async Task Create(CreateEntryJournalRequest args)
		{
			var entity = _mapper.Map<CreateEntryJournalRequest, EntryJournalModel>(args);

			await _entryJournalRepository.Create(entity);
		}

		public async Task Delete(Guid id)
		{
			var entity = await _entryJournalRepository.Get(id);

			await _entryJournalRepository.Delete(entity);
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

			var receipts = await _receiptRepository.GetAll();
			var debits = await _accountChartRepository.GetAllDebitAccounts();
			var credits = await _accountChartRepository.GetAllCreditAccounts();
			var receiptTables = await _receiptTableRepository.GetAll();

			var dtos = _mapper.Map<IReadOnlyCollection<EntryJournalModel>, IReadOnlyCollection<EntryJournalDto>>(entities);

			foreach (var dto in dtos)
			{
				dto.CreditAccountNumber = credits.FirstOrDefault(p => p.Id == dto.CreditAccountId).AccountNumber;
				dto.DebitAccountNumber = debits.FirstOrDefault(p => p.Id == dto.DebitAccountId).AccountNumber;
				var receiptTable = receiptTables.FirstOrDefault(p => p.Id == dto.ReceiptTableId);

				dto.OperationNumber = receipts.FirstOrDefault(p => p.Id == receiptTable.ReceiptId).OperationNumber;
			}

			return dtos;
		}

		public async Task Update(UpdateEntryJournalRequest args)
		{
			var entity = await _entryJournalRepository.Get(args.Id);

			_mapper.Map(args, entity);

			await _entryJournalRepository.Update(entity);
		}
	}
}
