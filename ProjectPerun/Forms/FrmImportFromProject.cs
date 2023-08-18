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
    public partial class FrmImportFromProject : Form
    {
        public FrmImportFromProject()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            //OVIM BOTUNON DOHVACAMO PODATKE O NARUDZBI NA TEMELJU BROJA NARUDZBE
            //PODATCI SE NE MOGU MIJENJATI
            //NA TEMELJU ISFINISHED DOZVOLJAVA ILI NE IZMJENE
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //AKO JE ISFINISHED TRUE ONDA OVAJ BOTUN MOZEMO KORISTIT
            //MIJENJAMO KOLICINU NA POJEDINOM PAKETU MATERIJALA
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //AKO JE ISFINISHED TRUE ONDA OVAJ BOTUN MOZEMO KORISTIT
            //KADA PROMJENIMO SVE VELICINE ONDA VRACAMO MATERIJAL NA SKLADISTE
            //MOZDA PROMINIT U IMPORT; IPAK SE ZOVE IMPORT TO STORAGE
            //UPDATE NAD STORAGE TABLICOM
            //MOZDA ODUZET OD KOLICINE PAKETA I STAVIT U TABLICU STORAGE_ORDER KAO KOLICINA KOJA JE POTROSENA I STAVIT SPEND
        }
    }
}
