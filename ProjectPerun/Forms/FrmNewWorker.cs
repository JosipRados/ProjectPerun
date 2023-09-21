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
    public partial class FrmNewWorker : Form
    {
        public FrmNewWorker()
        {
            InitializeComponent();
        }
        private void FrmNewWorker_Load(object sender, EventArgs e)
        {
            cbRole.Items.Add("ADMIN");
            cbRole.Items.Add("POWERUSER");
            cbRole.Items.Add("STORAGE");
            cbRole.Items.Add("WORKER");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DSUserData newUser = new DSUserData();
            decimal hourRate;
            var userRow = newUser.UserTable.NewUserTableRow();

            if(string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbName.Text) ||
               string.IsNullOrWhiteSpace(tbSurname.Text) || string.IsNullOrWhiteSpace(tbPassword.Text) ||
               string.IsNullOrWhiteSpace(tbPasswordRepeat.Text))
            {
                MessageBox.Show("Some fields are missing.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbHourRate.Text))
                hourRate = 0;
            else
            {
                if(!decimal.TryParse(tbHourRate.Text, out hourRate))
                {
                    MessageBox.Show("Wrong input for hour rate!");
                    return;
                }
            }

            if (!tbPassword.Text.Equals(tbPasswordRepeat.Text))
            {
                MessageBox.Show("Passwords don't match!");
                return;
            }

            userRow.ID = 0;
            userRow.Username = tbUsername.Text;
            userRow.Name = tbName.Text;
            userRow.Surname = tbSurname.Text;
            userRow.Password = tbPassword.Text;
            userRow.HourPrice = hourRate;
            userRow.Role = cbRole.Text;
            userRow.TimeStamp = DateTime.Now;
            userRow.CreatedBy = Global.userID;
            userRow.Active = true;

            newUser.UserTable.AddUserTableRow(userRow);

            var response = UsersService.InsertUserData(newUser);

            if(response == null || !response.Success)
            {
                MessageBox.Show("Insert failed!");
                return;
            }
            else
            {
                MessageBox.Show("Inserted Succesfully!");
                return;
            }

        }


    }
}
