
namespace IES.FixedAssets.Host.Forms
{
	partial class FixedAssetForm
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
			this.buttonSave = new System.Windows.Forms.Button();
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
			this.groupBox1.Controls.Add(this.buttonSave);
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
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(172, 625);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(143, 43);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
			// FixedAssetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridViewFixedAssets);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FixedAssetForm";
			this.Text = "FixedAssetForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFixedAssets)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewFixedAssets;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label labelBalance;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxBalance;
		private System.Windows.Forms.TextBox textBoxName;
	}
}