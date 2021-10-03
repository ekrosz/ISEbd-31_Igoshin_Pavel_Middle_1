using IES.FixedAssets.Core.Models.Requests.ProviderRequests;
using IES.FixedAssets.Core.Services.Contracts;
using System;
using System.Windows.Forms;
using Unity;

namespace IES.FixedAssets.Host.Forms
{
	public partial class ProvidersForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		private readonly IProviderService _providerService;

		public ProvidersForm(IProviderService providerService)
		{
			InitializeComponent();

			_providerService = providerService;
		}

		private async void LoadData()
		{
			var data = await _providerService.GetAll();

			if (data != null)
			{
				dataGridViewProviders.DataSource = data;
				dataGridViewProviders.Columns[0].Visible = false;
				dataGridViewProviders.AutoResizeColumns();
				dataGridViewProviders.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
		}

		private async void buttonAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxName.Text))
				MessageBox.Show("Заполните все поля");

			try
			{
				await _providerService.Create(new CreateProviderRequest
				{
					Name = textBoxName.Text
				});

				textBoxName.Text = string.Empty;

				LoadData();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewProviders.SelectedRows.Count == 1)
				{
					var id = (Guid)dataGridViewProviders.SelectedRows[0].Cells[0].Value;

					var form = Container.Resolve<ProviderUpdateForm>();

					form.Id = id;

					if (form.ShowDialog() == DialogResult.OK)
					{
						LoadData();
					}
				}
				else if (dataGridViewProviders.SelectedRows.Count > 1)
				{
					MessageBox.Show("Выбрано несколько значений");
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private async void buttonDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewProviders.SelectedRows.Count == 0)
				return;

			try
			{
				for (int i = 0; i < dataGridViewProviders.SelectedRows.Count; i++)
				{
					var id = (Guid)dataGridViewProviders.SelectedRows[i].Cells[0].Value;

					await _providerService.Delete(id);
				}

				LoadData();
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

		private void ProvidersForm_Load(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
