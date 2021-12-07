using IES.FixedAssets.Core.Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TemplateEngine.Docx;

namespace IES.FixedAssets.Core.Services.Contracts
{
	public interface IReportService
	{
		Task<Content> GetFirstReportContent(DateTime date);

		Task<FirstReportListDto> GetFirstReportList(DateTime date);

		Task<Content> GetSecondReportContent(string responsible, DateTime date);

		Task<SecondReportListDto> GetSecondReportList(string responsible, DateTime date);
	}
}
