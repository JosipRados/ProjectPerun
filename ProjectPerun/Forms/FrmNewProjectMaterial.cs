using ProjectPerun.DataSets;
using ProjectPerun.Services;
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
    public partial class FrmNewProjectMaterial : Form
    {
        DSMaterialData dsMaterialData = new DSMaterialData();
        internal DSProjectMaterials dsNewProjectMaterial = new DSProjectMaterials();
        internal DSProjectMaterials dsSelectedMaterials = new DSProjectMaterials();
        int materialID = 0;
        internal int projectID;
        public FrmNewProjectMaterial()
        {
            InitializeComponent();
        }

        private void FrmNewProjectMaterial_Load(object sender, EventArgs e)
        {
            dsMaterialData.MaterialData.Merge(MaterialDataService.GetMaterialData());
            grdMaterials.DataSource = dsMaterialData.MaterialData;
            RemoveExistingMaterialsOnProjectFromMaterialData();
            cbDepartment.Items.Add("PRODUCTION");
            cbDepartment.Items.Add("FINISHING");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //INSERTIRAMO JEDAN NOVI ELEMENT
            //OVO JE SAMO ZA DODAVANJE KASNIJE ELEMENTA KADA JE PROJEKT KREIRAN
            //POSEBNA FORMA ZA KREIRANJE PROJEKTA FROM THE SCRATCH
            if (string.IsNullOrEmpty(tbQuantity.Text) || tbQuantity.Text == "0" || !int.TryParse(tbQuantity.Text, out int i))
            {
                MessageBox.Show("Quantity field is wrong!");
                return;
            }

            if (cbDepartment.Text == "PRODUCTION" && tbType.Text == "OTHER")
            {
                MessageBox.Show("Other materials that are not elements can't go on machine production!");
                return;
            }

            if(string.IsNullOrWhiteSpace(tbCode.Text) || string.IsNullOrWhiteSpace(tbType.Text))
            {
                MessageBox.Show("You have to select material from table!");
                return;
            }

            var newRow = dsNewProjectMaterial.ProjectMaterials.NewProjectMaterialsRow();
            newRow["ID"] = 0;
            newRow["ProjectID"] = 0;
            newRow["MaterialID"] = materialID;
            newRow["Quantity"] = tbQuantity.Text;
            newRow["MaterialType"] = tbType.Text;
            newRow["Department"] = cbDepartment.Text;
            newRow["TimeStamp"] = DateTime.Now;
            newRow["UserID"] = Global.userID;
            newRow["MaterialCode"] = tbCode.Text;
            dsNewProjectMaterial.ProjectMaterials.AddProjectMaterialsRow(newRow);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void grdMaterials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdMaterials.SelectedRows.Count != 0)
            {
                var selectedRow = grdMaterials.SelectedRows[0];
                tbCode.Text = selectedRow.Cells[1].Value.ToString();
                tbType.Text = selectedRow.Cells[2].Value.ToString();
                materialID = int.Parse(selectedRow.Cells[0].Value.ToString());
            }
        }

        private void RemoveExistingMaterialsOnProjectFromMaterialData()
        {
            foreach (var row in dsSelectedMaterials.ProjectMaterials)
            {
                dsMaterialData.MaterialData.RemoveMaterialDataRow(dsMaterialData.MaterialData.Where(material => material.Code == row.MaterialCode).First());
            }
        }
    }
}
