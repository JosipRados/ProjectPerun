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
    public partial class FrmManageMaterialData : Form
    {
        public FrmManageMaterialData()
        {
            InitializeComponent();
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            //BRISE MATERIJAL IZ TABLICE
            //U BAZI GA POSTAVLJA NA NEAKTIVNO
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //PROMJENJENE PODATKE VRACA NA ID I RADI UPDATE NAD PODATCIMA POD TIM IDOM
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //OTVARA NOVU FORMU ZA UNOS NOVOG MATERIJALA
            //UNOSE SE SVI PODATCI I VRACA NAZAD STA JE UNESENO
            //NAKON SVIH OPERACIJA JE POTREBNO NAPRAVIT UPDATE NAD LOKALNOM EVENTUALNO CACHERANON TABLICON
            FrmNewMaterialData frmNewMaterialData = new FrmNewMaterialData();
            frmNewMaterialData.Show();
        }
    }
}
