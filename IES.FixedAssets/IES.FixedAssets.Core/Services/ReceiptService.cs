using AutoMapper;
using IES.FixedAssets.Common.Enums;
using IES.FixedAssets.Core.Helpers.Validators;
using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.ReceiptRequests;
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
	public class ReceiptService : IReceiptService
	{
		private readonly IReceiptRepository _receiptRepository;

		private readonly IProviderRepository _providerRepository;

		private readonly ISubdivisionRepository _subdivisionRepository;

		private readonly IResponsibleRepository _responsibleRepository;

		private readonly IMapper _mapper;

		public ReceiptService(IReceiptRepository receiptRepository, ISubdivisionRepository subdivisionRepository, IResponsibleRepository responsibleRepository, IProviderRepository providerRepository, IMapper mapper)
		{
			_receiptRepository = receiptRepository;
			_providerRepository = providerRepository;
			_subdivisionRepository = subdivisionRepository;
			_responsibleRepository = responsibleRepository;
			_mapper = mapper;
		}

		public async Task Create(CreateReceiptRequest args)
		{
			args.Validate();

			var entity = _mapper.Map<ReceiptModel>(args);

			await _receiptRepository.Create(entity);
		}

		public async Task Delete(Guid id)
		{
			var entity = await _receiptRepository.GetReceiptOrThrow(id);

			await _receiptRepository.Delete(entity);
		}

		public async Task<ReceiptDto> Get(Guid id)
		{
			var entity = await _receiptRepository.GetReceiptOrThrow(id);

			var dto = _mapper.Map<ReceiptDto>(entity);

			if (dto.ProviderId.HasValue)
			{
				var provider = await _providerRepository.GetProviderOrThrow(dto.ProviderId.Value);

				dto.ProviderName = provider?.Name;
			}

			return dto;
		}

		public async Task<IReadOnlyCollection<ReceiptDto>> GetAll()
		{
			var entities = await _receiptRepository.GetAll();

			if (entities == null)
				return new List<ReceiptDto>();

			var dtos = _mapper.Map<IReadOnlyCollection<ReceiptDto>>(entities);

			var providers = await _providerRepository.GetAll();

			foreach (var dto in dtos)
			{
				dto.ProviderName = providers
					?.SingleOrDefault(p => p.Id == dto.ProviderId)?.Name;
			}

			return dtos;
		}

		public async Task<IReadOnlyCollection<CommissioningOperationDto>> GetCommissionings()
		{
			var entities = await _receiptRepository.GetByOperation(OperationType.Commissioning);

			if (entities == null)
				return new List<CommissioningOperationDto>();

			var dtos = _mapper.Map<IReadOnlyCollection<CommissioningOperationDto>>(entities);

			var responsibles = await _responsibleRepository.GetAll();
			var subdivisions = await _subdivisionRepository.GetAll();

			foreach (var dto in dtos)
			{
				dto.ResponsibleName = responsibles
					?.SingleOrDefault(p => p.Id == dto.ResponsibleId)?.Fio;
				dto.SubdivisionName = subdivisions
					?.SingleOrDefault(p => p.Id == dto.SubdivisionId)?.Name;
			}

			return dtos;
		}

		public async Task<IReadOnlyCollection<ReceiptOperationDto>> GetReceipts()
		{
			var entities = await _receiptRepository.GetByOperation(OperationType.Receipt);

			if (entities == null)
				return new List<ReceiptOperationDto>();

			var dtos = _mapper.Map<IReadOnlyCollection<ReceiptOperationDto>>(entities);

			var providers = await _providerRepository.GetAll();

			foreach (var dto in dtos)
			{
				dto.ProviderName = providers
					?.SingleOrDefault(p => p.Id == dto.ProviderId)?.Name;
			}

			return dtos;
		}

		public async Task Update(UpdateReceiptRequest args)
		{
			var entity = await _receiptRepository.GetReceiptOrThrow(args.Id);

			args.Validate();

			_mapper.Map(args, entity);

			await _receiptRepository.Update(entity);
		}
	}
}
