using IES.FixedAssets.Common.Enums;
using System;
using System.Collections.Generic;

namespace IES.FixedAssets.Database.Models
{
	public class CreditAccountChartModel
	{
		public Guid Id { get; set; }

		public string AccountNumber { get; set; }

		public string AccountName { get; set; }

		public AccountType AccountType { get; set; }

		public string FirstSubconto { get; set; }

		public string SecondSubconto { get; set; }

		public string ThirdSubconto { get; set; }

		public string Comment { get; set; }

		public List<EntryJournalModel> CreditEntryJournals { get; set; } = new List<EntryJournalModel>();
	}
}
