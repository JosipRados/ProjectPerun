using ProjectPerun.DataSets;
using ProjectPerun.Models;
using ProjectPerunDesktop.DataCalls;

using ProjectPerunDesktop.Models;
using ProjectPerunDesktop.Services;
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
    public partial class FrmStorage : Form
    {
        DSStorage dsStorage = new DSStorage();
        public FrmStorage()
        {
            InitializeComponent();
        }
        private void FrmStorage_Load(object sender, EventArgs e)
        {
            var table = StorageService.GetStorageData();
            //table.TableName = "Storage";
            //dsStorage.Storage.Merge(StorageService.GetStorageData());
            try
            {
                dsStorage.Storage.Merge(table);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            grdStorage.DataSource = dsStorage.Storage;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //UZIMA SVE UPISANE PODATKE I RADI POZIV NA BAZU DA VRATI SAMO TE ELEMENTE
            //STRANICA POSTAJE 1 I PONOVO KAD SE RADI POZIV RADI SE NA ISTI NACIN KAO I SVE
            //AKO NEMA NIŠTA I OZNACENO JE ALL ONDA SE RADI POZIV NAD SVIM, TO SE DOGAĐA KADA TEK OTVARAMO
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //UZIMA SE SELEKTIRANI RECORD U TABLICI I OTVARA SE PROZOR ZA IZMJENU PODATAKA
            //SAVE CHANGES U PROZORU POZIVA UPDATE NAD TIM ELEMENTOM S SVOJIM IDom I BROJEM PAKETA/MATERIJALA
            
            FrmUpdateMaterial frmUpdateMaterial = new FrmUpdateMaterial();
            frmUpdateMaterial.selectedRow = GetSelectedData();
            frmUpdateMaterial.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //DODAVANJE NOVOG ELEMENTA, ALI SAMO JEDNOG
            //DOZVOLJENO ZA SPECIFIČNE SLUČAJEVE KADA SE NESTO IZBRISE
            //AKO GA DODAJEMO ZA BATCHID SE UPISUJE NESTO GENERICNO TIPA 0 TIME ZNAMO DA NIJE DODAN U BATCHU NEGO DIREKTNO
            //U DESCRIPTION MOZEMO DODATI RAZLOG
            //DA LI TREBA POZIVATI SVE ELEMENTE SVAKI PUT ILI MOGU NAPRAVIT NEKI CACHE KOJI CE IMAT PRILIKOM POKRETANJA SVE
            //TIME UBRZAVAMO UPIS I VEZANJE S ODREĐENIM ELEMENTOM KADA UPISUJEMO NOVI AKO IH IMAN CHACHIRANO U PROGRAMU
            //JOS SE MALO POZABAVIT TIME; ASINKRONI POZIV PRILIKOM PALJENJA DA NAPUNI NEKI CACHE SVIM RECORDIMA
            new FrmAddNewMaterial().ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //BRISANJE ELEMENTA SE VRŠI TAKO DA SE POSTAVLJA FLAG REMOVED NA 1
            //PAZIT DA PRILIKOM POZIVA STALNO GLEDAMO SAMO ELEMENTE KOJI SU REMOVED 0
            //ADMIN MOZDA MOZE IMAT PREGRED SVIH REMOVED ELEMENATA ILI POWERUSER DUNNO I IMAT OPCIJU ZA UNREMOVAT IH AKO JE ERR.
            new FrmDeleteMaterial().ShowDialog();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //UZIMAJU SE LOKALNI PODATCI PRETRAGE, KADA GLEDAMO SEARCH U FORMI OSTAJU ZAPAMCENI PODATCI; NE NANOVO IZ KUTIJA
            //STRANICA SE DIZE ZA 1 I SALJE SE SVE TO SKUPA U BAZU KOJA VRACA NOVI BATCH 
            //IMAT NEGDI NEKU PROVJERU ZA MAX BROJ STRANICA TO MOZDA S PRVIM POZIVOM VRATIMO, S SVAKIM PONOVNO ZAPRAVO
            //AKO JE TRENUTNA STRANICA JEDNAKA MAX BROJU STRANICA ONDA OVU DESNU STRELICU STAVLJAMO KAO NEMOŽE
            //ISTO TAKO S PRVIM POZIVOM AKO JE STRANICA 1 ONDA STAVLJAMO LIVU STRELICU NEMOZE, PROVJERAVAMO OBOJE STALNO
        }

        private DataGridViewRow GetSelectedData()
        {
            MaterialDataModel materialData = new MaterialDataModel();
            if (grdStorage.SelectedRows.Count != 0)
            {
                return grdStorage.SelectedRows[0];
                //DataGridViewRow selectedRow = grdStorage.SelectedRows[0];
                ////materialData.ID = selectedRow.Cells[0].Value.ToString();
                ////materialData.Number = selectedRow.Cells[1].Value.ToString();
                ////materialData.Code = selectedRow.Cells[2].Value.ToString();
                ////materialData.Name = selectedRow.Cells[3].Value.ToString();
                ////materialData.Quantity = selectedRow.Cells[5].Value.ToString();
                ////materialData.Price = selectedRow.Cells[6].Value.ToString();
                ////materialData.Type = selectedRow.Cells[8].Value.ToString();
                ////materialData.WarehouseID = selectedRow.Cells[9].Value.ToString();
                ////materialData.OnProject = bool.Parse(selectedRow.Cells[17].Value.ToString());
                ////materialData.ProjectID = selectedRow.Cells[18].Value.ToString();
                ////materialData.Reserved = bool.Parse(selectedRow.Cells[14].Value.ToString());
                //IEnumerable<MaterialDataModel> data = selectedRow.Cells.Cast<MaterialDataModel>();
                //return materialData;

                

                //if (selectedRow.Cells[4].Value.ToString().ToLower() == "false")
                //    cbAdministrator.Checked = false;
                //else
                //    cbAdministrator.Checked = true;

                //if (selectedRow.Cells[5].Value.ToString().ToLower() == "false")
                //    cbDjelatnik.Checked = false;
                //else
                //    cbDjelatnik.Checked = true;
            }
            return null;
        }


    }
}
