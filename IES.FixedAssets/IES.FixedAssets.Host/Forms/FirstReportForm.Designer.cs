
namespace IES.FixedAssets.Host.Forms
{
	partial class FirstReportForm
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
			this.dataGridViewReport = new System.Windows.Forms.DataGridView();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.buttonReport = new System.Windows.Forms.Button();
			this.buttonExport = new System.Windows.Forms.Button();
			this.textBoxTotal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewReport
			// 
			this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewReport.Location = new System.Drawing.Point(12, 45);
			this.dataGridViewReport.Name = "dataGridViewReport";
			this.dataGridViewReport.RowHeadersWidth = 62;
			this.dataGridViewReport.RowTemplate.Height = 28;
			this.dataGridViewReport.Size = new System.Drawing.Size(776, 361);
			this.dataGridViewReport.TabIndex = 0;
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Location = new System.Drawing.Point(13, 13);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(200, 26);
			this.dateTimePickerDate.TabIndex = 1;
			// 
			// buttonReport
			// 
			this.buttonReport.Location = new System.Drawing.Point(236, 7);
			this.buttonReport.Name = "buttonReport";
			this.buttonReport.Size = new System.Drawing.Size(111, 32);
			this.buttonReport.TabIndex = 2;
			this.buttonReport.Text = "Показать";
			this.buttonReport.UseVisualStyleBackColor = true;
			this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
			// 
			// buttonExport
			// 
			this.buttonExport.Location = new System.Drawing.Point(354, 7);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(95, 32);
			this.buttonExport.TabIndex = 3;
			this.buttonExport.Text = "Экспорт";
			this.buttonExport.UseVisualStyleBackColor = true;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			// 
			// textBoxTotal
			// 
			this.textBoxTotal.Location = new System.Drawing.Point(656, 412);
			this.textBoxTotal.Name = "textBoxTotal";
			this.textBoxTotal.ReadOnly = true;
			this.textBoxTotal.Size = new System.Drawing.Size(132, 26);
			this.textBoxTotal.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(599, 415);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Итого:";
			// 
			// FirstReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxTotal);
			this.Controls.Add(this.buttonExport);
			this.Controls.Add(this.buttonReport);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.dataGridViewReport);
			this.Name = "FirstReportForm";
			this.Text = "FirstReportForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewReport;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.Button buttonReport;
		private System.Windows.Forms.Button buttonExport;
		private System.Windows.Forms.TextBox textBoxTotal;
		private System.Windows.Forms.Label label1;
	}
}