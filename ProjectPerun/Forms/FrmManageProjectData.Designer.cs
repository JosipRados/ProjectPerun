using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmManageProjectData
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbProjectDescription = new System.Windows.Forms.RichTextBox();
            this.tbProjectCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProjectMaterial = new System.Windows.Forms.GroupBox();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemoveMaterial = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaterialQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rtbMaterialDescription = new System.Windows.Forms.RichTextBox();
            this.tbMaterialType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaterialCode = new System.Windows.Forms.TextBox();
            this.gbProjectData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbProjectMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProjectData
            // 
            this.gbProjectData.Controls.Add(this.dataGridView1);
            this.gbProjectData.Controls.Add(this.btnRemove);
            this.gbProjectData.Controls.Add(this.btnUpdate);
            this.gbProjectData.Controls.Add(this.label3);
            this.gbProjectData.Controls.Add(this.rtbProjectDescription);
            this.gbProjectData.Controls.Add(this.tbProjectCompany);
            this.gbProjectData.Controls.Add(this.label2);
            this.gbProjectData.Controls.Add(this.tbProjectName);
            this.gbProjectData.Controls.Add(this.label1);
            this.gbProjectData.Location = new System.Drawing.Point(12, 12);
            this.gbProjectData.Name = "gbProjectData";
            this.gbProjectData.Size = new System.Drawing.Size(392, 639);
            this.gbProjectData.TabIndex = 0;
            this.gbProjectData.TabStop = false;
            this.gbProjectData.Text = "Project Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(344, 188);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(16, 491);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 52);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(235, 491);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 52);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description:";
            // 
            // rtbProjectDescription
            // 
            this.rtbProjectDescription.Location = new System.Drawing.Point(140, 109);
            this.rtbProjectDescription.Name = "rtbProjectDescription";
            this.rtbProjectDescription.Size = new System.Drawing.Size(220, 130);
            this.rtbProjectDescription.TabIndex = 6;
            this.rtbProjectDescription.Text = "";
            // 
            // tbProjectCompany
            // 
            this.tbProjectCompany.Location = new System.Drawing.Point(140, 70);
            this.tbProjectCompany.Name = "tbProjectCompany";
            this.tbProjectCompany.Size = new System.Drawing.Size(220, 27);
            this.tbProjectCompany.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Company:";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(140, 32);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(220, 27);
            this.tbProjectName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project Name:";
            // 
            // gbProjectMaterial
            // 
            this.gbProjectMaterial.Controls.Add(this.tbDepartment);
            this.gbProjectMaterial.Controls.Add(this.label8);
            this.gbProjectMaterial.Controls.Add(this.btnRemoveMaterial);
            this.gbProjectMaterial.Controls.Add(this.btnAdd);
            this.gbProjectMaterial.Controls.Add(this.label7);
            this.gbProjectMaterial.Controls.Add(this.tbMaterialQuantity);
            this.gbProjectMaterial.Controls.Add(this.label4);
            this.gbProjectMaterial.Controls.Add(this.dataGridView2);
            this.gbProjectMaterial.Controls.Add(this.rtbMaterialDescription);
            this.gbProjectMaterial.Controls.Add(this.tbMaterialType);
            this.gbProjectMaterial.Controls.Add(this.label6);
            this.gbProjectMaterial.Controls.Add(this.label5);
            this.gbProjectMaterial.Controls.Add(this.tbMaterialCode);
            this.gbProjectMaterial.Location = new System.Drawing.Point(426, 12);
            this.gbProjectMaterial.Name = "gbProjectMaterial";
            this.gbProjectMaterial.Size = new System.Drawing.Size(744, 639);
            this.gbProjectMaterial.TabIndex = 1;
            this.gbProjectMaterial.TabStop = false;
            this.gbProjectMaterial.Text = "Project Material";
            // 
            // tbDepartment
            // 
            this.tbDepartment.Location = new System.Drawing.Point(495, 132);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(220, 27);
            this.tbDepartment.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(371, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Department:";
            // 
            // btnRemoveMaterial
            // 
            this.btnRemoveMaterial.Location = new System.Drawing.Point(495, 379);
            this.btnRemoveMaterial.Name = "btnRemoveMaterial";
            this.btnRemoveMaterial.Size = new System.Drawing.Size(220, 52);
            this.btnRemoveMaterial.TabIndex = 18;
            this.btnRemoveMaterial.Text = "REMOVE";
            this.btnRemoveMaterial.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(495, 312);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(220, 52);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(371, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quantity:";
            // 
            // tbMaterialQuantity
            // 
            this.tbMaterialQuantity.Location = new System.Drawing.Point(495, 66);
            this.tbMaterialQuantity.Name = "tbMaterialQuantity";
            this.tbMaterialQuantity.Size = new System.Drawing.Size(220, 27);
            this.tbMaterialQuantity.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(371, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Description:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(29, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(310, 580);
            this.dataGridView2.TabIndex = 10;
            // 
            // rtbMaterialDescription
            // 
            this.rtbMaterialDescription.Location = new System.Drawing.Point(495, 165);
            this.rtbMaterialDescription.Name = "rtbMaterialDescription";
            this.rtbMaterialDescription.Size = new System.Drawing.Size(220, 130);
            this.rtbMaterialDescription.TabIndex = 14;
            this.rtbMaterialDescription.Text = "";
            // 
            // tbMaterialType
            // 
            this.tbMaterialType.Location = new System.Drawing.Point(495, 99);
            this.tbMaterialType.Name = "tbMaterialType";
            this.tbMaterialType.Size = new System.Drawing.Size(220, 27);
            this.tbMaterialType.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(371, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Material Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(371, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Type:";
            // 
            // tbMaterialCode
            // 
            this.tbMaterialCode.Location = new System.Drawing.Point(495, 33);
            this.tbMaterialCode.Name = "tbMaterialCode";
            this.tbMaterialCode.Size = new System.Drawing.Size(220, 27);
            this.tbMaterialCode.TabIndex = 10;
            // 
            // FrmManageProjectData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 663);
            this.Controls.Add(this.gbProjectMaterial);
            this.Controls.Add(this.gbProjectData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmManageProjectData";
            this.Text = "ManageProjectData";
            this.gbProjectData.ResumeLayout(false);
            this.gbProjectData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbProjectMaterial.ResumeLayout(false);
            this.gbProjectMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbProjectData;
        private Button btnRemove;
        private Button btnUpdate;
        private Label label3;
        private RichTextBox rtbProjectDescription;
        private TextBox tbProjectCompany;
        private Label label2;
        private TextBox tbProjectName;
        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox gbProjectMaterial;
        private Label label4;
        private DataGridView dataGridView2;
        private RichTextBox rtbMaterialDescription;
        private TextBox tbMaterialType;
        private Label label6;
        private Label label5;
        private TextBox tbMaterialCode;
        private Button btnRemoveMaterial;
        private Button btnAdd;
        private Label label7;
        private TextBox tbMaterialQuantity;
        private TextBox tbDepartment;
        private Label label8;
    }
}