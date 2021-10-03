using IES.FixedAssets.Common.Enums;
using IES.FixedAssets.Common.Helpers.Tools;
using IES.FixedAssets.Core.Models.Requests.ReceiptRequests;
using IES.FixedAssets.Core.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace IES.FixedAssets.Host.Forms
{
	public partial class ReceiptsForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		private readonly IReceiptService _receiptService;

		private readonly IProviderService _providerService;

		public ReceiptsForm(IReceiptService receiptService, IProviderService providerService)
		{
			InitializeComponent();

			_receiptService = receiptService;
			_providerService = providerService;
		}

		private async Task LoadData()
		{
			var data = await _receiptService.GetAll();

			if (data != null)
			{
				dataGridViewReceipts.DataSource = data;
				dataGridViewReceipts.Columns[0].Visible = false;
				dataGridViewReceipts.Columns[1].Visible = false;
				dataGridViewReceipts.AutoResizeColumns();
				dataGridViewReceipts.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}

			var providers = await _providerService.GetAll();

			comboBoxProvider.DisplayMember = "Name";
			comboBoxProvider.ValueMember = "Id";
			comboBoxProvider.DataSource = providers;
			comboBoxProvider.SelectedItem = null;

			foreach (var operationType in Enum.GetValues(typeof(OperationType)))
			{
				comboBoxOperationType.Items.Add(((OperationType)operationType).GetDescription());
			};
		}

		private async void buttonAdd_Click(object sender, EventArgs e)
		{
			if (comboBoxOperationType.SelectedItem == null ||
				comboBoxProvider.SelectedItem == null ||
				dateTimePicker1.Value == null ||
				string.IsNullOrWhiteSpace(textBoxSum.Text))
			{
				MessageBox.Show("Заполните все поля");

				return;
			}

			try
			{
				await _receiptService.Create(new CreateReceiptRequest
				{
					ProviderId = comboBoxProvider.SelectedValue.ToString(),
					ReceiptDate = dateTimePicker1.Value.ToString(),
					OperationType = comboBoxOperationType.SelectedItem.ToString(),
					Sum = textBoxSum.Text
				});

				await LoadData();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{

		}

		private async void buttonDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewReceipts.SelectedRows.Count == 0)
				return;

			try
			{
				for (int i = 0; i < dataGridViewReceipts.SelectedRows.Count; i++)
				{
					var id = (Guid)dataGridViewReceipts.SelectedRows[i].Cells[0].Value;

					await _receiptService.Delete(id);
				}

				await LoadData();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private async void ReceiptsForm_Load(object sender, EventArgs e)
		{
			await LoadData();
		}

		private void textBoxSum_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;

			if (!Char.IsDigit(number) && number != 8 && number != 44)
			{
				e.Handled = true;
			}
		}
	}
}
