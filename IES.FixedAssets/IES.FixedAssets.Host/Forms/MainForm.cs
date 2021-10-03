using IES.FixedAssets.Core.Services;
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
	public partial class MainForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		public MainForm()
		{
			InitializeComponent();
		}

		private void планСчетовToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = Container.Resolve<AccountChartForm>();

			form.ShowDialog();
		}

		private void оСToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = Container.Resolve<FixedAssetsForm>();

			form.ShowDialog();
		}

		private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = Container.Resolve<ProvidersForm>();

			form.ShowDialog();
		}

		private void журналОперацийToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = Container.Resolve<ReceiptsForm>();

			form.ShowDialog();
		}
	}
}
