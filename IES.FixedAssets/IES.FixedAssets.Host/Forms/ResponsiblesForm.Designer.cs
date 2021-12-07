
namespace IES.FixedAssets.Host.Forms
{
	partial class ResponsiblesForm
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
			this.dataGridViewResponsibles = new System.Windows.Forms.DataGridView();
			this.labelFio = new System.Windows.Forms.Label();
			this.textBoxFio = new System.Windows.Forms.TextBox();
			this.buttonCreate = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResponsibles)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewResponsibles
			// 
			this.dataGridViewResponsibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewResponsibles.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewResponsibles.Name = "dataGridViewResponsibles";
			this.dataGridViewResponsibles.RowHeadersWidth = 62;
			this.dataGridViewResponsibles.RowTemplate.Height = 28;
			this.dataGridViewResponsibles.Size = new System.Drawing.Size(469, 426);
			this.dataGridViewResponsibles.TabIndex = 0;
			// 
			// labelFio
			// 
			this.labelFio.AutoSize = true;
			this.labelFio.Location = new System.Drawing.Point(487, 12);
			this.labelFio.Name = "labelFio";
			this.labelFio.Size = new System.Drawing.Size(51, 20);
			this.labelFio.TabIndex = 1;
			this.labelFio.Text = "ФИО:";
			// 
			// textBoxFio
			// 
			this.textBoxFio.Location = new System.Drawing.Point(487, 35);
			this.textBoxFio.Name = "textBoxFio";
			this.textBoxFio.Size = new System.Drawing.Size(301, 26);
			this.textBoxFio.TabIndex = 2;
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(676, 67);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(112, 33);
			this.buttonCreate.TabIndex = 3;
			this.buttonCreate.Text = "Добавить";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(491, 135);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(297, 33);
			this.buttonUpdate.TabIndex = 4;
			this.buttonUpdate.Text = "Изменить";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(491, 174);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(297, 33);
			this.buttonDelete.TabIndex = 5;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(676, 405);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(108, 33);
			this.buttonClose.TabIndex = 6;
			this.buttonClose.Text = "Закрыть";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// ResponsiblesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.textBoxFio);
			this.Controls.Add(this.labelFio);
			this.Controls.Add(this.dataGridViewResponsibles);
			this.Name = "ResponsiblesForm";
			this.Text = "ResponsiblesForm";
			this.Load += new System.EventHandler(this.ResponsiblesForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResponsibles)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewResponsibles;
		private System.Windows.Forms.Label labelFio;
		private System.Windows.Forms.TextBox textBoxFio;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonClose;
	}
}