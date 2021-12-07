using System;
using System.Collections.Generic;
using System.Text;

namespace IES.FixedAssets.Core.Models.Dto
{
	public class SecondReportListDto
	{
		public IEnumerable<SecondReportDto> Report { get; set; }

		public DateTime Date { get; set; }

		public string Fio { get; set; }

		public decimal Total { get; set; }
	}
}
