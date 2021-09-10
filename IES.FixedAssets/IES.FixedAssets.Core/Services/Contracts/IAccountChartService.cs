using IES.FixedAssets.Core.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Core.Services.Contracts
{
	public interface IAccountChartService
	{
		Task<IReadOnlyCollection<AccountChartDto>> GetAllCreditAccounts();

		Task<IReadOnlyCollection<AccountChartDto>> GetAllDebitAccounts();
	}
}
