using AutoMapper;
using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.SubdivisionRequests;
using IES.FixedAssets.Core.Services.Contracts;
using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services
{
	public class SubdivisionService : ISubdivisionService
	{
		private readonly ISubdivisionRepository _subdivisionRepository;

		private readonly IMapper _mapper;

		public SubdivisionService(ISubdivisionRepository subdivisionRepository, IMapper mapper)
		{
			_subdivisionRepository = subdivisionRepository;
			_mapper = mapper;
		}

		public async Task Create(CreateSubdivisionRequest args)
		{
			var entity = _mapper.Map<SubdivisionModel>(args);

			await _subdivisionRepository.Create(entity);
		}

		public async Task Delete(Guid id)
		{
			var entity = await _subdivisionRepository.Get(id);

			await _subdivisionRepository.Delete(entity);
		}

		public async Task<SubdivisionDto> Get(Guid id)
		{
			var entity = await _subdivisionRepository.Get(id);

			var dto = _mapper.Map<SubdivisionDto>(entity);

			return dto;
		}

		public async Task<IReadOnlyCollection<SubdivisionDto>> GetAll()
		{
			var entities = await _subdivisionRepository.GetAll();

			if (entities == null)
				return new List<SubdivisionDto>();

			var dtos = _mapper.Map<IReadOnlyCollection<SubdivisionDto>>(entities);

			return dtos;
		}

		public async Task Update(UpdateSubdivisionRequest args)
		{
			var entity = await _subdivisionRepository.Get(args.Id);

			_mapper.Map(args, entity);

			await _subdivisionRepository.Update(entity);
		}
	}
}
