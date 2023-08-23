using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmManageProjectData
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
            this.grdProjects = new System.Windows.Forms.DataGridView();
            this.btnRemoveProject = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbProjectDescription = new System.Windows.Forms.RichTextBox();
            this.tbProjectCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProjectMaterial = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemoveMaterial = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaterialQuantity = new System.Windows.Forms.TextBox();
            this.grdMaterials = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaterialCode = new System.Windows.Forms.TextBox();
            this.btnLoadMaterials = new System.Windows.Forms.Button();
            this.dSProjects = new ProjectPerun.DataSets.DSProjects();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectMaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSProjectMaterials1 = new ProjectPerun.DataSets.DSProjectMaterials();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.btnUpdateMaterial = new System.Windows.Forms.Button();
            this.tbType = new System.Windows.Forms.TextBox();
            this.gbProjectData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjects)).BeginInit();
            this.gbProjectMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProjectMaterials1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProjectData
            // 
            this.gbProjectData.Controls.Add(this.btnLoadMaterials);
            this.gbProjectData.Controls.Add(this.grdProjects);
            this.gbProjectData.Controls.Add(this.btnRemoveProject);
            this.gbProjectData.Controls.Add(this.btnUpdate);
            this.gbProjectData.Controls.Add(this.label3);
            this.gbProjectData.Controls.Add(this.rtbProjectDescription);
            this.gbProjectData.Controls.Add(this.tbProjectCompany);
            this.gbProjectData.Controls.Add(this.label2);
            this.gbProjectData.Controls.Add(this.tbProjectName);
            this.gbProjectData.Controls.Add(this.label1);
            this.gbProjectData.Location = new System.Drawing.Point(12, 10);
            this.gbProjectData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProjectData.Name = "gbProjectData";
            this.gbProjectData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProjectData.Size = new System.Drawing.Size(392, 511);
            this.gbProjectData.TabIndex = 0;
            this.gbProjectData.TabStop = false;
            this.gbProjectData.Text = "Project Data";
            // 
            // grdProjects
            // 
            this.grdProjects.AllowUserToAddRows = false;
            this.grdProjects.AllowUserToDeleteRows = false;
            this.grdProjects.AutoGenerateColumns = false;
            this.grdProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.grdProjects.DataSource = this.projectsBindingSource;
            this.grdProjects.Location = new System.Drawing.Point(16, 214);
            this.grdProjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdProjects.Name = "grdProjects";
            this.grdProjects.ReadOnly = true;
            this.grdProjects.RowHeadersVisible = false;
            this.grdProjects.RowHeadersWidth = 51;
            this.grdProjects.RowTemplate.Height = 29;
            this.grdProjects.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProjects.Size = new System.Drawing.Size(344, 150);
            this.grdProjects.TabIndex = 1;
            this.grdProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProjects_CellContentClick);
            // 
            // btnRemoveProject
            // 
            this.btnRemoveProject.Location = new System.Drawing.Point(16, 393);
            this.btnRemoveProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveProject.Name = "btnRemoveProject";
            this.btnRemoveProject.Size = new System.Drawing.Size(125, 42);
            this.btnRemoveProject.TabIndex = 9;
            this.btnRemoveProject.Text = "REMOVE";
            this.btnRemoveProject.UseVisualStyleBackColor = true;
            this.btnRemoveProject.Click += new System.EventHandler(this.btnRemoveProject_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(235, 393);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 42);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.rtbProjectDescription.Location = new System.Drawing.Point(140, 87);
            this.rtbProjectDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbProjectDescription.Name = "rtbProjectDescription";
            this.rtbProjectDescription.Size = new System.Drawing.Size(220, 105);
            this.rtbProjectDescription.TabIndex = 6;
            this.rtbProjectDescription.Text = "";
            // 
            // tbProjectCompany
            // 
            this.tbProjectCompany.Location = new System.Drawing.Point(140, 56);
            this.tbProjectCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProjectCompany.Name = "tbProjectCompany";
            this.tbProjectCompany.Size = new System.Drawing.Size(220, 22);
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
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(140, 26);
            this.tbProjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(220, 22);
            this.tbProjectName.TabIndex = 2;
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
            // gbProjectMaterial
            // 
            this.gbProjectMaterial.Controls.Add(this.tbType);
            this.gbProjectMaterial.Controls.Add(this.btnUpdateMaterial);
            this.gbProjectMaterial.Controls.Add(this.cbDepartment);
            this.gbProjectMaterial.Controls.Add(this.label8);
            this.gbProjectMaterial.Controls.Add(this.btnRemoveMaterial);
            this.gbProjectMaterial.Controls.Add(this.btnAdd);
            this.gbProjectMaterial.Controls.Add(this.label7);
            this.gbProjectMaterial.Controls.Add(this.tbMaterialQuantity);
            this.gbProjectMaterial.Controls.Add(this.grdMaterials);
            this.gbProjectMaterial.Controls.Add(this.label6);
            this.gbProjectMaterial.Controls.Add(this.label5);
            this.gbProjectMaterial.Controls.Add(this.tbMaterialCode);
            this.gbProjectMaterial.Location = new System.Drawing.Point(426, 10);
            this.gbProjectMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProjectMaterial.Name = "gbProjectMaterial";
            this.gbProjectMaterial.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProjectMaterial.Size = new System.Drawing.Size(744, 511);
            this.gbProjectMaterial.TabIndex = 1;
            this.gbProjectMaterial.TabStop = false;
            this.gbProjectMaterial.Text = "Project Material";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label8.Location = new System.Drawing.Point(354, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Department:";
            // 
            // btnRemoveMaterial
            // 
            this.btnRemoveMaterial.Location = new System.Drawing.Point(495, 283);
            this.btnRemoveMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveMaterial.Name = "btnRemoveMaterial";
            this.btnRemoveMaterial.Size = new System.Drawing.Size(220, 42);
            this.btnRemoveMaterial.TabIndex = 18;
            this.btnRemoveMaterial.Text = "REMOVE";
            this.btnRemoveMaterial.UseVisualStyleBackColor = true;
            this.btnRemoveMaterial.Click += new System.EventHandler(this.btnRemoveMaterial_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(495, 232);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(220, 42);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(354, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quantity:";
            // 
            // tbMaterialQuantity
            // 
            this.tbMaterialQuantity.Location = new System.Drawing.Point(495, 52);
            this.tbMaterialQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaterialQuantity.Name = "tbMaterialQuantity";
            this.tbMaterialQuantity.Size = new System.Drawing.Size(220, 22);
            this.tbMaterialQuantity.TabIndex = 16;
            // 
            // grdMaterials
            // 
            this.grdMaterials.AllowUserToAddRows = false;
            this.grdMaterials.AllowUserToDeleteRows = false;
            this.grdMaterials.AutoGenerateColumns = false;
            this.grdMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.projectIDDataGridViewTextBoxColumn,
            this.materialIDDataGridViewTextBoxColumn,
            this.materialCodeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.materialTypeDataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn1,
            this.userIDDataGridViewTextBoxColumn1});
            this.grdMaterials.DataSource = this.projectMaterialsBindingSource;
            this.grdMaterials.Location = new System.Drawing.Point(29, 29);
            this.grdMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdMaterials.Name = "grdMaterials";
            this.grdMaterials.ReadOnly = true;
            this.grdMaterials.RowHeadersVisible = false;
            this.grdMaterials.RowHeadersWidth = 51;
            this.grdMaterials.RowTemplate.Height = 29;
            this.grdMaterials.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMaterials.Size = new System.Drawing.Size(310, 464);
            this.grdMaterials.TabIndex = 10;
            this.grdMaterials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMaterials_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(354, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Material Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(354, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Type:";
            // 
            // tbMaterialCode
            // 
            this.tbMaterialCode.Location = new System.Drawing.Point(495, 26);
            this.tbMaterialCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaterialCode.Name = "tbMaterialCode";
            this.tbMaterialCode.ReadOnly = true;
            this.tbMaterialCode.Size = new System.Drawing.Size(220, 22);
            this.tbMaterialCode.TabIndex = 10;
            // 
            // btnLoadMaterials
            // 
            this.btnLoadMaterials.Location = new System.Drawing.Point(16, 439);
            this.btnLoadMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadMaterials.Name = "btnLoadMaterials";
            this.btnLoadMaterials.Size = new System.Drawing.Size(344, 42);
            this.btnLoadMaterials.TabIndex = 10;
            this.btnLoadMaterials.Text = "LOAD PROJECT MATERIALS";
            this.btnLoadMaterials.UseVisualStyleBackColor = true;
            this.btnLoadMaterials.Click += new System.EventHandler(this.btnLoadMaterials_Click);
            // 
            // dSProjects
            // 
            this.dSProjects.DataSetName = "DSProjects";
            this.dSProjects.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.dSProjects;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
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
            // materialCodeDataGridViewTextBoxColumn
            // 
            this.materialCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.materialCodeDataGridViewTextBoxColumn.DataPropertyName = "MaterialCode";
            this.materialCodeDataGridViewTextBoxColumn.HeaderText = "MaterialCode";
            this.materialCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.materialCodeDataGridViewTextBoxColumn.Name = "materialCodeDataGridViewTextBoxColumn";
            this.materialCodeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
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
            // projectMaterialsBindingSource
            // 
            this.projectMaterialsBindingSource.DataMember = "ProjectMaterials";
            this.projectMaterialsBindingSource.DataSource = this.dSProjectMaterials1;
            // 
            // dSProjectMaterials1
            // 
            this.dSProjectMaterials1.DataSetName = "DSProjectMaterials";
            this.dSProjectMaterials1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(495, 109);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(220, 24);
            this.cbDepartment.TabIndex = 22;
            // 
            // btnUpdateMaterial
            // 
            this.btnUpdateMaterial.Location = new System.Drawing.Point(495, 181);
            this.btnUpdateMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateMaterial.Name = "btnUpdateMaterial";
            this.btnUpdateMaterial.Size = new System.Drawing.Size(220, 42);
            this.btnUpdateMaterial.TabIndex = 23;
            this.btnUpdateMaterial.Text = "UPDATE";
            this.btnUpdateMaterial.UseVisualStyleBackColor = true;
            this.btnUpdateMaterial.Click += new System.EventHandler(this.btnUpdateMaterial_Click);
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(495, 78);
            this.tbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(220, 22);
            this.tbType.TabIndex = 24;
            // 
            // FrmManageProjectData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 530);
            this.Controls.Add(this.gbProjectMaterial);
            this.Controls.Add(this.gbProjectData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmManageProjectData";
            this.Text = "ManageProjectData";
            this.Load += new System.EventHandler(this.FrmManageProjectData_Load);
            this.gbProjectData.ResumeLayout(false);
            this.gbProjectData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjects)).EndInit();
            this.gbProjectMaterial.ResumeLayout(false);
            this.gbProjectMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProjectMaterials1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbProjectData;
        private Button btnRemoveProject;
        private Button btnUpdate;
        private Label label3;
        private RichTextBox rtbProjectDescription;
        private TextBox tbProjectCompany;
        private Label label2;
        private TextBox tbProjectName;
        private Label label1;
        private DataGridView grdProjects;
        private GroupBox gbProjectMaterial;
        private DataGridView grdMaterials;
        private Label label6;
        private Label label5;
        private TextBox tbMaterialCode;
        private Button btnRemoveMaterial;
        private Button btnAdd;
        private Label label7;
        private TextBox tbMaterialQuantity;
        private Label label8;
        private Button btnLoadMaterials;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private BindingSource projectsBindingSource;
        private ProjectPerun.DataSets.DSProjects dSProjects;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn1;
        private BindingSource projectMaterialsBindingSource;
        private ProjectPerun.DataSets.DSProjectMaterials dSProjectMaterials1;
        private ComboBox cbDepartment;
        private Button btnUpdateMaterial;
        private TextBox tbType;
    }
}