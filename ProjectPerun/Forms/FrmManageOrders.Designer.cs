using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmManageOrders
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
            this.gbProjectData = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMarkFinished = new System.Windows.Forms.Button();
            this.btnRefreshOrders = new System.Windows.Forms.Button();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbFinished = new System.Windows.Forms.RadioButton();
            this.rbAllOrders = new System.Windows.Forms.RadioButton();
            this.cbFinished = new System.Windows.Forms.CheckBox();
            this.cbMaterialAsigned = new System.Windows.Forms.CheckBox();
            this.tbFinishedDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrderedDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOrderQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrderNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbShifts = new System.Windows.Forms.GroupBox();
            this.btnRefreshShifts = new System.Windows.Forms.Button();
            this.rbFinishig = new System.Windows.Forms.RadioButton();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.rbProduction = new System.Windows.Forms.RadioButton();
            this.rbAllShifts = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gbPricesMaterials = new System.Windows.Forms.GroupBox();
            this.btnShowMaterials = new System.Windows.Forms.Button();
            this.tbFullTime = new System.Windows.Forms.TextBox();
            this.tbProductionTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbFinishingTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbFullPrice = new System.Windows.Forms.TextBox();
            this.tbMaterialPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbWorkerPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbProjectData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbShifts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbPricesMaterials.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProjectData
            // 
            this.gbProjectData.Controls.Add(this.btnDelete);
            this.gbProjectData.Controls.Add(this.btnMarkFinished);
            this.gbProjectData.Controls.Add(this.btnRefreshOrders);
            this.gbProjectData.Controls.Add(this.rbActive);
            this.gbProjectData.Controls.Add(this.rbFinished);
            this.gbProjectData.Controls.Add(this.rbAllOrders);
            this.gbProjectData.Controls.Add(this.cbFinished);
            this.gbProjectData.Controls.Add(this.cbMaterialAsigned);
            this.gbProjectData.Controls.Add(this.tbFinishedDate);
            this.gbProjectData.Controls.Add(this.label5);
            this.gbProjectData.Controls.Add(this.tbOrderedDate);
            this.gbProjectData.Controls.Add(this.label4);
            this.gbProjectData.Controls.Add(this.tbOrderQuantity);
            this.gbProjectData.Controls.Add(this.label3);
            this.gbProjectData.Controls.Add(this.dataGridView1);
            this.gbProjectData.Controls.Add(this.btnCreate);
            this.gbProjectData.Controls.Add(this.btnUpdate);
            this.gbProjectData.Controls.Add(this.tbProjectName);
            this.gbProjectData.Controls.Add(this.label2);
            this.gbProjectData.Controls.Add(this.tbOrderNumber);
            this.gbProjectData.Controls.Add(this.label1);
            this.gbProjectData.Location = new System.Drawing.Point(12, 12);
            this.gbProjectData.Name = "gbProjectData";
            this.gbProjectData.Size = new System.Drawing.Size(1158, 330);
            this.gbProjectData.TabIndex = 1;
            this.gbProjectData.TabStop = false;
            this.gbProjectData.Text = "Order Data";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(833, 246);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(251, 52);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMarkFinished
            // 
            this.btnMarkFinished.Location = new System.Drawing.Point(833, 157);
            this.btnMarkFinished.Name = "btnMarkFinished";
            this.btnMarkFinished.Size = new System.Drawing.Size(251, 52);
            this.btnMarkFinished.TabIndex = 25;
            this.btnMarkFinished.Text = "MARK AS FINISHED";
            this.btnMarkFinished.UseVisualStyleBackColor = true;
            this.btnMarkFinished.Click += new System.EventHandler(this.btnMarkFinished_Click);
            // 
            // btnRefreshOrders
            // 
            this.btnRefreshOrders.Location = new System.Drawing.Point(408, 259);
            this.btnRefreshOrders.Name = "btnRefreshOrders";
            this.btnRefreshOrders.Size = new System.Drawing.Size(352, 39);
            this.btnRefreshOrders.TabIndex = 24;
            this.btnRefreshOrders.Text = "REFRESH";
            this.btnRefreshOrders.UseVisualStyleBackColor = true;
            this.btnRefreshOrders.Click += new System.EventHandler(this.btnRefreshOrders_Click);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(592, 229);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(71, 24);
            this.rbActive.TabIndex = 23;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // rbFinished
            // 
            this.rbFinished.AutoSize = true;
            this.rbFinished.Location = new System.Drawing.Point(484, 229);
            this.rbFinished.Name = "rbFinished";
            this.rbFinished.Size = new System.Drawing.Size(84, 24);
            this.rbFinished.TabIndex = 22;
            this.rbFinished.TabStop = true;
            this.rbFinished.Text = "Finished";
            this.rbFinished.UseVisualStyleBackColor = true;
            // 
            // rbAllOrders
            // 
            this.rbAllOrders.AutoSize = true;
            this.rbAllOrders.Location = new System.Drawing.Point(408, 229);
            this.rbAllOrders.Name = "rbAllOrders";
            this.rbAllOrders.Size = new System.Drawing.Size(48, 24);
            this.rbAllOrders.TabIndex = 21;
            this.rbAllOrders.TabStop = true;
            this.rbAllOrders.Text = "All";
            this.rbAllOrders.UseVisualStyleBackColor = true;
            // 
            // cbFinished
            // 
            this.cbFinished.AutoSize = true;
            this.cbFinished.Enabled = false;
            this.cbFinished.Location = new System.Drawing.Point(148, 274);
            this.cbFinished.Name = "cbFinished";
            this.cbFinished.Size = new System.Drawing.Size(85, 24);
            this.cbFinished.TabIndex = 20;
            this.cbFinished.Text = "Finished";
            this.cbFinished.UseVisualStyleBackColor = true;
            // 
            // cbMaterialAsigned
            // 
            this.cbMaterialAsigned.AutoSize = true;
            this.cbMaterialAsigned.Enabled = false;
            this.cbMaterialAsigned.Location = new System.Drawing.Point(148, 244);
            this.cbMaterialAsigned.Name = "cbMaterialAsigned";
            this.cbMaterialAsigned.Size = new System.Drawing.Size(144, 24);
            this.cbMaterialAsigned.TabIndex = 19;
            this.cbMaterialAsigned.Text = "Material Asigned";
            this.cbMaterialAsigned.UseVisualStyleBackColor = true;
            // 
            // tbFinishedDate
            // 
            this.tbFinishedDate.Location = new System.Drawing.Point(148, 193);
            this.tbFinishedDate.Name = "tbFinishedDate";
            this.tbFinishedDate.ReadOnly = true;
            this.tbFinishedDate.Size = new System.Drawing.Size(220, 27);
            this.tbFinishedDate.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Finished:";
            // 
            // tbOrderedDate
            // 
            this.tbOrderedDate.Location = new System.Drawing.Point(148, 155);
            this.tbOrderedDate.Name = "tbOrderedDate";
            this.tbOrderedDate.ReadOnly = true;
            this.tbOrderedDate.Size = new System.Drawing.Size(220, 27);
            this.tbOrderedDate.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ordered:";
            // 
            // tbOrderQuantity
            // 
            this.tbOrderQuantity.Location = new System.Drawing.Point(148, 108);
            this.tbOrderQuantity.Name = "tbOrderQuantity";
            this.tbOrderQuantity.Size = new System.Drawing.Size(220, 27);
            this.tbOrderQuantity.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Order Quantity:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(408, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(352, 188);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(833, 35);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(251, 52);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "CREATE ORDER";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(833, 96);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(251, 52);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(148, 70);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(220, 27);
            this.tbProjectName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Project Name:";
            // 
            // tbOrderNumber
            // 
            this.tbOrderNumber.Location = new System.Drawing.Point(148, 35);
            this.tbOrderNumber.Name = "tbOrderNumber";
            this.tbOrderNumber.Size = new System.Drawing.Size(220, 27);
            this.tbOrderNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Number:";
            // 
            // gbShifts
            // 
            this.gbShifts.Controls.Add(this.btnRefreshShifts);
            this.gbShifts.Controls.Add(this.rbFinishig);
            this.gbShifts.Controls.Add(this.btnShowDetails);
            this.gbShifts.Controls.Add(this.rbProduction);
            this.gbShifts.Controls.Add(this.rbAllShifts);
            this.gbShifts.Controls.Add(this.dataGridView2);
            this.gbShifts.Location = new System.Drawing.Point(12, 348);
            this.gbShifts.Name = "gbShifts";
            this.gbShifts.Size = new System.Drawing.Size(538, 303);
            this.gbShifts.TabIndex = 2;
            this.gbShifts.TabStop = false;
            this.gbShifts.Text = "Shifts";
            // 
            // btnRefreshShifts
            // 
            this.btnRefreshShifts.Location = new System.Drawing.Point(307, 231);
            this.btnRefreshShifts.Name = "btnRefreshShifts";
            this.btnRefreshShifts.Size = new System.Drawing.Size(96, 39);
            this.btnRefreshShifts.TabIndex = 30;
            this.btnRefreshShifts.Text = "REFRESH";
            this.btnRefreshShifts.UseVisualStyleBackColor = true;
            this.btnRefreshShifts.Click += new System.EventHandler(this.btnRefreshShifts_Click);
            // 
            // rbFinishig
            // 
            this.rbFinishig.AutoSize = true;
            this.rbFinishig.Location = new System.Drawing.Point(182, 231);
            this.rbFinishig.Name = "rbFinishig";
            this.rbFinishig.Size = new System.Drawing.Size(88, 24);
            this.rbFinishig.TabIndex = 29;
            this.rbFinishig.TabStop = true;
            this.rbFinishig.Text = "Finishing";
            this.rbFinishig.UseVisualStyleBackColor = true;
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Location = new System.Drawing.Point(422, 231);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(96, 39);
            this.btnShowDetails.TabIndex = 27;
            this.btnShowDetails.Text = "DETAILS";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // rbProduction
            // 
            this.rbProduction.AutoSize = true;
            this.rbProduction.Location = new System.Drawing.Point(74, 231);
            this.rbProduction.Name = "rbProduction";
            this.rbProduction.Size = new System.Drawing.Size(102, 24);
            this.rbProduction.TabIndex = 28;
            this.rbProduction.TabStop = true;
            this.rbProduction.Text = "Production";
            this.rbProduction.UseVisualStyleBackColor = true;
            // 
            // rbAllShifts
            // 
            this.rbAllShifts.AutoSize = true;
            this.rbAllShifts.Location = new System.Drawing.Point(17, 231);
            this.rbAllShifts.Name = "rbAllShifts";
            this.rbAllShifts.Size = new System.Drawing.Size(48, 24);
            this.rbAllShifts.TabIndex = 27;
            this.rbAllShifts.TabStop = true;
            this.rbAllShifts.Text = "All";
            this.rbAllShifts.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(502, 188);
            this.dataGridView2.TabIndex = 27;
            // 
            // gbPricesMaterials
            // 
            this.gbPricesMaterials.Controls.Add(this.btnShowMaterials);
            this.gbPricesMaterials.Controls.Add(this.tbFullTime);
            this.gbPricesMaterials.Controls.Add(this.tbProductionTime);
            this.gbPricesMaterials.Controls.Add(this.label9);
            this.gbPricesMaterials.Controls.Add(this.label10);
            this.gbPricesMaterials.Controls.Add(this.tbFinishingTime);
            this.gbPricesMaterials.Controls.Add(this.label11);
            this.gbPricesMaterials.Controls.Add(this.tbFullPrice);
            this.gbPricesMaterials.Controls.Add(this.tbMaterialPrice);
            this.gbPricesMaterials.Controls.Add(this.label6);
            this.gbPricesMaterials.Controls.Add(this.label8);
            this.gbPricesMaterials.Controls.Add(this.tbWorkerPrice);
            this.gbPricesMaterials.Controls.Add(this.label7);
            this.gbPricesMaterials.Location = new System.Drawing.Point(556, 348);
            this.gbPricesMaterials.Name = "gbPricesMaterials";
            this.gbPricesMaterials.Size = new System.Drawing.Size(614, 303);
            this.gbPricesMaterials.TabIndex = 4;
            this.gbPricesMaterials.TabStop = false;
            this.gbPricesMaterials.Text = "Prices And Materials";
            // 
            // btnShowMaterials
            // 
            this.btnShowMaterials.Location = new System.Drawing.Point(384, 218);
            this.btnShowMaterials.Name = "btnShowMaterials";
            this.btnShowMaterials.Size = new System.Drawing.Size(207, 52);
            this.btnShowMaterials.TabIndex = 27;
            this.btnShowMaterials.Text = "SHOW MATERIALS";
            this.btnShowMaterials.UseVisualStyleBackColor = true;
            this.btnShowMaterials.Click += new System.EventHandler(this.btnShowMaterials_Click);
            // 
            // tbFullTime
            // 
            this.tbFullTime.Location = new System.Drawing.Point(166, 241);
            this.tbFullTime.Name = "tbFullTime";
            this.tbFullTime.ReadOnly = true;
            this.tbFullTime.Size = new System.Drawing.Size(191, 27);
            this.tbFullTime.TabIndex = 38;
            // 
            // tbProductionTime
            // 
            this.tbProductionTime.Location = new System.Drawing.Point(166, 168);
            this.tbProductionTime.Name = "tbProductionTime";
            this.tbProductionTime.ReadOnly = true;
            this.tbProductionTime.Size = new System.Drawing.Size(191, 27);
            this.tbProductionTime.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(21, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "Full Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(21, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 23);
            this.label10.TabIndex = 34;
            this.label10.Text = "Production Time:";
            // 
            // tbFinishingTime
            // 
            this.tbFinishingTime.Location = new System.Drawing.Point(166, 204);
            this.tbFinishingTime.Name = "tbFinishingTime";
            this.tbFinishingTime.ReadOnly = true;
            this.tbFinishingTime.Size = new System.Drawing.Size(191, 27);
            this.tbFinishingTime.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(21, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 23);
            this.label11.TabIndex = 35;
            this.label11.Text = "Finishing Time:";
            // 
            // tbFullPrice
            // 
            this.tbFullPrice.Location = new System.Drawing.Point(166, 110);
            this.tbFullPrice.Name = "tbFullPrice";
            this.tbFullPrice.ReadOnly = true;
            this.tbFullPrice.Size = new System.Drawing.Size(191, 27);
            this.tbFullPrice.TabIndex = 32;
            // 
            // tbMaterialPrice
            // 
            this.tbMaterialPrice.Location = new System.Drawing.Point(166, 37);
            this.tbMaterialPrice.Name = "tbMaterialPrice";
            this.tbMaterialPrice.ReadOnly = true;
            this.tbMaterialPrice.Size = new System.Drawing.Size(191, 27);
            this.tbMaterialPrice.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Full Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(21, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 28;
            this.label8.Text = "Material Price:";
            // 
            // tbWorkerPrice
            // 
            this.tbWorkerPrice.Location = new System.Drawing.Point(166, 73);
            this.tbWorkerPrice.Name = "tbWorkerPrice";
            this.tbWorkerPrice.ReadOnly = true;
            this.tbWorkerPrice.Size = new System.Drawing.Size(191, 27);
            this.tbWorkerPrice.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(21, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Worker Price:";
            // 
            // FrmManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 663);
            this.Controls.Add(this.gbPricesMaterials);
            this.Controls.Add(this.gbShifts);
            this.Controls.Add(this.gbProjectData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmManageOrders";
            this.Text = "ManageOrders";
            this.gbProjectData.ResumeLayout(false);
            this.gbProjectData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbShifts.ResumeLayout(false);
            this.gbShifts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbPricesMaterials.ResumeLayout(false);
            this.gbPricesMaterials.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbProjectData;
        private Button btnDelete;
        private Button btnMarkFinished;
        private Button btnRefreshOrders;
        private RadioButton rbActive;
        private RadioButton rbFinished;
        private RadioButton rbAllOrders;
        private CheckBox cbFinished;
        private CheckBox cbMaterialAsigned;
        private TextBox tbFinishedDate;
        private Label label5;
        private TextBox tbOrderedDate;
        private Label label4;
        private TextBox tbOrderQuantity;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnCreate;
        private Button btnUpdate;
        private TextBox tbProjectName;
        private Label label2;
        private TextBox tbOrderNumber;
        private Label label1;
        private GroupBox gbShifts;
        private Button btnRefreshShifts;
        private RadioButton rbFinishig;
        private Button btnShowDetails;
        private RadioButton rbProduction;
        private RadioButton rbAllShifts;
        private DataGridView dataGridView2;
        private GroupBox gbPricesMaterials;
        private Button btnShowMaterials;
        private TextBox tbFullTime;
        private TextBox tbProductionTime;
        private Label label9;
        private Label label10;
        private TextBox tbFinishingTime;
        private Label label11;
        private TextBox tbFullPrice;
        private TextBox tbMaterialPrice;
        private Label label6;
        private Label label8;
        private TextBox tbWorkerPrice;
        private Label label7;
    }
}