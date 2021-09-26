
namespace IES.FixedAssets.Host.Forms
{
	partial class FixedAssetUpdateForm
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
			this.labelName = new System.Windows.Forms.Label();
			this.labelBalance = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxBalance = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(12, 9);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(122, 20);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Наименование";
			// 
			// labelBalance
			// 
			this.labelBalance.AutoSize = true;
			this.labelBalance.Location = new System.Drawing.Point(12, 70);
			this.labelBalance.Name = "labelBalance";
			this.labelBalance.Size = new System.Drawing.Size(186, 20);
			this.labelBalance.TabIndex = 1;
			this.labelBalance.Text = "Балансовая стоимость";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(16, 32);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(308, 26);
			this.textBoxName.TabIndex = 2;
			// 
			// textBoxBalance
			// 
			this.textBoxBalance.Location = new System.Drawing.Point(16, 93);
			this.textBoxBalance.Name = "textBoxBalance";
			this.textBoxBalance.Size = new System.Drawing.Size(308, 26);
			this.textBoxBalance.TabIndex = 3;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(95, 139);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(116, 38);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(217, 139);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(107, 38);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// FixedAssetUpdateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 192);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.textBoxBalance);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelBalance);
			this.Controls.Add(this.labelName);
			this.Name = "FixedAssetUpdateForm";
			this.Text = "FormFixedAssetUpdate";
			this.Load += new System.EventHandler(this.FixedAssetUpdateForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelBalance;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxBalance;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
	}
}