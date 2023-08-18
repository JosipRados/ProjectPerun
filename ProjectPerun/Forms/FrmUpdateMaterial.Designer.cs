using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmUpdateMaterial
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMaterial = new System.Windows.Forms.RadioButton();
            this.rbElement = new System.Windows.Forms.RadioButton();
            this.tbProject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbOnProject = new System.Windows.Forms.RadioButton();
            this.rbReserved = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbWarehouse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCode = new System.Windows.Forms.ComboBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATE MATERIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(18, 70);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(264, 22);
            this.tbName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(17, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Code:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(16, 237);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(264, 22);
            this.tbQuantity.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(16, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(16, 291);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(264, 22);
            this.tbPrice.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(16, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMaterial);
            this.groupBox1.Controls.Add(this.rbElement);
            this.groupBox1.Location = new System.Drawing.Point(328, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(173, 75);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type:";
            // 
            // rbMaterial
            // 
            this.rbMaterial.AutoSize = true;
            this.rbMaterial.Enabled = false;
            this.rbMaterial.Location = new System.Drawing.Point(6, 45);
            this.rbMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMaterial.Name = "rbMaterial";
            this.rbMaterial.Size = new System.Drawing.Size(76, 20);
            this.rbMaterial.TabIndex = 1;
            this.rbMaterial.TabStop = true;
            this.rbMaterial.Text = "Material";
            this.rbMaterial.UseVisualStyleBackColor = true;
            // 
            // rbElement
            // 
            this.rbElement.AutoSize = true;
            this.rbElement.Enabled = false;
            this.rbElement.Location = new System.Drawing.Point(6, 21);
            this.rbElement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbElement.Name = "rbElement";
            this.rbElement.Size = new System.Drawing.Size(77, 20);
            this.rbElement.TabIndex = 0;
            this.rbElement.TabStop = true;
            this.rbElement.Text = "Element";
            this.rbElement.UseVisualStyleBackColor = true;
            // 
            // tbProject
            // 
            this.tbProject.Location = new System.Drawing.Point(16, 345);
            this.tbProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProject.Name = "tbProject";
            this.tbProject.ReadOnly = true;
            this.tbProject.Size = new System.Drawing.Size(264, 22);
            this.tbProject.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(16, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Project:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNone);
            this.groupBox2.Controls.Add(this.rbOnProject);
            this.groupBox2.Controls.Add(this.rbReserved);
            this.groupBox2.Location = new System.Drawing.Point(328, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(173, 99);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "State:";
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Enabled = false;
            this.rbNone.Location = new System.Drawing.Point(6, 69);
            this.rbNone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(61, 20);
            this.rbNone.TabIndex = 2;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // rbOnProject
            // 
            this.rbOnProject.AutoSize = true;
            this.rbOnProject.Enabled = false;
            this.rbOnProject.Location = new System.Drawing.Point(6, 45);
            this.rbOnProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbOnProject.Name = "rbOnProject";
            this.rbOnProject.Size = new System.Drawing.Size(90, 20);
            this.rbOnProject.TabIndex = 1;
            this.rbOnProject.TabStop = true;
            this.rbOnProject.Text = "On Project";
            this.rbOnProject.UseVisualStyleBackColor = true;
            // 
            // rbReserved
            // 
            this.rbReserved.AutoSize = true;
            this.rbReserved.Enabled = false;
            this.rbReserved.Location = new System.Drawing.Point(6, 21);
            this.rbReserved.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbReserved.Name = "rbReserved";
            this.rbReserved.Size = new System.Drawing.Size(88, 20);
            this.rbReserved.TabIndex = 0;
            this.rbReserved.TabStop = true;
            this.rbReserved.Text = "Reserved";
            this.rbReserved.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(17, 475);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(479, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SAVE CHANGES";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbWarehouse
            // 
            this.tbWarehouse.Location = new System.Drawing.Point(14, 399);
            this.tbWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWarehouse.Name = "tbWarehouse";
            this.tbWarehouse.Size = new System.Drawing.Size(264, 22);
            this.tbWarehouse.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(11, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Warehouse:";
            // 
            // cbCode
            // 
            this.cbCode.FormattingEnabled = true;
            this.cbCode.Location = new System.Drawing.Point(17, 180);
            this.cbCode.Name = "cbCode";
            this.cbCode.Size = new System.Drawing.Size(264, 24);
            this.cbCode.TabIndex = 15;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(17, 124);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.ReadOnly = true;
            this.tbNumber.Size = new System.Drawing.Size(264, 22);
            this.tbNumber.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label8.Location = new System.Drawing.Point(17, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Number:";
            // 
            // FrmUpdateMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 557);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbCode);
            this.Controls.Add(this.tbWarehouse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbProject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUpdateMaterial";
            this.Text = "FrmUpdateMaterial";
            this.Load += new System.EventHandler(this.FrmUpdateMaterial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private Label label3;
        private TextBox tbQuantity;
        private Label label4;
        private TextBox tbPrice;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton rbMaterial;
        private RadioButton rbElement;
        private TextBox tbProject;
        private Label label7;
        private GroupBox groupBox2;
        private RadioButton rbNone;
        private RadioButton rbOnProject;
        private RadioButton rbReserved;
        private Button btnSave;
        private TextBox tbWarehouse;
        private Label label6;
        private ComboBox cbCode;
        private TextBox tbNumber;
        private Label label8;
    }
}