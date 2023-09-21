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
    public partial class FrmExportToProject : Form
    {
        DSOrderData dsOrderData = new DSOrderData();
        DSProjects dsProjects = new DSProjects();
        DSStorage dsStorage = new DSStorage();
        DSStorage dsRemovedStorage = new DSStorage();
        DSProjectMaterials dsProjectMaterials = new DSProjectMaterials();
        DSOrderStorage dsFinishing = new DSOrderStorage();
        DSOrderStorage dsProduction = new DSOrderStorage();
        public FrmExportToProject()
        {
            InitializeComponent();
        }

        private void FrmExportToProject_Load(object sender, EventArgs e)
        {
            grdOrders.DataSource = dsOrderData.OrderTable;
            grdStorage.DataSource = dsStorage.Storage;
            grdFinishing.DataSource = dsFinishing.OrderStorageTable;
            grdProduction.DataSource = dsProduction.OrderStorageTable;

            var response = OrdersService.GetOrderData("ACTIVE");
            if(response.Rows.Count <= 0 || response == null)
            {
                MessageBox.Show("Couldn't fetch orders, try again!");
                return;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (grdOrders.SelectedRows.Count != 0)
            {
                var selectedRow = grdOrders.SelectedRows[0];

                var response = StorageService.GetAvailableMaterialsForOrder(int.Parse(selectedRow.Cells[0].Value.ToString()));
                if (response.Rows == null && response.Rows.Count <= 0)
                {
                    MessageBox.Show("Couldn't fetch order materials data, try load again!");
                    return;
                }
                else
                {
                    dsStorage.Clear();
                    dsStorage.Storage.Merge(response);
                }

                if (!GetProjectMaterialData(int.Parse(selectedRow.Cells[1].Value.ToString())))
                    return;
                SetStorageMaterialDepartment();

            }
        }

        private void SetStorageMaterialDepartment()
        {
            foreach (DataGridViewRow dr in grdStorage.Rows)
            {
                dr.Cells["Department"].Value = dsProjectMaterials.ProjectMaterials
                                               .Where(record => record.MaterialCode == dr.Cells["Code"].Value.ToString())
                                               .First().Department;
            }
        }

        private bool GetProjectMaterialData(int projectID)
        {
            var response = ProjectService.GetProjectMaterials(projectID);
            if(response.Rows.Count <= 0 || response == null)
            {
                MessageBox.Show("Couldn't fetch order materials data, try load again!");
                return false;
            }
            else
            {
                dsProjectMaterials.Clear();
                dsProjectMaterials.ProjectMaterials.Merge(response);
                return true;
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (grdStorage.SelectedRows.Count != 0)
            {
                var selectedRow = grdStorage.SelectedRows[0];

                if (selectedRow.Cells[0].Value.ToString() == "PRODUCTION")
                {
                    var orderMaterialRow = dsProduction.OrderStorageTable.NewOrderStorageTableRow();
                    orderMaterialRow.ID = 0;
                    orderMaterialRow.OrderID = int.Parse(tbOrderNumber.Text);
                    orderMaterialRow.StorageID = int.Parse(selectedRow.Cells[0].Value.ToString());
                    orderMaterialRow.StorageNumber = int.Parse(selectedRow.Cells[1].Value.ToString());
                    orderMaterialRow.Quantity = int.Parse(selectedRow.Cells[5].Value.ToString());
                    orderMaterialRow.Type = selectedRow.Cells[8].Value.ToString();
                    orderMaterialRow.Department = selectedRow.Cells[9].Value.ToString();
                    orderMaterialRow.Spent = false;
                    orderMaterialRow.TimeStamp = DateTime.Now;
                    orderMaterialRow.UserID = Global.userID;
                    dsProduction.OrderStorageTable.AddOrderStorageTableRow(orderMaterialRow);
                }

                if (selectedRow.Cells[0].Value.ToString() == "FINISHING")
                {
                    var orderMaterialRow = dsFinishing.OrderStorageTable.NewOrderStorageTableRow();
                    orderMaterialRow.ID = 0;
                    orderMaterialRow.OrderID = int.Parse(tbOrderNumber.Text);
                    orderMaterialRow.StorageID = int.Parse(selectedRow.Cells[0].Value.ToString());
                    orderMaterialRow.StorageNumber = int.Parse(selectedRow.Cells[1].Value.ToString());
                    orderMaterialRow.Quantity = int.Parse(selectedRow.Cells[5].Value.ToString());
                    orderMaterialRow.Type = selectedRow.Cells[8].Value.ToString();
                    orderMaterialRow.Department = selectedRow.Cells[9].Value.ToString();
                    orderMaterialRow.Spent = false;
                    orderMaterialRow.TimeStamp = DateTime.Now;
                    orderMaterialRow.UserID = Global.userID;
                    dsFinishing.OrderStorageTable.AddOrderStorageTableRow(orderMaterialRow);
                }

                dsRemovedStorage.Storage.Rows.Add(dsStorage.Storage
                                                  .Where(record => record.ID == int.Parse(selectedRow.Cells[0].Value.ToString()))
                                                  .FirstOrDefault()
                                                  .ItemArray);
                dsStorage.Storage.RemoveStorageRow(dsStorage.Storage
                                                   .Where(record => record.ID == int.Parse(selectedRow.Cells[0].Value.ToString()))
                                                   .FirstOrDefault());
            }
        }

        private void btnReturnProduction_Click(object sender, EventArgs e)
        {
            if (grdProduction.SelectedRows.Count != 0)
            {
                var selectedRow = grdProduction.SelectedRows[0];
                dsStorage.Storage.Rows.Add(dsRemovedStorage.Storage
                                           .Where(record => record.ID == int.Parse(selectedRow.Cells[2].Value.ToString()))
                                           .FirstOrDefault()
                                           .ItemArray);
                dsRemovedStorage.Storage.RemoveStorageRow(dsRemovedStorage.Storage
                                                          .Where(record => record.ID == int.Parse(selectedRow.Cells[2].Value.ToString()))
                                                          .FirstOrDefault());
            }
        }

        private void btnReturnFinishing_Click(object sender, EventArgs e)
        {
            if (grdFinishing.SelectedRows.Count != 0)
            {
                var selectedRow = grdFinishing.SelectedRows[0];
                dsStorage.Storage.Rows.Add(dsRemovedStorage.Storage
                                           .Where(record => record.ID == int.Parse(selectedRow.Cells[2].Value.ToString()))
                                           .FirstOrDefault()
                                           .ItemArray);
                dsRemovedStorage.Storage.RemoveStorageRow(dsRemovedStorage.Storage
                                                          .Where(record => record.ID == int.Parse(selectedRow.Cells[2].Value.ToString()))
                                                          .FirstOrDefault());
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DSOrderStorage allOrderMaterials = new DSOrderStorage();
            allOrderMaterials.OrderStorageTable.Merge(dsProduction.OrderStorageTable);
            allOrderMaterials.OrderStorageTable.Merge(dsFinishing.OrderStorageTable);
            var response = OrdersService.AddStorageMaterialsToOrder(dsRemovedStorage, allOrderMaterials);
            if (!response.Success)
            {
                MessageBox.Show("Material for order is not separated, please try again!");
                return;
            }
            else
            {
                MessageBox.Show("Material for order separated successfuly.");
                ClearDataAfterSeparatedMaterial();
            }
        }

        private void SetTransactionMaterialData()
        {
            DSTransactionStorage transactionMaterial = new DSTransactionStorage();
            foreach(var row in dsRemovedStorage.Storage.Rows)
            {
                var material = transactionMaterial.TransactionTable.NewTransactionTableRow();
                material.ID = 0;
                material.Number = 0;
                material.Code = "";
                material.Type = "";
                material.TransactionType = "";
                material.Quantity = 0;
                material.Price = 0;
                material.ElementID = 0;
                material.WarehouseID = 0;
                material.LastChange = DateTime.Now;
                material.UserID = 0;
                material.Reserved = true;
                material.OnProject = true;
                material.BatchID = 0;
                material.ImportBatchNumber = 0;


            }
        }

        private void ClearDataAfterSeparatedMaterial()
        {
            dsStorage.Clear();
            dsProduction.Clear();
            dsFinishing.Clear();
            dsRemovedStorage.Clear();
            tbOrderNumber.Clear();
            tbQuantity.Clear();
            tbProjectName.Clear();
        }

        private void grdOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdOrders.SelectedRows.Count != 0)
            {
                var selectedRow = grdOrders.SelectedRows[0];

                var response = ProjectService.GetOneProjectData(int.Parse(selectedRow.Cells[2].Value.ToString()));
                if (response.Rows == null && response.Rows.Count <= 0)
                {
                    MessageBox.Show("Couldn't fetch project data, try load order again!");
                    return;
                }
                else
                {
                    dsProjects.Clear();
                    dsProjects.Projects.Merge(response);
                }

                tbOrderNumber.Text = selectedRow.Cells[0].Value.ToString();
                tbQuantity.Text = selectedRow.Cells[2].Value.ToString();
                tbProjectName.Text = dsProjects.Projects.FirstOrDefault()?.Name;
            }
        }
    }
}
