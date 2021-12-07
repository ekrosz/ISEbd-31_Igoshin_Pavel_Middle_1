using System;
using System.ComponentModel;

namespace IES.FixedAssets.Core.Models.Dto
{
	public sealed class EntryJournalDto
	{
		public Guid Id { get; set; }

		public Guid DebitAccountId { get; set; }

		public Guid CreditAccountId { get; set; }

		public Guid ReceiptTableId { get; set; }

		[DisplayName("Номер операции")]
		public int OperationNumber { get; set; }

		[DisplayName("Дебит")]
		public string DebitAccountNumber { get; set; }

		[DisplayName("Субконто №1")]
		public string DebitFirstSubconto { get; set; }

		[DisplayName("Субконто №2")]
		public string DebitSecondSubconto { get; set; }

		[DisplayName("Субконто №3")]
		public string DebitThirdSubconto { get; set; }

		[DisplayName("Кредит")]
		public string CreditAccountNumber { get; set; }

		[DisplayName("Субконто №1")]
		public string CreditFirstSubconto { get; set; }

		[DisplayName("Субконто №2")]
		public string CreditSecondSubconto { get; set; }

		[DisplayName("Субконто №3")]
		public string CreditThirdSubconto { get; set; }

		[DisplayName("Количество")]
		public int Count { get; set; }

		[DisplayName("Сумма")]
		public double Sum { get; set; }

		[DisplayName("Дата")]
		public DateTime DateEntry { get; set; }
	}
}
