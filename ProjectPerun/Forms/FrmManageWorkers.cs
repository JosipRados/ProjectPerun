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
    public partial class FrmManageWorkers : Form
    {
        public FrmManageWorkers()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //MIJENJAMO PODATKE O RADNIKU
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //OTVARAMO FORMU I KREIRAMO NOVOG RADNIKA
            FrmNewWorker frmNewWorker = new FrmNewWorker();
            frmNewWorker.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //OTVARAMO FORMU ZA IZMJENU ŠIFRE
            FrmChangePassword frmNewPassword = new FrmChangePassword();
            frmNewPassword.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //POSTAVLJAMO RADNIKA U NEAKTIVNO
        }

        private void btnRefreshShifts_Click(object sender, EventArgs e)
        {
            //PRIKAZUJEMO SMJENE NA TEMELJU POLJA
        }
    }
}
