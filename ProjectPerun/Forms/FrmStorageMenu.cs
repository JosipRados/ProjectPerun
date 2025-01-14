﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPerunDesktop.Forms
{
    public partial class FrmStorageMenu : Form
    {
        private Form activeForm = null;
        public FrmStorageMenu()
        {
            InitializeComponent();
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            scMenuForm.Panel2.Controls.Add(childForm);
            scMenuForm.Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmStorage());
        }
    }
}
