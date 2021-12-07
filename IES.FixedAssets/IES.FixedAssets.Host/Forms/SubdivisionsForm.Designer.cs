
namespace IES.FixedAssets.Host.Forms
{
	partial class SubdivisionsForm
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
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonCreate = new System.Windows.Forms.Button();
			this.textBoxSubdivision = new System.Windows.Forms.TextBox();
			this.labelSubdivision = new System.Windows.Forms.Label();
			this.dataGridViewSubdivisions = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubdivisions)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(676, 405);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(108, 33);
			this.buttonClose.TabIndex = 13;
			this.buttonClose.Text = "Закрыть";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(491, 174);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(297, 33);
			this.buttonDelete.TabIndex = 12;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(491, 135);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(297, 33);
			this.buttonUpdate.TabIndex = 11;
			this.buttonUpdate.Text = "Изменить";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(676, 67);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(112, 33);
			this.buttonCreate.TabIndex = 10;
			this.buttonCreate.Text = "Добавить";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// textBoxSubdivision
			// 
			this.textBoxSubdivision.Location = new System.Drawing.Point(487, 35);
			this.textBoxSubdivision.Name = "textBoxSubdivision";
			this.textBoxSubdivision.Size = new System.Drawing.Size(301, 26);
			this.textBoxSubdivision.TabIndex = 9;
			// 
			// labelSubdivision
			// 
			this.labelSubdivision.AutoSize = true;
			this.labelSubdivision.Location = new System.Drawing.Point(487, 12);
			this.labelSubdivision.Name = "labelSubdivision";
			this.labelSubdivision.Size = new System.Drawing.Size(137, 20);
			this.labelSubdivision.TabIndex = 8;
			this.labelSubdivision.Text = "Подразделение:";
			// 
			// dataGridViewSubdivisions
			// 
			this.dataGridViewSubdivisions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSubdivisions.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewSubdivisions.Name = "dataGridViewSubdivisions";
			this.dataGridViewSubdivisions.RowHeadersWidth = 62;
			this.dataGridViewSubdivisions.RowTemplate.Height = 28;
			this.dataGridViewSubdivisions.Size = new System.Drawing.Size(469, 426);
			this.dataGridViewSubdivisions.TabIndex = 7;
			// 
			// SubdivisionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.textBoxSubdivision);
			this.Controls.Add(this.labelSubdivision);
			this.Controls.Add(this.dataGridViewSubdivisions);
			this.Name = "SubdivisionsForm";
			this.Text = "SubdivisionsForm";
			this.Load += new System.EventHandler(this.SubdivisionsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubdivisions)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.TextBox textBoxSubdivision;
		private System.Windows.Forms.Label labelSubdivision;
		private System.Windows.Forms.DataGridView dataGridViewSubdivisions;
	}
}