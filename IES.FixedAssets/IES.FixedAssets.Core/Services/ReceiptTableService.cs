using AutoMapper;
using IES.FixedAssets.Common.Enums;
using IES.FixedAssets.Common.Helpers.Tools;
using IES.FixedAssets.Core.Helpers.Validators;
using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.ReceiptTableRequests;
using IES.FixedAssets.Core.Services.Contracts;
using IES.FixedAssets.Database.Extensions.RepositoryExtensions;
using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services
{
	public class ReceiptTableService : IReceiptTableService
	{
		private readonly IReceiptTableRepository _receiptTableRepository;

		private readonly IReceiptRepository _receiptRepository;

		private readonly IFixedAssetRepository _fixedAssetRepository;

		private readonly IEntryJournalRepository _entryJournalRepository;

		private readonly IAccountChartRepository _accountChartRepository;

		private readonly ISubdivisionRepository _subdivisionRepository;

		private readonly IResponsibleRepository _responsibleRepository;

		private readonly IProviderRepository _providerRepository;

		private readonly IMapper _mapper;

		public ReceiptTableService(
			IAccountChartRepository accountChartRepository,
			IReceiptTableRepository receiptTableRepository,
			IReceiptRepository receiptRepository,
			IFixedAssetRepository fixedAssetRepository,
			IEntryJournalRepository entryJournalRepository,
			ISubdivisionRepository subdivisionRepository,
			IResponsibleRepository responsibleRepository,
			IProviderRepository providerRepository,
			IMapper mapper)
		{
			_accountChartRepository = accountChartRepository;
			_receiptTableRepository = receiptTableRepository;
			_receiptRepository = receiptRepository;
			_fixedAssetRepository = fixedAssetRepository;
			_entryJournalRepository = entryJournalRepository;
			_subdivisionRepository = subdivisionRepository;
			_responsibleRepository = responsibleRepository;
			_providerRepository = providerRepository;
			_mapper = mapper;
		}

		public async Task Create(CreateReceiptTableRequest args)
		{
			args.Validate();

			var entity = _mapper.Map<ReceiptTableModel>(args);

			var fixedAsset = await _fixedAssetRepository.GetFixedAssetOrThrow(entity.FixedAssetId);
			var receipt = await _receiptRepository.Get(entity.ReceiptId);
			var receiptTable = await _receiptTableRepository.GetReceiptTableByFixedAsset(entity.ReceiptId, entity.FixedAssetId);

			if (receiptTable != null)
			{
				await _receiptTableRepository.CheckFixedAssetsAvailabilityOrThrow(entity.Count, receipt, receiptTable);

				receiptTable.Sum = fixedAsset.BalancePrice * entity.Count;
				receiptTable.Count = entity.Count;

				await _receiptTableRepository.Update(receiptTable);

				if (receipt.OperationType == OperationType.Receipt)
				{
					if (receipt.ProviderId.HasValue)
					{
						await UpdateEntry("08.4", "60", receiptTable, receiptTable.Count);
					}
					else
					{
						await UpdateEntry("08.3", "43", receiptTable, receiptTable.Count);
					}
				}
				else
				{
					var fixedAssetsCountWithProvider = await _receiptTableRepository.GetFixedAssetsCountWithProvider(entity.FixedAssetId, receipt.ReceiptDate);
					var fixedAssetsCountWithoutProvider = await _receiptTableRepository.GetFixedAssetsCountWithoutProvider(entity.FixedAssetId, receipt.ReceiptDate);

					if (receiptTable.Count < fixedAssetsCountWithProvider && fixedAssetsCountWithProvider != 0)
					{
						await UpdateEntry("01", "08.4", receiptTable, receiptTable.Count);
					}
					else
					{
						await UpdateEntry("01", "08.4", receiptTable, fixedAssetsCountWithProvider);

						if (receiptTable.Count - fixedAssetsCountWithProvider < fixedAssetsCountWithoutProvider)
						{
							await UpdateEntry("01", "08.3", receiptTable, receiptTable.Count - fixedAssetsCountWithProvider);
						}
						else
						{
							await UpdateEntry("01", "08.3", receiptTable, fixedAssetsCountWithoutProvider);
						}
					}
				}
			}
			else
			{
				await _receiptTableRepository.CheckFixedAssetsAvailabilityOrThrow(entity.Count, receipt, entity);

				entity.Sum = fixedAsset.BalancePrice * entity.Count;

				await _receiptTableRepository.Create(entity);

				if (receipt.OperationType == OperationType.Receipt)
				{
					if (receipt.ProviderId.HasValue)
					{
						await CreateEntry("08.4", "60", entity, entity.Count);
					}
					else
					{
						await CreateEntry("08.3", "43", entity, entity.Count);
					}
				}
				else
				{
					var fixedAssetsCountWithProvider = await _receiptTableRepository.GetFixedAssetsCountWithProvider(entity.FixedAssetId, receipt.ReceiptDate);
					var fixedAssetsCountWithoutProvider = await _receiptTableRepository.GetFixedAssetsCountWithoutProvider(entity.FixedAssetId, receipt.ReceiptDate);

					if (entity.Count < fixedAssetsCountWithProvider && fixedAssetsCountWithProvider != 0)
					{
						await CreateEntry("01", "08.4", entity, entity.Count);
					}
					else
					{
						await CreateEntry("01", "08.4", entity, fixedAssetsCountWithProvider);

						if (entity.Count - fixedAssetsCountWithProvider < fixedAssetsCountWithoutProvider)
						{
							await CreateEntry("01", "08.3", entity, entity.Count - fixedAssetsCountWithProvider);
						}
						else
						{
							await CreateEntry("01", "08.3", entity, fixedAssetsCountWithoutProvider);
						}
					}
				}
			}

			await UpdateReceiptSum(entity.ReceiptId);
		}

		public async Task Delete(Guid id)
		{
			var entity = await _receiptTableRepository.GetReceiptTableOrThrow(id);

			await _receiptTableRepository.Delete(entity);

			await UpdateReceiptSum(entity.ReceiptId);

			await DeleteEntry(entity);
		}

		public async Task<ReceiptTableDto> Get(Guid id)
		{
			var entity = await _receiptTableRepository.GetReceiptTableOrThrow(id);

			var dto = _mapper.Map<ReceiptTableDto>(entity);

			var fixedAsset = await _fixedAssetRepository.GetFixedAssetOrThrow(dto.FixedAssetId);

			dto.FixedAssetName = fixedAsset.Name;

			return dto;
		}

		public async Task<IReadOnlyCollection<ReceiptTableDto>> GetAll()
		{
			var entities = await _receiptTableRepository.GetAll();

			if (entities == null)
				return new List<ReceiptTableDto>();

			var dtos = _mapper.Map<IReadOnlyCollection<ReceiptTableDto>>(entities);

			var fixedAssets = await _fixedAssetRepository.GetAll();

			foreach (var dto in dtos)
			{
				dto.FixedAssetName = fixedAssets
					.SingleOrDefault(p => p.Id == dto.FixedAssetId)?.Name;
			}

			return dtos;
		}

		public async Task<IReadOnlyCollection<ReceiptTableDto>> GetReceiptTableByReceipt(Guid receiptId)
		{
			var receipt = await _receiptRepository.GetReceiptOrThrow(receiptId);
			var entities = await _receiptTableRepository.GetReceiptTablesByReceipt(receipt.Id);

			if (entities == null)
				return new List<ReceiptTableDto>();

			var dtos = _mapper.Map<IReadOnlyCollection<ReceiptTableDto>>(entities);

			var fixedAssets = await _fixedAssetRepository.GetAll();

			foreach (var dto in dtos)
			{
				dto.FixedAssetName = fixedAssets
					.SingleOrDefault(p => p.Id == dto.FixedAssetId)?.Name;
			}

			return dtos;
		}

		public async Task Update(UpdateReceiptTableRequest args)
		{
			var entity = await _receiptTableRepository.GetReceiptTableOrThrow(args.Id);

			args.Validate();

			_mapper.Map(args, entity);

			var fixedAsset = await _fixedAssetRepository.GetFixedAssetOrThrow(entity.FixedAssetId);
			var receipt = await _receiptRepository.Get(entity.ReceiptId);

			entity.Sum = fixedAsset.BalancePrice * entity.Count;

			await _receiptTableRepository.CheckFixedAssetsAvailabilityOrThrow(entity.Count, receipt, entity);

			await _receiptTableRepository.Update(entity);

			await UpdateReceiptSum(entity.ReceiptId);
		}

		private async Task UpdateReceiptSum(Guid receiptId)
		{
			var receipt = await _receiptRepository.GetReceiptOrThrow(receiptId);
			var totalSum = await _receiptTableRepository.GetTotalSumByReceipt(receiptId);

			receipt.Sum = totalSum;

			await _receiptRepository.Update(receipt);
		}

		private async Task CreateEntry(string debit, string credit, ReceiptTableModel receiptTableModel, int count)
		{
			var receipt = await _receiptRepository.Get(receiptTableModel.ReceiptId);
			var debits = await _accountChartRepository.GetAllDebitAccounts();
			var credits = await _accountChartRepository.GetAllCreditAccounts();
			var fixedAssets = await _fixedAssetRepository.GetAll();
			var subdivisions = await _subdivisionRepository.GetAll();
			var responsibles = await _responsibleRepository.GetAll();
			var providers = await _providerRepository.GetAll();

			var fixedAsset = fixedAssets?.FirstOrDefault(p => p.Id == receiptTableModel.FixedAssetId);

			var entry = new EntryJournalModel
			{
				ReceiptTableId = receiptTableModel.Id,
				Count = count,
				Sum = fixedAsset.BalancePrice * count,
				DateEntry = receipt.ReceiptDate,
				DebitAccountId = debits.FirstOrDefault(p => string.Equals(p.AccountNumber, debit, StringComparison.OrdinalIgnoreCase)).Id,
				CreditAccountId = credits.FirstOrDefault(p => string.Equals(p.AccountNumber, credit, StringComparison.OrdinalIgnoreCase)).Id
			};

			switch (debit)
			{
				case "01":
					entry.DebitFirstSubconto = fixedAsset?.Name;
					entry.DebitSecondSubconto = subdivisions?.FirstOrDefault(p => p.Id == receipt.SubdivisionId)?.Name;
					entry.DebitThirdSubconto = responsibles?.FirstOrDefault(p => p.Id == receipt.ResponsibleId)?.Fio;
					break;
				case "08.3":
					entry.DebitFirstSubconto = fixedAsset?.Name;
					entry.DebitSecondSubconto = receipt?.Source?.GetDescription();
					break;
				case "08.4":
					entry.DebitFirstSubconto = fixedAsset?.Name;
					entry.DebitSecondSubconto = receipt?.Source?.GetDescription();
					entry.DebitThirdSubconto = providers?.FirstOrDefault(p => p.Id == receipt.ProviderId)?.Name;
					break;
			}

			switch (credit)
			{
				case "60":
					entry.CreditFirstSubconto = fixedAsset?.Name;
					entry.CreditSecondSubconto = providers?.FirstOrDefault(p => p.Id == receipt.ProviderId)?.Name;
					break;
				case "08.3":
					entry.CreditFirstSubconto = fixedAsset?.Name;
					break;
				case "08.4":
					entry.CreditFirstSubconto = fixedAsset?.Name;
					break;
				case "43":
					entry.CreditFirstSubconto = fixedAsset?.Name;
					break;
			}

			await _entryJournalRepository.Create(entry);
		}

		private async Task UpdateEntry(string newDebit, string newCredit, ReceiptTableModel receiptTableModel, int count)
		{
			var entry = await _entryJournalRepository.GetEntryByReceiptTable(receiptTableModel.Id);

			if (entry == null)
				throw new Exception("Проводка не найдена");

			var receipt = await _receiptRepository.Get(receiptTableModel.ReceiptId);

			var debits = await _accountChartRepository.GetAllDebitAccounts();
			var credits = await _accountChartRepository.GetAllCreditAccounts();
			var fixedAssets = await _fixedAssetRepository.GetAll();
			var subdivisions = await _subdivisionRepository.GetAll();
			var responsibles = await _responsibleRepository.GetAll();
			var providers = await _providerRepository.GetAll();

			var fixedAsset = fixedAssets?.FirstOrDefault(p => p.Id == receiptTableModel.FixedAssetId);

			var debitAcc = debits.FirstOrDefault(p => string.Equals(p.AccountNumber, newDebit, StringComparison.OrdinalIgnoreCase));
			var creditAcc = debits.FirstOrDefault(p => string.Equals(p.AccountNumber, newCredit, StringComparison.OrdinalIgnoreCase));

			if (debits == null || credits == null)
				throw new Exception("Заполните справочник счетов!");

			entry.DebitAccountId = debitAcc.Id;
			entry.CreditAccountId = creditAcc.Id;
			entry.DateEntry = receipt.ReceiptDate;
			entry.Count = count;
			entry.Sum = fixedAsset.BalancePrice * count;
			entry.ReceiptTableId = receiptTableModel.Id;

			entry.CreditFirstSubconto = null;
			entry.CreditSecondSubconto = null;
			entry.CreditThirdSubconto = null;
			entry.DebitFirstSubconto = null;
			entry.DebitSecondSubconto = null;
			entry.DebitThirdSubconto = null;

			switch (newDebit)
			{
				case "01":
					entry.DebitFirstSubconto = fixedAsset?.Name;
					entry.DebitSecondSubconto = subdivisions?.FirstOrDefault(p => p.Id == receipt.SubdivisionId)?.Name;
					entry.DebitThirdSubconto = responsibles?.FirstOrDefault(p => p.Id == receipt.ResponsibleId)?.Fio;
					break;
				case "08.3":
					entry.DebitFirstSubconto = fixedAsset?.Name;
					entry.DebitSecondSubconto = receipt?.Source?.GetDescription();
					break;
				case "08.4":
					entry.DebitFirstSubconto = fixedAsset?.Name;
					entry.DebitSecondSubconto = receipt?.Source?.GetDescription();
					entry.DebitThirdSubconto = providers?.FirstOrDefault(p => p.Id == receipt.ProviderId)?.Name;
					break;
			}

			switch (newCredit)
			{
				case "60":
					entry.CreditFirstSubconto = fixedAsset?.Name;
					entry.CreditSecondSubconto = providers?.FirstOrDefault(p => p.Id == receipt.ProviderId)?.Name;
					break;
				case "08.3":
					entry.CreditFirstSubconto = fixedAsset?.Name;
					break;
				case "08.4":
					entry.CreditFirstSubconto = fixedAsset?.Name;
					break;
				case "43":
					entry.CreditFirstSubconto = fixedAsset?.Name;
					break;
			}

			await _entryJournalRepository.Update(entry);
		}

		private async Task DeleteEntry(ReceiptTableModel receiptTableModel)
		{
			var entry = await _entryJournalRepository.GetEntryByReceiptTable(receiptTableModel.Id);

			if (entry == null)
				throw new Exception("Проводка не найдена");

			await _entryJournalRepository.Delete(entry);
		}
	}
}
