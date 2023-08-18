using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmProduction
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
            this.gbPodatciSmjene = new System.Windows.Forms.GroupBox();
            this.btnFetchShiftData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbShiftNumber = new System.Windows.Forms.TextBox();
            this.cbOrderNumber = new System.Windows.Forms.ComboBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbOrderQuantity = new System.Windows.Forms.TextBox();
            this.btnStartShift = new System.Windows.Forms.Button();
            this.gbRemoveMaterial = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaterialNumber = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbOrderMaterials = new System.Windows.Forms.GroupBox();
            this.gbWorkers = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.btnRemoveWorker = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.btnFinishShift = new System.Windows.Forms.Button();
            this.gbPodatciSmjene.SuspendLayout();
            this.gbRemoveMaterial.SuspendLayout();
            this.gbOrderMaterials.SuspendLayout();
            this.gbWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPodatciSmjene
            // 
            this.gbPodatciSmjene.Controls.Add(this.label7);
            this.gbPodatciSmjene.Controls.Add(this.tbDepartment);
            this.gbPodatciSmjene.Controls.Add(this.btnStartShift);
            this.gbPodatciSmjene.Controls.Add(this.tbOrderQuantity);
            this.gbPodatciSmjene.Controls.Add(this.btnFetchShiftData);
            this.gbPodatciSmjene.Controls.Add(this.tbProductName);
            this.gbPodatciSmjene.Controls.Add(this.cbOrderNumber);
            this.gbPodatciSmjene.Controls.Add(this.label4);
            this.gbPodatciSmjene.Controls.Add(this.tbShiftNumber);
            this.gbPodatciSmjene.Controls.Add(this.label3);
            this.gbPodatciSmjene.Controls.Add(this.label2);
            this.gbPodatciSmjene.Controls.Add(this.label1);
            this.gbPodatciSmjene.Location = new System.Drawing.Point(12, 12);
            this.gbPodatciSmjene.Name = "gbPodatciSmjene";
            this.gbPodatciSmjene.Size = new System.Drawing.Size(405, 315);
            this.gbPodatciSmjene.TabIndex = 0;
            this.gbPodatciSmjene.TabStop = false;
            this.gbPodatciSmjene.Text = "Shift Informations";
            // 
            // btnFetchShiftData
            // 
            this.btnFetchShiftData.Location = new System.Drawing.Point(16, 236);
            this.btnFetchShiftData.Name = "btnFetchShiftData";
            this.btnFetchShiftData.Size = new System.Drawing.Size(133, 50);
            this.btnFetchShiftData.TabIndex = 1;
            this.btnFetchShiftData.Text = "FETCH ORDER";
            this.btnFetchShiftData.UseVisualStyleBackColor = true;
            this.btnFetchShiftData.Click += new System.EventHandler(this.btnFetchShiftData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Order Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Shift Number:";
            // 
            // tbShiftNumber
            // 
            this.tbShiftNumber.Location = new System.Drawing.Point(166, 48);
            this.tbShiftNumber.Name = "tbShiftNumber";
            this.tbShiftNumber.Size = new System.Drawing.Size(206, 27);
            this.tbShiftNumber.TabIndex = 2;
            // 
            // cbOrderNumber
            // 
            this.cbOrderNumber.FormattingEnabled = true;
            this.cbOrderNumber.Location = new System.Drawing.Point(166, 114);
            this.cbOrderNumber.Name = "cbOrderNumber";
            this.cbOrderNumber.Size = new System.Drawing.Size(206, 28);
            this.cbOrderNumber.TabIndex = 3;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(166, 148);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(206, 27);
            this.tbProductName.TabIndex = 6;
            // 
            // tbOrderQuantity
            // 
            this.tbOrderQuantity.Location = new System.Drawing.Point(166, 181);
            this.tbOrderQuantity.Name = "tbOrderQuantity";
            this.tbOrderQuantity.Size = new System.Drawing.Size(206, 27);
            this.tbOrderQuantity.TabIndex = 7;
            // 
            // btnStartShift
            // 
            this.btnStartShift.Enabled = false;
            this.btnStartShift.Location = new System.Drawing.Point(239, 236);
            this.btnStartShift.Name = "btnStartShift";
            this.btnStartShift.Size = new System.Drawing.Size(133, 50);
            this.btnStartShift.TabIndex = 8;
            this.btnStartShift.Text = "START SHIFT";
            this.btnStartShift.UseVisualStyleBackColor = true;
            this.btnStartShift.Click += new System.EventHandler(this.btnStartShift_Click);
            // 
            // gbRemoveMaterial
            // 
            this.gbRemoveMaterial.Controls.Add(this.btnRemove);
            this.gbRemoveMaterial.Controls.Add(this.label6);
            this.gbRemoveMaterial.Controls.Add(this.tbCode);
            this.gbRemoveMaterial.Controls.Add(this.label5);
            this.gbRemoveMaterial.Controls.Add(this.tbMaterialNumber);
            this.gbRemoveMaterial.Location = new System.Drawing.Point(12, 347);
            this.gbRemoveMaterial.Name = "gbRemoveMaterial";
            this.gbRemoveMaterial.Size = new System.Drawing.Size(405, 205);
            this.gbRemoveMaterial.TabIndex = 1;
            this.gbRemoveMaterial.TabStop = false;
            this.gbRemoveMaterial.Text = "Remove Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Material Number:";
            // 
            // tbMaterialNumber
            // 
            this.tbMaterialNumber.Location = new System.Drawing.Point(166, 45);
            this.tbMaterialNumber.Name = "tbMaterialNumber";
            this.tbMaterialNumber.Size = new System.Drawing.Size(206, 27);
            this.tbMaterialNumber.TabIndex = 9;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(166, 78);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(206, 27);
            this.tbCode.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Code:";
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(239, 126);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(133, 50);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbOrderMaterials
            // 
            this.gbOrderMaterials.Controls.Add(this.dataGridView1);
            this.gbOrderMaterials.Location = new System.Drawing.Point(445, 12);
            this.gbOrderMaterials.Name = "gbOrderMaterials";
            this.gbOrderMaterials.Size = new System.Drawing.Size(455, 655);
            this.gbOrderMaterials.TabIndex = 2;
            this.gbOrderMaterials.TabStop = false;
            this.gbOrderMaterials.Text = "Order Materials";
            // 
            // gbWorkers
            // 
            this.gbWorkers.Controls.Add(this.btnRemoveWorker);
            this.gbWorkers.Controls.Add(this.btnAddWorker);
            this.gbWorkers.Controls.Add(this.dataGridView2);
            this.gbWorkers.Location = new System.Drawing.Point(930, 12);
            this.gbWorkers.Name = "gbWorkers";
            this.gbWorkers.Size = new System.Drawing.Size(365, 315);
            this.gbWorkers.TabIndex = 3;
            this.gbWorkers.TabStop = false;
            this.gbWorkers.Text = "Workers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(409, 605);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(324, 188);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Enabled = false;
            this.btnAddWorker.Location = new System.Drawing.Point(21, 236);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(133, 50);
            this.btnAddWorker.TabIndex = 13;
            this.btnAddWorker.Text = "ADD";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // btnRemoveWorker
            // 
            this.btnRemoveWorker.Enabled = false;
            this.btnRemoveWorker.Location = new System.Drawing.Point(212, 236);
            this.btnRemoveWorker.Name = "btnRemoveWorker";
            this.btnRemoveWorker.Size = new System.Drawing.Size(133, 50);
            this.btnRemoveWorker.TabIndex = 14;
            this.btnRemoveWorker.Text = "REMOVE";
            this.btnRemoveWorker.UseVisualStyleBackColor = true;
            this.btnRemoveWorker.Click += new System.EventHandler(this.btnRemoveWorker_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(951, 602);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(324, 50);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Department:";
            // 
            // tbDepartment
            // 
            this.tbDepartment.Location = new System.Drawing.Point(166, 81);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(206, 27);
            this.tbDepartment.TabIndex = 9;
            // 
            // btnFinishShift
            // 
            this.btnFinishShift.Enabled = false;
            this.btnFinishShift.Location = new System.Drawing.Point(951, 546);
            this.btnFinishShift.Name = "btnFinishShift";
            this.btnFinishShift.Size = new System.Drawing.Size(324, 50);
            this.btnFinishShift.TabIndex = 14;
            this.btnFinishShift.Text = "FINISH SHIFT";
            this.btnFinishShift.UseVisualStyleBackColor = true;
            this.btnFinishShift.Click += new System.EventHandler(this.btnFinishShift_Click);
            // 
            // FrmProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 679);
            this.Controls.Add(this.btnFinishShift);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbWorkers);
            this.Controls.Add(this.gbOrderMaterials);
            this.Controls.Add(this.gbRemoveMaterial);
            this.Controls.Add(this.gbPodatciSmjene);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmProduction";
            this.Text = "FrmProduction";
            this.gbPodatciSmjene.ResumeLayout(false);
            this.gbPodatciSmjene.PerformLayout();
            this.gbRemoveMaterial.ResumeLayout(false);
            this.gbRemoveMaterial.PerformLayout();
            this.gbOrderMaterials.ResumeLayout(false);
            this.gbWorkers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbPodatciSmjene;
        private Label label1;
        private Button btnFetchShiftData;
        private TextBox tbOrderQuantity;
        private TextBox tbProductName;
        private ComboBox cbOrderNumber;
        private Label label4;
        private TextBox tbShiftNumber;
        private Label label3;
        private Label label2;
        private Button btnStartShift;
        private GroupBox gbRemoveMaterial;
        private Label label6;
        private TextBox tbCode;
        private Label label5;
        private TextBox tbMaterialNumber;
        private Label label7;
        private TextBox tbDepartment;
        private Button btnRemove;
        private GroupBox gbOrderMaterials;
        private DataGridView dataGridView1;
        private GroupBox gbWorkers;
        private Button btnRemoveWorker;
        private Button btnAddWorker;
        private DataGridView dataGridView2;
        private Button btnCancel;
        private Button btnFinishShift;
    }
}