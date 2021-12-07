
namespace IES.FixedAssets.Host.Forms
{
	partial class ReceiptUpdateForm
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
			this.dateTimePickerReceiptDate = new System.Windows.Forms.DateTimePicker();
			this.labelDate = new System.Windows.Forms.Label();
			this.comboBoxProvider = new System.Windows.Forms.ComboBox();
			this.comboBoxSource = new System.Windows.Forms.ComboBox();
			this.labelProvider = new System.Windows.Forms.Label();
			this.labelSource = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dateTimePickerReceiptDate
			// 
			this.dateTimePickerReceiptDate.Location = new System.Drawing.Point(16, 161);
			this.dateTimePickerReceiptDate.Name = "dateTimePickerReceiptDate";
			this.dateTimePickerReceiptDate.Size = new System.Drawing.Size(299, 26);
			this.dateTimePickerReceiptDate.TabIndex = 19;
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Location = new System.Drawing.Point(12, 138);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(48, 20);
			this.labelDate.TabIndex = 18;
			this.labelDate.Text = "Дата";
			// 
			// comboBoxProvider
			// 
			this.comboBoxProvider.FormattingEnabled = true;
			this.comboBoxProvider.Location = new System.Drawing.Point(16, 97);
			this.comboBoxProvider.Name = "comboBoxProvider";
			this.comboBoxProvider.Size = new System.Drawing.Size(299, 28);
			this.comboBoxProvider.TabIndex = 17;
			// 
			// comboBoxSource
			// 
			this.comboBoxSource.FormattingEnabled = true;
			this.comboBoxSource.Location = new System.Drawing.Point(16, 32);
			this.comboBoxSource.Name = "comboBoxSource";
			this.comboBoxSource.Size = new System.Drawing.Size(299, 28);
			this.comboBoxSource.TabIndex = 16;
			this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSource_SelectedIndexChanged);
			// 
			// labelProvider
			// 
			this.labelProvider.AutoSize = true;
			this.labelProvider.Location = new System.Drawing.Point(12, 74);
			this.labelProvider.Name = "labelProvider";
			this.labelProvider.Size = new System.Drawing.Size(95, 20);
			this.labelProvider.TabIndex = 15;
			this.labelProvider.Text = "Поставщик";
			// 
			// labelSource
			// 
			this.labelSource.AutoSize = true;
			this.labelSource.Location = new System.Drawing.Point(12, 9);
			this.labelSource.Name = "labelSource";
			this.labelSource.Size = new System.Drawing.Size(81, 20);
			this.labelSource.TabIndex = 14;
			this.labelSource.Text = "Источник";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(215, 211);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(100, 40);
			this.buttonCancel.TabIndex = 20;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(88, 211);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(121, 40);
			this.buttonSave.TabIndex = 21;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// ReceiptUpdateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 266);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.dateTimePickerReceiptDate);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.comboBoxProvider);
			this.Controls.Add(this.comboBoxSource);
			this.Controls.Add(this.labelProvider);
			this.Controls.Add(this.labelSource);
			this.Name = "ReceiptUpdateForm";
			this.Text = "ReceiptUpdateForm";
			this.Load += new System.EventHandler(this.ReceiptUpdateForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePickerReceiptDate;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.ComboBox comboBoxProvider;
		private System.Windows.Forms.ComboBox comboBoxSource;
		private System.Windows.Forms.Label labelProvider;
		private System.Windows.Forms.Label labelSource;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
	}
}