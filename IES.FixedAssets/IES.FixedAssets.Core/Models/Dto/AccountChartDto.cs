using IES.FixedAssets.Common.Enums;
using System;

namespace IES.FixedAssets.Core.Models.Dto
{
	public sealed class AccountChartDto
	{
		public Guid Id { get; set; }

		public string AccountNumber { get; set; }

		public string AccountName { get; set; }

		public AccountType AccountType { get; set; }

		public string FirstSubconto { get; set; }

		public string SecondSubconto { get; set; }

		public string ThirdSubconto { get; set; }

		public string Comment { get; set; }
	}
}
