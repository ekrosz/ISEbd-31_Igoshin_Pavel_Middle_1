using IES.FixedAssets.Core.Models.Requests.FixedAssetRequest;
using IES.FixedAssets.Core.Services.Contracts;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace IES.FixedAssets.Host.Forms
{
	public partial class FixedAssetsForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		private readonly IFixedAssetService _fixedAssetService;

		public FixedAssetsForm(IFixedAssetService fixedAssetService)
		{
			InitializeComponent();

			_fixedAssetService = fixedAssetService;
		}

		private async Task LoadData()
		{
			var data = await _fixedAssetService.GetAll();

			if (data != null)
			{
				dataGridViewFixedAssets.DataSource = data;
				dataGridViewFixedAssets.Columns[0].Visible = false;
				dataGridViewFixedAssets.AutoResizeColumns();
				dataGridViewFixedAssets.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
		}

		private void textBoxBalance_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;

			if (!Char.IsDigit(number) && number != 8 && number != 44)
			{
				e.Handled = true;
			}
		}

		private async void buttonAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxBalance.Text) || string.IsNullOrWhiteSpace(textBoxName.Text))
				MessageBox.Show("Заполните все поля");

			try
			{
				await _fixedAssetService.Create(new CreateFixedAssetRequest
				{
					Name = textBoxName.Text,
					BalancePrice = textBoxBalance.Text
				});

				textBoxName.Text = string.Empty;
				textBoxBalance.Text = string.Empty;

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
				if (dataGridViewFixedAssets.SelectedRows.Count == 1)
				{
					var id = (Guid)dataGridViewFixedAssets.SelectedRows[0].Cells[0].Value;

					var form = Container.Resolve<FixedAssetUpdateForm>();

					form.Id = id;

					if (form.ShowDialog() == DialogResult.OK)
					{
						await LoadData();
					}
				}
				else if (dataGridViewFixedAssets.SelectedRows.Count > 1)
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
			if (dataGridViewFixedAssets.SelectedRows.Count == 0)
				return;

			try
			{
				for (int i = 0; i < dataGridViewFixedAssets.SelectedRows.Count; i++)
				{
					var id = (Guid)dataGridViewFixedAssets.SelectedRows[i].Cells[0].Value;

					await _fixedAssetService.Delete(id);
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

		private async void FixedAssetsForm_Load(object sender, EventArgs e)
		{
			await LoadData();
		}
	}
}
