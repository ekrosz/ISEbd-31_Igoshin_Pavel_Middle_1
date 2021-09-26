using IES.FixedAssets.Core.Models.Requests.FixedAssetRequest;
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
	public partial class FixedAssetForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		private readonly IFixedAssetService _fixedAssetService;

		public FixedAssetForm(IFixedAssetService fixedAssetService)
		{
			InitializeComponent();

			_fixedAssetService = fixedAssetService;

			LoadData();
		}

		public async void LoadData()
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

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxBalance.Text) || string.IsNullOrWhiteSpace(textBoxName.Text))
				return;

			try
			{
				await _fixedAssetService.Create(new CreateFixedAssetRequest
				{
					Name = textBoxName.Text,
					BalancePrice = textBoxBalance.Text
				});

				Close();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
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
	}
}
