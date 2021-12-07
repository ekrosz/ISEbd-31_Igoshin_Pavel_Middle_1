using IES.FixedAssets.Common.Enums;
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
	public partial class AcceptanceUpdateForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		public Guid Id { get; set; }

		private readonly IReceiptService _receiptService;

		private readonly ISubdivisionService _subdivisionService;

		private readonly IResponsibleService _responsibleService;

		public AcceptanceUpdateForm(IReceiptService receiptService, ISubdivisionService subdivisionService, IResponsibleService responsibleService)
		{
			InitializeComponent();

			_responsibleService = responsibleService;
			_receiptService = receiptService;
			_subdivisionService = subdivisionService;
		}

		private async Task LoadData()
		{
			var data = await _receiptService.Get(Id);
			var subdivisions = await _subdivisionService.GetAll();

			if (subdivisions != null && data != null)
			{
				comboBoxSubdivision.DisplayMember = "Name";
				comboBoxSubdivision.ValueMember = "Id";
				comboBoxSubdivision.DataSource = subdivisions;
				comboBoxSubdivision.SelectedValue = data.SubdivisionId;
			}

			var responsibles = await _responsibleService.GetAll();

			if (responsibles != null && data != null)
			{
				comboBoxResponsible.DisplayMember = "Fio";
				comboBoxResponsible.ValueMember = "Id";
				comboBoxResponsible.DataSource = responsibles;
				comboBoxResponsible.SelectedValue = data.ResponsibleId;
			}

		}

		private async void AcceptanceUpdateForm_Load(object sender, EventArgs e)
		{
			await LoadData();
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(comboBoxResponsible.Text) ||
				string.IsNullOrWhiteSpace(comboBoxSubdivision.Text) ||
				string.IsNullOrWhiteSpace(dateTimePickerReceiptDate.Text))
			{
				MessageBox.Show("Заполните все поля");

				return;
			}

			try
			{
				await _receiptService.Update(new UpdateReceiptRequest
				{
					Id = Id,
					ReceiptDate = dateTimePickerReceiptDate.Text,
					OperationType = OperationType.Commissioning.ToString(),
					ResponsibleId = comboBoxResponsible.SelectedValue?.ToString(),
					SubdivisionId = comboBoxSubdivision.SelectedValue?.ToString(),
				});

				DialogResult = DialogResult.OK;

				Close();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;

			Close();
		}
	}
}
