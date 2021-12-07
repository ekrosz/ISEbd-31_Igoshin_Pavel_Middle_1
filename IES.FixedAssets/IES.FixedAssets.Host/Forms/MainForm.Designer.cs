
namespace IES.FixedAssets.Host.Forms
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.планСчетовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.мОЛToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.подразделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.журналыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.журналПоступленийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.журналПринятияКУчетуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.журналПроводокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ведомостьНаличияОСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.списокОСЗакрепленныхЗаМОЛToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.планСчетовToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.журналыToolStripMenuItem,
            this.отчетыToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(800, 33);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip";
			// 
			// планСчетовToolStripMenuItem
			// 
			this.планСчетовToolStripMenuItem.Name = "планСчетовToolStripMenuItem";
			this.планСчетовToolStripMenuItem.Size = new System.Drawing.Size(129, 29);
			this.планСчетовToolStripMenuItem.Text = "План счетов";
			this.планСчетовToolStripMenuItem.Click += new System.EventHandler(this.планСчетовToolStripMenuItem_Click);
			// 
			// справочникиToolStripMenuItem
			// 
			this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оСToolStripMenuItem,
            this.поставщикиToolStripMenuItem,
            this.мОЛToolStripMenuItem,
            this.подразделенияToolStripMenuItem});
			this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
			this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
			this.справочникиToolStripMenuItem.Text = "Справочники";
			// 
			// оСToolStripMenuItem
			// 
			this.оСToolStripMenuItem.Name = "оСToolStripMenuItem";
			this.оСToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
			this.оСToolStripMenuItem.Text = "ОС";
			this.оСToolStripMenuItem.Click += new System.EventHandler(this.оСToolStripMenuItem_Click);
			// 
			// поставщикиToolStripMenuItem
			// 
			this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
			this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
			this.поставщикиToolStripMenuItem.Text = "Поставщики";
			this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
			// 
			// мОЛToolStripMenuItem
			// 
			this.мОЛToolStripMenuItem.Name = "мОЛToolStripMenuItem";
			this.мОЛToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
			this.мОЛToolStripMenuItem.Text = "МОЛ";
			this.мОЛToolStripMenuItem.Click += new System.EventHandler(this.мОЛToolStripMenuItem_Click);
			// 
			// подразделенияToolStripMenuItem
			// 
			this.подразделенияToolStripMenuItem.Name = "подразделенияToolStripMenuItem";
			this.подразделенияToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
			this.подразделенияToolStripMenuItem.Text = "Подразделения";
			this.подразделенияToolStripMenuItem.Click += new System.EventHandler(this.подразделенияToolStripMenuItem_Click);
			// 
			// журналыToolStripMenuItem
			// 
			this.журналыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.журналПоступленийToolStripMenuItem,
            this.журналПринятияКУчетуToolStripMenuItem,
            this.журналПроводокToolStripMenuItem});
			this.журналыToolStripMenuItem.Name = "журналыToolStripMenuItem";
			this.журналыToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
			this.журналыToolStripMenuItem.Text = "Журналы";
			// 
			// журналПоступленийToolStripMenuItem
			// 
			this.журналПоступленийToolStripMenuItem.Name = "журналПоступленийToolStripMenuItem";
			this.журналПоступленийToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
			this.журналПоступленийToolStripMenuItem.Text = "Журнал поступлений";
			this.журналПоступленийToolStripMenuItem.Click += new System.EventHandler(this.журналОперацийToolStripMenuItem_Click);
			// 
			// журналПринятияКУчетуToolStripMenuItem
			// 
			this.журналПринятияКУчетуToolStripMenuItem.Name = "журналПринятияКУчетуToolStripMenuItem";
			this.журналПринятияКУчетуToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
			this.журналПринятияКУчетуToolStripMenuItem.Text = "Журнал принятия к учету";
			this.журналПринятияКУчетуToolStripMenuItem.Click += new System.EventHandler(this.журналПринятияКУчетуToolStripMenuItem_Click);
			// 
			// журналПроводокToolStripMenuItem
			// 
			this.журналПроводокToolStripMenuItem.Name = "журналПроводокToolStripMenuItem";
			this.журналПроводокToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
			this.журналПроводокToolStripMenuItem.Text = "Журнал проводок";
			this.журналПроводокToolStripMenuItem.Click += new System.EventHandler(this.журналПроводокToolStripMenuItem_Click);
			// 
			// отчетыToolStripMenuItem
			// 
			this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ведомостьНаличияОСToolStripMenuItem,
            this.списокОСЗакрепленныхЗаМОЛToolStripMenuItem});
			this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
			this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
			this.отчетыToolStripMenuItem.Text = "Отчеты";
			// 
			// ведомостьНаличияОСToolStripMenuItem
			// 
			this.ведомостьНаличияОСToolStripMenuItem.Name = "ведомостьНаличияОСToolStripMenuItem";
			this.ведомостьНаличияОСToolStripMenuItem.Size = new System.Drawing.Size(396, 34);
			this.ведомостьНаличияОСToolStripMenuItem.Text = "Ведомость наличия ОС";
			this.ведомостьНаличияОСToolStripMenuItem.Click += new System.EventHandler(this.ведомостьНаличияОСToolStripMenuItem_Click);
			// 
			// списокОСЗакрепленныхЗаМОЛToolStripMenuItem
			// 
			this.списокОСЗакрепленныхЗаМОЛToolStripMenuItem.Name = "списокОСЗакрепленныхЗаМОЛToolStripMenuItem";
			this.списокОСЗакрепленныхЗаМОЛToolStripMenuItem.Size = new System.Drawing.Size(396, 34);
			this.списокОСЗакрепленныхЗаМОЛToolStripMenuItem.Text = "Список ОС, закрепленных за МОЛ";
			this.списокОСЗакрепленныхЗаМОЛToolStripMenuItem.Click += new System.EventHandler(this.списокОСЗакрепленныхЗаМОЛToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem планСчетовToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оСToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem журналыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem журналПоступленийToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem журналПроводокToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ведомостьНаличияОСToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem списокОСЗакрепленныхЗаМОЛToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem журналПринятияКУчетуToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem мОЛToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem подразделенияToolStripMenuItem;
	}
}