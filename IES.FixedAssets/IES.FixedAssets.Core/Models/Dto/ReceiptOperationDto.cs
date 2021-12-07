using System;
using System.ComponentModel;

namespace IES.FixedAssets.Core.Models.Dto
{
	public class ReceiptOperationDto
	{
		public Guid Id { get; set; }

		public Guid ProviderId { get; set; }

		[DisplayName("Номер")]
		public int OperationNumber { get; set; }

		[DisplayName("Поставщик")]
		public string ProviderName { get; set; }

		[DisplayName("Сумма")]
		public double Sum { get; set; }

		[DisplayName("Дата")]
		public DateTime ReceiptDate { get; set; }

		[DisplayName("Тип")]
		public string OperationType { get; set; }

		[DisplayName("Источник")]
		public string Source { get; set; }
	}
}
