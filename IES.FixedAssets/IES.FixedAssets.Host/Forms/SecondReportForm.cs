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
	public partial class SecondReportForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		public readonly IReportService _reportService;

		public SecondReportForm(IReportService reportService)
		{
			InitializeComponent();

			_reportService = reportService;
		}

		private async void buttonExport_Click(object sender, EventArgs e)
		{
            if (string.IsNullOrWhiteSpace(textBoxFio.Text))
                return;

            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Delete(dialog.FileName);
                        File.Copy("SecondReportTemplate.docx", dialog.FileName);

                        var valuesToFill = await _reportService.GetSecondReportContent(textBoxFio.Text, dateTimePickerDate.Value);

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

		private async void buttonReport_Click(object sender, EventArgs e)
		{
            if (string.IsNullOrWhiteSpace(textBoxFio.Text))
			{
                MessageBox.Show("Введите ФИО!");

                return;
			}
			var report = await _reportService.GetSecondReportList(textBoxFio.Text, dateTimePickerDate.Value);

			dataGridViewReport.DataSource = report.Report;
			dataGridViewReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            textBoxFio.Text = report.Fio;
            textBoxTotal.Text = report.Total.ToString();
		}
	}
}
