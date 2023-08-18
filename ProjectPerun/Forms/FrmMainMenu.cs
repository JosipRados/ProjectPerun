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

        private void btnStorage_Click(object sender, EventArgs e)
        {
            //OTVORI FORMU STORAGE MENU
            //ZATVORI MAIN MENU
            //POSTAVIT KADA SE STORAGE MENU ZATVORI DA SE MAIN MENU OTVORI
            this.Hide();
            FrmStorageMenu2 frmStorageMenu = new FrmStorageMenu2();
            frmStorageMenu.ShowDialog();
            this.Show();

        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            //OTVORI FORMU PRODUCTION MENU
            //ZATVORI MAIN MENU
            //KADA SE PRODUCTION ZATVORI MAIN MENU SE OTVARA
            //this.Hide();
            FrmProduction frmProduction = new FrmProduction();
            frmProduction.Show();
            //this.Show();
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            //CONFIGURATION JE ZA POWERUSERA
            //POWERUSER PRIPREMA NAZIVE ELEMENATA I NAZIVE PROJEKATA I SVE OSTALE PREDEFINIRANE STVARI
            //ADMIN U KONFIGURACIJI JOŠ IMA I KREIRANJE USERA I MJENJANJE ISTIH
            //SKLADIŠTAR I RADNIK SU RADNICI KOJI RADE SAMO U SMJENAMA I DODAVAJU MATERIJAL
            //UPITNO JE DA LI SKLADIŠTAR MOŽE IMATI MOGUČNOST DODAVANJA ELEMENATA U BAZU ELEMENATA
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
