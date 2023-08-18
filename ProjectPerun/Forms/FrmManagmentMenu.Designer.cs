using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmManagmentMenu
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
            this.btnManageWorkers = new System.Windows.Forms.Button();
            this.btnManageShifts = new System.Windows.Forms.Button();
            this.btnManageOrders = new System.Windows.Forms.Button();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.btnManageProjects = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageMaterials = new System.Windows.Forms.Button();
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
            this.panMenu.Controls.Add(this.btnManageWorkers);
            this.panMenu.Controls.Add(this.btnManageShifts);
            this.panMenu.Controls.Add(this.btnManageOrders);
            this.panMenu.Controls.Add(this.btnCreateProject);
            this.panMenu.Controls.Add(this.btnManageProjects);
            this.panMenu.Controls.Add(this.label1);
            this.panMenu.Controls.Add(this.btnManageMaterials);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMenu.Location = new System.Drawing.Point(1, 1);
            this.panMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(206, 686);
            this.panMenu.TabIndex = 0;
            // 
            // btnManageWorkers
            // 
            this.btnManageWorkers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnManageWorkers.FlatAppearance.BorderSize = 0;
            this.btnManageWorkers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(228)))));
            this.btnManageWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageWorkers.Location = new System.Drawing.Point(0, 285);
            this.btnManageWorkers.Name = "btnManageWorkers";
            this.btnManageWorkers.Size = new System.Drawing.Size(206, 38);
            this.btnManageWorkers.TabIndex = 10;
            this.btnManageWorkers.Text = "MANAGE WORKERS";
            this.btnManageWorkers.UseVisualStyleBackColor = true;
            this.btnManageWorkers.Click += new System.EventHandler(this.btnManageWorkers_Click);
            // 
            // btnManageShifts
            // 
            this.btnManageShifts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnManageShifts.FlatAppearance.BorderSize = 0;
            this.btnManageShifts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(228)))));
            this.btnManageShifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageShifts.Location = new System.Drawing.Point(0, 241);
            this.btnManageShifts.Name = "btnManageShifts";
            this.btnManageShifts.Size = new System.Drawing.Size(206, 38);
            this.btnManageShifts.TabIndex = 9;
            this.btnManageShifts.Text = "MANAGE SHIFTS";
            this.btnManageShifts.UseVisualStyleBackColor = true;
            this.btnManageShifts.Click += new System.EventHandler(this.btnManageShifts_Click);
            // 
            // btnManageOrders
            // 
            this.btnManageOrders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnManageOrders.FlatAppearance.BorderSize = 0;
            this.btnManageOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(228)))));
            this.btnManageOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageOrders.Location = new System.Drawing.Point(0, 197);
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Size = new System.Drawing.Size(206, 38);
            this.btnManageOrders.TabIndex = 8;
            this.btnManageOrders.Text = "MANAGE ORDERS";
            this.btnManageOrders.UseVisualStyleBackColor = true;
            this.btnManageOrders.Click += new System.EventHandler(this.btnManageOrders_Click);
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCreateProject.FlatAppearance.BorderSize = 0;
            this.btnCreateProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(228)))));
            this.btnCreateProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProject.Location = new System.Drawing.Point(0, 153);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(206, 38);
            this.btnCreateProject.TabIndex = 7;
            this.btnCreateProject.Text = "CREATE PROJECT";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // btnManageProjects
            // 
            this.btnManageProjects.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnManageProjects.FlatAppearance.BorderSize = 0;
            this.btnManageProjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(228)))));
            this.btnManageProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProjects.Location = new System.Drawing.Point(0, 109);
            this.btnManageProjects.Name = "btnManageProjects";
            this.btnManageProjects.Size = new System.Drawing.Size(206, 38);
            this.btnManageProjects.TabIndex = 6;
            this.btnManageProjects.Text = "MANAGE PROJECTS";
            this.btnManageProjects.UseVisualStyleBackColor = true;
            this.btnManageProjects.Click += new System.EventHandler(this.btnManageProjects_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "MANAGMENT";
            // 
            // btnManageMaterials
            // 
            this.btnManageMaterials.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnManageMaterials.FlatAppearance.BorderSize = 0;
            this.btnManageMaterials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(228)))));
            this.btnManageMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageMaterials.Location = new System.Drawing.Point(0, 65);
            this.btnManageMaterials.Name = "btnManageMaterials";
            this.btnManageMaterials.Size = new System.Drawing.Size(206, 38);
            this.btnManageMaterials.TabIndex = 5;
            this.btnManageMaterials.Text = "MANAGE MATERIALS";
            this.btnManageMaterials.UseVisualStyleBackColor = true;
            this.btnManageMaterials.Click += new System.EventHandler(this.btnManageMaterials_Click);
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
            // FrmManagmentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 688);
            this.Controls.Add(this.layPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmManagmentMenu";
            this.Text = "FrmManagmentMenu";
            this.Load += new System.EventHandler(this.FrmManagmentMenu_Load);
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
        private Button btnManageMaterials;
        private Button btnManageProjects;
        private Button btnCreateProject;
        private Button btnManageOrders;
        private Button btnManageShifts;
        private Button btnManageWorkers;
    }
}