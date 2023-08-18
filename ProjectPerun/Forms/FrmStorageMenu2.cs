using System;
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
    public partial class FrmStorageMenu2 : Form
    {
        private Form activeForm = null;
        public FrmStorageMenu2()
        {
            InitializeComponent();
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmStorage());
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panForm.Controls.Add(childForm);
            panForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnInsertBatch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmInsertBatch());
        }

        private void btnElementData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmManageMaterialData());
        }

        private void btnExportProject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmExportToProject());
        }

        private void btnImportFromProject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmImportFromProject());
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCheckAvailability());
        }

        private void FrmStorageMenu2_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLogo());
        }
    }
}
