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
    public partial class FrmCreateProject : Form
    {
        DSMaterialData dsMaterialData = new DSMaterialData();
        DSProjectMaterials dsProjectMaterials = new DSProjectMaterials();
        DSProjects dsProjects = new DSProjects();
        int projectID = 0;
        int materialID = 0;
        public FrmCreateProject()
        {
            InitializeComponent();
        }

        private void FrmCreateProject_Load(object sender, EventArgs e)
        {
            cbDepartment.Items.Clear();
            cbDepartment.Items.Add("PRODUCTION");
            cbDepartment.Items.Add("FINISHING");
            cbDepartment.SelectedIndex = cbDepartment.FindStringExact("PRODUCTION");

            dsMaterialData.MaterialData.Merge(MaterialDataService.GetMaterialData());
            grdAll.DataSource = dsMaterialData.MaterialData;
            grdSelected.DataSource = dsProjectMaterials.ProjectMaterials;

            //dsProjects.Projects.Merge(ProjectService.GetProjectData());
            //cbProjects.DataSource = dsProjects.Projects;
            //cbProjects.DisplayMember = "Name";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //DODAVANJE U TABLICU
            //KREIRAT NOVI DS S QUANT; DEPART; DODAT ELE IZ DESNE U NJEGA I MAKNIT IZ ELE; REFRESH ALL

            if(tbMaterialCode.Text.StartsWith("M") && cbDepartment.Text == "PRODUCTION")
            {
                MessageBox.Show("Other materials can't go on machine production!");
                return;
            }

            if(string.IsNullOrEmpty(tbMaterialQuantity.Text))
            {
                MessageBox.Show("Can't add material without quantity!");
                return;
            }

            var newRow = dsProjectMaterials.ProjectMaterials.NewProjectMaterialsRow();
            newRow["ID"] = 0;
            newRow["ProjectID"] = 0;
            newRow["MaterialID"] = materialID;
            newRow["MaterialType"] = tbMaterialType.Text;
            newRow["Quantity"] = tbMaterialQuantity.Text;
            newRow["TimeStamp"] = DateTime.Now;
            newRow["UserID"] = Global.userID;
            newRow["Department"] = cbDepartment.Text;
            newRow["MaterialCode"] = tbMaterialCode.Text;

            if(dsProjectMaterials.ProjectMaterials.Any(ID => ID.Field<Int64>("ID") == materialID))
            {
                MessageBox.Show("Already exists in separated material table!");
                return;
            }

            dsProjectMaterials.ProjectMaterials.AddProjectMaterialsRow(newRow);
            var oldRow = dsMaterialData.MaterialData.Where(ID => ID.Field<Int64>("ID") == materialID);
            dsMaterialData.MaterialData.RemoveMaterialDataRow(oldRow.First());
            ClearMaterialFields();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (grdSelected.SelectedRows.Count != 0)
            {
                var newRow = dsMaterialData.MaterialData.NewMaterialDataRow();
                var selectedRow = grdSelected.SelectedRows[0];
                newRow["ID"] = selectedRow.Cells[3].Value.ToString();
                newRow["Code"] = selectedRow.Cells[1].Value.ToString();
                newRow["MaterialType"] = selectedRow.Cells[5].Value.ToString();
                newRow["TimeStamp"] = DateTime.Now;
                newRow["UserID"] = Global.userID;
                newRow["Description"] = "";
                newRow["Active"] = true;
                dsMaterialData.MaterialData.AddMaterialDataRow(newRow);

                var oldRow = dsProjectMaterials.ProjectMaterials
                             .Where(Material => Material.Field<Int64>("MaterialID") == int.Parse(selectedRow.Cells[3].Value.ToString()));
                dsProjectMaterials.ProjectMaterials.RemoveProjectMaterialsRow(oldRow.First());
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //SLANJE U BAZU
            DSProjects newProject = new DSProjects();
            var newRow = newProject.Projects.NewProjectsRow();
            newRow["ID"] = 0;
            newRow["Name"] = tbProjectName.Text;
            newRow["Company"] = tbProjectCompany.Text;
            newRow["Description"] = rtbProjectDescription.Text;
            newRow["TimeStamp"] = DateTime.Now;
            newRow["UserID"] = Global.userID;
            newRow["Active"] = true;
            newProject.Projects.AddProjectsRow(newRow);

            var response = ProjectService.InsertProjectData(newProject, dsProjectMaterials);

            if (response.Success)
            {
                MessageBox.Show("New project " + tbProjectName.Text + " is inserted.");
                ClearMaterialFields();
                ClearProjectFields();
            }
            else
            {
                MessageBox.Show("ERROR: " + response.Error);
            }


        }

        private void grdAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdAll.SelectedRows.Count != 0)
            {
                var selectedRow = grdAll.SelectedRows[0];
                materialID = int.Parse(selectedRow.Cells[0].Value.ToString());
                tbMaterialCode.Text = selectedRow.Cells[1].Value.ToString();
                tbMaterialType.Text = selectedRow.Cells[2].Value.ToString();
            }
        }

        private void ClearMaterialFields()
        {
            tbMaterialCode.Clear();
            tbMaterialType.Clear();
            tbMaterialQuantity.Clear();
            cbDepartment.SelectedIndex = cbDepartment.FindStringExact("PRODUCTION");
            materialID = 0;
        }
        
        private void ClearProjectFields()
        {
            tbProjectName.Clear();
            tbProjectCompany.Clear();
            rtbProjectDescription.Clear();

            dsProjectMaterials.ProjectMaterials.Clear();
            dsProjects.Clear();
            dsMaterialData.Clear();
            dsMaterialData.MaterialData.Merge(MaterialDataService.GetMaterialData());
        }

    }
}
