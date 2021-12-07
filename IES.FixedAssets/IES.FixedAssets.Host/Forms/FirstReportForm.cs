using IES.FixedAssets.Core.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateEngine.Docx;
using Unity;

namespace IES.FixedAssets.Host.Forms
{
	public partial class FirstReportForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		public readonly IReportService _reportService;

		public FirstReportForm(IReportService reportService)
		{
			InitializeComponent();

			_reportService = reportService;
		}

		private async void buttonReport_Click(object sender, EventArgs e)
		{
			var report = await _reportService.GetFirstReportList(dateTimePickerDate.Value);

			dataGridViewReport.DataSource = report.Report;
			dataGridViewReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			textBoxTotal.Text = report.Total.ToString();
		}

		private async void buttonExport_Click(object sender, EventArgs e)
		{
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Delete(dialog.FileName);
                        File.Copy("FirstReportTemplate.docx", dialog.FileName);

                        var valuesToFill = await _reportService.GetFirstReportContent(dateTimePickerDate.Value);

                        using (var outputDocument = new TemplateProcessor(dialog.FileName)
                            .SetRemoveContentControls(true))
                        {
                            outputDocument.FillContent(valuesToFill);
                            outputDocument.SaveChanges();
                        }

                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
	}
}
