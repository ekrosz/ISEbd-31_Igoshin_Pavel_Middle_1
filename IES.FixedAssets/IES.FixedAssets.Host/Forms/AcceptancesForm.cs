using IES.FixedAssets.Common.Enums;
using IES.FixedAssets.Common.Helpers.Tools;
using IES.FixedAssets.Core.Models.Requests.ReceiptRequests;
using IES.FixedAssets.Core.Models.Requests.ReceiptTableRequests;
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
	public partial class AcceptancesForm : Form
	{

		[Dependency]
		public new IUnityContainer Container { get; set; }

		private readonly IReceiptService _receiptService;

		private readonly IReceiptTableService _receiptTableService;

		private readonly IResponsibleService _responsibleService;

		private readonly ISubdivisionService _subdivisionService;

		private readonly IFixedAssetService _fixedAssetService;

		public AcceptancesForm(IReceiptService receiptService, IReceiptTableService receiptTableService, IResponsibleService responsibleService, ISubdivisionService subdivisionService, IFixedAssetService fixedAssetService)
		{
			InitializeComponent();

			_receiptService = receiptService;
			_receiptTableService = receiptTableService;
			_responsibleService = responsibleService;
			_subdivisionService = subdivisionService;
			_fixedAssetService = fixedAssetService;
		}

		private async Task LoadReceiptData()
		{
			var data = await _receiptService.GetCommissionings();

			if (data != null)
			{
				dataGridViewReceipts.DataSource = data;
				dataGridViewReceipts.Columns[0].Visible = false;
				dataGridViewReceipts.Columns[1].Visible = false;
				dataGridViewReceipts.Columns[2].Visible = false;
				dataGridViewReceipts.AutoResizeColumns();
				dataGridViewReceipts.MultiSelect = false;
			}
		}

		private async Task LoadReceiptTableData(Guid receiptId)
		{
			var receiptTable = await _receiptTableService.GetReceiptTableByReceipt(receiptId);

			if (receiptTable != null)
			{
				dataGridViewReceiptTable.DataSource = receiptTable;
				dataGridViewReceiptTable.Columns[0].Visible = false;
				dataGridViewReceiptTable.Columns[1].Visible = false;
				dataGridViewReceiptTable.Columns[2].Visible = false;
				dataGridViewReceiptTable.AutoResizeColumns();
				dataGridViewReceiptTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dataGridViewReceiptTable.MultiSelect = false;
			}
		}

		private async Task LoadComboBoxes()
		{
			var subdivisions = await _subdivisionService.GetAll();

			if (subdivisions != null)
			{
				comboBoxSubdivision.DisplayMember = "Name";
				comboBoxSubdivision.ValueMember = "Id";
				comboBoxSubdivision.DataSource = subdivisions;
				comboBoxSubdivision.SelectedItem = null;
			}

			var responsibles = await _responsibleService.GetAll();

			if (responsibles != null)
			{
				comboBoxResponsible.DisplayMember = "Fio";
				comboBoxResponsible.ValueMember = "Id";
				comboBoxResponsible.DataSource = responsibles;
				comboBoxResponsible.SelectedItem = null;
			}

			var fixedAssets = await _fixedAssetService.GetAll();

			if (fixedAssets != null)
			{
				comboBoxFixedAsset.DisplayMember = "Name";
				comboBoxFixedAsset.ValueMember = "Id";
				comboBoxFixedAsset.DataSource = fixedAssets;
				comboBoxFixedAsset.SelectedItem = null;
			}
		}

		private async void AcceptancesForm_Load(object sender, EventArgs e)
		{
			await LoadReceiptData();
			await LoadComboBoxes();
		}

		private async void buttonReceiptAdd_Click(object sender, EventArgs e)
		{
			if (dateTimePickerReceiptDate.Value == null ||
				comboBoxSubdivision.SelectedItem == null ||
				comboBoxResponsible.SelectedItem == null)
			{
				MessageBox.Show("Заполните все поля");

				return;
			}

			try
			{
				await _receiptService.Create(new CreateReceiptRequest
				{
					ResponsibleId = comboBoxResponsible.SelectedValue.ToString(),
					ReceiptDate = dateTimePickerReceiptDate.Value.ToString(),
					OperationType = OperationType.Commissioning.GetDescription(),
					SubdivisionId = comboBoxSubdivision.SelectedValue.ToString()
				});

				await LoadReceiptData();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private async void buttonReceiptUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewReceipts.SelectedRows.Count == 1)
				{
					var selectedRow = dataGridViewReceipts.SelectedRows[0];

					var index = selectedRow.Index;
					var id = (Guid)selectedRow.Cells[0].Value;

					var form = Container.Resolve<AcceptanceUpdateForm>();

					form.Id = id;

					if (form.ShowDialog() == DialogResult.OK)
					{
						await LoadReceiptData();

						dataGridViewReceipts.ClearSelection();
						dataGridViewReceipts.Rows[index].Selected = true;
					}
				}
				else if (dataGridViewReceipts.SelectedRows.Count > 1)
				{
					MessageBox.Show("Выбрано несколько значений");
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private async void buttonReceiptDelete_Click(object sender, EventArgs e)
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

				await LoadReceiptData();

				if (dataGridViewReceipts.Rows.Count > 0)
				{
					dataGridViewReceipts.ClearSelection();
					dataGridViewReceipts.Rows[0].Selected = true;
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private async void buttonReceiptTebleAdd_Click(object sender, EventArgs e)
		{
			if (comboBoxFixedAsset.SelectedItem == null ||
				string.IsNullOrWhiteSpace(numericUpDownCount.Value.ToString()))
			{
				MessageBox.Show("Заполните все поля!");

				return;
			}

			if (dataGridViewReceipts.SelectedRows.Count == 1)
			{
				try
				{
					var selectedRow = dataGridViewReceipts.SelectedRows[0];
					var receiptId = (Guid)selectedRow.Cells[0].Value;

					await _receiptTableService.Create(new CreateReceiptTableRequest
					{
						ReceiptId = receiptId.ToString(),
						FixedAssetId = comboBoxFixedAsset.SelectedValue.ToString(),
						Count = numericUpDownCount.Value.ToString()
					});

					var index = selectedRow.Index;

					await LoadReceiptTableData(receiptId);
					await LoadReceiptData();

					dataGridViewReceipts.ClearSelection();
					dataGridViewReceipts.Rows[index].Selected = true;
				}
				catch (Exception exc)
				{
					MessageBox.Show(exc.Message);
				}
			}
			else
			{
				MessageBox.Show("Выберите одну строку поступления!");
			}
		}

		private async void buttonReceiptTableDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewReceiptTable.SelectedRows.Count == 0)
				return;

			try
			{
				var selectedRow = dataGridViewReceipts.SelectedRows[0];

				for (int i = 0; i < dataGridViewReceiptTable.SelectedRows.Count; i++)
				{
					var receiptTableId = (Guid)dataGridViewReceiptTable.SelectedRows[i].Cells[0].Value;

					await _receiptTableService.Delete(receiptTableId);
				}

				var index = selectedRow.Index;
				var receiptId = (Guid)selectedRow.Cells[0].Value;

				await LoadReceiptData();
				await LoadReceiptTableData(receiptId);

				//dataGridViewReceipts.ClearSelection();
				dataGridViewReceipts.Rows[index].Selected = true;

				if (dataGridViewReceiptTable.Rows.Count > 0)
				{
					dataGridViewReceiptTable.ClearSelection();
					dataGridViewReceiptTable.Rows[0].Selected = true;
				}
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

		private async void dataGridViewReceipts_SelectionChanged(object sender, EventArgs e)
		{
			var selectedRow = dataGridViewReceipts.SelectedRows;

			if (selectedRow.Count == 1)
			{
				var receiptId = (Guid)selectedRow[0].Cells[0].Value;

				await LoadReceiptTableData(receiptId);

				if (dataGridViewReceiptTable.Rows.Count > 0)
				{
					dataGridViewReceiptTable.ClearSelection();
					dataGridViewReceiptTable.Rows[0].Selected = true;
				}
			}
		}
	}
}
