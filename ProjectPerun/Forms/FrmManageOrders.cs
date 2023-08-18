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
    public partial class FrmManageOrders : Form
    {
        public FrmManageOrders()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //POZIVAMO FORMU I KREIRAMO NARUDZBU ZATIN REFRESHAMO LISTU
            FrmNewOrder frmNewOrder = new FrmNewOrder();
            frmNewOrder.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //PODATKE KOJE SMO IZMJENILI U KUCICAMA SPREMAMO NA ID KOJI JE OZNACEN U GRIDU
            //UPDATE RADI SAMO UPDATE DIREKTNO NAD IDom
        }

        private void btnMarkFinished_Click(object sender, EventArgs e)
        {
            //PROVJERAVAMO DA LI PROJEKT IMA ODVOJEN MATERIJAL
            //AKO JE MATERIJAL ODVOJEN I DOBILI SMO INFORMACIJU DA JE PROJEKT DOVRSEN STAVLJAMO FLAG NA DOVRSENO
            //KASNIJE MOZEMO IMAT DORADU I PROIZVODNJU DI SVAKO MOZE STAVIT SVOJ SEGMENT KAO GOTOVO
            //OVO NAN OZNACAVA DA JE SVE GOTOVO I DA MOZEMO RACUNATI CIJENU
            //CIJENA SE IZRACUNAVA ODMAH PO FINISHINGU I REFRESHA SE LISTA UKLJUCUJUCI I OVAJ PROJEKT
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //BRISANJE PROJEKTA JE MOGUCE SAMO AKO NEMA ODVOJENOG MATERIJALA I AKO NIJE ZAVRSEN
            //POSTOJI RADI JEDNE STVARI AKO JE KREIRANO SLUCAJNO KRIVO U SAMOM STARTU
            //AKO JE PROJEKT KREIRAN I ODVOJIO SE MATERIJAL TADA SE PROJEKT MORA DEAKTIVIRATI PREKO ADMINISTRATORA
            //ZA SADA JE OVO OVAKO ZBOG KOMPLIKACIJE VRACANJA MATERIJALA NAZAD NA SKLADISTE PREVISE POSLA
        }

        private void btnRefreshShifts_Click(object sender, EventArgs e)
        {
            //UZIMA RADIO BOTUN I HVATA PODATKE IZ BAZE NA TEMELJU NJEGA
        }

        private void btnRefreshOrders_Click(object sender, EventArgs e)
        {
            //UZIMA RADIO BOTUN I HVATA PODATKE IZ BAZE NA TEMELJU NJEGA
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            //OTVARA FORMU S DETALJIMA SMJENE KOJA UKLJUCUJE I RADNIKE KOJI SU RADILI U SMJENI
            FrmOrderShiftDetails frmOrderShiftDetails = new FrmOrderShiftDetails();
            frmOrderShiftDetails.Show();
        }

        private void btnShowMaterials_Click(object sender, EventArgs e)
        {
            //OTVARA FORMU U KOJOJ SE NALAZI SAMO TABLICA KOJA PRIKAZUJE SVE ELEMENTE KOJI SU SKINUTI ZA PROJEKT I NJIHOVO STANJE
            //MOZDA STAVIT NESTO STA CE RAZLIKOVAT POTROSENO I VRACENO NA SKLADISTE AL ZA SADA NIJE POTRIBNO
            FrmOrderShowMaterials frmOrderShowMaterials = new FrmOrderShowMaterials();
            frmOrderShowMaterials.Show();
        }
    }
}
