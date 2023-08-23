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
    public partial class FrmManageProjectData : Form
    {
        DSProjects dsProjects = new DSProjects();
        DSProjectMaterials dsProjectMaterials = new DSProjectMaterials();
        int projectID = 0;
        int materialTableID = 0;
        public FrmManageProjectData()
        {
            InitializeComponent();
        }

        private void FrmManageProjectData_Load(object sender, EventArgs e)
        {
            cbDepartment.Items.Add("PRODUCTION");
            cbDepartment.Items.Add("FINISHING");
            dsProjects.Projects.Merge(ProjectService.GetProjectData());
            grdProjects.DataSource = dsProjects.Projects;
            grdMaterials.DataSource = dsProjectMaterials.ProjectMaterials;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //MOZEMO PROMJENITI NEKE INFORMACIJE O PROJEKTU; UPDATE JE SAMO ZA PROMJENU INFORMACIJA O PROJEKTU
            //ISTO TAKO MOGU NAPRAVT NEKAKAV INSERT I MATERIJALA LOKALNO PRVO PA ONDA CJELOKUPNI UPDATE AL ZA SADA NE
            //NAJVJEROJATNIJE BI TO ISLO NA NACIN DA POBRISEN SVE RECORDE U TABLICI I DODAN SVE NOVE JEDNOSTAVNIJE JE
            if (dsProjectMaterials == null || dsProjectMaterials.ProjectMaterials.Rows.Count <= 0)
            {
                MessageBox.Show("Have to load materials before the update!");
                return;
            }
            if (projectID == 0)
            {
                MessageBox.Show("Project is not selected!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbProjectName.Text) || string.IsNullOrWhiteSpace(tbProjectCompany.Text))
            {
                MessageBox.Show("Project Name or Company shouldn't be empty!");
                return;
            }

            DSProjects dsNewProject = new DSProjects();
            var row = dsNewProject.Projects.NewProjectsRow();
            FillDSProjectsRow(row);
            dsNewProject.Projects.AddProjectsRow(row);

            var response = ProjectService.UpdateProjectData(dsNewProject, dsProjectMaterials);
            if(response.Success == false)
            {
                MessageBox.Show("Project is not updated, ERROR: " + response.Error);
                return;
            }
            else
            {
                dsProjects.Projects.RemoveProjectsRow(dsProjects.Projects.Where(record => record.ID == projectID).First());
                row = dsProjects.Projects.NewProjectsRow();
                FillDSProjectsRow(row);
                dsProjects.Projects.AddProjectsRow(row);
                MessageBox.Show("Project successfuly updated.");
                ClearMaterialFields();
                ClearProjectFields();
                return;
            }
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
            FrmNewProjectMaterial frmNewProjectMaterial = new FrmNewProjectMaterial();
            frmNewProjectMaterial.dsSelectedMaterials.ProjectMaterials.Merge(dsProjectMaterials.ProjectMaterials);
            frmNewProjectMaterial.projectID = projectID;
            var result = frmNewProjectMaterial.ShowDialog();
            if(result == DialogResult.OK)
            {
                frmNewProjectMaterial.dsNewProjectMaterial.ProjectMaterials.Rows[0]["ProjectID"] = projectID;
                dsProjectMaterials.ProjectMaterials.Merge(frmNewProjectMaterial.dsNewProjectMaterial.ProjectMaterials);
                MessageBox.Show("Material succesfuly added.");
                return;
            }
            else if(result == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                MessageBox.Show("Material could not be added!");
                return;
            }
        }

        private void grdProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdProjects.SelectedRows.Count != 0)
            {
                var selectedRow = grdProjects.SelectedRows[0];
                tbProjectName.Text = selectedRow.Cells[1].Value.ToString();
                tbProjectCompany.Text = selectedRow.Cells[2].Value.ToString();
                rtbProjectDescription.Text = selectedRow.Cells[3].Value.ToString();
                projectID = int.Parse(selectedRow.Cells[0].Value.ToString());
                dsProjectMaterials.Clear();
            }
        }

        private void btnLoadMaterials_Click(object sender, EventArgs e)
        {
            dsProjectMaterials.Clear();
            dsProjectMaterials.ProjectMaterials.Merge(ProjectService.GetProjectMaterials(projectID));
        }

        private void grdMaterials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdMaterials.SelectedRows.Count != 0)
            {
                var selectedRow = grdMaterials.SelectedRows[0];
                tbMaterialCode.Text = selectedRow.Cells[3].Value.ToString();
                tbMaterialQuantity.Text = selectedRow.Cells[4].Value.ToString();
                tbType.Text = selectedRow.Cells[6].Value.ToString();
                cbDepartment.SelectedIndex = cbDepartment.FindStringExact(selectedRow.Cells[5].Value.ToString());
                materialTableID = int.Parse(selectedRow.Cells[0].Value.ToString());
            }

        }

        private void btnUpdateMaterial_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbMaterialQuantity.Text) || tbMaterialQuantity.Text == "0" || !int.TryParse(tbMaterialQuantity.Text, out int i))
            {
                MessageBox.Show("Quantity field is wrong!");
                return;
            }

            if(cbDepartment.Text == "PRODUCTION" && tbType.Text == "OTHER")
            {
                MessageBox.Show("Other materials that are not elements can't go on machine production!");
                return;
            }

            var row = dsProjectMaterials.ProjectMaterials
                      .Where(Material => Material.Field<Int64>("ID") == materialTableID).First();
            row["Quantity"] = tbMaterialQuantity.Text;
            row["Department"] = cbDepartment.Text;
            MessageBox.Show("Material information successfuly updated.");
            ClearMaterialFields();
        }

        private void btnRemoveProject_Click(object sender, EventArgs e)
        {
            if (projectID == 0)
            {
                MessageBox.Show("Project is not selected!");
                return;
            }

            DSProjects dsRemoveProject = new DSProjects();
            var row = dsRemoveProject.Projects.NewProjectsRow();
            FillDSProjectsRow(row);
            dsRemoveProject.Projects.AddProjectsRow(row);
            
            var response = ProjectService.DeleteProjectData(dsRemoveProject);
            if(response.Success == false)
            {
                MessageBox.Show("Project couldn't be removed, ERROR: " + response.Error);
                return;
            }
            else
            {
                MessageBox.Show("Project successfuly removed.");
                dsProjects.Projects.RemoveProjectsRow(dsProjects.Projects.Where(record => record.ID == projectID).First());
                ClearMaterialFields();
                ClearProjectFields();
                return;
            }
        }

        private void btnRemoveMaterial_Click(object sender, EventArgs e)
        {
            var row = dsProjectMaterials.ProjectMaterials
                      .Where(Material => Material.Field<Int64>("ID") == materialTableID).First();
            dsProjectMaterials.ProjectMaterials.RemoveProjectMaterialsRow(row);
            ClearMaterialFields();
        }

        private void FillDSProjectsRow(DSProjects.ProjectsRow row)
        {
            row.ID = projectID;
            row.Name = tbProjectName.Text;
            row.Company = tbProjectCompany.Text;
            row.Description = rtbProjectDescription.Text;
            row.TimeStamp = DateTime.Now;
            row.UserID = Global.userID;
            row.Active = true;
        }

        private void ClearMaterialFields()
        {
            tbMaterialQuantity.Clear();
            tbMaterialCode.Clear();
            tbType.Clear();
            materialTableID = 0;
            cbDepartment.Text = "";
        }

        private void ClearProjectFields()
        {
            tbProjectCompany.Clear();
            tbProjectName.Clear();
            rtbProjectDescription.Clear();
            projectID = 0;
            dsProjectMaterials.Clear();
        }
    }
}
