using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IES.FixedAssets.Core.Models.Dto
{
	public class CommissioningOperationDto
	{
		public Guid Id { get; set; }

		public Guid ResponsibleId { get; set; }

		public Guid SubdivisionId { get; set; }

		[DisplayName("Номер")]
		public int OperationNumber { get; set; }

		[DisplayName("МОЛ")]
		public string ResponsibleName { get; set; }

		[DisplayName("Подразделение")]
		public string SubdivisionName { get; set; }

		[DisplayName("Сумма")]
		public double Sum { get; set; }

		[DisplayName("Дата")]
		public DateTime ReceiptDate { get; set; }

		[DisplayName("Тип")]
		public string OperationType { get; set; }
	}
}
