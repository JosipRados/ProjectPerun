using ProjectPerun.Models;
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
    public partial class FrmUpdateMaterial : Form
    {
        internal DataGridViewRow selectedRow;
        public FrmUpdateMaterial()
        {
            InitializeComponent();
        }
        private void FrmUpdateMaterial_Load(object sender, EventArgs e)
        {
            if (selectedRow == null)
                this.Close();

            tbName.Text = selectedRow.Cells[0].Value.ToString();
            tbPrice.Text = selectedRow.Cells[0].Value.ToString();
            tbProject.Text = selectedRow.Cells[0].Value.ToString();
            tbQuantity.Text = selectedRow.Cells[0].Value.ToString();
            tbWarehouse.Text = selectedRow.Cells[0].Value.ToString();
            tbNumber.Text = selectedRow.Cells[0].Value.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MOGU SE MINJAT SAMO PRVA 4 POLJA I TO U ODNOSU NA TO JEL ELEMENT ILI MATERIJAL
            //DODAVANJE DA LI JE NA PROJEKTU ILI NIJE IDE KROZ DRUGI PROCES
            //OVDJE TE INFORMACIJE POSTOJE SAMO RADI PRIKAZA DA SE ZNA DA LI SE MOŽE MIJENJATI
            //MOŽDA NAPRAVITI AKO JE MATERIJAL NA PROJEKTU DA SE NE PRIKAZUJE CAK U TABLICI
            //ILI GA PRIKAZATI I OZNACITI DA JE NA PROJEKTU ALI SE ONDA NE MOŽE RADITI UPDATE
            //SVEJEDNO OTVORITI PROZOR
            //IZBACITI MSG BOX DA JE NA PROJEKTU I ONDA PRIKAZATI PROZOR NA KOJEM NE MOZES RADITI IZMJENE
        }


    }
}
