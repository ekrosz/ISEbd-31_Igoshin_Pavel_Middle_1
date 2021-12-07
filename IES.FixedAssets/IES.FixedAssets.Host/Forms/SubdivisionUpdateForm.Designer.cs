
namespace IES.FixedAssets.Host.Forms
{
	partial class SubdivisionUpdateForm
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
			this.textBoxSubdivision = new System.Windows.Forms.TextBox();
			this.labelSubdivision = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(60, 90);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(115, 33);
			this.buttonSave.TabIndex = 7;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(181, 90);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(94, 33);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// textBoxSubdivision
			// 
			this.textBoxSubdivision.Location = new System.Drawing.Point(12, 36);
			this.textBoxSubdivision.Name = "textBoxSubdivision";
			this.textBoxSubdivision.Size = new System.Drawing.Size(264, 26);
			this.textBoxSubdivision.TabIndex = 5;
			// 
			// labelSubdivision
			// 
			this.labelSubdivision.AutoSize = true;
			this.labelSubdivision.Location = new System.Drawing.Point(12, 12);
			this.labelSubdivision.Name = "labelSubdivision";
			this.labelSubdivision.Size = new System.Drawing.Size(137, 20);
			this.labelSubdivision.TabIndex = 4;
			this.labelSubdivision.Text = "Подразделение:";
			// 
			// SubdivisionUpdateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 145);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.textBoxSubdivision);
			this.Controls.Add(this.labelSubdivision);
			this.Name = "SubdivisionUpdateForm";
			this.Text = "SubdivisionUpdateForm";
			this.Load += new System.EventHandler(this.SubdivisionUpdateForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.TextBox textBoxSubdivision;
		private System.Windows.Forms.Label labelSubdivision;
	}
}