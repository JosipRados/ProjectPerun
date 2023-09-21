using ProjectPerun.DataSets;
using ProjectPerun.Services;
using ProjectPerunDesktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        DSMaterialData dsMaterialData = new DSMaterialData();
        int newBatchNumber;
        int materialNumber;
        public FrmInsertBatch()
        {
            InitializeComponent();
        }

        private void FrmInsertBatch_Load(object sender, EventArgs e)
        {
            grdMaterialData.DataSource = dsMaterialData.MaterialData;
            cbWarehouse.DataSource = dsWarehouses.Warehouse;
            cbWarehouse.DisplayMember = "Name";
            cbWarehouse.ValueMember = "ID";
            tbDate.Text = DateTime.Now.ToString();
            grdImport.DataSource = dsImport.TransactionTable;

            if (!FetchNewBatchNumber())
                return;

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

            var responseMaterialData = MaterialDataService.GetMaterialData();
            if(responseMaterialData == null || responseMaterialData.Rows.Count <= 0)
            {
                MessageBox.Show("Couldn't load material data, please try to close and opet window again.");
                return;
            }
            else
                dsMaterialData.MaterialData.Merge(responseMaterialData);
                
            
        }

        private void brnGetData_Click(object sender, EventArgs e)
        {
            int batchNumberID;
            if(string.IsNullOrWhiteSpace(tbBatchNumber.Text.ToString()) || !int.TryParse(tbBatchNumber.Text.ToString(), out batchNumberID))
            {
                MessageBox.Show("Invalid value for Batch Number field!");
                return;
            }
            var batchData = BatchService.GetOneBatchData(batchNumberID);
            if(batchData == null || batchData.Rows.Count <= 0)
            {
                MessageBox.Show("Couldn't load batch, please try fetch data again.");
                return;
            }

            dsBatch.BatchTable.Merge(batchData);
            var batchRow = dsBatch.BatchTable.First();
            tbBatchNumber.Text = batchRow.BatchNumber.ToString();
            tbSender.Text = batchRow.Sender.ToString();
            tbDate.Text = batchRow.TimeStamp.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int quantity;
            decimal price;
            if (string.IsNullOrWhiteSpace(tbQuantity.Text) || string.IsNullOrWhiteSpace(tbPrice.Text))
            {
                MessageBox.Show("Quantity and price fields must be filled!");
                return;
            }
            if (!int.TryParse(tbQuantity.Text, out quantity))
            {
                MessageBox.Show("Quantity must be number.");
                return;
            }
            if (!decimal.TryParse(tbPrice.Text, out price))
            {
                MessageBox.Show("Price must be decimal number.");
                return;
            }

            var importRow = dsImport.TransactionTable.NewTransactionTableRow();
            importRow.Code = tbCode.Text;
            importRow.Number = materialNumber;
            importRow.Quantity = quantity;
            importRow.Price = price;
            importRow.Name = tbName.Text;
            importRow.ElementID = dsMaterialData.MaterialData.Where(data => data.Code == tbCode.Text).First().ID;
            if (rbElement.Checked)
                importRow.Type = "ELEMENT";
            else
                importRow.Type = "OTHER";

            dsImport.TransactionTable.Rows.Add(importRow);

            materialNumber += 1;
            ClearMaterialFields();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            foreach(var row in dsImport.TransactionTable)
            {
                row.BatchID = newBatchNumber;
                row.TransactionType = "IMPORT";
                row.UserID = Global.userID;
                row.WarehouseID = long.Parse(cbWarehouse.SelectedValue.ToString());
            }

            var response = StorageService.InsertStorageData(dsImport);

            if (!response.Success)
            {
                dsImport.Clear();
                dsImport.TransactionTable.Merge(response.Data);
                MessageBox.Show("Some materials have invalid data, please change information and try again!");
                FetchNewBatchNumber();
                return;
            }
            else
            {
                MessageBox.Show("Import success!");
                dsImport.Clear();
                return;
            }
        }

        private void rbNewBatch_Click(object sender, EventArgs e)
        {
            tbBatchNumber.ReadOnly = true;
            tbSender.ReadOnly = false;
            tbDate.ReadOnly = false;
            ClearBatchFields();
            tbBatchNumber.Text = newBatchNumber.ToString();
            dsBatch.Clear();
        }

        private void rbExistingBatch_Click(object sender, EventArgs e)
        {
            tbBatchNumber.ReadOnly = false;
            tbSender.ReadOnly = true;
            tbDate.ReadOnly = true;
            ClearBatchFields();
            dsBatch.Clear();
        }

        private void ClearBatchFields()
        {
            tbBatchNumber.Clear();
            tbSender.Clear();
            tbDate.Clear();
        }

        private void ClearMaterialFields()
        {
            tbCode.Clear();
            tbName.Clear();
            tbNumber.Text = materialNumber.ToString();
            tbPrice.Clear();
            tbQuantity.Clear();
            rbElement.Checked = false;
            rbOther.Checked = false;
        }

        private void grdMaterialData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdMaterialData.SelectedRows.Count != 0)
            {
                var selectedRow = grdMaterialData.SelectedRows[0];
                tbCode.Text = selectedRow.Cells[1].Value.ToString();
                if (selectedRow.Cells[2].Value.ToString() == "ELEMENT")
                    rbElement.Checked = true;
                else
                    rbOther.Checked = true;
            }
        }

        private bool FetchNewBatchNumber()
        {
            var responseBatch = BatchService.GetNewBatchNumber();
            if (responseBatch == null || responseBatch.Rows.Count <= 0)
            {
                MessageBox.Show("Couldn't load new batch number, please try to close and opet window again.");
                return false;
            }
            else
            {
                newBatchNumber = int.Parse(responseBatch.Rows[0]["BatchNumber"].ToString());
                tbBatchNumber.Text = newBatchNumber.ToString();
                return true;
            }
        }
    }
}
