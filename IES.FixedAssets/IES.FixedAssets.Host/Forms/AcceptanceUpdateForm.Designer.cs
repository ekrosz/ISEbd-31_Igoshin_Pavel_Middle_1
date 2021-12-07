
namespace IES.FixedAssets.Host.Forms
{
	partial class AcceptanceUpdateForm
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
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.dateTimePickerReceiptDate = new System.Windows.Forms.DateTimePicker();
			this.labelDate = new System.Windows.Forms.Label();
			this.comboBoxResponsible = new System.Windows.Forms.ComboBox();
			this.comboBoxSubdivision = new System.Windows.Forms.ComboBox();
			this.labelResponsible = new System.Windows.Forms.Label();
			this.labelSubdivision = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(84, 210);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(121, 40);
			this.buttonSave.TabIndex = 29;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(211, 210);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(100, 40);
			this.buttonCancel.TabIndex = 28;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// dateTimePickerReceiptDate
			// 
			this.dateTimePickerReceiptDate.Location = new System.Drawing.Point(12, 160);
			this.dateTimePickerReceiptDate.Name = "dateTimePickerReceiptDate";
			this.dateTimePickerReceiptDate.Size = new System.Drawing.Size(299, 26);
			this.dateTimePickerReceiptDate.TabIndex = 27;
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Location = new System.Drawing.Point(8, 137);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(48, 20);
			this.labelDate.TabIndex = 26;
			this.labelDate.Text = "Дата";
			// 
			// comboBoxResponsible
			// 
			this.comboBoxResponsible.FormattingEnabled = true;
			this.comboBoxResponsible.Location = new System.Drawing.Point(12, 96);
			this.comboBoxResponsible.Name = "comboBoxResponsible";
			this.comboBoxResponsible.Size = new System.Drawing.Size(299, 28);
			this.comboBoxResponsible.TabIndex = 25;
			// 
			// comboBoxSubdivision
			// 
			this.comboBoxSubdivision.FormattingEnabled = true;
			this.comboBoxSubdivision.Location = new System.Drawing.Point(12, 31);
			this.comboBoxSubdivision.Name = "comboBoxSubdivision";
			this.comboBoxSubdivision.Size = new System.Drawing.Size(299, 28);
			this.comboBoxSubdivision.TabIndex = 24;
			// 
			// labelResponsible
			// 
			this.labelResponsible.AutoSize = true;
			this.labelResponsible.Location = new System.Drawing.Point(8, 73);
			this.labelResponsible.Name = "labelResponsible";
			this.labelResponsible.Size = new System.Drawing.Size(46, 20);
			this.labelResponsible.TabIndex = 23;
			this.labelResponsible.Text = "МОЛ";
			// 
			// labelSubdivision
			// 
			this.labelSubdivision.AutoSize = true;
			this.labelSubdivision.Location = new System.Drawing.Point(8, 8);
			this.labelSubdivision.Name = "labelSubdivision";
			this.labelSubdivision.Size = new System.Drawing.Size(133, 20);
			this.labelSubdivision.TabIndex = 22;
			this.labelSubdivision.Text = "Подразделение";
			// 
			// AcceptanceUpdateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 268);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.dateTimePickerReceiptDate);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.comboBoxResponsible);
			this.Controls.Add(this.comboBoxSubdivision);
			this.Controls.Add(this.labelResponsible);
			this.Controls.Add(this.labelSubdivision);
			this.Name = "AcceptanceUpdateForm";
			this.Text = "AcceptanceUpdateForm";
			this.Load += new System.EventHandler(this.AcceptanceUpdateForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.DateTimePicker dateTimePickerReceiptDate;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.ComboBox comboBoxResponsible;
		private System.Windows.Forms.ComboBox comboBoxSubdivision;
		private System.Windows.Forms.Label labelResponsible;
		private System.Windows.Forms.Label labelSubdivision;
	}
}