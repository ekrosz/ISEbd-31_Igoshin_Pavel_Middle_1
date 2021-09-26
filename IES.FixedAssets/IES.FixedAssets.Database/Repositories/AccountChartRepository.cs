using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Repositories
{
	public class AccountChartRepository : IAccountChartRepository
	{
		private readonly FixedAssetsContext _context;

		public AccountChartRepository(FixedAssetsContext context)
			=> _context = context;

		public async Task<IReadOnlyCollection<CreditAccountChartModel>> GetAllCreditAccounts()
		{
			return await _context.CreditAccountCharts
				.AsNoTracking()
				.OrderBy(p => p.AccountNumber)
				.ToArrayAsync();
		}

		public async Task<IReadOnlyCollection<DebitAccountChartModel>> GetAllDebitAccounts()
		{
			return await _context.DebitAccountCharts
				.AsNoTracking()
				.OrderBy(p => p.AccountNumber)
				.ToArrayAsync();
		}
	}
}
