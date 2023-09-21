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
    public partial class FrmCheckAvailability : Form
    {
        internal int projectID = 0;
        public FrmCheckAvailability()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            if(projectID == 0)
            {
                if(!int.TryParse(tbProjectName.Text, out projectID))
                {
                    MessageBox.Show("Could not fetch project, please select proper project!");
                    return;
                }
                var response = ProjectService.CheckMaterialAvailability(projectID);
                if(response == null || response.Rows.Count <= 0)
                {
                    MessageBox.Show("Couldn't callculate required matterials!");
                    return;
                }
                else
                    grdAvailability.DataSource = response;
            }
                
        }
    }
}
