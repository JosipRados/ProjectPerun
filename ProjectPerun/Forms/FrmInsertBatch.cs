using ProjectPerun.DataSets;
using ProjectPerun.Services;
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
    public partial class FrmInsertBatch : Form
    {
        DSWarehouse dsWarehouses = new DSWarehouse();
        DSBatchData dsBatch = new DSBatchData();
        DSTransactionStorage dsImport = new DSTransactionStorage();
        int newBatchNumber;
        int materialNumber;
        public FrmInsertBatch()
        {
            InitializeComponent();
        }

        private void FrmInsertBatch_Load(object sender, EventArgs e)
        {
            var responseBatch = BatchService.GetNewBatchID();
            if (responseBatch == null || responseBatch.Rows.Count <= 0)
            {
                MessageBox.Show("Couldn't load new batch number, please try to close and opet window again.");
                return;
            }
            else
            {
                newBatchNumber = int.Parse(responseBatch.Rows[0]["BatchNumber"].ToString());
                tbBatchNumber.Text = newBatchNumber.ToString();
            }

            var responseWarehouse = WarehouseService.GetWarehouseData();
            if (responseWarehouse == null || responseWarehouse.Rows.Count <= 0)
            {
                MessageBox.Show("Couldn't load Warehouses, please try to close and opet window again.");
                return;
            }
            else
                dsWarehouses.Warehouse.Merge(responseWarehouse);

            var responseMaterialNumber = StorageService.GetLastMaterialNumber();
            if (responseMaterialNumber == null || responseMaterialNumber.Rows.Count <= 0)
            {
                MessageBox.Show("Couldn't load new batch number, please try to close and opet window again.");
                return;
            }
            else
            {
                materialNumber = int.Parse(responseMaterialNumber.Rows[0]["MaterialNumber"].ToString());
                tbNumber.Text = materialNumber.ToString();
            }
                
            
        }

        private void brnGetData_Click(object sender, EventArgs e)
        {
            //DOHVAT PODATAKA O BATCHU (DODAT BATCH I WAREHOUSE TABLICE)
            //KADA KORISTIMO EXISTING BATCH BLOKIRAMO SVA POLJA OSIN BATCH ID-a
            //KADA SE UPIŠE ID TREBA SE KLIKNUTI GET DATA DA BI SE POPUNILA OSTALA
            //TIME SPRIJEČAVAMO DA SE UNESE NEKAKAV BATCH ID KOJI NE POSTOJI
            //KASNIJE GLEDAN DA SU SVA POLJA POPUNJENA KADA ŠALJEMO INAĆE NEVALJA
            //JEDINO KAKO SE MOGU POPUNITI JE DA KLIKNEMO NEW BATCH I POPUNIMO SAMI
            //BATCHID CE SE SAM GENERIRATI DOK BROJ PAKETA MORAM UBACITI U CONFIG TABLICU
            //DODATI BROJ PAKETA U TABLICE ZA MATERIJAL
            //KADA SE VRATE PODATCI KOJI NEVALJAJU MOZEMO ZATVORITI OVU FORMU I OTVORIT ISTU NOVU
            //POSTAVIT SAMO DS KOJI POKAZUJE PODATKE U GRIDU I REC DA TI PODATCI NEVALJAJU I TREBA IH ISPRAVIT
            //NAPISAT NEKU PORUKU GREŠKE DA SE ZNA STA JE KRIVO I ONDA DAT NA ISPRAVAK
            //MOZDA STAVIT NEKAKAV TEXT BOX KOJI JE ONLY READ I VISIBLE KADA POSTOJI NESTO U VARIJABLI TXTGRESKA
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //DODAJU SE PODATCI U LOKALNI DS KOJI SE PRIKAZUJE U DESNOM GRIDU
            //AKO NEŠTO NE ŠTIMA S PODATCIMA IZBACI SE TXTBOX I NAKON TOGA VRATIMO NAZAD
            //KADA SE ISPRAVI ONDA NAPUNIMO DS S PODATCIMA I REFRESHAMO GRID
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //KADA SE ZAVRŠI S DODAVANJEM PODATAKA U DS RADI SE IMPORT U BAZU
            //POZIVAJU SE PROCEDURE ZA IMPORT I VRAĆAJU PODATKE KOJI SU KRIVI
            //NAPRAVIT PROVJERU AKO JE SVE OK ONDA SE VRAĆA NA FORMU SKLADISTE 
            //AKO NIJE SVE OK OSTAJE OVA FORMA OTVORENA S PODATCIMA KOJI JESU SAMO SE DS MIJENJA
            //MISLIN DA BI TRIBALO BIT OK NAMISTIT TO AKO VRATIN IDENTICNE PODATKE KOJE SAN POSLA

            foreach(var row in dsImport.TransactionTable)
            {
                row.BatchID = newBatchNumber;
                row.TransactionType = "IMPORT";
            }
        }

        private void rbNewBatch_Click(object sender, EventArgs e)
        {
            tbBatchNumber.ReadOnly = true;
            tbSender.ReadOnly = false;
            tbDate.ReadOnly = false;
            ClearBatchFields();
            tbBatchNumber.Text = newBatchNumber.ToString();
        }

        private void rbExistingBatch_Click(object sender, EventArgs e)
        {
            tbBatchNumber.ReadOnly = false;
            tbSender.ReadOnly = true;
            tbDate.ReadOnly = true;
            ClearBatchFields();
        }

        private void ClearBatchFields()
        {
            tbBatchNumber.Clear();
            tbSender.Clear();
            tbDate.Clear();
        }


    }
}
