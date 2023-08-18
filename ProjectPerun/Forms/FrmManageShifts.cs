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
    public partial class FrmManageShifts : Form
    {
        public FrmManageShifts()
        {
            InitializeComponent();
        }

        private void btnRefreshShifts_Click(object sender, EventArgs e)
        {
            //UZIMA PODATKE IZ POLJA I RADI POZIV NA BAZU NA TEMELJU NJIH
        }

        private void btnShowWorkers_Click(object sender, EventArgs e)
        {
            //ZA SELEKTIRANU SMJENU POKAZUJE RADNIKE; MOZDA POSTAVIT AKO KLIKNEMO ZA DRUGU SMJENU DA IH MAKNE IZ TABLICE
            //CISTO DA SE NE GLEDA SMJENA I RADNICI 
            //ALTERNATIVA JE SKUPLJANJE SVIH RADNIKA ZA SVE PRIKAZANE SMJENE I AUTOMATSKI REFRESH ALI TO MOZE ZAUZIMAT MEM
            //I POZIV MOZE TRAJAT DOSTA DUZE AKO SE UZME NPR CIJELA GODINA ZA PRIKAZ
            //TO MOZE BITI POLJE ZA PRIKAZ CIJELOKUPNOG IZVJESCA DI ONDA MOZEMO IMAT SVE SMJENE PO PRO ILI PO DAT
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //JOS VIDIT DA LI IMPLEMENTIRAT; AKO IMPLEMENTIRAN ONDA MOGU TU POKAZAT PODATKE O SMJENAMA
            //POSTAVIT UKUPNE SATE SMJENE; UKUPNE SATE RADNIKA NA SMJENAMA I BROJ SMJENA POJEDINIH RADNIKA
            //TIME MOZEMO IMAT PODATKE TKO JE KOLKO RADIA NA PROJEKTU ITD AKO FILTRIRAMO PO PROJEKTU
            //MOZE BIT KORISNA STVARCICA AKO STIGNEN IMPLEMENTIRAT
            //ISTO TAKO MOZE BIT SHOW SHIFT DI POKAZUJEN SAMO ZA SMJENU PODATKE; KOLKO JE TRAJALA KO JE RADIA NA CEMU ITD
        }
    }
}
