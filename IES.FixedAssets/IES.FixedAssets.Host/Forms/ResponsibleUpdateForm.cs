using IES.FixedAssets.Core.Models.Requests.ResponsibleRequests;
using IES.FixedAssets.Core.Services.Contracts;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace IES.FixedAssets.Host.Forms
{
	public partial class ResponsibleUpdateForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		public Guid Id { get; set; }

		private readonly IResponsibleService _responsibleService;

		public ResponsibleUpdateForm(IResponsibleService responsibleService)
		{
			InitializeComponent();

			_responsibleService = responsibleService;
		}

		private async Task LoadData()
		{
			var data = await _responsibleService.Get(Id);

			textBoxFio.Text = data.Fio;
		}

		private async void ResponsibleUpdateForm_Load(object sender, EventArgs e)
		{
			await LoadData();
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxFio.Text))
				MessageBox.Show("Заполните все поля");

			try
			{
				await _responsibleService.Update(new UpdateResponsibleRequest
				{
					Id = Id,
					Fio = textBoxFio.Text
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
