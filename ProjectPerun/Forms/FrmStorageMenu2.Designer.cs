using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmStorageMenu2
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
            this.layPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.btnImportFromProject = new System.Windows.Forms.Button();
            this.btnExportProject = new System.Windows.Forms.Button();
            this.btnElementData = new System.Windows.Forms.Button();
            this.btnInsertBatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStorage = new System.Windows.Forms.Button();
            this.panForm = new System.Windows.Forms.Panel();
            this.layPanel.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // layPanel
            // 
            this.layPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.layPanel.ColumnCount = 2;
            this.layPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.86487F));
            this.layPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.13513F));
            this.layPanel.Controls.Add(this.panMenu, 0, 0);
            this.layPanel.Controls.Add(this.panForm, 1, 0);
            this.layPanel.Location = new System.Drawing.Point(0, 0);
            this.layPanel.Name = "layPanel";
            this.layPanel.RowCount = 1;
            this.layPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.34303F));
            this.layPanel.Size = new System.Drawing.Size(1395, 688);
            this.layPanel.TabIndex = 1;
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panMenu.Controls.Add(this.btnCheckAvailability);
            this.panMenu.Controls.Add(this.btnImportFromProject);
            this.panMenu.Controls.Add(this.btnExportProject);
            this.panMenu.Controls.Add(this.btnElementData);
            this.panMenu.Controls.Add(this.btnInsertBatch);
            this.panMenu.Controls.Add(this.label1);
            this.panMenu.Controls.Add(this.btnStorage);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMenu.Location = new System.Drawing.Point(1, 1);
            this.panMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(206, 686);
            this.panMenu.TabIndex = 0;
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCheckAvailability.FlatAppearance.BorderSize = 0;
            this.btnCheckAvailability.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(228)))));
            this.btnCheckAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAvailability.Location = new System.Drawing.Point(0, 285);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(206, 38);
            this.btnCheckAvailability.TabIndex = 10;
            this.btnCheckAvailability.Text = "CHECK AVAILABILITY";
            this.btnCheckAvailability.UseVisualStyleBackColor = true;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // btnImportFromProject
            // 
            this.btnImportFromProject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnImportFromProject.FlatAppearance.BorderSize = 0;
            this.btnImportFromProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(228)))));
            this.btnImportFromProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportFromProject.Location = new System.Drawing.Point(0, 241);
            this.btnImportFromProject.Name = "btnImportFromProject";
            this.btnImportFromProject.Size = new System.Drawing.Size(206, 38);
            this.btnImportFromProject.TabIndex = 9;
            this.btnImportFromProject.Text = "IMPORT FROM PROJECT";
            this.btnImportFromProject.UseVisualStyleBackColor = true;
            this.btnImportFromProject.Click += new System.EventHandler(this.btnImportFromProject_Click);
            // 
            // btnExportProject
            // 
            this.btnExportProject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportProject.FlatAppearance.BorderSize = 0;
            this.btnExportProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(228)))));
            this.btnExportProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportProject.Location = new System.Drawing.Point(-1, 197);
            this.btnExportProject.Name = "btnExportProject";
            this.btnExportProject.Size = new System.Drawing.Size(210, 38);
            this.btnExportProject.TabIndex = 8;
            this.btnExportProject.Text = "EXPORT TO PROJECT";
            this.btnExportProject.UseVisualStyleBackColor = true;
            this.btnExportProject.Click += new System.EventHandler(this.btnExportProject_Click);
            // 
            // btnElementData
            // 
            this.btnElementData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnElementData.FlatAppearance.BorderSize = 0;
            this.btnElementData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(228)))));
            this.btnElementData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElementData.Location = new System.Drawing.Point(0, 153);
            this.btnElementData.Name = "btnElementData";
            this.btnElementData.Size = new System.Drawing.Size(209, 38);
            this.btnElementData.TabIndex = 7;
            this.btnElementData.Text = "ELEMENT DATA";
            this.btnElementData.UseVisualStyleBackColor = true;
            this.btnElementData.Click += new System.EventHandler(this.btnElementData_Click);
            // 
            // btnInsertBatch
            // 
            this.btnInsertBatch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInsertBatch.FlatAppearance.BorderSize = 0;
            this.btnInsertBatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(228)))));
            this.btnInsertBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertBatch.Location = new System.Drawing.Point(0, 109);
            this.btnInsertBatch.Name = "btnInsertBatch";
            this.btnInsertBatch.Size = new System.Drawing.Size(209, 38);
            this.btnInsertBatch.TabIndex = 6;
            this.btnInsertBatch.Text = "INSERT BATCH";
            this.btnInsertBatch.UseVisualStyleBackColor = true;
            this.btnInsertBatch.Click += new System.EventHandler(this.btnInsertBatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "STORAGE MENU";
            // 
            // btnStorage
            // 
            this.btnStorage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnStorage.FlatAppearance.BorderSize = 0;
            this.btnStorage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(228)))));
            this.btnStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorage.Location = new System.Drawing.Point(0, 65);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(209, 38);
            this.btnStorage.TabIndex = 5;
            this.btnStorage.Text = "STORAGE";
            this.btnStorage.UseVisualStyleBackColor = true;
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // panForm
            // 
            this.panForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panForm.Location = new System.Drawing.Point(208, 1);
            this.panForm.Margin = new System.Windows.Forms.Padding(0);
            this.panForm.Name = "panForm";
            this.panForm.Size = new System.Drawing.Size(1186, 686);
            this.panForm.TabIndex = 1;
            // 
            // FrmStorageMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 688);
            this.Controls.Add(this.layPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmStorageMenu2";
            this.Text = "FrmStorageMenu2";
            this.Load += new System.EventHandler(this.FrmStorageMenu2_Load);
            this.layPanel.ResumeLayout(false);
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel layPanel;
        private Panel panMenu;
        private Panel panForm;
        private Label label1;
        private Button btnStorage;
        private Button btnInsertBatch;
        private Button btnElementData;
        private Button btnExportProject;
        private Button btnImportFromProject;
        private Button btnCheckAvailability;
    }
}