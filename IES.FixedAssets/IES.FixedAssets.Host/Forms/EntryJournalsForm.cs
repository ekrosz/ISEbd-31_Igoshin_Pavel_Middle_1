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
	public partial class EntryJournalsForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		private readonly IEntryJournalService _entryJournalService;

		public EntryJournalsForm(IEntryJournalService entryJournalService)
		{
			InitializeComponent();

			_entryJournalService = entryJournalService;
		}

		private async Task LoadData()
		{
			var accountCharts = await _entryJournalService.GetAll();

			if (accountCharts != null)
			{
				dataGridView1.DataSource = accountCharts;
				dataGridView1.Columns[0].Visible = false;
				dataGridView1.Columns[1].Visible = false;
				dataGridView1.Columns[2].Visible = false;
				dataGridView1.Columns[3].Visible = false;
				dataGridView1.AutoResizeColumns();
			}
		}

		private async void EntryJournalsForm_Load(object sender, EventArgs e)
		{
			await LoadData();
		}
	}
}
