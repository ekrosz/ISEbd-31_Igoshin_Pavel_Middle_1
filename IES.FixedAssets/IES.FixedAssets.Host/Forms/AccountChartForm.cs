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
	public partial class AccountChartForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		private readonly IAccountChartService _accountChartService;

		public AccountChartForm(IAccountChartService accountChartService)
		{
			InitializeComponent();

			_accountChartService = accountChartService;

			LoadData();
		}

		private async void LoadData()
		{
			var accountCharts = await _accountChartService.GetAllCreditAccounts();

			if (accountCharts != null)
			{
				dataGridViewAccountCharts.DataSource = accountCharts;
				dataGridViewAccountCharts.Columns[0].Visible = false;
				dataGridViewAccountCharts.AutoResizeColumns();
			}
		}
	}
}
