
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
			this.groupBoxReceipt = new System.Windows.Forms.GroupBox();
			this.comboBoxSource = new System.Windows.Forms.ComboBox();
			this.labelSource = new System.Windows.Forms.Label();
			this.dateTimePickerReceiptDate = new System.Windows.Forms.DateTimePicker();
			this.labelDate = new System.Windows.Forms.Label();
			this.comboBoxProvider = new System.Windows.Forms.ComboBox();
			this.buttonReceiptDelete = new System.Windows.Forms.Button();
			this.buttonReceiptUpdate = new System.Windows.Forms.Button();
			this.buttonReceiptAdd = new System.Windows.Forms.Button();
			this.labelProvider = new System.Windows.Forms.Label();
			this.dataGridViewReceipts = new System.Windows.Forms.DataGridView();
			this.labelReceipts = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewReceiptTable = new System.Windows.Forms.DataGridView();
			this.groupBoxReceiptTable = new System.Windows.Forms.GroupBox();
			this.buttonClose = new System.Windows.Forms.Button();
			this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
			this.labelCount = new System.Windows.Forms.Label();
			this.comboBoxFixedAsset = new System.Windows.Forms.ComboBox();
			this.buttonReceiptTableDelete = new System.Windows.Forms.Button();
			this.buttonReceiptTebleAdd = new System.Windows.Forms.Button();
			this.labelFixedAsset = new System.Windows.Forms.Label();
			this.groupBoxReceipt.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiptTable)).BeginInit();
			this.groupBoxReceiptTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxReceipt
			// 
			this.groupBoxReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxReceipt.Controls.Add(this.comboBoxSource);
			this.groupBoxReceipt.Controls.Add(this.labelSource);
			this.groupBoxReceipt.Controls.Add(this.dateTimePickerReceiptDate);
			this.groupBoxReceipt.Controls.Add(this.labelDate);
			this.groupBoxReceipt.Controls.Add(this.comboBoxProvider);
			this.groupBoxReceipt.Controls.Add(this.buttonReceiptDelete);
			this.groupBoxReceipt.Controls.Add(this.buttonReceiptUpdate);
			this.groupBoxReceipt.Controls.Add(this.buttonReceiptAdd);
			this.groupBoxReceipt.Controls.Add(this.labelProvider);
			this.groupBoxReceipt.Location = new System.Drawing.Point(873, 36);
			this.groupBoxReceipt.Name = "groupBoxReceipt";
			this.groupBoxReceipt.Size = new System.Drawing.Size(315, 369);
			this.groupBoxReceipt.TabIndex = 6;
			this.groupBoxReceipt.TabStop = false;
			this.groupBoxReceipt.Text = "Добавление / редактирование";
			// 
			// comboBoxSource
			// 
			this.comboBoxSource.FormattingEnabled = true;
			this.comboBoxSource.Location = new System.Drawing.Point(6, 56);
			this.comboBoxSource.Name = "comboBoxSource";
			this.comboBoxSource.Size = new System.Drawing.Size(299, 28);
			this.comboBoxSource.TabIndex = 15;
			this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSource_SelectedIndexChanged);
			// 
			// labelSource
			// 
			this.labelSource.AutoSize = true;
			this.labelSource.Location = new System.Drawing.Point(2, 33);
			this.labelSource.Name = "labelSource";
			this.labelSource.Size = new System.Drawing.Size(81, 20);
			this.labelSource.TabIndex = 14;
			this.labelSource.Text = "Источник";
			// 
			// dateTimePickerReceiptDate
			// 
			this.dateTimePickerReceiptDate.Location = new System.Drawing.Point(6, 122);
			this.dateTimePickerReceiptDate.Name = "dateTimePickerReceiptDate";
			this.dateTimePickerReceiptDate.Size = new System.Drawing.Size(299, 26);
			this.dateTimePickerReceiptDate.TabIndex = 13;
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Location = new System.Drawing.Point(2, 99);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(48, 20);
			this.labelDate.TabIndex = 12;
			this.labelDate.Text = "Дата";
			// 
			// comboBoxProvider
			// 
			this.comboBoxProvider.FormattingEnabled = true;
			this.comboBoxProvider.Location = new System.Drawing.Point(6, 184);
			this.comboBoxProvider.Name = "comboBoxProvider";
			this.comboBoxProvider.Size = new System.Drawing.Size(299, 28);
			this.comboBoxProvider.TabIndex = 8;
			// 
			// buttonReceiptDelete
			// 
			this.buttonReceiptDelete.Location = new System.Drawing.Point(6, 296);
			this.buttonReceiptDelete.Name = "buttonReceiptDelete";
			this.buttonReceiptDelete.Size = new System.Drawing.Size(303, 35);
			this.buttonReceiptDelete.TabIndex = 6;
			this.buttonReceiptDelete.Text = "Удалить";
			this.buttonReceiptDelete.UseVisualStyleBackColor = true;
			this.buttonReceiptDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonReceiptUpdate
			// 
			this.buttonReceiptUpdate.Location = new System.Drawing.Point(6, 255);
			this.buttonReceiptUpdate.Name = "buttonReceiptUpdate";
			this.buttonReceiptUpdate.Size = new System.Drawing.Size(303, 35);
			this.buttonReceiptUpdate.TabIndex = 5;
			this.buttonReceiptUpdate.Text = "Изменить";
			this.buttonReceiptUpdate.UseVisualStyleBackColor = true;
			this.buttonReceiptUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonReceiptAdd
			// 
			this.buttonReceiptAdd.Location = new System.Drawing.Point(6, 218);
			this.buttonReceiptAdd.Name = "buttonReceiptAdd";
			this.buttonReceiptAdd.Size = new System.Drawing.Size(303, 31);
			this.buttonReceiptAdd.TabIndex = 4;
			this.buttonReceiptAdd.Text = "Добавить";
			this.buttonReceiptAdd.UseVisualStyleBackColor = true;
			this.buttonReceiptAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// labelProvider
			// 
			this.labelProvider.AutoSize = true;
			this.labelProvider.Location = new System.Drawing.Point(2, 161);
			this.labelProvider.Name = "labelProvider";
			this.labelProvider.Size = new System.Drawing.Size(95, 20);
			this.labelProvider.TabIndex = 2;
			this.labelProvider.Text = "Поставщик";
			// 
			// dataGridViewReceipts
			// 
			this.dataGridViewReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewReceipts.Location = new System.Drawing.Point(12, 36);
			this.dataGridViewReceipts.Name = "dataGridViewReceipts";
			this.dataGridViewReceipts.RowHeadersWidth = 62;
			this.dataGridViewReceipts.RowTemplate.Height = 28;
			this.dataGridViewReceipts.Size = new System.Drawing.Size(851, 369);
			this.dataGridViewReceipts.TabIndex = 5;
			this.dataGridViewReceipts.SelectionChanged += new System.EventHandler(this.dataGridViewReceipts_SelectionChanged);
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
			this.label1.Location = new System.Drawing.Point(12, 423);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Табличная часть";
			// 
			// dataGridViewReceiptTable
			// 
			this.dataGridViewReceiptTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewReceiptTable.Location = new System.Drawing.Point(12, 446);
			this.dataGridViewReceiptTable.Name = "dataGridViewReceiptTable";
			this.dataGridViewReceiptTable.RowHeadersWidth = 62;
			this.dataGridViewReceiptTable.RowTemplate.Height = 28;
			this.dataGridViewReceiptTable.Size = new System.Drawing.Size(851, 457);
			this.dataGridViewReceiptTable.TabIndex = 9;
			this.dataGridViewReceiptTable.SelectionChanged += new System.EventHandler(this.dataGridViewReceiptTable_SelectionChanged);
			// 
			// groupBoxReceiptTable
			// 
			this.groupBoxReceiptTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxReceiptTable.Controls.Add(this.buttonClose);
			this.groupBoxReceiptTable.Controls.Add(this.numericUpDownCount);
			this.groupBoxReceiptTable.Controls.Add(this.labelCount);
			this.groupBoxReceiptTable.Controls.Add(this.comboBoxFixedAsset);
			this.groupBoxReceiptTable.Controls.Add(this.buttonReceiptTableDelete);
			this.groupBoxReceiptTable.Controls.Add(this.buttonReceiptTebleAdd);
			this.groupBoxReceiptTable.Controls.Add(this.labelFixedAsset);
			this.groupBoxReceiptTable.Location = new System.Drawing.Point(873, 446);
			this.groupBoxReceiptTable.Name = "groupBoxReceiptTable";
			this.groupBoxReceiptTable.Size = new System.Drawing.Size(315, 457);
			this.groupBoxReceiptTable.TabIndex = 10;
			this.groupBoxReceiptTable.TabStop = false;
			this.groupBoxReceiptTable.Text = "Добавление / редактирование";
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(194, 411);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(119, 46);
			this.buttonClose.TabIndex = 14;
			this.buttonClose.Text = "Закрыть";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// numericUpDownCount
			// 
			this.numericUpDownCount.Location = new System.Drawing.Point(10, 119);
			this.numericUpDownCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownCount.Name = "numericUpDownCount";
			this.numericUpDownCount.Size = new System.Drawing.Size(299, 26);
			this.numericUpDownCount.TabIndex = 13;
			this.numericUpDownCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelCount
			// 
			this.labelCount.AutoSize = true;
			this.labelCount.Location = new System.Drawing.Point(6, 96);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(100, 20);
			this.labelCount.TabIndex = 12;
			this.labelCount.Text = "Количество";
			// 
			// comboBoxFixedAsset
			// 
			this.comboBoxFixedAsset.FormattingEnabled = true;
			this.comboBoxFixedAsset.Location = new System.Drawing.Point(10, 54);
			this.comboBoxFixedAsset.Name = "comboBoxFixedAsset";
			this.comboBoxFixedAsset.Size = new System.Drawing.Size(299, 28);
			this.comboBoxFixedAsset.TabIndex = 9;
			// 
			// buttonReceiptTableDelete
			// 
			this.buttonReceiptTableDelete.Location = new System.Drawing.Point(10, 244);
			this.buttonReceiptTableDelete.Name = "buttonReceiptTableDelete";
			this.buttonReceiptTableDelete.Size = new System.Drawing.Size(303, 35);
			this.buttonReceiptTableDelete.TabIndex = 6;
			this.buttonReceiptTableDelete.Text = "Удалить";
			this.buttonReceiptTableDelete.UseVisualStyleBackColor = true;
			this.buttonReceiptTableDelete.Click += new System.EventHandler(this.buttonReceiptTableDelete_Click);
			// 
			// buttonReceiptTebleAdd
			// 
			this.buttonReceiptTebleAdd.Location = new System.Drawing.Point(166, 164);
			this.buttonReceiptTebleAdd.Name = "buttonReceiptTebleAdd";
			this.buttonReceiptTebleAdd.Size = new System.Drawing.Size(143, 43);
			this.buttonReceiptTebleAdd.TabIndex = 4;
			this.buttonReceiptTebleAdd.Text = "Добавить";
			this.buttonReceiptTebleAdd.UseVisualStyleBackColor = true;
			this.buttonReceiptTebleAdd.Click += new System.EventHandler(this.buttonReceiptTableAdd_Click);
			// 
			// labelFixedAsset
			// 
			this.labelFixedAsset.AutoSize = true;
			this.labelFixedAsset.Location = new System.Drawing.Point(6, 31);
			this.labelFixedAsset.Name = "labelFixedAsset";
			this.labelFixedAsset.Size = new System.Drawing.Size(159, 20);
			this.labelFixedAsset.TabIndex = 3;
			this.labelFixedAsset.Text = "Основное средство";
			// 
			// ReceiptsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 918);
			this.Controls.Add(this.groupBoxReceiptTable);
			this.Controls.Add(this.dataGridViewReceiptTable);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelReceipts);
			this.Controls.Add(this.groupBoxReceipt);
			this.Controls.Add(this.dataGridViewReceipts);
			this.Name = "ReceiptsForm";
			this.Text = " ";
			this.Load += new System.EventHandler(this.ReceiptsForm_Load);
			this.groupBoxReceipt.ResumeLayout(false);
			this.groupBoxReceipt.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiptTable)).EndInit();
			this.groupBoxReceiptTable.ResumeLayout(false);
			this.groupBoxReceiptTable.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxReceipt;
		private System.Windows.Forms.Button buttonReceiptDelete;
		private System.Windows.Forms.Button buttonReceiptUpdate;
		private System.Windows.Forms.Button buttonReceiptAdd;
		private System.Windows.Forms.Label labelProvider;
		private System.Windows.Forms.DataGridView dataGridViewReceipts;
		private System.Windows.Forms.ComboBox comboBoxProvider;
		private System.Windows.Forms.DateTimePicker dateTimePickerReceiptDate;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.Label labelReceipts;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridViewReceiptTable;
		private System.Windows.Forms.GroupBox groupBoxReceiptTable;
		private System.Windows.Forms.ComboBox comboBoxFixedAsset;
		private System.Windows.Forms.Button buttonReceiptTableDelete;
		private System.Windows.Forms.Button buttonReceiptTebleAdd;
		private System.Windows.Forms.Label labelFixedAsset;
		private System.Windows.Forms.Label labelCount;
		private System.Windows.Forms.NumericUpDown numericUpDownCount;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.ComboBox comboBoxSource;
		private System.Windows.Forms.Label labelSource;
	}
}