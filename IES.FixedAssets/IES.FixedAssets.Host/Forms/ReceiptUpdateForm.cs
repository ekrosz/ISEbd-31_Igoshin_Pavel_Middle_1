using IES.FixedAssets.Common.Enums;
using IES.FixedAssets.Core.Services.Contracts;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using IES.FixedAssets.Common.Helpers.Tools;
using IES.FixedAssets.Core.Models.Requests.ReceiptRequests;
using Unity;

namespace IES.FixedAssets.Host.Forms
{
	public partial class ReceiptUpdateForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		public Guid Id { get; set; }

		private readonly IReceiptService _receiptService;

		private readonly IProviderService _providerService;

		public ReceiptUpdateForm(IReceiptService receiptService, IProviderService providerService)
		{
			InitializeComponent();

			_receiptService = receiptService;
			_providerService = providerService;
		}

		private async Task LoadData()
		{
			var data = await _receiptService.Get(Id);
			var providers = await _providerService.GetAll();

			if (providers != null && data != null)
			{
				comboBoxProvider.DisplayMember = "Name";
				comboBoxProvider.ValueMember = "Id";
				comboBoxProvider.DataSource = providers;
				comboBoxProvider.SelectedValue = data.ProviderId;
			}

			foreach (var source in Enum.GetValues(typeof(SourceReceipt)))
			{
				comboBoxSource.Items.Add(((SourceReceipt)source).GetDescription());
			};

			comboBoxSource.SelectedItem = data.Source;

			if (!data.ProviderId.HasValue)
				comboBoxProvider.Visible = false;

		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;

			Close();
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(comboBoxSource.Text) ||
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
					OperationType = OperationType.Receipt.ToString(),
					Source = comboBoxSource.SelectedItem.ToString(),
					ProviderId = comboBoxProvider.SelectedValue?.ToString(),
				});

				DialogResult = DialogResult.OK;

				Close();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private async void ReceiptUpdateForm_Load(object sender, EventArgs e)
		{
			await LoadData();
		}

		private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
		{
			var source = comboBoxSource.SelectedItem.ToString();

			switch (source.ToLower())
			{
				case "создано":
					comboBoxProvider.Visible = false;
					labelProvider.Visible = false;
					comboBoxProvider.SelectedItem = null;
					break;
				case "куплено":
					comboBoxProvider.Visible = true;
					labelProvider.Visible = true;
					break;
			}
		}
	}
}
