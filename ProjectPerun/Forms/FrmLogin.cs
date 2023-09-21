using ProjectPerun.Models;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var response = UsersService.LoginUser(new LoginModel(tbUsername.Text, tbPassword.Text));
            if (response.Success)
            {
                int.TryParse(response.Data.Rows[0]["UserID"].ToString(), out Global.userID);
                Global.userRole = response.Data.Rows[0]["Role"].ToString();
                FrmMainMenu frmMainMenu = new FrmMainMenu();
                this.Hide();
                frmMainMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed, try again!");
                return;
            }
        }
    }
}
