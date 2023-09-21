using ProjectPerun.DataSets;
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
    public partial class FrmOrderShowMaterials : Form
    {
        DSOrderStorage dsOrderStorage = new DSOrderStorage();
        internal int orderID;
        public FrmOrderShowMaterials()
        {
            InitializeComponent();
        }

        private void FrmOrderShowMaterials_Load(object sender, EventArgs e)
        {
            grdOrderStorage.DataSource = dsOrderStorage.OrderStorageTable;
            var response = StorageService.GetOrderMaterials(orderID);
            if (response == null || response.Rows.Count <= 0)
            {
                MessageBox.Show("Couldn't fetch materials for order, please try again");
                this.Close();
            }
            else
                dsOrderStorage.OrderStorageTable.Merge(response);
        }
    }
}
