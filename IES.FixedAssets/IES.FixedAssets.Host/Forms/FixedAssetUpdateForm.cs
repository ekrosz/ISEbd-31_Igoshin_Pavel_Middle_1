using IES.FixedAssets.Core.Models.Requests.FixedAssetRequest;
using IES.FixedAssets.Core.Services.Contracts;
using System;
using System.Windows.Forms;
using Unity;

namespace IES.FixedAssets.Host.Forms
{
	public partial class FixedAssetUpdateForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		public Guid Id { get; set; }

		private readonly IFixedAssetService _fixedAssetService;

		public FixedAssetUpdateForm(IFixedAssetService fixedAssetService)
		{
			InitializeComponent();

			_fixedAssetService = fixedAssetService;
		}

		private async void LoadData()
		{
			var data = await _fixedAssetService.Get(Id);

			textBoxName.Text = data.Name;
			textBoxBalance.Text = data.BalancePrice.ToString();
		}

		private void FixedAssetUpdateForm_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;

			Close();
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxBalance.Text))
				MessageBox.Show("Заполните все поля");

			try
			{
				await _fixedAssetService.Update(new UpdateFixedAssetRequest
				{
					Id = Id,
					Name = textBoxName.Text,
					BalancePrice = textBoxBalance.Text
				});

				DialogResult = DialogResult.OK;

				Close();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}
	}
}
