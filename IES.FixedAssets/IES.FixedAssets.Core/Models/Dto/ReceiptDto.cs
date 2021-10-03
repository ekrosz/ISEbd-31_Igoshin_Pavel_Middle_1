using System;
using System.ComponentModel;

namespace IES.FixedAssets.Core.Models.Dto
{
	public sealed class ReceiptDto
	{
		public Guid Id { get; set; }

		public Guid ProviderId { get; set; }

		[DisplayName("Поставщик")]
		public string ProviderName { get; set; }

		[DisplayName("Сумма")]
		public double Sum { get; set; }

		[DisplayName("Дата")]
		public DateTime ReceiptDate { get; set; }

		[DisplayName("Тип")]
		public string OperationType { get; set; }
	}
}
