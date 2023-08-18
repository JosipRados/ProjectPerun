using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmStorage
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
            this.grdStorage = new System.Windows.Forms.DataGridView();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSStorage1 = new ProjectPerun.DataSets.DSStorage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOrderBy = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMaterials = new System.Windows.Forms.RadioButton();
            this.rbElements = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dSStorage1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastChangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.importBatchNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onProjectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSStorage1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSStorage1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStorage
            // 
            this.grdStorage.AllowUserToAddRows = false;
            this.grdStorage.AllowUserToDeleteRows = false;
            this.grdStorage.AutoGenerateColumns = false;
            this.grdStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.packageQuantityDataGridViewTextBoxColumn,
            this.currentQuantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.elementIDDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.warehouseIDDataGridViewTextBoxColumn,
            this.lastChangeDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn,
            this.reservedDataGridViewCheckBoxColumn,
            this.importBatchNumberDataGridViewTextBoxColumn,
            this.transactionIDDataGridViewTextBoxColumn,
            this.onProjectDataGridViewCheckBoxColumn,
            this.projectIDDataGridViewTextBoxColumn,
            this.removedDataGridViewCheckBoxColumn});
            this.grdStorage.DataSource = this.storageBindingSource;
            this.grdStorage.Location = new System.Drawing.Point(35, 21);
            this.grdStorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdStorage.Name = "grdStorage";
            this.grdStorage.ReadOnly = true;
            this.grdStorage.RowHeadersVisible = false;
            this.grdStorage.RowHeadersWidth = 51;
            this.grdStorage.RowTemplate.Height = 29;
            this.grdStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStorage.Size = new System.Drawing.Size(1114, 287);
            this.grdStorage.TabIndex = 0;
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "Storage";
            this.storageBindingSource.DataSource = this.dSStorage1;
            // 
            // dSStorage1
            // 
            this.dSStorage1.DataSetName = "DSStorage";
            this.dSStorage1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(35, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(150, 400);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(307, 22);
            this.tbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(35, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code:";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(150, 426);
            this.tbCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(307, 22);
            this.tbCode.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(35, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Order by:";
            // 
            // cbOrderBy
            // 
            this.cbOrderBy.FormattingEnabled = true;
            this.cbOrderBy.Location = new System.Drawing.Point(150, 453);
            this.cbOrderBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrderBy.Name = "cbOrderBy";
            this.cbOrderBy.Size = new System.Drawing.Size(307, 24);
            this.cbOrderBy.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(678, 400);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 48);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 374);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 22);
            this.textBox1.TabIndex = 11;
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbNumber.Location = new System.Drawing.Point(35, 377);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(77, 23);
            this.lbNumber.TabIndex = 10;
            this.lbNumber.Text = "Number:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Location = new System.Drawing.Point(35, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 318);
            this.panel1.TabIndex = 12;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundImage = global::ProjectPerun.Properties.Resources.arrowLeftIcon;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(933, 292);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(48, 21);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::ProjectPerun.Properties.Resources.arrowRightIcon;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(1024, 292);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(49, 21);
            this.btnNext.TabIndex = 17;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMaterials);
            this.groupBox1.Controls.Add(this.rbElements);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Location = new System.Drawing.Point(478, 374);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(167, 102);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rbMaterials
            // 
            this.rbMaterials.AutoSize = true;
            this.rbMaterials.Location = new System.Drawing.Point(18, 72);
            this.rbMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMaterials.Name = "rbMaterials";
            this.rbMaterials.Size = new System.Drawing.Size(83, 20);
            this.rbMaterials.TabIndex = 2;
            this.rbMaterials.TabStop = true;
            this.rbMaterials.Text = "Materials";
            this.rbMaterials.UseVisualStyleBackColor = true;
            // 
            // rbElements
            // 
            this.rbElements.AutoSize = true;
            this.rbElements.Location = new System.Drawing.Point(18, 48);
            this.rbElements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbElements.Name = "rbElements";
            this.rbElements.Size = new System.Drawing.Size(84, 20);
            this.rbElements.TabIndex = 1;
            this.rbElements.TabStop = true;
            this.rbElements.Text = "Elements";
            this.rbElements.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(18, 24);
            this.rbAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(43, 20);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(904, 400);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(160, 48);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "ADD NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(904, 347);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 48);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(904, 453);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 48);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dSStorage1BindingSource
            // 
            this.dSStorage1BindingSource.DataSource = this.dSStorage1;
            this.dSStorage1BindingSource.Position = 0;
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
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // packageQuantityDataGridViewTextBoxColumn
            // 
            this.packageQuantityDataGridViewTextBoxColumn.DataPropertyName = "PackageQuantity";
            this.packageQuantityDataGridViewTextBoxColumn.HeaderText = "PackageQuantity";
            this.packageQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packageQuantityDataGridViewTextBoxColumn.Name = "packageQuantityDataGridViewTextBoxColumn";
            this.packageQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.packageQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentQuantityDataGridViewTextBoxColumn
            // 
            this.currentQuantityDataGridViewTextBoxColumn.DataPropertyName = "CurrentQuantity";
            this.currentQuantityDataGridViewTextBoxColumn.HeaderText = "CurrentQuantity";
            this.currentQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentQuantityDataGridViewTextBoxColumn.Name = "currentQuantityDataGridViewTextBoxColumn";
            this.currentQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // elementIDDataGridViewTextBoxColumn
            // 
            this.elementIDDataGridViewTextBoxColumn.DataPropertyName = "ElementID";
            this.elementIDDataGridViewTextBoxColumn.HeaderText = "ElementID";
            this.elementIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elementIDDataGridViewTextBoxColumn.Name = "elementIDDataGridViewTextBoxColumn";
            this.elementIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.elementIDDataGridViewTextBoxColumn.Visible = false;
            this.elementIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // warehouseIDDataGridViewTextBoxColumn
            // 
            this.warehouseIDDataGridViewTextBoxColumn.DataPropertyName = "WarehouseID";
            this.warehouseIDDataGridViewTextBoxColumn.HeaderText = "WarehouseID";
            this.warehouseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.warehouseIDDataGridViewTextBoxColumn.Name = "warehouseIDDataGridViewTextBoxColumn";
            this.warehouseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.warehouseIDDataGridViewTextBoxColumn.Visible = false;
            this.warehouseIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastChangeDataGridViewTextBoxColumn
            // 
            this.lastChangeDataGridViewTextBoxColumn.DataPropertyName = "LastChange";
            this.lastChangeDataGridViewTextBoxColumn.HeaderText = "LastChange";
            this.lastChangeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastChangeDataGridViewTextBoxColumn.Name = "lastChangeDataGridViewTextBoxColumn";
            this.lastChangeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastChangeDataGridViewTextBoxColumn.Visible = false;
            this.lastChangeDataGridViewTextBoxColumn.Width = 125;
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
            // timeStampDataGridViewTextBoxColumn
            // 
            this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
            this.timeStampDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeStampDataGridViewTextBoxColumn.Width = 236;
            // 
            // reservedDataGridViewCheckBoxColumn
            // 
            this.reservedDataGridViewCheckBoxColumn.DataPropertyName = "Reserved";
            this.reservedDataGridViewCheckBoxColumn.HeaderText = "Reserved";
            this.reservedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.reservedDataGridViewCheckBoxColumn.Name = "reservedDataGridViewCheckBoxColumn";
            this.reservedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.reservedDataGridViewCheckBoxColumn.Visible = false;
            this.reservedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // importBatchNumberDataGridViewTextBoxColumn
            // 
            this.importBatchNumberDataGridViewTextBoxColumn.DataPropertyName = "ImportBatchNumber";
            this.importBatchNumberDataGridViewTextBoxColumn.HeaderText = "ImportBatchNumber";
            this.importBatchNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.importBatchNumberDataGridViewTextBoxColumn.Name = "importBatchNumberDataGridViewTextBoxColumn";
            this.importBatchNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.importBatchNumberDataGridViewTextBoxColumn.Visible = false;
            this.importBatchNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            this.transactionIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.HeaderText = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            this.transactionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionIDDataGridViewTextBoxColumn.Visible = false;
            this.transactionIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // onProjectDataGridViewCheckBoxColumn
            // 
            this.onProjectDataGridViewCheckBoxColumn.DataPropertyName = "OnProject";
            this.onProjectDataGridViewCheckBoxColumn.HeaderText = "OnProject";
            this.onProjectDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.onProjectDataGridViewCheckBoxColumn.Name = "onProjectDataGridViewCheckBoxColumn";
            this.onProjectDataGridViewCheckBoxColumn.ReadOnly = true;
            this.onProjectDataGridViewCheckBoxColumn.Visible = false;
            this.onProjectDataGridViewCheckBoxColumn.Width = 125;
            // 
            // projectIDDataGridViewTextBoxColumn
            // 
            this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.HeaderText = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
            this.projectIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectIDDataGridViewTextBoxColumn.Visible = false;
            this.projectIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // removedDataGridViewCheckBoxColumn
            // 
            this.removedDataGridViewCheckBoxColumn.DataPropertyName = "Removed";
            this.removedDataGridViewCheckBoxColumn.HeaderText = "Removed";
            this.removedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.removedDataGridViewCheckBoxColumn.Name = "removedDataGridViewCheckBoxColumn";
            this.removedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.removedDataGridViewCheckBoxColumn.Visible = false;
            this.removedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // FrmStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 530);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbOrderBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdStorage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmStorage";
            this.Text = "FrmStorage";
            this.Load += new System.EventHandler(this.FrmStorage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSStorage1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSStorage1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdStorage;
        private Label label1;
        private TextBox tbName;
        private Label label2;
        private TextBox tbCode;
        private Label label4;
        private ComboBox cbOrderBy;
        private Button btnSearch;
        private TextBox textBox1;
        private Label lbNumber;
        private Panel panel1;
        private GroupBox groupBox1;
        private RadioButton rbMaterials;
        private RadioButton rbElements;
        private RadioButton rbAll;
        private Button btnPrevious;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnNext;
        private BindingSource storageBindingSource;
        private ProjectPerun.DataSets.DSStorage dSStorage1;
        private BindingSource dSStorage1BindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn packageQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn elementIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn warehouseIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastChangeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn reservedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn importBatchNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn onProjectDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn removedDataGridViewCheckBoxColumn;
    }
}