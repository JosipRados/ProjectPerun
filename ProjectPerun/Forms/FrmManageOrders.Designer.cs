using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmManageOrders
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
            this.gbProjectData = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMarkFinished = new System.Windows.Forms.Button();
            this.btnRefreshOrders = new System.Windows.Forms.Button();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbFinished = new System.Windows.Forms.RadioButton();
            this.rbAllOrders = new System.Windows.Forms.RadioButton();
            this.cbFinished = new System.Windows.Forms.CheckBox();
            this.cbMaterialAsigned = new System.Windows.Forms.CheckBox();
            this.tbFinishedDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrderedDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOrderQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grdOrders = new System.Windows.Forms.DataGridView();
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
            this.orderTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSOrderData = new ProjectPerun.DataSets.DSOrderData();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrderNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbShifts = new System.Windows.Forms.GroupBox();
            this.btnRefreshShifts = new System.Windows.Forms.Button();
            this.rbFinishig = new System.Windows.Forms.RadioButton();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.rbProduction = new System.Windows.Forms.RadioButton();
            this.rbAllShifts = new System.Windows.Forms.RadioButton();
            this.grdShifts = new System.Windows.Forms.DataGridView();
            this.gbPricesMaterials = new System.Windows.Forms.GroupBox();
            this.btnShowMaterials = new System.Windows.Forms.Button();
            this.tbFullTime = new System.Windows.Forms.TextBox();
            this.tbProductionTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbFinishingTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbFullPrice = new System.Windows.Forms.TextBox();
            this.tbMaterialPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbWorkerPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dSOrderDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSShifts = new ProjectPerun.DataSets.DSShifts();
            this.shiftTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStartedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeEndedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbProjectData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSOrderData)).BeginInit();
            this.gbShifts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdShifts)).BeginInit();
            this.gbPricesMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSOrderDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSShifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProjectData
            // 
            this.gbProjectData.Controls.Add(this.btnDelete);
            this.gbProjectData.Controls.Add(this.btnMarkFinished);
            this.gbProjectData.Controls.Add(this.btnRefreshOrders);
            this.gbProjectData.Controls.Add(this.rbActive);
            this.gbProjectData.Controls.Add(this.rbFinished);
            this.gbProjectData.Controls.Add(this.rbAllOrders);
            this.gbProjectData.Controls.Add(this.cbFinished);
            this.gbProjectData.Controls.Add(this.cbMaterialAsigned);
            this.gbProjectData.Controls.Add(this.tbFinishedDate);
            this.gbProjectData.Controls.Add(this.label5);
            this.gbProjectData.Controls.Add(this.tbOrderedDate);
            this.gbProjectData.Controls.Add(this.label4);
            this.gbProjectData.Controls.Add(this.tbOrderQuantity);
            this.gbProjectData.Controls.Add(this.label3);
            this.gbProjectData.Controls.Add(this.grdOrders);
            this.gbProjectData.Controls.Add(this.btnCreate);
            this.gbProjectData.Controls.Add(this.btnUpdate);
            this.gbProjectData.Controls.Add(this.tbProjectName);
            this.gbProjectData.Controls.Add(this.label2);
            this.gbProjectData.Controls.Add(this.tbOrderNumber);
            this.gbProjectData.Controls.Add(this.label1);
            this.gbProjectData.Location = new System.Drawing.Point(12, 10);
            this.gbProjectData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProjectData.Name = "gbProjectData";
            this.gbProjectData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProjectData.Size = new System.Drawing.Size(1158, 264);
            this.gbProjectData.TabIndex = 1;
            this.gbProjectData.TabStop = false;
            this.gbProjectData.Text = "Order Data";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(833, 197);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(251, 42);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMarkFinished
            // 
            this.btnMarkFinished.Location = new System.Drawing.Point(833, 126);
            this.btnMarkFinished.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMarkFinished.Name = "btnMarkFinished";
            this.btnMarkFinished.Size = new System.Drawing.Size(251, 42);
            this.btnMarkFinished.TabIndex = 25;
            this.btnMarkFinished.Text = "MARK AS FINISHED";
            this.btnMarkFinished.UseVisualStyleBackColor = true;
            this.btnMarkFinished.Click += new System.EventHandler(this.btnMarkFinished_Click);
            // 
            // btnRefreshOrders
            // 
            this.btnRefreshOrders.Location = new System.Drawing.Point(408, 207);
            this.btnRefreshOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshOrders.Name = "btnRefreshOrders";
            this.btnRefreshOrders.Size = new System.Drawing.Size(352, 31);
            this.btnRefreshOrders.TabIndex = 24;
            this.btnRefreshOrders.Text = "REFRESH";
            this.btnRefreshOrders.UseVisualStyleBackColor = true;
            this.btnRefreshOrders.Click += new System.EventHandler(this.btnRefreshOrders_Click);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(592, 183);
            this.rbActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(65, 20);
            this.rbActive.TabIndex = 23;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbOrders_CheckedChanged);
            // 
            // rbFinished
            // 
            this.rbFinished.AutoSize = true;
            this.rbFinished.Location = new System.Drawing.Point(484, 183);
            this.rbFinished.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFinished.Name = "rbFinished";
            this.rbFinished.Size = new System.Drawing.Size(79, 20);
            this.rbFinished.TabIndex = 22;
            this.rbFinished.Text = "Finished";
            this.rbFinished.UseVisualStyleBackColor = true;
            this.rbFinished.CheckedChanged += new System.EventHandler(this.rbOrders_CheckedChanged);
            // 
            // rbAllOrders
            // 
            this.rbAllOrders.AutoSize = true;
            this.rbAllOrders.Checked = true;
            this.rbAllOrders.Location = new System.Drawing.Point(408, 183);
            this.rbAllOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAllOrders.Name = "rbAllOrders";
            this.rbAllOrders.Size = new System.Drawing.Size(43, 20);
            this.rbAllOrders.TabIndex = 21;
            this.rbAllOrders.TabStop = true;
            this.rbAllOrders.Text = "All";
            this.rbAllOrders.UseVisualStyleBackColor = true;
            this.rbAllOrders.CheckedChanged += new System.EventHandler(this.rbOrders_CheckedChanged);
            // 
            // cbFinished
            // 
            this.cbFinished.AutoSize = true;
            this.cbFinished.Enabled = false;
            this.cbFinished.Location = new System.Drawing.Point(148, 219);
            this.cbFinished.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFinished.Name = "cbFinished";
            this.cbFinished.Size = new System.Drawing.Size(80, 20);
            this.cbFinished.TabIndex = 20;
            this.cbFinished.Text = "Finished";
            this.cbFinished.UseVisualStyleBackColor = true;
            // 
            // cbMaterialAsigned
            // 
            this.cbMaterialAsigned.AutoSize = true;
            this.cbMaterialAsigned.Enabled = false;
            this.cbMaterialAsigned.Location = new System.Drawing.Point(148, 195);
            this.cbMaterialAsigned.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaterialAsigned.Name = "cbMaterialAsigned";
            this.cbMaterialAsigned.Size = new System.Drawing.Size(130, 20);
            this.cbMaterialAsigned.TabIndex = 19;
            this.cbMaterialAsigned.Text = "Material Asigned";
            this.cbMaterialAsigned.UseVisualStyleBackColor = true;
            // 
            // tbFinishedDate
            // 
            this.tbFinishedDate.Location = new System.Drawing.Point(148, 154);
            this.tbFinishedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFinishedDate.Name = "tbFinishedDate";
            this.tbFinishedDate.ReadOnly = true;
            this.tbFinishedDate.Size = new System.Drawing.Size(220, 22);
            this.tbFinishedDate.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(16, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Finished:";
            // 
            // tbOrderedDate
            // 
            this.tbOrderedDate.Location = new System.Drawing.Point(148, 124);
            this.tbOrderedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOrderedDate.Name = "tbOrderedDate";
            this.tbOrderedDate.ReadOnly = true;
            this.tbOrderedDate.Size = new System.Drawing.Size(220, 22);
            this.tbOrderedDate.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(16, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ordered:";
            // 
            // tbOrderQuantity
            // 
            this.tbOrderQuantity.Location = new System.Drawing.Point(148, 86);
            this.tbOrderQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOrderQuantity.Name = "tbOrderQuantity";
            this.tbOrderQuantity.Size = new System.Drawing.Size(220, 22);
            this.tbOrderQuantity.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Order Quantity:";
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
            this.grdOrders.Location = new System.Drawing.Point(408, 28);
            this.grdOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.ReadOnly = true;
            this.grdOrders.RowHeadersVisible = false;
            this.grdOrders.RowHeadersWidth = 51;
            this.grdOrders.RowTemplate.Height = 29;
            this.grdOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrders.Size = new System.Drawing.Size(352, 150);
            this.grdOrders.TabIndex = 0;
            this.grdOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectIDDataGridViewTextBoxColumn
            // 
            this.projectIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.HeaderText = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
            this.projectIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectIDDataGridViewTextBoxColumn.Visible = false;
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
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(833, 28);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(251, 42);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "CREATE ORDER";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(833, 77);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(251, 42);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(148, 56);
            this.tbProjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.ReadOnly = true;
            this.tbProjectName.Size = new System.Drawing.Size(220, 22);
            this.tbProjectName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Project Name:";
            // 
            // tbOrderNumber
            // 
            this.tbOrderNumber.Location = new System.Drawing.Point(148, 28);
            this.tbOrderNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOrderNumber.Name = "tbOrderNumber";
            this.tbOrderNumber.ReadOnly = true;
            this.tbOrderNumber.Size = new System.Drawing.Size(220, 22);
            this.tbOrderNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Number:";
            // 
            // gbShifts
            // 
            this.gbShifts.Controls.Add(this.btnRefreshShifts);
            this.gbShifts.Controls.Add(this.rbFinishig);
            this.gbShifts.Controls.Add(this.btnShowDetails);
            this.gbShifts.Controls.Add(this.rbProduction);
            this.gbShifts.Controls.Add(this.rbAllShifts);
            this.gbShifts.Controls.Add(this.grdShifts);
            this.gbShifts.Location = new System.Drawing.Point(12, 278);
            this.gbShifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbShifts.Name = "gbShifts";
            this.gbShifts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbShifts.Size = new System.Drawing.Size(538, 242);
            this.gbShifts.TabIndex = 2;
            this.gbShifts.TabStop = false;
            this.gbShifts.Text = "Shifts";
            // 
            // btnRefreshShifts
            // 
            this.btnRefreshShifts.Location = new System.Drawing.Point(307, 185);
            this.btnRefreshShifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshShifts.Name = "btnRefreshShifts";
            this.btnRefreshShifts.Size = new System.Drawing.Size(96, 31);
            this.btnRefreshShifts.TabIndex = 30;
            this.btnRefreshShifts.Text = "SHOW";
            this.btnRefreshShifts.UseVisualStyleBackColor = true;
            this.btnRefreshShifts.Click += new System.EventHandler(this.btnRefreshShifts_Click);
            // 
            // rbFinishig
            // 
            this.rbFinishig.AutoSize = true;
            this.rbFinishig.Location = new System.Drawing.Point(182, 185);
            this.rbFinishig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFinishig.Name = "rbFinishig";
            this.rbFinishig.Size = new System.Drawing.Size(81, 20);
            this.rbFinishig.TabIndex = 29;
            this.rbFinishig.Text = "Finishing";
            this.rbFinishig.UseVisualStyleBackColor = true;
            this.rbFinishig.CheckedChanged += new System.EventHandler(this.rbShifts_CheckedChanged);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Location = new System.Drawing.Point(422, 185);
            this.btnShowDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(96, 31);
            this.btnShowDetails.TabIndex = 27;
            this.btnShowDetails.Text = "DETAILS";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Visible = false;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // rbProduction
            // 
            this.rbProduction.AutoSize = true;
            this.rbProduction.Location = new System.Drawing.Point(74, 185);
            this.rbProduction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbProduction.Name = "rbProduction";
            this.rbProduction.Size = new System.Drawing.Size(92, 20);
            this.rbProduction.TabIndex = 28;
            this.rbProduction.Text = "Production";
            this.rbProduction.UseVisualStyleBackColor = true;
            this.rbProduction.CheckedChanged += new System.EventHandler(this.rbShifts_CheckedChanged);
            // 
            // rbAllShifts
            // 
            this.rbAllShifts.AutoSize = true;
            this.rbAllShifts.Checked = true;
            this.rbAllShifts.Location = new System.Drawing.Point(17, 185);
            this.rbAllShifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAllShifts.Name = "rbAllShifts";
            this.rbAllShifts.Size = new System.Drawing.Size(43, 20);
            this.rbAllShifts.TabIndex = 27;
            this.rbAllShifts.TabStop = true;
            this.rbAllShifts.Text = "All";
            this.rbAllShifts.UseVisualStyleBackColor = true;
            this.rbAllShifts.CheckedChanged += new System.EventHandler(this.rbShifts_CheckedChanged);
            // 
            // grdShifts
            // 
            this.grdShifts.AllowUserToAddRows = false;
            this.grdShifts.AllowUserToDeleteRows = false;
            this.grdShifts.AllowUserToResizeColumns = false;
            this.grdShifts.AutoGenerateColumns = false;
            this.grdShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdShifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.orderIDDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.timeStartedDataGridViewTextBoxColumn,
            this.timeEndedDataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn1});
            this.grdShifts.DataSource = this.shiftTableBindingSource;
            this.grdShifts.Location = new System.Drawing.Point(16, 30);
            this.grdShifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdShifts.Name = "grdShifts";
            this.grdShifts.ReadOnly = true;
            this.grdShifts.RowHeadersVisible = false;
            this.grdShifts.RowHeadersWidth = 51;
            this.grdShifts.RowTemplate.Height = 29;
            this.grdShifts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdShifts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdShifts.Size = new System.Drawing.Size(502, 150);
            this.grdShifts.TabIndex = 27;
            // 
            // gbPricesMaterials
            // 
            this.gbPricesMaterials.Controls.Add(this.btnShowMaterials);
            this.gbPricesMaterials.Controls.Add(this.tbFullTime);
            this.gbPricesMaterials.Controls.Add(this.tbProductionTime);
            this.gbPricesMaterials.Controls.Add(this.label9);
            this.gbPricesMaterials.Controls.Add(this.label10);
            this.gbPricesMaterials.Controls.Add(this.tbFinishingTime);
            this.gbPricesMaterials.Controls.Add(this.label11);
            this.gbPricesMaterials.Controls.Add(this.tbFullPrice);
            this.gbPricesMaterials.Controls.Add(this.tbMaterialPrice);
            this.gbPricesMaterials.Controls.Add(this.label6);
            this.gbPricesMaterials.Controls.Add(this.label8);
            this.gbPricesMaterials.Controls.Add(this.tbWorkerPrice);
            this.gbPricesMaterials.Controls.Add(this.label7);
            this.gbPricesMaterials.Location = new System.Drawing.Point(556, 278);
            this.gbPricesMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPricesMaterials.Name = "gbPricesMaterials";
            this.gbPricesMaterials.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPricesMaterials.Size = new System.Drawing.Size(614, 242);
            this.gbPricesMaterials.TabIndex = 4;
            this.gbPricesMaterials.TabStop = false;
            this.gbPricesMaterials.Text = "Prices And Materials";
            // 
            // btnShowMaterials
            // 
            this.btnShowMaterials.Location = new System.Drawing.Point(384, 174);
            this.btnShowMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowMaterials.Name = "btnShowMaterials";
            this.btnShowMaterials.Size = new System.Drawing.Size(207, 42);
            this.btnShowMaterials.TabIndex = 27;
            this.btnShowMaterials.Text = "SHOW MATERIALS";
            this.btnShowMaterials.UseVisualStyleBackColor = true;
            this.btnShowMaterials.Click += new System.EventHandler(this.btnShowMaterials_Click);
            // 
            // tbFullTime
            // 
            this.tbFullTime.Location = new System.Drawing.Point(166, 193);
            this.tbFullTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFullTime.Name = "tbFullTime";
            this.tbFullTime.ReadOnly = true;
            this.tbFullTime.Size = new System.Drawing.Size(191, 22);
            this.tbFullTime.TabIndex = 38;
            // 
            // tbProductionTime
            // 
            this.tbProductionTime.Location = new System.Drawing.Point(166, 134);
            this.tbProductionTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProductionTime.Name = "tbProductionTime";
            this.tbProductionTime.ReadOnly = true;
            this.tbProductionTime.Size = new System.Drawing.Size(191, 22);
            this.tbProductionTime.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label9.Location = new System.Drawing.Point(21, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "Full Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label10.Location = new System.Drawing.Point(21, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 23);
            this.label10.TabIndex = 34;
            this.label10.Text = "Production Time:";
            // 
            // tbFinishingTime
            // 
            this.tbFinishingTime.Location = new System.Drawing.Point(166, 163);
            this.tbFinishingTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFinishingTime.Name = "tbFinishingTime";
            this.tbFinishingTime.ReadOnly = true;
            this.tbFinishingTime.Size = new System.Drawing.Size(191, 22);
            this.tbFinishingTime.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label11.Location = new System.Drawing.Point(21, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 23);
            this.label11.TabIndex = 35;
            this.label11.Text = "Finishing Time:";
            // 
            // tbFullPrice
            // 
            this.tbFullPrice.Location = new System.Drawing.Point(166, 88);
            this.tbFullPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFullPrice.Name = "tbFullPrice";
            this.tbFullPrice.ReadOnly = true;
            this.tbFullPrice.Size = new System.Drawing.Size(191, 22);
            this.tbFullPrice.TabIndex = 32;
            // 
            // tbMaterialPrice
            // 
            this.tbMaterialPrice.Location = new System.Drawing.Point(166, 30);
            this.tbMaterialPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaterialPrice.Name = "tbMaterialPrice";
            this.tbMaterialPrice.ReadOnly = true;
            this.tbMaterialPrice.Size = new System.Drawing.Size(191, 22);
            this.tbMaterialPrice.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(21, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Full Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label8.Location = new System.Drawing.Point(21, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 28;
            this.label8.Text = "Material Price:";
            // 
            // tbWorkerPrice
            // 
            this.tbWorkerPrice.Location = new System.Drawing.Point(166, 58);
            this.tbWorkerPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWorkerPrice.Name = "tbWorkerPrice";
            this.tbWorkerPrice.ReadOnly = true;
            this.tbWorkerPrice.Size = new System.Drawing.Size(191, 22);
            this.tbWorkerPrice.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(21, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Worker Price:";
            // 
            // dSOrderDataBindingSource
            // 
            this.dSOrderDataBindingSource.DataSource = this.dSOrderData;
            this.dSOrderDataBindingSource.Position = 0;
            // 
            // dSShifts
            // 
            this.dSShifts.DataSetName = "DSShifts";
            this.dSShifts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shiftTableBindingSource
            // 
            this.shiftTableBindingSource.DataMember = "ShiftTable";
            this.shiftTableBindingSource.DataSource = this.dSShifts;
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
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeStartedDataGridViewTextBoxColumn
            // 
            this.timeStartedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeStartedDataGridViewTextBoxColumn.DataPropertyName = "TimeStarted";
            this.timeStartedDataGridViewTextBoxColumn.HeaderText = "TimeStarted";
            this.timeStartedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeStartedDataGridViewTextBoxColumn.Name = "timeStartedDataGridViewTextBoxColumn";
            this.timeStartedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeEndedDataGridViewTextBoxColumn
            // 
            this.timeEndedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeEndedDataGridViewTextBoxColumn.DataPropertyName = "TimeEnded";
            this.timeEndedDataGridViewTextBoxColumn.HeaderText = "TimeEnded";
            this.timeEndedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeEndedDataGridViewTextBoxColumn.Name = "timeEndedDataGridViewTextBoxColumn";
            this.timeEndedDataGridViewTextBoxColumn.ReadOnly = true;
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
            // FrmManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 530);
            this.Controls.Add(this.gbPricesMaterials);
            this.Controls.Add(this.gbShifts);
            this.Controls.Add(this.gbProjectData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmManageOrders";
            this.Text = "ManageOrders";
            this.Load += new System.EventHandler(this.FrmManageOrders_Load);
            this.gbProjectData.ResumeLayout(false);
            this.gbProjectData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSOrderData)).EndInit();
            this.gbShifts.ResumeLayout(false);
            this.gbShifts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdShifts)).EndInit();
            this.gbPricesMaterials.ResumeLayout(false);
            this.gbPricesMaterials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSOrderDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSShifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbProjectData;
        private Button btnDelete;
        private Button btnMarkFinished;
        private Button btnRefreshOrders;
        private RadioButton rbActive;
        private RadioButton rbFinished;
        private RadioButton rbAllOrders;
        private CheckBox cbFinished;
        private CheckBox cbMaterialAsigned;
        private TextBox tbFinishedDate;
        private Label label5;
        private TextBox tbOrderedDate;
        private Label label4;
        private TextBox tbOrderQuantity;
        private Label label3;
        private DataGridView grdOrders;
        private Button btnCreate;
        private Button btnUpdate;
        private TextBox tbProjectName;
        private Label label2;
        private TextBox tbOrderNumber;
        private Label label1;
        private GroupBox gbShifts;
        private Button btnRefreshShifts;
        private RadioButton rbFinishig;
        private Button btnShowDetails;
        private RadioButton rbProduction;
        private RadioButton rbAllShifts;
        private DataGridView grdShifts;
        private GroupBox gbPricesMaterials;
        private Button btnShowMaterials;
        private TextBox tbFullTime;
        private TextBox tbProductionTime;
        private Label label9;
        private Label label10;
        private TextBox tbFinishingTime;
        private Label label11;
        private TextBox tbFullPrice;
        private TextBox tbMaterialPrice;
        private Label label6;
        private Label label8;
        private TextBox tbWorkerPrice;
        private Label label7;
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
        private BindingSource orderTableBindingSource;
        private ProjectPerun.DataSets.DSOrderData dSOrderData;
        private BindingSource dSOrderDataBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeStartedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeEndedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn1;
        private BindingSource shiftTableBindingSource;
        private ProjectPerun.DataSets.DSShifts dSShifts;
    }
}