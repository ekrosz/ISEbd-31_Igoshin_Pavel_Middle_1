
namespace IES.FixedAssets.Host.Forms
{
	partial class FixedAssetsForm
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
			this.dataGridViewFixedAssets = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.labelBalance = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxBalance = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFixedAssets)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewFixedAssets
			// 
			this.dataGridViewFixedAssets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridViewFixedAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFixedAssets.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewFixedAssets.Name = "dataGridViewFixedAssets";
			this.dataGridViewFixedAssets.RowHeadersWidth = 62;
			this.dataGridViewFixedAssets.RowTemplate.Height = 28;
			this.dataGridViewFixedAssets.Size = new System.Drawing.Size(855, 668);
			this.dataGridViewFixedAssets.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.buttonClose);
			this.groupBox1.Controls.Add(this.buttonDelete);
			this.groupBox1.Controls.Add(this.buttonUpdate);
			this.groupBox1.Controls.Add(this.buttonAdd);
			this.groupBox1.Controls.Add(this.labelBalance);
			this.groupBox1.Controls.Add(this.labelName);
			this.groupBox1.Controls.Add(this.textBoxBalance);
			this.groupBox1.Controls.Add(this.textBoxName);
			this.groupBox1.Location = new System.Drawing.Point(873, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(315, 668);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Добавление / редактирование";
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(166, 623);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(143, 39);
			this.buttonClose.TabIndex = 7;
			this.buttonClose.Text = "Закрыть";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(6, 353);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(303, 35);
			this.buttonDelete.TabIndex = 6;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(6, 311);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(303, 35);
			this.buttonUpdate.TabIndex = 5;
			this.buttonUpdate.Text = "Изменить";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(166, 180);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(143, 43);
			this.buttonAdd.TabIndex = 4;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// labelBalance
			// 
			this.labelBalance.AutoSize = true;
			this.labelBalance.Location = new System.Drawing.Point(6, 112);
			this.labelBalance.Name = "labelBalance";
			this.labelBalance.Size = new System.Drawing.Size(186, 20);
			this.labelBalance.TabIndex = 3;
			this.labelBalance.Text = "Балансовая стоимость";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(6, 47);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(122, 20);
			this.labelName.TabIndex = 2;
			this.labelName.Text = "Наименование";
			// 
			// textBoxBalance
			// 
			this.textBoxBalance.Location = new System.Drawing.Point(6, 135);
			this.textBoxBalance.Name = "textBoxBalance";
			this.textBoxBalance.Size = new System.Drawing.Size(303, 26);
			this.textBoxBalance.TabIndex = 1;
			this.textBoxBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBalance_KeyPress);
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(6, 70);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(303, 26);
			this.textBoxName.TabIndex = 0;
			// 
			// FixedAssetsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridViewFixedAssets);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FixedAssetsForm";
			this.Text = "Основные средства";
			this.Load += new System.EventHandler(this.FixedAssetsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFixedAssets)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewFixedAssets;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Label labelBalance;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxBalance;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpdate;
	}
}