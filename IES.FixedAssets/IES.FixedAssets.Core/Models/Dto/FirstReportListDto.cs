using System;
using System.Collections.Generic;
using System.Text;

namespace IES.FixedAssets.Core.Models.Dto
{
	public class FirstReportListDto
	{
		public IEnumerable<FirstReportDto> Report { get; set; }

		public DateTime Date { get; set; }

		public decimal Total { get; set; }
	}
}
