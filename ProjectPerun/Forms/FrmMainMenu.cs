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
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }
        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            btnStorage.Enabled = (Global.userRole == "WORKER") ? false : true;
            btnProduction.Enabled = (Global.userRole == "STORAGE") ? false : true;
            //btnConfiguration.Enabled = (Global.userRole == "ADMIN") ? true : false;
            btnManagment.Enabled = (Global.userRole == "WORKER" || Global.userRole == "STORAGE") ? false : true;
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStorageMenu2 frmStorageMenu = new FrmStorageMenu2();
            frmStorageMenu.ShowDialog();
            this.Show();

        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FrmProduction frmProduction = new FrmProduction();
            frmProduction.Show();
            //this.Show();
        }

        private void btnManagment_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmManagmentMenu frmManagment = new FrmManagmentMenu();
            frmManagment.ShowDialog();
            this.Show();
        }


    }
}
