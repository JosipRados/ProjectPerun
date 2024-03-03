using ProjectPerun.DataSets;
using ProjectPerun.Services;
using ProjectPerunDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPerunDesktop.Forms
{
    public partial class FrmNewMaterialData : Form
    {
        internal DSMaterialData newMaterialData = new DSMaterialData();
        internal APIResponseModel response = new APIResponseModel();
        public FrmNewMaterialData()
        {
            InitializeComponent();
        }
        private void FrmNewMaterialData_Load(object sender, EventArgs e)
        {
            cbMaterialType.Items.Add("ELEMENT");
            cbMaterialType.Items.Add("OTHER");
            cbMaterialType.SelectedIndex = cbMaterialType.FindStringExact("ELEMENT");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //ŠALJU SE PODATCI O MATERIJALU U BAZU
            //ISTI PODATCI SE VRACAJU NAZAD
            //VIDIT KAKO PROVJERIT STA JE VRACENO I NAMISTIT VRACANJE TAKO DA SE ZNA REFRESHAT TABLICA S MATERIJALIMA U DONJOJ
            if (cbMaterialType.Text == "OTHER" && !tbMaterialCode.Text.StartsWith("M"))
            {
                MessageBox.Show("Material code has to start with letter M!");
                return;
            }

            if (cbMaterialType.Text == "ELEMENT" && tbMaterialCode.Text.StartsWith("M"))
            {
                MessageBox.Show("Element code can't start with letter M!");
                return;
            }

            if(string.IsNullOrEmpty(tbMaterialCode.Text))
            {
                MessageBox.Show("Material code shouldn't be empty!");
                return;
            }

            var row = newMaterialData.MaterialData.NewMaterialDataRow();
            row["ID"] = 0;
            row["Code"] = tbMaterialCode.Text;
            row["MaterialType"] = cbMaterialType.Text;
            row["Description"] = rtbDescription.Text;
            row["UserID"] = Global.userID;
            row["Active"] = true;
            row["TimeStamp"] = DateTime.Now;
            newMaterialData.MaterialData.AddMaterialDataRow(row);

            response = MaterialDataService.InsertMaterialData(newMaterialData);

            if(response.Success == false)
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
            else
            {
                newMaterialData.MaterialData.FirstOrDefault().ID = long.Parse(response.Data.Rows[0][0].ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}
