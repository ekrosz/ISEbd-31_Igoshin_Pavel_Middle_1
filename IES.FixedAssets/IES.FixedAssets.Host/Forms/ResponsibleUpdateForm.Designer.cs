
namespace IES.FixedAssets.Host.Forms
{
	partial class ResponsibleUpdateForm
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
			this.labelFio = new System.Windows.Forms.Label();
			this.textBoxFio = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelFio
			// 
			this.labelFio.AutoSize = true;
			this.labelFio.Location = new System.Drawing.Point(13, 13);
			this.labelFio.Name = "labelFio";
			this.labelFio.Size = new System.Drawing.Size(51, 20);
			this.labelFio.TabIndex = 0;
			this.labelFio.Text = "ФИО:";
			// 
			// textBoxFio
			// 
			this.textBoxFio.Location = new System.Drawing.Point(13, 37);
			this.textBoxFio.Name = "textBoxFio";
			this.textBoxFio.Size = new System.Drawing.Size(264, 26);
			this.textBoxFio.TabIndex = 1;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(182, 91);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(94, 33);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(61, 91);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(115, 33);
			this.buttonSave.TabIndex = 3;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// ResponsibleUpdateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 152);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.textBoxFio);
			this.Controls.Add(this.labelFio);
			this.Name = "ResponsibleUpdateForm";
			this.Text = "ResponsibleUpdateForm";
			this.Load += new System.EventHandler(this.ResponsibleUpdateForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelFio;
		private System.Windows.Forms.TextBox textBoxFio;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
	}
}