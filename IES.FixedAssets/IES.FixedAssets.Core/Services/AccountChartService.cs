using AutoMapper;
using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Services.Contracts;
using IES.FixedAssets.Database.Repositories.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services
{
	public class AccountChartService : IAccountChartService
	{
		private readonly IAccountChartRepository _accountChartRepository;

		private readonly IMapper _mapper;

		public AccountChartService(IAccountChartRepository accountChartRepository, IMapper mapper)
		{
			_accountChartRepository = accountChartRepository;
			_mapper = mapper;
		}

		public async Task<IReadOnlyCollection<AccountChartDto>> GetAllCreditAccounts()
		{
			var accountModels = await _accountChartRepository.GetAllCreditAccounts();

			var accountDtos = _mapper.Map<IReadOnlyCollection<AccountChartDto>>(accountModels);

			return accountDtos;
		}

		public async Task<IReadOnlyCollection<AccountChartDto>> GetAllDebitAccounts()
		{
			var accountModels = await _accountChartRepository.GetAllDebitAccounts();

			var accountDtos = _mapper.Map<IReadOnlyCollection<AccountChartDto>>(accountModels);

			return accountDtos;
		}
	}
}
