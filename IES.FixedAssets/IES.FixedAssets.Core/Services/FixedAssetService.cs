using AutoMapper;
using IES.FixedAssets.Core.Helpers.Validators;
using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.FixedAssetRequest;
using IES.FixedAssets.Core.Services.Contracts;
using IES.FixedAssets.Database.Extensions.RepositoryExtensions;
using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services
{
	public class FixedAssetService : IFixedAssetService
	{
		private readonly IFixedAssetRepository _fixedAssetRepository;

		private readonly IMapper _mapper;

		public FixedAssetService(IFixedAssetRepository fixedAssetRepository, IMapper mapper)
		{
			_fixedAssetRepository = fixedAssetRepository;
			_mapper = mapper;
		}

		public async Task Create(CreateFixedAssetRequest args)
		{
			args.Validate();

			await _fixedAssetRepository.IsUniqueNameOrThrow(args.Name);

			var entity = _mapper.Map<FixedAssetModel>(args);

			await _fixedAssetRepository.Create(entity);
		}

		public async Task Delete(Guid id)
		{
			var entity = await _fixedAssetRepository.GetFixedAssetOrThrow(id);

			await _fixedAssetRepository.Delete(entity);
		}

		public async Task<FixedAssetDto> Get(Guid id)
		{
			var entity = await _fixedAssetRepository.GetFixedAssetOrThrow(id);

			var dto = _mapper.Map<FixedAssetDto>(entity);

			return dto;
		}

		public async Task<IReadOnlyCollection<FixedAssetDto>> GetAll()
		{
			var entities = await _fixedAssetRepository.GetAll();

			if (entities == null)
				return new List<FixedAssetDto>();

			var dtos = _mapper.Map<IReadOnlyCollection<FixedAssetDto>>(entities);

			return dtos;
		}

		public async Task Update(UpdateFixedAssetRequest args)
		{
			var entity = await _fixedAssetRepository.GetFixedAssetOrThrow(args.Id);

			args.Validate();

			_mapper.Map(args, entity);

			await _fixedAssetRepository.Update(entity);
		}
	}
}
