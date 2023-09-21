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
    public partial class FrmNewOrder : Form
    {
        DSProjects dsProjects = new DSProjects();
        internal DSOrderData dsNewOrder = new DSOrderData();
        public FrmNewOrder()
        {
            InitializeComponent();
        }

        private void FrmNewOrder_Load(object sender, EventArgs e)
        {
            var response = ProjectService.GetProjectData();
            if(response == null || response.Rows.Count <= 0)
            {
                MessageBox.Show("Couldn't fetch projects data, please re-open form!");
                return;
            }
            else
            {
                dsProjects.Projects.Merge(response);
                cbProjectName.DataSource = dsProjects.Projects;
                cbProjectName.DisplayMember = "Name";
                cbProjectName.ValueMember = "ID";
            }
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            //POZIVAMO PROVJERU DA LI U SKLADIŠTU IMA DOVOLJNO MATERIJALA
            //MOZEMO POZVAT VEC POSTOJECU FORMU
            FrmCheckAvailability frmCheckAvailability = new FrmCheckAvailability();
            frmCheckAvailability.ShowDialog();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            //AKO SMO PROVJERILI I SVE STIMA ONDA MOZEMO KREIRATI NARUDŽBU
            //PONOVNO SE REFRESHA LISTA
            if(string.IsNullOrWhiteSpace(cbProjectName.Text) || string.IsNullOrWhiteSpace(tbQuantity.Text))
            {
                MessageBox.Show("All fields must be filled!");
                return;
            }
            var row = dsNewOrder.OrderTable.NewOrderTableRow();
            row.ProjectID = int.Parse(cbProjectName.SelectedValue.ToString());
            row.OrderedQuantity = int.Parse(tbQuantity.Text);
            row.UserID = Global.userID;
            dsNewOrder.OrderTable.AddOrderTableRow(row);
            var response = OrdersService.InsertOrderData(dsNewOrder);

            if (!response.Success)
            {
                MessageBox.Show("Order not inserted successfuly");
                DialogResult = DialogResult.No;
                this.Close();
            }
            else
            {

                MessageBox.Show("Order inserted successfuly");
                DialogResult= DialogResult.OK;
                this.Close();
            }

        }

        
    }
}
