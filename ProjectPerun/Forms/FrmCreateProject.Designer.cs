using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmCreateProject
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbProjectDescription = new System.Windows.Forms.RichTextBox();
            this.tbProjectCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.tbMaterialType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grdAll = new System.Windows.Forms.DataGridView();
            this.tbMaterialQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaterialCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dSMaterialData = new ProjectPerun.DataSets.DSMaterialData();
            this.materialDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRemove = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdSelected = new System.Windows.Forms.DataGridView();
            this.projectMaterialsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dSProjectMaterials1 = new ProjectPerun.DataSets.DSProjectMaterials();
            this.projectMaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectMaterialsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSProjects1 = new ProjectPerun.DataSets.DSProjects();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.gbProjectData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMaterialData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMaterialsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProjectMaterials1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMaterialsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProjects1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProjectData
            // 
            this.gbProjectData.Controls.Add(this.tbProjectName);
            this.gbProjectData.Controls.Add(this.grdSelected);
            this.gbProjectData.Controls.Add(this.btnRemove);
            this.gbProjectData.Controls.Add(this.btnCreate);
            this.gbProjectData.Controls.Add(this.label3);
            this.gbProjectData.Controls.Add(this.rtbProjectDescription);
            this.gbProjectData.Controls.Add(this.tbProjectCompany);
            this.gbProjectData.Controls.Add(this.label2);
            this.gbProjectData.Controls.Add(this.label1);
            this.gbProjectData.Location = new System.Drawing.Point(12, 10);
            this.gbProjectData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProjectData.Name = "gbProjectData";
            this.gbProjectData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProjectData.Size = new System.Drawing.Size(450, 511);
            this.gbProjectData.TabIndex = 1;
            this.gbProjectData.TabStop = false;
            this.gbProjectData.Text = "Project Data";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(24, 458);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(403, 29);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description:";
            // 
            // rtbProjectDescription
            // 
            this.rtbProjectDescription.Location = new System.Drawing.Point(165, 87);
            this.rtbProjectDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbProjectDescription.Name = "rtbProjectDescription";
            this.rtbProjectDescription.Size = new System.Drawing.Size(262, 105);
            this.rtbProjectDescription.TabIndex = 6;
            this.rtbProjectDescription.Text = "";
            // 
            // tbProjectCompany
            // 
            this.tbProjectCompany.Location = new System.Drawing.Point(165, 56);
            this.tbProjectCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProjectCompany.Name = "tbProjectCompany";
            this.tbProjectCompany.Size = new System.Drawing.Size(262, 22);
            this.tbProjectCompany.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Company:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDepartment);
            this.groupBox1.Controls.Add(this.tbMaterialType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.grdAll);
            this.groupBox1.Controls.Add(this.tbMaterialQuantity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbMaterialCode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(480, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(690, 511);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Data";
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(126, 116);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(193, 24);
            this.cbDepartment.TabIndex = 16;
            // 
            // tbMaterialType
            // 
            this.tbMaterialType.Location = new System.Drawing.Point(126, 86);
            this.tbMaterialType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaterialType.Name = "tbMaterialType";
            this.tbMaterialType.ReadOnly = true;
            this.tbMaterialType.Size = new System.Drawing.Size(193, 22);
            this.tbMaterialType.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(14, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(14, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Department:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(126, 147);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(193, 29);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grdAll
            // 
            this.grdAll.AllowUserToAddRows = false;
            this.grdAll.AllowUserToDeleteRows = false;
            this.grdAll.AutoGenerateColumns = false;
            this.grdAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.codeDataGridViewTextBoxColumn1,
            this.materialTypeDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.timeStampDataGridViewTextBoxColumn1,
            this.userIDDataGridViewTextBoxColumn1,
            this.activeDataGridViewCheckBoxColumn1});
            this.grdAll.DataSource = this.materialDataBindingSource;
            this.grdAll.Location = new System.Drawing.Point(345, 26);
            this.grdAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdAll.Name = "grdAll";
            this.grdAll.ReadOnly = true;
            this.grdAll.RowHeadersVisible = false;
            this.grdAll.RowHeadersWidth = 51;
            this.grdAll.RowTemplate.Height = 29;
            this.grdAll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAll.Size = new System.Drawing.Size(324, 462);
            this.grdAll.TabIndex = 8;
            this.grdAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAll_CellContentClick);
            // 
            // tbMaterialQuantity
            // 
            this.tbMaterialQuantity.Location = new System.Drawing.Point(126, 56);
            this.tbMaterialQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaterialQuantity.Name = "tbMaterialQuantity";
            this.tbMaterialQuantity.Size = new System.Drawing.Size(193, 22);
            this.tbMaterialQuantity.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(14, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity:";
            // 
            // tbMaterialCode
            // 
            this.tbMaterialCode.Location = new System.Drawing.Point(126, 26);
            this.tbMaterialCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaterialCode.Name = "tbMaterialCode";
            this.tbMaterialCode.ReadOnly = true;
            this.tbMaterialCode.Size = new System.Drawing.Size(193, 22);
            this.tbMaterialCode.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(14, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Code:";
            // 
            // dSMaterialData
            // 
            this.dSMaterialData.DataSetName = "DSMaterialData";
            this.dSMaterialData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialDataBindingSource
            // 
            this.materialDataBindingSource.DataMember = "MaterialData";
            this.materialDataBindingSource.DataSource = this.dSMaterialData;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(219, 414);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(208, 29);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            // codeDataGridViewTextBoxColumn1
            // 
            this.codeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn1.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn1.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn1.Name = "codeDataGridViewTextBoxColumn1";
            this.codeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // materialTypeDataGridViewTextBoxColumn1
            // 
            this.materialTypeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.materialTypeDataGridViewTextBoxColumn1.DataPropertyName = "MaterialType";
            this.materialTypeDataGridViewTextBoxColumn1.HeaderText = "MaterialType";
            this.materialTypeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.materialTypeDataGridViewTextBoxColumn1.Name = "materialTypeDataGridViewTextBoxColumn1";
            this.materialTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn1.Visible = false;
            this.descriptionDataGridViewTextBoxColumn1.Width = 125;
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
            // activeDataGridViewCheckBoxColumn1
            // 
            this.activeDataGridViewCheckBoxColumn1.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn1.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.activeDataGridViewCheckBoxColumn1.Name = "activeDataGridViewCheckBoxColumn1";
            this.activeDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn1.Visible = false;
            this.activeDataGridViewCheckBoxColumn1.Width = 125;
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
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // grdSelected
            // 
            this.grdSelected.AllowUserToAddRows = false;
            this.grdSelected.AllowUserToDeleteRows = false;
            this.grdSelected.AutoGenerateColumns = false;
            this.grdSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.MaterialCode,
            this.projectIDDataGridViewTextBoxColumn,
            this.materialIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.materialTypeDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.grdSelected.DataSource = this.projectMaterialsBindingSource2;
            this.grdSelected.Location = new System.Drawing.Point(24, 225);
            this.grdSelected.Name = "grdSelected";
            this.grdSelected.ReadOnly = true;
            this.grdSelected.RowHeadersVisible = false;
            this.grdSelected.RowHeadersWidth = 51;
            this.grdSelected.RowTemplate.Height = 24;
            this.grdSelected.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSelected.Size = new System.Drawing.Size(403, 184);
            this.grdSelected.TabIndex = 17;
            // 
            // projectMaterialsBindingSource2
            // 
            this.projectMaterialsBindingSource2.DataMember = "ProjectMaterials";
            this.projectMaterialsBindingSource2.DataSource = this.dSProjectMaterials1;
            // 
            // dSProjectMaterials1
            // 
            this.dSProjectMaterials1.DataSetName = "DSProjectMaterials";
            this.dSProjectMaterials1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectMaterialsBindingSource
            // 
            this.projectMaterialsBindingSource.DataMember = "ProjectMaterials";
            this.projectMaterialsBindingSource.DataSource = this.dSProjectMaterials1;
            // 
            // projectMaterialsBindingSource1
            // 
            this.projectMaterialsBindingSource1.DataMember = "ProjectMaterials";
            this.projectMaterialsBindingSource1.DataSource = this.dSProjectMaterials1;
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
            // MaterialCode
            // 
            this.MaterialCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialCode.DataPropertyName = "MaterialCode";
            this.MaterialCode.HeaderText = "MaterialCode";
            this.MaterialCode.MinimumWidth = 6;
            this.MaterialCode.Name = "MaterialCode";
            this.MaterialCode.ReadOnly = true;
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
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialIDDataGridViewTextBoxColumn.Visible = false;
            this.materialIDDataGridViewTextBoxColumn.Width = 125;
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
            // materialTypeDataGridViewTextBoxColumn
            // 
            this.materialTypeDataGridViewTextBoxColumn.DataPropertyName = "MaterialType";
            this.materialTypeDataGridViewTextBoxColumn.HeaderText = "MaterialType";
            this.materialTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
            this.materialTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialTypeDataGridViewTextBoxColumn.Visible = false;
            this.materialTypeDataGridViewTextBoxColumn.Width = 125;
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
            // dSProjects1
            // 
            this.dSProjects1.DataSetName = "DSProjects";
            this.dSProjects1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.dSProjects1;
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(165, 31);
            this.tbProjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(262, 22);
            this.tbProjectName.TabIndex = 19;
            // 
            // FrmCreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 530);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbProjectData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCreateProject";
            this.Text = "FrmCreateProject";
            this.Load += new System.EventHandler(this.FrmCreateProject_Load);
            this.gbProjectData.ResumeLayout(false);
            this.gbProjectData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMaterialData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMaterialsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProjectMaterials1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMaterialsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProjects1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbProjectData;
        private Label label3;
        private RichTextBox rtbProjectDescription;
        private TextBox tbProjectCompany;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView grdAll;
        private TextBox tbMaterialQuantity;
        private Label label5;
        private TextBox tbMaterialCode;
        private Label label6;
        private Button btnAdd;
        private Button btnCreate;
        private TextBox tbMaterialType;
        private Label label7;
        private Label label4;
        private BindingSource materialDataBindingSource;
        private ProjectPerun.DataSets.DSMaterialData dSMaterialData;
        private Button btnRemove;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn1;
        private BindingSource projectMaterialsBindingSource;
        private ProjectPerun.DataSets.DSProjectMaterials dSProjectMaterials1;
        private DataGridView grdSelected;
        private BindingSource projectMaterialsBindingSource2;
        private BindingSource projectMaterialsBindingSource1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn MaterialCode;
        private DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private ComboBox cbDepartment;
        private BindingSource projectsBindingSource;
        private ProjectPerun.DataSets.DSProjects dSProjects1;
        private TextBox tbProjectName;
    }
}