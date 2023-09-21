using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmInsertBatch
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
            this.components = new System.ComponentModel.Container();
            this.grdImport = new System.Windows.Forms.DataGridView();
            this.transactionTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSTransactionStorage = new ProjectPerun.DataSets.DSTransactionStorage();
            this.gbBatchInformation = new System.Windows.Forms.GroupBox();
            this.brnGetData = new System.Windows.Forms.Button();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBatchNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbExistingBatch = new System.Windows.Forms.RadioButton();
            this.rbNewBatch = new System.Windows.Forms.RadioButton();
            this.cbWarehouse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMaterialInformation = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grdMaterialData = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.materialDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMaterialData = new ProjectPerun.DataSets.DSMaterialData();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbElement = new System.Windows.Forms.RadioButton();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastChangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.onProjectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.batchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importBatchNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTransactionStorage)).BeginInit();
            this.gbBatchInformation.SuspendLayout();
            this.gbMaterialInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMaterialData)).BeginInit();
            this.SuspendLayout();
            // 
            // grdImport
            // 
            this.grdImport.AllowUserToAddRows = false;
            this.grdImport.AllowUserToDeleteRows = false;
            this.grdImport.AllowUserToResizeRows = false;
            this.grdImport.AutoGenerateColumns = false;
            this.grdImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.numberDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.transactionTypeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.elementIDDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.warehouseIDDataGridViewTextBoxColumn,
            this.lastChangeDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn1,
            this.timeStampDataGridViewTextBoxColumn1,
            this.reservedDataGridViewCheckBoxColumn,
            this.onProjectDataGridViewCheckBoxColumn,
            this.batchIDDataGridViewTextBoxColumn,
            this.importBatchNumberDataGridViewTextBoxColumn});
            this.grdImport.DataSource = this.transactionTableBindingSource;
            this.grdImport.Location = new System.Drawing.Point(598, 22);
            this.grdImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdImport.Name = "grdImport";
            this.grdImport.RowHeadersVisible = false;
            this.grdImport.RowHeadersWidth = 51;
            this.grdImport.RowTemplate.Height = 17;
            this.grdImport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdImport.Size = new System.Drawing.Size(551, 408);
            this.grdImport.TabIndex = 0;
            // 
            // transactionTableBindingSource
            // 
            this.transactionTableBindingSource.DataMember = "TransactionTable";
            this.transactionTableBindingSource.DataSource = this.dSTransactionStorage;
            // 
            // dSTransactionStorage
            // 
            this.dSTransactionStorage.DataSetName = "DSTransactionStorage";
            this.dSTransactionStorage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbBatchInformation
            // 
            this.gbBatchInformation.Controls.Add(this.brnGetData);
            this.gbBatchInformation.Controls.Add(this.tbDate);
            this.gbBatchInformation.Controls.Add(this.label4);
            this.gbBatchInformation.Controls.Add(this.tbSender);
            this.gbBatchInformation.Controls.Add(this.label3);
            this.gbBatchInformation.Controls.Add(this.tbBatchNumber);
            this.gbBatchInformation.Controls.Add(this.label2);
            this.gbBatchInformation.Controls.Add(this.rbExistingBatch);
            this.gbBatchInformation.Controls.Add(this.rbNewBatch);
            this.gbBatchInformation.Controls.Add(this.cbWarehouse);
            this.gbBatchInformation.Controls.Add(this.label1);
            this.gbBatchInformation.Location = new System.Drawing.Point(12, 10);
            this.gbBatchInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBatchInformation.Name = "gbBatchInformation";
            this.gbBatchInformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBatchInformation.Size = new System.Drawing.Size(562, 148);
            this.gbBatchInformation.TabIndex = 1;
            this.gbBatchInformation.TabStop = false;
            this.gbBatchInformation.Text = "Batch Information";
            // 
            // brnGetData
            // 
            this.brnGetData.Location = new System.Drawing.Point(326, 100);
            this.brnGetData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brnGetData.Name = "brnGetData";
            this.brnGetData.Size = new System.Drawing.Size(122, 35);
            this.brnGetData.TabIndex = 10;
            this.brnGetData.Text = "GET DATA";
            this.brnGetData.UseVisualStyleBackColor = true;
            this.brnGetData.Click += new System.EventHandler(this.brnGetData_Click);
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(111, 114);
            this.tbDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(167, 22);
            this.tbDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date:";
            // 
            // tbSender
            // 
            this.tbSender.Location = new System.Drawing.Point(111, 87);
            this.tbSender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSender.Name = "tbSender";
            this.tbSender.Size = new System.Drawing.Size(167, 22);
            this.tbSender.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sender:";
            // 
            // tbBatchNumber
            // 
            this.tbBatchNumber.Location = new System.Drawing.Point(111, 61);
            this.tbBatchNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBatchNumber.Name = "tbBatchNumber";
            this.tbBatchNumber.ReadOnly = true;
            this.tbBatchNumber.Size = new System.Drawing.Size(167, 22);
            this.tbBatchNumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Batch No:";
            // 
            // rbExistingBatch
            // 
            this.rbExistingBatch.AutoSize = true;
            this.rbExistingBatch.Location = new System.Drawing.Point(326, 53);
            this.rbExistingBatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbExistingBatch.Name = "rbExistingBatch";
            this.rbExistingBatch.Size = new System.Drawing.Size(111, 20);
            this.rbExistingBatch.TabIndex = 3;
            this.rbExistingBatch.Text = "Existing Batch";
            this.rbExistingBatch.UseVisualStyleBackColor = true;
            this.rbExistingBatch.Click += new System.EventHandler(this.rbExistingBatch_Click);
            // 
            // rbNewBatch
            // 
            this.rbNewBatch.AutoSize = true;
            this.rbNewBatch.Checked = true;
            this.rbNewBatch.Location = new System.Drawing.Point(326, 29);
            this.rbNewBatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNewBatch.Name = "rbNewBatch";
            this.rbNewBatch.Size = new System.Drawing.Size(92, 20);
            this.rbNewBatch.TabIndex = 2;
            this.rbNewBatch.TabStop = true;
            this.rbNewBatch.Text = "New Batch";
            this.rbNewBatch.UseVisualStyleBackColor = true;
            this.rbNewBatch.Click += new System.EventHandler(this.rbNewBatch_Click);
            // 
            // cbWarehouse
            // 
            this.cbWarehouse.FormattingEnabled = true;
            this.cbWarehouse.Location = new System.Drawing.Point(111, 26);
            this.cbWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Size = new System.Drawing.Size(167, 24);
            this.cbWarehouse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warehouse:";
            // 
            // gbMaterialInformation
            // 
            this.gbMaterialInformation.Controls.Add(this.btnAdd);
            this.gbMaterialInformation.Controls.Add(this.grdMaterialData);
            this.gbMaterialInformation.Controls.Add(this.tbName);
            this.gbMaterialInformation.Controls.Add(this.label9);
            this.gbMaterialInformation.Controls.Add(this.rbOther);
            this.gbMaterialInformation.Controls.Add(this.rbElement);
            this.gbMaterialInformation.Controls.Add(this.tbPrice);
            this.gbMaterialInformation.Controls.Add(this.label8);
            this.gbMaterialInformation.Controls.Add(this.tbQuantity);
            this.gbMaterialInformation.Controls.Add(this.label5);
            this.gbMaterialInformation.Controls.Add(this.tbCode);
            this.gbMaterialInformation.Controls.Add(this.label6);
            this.gbMaterialInformation.Controls.Add(this.tbNumber);
            this.gbMaterialInformation.Controls.Add(this.label7);
            this.gbMaterialInformation.Location = new System.Drawing.Point(12, 179);
            this.gbMaterialInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMaterialInformation.Name = "gbMaterialInformation";
            this.gbMaterialInformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMaterialInformation.Size = new System.Drawing.Size(562, 331);
            this.gbMaterialInformation.TabIndex = 2;
            this.gbMaterialInformation.TabStop = false;
            this.gbMaterialInformation.Text = "Material Information";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 255);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(272, 35);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grdMaterialData
            // 
            this.grdMaterialData.AllowUserToAddRows = false;
            this.grdMaterialData.AllowUserToDeleteRows = false;
            this.grdMaterialData.AllowUserToResizeRows = false;
            this.grdMaterialData.AutoGenerateColumns = false;
            this.grdMaterialData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaterialData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.materialTypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.grdMaterialData.DataSource = this.materialDataBindingSource;
            this.grdMaterialData.Location = new System.Drawing.Point(299, 29);
            this.grdMaterialData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdMaterialData.Name = "grdMaterialData";
            this.grdMaterialData.ReadOnly = true;
            this.grdMaterialData.RowHeadersVisible = false;
            this.grdMaterialData.RowHeadersWidth = 51;
            this.grdMaterialData.RowTemplate.Height = 17;
            this.grdMaterialData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdMaterialData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMaterialData.Size = new System.Drawing.Size(245, 262);
            this.grdMaterialData.TabIndex = 3;
            this.grdMaterialData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMaterialData_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialTypeDataGridViewTextBoxColumn
            // 
            this.materialTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.materialTypeDataGridViewTextBoxColumn.DataPropertyName = "MaterialType";
            this.materialTypeDataGridViewTextBoxColumn.HeaderText = "MaterialType";
            this.materialTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
            this.materialTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeStampDataGridViewTextBoxColumn
            // 
            this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
            this.timeStampDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeStampDataGridViewTextBoxColumn.Visible = false;
            this.timeStampDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn.Visible = false;
            this.activeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // materialDataBindingSource
            // 
            this.materialDataBindingSource.DataMember = "MaterialData";
            this.materialDataBindingSource.DataSource = this.dSMaterialData;
            // 
            // dSMaterialData
            // 
            this.dSMaterialData.DataSetName = "DSMaterialData";
            this.dSMaterialData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(111, 55);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(167, 22);
            this.tbName.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label9.Location = new System.Drawing.Point(6, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Name:";
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Enabled = false;
            this.rbOther.Location = new System.Drawing.Point(139, 186);
            this.rbOther.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(60, 20);
            this.rbOther.TabIndex = 11;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbElement
            // 
            this.rbElement.AutoSize = true;
            this.rbElement.Enabled = false;
            this.rbElement.Location = new System.Drawing.Point(21, 186);
            this.rbElement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbElement.Name = "rbElement";
            this.rbElement.Size = new System.Drawing.Size(77, 20);
            this.rbElement.TabIndex = 18;
            this.rbElement.TabStop = true;
            this.rbElement.Text = "Element";
            this.rbElement.UseVisualStyleBackColor = true;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(111, 134);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(167, 22);
            this.tbPrice.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label8.Location = new System.Drawing.Point(6, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Price:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(111, 108);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(167, 22);
            this.tbQuantity.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantity:";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(111, 82);
            this.tbCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCode.Name = "tbCode";
            this.tbCode.ReadOnly = true;
            this.tbCode.Size = new System.Drawing.Size(167, 22);
            this.tbCode.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(6, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Code:";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(111, 29);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.ReadOnly = true;
            this.tbNumber.Size = new System.Drawing.Size(167, 22);
            this.tbNumber.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Number:";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(877, 447);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(272, 35);
            this.btnImport.TabIndex = 22;
            this.btnImport.Text = "IMPORT";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            this.iDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn1
            // 
            this.codeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn1.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn1.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn1.Name = "codeDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // transactionTypeDataGridViewTextBoxColumn
            // 
            this.transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
            this.transactionTypeDataGridViewTextBoxColumn.Visible = false;
            this.transactionTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // elementIDDataGridViewTextBoxColumn
            // 
            this.elementIDDataGridViewTextBoxColumn.DataPropertyName = "ElementID";
            this.elementIDDataGridViewTextBoxColumn.HeaderText = "ElementID";
            this.elementIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elementIDDataGridViewTextBoxColumn.Name = "elementIDDataGridViewTextBoxColumn";
            this.elementIDDataGridViewTextBoxColumn.Visible = false;
            this.elementIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Visible = false;
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // warehouseIDDataGridViewTextBoxColumn
            // 
            this.warehouseIDDataGridViewTextBoxColumn.DataPropertyName = "WarehouseID";
            this.warehouseIDDataGridViewTextBoxColumn.HeaderText = "WarehouseID";
            this.warehouseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.warehouseIDDataGridViewTextBoxColumn.Name = "warehouseIDDataGridViewTextBoxColumn";
            this.warehouseIDDataGridViewTextBoxColumn.Visible = false;
            this.warehouseIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastChangeDataGridViewTextBoxColumn
            // 
            this.lastChangeDataGridViewTextBoxColumn.DataPropertyName = "LastChange";
            this.lastChangeDataGridViewTextBoxColumn.HeaderText = "LastChange";
            this.lastChangeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastChangeDataGridViewTextBoxColumn.Name = "lastChangeDataGridViewTextBoxColumn";
            this.lastChangeDataGridViewTextBoxColumn.Visible = false;
            this.lastChangeDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIDDataGridViewTextBoxColumn1
            // 
            this.userIDDataGridViewTextBoxColumn1.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn1.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn1.Name = "userIDDataGridViewTextBoxColumn1";
            this.userIDDataGridViewTextBoxColumn1.Visible = false;
            this.userIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // timeStampDataGridViewTextBoxColumn1
            // 
            this.timeStampDataGridViewTextBoxColumn1.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn1.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.timeStampDataGridViewTextBoxColumn1.Name = "timeStampDataGridViewTextBoxColumn1";
            this.timeStampDataGridViewTextBoxColumn1.Visible = false;
            this.timeStampDataGridViewTextBoxColumn1.Width = 125;
            // 
            // reservedDataGridViewCheckBoxColumn
            // 
            this.reservedDataGridViewCheckBoxColumn.DataPropertyName = "Reserved";
            this.reservedDataGridViewCheckBoxColumn.HeaderText = "Reserved";
            this.reservedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.reservedDataGridViewCheckBoxColumn.Name = "reservedDataGridViewCheckBoxColumn";
            this.reservedDataGridViewCheckBoxColumn.Visible = false;
            this.reservedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // onProjectDataGridViewCheckBoxColumn
            // 
            this.onProjectDataGridViewCheckBoxColumn.DataPropertyName = "OnProject";
            this.onProjectDataGridViewCheckBoxColumn.HeaderText = "OnProject";
            this.onProjectDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.onProjectDataGridViewCheckBoxColumn.Name = "onProjectDataGridViewCheckBoxColumn";
            this.onProjectDataGridViewCheckBoxColumn.Visible = false;
            this.onProjectDataGridViewCheckBoxColumn.Width = 125;
            // 
            // batchIDDataGridViewTextBoxColumn
            // 
            this.batchIDDataGridViewTextBoxColumn.DataPropertyName = "BatchID";
            this.batchIDDataGridViewTextBoxColumn.HeaderText = "BatchID";
            this.batchIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.batchIDDataGridViewTextBoxColumn.Name = "batchIDDataGridViewTextBoxColumn";
            this.batchIDDataGridViewTextBoxColumn.Visible = false;
            this.batchIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // importBatchNumberDataGridViewTextBoxColumn
            // 
            this.importBatchNumberDataGridViewTextBoxColumn.DataPropertyName = "ImportBatchNumber";
            this.importBatchNumberDataGridViewTextBoxColumn.HeaderText = "ImportBatchNumber";
            this.importBatchNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.importBatchNumberDataGridViewTextBoxColumn.Name = "importBatchNumberDataGridViewTextBoxColumn";
            this.importBatchNumberDataGridViewTextBoxColumn.Visible = false;
            this.importBatchNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmInsertBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 530);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.gbMaterialInformation);
            this.Controls.Add(this.gbBatchInformation);
            this.Controls.Add(this.grdImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmInsertBatch";
            this.Text = "FrmInsertBatch";
            this.Load += new System.EventHandler(this.FrmInsertBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTransactionStorage)).EndInit();
            this.gbBatchInformation.ResumeLayout(false);
            this.gbBatchInformation.PerformLayout();
            this.gbMaterialInformation.ResumeLayout(false);
            this.gbMaterialInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMaterialData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdImport;
        private GroupBox gbBatchInformation;
        private Label label1;
        private RadioButton rbExistingBatch;
        private RadioButton rbNewBatch;
        private ComboBox cbWarehouse;
        private Button brnGetData;
        private TextBox tbDate;
        private Label label4;
        private TextBox tbSender;
        private Label label3;
        private TextBox tbBatchNumber;
        private Label label2;
        private GroupBox gbMaterialInformation;
        private TextBox tbQuantity;
        private Label label5;
        private TextBox tbCode;
        private Label label6;
        private TextBox tbNumber;
        private Label label7;
        private TextBox tbName;
        private Label label9;
        private RadioButton rbOther;
        private RadioButton rbElement;
        private TextBox tbPrice;
        private Label label8;
        private Button btnAdd;
        private DataGridView grdMaterialData;
        private Button btnImport;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private BindingSource materialDataBindingSource;
        private ProjectPerun.DataSets.DSMaterialData dSMaterialData;
        private BindingSource transactionTableBindingSource;
        private ProjectPerun.DataSets.DSTransactionStorage dSTransactionStorage;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn elementIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn warehouseIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastChangeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn reservedDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn onProjectDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn batchIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importBatchNumberDataGridViewTextBoxColumn;
    }
}