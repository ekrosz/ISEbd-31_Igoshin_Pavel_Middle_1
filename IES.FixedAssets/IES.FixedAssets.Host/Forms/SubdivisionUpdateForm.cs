using IES.FixedAssets.Core.Models.Requests.SubdivisionRequests;
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
	public partial class SubdivisionUpdateForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		public Guid Id { get; set; }

		private readonly ISubdivisionService _subdivisionService;

		public SubdivisionUpdateForm(ISubdivisionService subdivisionService)
		{
			InitializeComponent();

			_subdivisionService = subdivisionService;
		}

		private async Task LoadData()
		{
			var data = await _subdivisionService.Get(Id);

			textBoxSubdivision.Text = data.Name;
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;

			Close();
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxSubdivision.Text))
				MessageBox.Show("Заполните все поля");

			try
			{
				await _subdivisionService.Update(new UpdateSubdivisionRequest
				{
					Id = Id,
					Name = textBoxSubdivision.Text
				});

				DialogResult = DialogResult.OK;

				Close();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private async void SubdivisionUpdateForm_Load(object sender, EventArgs e)
		{
			await LoadData();
		}
	}
}
