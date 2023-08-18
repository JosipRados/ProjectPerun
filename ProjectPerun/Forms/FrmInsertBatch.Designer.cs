using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmInsertBatch
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
            this.grdImport = new System.Windows.Forms.DataGridView();
            this.gbBatchInformation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWerehouse = new System.Windows.Forms.ComboBox();
            this.rbNewBatch = new System.Windows.Forms.RadioButton();
            this.rbExistingBatch = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBatch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSender = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.brnGetData = new System.Windows.Forms.Button();
            this.gbMaterialInformation = new System.Windows.Forms.GroupBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbElement = new System.Windows.Forms.RadioButton();
            this.rbMaterial = new System.Windows.Forms.RadioButton();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdImport)).BeginInit();
            this.gbBatchInformation.SuspendLayout();
            this.gbMaterialInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdImport
            // 
            this.grdImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdImport.Location = new System.Drawing.Point(598, 28);
            this.grdImport.Name = "grdImport";
            this.grdImport.RowHeadersWidth = 51;
            this.grdImport.RowTemplate.Height = 29;
            this.grdImport.Size = new System.Drawing.Size(551, 510);
            this.grdImport.TabIndex = 0;
            // 
            // gbBatchInformation
            // 
            this.gbBatchInformation.Controls.Add(this.brnGetData);
            this.gbBatchInformation.Controls.Add(this.tbDate);
            this.gbBatchInformation.Controls.Add(this.label4);
            this.gbBatchInformation.Controls.Add(this.tbSender);
            this.gbBatchInformation.Controls.Add(this.label3);
            this.gbBatchInformation.Controls.Add(this.tbBatch);
            this.gbBatchInformation.Controls.Add(this.label2);
            this.gbBatchInformation.Controls.Add(this.rbExistingBatch);
            this.gbBatchInformation.Controls.Add(this.rbNewBatch);
            this.gbBatchInformation.Controls.Add(this.cbWerehouse);
            this.gbBatchInformation.Controls.Add(this.label1);
            this.gbBatchInformation.Location = new System.Drawing.Point(12, 12);
            this.gbBatchInformation.Name = "gbBatchInformation";
            this.gbBatchInformation.Size = new System.Drawing.Size(546, 185);
            this.gbBatchInformation.TabIndex = 1;
            this.gbBatchInformation.TabStop = false;
            this.gbBatchInformation.Text = "Batch Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warehouse:";
            // 
            // cbWerehouse
            // 
            this.cbWerehouse.FormattingEnabled = true;
            this.cbWerehouse.Location = new System.Drawing.Point(111, 33);
            this.cbWerehouse.Name = "cbWerehouse";
            this.cbWerehouse.Size = new System.Drawing.Size(167, 28);
            this.cbWerehouse.TabIndex = 1;
            // 
            // rbNewBatch
            // 
            this.rbNewBatch.AutoSize = true;
            this.rbNewBatch.Location = new System.Drawing.Point(326, 36);
            this.rbNewBatch.Name = "rbNewBatch";
            this.rbNewBatch.Size = new System.Drawing.Size(101, 24);
            this.rbNewBatch.TabIndex = 2;
            this.rbNewBatch.TabStop = true;
            this.rbNewBatch.Text = "New Batch";
            this.rbNewBatch.UseVisualStyleBackColor = true;
            // 
            // rbExistingBatch
            // 
            this.rbExistingBatch.AutoSize = true;
            this.rbExistingBatch.Location = new System.Drawing.Point(326, 66);
            this.rbExistingBatch.Name = "rbExistingBatch";
            this.rbExistingBatch.Size = new System.Drawing.Size(122, 24);
            this.rbExistingBatch.TabIndex = 3;
            this.rbExistingBatch.TabStop = true;
            this.rbExistingBatch.Text = "Existing Batch";
            this.rbExistingBatch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Batch No:";
            // 
            // tbBatch
            // 
            this.tbBatch.Location = new System.Drawing.Point(111, 76);
            this.tbBatch.Name = "tbBatch";
            this.tbBatch.Size = new System.Drawing.Size(167, 27);
            this.tbBatch.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sender:";
            // 
            // tbSender
            // 
            this.tbSender.Location = new System.Drawing.Point(111, 109);
            this.tbSender.Name = "tbSender";
            this.tbSender.Size = new System.Drawing.Size(167, 27);
            this.tbSender.TabIndex = 7;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(111, 142);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(167, 27);
            this.tbDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date:";
            // 
            // brnGetData
            // 
            this.brnGetData.Location = new System.Drawing.Point(326, 125);
            this.brnGetData.Name = "brnGetData";
            this.brnGetData.Size = new System.Drawing.Size(122, 44);
            this.brnGetData.TabIndex = 10;
            this.brnGetData.Text = "GET DATA";
            this.brnGetData.UseVisualStyleBackColor = true;
            this.brnGetData.Click += new System.EventHandler(this.brnGetData_Click);
            // 
            // gbMaterialInformation
            // 
            this.gbMaterialInformation.Controls.Add(this.btnAdd);
            this.gbMaterialInformation.Controls.Add(this.dataGridView1);
            this.gbMaterialInformation.Controls.Add(this.tbName);
            this.gbMaterialInformation.Controls.Add(this.label9);
            this.gbMaterialInformation.Controls.Add(this.rbMaterial);
            this.gbMaterialInformation.Controls.Add(this.rbElement);
            this.gbMaterialInformation.Controls.Add(this.tbPrice);
            this.gbMaterialInformation.Controls.Add(this.label8);
            this.gbMaterialInformation.Controls.Add(this.tbQuantity);
            this.gbMaterialInformation.Controls.Add(this.label5);
            this.gbMaterialInformation.Controls.Add(this.tbCode);
            this.gbMaterialInformation.Controls.Add(this.label6);
            this.gbMaterialInformation.Controls.Add(this.tbNumber);
            this.gbMaterialInformation.Controls.Add(this.label7);
            this.gbMaterialInformation.Location = new System.Drawing.Point(12, 224);
            this.gbMaterialInformation.Name = "gbMaterialInformation";
            this.gbMaterialInformation.Size = new System.Drawing.Size(546, 414);
            this.gbMaterialInformation.TabIndex = 2;
            this.gbMaterialInformation.TabStop = false;
            this.gbMaterialInformation.Text = "Material Information";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(111, 135);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(167, 27);
            this.tbQuantity.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantity:";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(111, 102);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(167, 27);
            this.tbCode.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Code:";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(111, 36);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(167, 27);
            this.tbNumber.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Number:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(111, 168);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(167, 27);
            this.tbPrice.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Price:";
            // 
            // rbElement
            // 
            this.rbElement.AutoSize = true;
            this.rbElement.Location = new System.Drawing.Point(21, 232);
            this.rbElement.Name = "rbElement";
            this.rbElement.Size = new System.Drawing.Size(84, 24);
            this.rbElement.TabIndex = 18;
            this.rbElement.TabStop = true;
            this.rbElement.Text = "Element";
            this.rbElement.UseVisualStyleBackColor = true;
            // 
            // rbMaterial
            // 
            this.rbMaterial.AutoSize = true;
            this.rbMaterial.Location = new System.Drawing.Point(139, 232);
            this.rbMaterial.Name = "rbMaterial";
            this.rbMaterial.Size = new System.Drawing.Size(85, 24);
            this.rbMaterial.TabIndex = 11;
            this.rbMaterial.TabStop = true;
            this.rbMaterial.Text = "Material";
            this.rbMaterial.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(111, 69);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(167, 27);
            this.tbName.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(299, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(189, 327);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 319);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(272, 44);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(877, 559);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(272, 44);
            this.btnImport.TabIndex = 22;
            this.btnImport.Text = "IMPORT";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // FrmInsertBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 663);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.gbMaterialInformation);
            this.Controls.Add(this.gbBatchInformation);
            this.Controls.Add(this.grdImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInsertBatch";
            this.Text = "FrmInsertBatch";
            ((System.ComponentModel.ISupportInitialize)(this.grdImport)).EndInit();
            this.gbBatchInformation.ResumeLayout(false);
            this.gbBatchInformation.PerformLayout();
            this.gbMaterialInformation.ResumeLayout(false);
            this.gbMaterialInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdImport;
        private GroupBox gbBatchInformation;
        private Label label1;
        private RadioButton rbExistingBatch;
        private RadioButton rbNewBatch;
        private ComboBox cbWerehouse;
        private Button brnGetData;
        private TextBox tbDate;
        private Label label4;
        private TextBox tbSender;
        private Label label3;
        private TextBox tbBatch;
        private Label label2;
        private GroupBox gbMaterialInformation;
        private TextBox tbQuantity;
        private Label label5;
        private TextBox tbCode;
        private Label label6;
        private TextBox tbNumber;
        private Label label7;
        private TextBox tbName;
        private Label label9;
        private RadioButton rbMaterial;
        private RadioButton rbElement;
        private TextBox tbPrice;
        private Label label8;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private Button btnImport;
    }
}