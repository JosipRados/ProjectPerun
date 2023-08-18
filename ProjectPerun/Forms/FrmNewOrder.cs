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
    public partial class FrmNewOrder : Form
    {
        public FrmNewOrder()
        {
            InitializeComponent();
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            //POZIVAMO PROVJERU DA LI U SKLADIŠTU IMA DOVOLJNO MATERIJALA
            //MOZEMO POZVAT VEC POSTOJECU FORMU
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            //AKO SMO PROVJERILI I SVE STIMA ONDA MOZEMO KREIRATI NARUDŽBU
            //PONOVNO SE REFRESHA LISTA
        }
    }
}
