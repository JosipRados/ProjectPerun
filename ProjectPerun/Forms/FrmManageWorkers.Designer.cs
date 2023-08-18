using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmManageWorkers
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
            this.gbWorkers = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tbWorkerName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.gbShifts = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefreshShifts = new System.Windows.Forms.Button();
            this.rbFinishing = new System.Windows.Forms.RadioButton();
            this.rbProduction = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.cbProjectName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbShifts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbWorkers
            // 
            this.gbWorkers.Controls.Add(this.textBox4);
            this.gbWorkers.Controls.Add(this.label8);
            this.gbWorkers.Controls.Add(this.textBox3);
            this.gbWorkers.Controls.Add(this.label7);
            this.gbWorkers.Controls.Add(this.btnChangePassword);
            this.gbWorkers.Controls.Add(this.btnRemove);
            this.gbWorkers.Controls.Add(this.btnCreate);
            this.gbWorkers.Controls.Add(this.textBox2);
            this.gbWorkers.Controls.Add(this.label5);
            this.gbWorkers.Controls.Add(this.textBox1);
            this.gbWorkers.Controls.Add(this.label4);
            this.gbWorkers.Controls.Add(this.tbWorkerName);
            this.gbWorkers.Controls.Add(this.dataGridView2);
            this.gbWorkers.Controls.Add(this.btnUpdate);
            this.gbWorkers.Controls.Add(this.label1);
            this.gbWorkers.Location = new System.Drawing.Point(12, 12);
            this.gbWorkers.Name = "gbWorkers";
            this.gbWorkers.Size = new System.Drawing.Size(466, 639);
            this.gbWorkers.TabIndex = 23;
            this.gbWorkers.TabStop = false;
            this.gbWorkers.Text = "Workers";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(23, 431);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(414, 39);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Username:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(23, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(414, 188);
            this.dataGridView2.TabIndex = 27;
            // 
            // tbWorkerName
            // 
            this.tbWorkerName.Location = new System.Drawing.Point(184, 236);
            this.tbWorkerName.Name = "tbWorkerName";
            this.tbWorkerName.Size = new System.Drawing.Size(208, 27);
            this.tbWorkerName.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 27);
            this.textBox1.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(52, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Role:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 368);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 27);
            this.textBox2.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(52, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Hour Rate:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(23, 476);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(414, 39);
            this.btnCreate.TabIndex = 33;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(23, 584);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(414, 39);
            this.btnRemove.TabIndex = 34;
            this.btnRemove.Text = "DELETE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(23, 521);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(414, 39);
            this.btnChangePassword.TabIndex = 35;
            this.btnChangePassword.Text = "CHANGE PASSWORD";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // gbShifts
            // 
            this.gbShifts.Controls.Add(this.btnRefreshShifts);
            this.gbShifts.Controls.Add(this.dataGridView1);
            this.gbShifts.Controls.Add(this.rbFinishing);
            this.gbShifts.Controls.Add(this.cbProjectName);
            this.gbShifts.Controls.Add(this.rbProduction);
            this.gbShifts.Controls.Add(this.label6);
            this.gbShifts.Controls.Add(this.rbAll);
            this.gbShifts.Controls.Add(this.dtFrom);
            this.gbShifts.Controls.Add(this.label3);
            this.gbShifts.Controls.Add(this.dtTo);
            this.gbShifts.Controls.Add(this.label2);
            this.gbShifts.Location = new System.Drawing.Point(495, 12);
            this.gbShifts.Name = "gbShifts";
            this.gbShifts.Size = new System.Drawing.Size(675, 639);
            this.gbShifts.TabIndex = 24;
            this.gbShifts.TabStop = false;
            this.gbShifts.Text = "Worker Shifts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(630, 327);
            this.dataGridView1.TabIndex = 36;
            // 
            // btnRefreshShifts
            // 
            this.btnRefreshShifts.Location = new System.Drawing.Point(22, 584);
            this.btnRefreshShifts.Name = "btnRefreshShifts";
            this.btnRefreshShifts.Size = new System.Drawing.Size(352, 39);
            this.btnRefreshShifts.TabIndex = 36;
            this.btnRefreshShifts.Text = "REFRESH";
            this.btnRefreshShifts.UseVisualStyleBackColor = true;
            this.btnRefreshShifts.Click += new System.EventHandler(this.btnRefreshShifts_Click);
            // 
            // rbFinishing
            // 
            this.rbFinishing.AutoSize = true;
            this.rbFinishing.Location = new System.Drawing.Point(246, 520);
            this.rbFinishing.Name = "rbFinishing";
            this.rbFinishing.Size = new System.Drawing.Size(88, 24);
            this.rbFinishing.TabIndex = 35;
            this.rbFinishing.Text = "Finishing";
            this.rbFinishing.UseVisualStyleBackColor = true;
            // 
            // rbProduction
            // 
            this.rbProduction.AutoSize = true;
            this.rbProduction.Location = new System.Drawing.Point(111, 520);
            this.rbProduction.Name = "rbProduction";
            this.rbProduction.Size = new System.Drawing.Size(102, 24);
            this.rbProduction.TabIndex = 34;
            this.rbProduction.Text = "Production";
            this.rbProduction.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(28, 520);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(48, 24);
            this.rbAll.TabIndex = 33;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "To Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "From Date:";
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(155, 460);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(208, 27);
            this.dtTo.TabIndex = 30;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(155, 427);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(208, 27);
            this.dtFrom.TabIndex = 29;
            // 
            // cbProjectName
            // 
            this.cbProjectName.FormattingEnabled = true;
            this.cbProjectName.Location = new System.Drawing.Point(155, 372);
            this.cbProjectName.Name = "cbProjectName";
            this.cbProjectName.Size = new System.Drawing.Size(208, 28);
            this.cbProjectName.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Project Name:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(184, 269);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 27);
            this.textBox3.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(52, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "Name:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(184, 302);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(208, 27);
            this.textBox4.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(52, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 23);
            this.label8.TabIndex = 38;
            this.label8.Text = "Surname:";
            // 
            // FrmManageWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 663);
            this.Controls.Add(this.gbShifts);
            this.Controls.Add(this.gbWorkers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmManageWorkers";
            this.Text = "FrmManageWorkers";
            this.gbWorkers.ResumeLayout(false);
            this.gbWorkers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbShifts.ResumeLayout(false);
            this.gbShifts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbWorkers;
        private Button btnUpdate;
        private Label label1;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox1;
        private Label label4;
        private TextBox tbWorkerName;
        private DataGridView dataGridView2;
        private Button btnChangePassword;
        private Button btnRemove;
        private Button btnCreate;
        private GroupBox gbShifts;
        private DataGridView dataGridView1;
        private Button btnRefreshShifts;
        private RadioButton rbFinishing;
        private ComboBox cbProjectName;
        private RadioButton rbProduction;
        private Label label6;
        private RadioButton rbAll;
        private DateTimePicker dtFrom;
        private Label label3;
        private DateTimePicker dtTo;
        private Label label2;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox3;
        private Label label7;
    }
}