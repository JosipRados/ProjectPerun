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
using System.Xml.Linq;

namespace ProjectPerunDesktop.Forms
{
    public partial class FrmManageOrders : Form
    {
        DSOrderData dsOrders = new DSOrderData();
        DSShifts dsShifts = new DSShifts();
        DSProjects dsProjects = new DSProjects();
        string ordersFilter = "ALL";
        string shiftsFilter = "ALL";

        public FrmManageOrders()
        {
            InitializeComponent();
        }

        private void FrmManageOrders_Load(object sender, EventArgs e)
        {
            grdOrders.DataSource = dsOrders.OrderTable;
            grdShifts.DataSource = dsShifts.ShiftTable;

            var orders = OrdersService.GetOrderData(ordersFilter);
            if(orders == null || orders.Rows.Count <= 0)
            {
                MessageBox.Show("Couldn't fetch orders. Non existing orders!");
                dsOrders.Clear();
                return;
            }
            else
                dsOrders.OrderTable.Merge(orders, true, MissingSchemaAction.Ignore);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmNewOrder frmNewOrder = new FrmNewOrder();
            var result = frmNewOrder.ShowDialog();
            if (result == DialogResult.No)
                return;
            if(result == DialogResult.OK)
            {
                dsOrders.OrderTable.Merge(frmNewOrder.dsNewOrder.OrderTable);
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DSOrderData updateOrder = new DSOrderData();
            if (grdOrders.SelectedRows.Count != 0)
            {
                var selectedRow = grdOrders.SelectedRows[0];
                int orderID = int.Parse(selectedRow.Cells[0].Value.ToString());
                var row = dsOrders.OrderTable.Where(order => order.ID == orderID).FirstOrDefault();
                row.OrderedQuantity = int.Parse(tbOrderQuantity.Text);
                updateOrder.OrderTable.Rows.Add(row.ItemArray);

                var response = OrdersService.UpdateOrderData(updateOrder);
                if (!response.Success)
                {
                    MessageBox.Show("Update error, please try again!");
                    return;
                }
                else
                {
                    var rowTemp = row.ItemArray;
                    dsOrders.OrderTable.RemoveOrderTableRow(dsOrders.OrderTable.Where(order => order.ID == row.ID).First());
                    dsOrders.OrderTable.Rows.Add(rowTemp);
                    MessageBox.Show("Update successful!");
                    return;
                }
            }
        }

        private void btnMarkFinished_Click(object sender, EventArgs e)
        {
            if (grdOrders.SelectedRows.Count != 0)
            {
                var selectedRow = grdOrders.SelectedRows[0];
                var response = OrdersService.FinishOrder(int.Parse(selectedRow.Cells[0].Value.ToString()));
                if (!response.Success)
                {
                    MessageBox.Show("Couldn't set order to finished state!");
                    return;
                }
                else
                {
                    MessageBox.Show("Order set to finished state successfuly.");
                    btnRefreshOrders_Click(sender, e);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Order is not selected!");
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdOrders.SelectedRows.Count != 0)
            {
                var selectedRow = grdOrders.SelectedRows[0];
                var response = OrdersService.DeleteOrderData(int.Parse(selectedRow.Cells[0].Value.ToString()));
                if (!response.Success)
                {
                    MessageBox.Show("Order deleted successfuly.");
                    return;
                }
                else
                {
                    MessageBox.Show("Couldn't delete order, please try again!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Order is not selected!");
                return;
            }
        }

        private void btnRefreshShifts_Click(object sender, EventArgs e)
        {
            int orderID;
            if (grdOrders.SelectedRows.Count != 0)
            {
                var selectedRow = grdOrders.SelectedRows[0];
                orderID = int.Parse(selectedRow.Cells[0].Value.ToString());
                var response = ShiftService.GetShiftsByOrderID(orderID);
                if(response.Rows.Count <= 0 || response == null)
                {
                    MessageBox.Show("There is no shifts to fetch for selected order!");
                    return;
                }
                else
                {
                    dsShifts.Clear();
                    dsShifts.ShiftTable.Merge(response);
                }
            }
            else
            {
                MessageBox.Show("No order is selected!");
                return;
            }
        }

        private void btnRefreshOrders_Click(object sender, EventArgs e)
        {
            var orders = OrdersService.GetOrderData(ordersFilter);
            if (orders == null || orders.Rows.Count <= 0)
            {
                MessageBox.Show("Couldn't fetch orders. Non existing orders!");
                dsOrders.Clear();
                return;
            }
            else
            {
                dsOrders.Clear();
                dsOrders.OrderTable.Merge(orders, true, MissingSchemaAction.Ignore);
            }
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            FrmOrderShiftDetails frmOrderShiftDetails = new FrmOrderShiftDetails();
            frmOrderShiftDetails.Show();
        }

        private void btnShowMaterials_Click(object sender, EventArgs e)
        {
            if (grdOrders.SelectedRows.Count != 0)
            {
                FrmOrderShowMaterials frmOrderShowMaterials = new FrmOrderShowMaterials();
                var selectedRow = grdOrders.SelectedRows[0];
                frmOrderShowMaterials.orderID = int.Parse(selectedRow.Cells[0].Value.ToString());
                frmOrderShowMaterials.ShowDialog();
            }
            else
            {
                MessageBox.Show("Order is not selected!");
                return;
            }
        }

        private void rbOrders_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllOrders.Checked)
                ordersFilter = "ALL";
            if (rbFinished.Checked)
                ordersFilter = "FINISHED";
            if (rbActive.Checked)
                ordersFilter = "ACTIVE";
        }

        private void rbShifts_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllShifts.Checked)
                shiftsFilter = "ALL";
            if (rbFinishig.Checked)
                shiftsFilter = "FINISHING";
            if (rbProduction.Checked)
                shiftsFilter = "PRODUCTION";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdOrders.SelectedRows.Count != 0)
            {
                var selectedRow = grdOrders.SelectedRows[0];
                if (!GetProjectDataForOrder(int.Parse(selectedRow.Cells[1].Value.ToString())))
                    return;

                tbOrderNumber.Text = selectedRow.Cells[0].Value.ToString();
                tbProjectName.Text = dsProjects.Projects.First().Name;
                tbOrderQuantity.Text = selectedRow.Cells[2].Value.ToString();
                tbOrderedDate.Text = selectedRow.Cells[3].Value.ToString();
                tbFinishedDate.Text = selectedRow.Cells[4].Value.ToString();
                if(bool.Parse(selectedRow.Cells[6].Value.ToString()))
                    cbMaterialAsigned.Checked = true;
                if (bool.Parse(selectedRow.Cells[7].Value.ToString()))
                    cbFinished.Checked = true;

                tbMaterialPrice.Text = selectedRow.Cells[8].Value.ToString();
                tbWorkerPrice.Text = selectedRow.Cells[9].Value.ToString();
                tbProductionTime.Text = selectedRow.Cells[10].Value.ToString();
                tbFinishingTime.Text = selectedRow.Cells[11].Value.ToString();
            }
        }

        private bool GetProjectDataForOrder(int projectID)
        {
            var response = ProjectService.GetOneProjectData(projectID);
            if (response.Rows.Count <= 0 || response == null)
            {
                MessageBox.Show("Couldn't fetch Project data for given order, please try again!");
                return false;
            }
            else
            {
                dsProjects.Clear();
                dsProjects.Projects.Merge(response);
                return true;
            }
        }
    }
}
