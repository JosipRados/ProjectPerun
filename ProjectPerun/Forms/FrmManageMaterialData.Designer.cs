using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmManageMaterialData
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaterialCode = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.grdMaterials = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.materialDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMaterialData1 = new ProjectPerun.DataSets.DSMaterialData();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.cbMaterialType = new System.Windows.Forms.ComboBox();
            this.gbElementData = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dSMaterialData1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMaterialData1)).BeginInit();
            this.gbElementData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSMaterialData1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material Code:";
            // 
            // tbMaterialCode
            // 
            this.tbMaterialCode.Location = new System.Drawing.Point(162, 26);
            this.tbMaterialCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaterialCode.Name = "tbMaterialCode";
            this.tbMaterialCode.Size = new System.Drawing.Size(209, 22);
            this.tbMaterialCode.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(29, 229);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(128, 39);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // grdMaterials
            // 
            this.grdMaterials.AllowUserToAddRows = false;
            this.grdMaterials.AllowUserToDeleteRows = false;
            this.grdMaterials.AutoGenerateColumns = false;
            this.grdMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.materialTypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.grdMaterials.DataSource = this.materialDataBindingSource;
            this.grdMaterials.Location = new System.Drawing.Point(510, 37);
            this.grdMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdMaterials.Name = "grdMaterials";
            this.grdMaterials.ReadOnly = true;
            this.grdMaterials.RowHeadersVisible = false;
            this.grdMaterials.RowHeadersWidth = 51;
            this.grdMaterials.RowTemplate.Height = 29;
            this.grdMaterials.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMaterials.Size = new System.Drawing.Size(606, 454);
            this.grdMaterials.TabIndex = 3;
            this.grdMaterials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMaterials_CellContentDoubleClick);
            this.grdMaterials.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMaterials_CellContentDoubleClick);
            this.grdMaterials.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMaterials_CellContentDoubleClick);
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
            this.timeStampDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
            this.timeStampDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.materialDataBindingSource.DataSource = this.dSMaterialData1;
            // 
            // dSMaterialData1
            // 
            this.dSMaterialData1.DataSetName = "DSMaterialData";
            this.dSMaterialData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Material Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description:";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(162, 96);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(209, 97);
            this.rtbDescription.TabIndex = 6;
            this.rtbDescription.Text = "";
            // 
            // cbMaterialType
            // 
            this.cbMaterialType.FormattingEnabled = true;
            this.cbMaterialType.Location = new System.Drawing.Point(162, 61);
            this.cbMaterialType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaterialType.Name = "cbMaterialType";
            this.cbMaterialType.Size = new System.Drawing.Size(209, 24);
            this.cbMaterialType.TabIndex = 8;
            // 
            // gbElementData
            // 
            this.gbElementData.Controls.Add(this.btnRemove);
            this.gbElementData.Controls.Add(this.btnUpdate);
            this.gbElementData.Controls.Add(this.label1);
            this.gbElementData.Controls.Add(this.cbMaterialType);
            this.gbElementData.Controls.Add(this.btnNew);
            this.gbElementData.Controls.Add(this.tbMaterialCode);
            this.gbElementData.Controls.Add(this.rtbDescription);
            this.gbElementData.Controls.Add(this.label2);
            this.gbElementData.Controls.Add(this.label3);
            this.gbElementData.Location = new System.Drawing.Point(42, 37);
            this.gbElementData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbElementData.Name = "gbElementData";
            this.gbElementData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbElementData.Size = new System.Drawing.Size(401, 350);
            this.gbElementData.TabIndex = 9;
            this.gbElementData.TabStop = false;
            this.gbElementData.Text = "Element Data";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(224, 288);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(147, 39);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(224, 229);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 39);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dSMaterialData1BindingSource
            // 
            this.dSMaterialData1BindingSource.DataSource = this.dSMaterialData1;
            this.dSMaterialData1BindingSource.Position = 0;
            // 
            // FrmManageMaterialData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 530);
            this.Controls.Add(this.gbElementData);
            this.Controls.Add(this.grdMaterials);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmManageMaterialData";
            this.Text = "FrmElementData";
            this.Load += new System.EventHandler(this.FrmManageMaterialData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMaterialData1)).EndInit();
            this.gbElementData.ResumeLayout(false);
            this.gbElementData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSMaterialData1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox tbMaterialCode;
        private Button btnNew;
        private DataGridView grdMaterials;
        private Label label2;
        private Label label3;
        private RichTextBox rtbDescription;
        private ComboBox cbMaterialType;
        private GroupBox gbElementData;
        private Button btnUpdate;
        private Button btnRemove;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private BindingSource materialDataBindingSource;
        private ProjectPerun.DataSets.DSMaterialData dSMaterialData1;
        private BindingSource dSMaterialData1BindingSource;
    }
}