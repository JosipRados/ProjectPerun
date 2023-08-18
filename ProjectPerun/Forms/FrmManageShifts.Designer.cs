using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmManageShifts
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
            this.gbFilterShifts = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gbShiftList = new System.Windows.Forms.GroupBox();
            this.gbShifts = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbProjectName = new System.Windows.Forms.ComboBox();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbProduction = new System.Windows.Forms.RadioButton();
            this.rbFinishing = new System.Windows.Forms.RadioButton();
            this.btnRefreshShifts = new System.Windows.Forms.Button();
            this.btnShowWorkers = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbFilterShifts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbShiftList.SuspendLayout();
            this.gbShifts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilterShifts
            // 
            this.gbFilterShifts.Controls.Add(this.btnRefreshShifts);
            this.gbFilterShifts.Controls.Add(this.rbFinishing);
            this.gbFilterShifts.Controls.Add(this.rbProduction);
            this.gbFilterShifts.Controls.Add(this.rbAll);
            this.gbFilterShifts.Controls.Add(this.label3);
            this.gbFilterShifts.Controls.Add(this.label2);
            this.gbFilterShifts.Controls.Add(this.dtTo);
            this.gbFilterShifts.Controls.Add(this.dtFrom);
            this.gbFilterShifts.Controls.Add(this.cbProjectName);
            this.gbFilterShifts.Controls.Add(this.label1);
            this.gbFilterShifts.Location = new System.Drawing.Point(29, 35);
            this.gbFilterShifts.Name = "gbFilterShifts";
            this.gbFilterShifts.Size = new System.Drawing.Size(466, 331);
            this.gbFilterShifts.TabIndex = 22;
            this.gbFilterShifts.TabStop = false;
            this.gbFilterShifts.Text = "Filter Shifts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Project Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(29, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 230);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shift Workers";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 39);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(425, 170);
            this.dataGridView2.TabIndex = 22;
            // 
            // gbShiftList
            // 
            this.gbShiftList.Controls.Add(this.btnCalculate);
            this.gbShiftList.Controls.Add(this.btnShowWorkers);
            this.gbShiftList.Controls.Add(this.dataGridView1);
            this.gbShiftList.Location = new System.Drawing.Point(513, 35);
            this.gbShiftList.Name = "gbShiftList";
            this.gbShiftList.Size = new System.Drawing.Size(622, 578);
            this.gbShiftList.TabIndex = 24;
            this.gbShiftList.TabStop = false;
            this.gbShiftList.Text = "Shift List";
            // 
            // gbShifts
            // 
            this.gbShifts.Controls.Add(this.gbShiftList);
            this.gbShifts.Controls.Add(this.groupBox1);
            this.gbShifts.Controls.Add(this.gbFilterShifts);
            this.gbShifts.Location = new System.Drawing.Point(12, 12);
            this.gbShifts.Name = "gbShifts";
            this.gbShifts.Size = new System.Drawing.Size(1158, 639);
            this.gbShifts.TabIndex = 2;
            this.gbShifts.TabStop = false;
            this.gbShifts.Text = "Shifts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(572, 454);
            this.dataGridView1.TabIndex = 25;
            // 
            // cbProjectName
            // 
            this.cbProjectName.FormattingEnabled = true;
            this.cbProjectName.Location = new System.Drawing.Point(152, 32);
            this.cbProjectName.Name = "cbProjectName";
            this.cbProjectName.Size = new System.Drawing.Size(208, 28);
            this.cbProjectName.TabIndex = 18;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(152, 87);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(208, 27);
            this.dtFrom.TabIndex = 19;
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(152, 120);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(208, 27);
            this.dtTo.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "From Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "To Date:";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(25, 180);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(48, 24);
            this.rbAll.TabIndex = 23;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbProduction
            // 
            this.rbProduction.AutoSize = true;
            this.rbProduction.Location = new System.Drawing.Point(108, 180);
            this.rbProduction.Name = "rbProduction";
            this.rbProduction.Size = new System.Drawing.Size(102, 24);
            this.rbProduction.TabIndex = 24;
            this.rbProduction.TabStop = true;
            this.rbProduction.Text = "Production";
            this.rbProduction.UseVisualStyleBackColor = true;
            // 
            // rbFinishing
            // 
            this.rbFinishing.AutoSize = true;
            this.rbFinishing.Location = new System.Drawing.Point(243, 180);
            this.rbFinishing.Name = "rbFinishing";
            this.rbFinishing.Size = new System.Drawing.Size(88, 24);
            this.rbFinishing.TabIndex = 25;
            this.rbFinishing.TabStop = true;
            this.rbFinishing.Text = "Finishing";
            this.rbFinishing.UseVisualStyleBackColor = true;
            // 
            // btnRefreshShifts
            // 
            this.btnRefreshShifts.Location = new System.Drawing.Point(55, 244);
            this.btnRefreshShifts.Name = "btnRefreshShifts";
            this.btnRefreshShifts.Size = new System.Drawing.Size(352, 39);
            this.btnRefreshShifts.TabIndex = 26;
            this.btnRefreshShifts.Text = "REFRESH";
            this.btnRefreshShifts.UseVisualStyleBackColor = true;
            this.btnRefreshShifts.Click += new System.EventHandler(this.btnRefreshShifts_Click);
            // 
            // btnShowWorkers
            // 
            this.btnShowWorkers.Location = new System.Drawing.Point(22, 518);
            this.btnShowWorkers.Name = "btnShowWorkers";
            this.btnShowWorkers.Size = new System.Drawing.Size(264, 39);
            this.btnShowWorkers.TabIndex = 27;
            this.btnShowWorkers.Text = "SHOW WORKERS";
            this.btnShowWorkers.UseVisualStyleBackColor = true;
            this.btnShowWorkers.Click += new System.EventHandler(this.btnShowWorkers_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(330, 518);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(264, 39);
            this.btnCalculate.TabIndex = 28;
            this.btnCalculate.Text = "CALCULATE DATA";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // FrmManageShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 663);
            this.Controls.Add(this.gbShifts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmManageShifts";
            this.Text = "FrmManageShifts";
            this.gbFilterShifts.ResumeLayout(false);
            this.gbFilterShifts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbShiftList.ResumeLayout(false);
            this.gbShifts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbFilterShifts;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private GroupBox gbShiftList;
        private DataGridView dataGridView1;
        private GroupBox gbShifts;
        private ComboBox cbProjectName;
        private RadioButton rbFinishing;
        private RadioButton rbProduction;
        private RadioButton rbAll;
        private Label label3;
        private Label label2;
        private DateTimePicker dtTo;
        private DateTimePicker dtFrom;
        private Button btnRefreshShifts;
        private Button btnCalculate;
        private Button btnShowWorkers;
    }
}