using AutoMapper;
using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.ResponsibleRequests;
using IES.FixedAssets.Core.Services.Contracts;
using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services
{
	public class ResponsibleService : IResponsibleService
	{
		private readonly IResponsibleRepository _responsibleRepository;

		private readonly IMapper _mapper;

		public ResponsibleService(IResponsibleRepository responsibleRepository, IMapper mapper)
		{
			_responsibleRepository = responsibleRepository;
			_mapper = mapper;
		}

		public async Task Create(CreateResponsibleRequest args)
		{
			var entity = _mapper.Map<ResponsibleModel>(args);

			await _responsibleRepository.Create(entity);
		}

		public async Task Delete(Guid id)
		{
			var entity = await _responsibleRepository.Get(id);

			await _responsibleRepository.Delete(entity);
		}

		public async Task<ResponsibleDto> Get(Guid id)
		{
			var entity = await _responsibleRepository.Get(id);

			var dto = _mapper.Map<ResponsibleDto>(entity);

			return dto;
		}

		public async Task<IReadOnlyCollection<ResponsibleDto>> GetAll()
		{
			var entities = await _responsibleRepository.GetAll();

			if (entities == null)
				return new List<ResponsibleDto>();

			var dtos = _mapper.Map<IReadOnlyCollection<ResponsibleDto>>(entities);

			return dtos;
		}

		public async Task Update(UpdateResponsibleRequest args)
		{
			var entity = await _responsibleRepository.Get(args.Id);

			_mapper.Map(args, entity);

			await _responsibleRepository.Update(entity);
		}
	}
}
