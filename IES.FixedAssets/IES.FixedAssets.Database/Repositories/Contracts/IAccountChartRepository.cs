using IES.FixedAssets.Database.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories.Contracts
{
	public interface IAccountChartRepository
	{
		Task<IReadOnlyCollection<DebitAccountChartModel>> GetAllDebitAccounts();

		Task<IReadOnlyCollection<CreditAccountChartModel>> GetAllCreditAccounts();
	}
}
