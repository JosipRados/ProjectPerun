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
    public partial class FrmManageProjectData : Form
    {
        public FrmManageProjectData()
        {
            InitializeComponent();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //MOZEMO PROMJENITI NEKE INFORMACIJE O PROJEKTU; UPDATE JE SAMO ZA PROMJENU INFORMACIJA O PROJEKTU
            //ISTO TAKO MOGU NAPRAVT NEKAKAV INSERT I MATERIJALA LOKALNO PRVO PA ONDA CJELOKUPNI UPDATE AL ZA SADA NE
            //NAJVJEROJATNIJE BI TO ISLO NA NACIN DA POBRISEN SVE RECORDE U TABLICI I DODAN SVE NOVE JEDNOSTAVNIJE JE
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //BRISEMO PROJEKT
            //RETROAKTIVNO MORAMO BRISATI I SVE MATERIJALE ZA PROJEKT KAD BI SVE BRISALI
            //ZATO SAMO DEAKTIVIRAN PROJEKT
            //MOZDA UVEST MOGUCNOST DA ADMIN MOZE AKTIVIRATI NAZAD PROJEKTE
            //ADMIN JE ZADUZEN ZA ISPRAVLJANJE GRESAKA IPAK
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //OTVARAN NOVU FORMU KOJA SADRZI LISTU SVIH MATERIJALA KOJI NISU VEC NA PROJEKTU
            //IZ LISTE OZNACAVAMO MATERIJAL KOJI DODAJEMO I UPISUJEMO KOLICINU
            //KLIKOM DODAJ DODAJE SE U LOKALNU TABLICU I U BAZU
            FrmNewProjectMaterial frmNewProjectData = new FrmNewProjectMaterial();
            frmNewProjectData.Show();
        }
    }
}
