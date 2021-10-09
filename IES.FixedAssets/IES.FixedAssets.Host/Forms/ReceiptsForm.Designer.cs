
namespace IES.FixedAssets.Host.Forms
{
	partial class ReceiptsForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.labelDate = new System.Windows.Forms.Label();
			this.textBoxSum = new System.Windows.Forms.TextBox();
			this.labelSum = new System.Windows.Forms.Label();
			this.comboBoxOperationType = new System.Windows.Forms.ComboBox();
			this.comboBoxProvider = new System.Windows.Forms.ComboBox();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.labelOperationType = new System.Windows.Forms.Label();
			this.labelProvider = new System.Windows.Forms.Label();
			this.dataGridViewReceipts = new System.Windows.Forms.DataGridView();
			this.labelReceipts = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.labelDate);
			this.groupBox1.Controls.Add(this.textBoxSum);
			this.groupBox1.Controls.Add(this.labelSum);
			this.groupBox1.Controls.Add(this.comboBoxOperationType);
			this.groupBox1.Controls.Add(this.comboBoxProvider);
			this.groupBox1.Controls.Add(this.buttonClose);
			this.groupBox1.Controls.Add(this.buttonDelete);
			this.groupBox1.Controls.Add(this.buttonUpdate);
			this.groupBox1.Controls.Add(this.buttonAdd);
			this.groupBox1.Controls.Add(this.labelOperationType);
			this.groupBox1.Controls.Add(this.labelProvider);
			this.groupBox1.Location = new System.Drawing.Point(873, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(315, 940);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Добавление / редактирование";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(10, 266);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(299, 26);
			this.dateTimePicker1.TabIndex = 13;
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Location = new System.Drawing.Point(6, 243);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(48, 20);
			this.labelDate.TabIndex = 12;
			this.labelDate.Text = "Дата";
			// 
			// textBoxSum
			// 
			this.textBoxSum.Location = new System.Drawing.Point(10, 201);
			this.textBoxSum.Name = "textBoxSum";
			this.textBoxSum.Size = new System.Drawing.Size(299, 26);
			this.textBoxSum.TabIndex = 11;
			this.textBoxSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSum_KeyPress);
			// 
			// labelSum
			// 
			this.labelSum.AutoSize = true;
			this.labelSum.Location = new System.Drawing.Point(6, 177);
			this.labelSum.Name = "labelSum";
			this.labelSum.Size = new System.Drawing.Size(58, 20);
			this.labelSum.TabIndex = 10;
			this.labelSum.Text = "Сумма";
			// 
			// comboBoxOperationType
			// 
			this.comboBoxOperationType.FormattingEnabled = true;
			this.comboBoxOperationType.Location = new System.Drawing.Point(10, 135);
			this.comboBoxOperationType.Name = "comboBoxOperationType";
			this.comboBoxOperationType.Size = new System.Drawing.Size(299, 28);
			this.comboBoxOperationType.TabIndex = 9;
			// 
			// comboBoxProvider
			// 
			this.comboBoxProvider.FormattingEnabled = true;
			this.comboBoxProvider.Location = new System.Drawing.Point(10, 70);
			this.comboBoxProvider.Name = "comboBoxProvider";
			this.comboBoxProvider.Size = new System.Drawing.Size(299, 28);
			this.comboBoxProvider.TabIndex = 8;
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
			this.buttonDelete.Location = new System.Drawing.Point(6, 452);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(303, 35);
			this.buttonDelete.TabIndex = 6;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(6, 411);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(303, 35);
			this.buttonUpdate.TabIndex = 5;
			this.buttonUpdate.Text = "Изменить";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(166, 310);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(143, 43);
			this.buttonAdd.TabIndex = 4;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// labelOperationType
			// 
			this.labelOperationType.AutoSize = true;
			this.labelOperationType.Location = new System.Drawing.Point(6, 112);
			this.labelOperationType.Name = "labelOperationType";
			this.labelOperationType.Size = new System.Drawing.Size(112, 20);
			this.labelOperationType.TabIndex = 3;
			this.labelOperationType.Text = "Тип операции";
			// 
			// labelProvider
			// 
			this.labelProvider.AutoSize = true;
			this.labelProvider.Location = new System.Drawing.Point(6, 47);
			this.labelProvider.Name = "labelProvider";
			this.labelProvider.Size = new System.Drawing.Size(95, 20);
			this.labelProvider.TabIndex = 2;
			this.labelProvider.Text = "Поставщик";
			// 
			// dataGridViewReceipts
			// 
			this.dataGridViewReceipts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridViewReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewReceipts.Location = new System.Drawing.Point(16, 59);
			this.dataGridViewReceipts.Name = "dataGridViewReceipts";
			this.dataGridViewReceipts.RowHeadersWidth = 62;
			this.dataGridViewReceipts.RowTemplate.Height = 28;
			this.dataGridViewReceipts.Size = new System.Drawing.Size(851, 440);
			this.dataGridViewReceipts.TabIndex = 5;
			// 
			// labelReceipts
			// 
			this.labelReceipts.AutoSize = true;
			this.labelReceipts.Location = new System.Drawing.Point(12, 13);
			this.labelReceipts.Name = "labelReceipts";
			this.labelReceipts.Size = new System.Drawing.Size(109, 20);
			this.labelReceipts.TabIndex = 7;
			this.labelReceipts.Text = "Поступления";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 523);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Табличная часть";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(16, 546);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(851, 406);
			this.dataGridView1.TabIndex = 9;
			// 
			// ReceiptsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 964);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelReceipts);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridViewReceipts);
			this.Name = "ReceiptsForm";
			this.Text = "ReceiptsForm";
			this.Load += new System.EventHandler(this.ReceiptsForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Label labelOperationType;
		private System.Windows.Forms.Label labelProvider;
		private System.Windows.Forms.DataGridView dataGridViewReceipts;
		private System.Windows.Forms.ComboBox comboBoxOperationType;
		private System.Windows.Forms.ComboBox comboBoxProvider;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.TextBox textBoxSum;
		private System.Windows.Forms.Label labelSum;
		private System.Windows.Forms.Label labelReceipts;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}