using IES.FixedAssets.Core.Models.Requests.ResponsibleRequests;
using IES.FixedAssets.Core.Services.Contracts;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace IES.FixedAssets.Host.Forms
{
	public partial class ResponsiblesForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		private readonly IResponsibleService _responsibleService;

		public ResponsiblesForm(IResponsibleService responsibleService)
		{
			InitializeComponent();

			_responsibleService = responsibleService;
		}

		private async Task LoadData()
		{
			var data = await _responsibleService.GetAll();

			if (data != null)
			{
				dataGridViewResponsibles.DataSource = data;
				dataGridViewResponsibles.Columns[0].Visible = false;
				dataGridViewResponsibles.AutoResizeColumns();
				dataGridViewResponsibles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
		}

		private async void ResponsiblesForm_Load(object sender, EventArgs e)
		{
			await LoadData();
		}

		private async void buttonCreate_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxFio.Text))
				MessageBox.Show("Заполните все поля");

			try
			{
				await _responsibleService.Create(new CreateResponsibleRequest
				{
					Fio = textBoxFio.Text
				});

				textBoxFio.Text = string.Empty;

				await LoadData();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private async void buttonUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewResponsibles.SelectedRows.Count == 1)
				{
					var id = (Guid)dataGridViewResponsibles.SelectedRows[0].Cells[0].Value;

					var form = Container.Resolve<ResponsibleUpdateForm>();

					form.Id = id;

					if (form.ShowDialog() == DialogResult.OK)
					{
						await LoadData();
					}
				}
				else if (dataGridViewResponsibles.SelectedRows.Count > 1)
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
			if (dataGridViewResponsibles.SelectedRows.Count == 0)
				return;

			try
			{
				for (int i = 0; i < dataGridViewResponsibles.SelectedRows.Count; i++)
				{
					var id = (Guid)dataGridViewResponsibles.SelectedRows[i].Cells[0].Value;

					await _responsibleService.Delete(id);
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
	}
}
