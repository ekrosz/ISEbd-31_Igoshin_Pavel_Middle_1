using AutoMapper;
using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.ProviderRequests;
using IES.FixedAssets.Core.Services.Contracts;
using IES.FixedAssets.Database.Extensions.RepositoryExtensions;
using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services
{
	public class ProviderService : IProviderService
	{
		private readonly IProviderRepository _providerRepository;

		private readonly IMapper _mapper;

		public ProviderService(IProviderRepository providerRepository, IMapper mapper)
		{
			_providerRepository = providerRepository;
			_mapper = mapper;
		}

		public async Task Create(CreateProviderRequest args)
		{
			await _providerRepository.IsUniqueNameOrThrow(args.Name);

			var entity = _mapper.Map<ProviderModel>(args);

			await _providerRepository.Create(entity);
		}

		public async Task Delete(Guid id)
		{
			var entity = await _providerRepository.GetProviderOrThrow(id);

			await _providerRepository.Delete(entity);
		}

		public async Task<ProviderDto> Get(Guid id)
		{
			var entity = await _providerRepository.GetProviderOrThrow(id);

			var dto = _mapper.Map<ProviderDto>(entity);

			return dto;
		}

		public async Task<IReadOnlyCollection<ProviderDto>> GetAll()
		{
			var entities = await _providerRepository.GetAll();

			if (entities == null)
				return new List<ProviderDto>();

			var dtos = _mapper.Map<IReadOnlyCollection<ProviderDto>>(entities);

			return dtos;
		}

		public async Task Update(UpdateProviderRequest args)
		{
			var entity = await _providerRepository.GetProviderOrThrow(args.Id);

			await _providerRepository.IsUniqueNameOrThrow(args.Id, args.Name);

			_mapper.Map(args, entity);

			await _providerRepository.Update(entity);
		}
	}
}
