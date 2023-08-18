﻿using System.Windows.Forms;
namespace ProjectPerunDesktop.Forms
{
    partial class FrmNewWorker
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
            this.tbHourRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPasswordRepeat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbHourRate
            // 
            this.tbHourRate.Location = new System.Drawing.Point(169, 176);
            this.tbHourRate.Name = "tbHourRate";
            this.tbHourRate.Size = new System.Drawing.Size(208, 27);
            this.tbHourRate.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Hour Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Role:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(169, 29);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(208, 27);
            this.tbUsername.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Username:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(169, 62);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(208, 27);
            this.tbName.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Name:";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(169, 95);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(208, 27);
            this.tbSurname.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Surname:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(169, 222);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(208, 27);
            this.tbPassword.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Password:";
            // 
            // tbPasswordRepeat
            // 
            this.tbPasswordRepeat.Location = new System.Drawing.Point(169, 255);
            this.tbPasswordRepeat.Name = "tbPasswordRepeat";
            this.tbPasswordRepeat.PasswordChar = '*';
            this.tbPasswordRepeat.Size = new System.Drawing.Size(208, 27);
            this.tbPasswordRepeat.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(37, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "Repeat Pass:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(37, 349);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(340, 39);
            this.btnCreate.TabIndex = 47;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(169, 128);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(208, 28);
            this.cbRole.TabIndex = 48;
            // 
            // FrmNewWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbPasswordRepeat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHourRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label1);
            this.Name = "FrmNewWorker";
            this.Text = "FrmNewWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbHourRate;
        private Label label5;
        private Label label4;
        private TextBox tbUsername;
        private Label label1;
        private TextBox tbName;
        private Label label2;
        private TextBox tbSurname;
        private Label label3;
        private TextBox tbPassword;
        private Label label6;
        private TextBox tbPasswordRepeat;
        private Label label7;
        private Button btnCreate;
        private ComboBox cbRole;
    }
}