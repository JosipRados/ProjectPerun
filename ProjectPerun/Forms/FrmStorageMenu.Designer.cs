using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmStorageMenu
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
            this.scMenuForm = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStorage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scMenuForm)).BeginInit();
            this.scMenuForm.Panel1.SuspendLayout();
            this.scMenuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMenuForm
            // 
            this.scMenuForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMenuForm.Location = new System.Drawing.Point(0, 0);
            this.scMenuForm.Name = "scMenuForm";
            // 
            // scMenuForm.Panel1
            // 
            this.scMenuForm.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.scMenuForm.Panel1.Controls.Add(this.label1);
            this.scMenuForm.Panel1.Controls.Add(this.button3);
            this.scMenuForm.Panel1.Controls.Add(this.button2);
            this.scMenuForm.Panel1.Controls.Add(this.btnStorage);
            this.scMenuForm.Size = new System.Drawing.Size(1374, 709);
            this.scMenuForm.SplitterDistance = 300;
            this.scMenuForm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "STORAGE MENU";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(292, 61);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnStorage
            // 
            this.btnStorage.Location = new System.Drawing.Point(3, 81);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(292, 61);
            this.btnStorage.TabIndex = 1;
            this.btnStorage.Text = "STORAGE";
            this.btnStorage.UseVisualStyleBackColor = true;
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // FrmStorageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 709);
            this.Controls.Add(this.scMenuForm);
            this.Name = "FrmStorageMenu";
            this.Text = "FrmStorageMenu";
            this.scMenuForm.Panel1.ResumeLayout(false);
            this.scMenuForm.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMenuForm)).EndInit();
            this.scMenuForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer scMenuForm;
        private Button button3;
        private Button button2;
        private Button btnStorage;
        private Label label1;
    }
}