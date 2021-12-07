using IES.FixedAssets.Common.Enums;
using IES.FixedAssets.Common.Helpers.Tools;
using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Services.Contracts;
using IES.FixedAssets.Database.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateEngine.Docx;

namespace IES.FixedAssets.Core.Services
{
	public class ReportService : IReportService
	{
		private readonly IReceiptRepository _receiptRepository;

		private readonly IFixedAssetRepository _fixedAssetRepository;

		public ReportService(IReceiptRepository receiptRepository, IFixedAssetRepository fixedAssetRepository)
		{
			_receiptRepository = receiptRepository;
			_fixedAssetRepository = fixedAssetRepository;
		}

		public async Task<Content> GetFirstReportContent(DateTime date)
		{
			var receipts = await _receiptRepository.GetAll();

			var filteredReceipts = receipts
				.Where(e => e.OperationType == OperationType.Receipt && e.ReceiptDate.Date <= date.Date);

			var tableContent = new TableContent("Table");

			decimal total = 0;

			foreach (var rec in filteredReceipts)
			{
				foreach (var tb in rec.ReceiptTables)
				{
					var fixedAsset = await _fixedAssetRepository.GetById(tb.FixedAssetId);

					tableContent.AddRow(
						new FieldContent("FixedAsset", fixedAsset.Name),
						new FieldContent("Balance", Math.Round((decimal)fixedAsset.BalancePrice, 2).ToString()),
						new FieldContent("Count", tb.Count.ToString()),
						new FieldContent("ReceiptDate", rec.ReceiptDate.ToString("dd.MM.yyyy")),
						new FieldContent("Source", $"{rec.Source.GetDescription()}"));

					total += Math.Round((decimal)fixedAsset.BalancePrice * tb.Count, 2);
				}
			}

			var totalField = new FieldContent("Total", Math.Round(total, 2).ToString());

			var dateField = new FieldContent("Date", date.ToString("dd.MM.yyyy"));

			return new Content(dateField, tableContent, totalField);
		}

		public async Task<FirstReportListDto> GetFirstReportList(DateTime date)
		{
			var receipts = await _receiptRepository.GetAll();

			var filteredReceipts = receipts
				.Where(e => e.OperationType == OperationType.Receipt && e.ReceiptDate.Date <= date.Date);

			var tableContent = new TableContent("Table");

			decimal total = 0;

			var reportList = new List<FirstReportDto>();

			foreach (var rec in filteredReceipts)
			{
				foreach (var tb in rec.ReceiptTables)
				{
					var fixedAsset = await _fixedAssetRepository.GetById(tb.FixedAssetId);

					reportList.Add(new FirstReportDto
					{
						FixedAsset = fixedAsset.Name,
						Balance = Math.Round((decimal)fixedAsset.BalancePrice, 2),
						Count = tb.Count,
						ReceiptDate = rec.ReceiptDate,
						Source = $"{rec.Source.GetDescription()}"
					});

					total += Math.Round((decimal)fixedAsset.BalancePrice * tb.Count, 2);
				}
			}

			return new FirstReportListDto
			{
				Report = reportList,
				Date = date,
				Total = total
			};
		}

		public async Task<Content> GetSecondReportContent(string responsible, DateTime date)
		{
			var receipts = await _receiptRepository.GetAll();

			var filteredReceipts = receipts
				.Where(e => e.OperationType == OperationType.Commissioning && e.Responsible.Fio.ToLower().Contains(responsible.ToLower()) && e.ReceiptDate.Date <= date.Date);

			var tableContent = new TableContent("Table");

			decimal total = 0;

			foreach (var rec in filteredReceipts)
			{
				foreach (var tb in rec.ReceiptTables)
				{
					var fixedAsset = await _fixedAssetRepository.GetById(tb.FixedAssetId);

					tableContent.AddRow(
						new FieldContent("FixedAsset", fixedAsset.Name),
						new FieldContent("Balance", Math.Round(fixedAsset.BalancePrice, 2).ToString()),
						new FieldContent("Count", tb.Count.ToString()),
						new FieldContent("ComissioningDate", rec.ReceiptDate.ToString("dd.MM.yyyy")),
						new FieldContent("Subdivision", $"{rec.Subdivision?.Name}"));

					total += Math.Round((decimal)fixedAsset.BalancePrice, 2) * tb.Count;
				}
			}

			var responsibleFio = string.IsNullOrEmpty(responsible)
				? string.Empty
				: filteredReceipts.FirstOrDefault()?.Responsible?.Fio;

			var responsibleField = new FieldContent("Fio", $"{responsibleFio}");
			var dateField = new FieldContent("Date", date.ToString("dd.MM.yyyy"));
			var totalField = new FieldContent("Total", total.ToString());

			return new Content(totalField, responsibleField, dateField, tableContent);
		}

		public async Task<SecondReportListDto> GetSecondReportList(string responsible, DateTime date)
		{
			var receipts = await _receiptRepository.GetAll();

			var filteredReceipts = receipts
				.Where(e => e.OperationType == OperationType.Commissioning && e.Responsible.Fio.ToLower().Contains(responsible.ToLower()) && e.ReceiptDate.Date <= date.Date);

			var tableContent = new TableContent("Table");

			var reportList = new List<SecondReportDto>();

			decimal total = 0;

			foreach (var rec in filteredReceipts)
			{
				foreach (var tb in rec.ReceiptTables)
				{
					var fixedAsset = await _fixedAssetRepository.GetById(tb.FixedAssetId);

					reportList.Add(new SecondReportDto
					{
						FixedAsset = fixedAsset.Name,
						Balance = Math.Round((decimal)fixedAsset.BalancePrice, 2),
						Count = tb.Count,
						ComissioningDate = rec.ReceiptDate,
						Subdivision = rec.Subdivision.Name
					});

					total += Math.Round((decimal)fixedAsset.BalancePrice, 2) * tb.Count;
				}
			}

			var responsibleFio = string.IsNullOrEmpty(responsible)
				? string.Empty
				: filteredReceipts.FirstOrDefault()?.Responsible?.Fio;

			return new SecondReportListDto
			{
				Report = reportList,
				Date = date,
				Fio = responsibleFio,
				Total = total
			};
		}
	}
}
