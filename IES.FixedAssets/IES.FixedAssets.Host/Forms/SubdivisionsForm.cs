using IES.FixedAssets.Core.Models.Requests.SubdivisionRequests;
using IES.FixedAssets.Core.Services.Contracts;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace IES.FixedAssets.Host.Forms
{
	public partial class SubdivisionsForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		private readonly ISubdivisionService _subdivisionService;

		public SubdivisionsForm(ISubdivisionService subdivisionService)
		{
			InitializeComponent();

			_subdivisionService = subdivisionService;
		}

		private async Task LoadData()
		{
			var data = await _subdivisionService.GetAll();

			if (data != null)
			{
				dataGridViewSubdivisions.DataSource = data;
				dataGridViewSubdivisions.Columns[0].Visible = false;
				dataGridViewSubdivisions.AutoResizeColumns();
				dataGridViewSubdivisions.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
		}

		private async void buttonCreate_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxSubdivision.Text))
				MessageBox.Show("Заполните все поля");

			try
			{
				await _subdivisionService.Create(new CreateSubdivisionRequest
				{
					Name = textBoxSubdivision.Text
				});

				textBoxSubdivision.Text = string.Empty;

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
				if (dataGridViewSubdivisions.SelectedRows.Count == 1)
				{
					var id = (Guid)dataGridViewSubdivisions.SelectedRows[0].Cells[0].Value;

					var form = Container.Resolve<SubdivisionUpdateForm>();

					form.Id = id;

					if (form.ShowDialog() == DialogResult.OK)
					{
						await LoadData();
					}
				}
				else if (dataGridViewSubdivisions.SelectedRows.Count > 1)
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
			if (dataGridViewSubdivisions.SelectedRows.Count == 0)
				return;

			try
			{
				for (int i = 0; i < dataGridViewSubdivisions.SelectedRows.Count; i++)
				{
					var id = (Guid)dataGridViewSubdivisions.SelectedRows[i].Cells[0].Value;

					await _subdivisionService.Delete(id);
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

		private async void SubdivisionsForm_Load(object sender, EventArgs e)
		{
			await LoadData();
		}
	}
}
