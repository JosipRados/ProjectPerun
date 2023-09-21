using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmOrderShowMaterials
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
            this.grdOrderStorage = new System.Windows.Forms.DataGridView();
            this.dSOrderStorage1 = new ProjectPerun.DataSets.DSOrderStorage();
            this.dSOrderStorage1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderStorageTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSOrderStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSOrderStorage1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStorageTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOrderStorage
            // 
            this.grdOrderStorage.AllowUserToAddRows = false;
            this.grdOrderStorage.AllowUserToDeleteRows = false;
            this.grdOrderStorage.AutoGenerateColumns = false;
            this.grdOrderStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrderStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.storageIDDataGridViewTextBoxColumn,
            this.storageNumberDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.spentDataGridViewCheckBoxColumn,
            this.timeStampDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.grdOrderStorage.DataSource = this.orderStorageTableBindingSource;
            this.grdOrderStorage.Location = new System.Drawing.Point(26, 18);
            this.grdOrderStorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdOrderStorage.Name = "grdOrderStorage";
            this.grdOrderStorage.ReadOnly = true;
            this.grdOrderStorage.RowHeadersVisible = false;
            this.grdOrderStorage.RowHeadersWidth = 51;
            this.grdOrderStorage.RowTemplate.Height = 29;
            this.grdOrderStorage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdOrderStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrderStorage.Size = new System.Drawing.Size(562, 500);
            this.grdOrderStorage.TabIndex = 28;
            // 
            // dSOrderStorage1
            // 
            this.dSOrderStorage1.DataSetName = "DSOrderStorage";
            this.dSOrderStorage1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSOrderStorage1BindingSource
            // 
            this.dSOrderStorage1BindingSource.DataSource = this.dSOrderStorage1;
            this.dSOrderStorage1BindingSource.Position = 0;
            // 
            // orderStorageTableBindingSource
            // 
            this.orderStorageTableBindingSource.DataMember = "OrderStorageTable";
            this.orderStorageTableBindingSource.DataSource = this.dSOrderStorage1;
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
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // spentDataGridViewCheckBoxColumn
            // 
            this.spentDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.spentDataGridViewCheckBoxColumn.DataPropertyName = "Spent";
            this.spentDataGridViewCheckBoxColumn.HeaderText = "Spent";
            this.spentDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.spentDataGridViewCheckBoxColumn.Name = "spentDataGridViewCheckBoxColumn";
            this.spentDataGridViewCheckBoxColumn.ReadOnly = true;
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
            // FrmOrderShowMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 546);
            this.Controls.Add(this.grdOrderStorage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmOrderShowMaterials";
            this.Text = "FrmOrderShowMaterials";
            this.Load += new System.EventHandler(this.FrmOrderShowMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSOrderStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSOrderStorage1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStorageTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdOrderStorage;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn storageIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn storageNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn spentDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private BindingSource orderStorageTableBindingSource;
        private ProjectPerun.DataSets.DSOrderStorage dSOrderStorage1;
        private BindingSource dSOrderStorage1BindingSource;
    }
}