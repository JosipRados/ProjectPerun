using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmExportToProject
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
            this.gbStorageMaterial = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.grdStorage = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastChangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.importBatchNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onProjectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.projectIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSStorage = new ProjectPerun.DataSets.DSStorage();
            this.gbProjectMaterial = new System.Windows.Forms.GroupBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturnFinishing = new System.Windows.Forms.Button();
            this.btnReturnProduction = new System.Windows.Forms.Button();
            this.grdProduction = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.timeStampDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStorageTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSOrderStorage = new ProjectPerun.DataSets.DSOrderStorage();
            this.grdFinishing = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spentDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.timeStampDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbProjectData = new System.Windows.Forms.GroupBox();
            this.tbOrderNumber = new System.Windows.Forms.TextBox();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.orderTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSOrderData = new ProjectPerun.DataSets.DSOrderData();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialSeparatedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.finishedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.materialPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbStorageMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSStorage)).BeginInit();
            this.gbProjectMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStorageTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSOrderStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFinishing)).BeginInit();
            this.gbProjectData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSOrderData)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStorageMaterial
            // 
            this.gbStorageMaterial.Controls.Add(this.btnShow);
            this.gbStorageMaterial.Controls.Add(this.btnAddToOrder);
            this.gbStorageMaterial.Controls.Add(this.grdStorage);
            this.gbStorageMaterial.Location = new System.Drawing.Point(439, 18);
            this.gbStorageMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStorageMaterial.Name = "gbStorageMaterial";
            this.gbStorageMaterial.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStorageMaterial.Size = new System.Drawing.Size(714, 237);
            this.gbStorageMaterial.TabIndex = 0;
            this.gbStorageMaterial.TabStop = false;
            this.gbStorageMaterial.Text = "Storage Material";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(555, 33);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(145, 34);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(555, 182);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(145, 34);
            this.btnAddToOrder.TabIndex = 7;
            this.btnAddToOrder.Text = "ADD TO ORDER";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // grdStorage
            // 
            this.grdStorage.AllowUserToAddRows = false;
            this.grdStorage.AllowUserToDeleteRows = false;
            this.grdStorage.AllowUserToResizeRows = false;
            this.grdStorage.AutoGenerateColumns = false;
            this.grdStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.numberDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.packageQuantityDataGridViewTextBoxColumn,
            this.currentQuantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.elementIDDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.Department,
            this.warehouseIDDataGridViewTextBoxColumn,
            this.lastChangeDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn1,
            this.timeStampDataGridViewTextBoxColumn1,
            this.reservedDataGridViewCheckBoxColumn,
            this.importBatchNumberDataGridViewTextBoxColumn,
            this.transactionIDDataGridViewTextBoxColumn,
            this.onProjectDataGridViewCheckBoxColumn,
            this.projectIDDataGridViewTextBoxColumn1,
            this.removedDataGridViewCheckBoxColumn});
            this.grdStorage.DataSource = this.storageBindingSource;
            this.grdStorage.Location = new System.Drawing.Point(22, 33);
            this.grdStorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdStorage.Name = "grdStorage";
            this.grdStorage.ReadOnly = true;
            this.grdStorage.RowHeadersVisible = false;
            this.grdStorage.RowHeadersWidth = 51;
            this.grdStorage.RowTemplate.Height = 17;
            this.grdStorage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStorage.Size = new System.Drawing.Size(527, 184);
            this.grdStorage.TabIndex = 6;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // packageQuantityDataGridViewTextBoxColumn
            // 
            this.packageQuantityDataGridViewTextBoxColumn.DataPropertyName = "PackageQuantity";
            this.packageQuantityDataGridViewTextBoxColumn.HeaderText = "PackageQuantity";
            this.packageQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packageQuantityDataGridViewTextBoxColumn.Name = "packageQuantityDataGridViewTextBoxColumn";
            this.packageQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.packageQuantityDataGridViewTextBoxColumn.Visible = false;
            this.packageQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentQuantityDataGridViewTextBoxColumn
            // 
            this.currentQuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.currentQuantityDataGridViewTextBoxColumn.DataPropertyName = "CurrentQuantity";
            this.currentQuantityDataGridViewTextBoxColumn.HeaderText = "CurrentQuantity";
            this.currentQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentQuantityDataGridViewTextBoxColumn.Name = "currentQuantityDataGridViewTextBoxColumn";
            this.currentQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Department.HeaderText = "Department";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
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
            // userIDDataGridViewTextBoxColumn1
            // 
            this.userIDDataGridViewTextBoxColumn1.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn1.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn1.Name = "userIDDataGridViewTextBoxColumn1";
            this.userIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn1.Visible = false;
            this.userIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // timeStampDataGridViewTextBoxColumn1
            // 
            this.timeStampDataGridViewTextBoxColumn1.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn1.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.timeStampDataGridViewTextBoxColumn1.Name = "timeStampDataGridViewTextBoxColumn1";
            this.timeStampDataGridViewTextBoxColumn1.ReadOnly = true;
            this.timeStampDataGridViewTextBoxColumn1.Visible = false;
            this.timeStampDataGridViewTextBoxColumn1.Width = 125;
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
            // projectIDDataGridViewTextBoxColumn1
            // 
            this.projectIDDataGridViewTextBoxColumn1.DataPropertyName = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn1.HeaderText = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.projectIDDataGridViewTextBoxColumn1.Name = "projectIDDataGridViewTextBoxColumn1";
            this.projectIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.projectIDDataGridViewTextBoxColumn1.Visible = false;
            this.projectIDDataGridViewTextBoxColumn1.Width = 125;
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
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "Storage";
            this.storageBindingSource.DataSource = this.dSStorage;
            // 
            // dSStorage
            // 
            this.dSStorage.DataSetName = "DSStorage";
            this.dSStorage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbProjectMaterial
            // 
            this.gbProjectMaterial.Controls.Add(this.btnDone);
            this.gbProjectMaterial.Controls.Add(this.label2);
            this.gbProjectMaterial.Controls.Add(this.label1);
            this.gbProjectMaterial.Controls.Add(this.btnReturnFinishing);
            this.gbProjectMaterial.Controls.Add(this.btnReturnProduction);
            this.gbProjectMaterial.Controls.Add(this.grdProduction);
            this.gbProjectMaterial.Controls.Add(this.grdFinishing);
            this.gbProjectMaterial.Location = new System.Drawing.Point(24, 270);
            this.gbProjectMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProjectMaterial.Name = "gbProjectMaterial";
            this.gbProjectMaterial.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProjectMaterial.Size = new System.Drawing.Size(1129, 237);
            this.gbProjectMaterial.TabIndex = 1;
            this.gbProjectMaterial.TabStop = false;
            this.gbProjectMaterial.Text = "Order Material:";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(1027, 170);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(102, 66);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(574, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Finishing:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Production:";
            // 
            // btnReturnFinishing
            // 
            this.btnReturnFinishing.Location = new System.Drawing.Point(967, 56);
            this.btnReturnFinishing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnFinishing.Name = "btnReturnFinishing";
            this.btnReturnFinishing.Size = new System.Drawing.Size(102, 34);
            this.btnReturnFinishing.TabIndex = 10;
            this.btnReturnFinishing.Text = "RETURN";
            this.btnReturnFinishing.UseVisualStyleBackColor = true;
            this.btnReturnFinishing.Click += new System.EventHandler(this.btnReturnFinishing_Click);
            // 
            // btnReturnProduction
            // 
            this.btnReturnProduction.Location = new System.Drawing.Point(415, 56);
            this.btnReturnProduction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnProduction.Name = "btnReturnProduction";
            this.btnReturnProduction.Size = new System.Drawing.Size(102, 34);
            this.btnReturnProduction.TabIndex = 9;
            this.btnReturnProduction.Text = "RETURN";
            this.btnReturnProduction.UseVisualStyleBackColor = true;
            this.btnReturnProduction.Click += new System.EventHandler(this.btnReturnProduction_Click);
            // 
            // grdProduction
            // 
            this.grdProduction.AllowUserToAddRows = false;
            this.grdProduction.AllowUserToDeleteRows = false;
            this.grdProduction.AllowUserToResizeRows = false;
            this.grdProduction.AutoGenerateColumns = false;
            this.grdProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.orderIDDataGridViewTextBoxColumn,
            this.storageIDDataGridViewTextBoxColumn,
            this.storageNumberDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn1,
            this.departmentDataGridViewTextBoxColumn,
            this.spentDataGridViewCheckBoxColumn,
            this.timeStampDataGridViewTextBoxColumn2,
            this.userIDDataGridViewTextBoxColumn2});
            this.grdProduction.DataSource = this.orderStorageTableBindingSource;
            this.grdProduction.Location = new System.Drawing.Point(22, 56);
            this.grdProduction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdProduction.Name = "grdProduction";
            this.grdProduction.ReadOnly = true;
            this.grdProduction.RowHeadersVisible = false;
            this.grdProduction.RowHeadersWidth = 51;
            this.grdProduction.RowTemplate.Height = 17;
            this.grdProduction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProduction.Size = new System.Drawing.Size(387, 160);
            this.grdProduction.TabIndex = 9;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn2.Visible = false;
            this.iDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Visible = false;
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // storageIDDataGridViewTextBoxColumn
            // 
            this.storageIDDataGridViewTextBoxColumn.DataPropertyName = "StorageID";
            this.storageIDDataGridViewTextBoxColumn.HeaderText = "StorageID";
            this.storageIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.storageIDDataGridViewTextBoxColumn.Name = "storageIDDataGridViewTextBoxColumn";
            this.storageIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.storageIDDataGridViewTextBoxColumn.Visible = false;
            this.storageIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // storageNumberDataGridViewTextBoxColumn
            // 
            this.storageNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.storageNumberDataGridViewTextBoxColumn.DataPropertyName = "StorageNumber";
            this.storageNumberDataGridViewTextBoxColumn.HeaderText = "StorageNumber";
            this.storageNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.storageNumberDataGridViewTextBoxColumn.Name = "storageNumberDataGridViewTextBoxColumn";
            this.storageNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            this.typeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentDataGridViewTextBoxColumn.Visible = false;
            this.departmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // spentDataGridViewCheckBoxColumn
            // 
            this.spentDataGridViewCheckBoxColumn.DataPropertyName = "Spent";
            this.spentDataGridViewCheckBoxColumn.HeaderText = "Spent";
            this.spentDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.spentDataGridViewCheckBoxColumn.Name = "spentDataGridViewCheckBoxColumn";
            this.spentDataGridViewCheckBoxColumn.ReadOnly = true;
            this.spentDataGridViewCheckBoxColumn.Visible = false;
            this.spentDataGridViewCheckBoxColumn.Width = 125;
            // 
            // timeStampDataGridViewTextBoxColumn2
            // 
            this.timeStampDataGridViewTextBoxColumn2.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn2.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.timeStampDataGridViewTextBoxColumn2.Name = "timeStampDataGridViewTextBoxColumn2";
            this.timeStampDataGridViewTextBoxColumn2.ReadOnly = true;
            this.timeStampDataGridViewTextBoxColumn2.Visible = false;
            this.timeStampDataGridViewTextBoxColumn2.Width = 125;
            // 
            // userIDDataGridViewTextBoxColumn2
            // 
            this.userIDDataGridViewTextBoxColumn2.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn2.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn2.Name = "userIDDataGridViewTextBoxColumn2";
            this.userIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn2.Visible = false;
            this.userIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // orderStorageTableBindingSource
            // 
            this.orderStorageTableBindingSource.DataMember = "OrderStorageTable";
            this.orderStorageTableBindingSource.DataSource = this.dSOrderStorage;
            // 
            // dSOrderStorage
            // 
            this.dSOrderStorage.DataSetName = "DSOrderStorage";
            this.dSOrderStorage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdFinishing
            // 
            this.grdFinishing.AllowUserToAddRows = false;
            this.grdFinishing.AllowUserToDeleteRows = false;
            this.grdFinishing.AllowUserToResizeRows = false;
            this.grdFinishing.AutoGenerateColumns = false;
            this.grdFinishing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFinishing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn3,
            this.orderIDDataGridViewTextBoxColumn1,
            this.storageIDDataGridViewTextBoxColumn1,
            this.storageNumberDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn2,
            this.departmentDataGridViewTextBoxColumn1,
            this.spentDataGridViewCheckBoxColumn1,
            this.timeStampDataGridViewTextBoxColumn3,
            this.userIDDataGridViewTextBoxColumn3});
            this.grdFinishing.DataSource = this.orderStorageTableBindingSource;
            this.grdFinishing.Location = new System.Drawing.Point(574, 56);
            this.grdFinishing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdFinishing.Name = "grdFinishing";
            this.grdFinishing.ReadOnly = true;
            this.grdFinishing.RowHeadersVisible = false;
            this.grdFinishing.RowHeadersWidth = 51;
            this.grdFinishing.RowTemplate.Height = 17;
            this.grdFinishing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdFinishing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFinishing.Size = new System.Drawing.Size(387, 160);
            this.grdFinishing.TabIndex = 8;
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            this.iDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn3.Visible = false;
            this.iDDataGridViewTextBoxColumn3.Width = 125;
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            this.orderIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn1.Visible = false;
            this.orderIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // storageIDDataGridViewTextBoxColumn1
            // 
            this.storageIDDataGridViewTextBoxColumn1.DataPropertyName = "StorageID";
            this.storageIDDataGridViewTextBoxColumn1.HeaderText = "StorageID";
            this.storageIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.storageIDDataGridViewTextBoxColumn1.Name = "storageIDDataGridViewTextBoxColumn1";
            this.storageIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.storageIDDataGridViewTextBoxColumn1.Visible = false;
            this.storageIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // storageNumberDataGridViewTextBoxColumn1
            // 
            this.storageNumberDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.storageNumberDataGridViewTextBoxColumn1.DataPropertyName = "StorageNumber";
            this.storageNumberDataGridViewTextBoxColumn1.HeaderText = "StorageNumber";
            this.storageNumberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.storageNumberDataGridViewTextBoxColumn1.Name = "storageNumberDataGridViewTextBoxColumn1";
            this.storageNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn2
            // 
            this.typeDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn2.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn2.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn2.Name = "typeDataGridViewTextBoxColumn2";
            this.typeDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn1
            // 
            this.departmentDataGridViewTextBoxColumn1.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn1.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn1.Name = "departmentDataGridViewTextBoxColumn1";
            this.departmentDataGridViewTextBoxColumn1.ReadOnly = true;
            this.departmentDataGridViewTextBoxColumn1.Visible = false;
            this.departmentDataGridViewTextBoxColumn1.Width = 125;
            // 
            // spentDataGridViewCheckBoxColumn1
            // 
            this.spentDataGridViewCheckBoxColumn1.DataPropertyName = "Spent";
            this.spentDataGridViewCheckBoxColumn1.HeaderText = "Spent";
            this.spentDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.spentDataGridViewCheckBoxColumn1.Name = "spentDataGridViewCheckBoxColumn1";
            this.spentDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.spentDataGridViewCheckBoxColumn1.Visible = false;
            this.spentDataGridViewCheckBoxColumn1.Width = 125;
            // 
            // timeStampDataGridViewTextBoxColumn3
            // 
            this.timeStampDataGridViewTextBoxColumn3.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn3.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.timeStampDataGridViewTextBoxColumn3.Name = "timeStampDataGridViewTextBoxColumn3";
            this.timeStampDataGridViewTextBoxColumn3.ReadOnly = true;
            this.timeStampDataGridViewTextBoxColumn3.Visible = false;
            this.timeStampDataGridViewTextBoxColumn3.Width = 125;
            // 
            // userIDDataGridViewTextBoxColumn3
            // 
            this.userIDDataGridViewTextBoxColumn3.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn3.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn3.Name = "userIDDataGridViewTextBoxColumn3";
            this.userIDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn3.Visible = false;
            this.userIDDataGridViewTextBoxColumn3.Width = 125;
            // 
            // gbProjectData
            // 
            this.gbProjectData.Controls.Add(this.tbOrderNumber);
            this.gbProjectData.Controls.Add(this.grdOrders);
            this.gbProjectData.Controls.Add(this.tbQuantity);
            this.gbProjectData.Controls.Add(this.tbProjectName);
            this.gbProjectData.Controls.Add(this.label5);
            this.gbProjectData.Controls.Add(this.label4);
            this.gbProjectData.Controls.Add(this.label3);
            this.gbProjectData.Location = new System.Drawing.Point(24, 18);
            this.gbProjectData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProjectData.Name = "gbProjectData";
            this.gbProjectData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProjectData.Size = new System.Drawing.Size(384, 237);
            this.gbProjectData.TabIndex = 2;
            this.gbProjectData.TabStop = false;
            this.gbProjectData.Text = "Order Data:";
            // 
            // tbOrderNumber
            // 
            this.tbOrderNumber.Location = new System.Drawing.Point(150, 30);
            this.tbOrderNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOrderNumber.Name = "tbOrderNumber";
            this.tbOrderNumber.ReadOnly = true;
            this.tbOrderNumber.Size = new System.Drawing.Size(214, 22);
            this.tbOrderNumber.TabIndex = 17;
            // 
            // grdOrders
            // 
            this.grdOrders.AllowUserToAddRows = false;
            this.grdOrders.AllowUserToDeleteRows = false;
            this.grdOrders.AllowUserToResizeRows = false;
            this.grdOrders.AutoGenerateColumns = false;
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.projectIDDataGridViewTextBoxColumn,
            this.orderedQuantityDataGridViewTextBoxColumn,
            this.dateOrderedDataGridViewTextBoxColumn,
            this.dateFinalDataGridViewTextBoxColumn,
            this.stageDataGridViewTextBoxColumn,
            this.materialSeparatedDataGridViewCheckBoxColumn,
            this.finishedDataGridViewCheckBoxColumn,
            this.materialPriceDataGridViewTextBoxColumn,
            this.workerPriceDataGridViewTextBoxColumn,
            this.productionTimeDataGridViewTextBoxColumn,
            this.finishingTimeDataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.grdOrders.DataSource = this.orderTableBindingSource;
            this.grdOrders.Location = new System.Drawing.Point(22, 119);
            this.grdOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.ReadOnly = true;
            this.grdOrders.RowHeadersVisible = false;
            this.grdOrders.RowHeadersWidth = 51;
            this.grdOrders.RowTemplate.Height = 17;
            this.grdOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrders.Size = new System.Drawing.Size(342, 98);
            this.grdOrders.TabIndex = 13;
            this.grdOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrders_CellClick);
            // 
            // orderTableBindingSource
            // 
            this.orderTableBindingSource.DataMember = "OrderTable";
            this.orderTableBindingSource.DataSource = this.dSOrderData;
            // 
            // dSOrderData
            // 
            this.dSOrderData.DataSetName = "DSOrderData";
            this.dSOrderData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(150, 82);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.ReadOnly = true;
            this.tbQuantity.Size = new System.Drawing.Size(214, 22);
            this.tbQuantity.TabIndex = 16;
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(150, 56);
            this.tbProjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.ReadOnly = true;
            this.tbProjectName.Size = new System.Drawing.Size(214, 22);
            this.tbProjectName.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Project Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Order Number:";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Order Number";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // orderedQuantityDataGridViewTextBoxColumn
            // 
            this.orderedQuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderedQuantityDataGridViewTextBoxColumn.DataPropertyName = "OrderedQuantity";
            this.orderedQuantityDataGridViewTextBoxColumn.HeaderText = "OrderedQuantity";
            this.orderedQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderedQuantityDataGridViewTextBoxColumn.Name = "orderedQuantityDataGridViewTextBoxColumn";
            this.orderedQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOrderedDataGridViewTextBoxColumn
            // 
            this.dateOrderedDataGridViewTextBoxColumn.DataPropertyName = "DateOrdered";
            this.dateOrderedDataGridViewTextBoxColumn.HeaderText = "DateOrdered";
            this.dateOrderedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOrderedDataGridViewTextBoxColumn.Name = "dateOrderedDataGridViewTextBoxColumn";
            this.dateOrderedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOrderedDataGridViewTextBoxColumn.Visible = false;
            this.dateOrderedDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateFinalDataGridViewTextBoxColumn
            // 
            this.dateFinalDataGridViewTextBoxColumn.DataPropertyName = "DateFinal";
            this.dateFinalDataGridViewTextBoxColumn.HeaderText = "DateFinal";
            this.dateFinalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateFinalDataGridViewTextBoxColumn.Name = "dateFinalDataGridViewTextBoxColumn";
            this.dateFinalDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateFinalDataGridViewTextBoxColumn.Visible = false;
            this.dateFinalDataGridViewTextBoxColumn.Width = 125;
            // 
            // stageDataGridViewTextBoxColumn
            // 
            this.stageDataGridViewTextBoxColumn.DataPropertyName = "Stage";
            this.stageDataGridViewTextBoxColumn.HeaderText = "Stage";
            this.stageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stageDataGridViewTextBoxColumn.Name = "stageDataGridViewTextBoxColumn";
            this.stageDataGridViewTextBoxColumn.ReadOnly = true;
            this.stageDataGridViewTextBoxColumn.Visible = false;
            this.stageDataGridViewTextBoxColumn.Width = 125;
            // 
            // materialSeparatedDataGridViewCheckBoxColumn
            // 
            this.materialSeparatedDataGridViewCheckBoxColumn.DataPropertyName = "MaterialSeparated";
            this.materialSeparatedDataGridViewCheckBoxColumn.HeaderText = "MaterialSeparated";
            this.materialSeparatedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.materialSeparatedDataGridViewCheckBoxColumn.Name = "materialSeparatedDataGridViewCheckBoxColumn";
            this.materialSeparatedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.materialSeparatedDataGridViewCheckBoxColumn.Visible = false;
            this.materialSeparatedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // finishedDataGridViewCheckBoxColumn
            // 
            this.finishedDataGridViewCheckBoxColumn.DataPropertyName = "Finished";
            this.finishedDataGridViewCheckBoxColumn.HeaderText = "Finished";
            this.finishedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.finishedDataGridViewCheckBoxColumn.Name = "finishedDataGridViewCheckBoxColumn";
            this.finishedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.finishedDataGridViewCheckBoxColumn.Visible = false;
            this.finishedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // materialPriceDataGridViewTextBoxColumn
            // 
            this.materialPriceDataGridViewTextBoxColumn.DataPropertyName = "MaterialPrice";
            this.materialPriceDataGridViewTextBoxColumn.HeaderText = "MaterialPrice";
            this.materialPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.materialPriceDataGridViewTextBoxColumn.Name = "materialPriceDataGridViewTextBoxColumn";
            this.materialPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialPriceDataGridViewTextBoxColumn.Visible = false;
            this.materialPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // workerPriceDataGridViewTextBoxColumn
            // 
            this.workerPriceDataGridViewTextBoxColumn.DataPropertyName = "WorkerPrice";
            this.workerPriceDataGridViewTextBoxColumn.HeaderText = "WorkerPrice";
            this.workerPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workerPriceDataGridViewTextBoxColumn.Name = "workerPriceDataGridViewTextBoxColumn";
            this.workerPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerPriceDataGridViewTextBoxColumn.Visible = false;
            this.workerPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productionTimeDataGridViewTextBoxColumn
            // 
            this.productionTimeDataGridViewTextBoxColumn.DataPropertyName = "ProductionTime";
            this.productionTimeDataGridViewTextBoxColumn.HeaderText = "ProductionTime";
            this.productionTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productionTimeDataGridViewTextBoxColumn.Name = "productionTimeDataGridViewTextBoxColumn";
            this.productionTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.productionTimeDataGridViewTextBoxColumn.Visible = false;
            this.productionTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // finishingTimeDataGridViewTextBoxColumn
            // 
            this.finishingTimeDataGridViewTextBoxColumn.DataPropertyName = "FinishingTime";
            this.finishingTimeDataGridViewTextBoxColumn.HeaderText = "FinishingTime";
            this.finishingTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finishingTimeDataGridViewTextBoxColumn.Name = "finishingTimeDataGridViewTextBoxColumn";
            this.finishingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.finishingTimeDataGridViewTextBoxColumn.Visible = false;
            this.finishingTimeDataGridViewTextBoxColumn.Width = 125;
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
            // FrmExportToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 530);
            this.Controls.Add(this.gbProjectData);
            this.Controls.Add(this.gbProjectMaterial);
            this.Controls.Add(this.gbStorageMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmExportToProject";
            this.Text = "FrmExportToProject";
            this.Load += new System.EventHandler(this.FrmExportToProject_Load);
            this.gbStorageMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSStorage)).EndInit();
            this.gbProjectMaterial.ResumeLayout(false);
            this.gbProjectMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStorageTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSOrderStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFinishing)).EndInit();
            this.gbProjectData.ResumeLayout(false);
            this.gbProjectData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSOrderData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbStorageMaterial;
        private GroupBox gbProjectMaterial;
        private DataGridView grdStorage;
        private DataGridView grdFinishing;
        private Label label1;
        private Button btnReturnFinishing;
        private Button btnReturnProduction;
        private DataGridView grdProduction;
        private Button btnAddToOrder;
        private Label label2;
        private GroupBox gbProjectData;
        private DataGridView grdOrders;
        private TextBox tbQuantity;
        private TextBox tbProjectName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnDone;
        private Button btnShow;
        private TextBox tbOrderNumber;
        private BindingSource storageBindingSource;
        private ProjectPerun.DataSets.DSStorage dSStorage;
        private BindingSource orderTableBindingSource;
        private ProjectPerun.DataSets.DSOrderData dSOrderData;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn packageQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn elementIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn warehouseIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastChangeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn reservedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn importBatchNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn onProjectDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn removedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn storageIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn storageNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn spentDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn2;
        private BindingSource orderStorageTableBindingSource;
        private ProjectPerun.DataSets.DSOrderStorage dSOrderStorage;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn storageIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn storageNumberDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn spentDataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderedQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOrderedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateFinalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stageDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn materialSeparatedDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn finishedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn materialPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workerPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productionTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finishingTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
    }
}