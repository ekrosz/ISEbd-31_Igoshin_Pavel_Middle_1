﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace IES.FixedAssets.Host
{
	public partial class MainForm : Form
	{
		[Dependency]
		public new IUnityContainer Container { get; set; }

		public MainForm()
		{
			InitializeComponent();
		}
	}
}
