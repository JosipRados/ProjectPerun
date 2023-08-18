﻿using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmExportToProject
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
            this.gbStorageMaterial = new System.Windows.Forms.GroupBox();
            this.btnProduction = new System.Windows.Forms.Button();
            this.btnFInishing = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbProjectMaterial = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturnFinishing = new System.Windows.Forms.Button();
            this.btnReturnProduction = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gbProjectData = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.gbStorageMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbProjectMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbProjectData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStorageMaterial
            // 
            this.gbStorageMaterial.Controls.Add(this.btnProduction);
            this.gbStorageMaterial.Controls.Add(this.btnFInishing);
            this.gbStorageMaterial.Controls.Add(this.dataGridView1);
            this.gbStorageMaterial.Location = new System.Drawing.Point(439, 22);
            this.gbStorageMaterial.Name = "gbStorageMaterial";
            this.gbStorageMaterial.Size = new System.Drawing.Size(714, 296);
            this.gbStorageMaterial.TabIndex = 0;
            this.gbStorageMaterial.TabStop = false;
            this.gbStorageMaterial.Text = "Storage Material";
            // 
            // btnProduction
            // 
            this.btnProduction.Location = new System.Drawing.Point(555, 179);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(145, 43);
            this.btnProduction.TabIndex = 8;
            this.btnProduction.Text = "TO PRODUCTION";
            this.btnProduction.UseVisualStyleBackColor = true;
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click);
            // 
            // btnFInishing
            // 
            this.btnFInishing.Location = new System.Drawing.Point(555, 228);
            this.btnFInishing.Name = "btnFInishing";
            this.btnFInishing.Size = new System.Drawing.Size(145, 43);
            this.btnFInishing.TabIndex = 7;
            this.btnFInishing.Text = "TO FINISHING";
            this.btnFInishing.UseVisualStyleBackColor = true;
            this.btnFInishing.Click += new System.EventHandler(this.btnFInishing_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(527, 230);
            this.dataGridView1.TabIndex = 6;
            // 
            // gbProjectMaterial
            // 
            this.gbProjectMaterial.Controls.Add(this.btnDone);
            this.gbProjectMaterial.Controls.Add(this.label2);
            this.gbProjectMaterial.Controls.Add(this.label1);
            this.gbProjectMaterial.Controls.Add(this.btnReturnFinishing);
            this.gbProjectMaterial.Controls.Add(this.btnReturnProduction);
            this.gbProjectMaterial.Controls.Add(this.dataGridView3);
            this.gbProjectMaterial.Controls.Add(this.dataGridView2);
            this.gbProjectMaterial.Location = new System.Drawing.Point(24, 338);
            this.gbProjectMaterial.Name = "gbProjectMaterial";
            this.gbProjectMaterial.Size = new System.Drawing.Size(1129, 296);
            this.gbProjectMaterial.TabIndex = 1;
            this.gbProjectMaterial.TabStop = false;
            this.gbProjectMaterial.Text = "Order Material:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(574, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Finishing:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Production:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnReturnFinishing
            // 
            this.btnReturnFinishing.Location = new System.Drawing.Point(967, 70);
            this.btnReturnFinishing.Name = "btnReturnFinishing";
            this.btnReturnFinishing.Size = new System.Drawing.Size(102, 43);
            this.btnReturnFinishing.TabIndex = 10;
            this.btnReturnFinishing.Text = "RETURN";
            this.btnReturnFinishing.UseVisualStyleBackColor = true;
            this.btnReturnFinishing.Click += new System.EventHandler(this.btnReturnFinishing_Click);
            // 
            // btnReturnProduction
            // 
            this.btnReturnProduction.Location = new System.Drawing.Point(415, 70);
            this.btnReturnProduction.Name = "btnReturnProduction";
            this.btnReturnProduction.Size = new System.Drawing.Size(102, 43);
            this.btnReturnProduction.TabIndex = 9;
            this.btnReturnProduction.Text = "RETURN";
            this.btnReturnProduction.UseVisualStyleBackColor = true;
            this.btnReturnProduction.Click += new System.EventHandler(this.btnReturnProduction_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(22, 70);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(387, 200);
            this.dataGridView3.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(574, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(387, 200);
            this.dataGridView2.TabIndex = 8;
            // 
            // gbProjectData
            // 
            this.gbProjectData.Controls.Add(this.dataGridView4);
            this.gbProjectData.Controls.Add(this.comboBox1);
            this.gbProjectData.Controls.Add(this.textBox3);
            this.gbProjectData.Controls.Add(this.textBox2);
            this.gbProjectData.Controls.Add(this.label5);
            this.gbProjectData.Controls.Add(this.label4);
            this.gbProjectData.Controls.Add(this.label3);
            this.gbProjectData.Location = new System.Drawing.Point(24, 22);
            this.gbProjectData.Name = "gbProjectData";
            this.gbProjectData.Size = new System.Drawing.Size(384, 296);
            this.gbProjectData.TabIndex = 2;
            this.gbProjectData.TabStop = false;
            this.gbProjectData.Text = "Order Data:";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(22, 149);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 29;
            this.dataGridView4.Size = new System.Drawing.Size(342, 122);
            this.dataGridView4.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 28);
            this.comboBox1.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 27);
            this.textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 27);
            this.textBox2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Project Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Order Number:";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(1027, 213);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(102, 83);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // FrmExportToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 663);
            this.Controls.Add(this.gbProjectData);
            this.Controls.Add(this.gbProjectMaterial);
            this.Controls.Add(this.gbStorageMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExportToProject";
            this.Text = "FrmExportToProject";
            this.gbStorageMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbProjectMaterial.ResumeLayout(false);
            this.gbProjectMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbProjectData.ResumeLayout(false);
            this.gbProjectData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbStorageMaterial;
        private GroupBox gbProjectMaterial;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private Button btnReturnFinishing;
        private Button btnReturnProduction;
        private DataGridView dataGridView3;
        private Button btnProduction;
        private Button btnFInishing;
        private Label label2;
        private GroupBox gbProjectData;
        private DataGridView dataGridView4;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnDone;
    }
}