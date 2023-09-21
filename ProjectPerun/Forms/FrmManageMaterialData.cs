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
    public partial class FrmManageMaterialData : Form
    {
        DSMaterialData dsMaterialData = new DSMaterialData();
        int selectedID = 0;

        public FrmManageMaterialData()
        {
            InitializeComponent();
        }

        private void FrmManageMaterialData_Load(object sender, EventArgs e)
        {
            cbMaterialType.Items.Clear();
            cbMaterialType.Items.Add("ELEMENT");
            cbMaterialType.Items.Add("OTHER");
            cbMaterialType.SelectedIndex = cbMaterialType.FindStringExact("ELEMENT");

            try
            {
                var table = MaterialDataService.GetMaterialData();
                dsMaterialData.MaterialData.Merge(table);
                grdMaterials.DataSource = dsMaterialData.MaterialData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DSMaterialData dsDeleteMaterialData = new DSMaterialData();            
            var row = dsDeleteMaterialData.MaterialData.NewMaterialDataRow();

            if(selectedID == 0 || string.IsNullOrEmpty(tbMaterialCode.Text))
            {
                MessageBox.Show("Material Data not selected!");
                return;
            }

            row["ID"] = selectedID;
            row["Code"] = tbMaterialCode.Text;
            row["MaterialType"] = cbMaterialType.Text;
            row["Description"] = rtbDescription.Text;
            row["UserID"] = Global.userID;
            row["Active"] = true;
            row["TimeStamp"] = DateTime.Now;
            dsDeleteMaterialData.MaterialData.AddMaterialDataRow(row);

            var response = MaterialDataService.DeleteMaterialData(dsDeleteMaterialData);

            if (response.Success == false)
            {
                MessageBox.Show("Error: " + response.Error);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Material succesfuly deleted.");
                var oldRow = dsMaterialData.MaterialData.Where(ID => ID.Field<Int64>("ID") == selectedID);
                dsMaterialData.MaterialData.RemoveMaterialDataRow(oldRow.First());
                ClearFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (grdMaterials.SelectedRows.Count != 0)
            {
                DSMaterialData dsUpdateMaterialData = new DSMaterialData();
                var selectedRow = grdMaterials.SelectedRows[0];
                var row = dsUpdateMaterialData.MaterialData.NewMaterialDataRow();

                if(cbMaterialType.Text == "OTHER" && !tbMaterialCode.Text.StartsWith("M"))
                {
                    MessageBox.Show("Other Material code has to start with letter M!");
                    return;
                }

                if (cbMaterialType.Text == "ELEMENT" && tbMaterialCode.Text.StartsWith("M"))
                {
                    MessageBox.Show("Element code can't start with letter M!");
                    return;
                }

                if (selectedID == 0)
                {
                    MessageBox.Show("Material Data not selected!");
                    return;
                }

                if (string.IsNullOrEmpty(tbMaterialCode.Text))
                {
                    MessageBox.Show("Material Code shouldn't be empty!");
                    return;
                }

                row["ID"] = selectedID;
                row["Code"] = tbMaterialCode.Text;
                row["MaterialType"] = cbMaterialType.Text;
                row["Description"] = rtbDescription.Text;
                row["UserID"] = Global.userID;
                row["Active"] = true;
                row["TimeStamp"] = DateTime.Now;
                dsUpdateMaterialData.MaterialData.AddMaterialDataRow(row);

                var response = MaterialDataService.UpdateMaterialData(dsUpdateMaterialData);

                if (response.Success == false)
                {
                    MessageBox.Show("Error: " + response.Error);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Material succesfuly updated.");
                    var oldRow = dsMaterialData.MaterialData.Where(ID => ID.Field<Int64>("ID") == selectedID);
                    dsMaterialData.MaterialData.RemoveMaterialDataRow(oldRow.First());
                    dsMaterialData.Merge(dsUpdateMaterialData);
                    ClearFields();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmNewMaterialData frmNewMaterialData = new FrmNewMaterialData();
            var result = frmNewMaterialData.ShowDialog();

            if (result == DialogResult.OK)
            {
                dsMaterialData.Merge(frmNewMaterialData.newMaterialData);
                ClearFields();
            }

            if (result == DialogResult.No)
            {
                MessageBox.Show("Error:" + frmNewMaterialData.response.Error);
                ClearFields();
            }
        }

        private void grdMaterials_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdMaterials.SelectedRows.Count != 0)
            {
                var selectedRow = grdMaterials.SelectedRows[0];

                selectedID = int.Parse(selectedRow.Cells[0].Value.ToString());
                tbMaterialCode.Text = selectedRow.Cells[1].Value.ToString();
                cbMaterialType.SelectedIndex = cbMaterialType.FindStringExact(selectedRow.Cells[2].Value.ToString());
                rtbDescription.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void ClearFields()
        {
            tbMaterialCode.Clear();
            cbMaterialType.SelectedIndex = cbMaterialType.FindStringExact("ELEMENT");
            rtbDescription.Clear();
            selectedID = 0;
        }
    }
}
