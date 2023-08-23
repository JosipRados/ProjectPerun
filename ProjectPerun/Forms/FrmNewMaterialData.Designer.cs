using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmNewMaterialData
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaterialType = new System.Windows.Forms.ComboBox();
            this.tbMaterialCode = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Material Code:";
            // 
            // cbMaterialType
            // 
            this.cbMaterialType.FormattingEnabled = true;
            this.cbMaterialType.Location = new System.Drawing.Point(172, 74);
            this.cbMaterialType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaterialType.Name = "cbMaterialType";
            this.cbMaterialType.Size = new System.Drawing.Size(257, 24);
            this.cbMaterialType.TabIndex = 14;
            // 
            // tbMaterialCode
            // 
            this.tbMaterialCode.Location = new System.Drawing.Point(172, 40);
            this.tbMaterialCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaterialCode.Name = "tbMaterialCode";
            this.tbMaterialCode.Size = new System.Drawing.Size(257, 22);
            this.tbMaterialCode.TabIndex = 10;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(172, 110);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(257, 97);
            this.rtbDescription.TabIndex = 13;
            this.rtbDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Material Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(40, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Description:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(172, 269);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(257, 39);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // FrmNewMaterialData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 360);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMaterialType);
            this.Controls.Add(this.tbMaterialCode);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmNewMaterialData";
            this.Text = "FrmNewMaterialData";
            this.Load += new System.EventHandler(this.FrmNewMaterialData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbMaterialType;
        private TextBox tbMaterialCode;
        private RichTextBox rtbDescription;
        private Label label2;
        private Label label3;
        private Button btnInsert;
    }
}