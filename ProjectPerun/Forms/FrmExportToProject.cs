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
    public partial class FrmExportToProject : Form
    {
        public FrmExportToProject()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            //DODAJ MATERIJAL U PRODUKCIJSKU TABLICU
            //KADA SE IMPORTIRA ONDA SE PUNE OBE U UPDATE SAMO SE STAVLJAJU RAZLICITI FLAGOVI
        }

        private void btnFInishing_Click(object sender, EventArgs e)
        {
            //DODAJ MATERIJAL NA FINISHING
            //KAO I GORE DRUGI FLAG
        }

        private void btnReturnProduction_Click(object sender, EventArgs e)
        {
            //SAMO MICE IZ TABLICE ELEMENT I VRACA GA U GORNJU
            //NISAN ISA ZA TIME TREBA NEKAKO MAKNUTI ODMA ELEMENT IZ GORNJE DA SE NE PRIKAZUJE
            //NISAN SIGURAN KAKO TO IZVESTI, MOZDA TAKO DA DOHVATIM SAV MATERIJAL KOJI IDE NA PRIJEKT POTENCIJALNO
            //I NJEGA PAGINIRAT ILI NE PAGINIRAT UOPCE NEGO MICAT I DODATAVT IZ TABLICE
            //TAKO BI BILO NAJLAKSE A I NEBI TRIBALO BIT PRETJERANO PUNO RECORDA AKO NIJE CILO SKLADISTE TU
        }

        private void btnReturnFinishing_Click(object sender, EventArgs e)
        {
            //KAO I GORE SAMO ZA FINISHING
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //S OVIM BOTUNOM SMO ZAVRSILI ODVAJANJE MATERIJALA
            //RADE SE DVI RADNJE
            //PRVA RADNJA JE UPDATE STORAGE TABLICE PRIKO TRANSAKCIJSKE
            //DRUGA RADNJA JE SLANJE U TABLICU ORDER_STORAGE PODATKE O MATERIJALU
            //SALJE SE KOD; NAZIV; JEL DORADA IL PROIZVODNJA ITD I ZAPISUJE SE TAMO
        }
    }
}
