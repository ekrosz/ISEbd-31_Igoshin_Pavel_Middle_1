using IES.FixedAssets.Core.Models.Requests.ProviderRequests;
using IES.FixedAssets.Core.Services.Contracts;
using System;
using System.Windows.Forms;
using Unity;

namespace IES.FixedAssets.Host.Forms
{
	public partial class ProviderUpdateForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		public Guid Id { get; set; }

		private readonly IProviderService _providerService;

		public ProviderUpdateForm(IProviderService providerService)
		{
			InitializeComponent();

			_providerService = providerService;
		}

		private async void LoadData()
		{
			var data = await _providerService.Get(Id);

			textBoxName.Text = data.Name;
		}

		private void ProviderUpdateForm_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxName.Text))
				MessageBox.Show("Заполните все поля");

			try
			{
				await _providerService.Update(new UpdateProviderRequest
				{
					Id = Id,
					Name = textBoxName.Text
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
