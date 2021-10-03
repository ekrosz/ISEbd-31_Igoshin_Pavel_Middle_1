using IES.FixedAssets.Common.Enums;
using System;
using System.ComponentModel;

namespace IES.FixedAssets.Core.Models.Dto
{
	public sealed class AccountChartDto
	{
		public Guid Id { get; set; }

		[DisplayName("Номер")]
		public string AccountNumber { get; set; }

		[DisplayName("Наименование")]
		public string AccountName { get; set; }

		[DisplayName("Тип")]
		public AccountType AccountType { get; set; }

		[DisplayName("Первое субконто")]
		public string FirstSubconto { get; set; }

		[DisplayName("Второе субконто")]
		public string SecondSubconto { get; set; }

		[DisplayName("Третье субконто")]
		public string ThirdSubconto { get; set; }

		[DisplayName("Комментарий")]
		public string Comment { get; set; }
	}
}
