using System.Windows.Forms;

namespace ProjectPerunDesktop.Forms
{
    partial class FrmMainMenu
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
            this.lbMainMenu = new System.Windows.Forms.Label();
            this.btnStorage = new System.Windows.Forms.Button();
            this.btnProduction = new System.Windows.Forms.Button();
            this.btnManagment = new System.Windows.Forms.Button();
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMainMenu
            // 
            this.lbMainMenu.AutoSize = true;
            this.lbMainMenu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMainMenu.Location = new System.Drawing.Point(287, 23);
            this.lbMainMenu.Name = "lbMainMenu";
            this.lbMainMenu.Size = new System.Drawing.Size(227, 46);
            this.lbMainMenu.TabIndex = 0;
            this.lbMainMenu.Text = "MAIN MENU";
            // 
            // btnStorage
            // 
            this.btnStorage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStorage.Location = new System.Drawing.Point(47, 102);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(306, 99);
            this.btnStorage.TabIndex = 1;
            this.btnStorage.Text = "STORAGE";
            this.btnStorage.UseVisualStyleBackColor = true;
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // btnProduction
            // 
            this.btnProduction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProduction.Location = new System.Drawing.Point(433, 102);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(306, 99);
            this.btnProduction.TabIndex = 2;
            this.btnProduction.Text = "PRODUCTION";
            this.btnProduction.UseVisualStyleBackColor = true;
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click);
            // 
            // btnManagment
            // 
            this.btnManagment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManagment.Location = new System.Drawing.Point(47, 232);
            this.btnManagment.Name = "btnManagment";
            this.btnManagment.Size = new System.Drawing.Size(306, 99);
            this.btnManagment.TabIndex = 4;
            this.btnManagment.Text = "MANAGMENT";
            this.btnManagment.UseVisualStyleBackColor = true;
            this.btnManagment.Click += new System.EventHandler(this.btnManagment_Click);
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfiguration.Location = new System.Drawing.Point(433, 232);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(306, 99);
            this.btnConfiguration.TabIndex = 5;
            this.btnConfiguration.Text = "CONFIGURATION";
            this.btnConfiguration.UseVisualStyleBackColor = true;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.btnConfiguration);
            this.Controls.Add(this.btnManagment);
            this.Controls.Add(this.btnProduction);
            this.Controls.Add(this.btnStorage);
            this.Controls.Add(this.lbMainMenu);
            this.Name = "FrmMainMenu";
            this.Text = "FrmMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbMainMenu;
        private Button btnStorage;
        private Button btnProduction;
        private Button btnManagment;
        private Button btnConfiguration;
    }
}