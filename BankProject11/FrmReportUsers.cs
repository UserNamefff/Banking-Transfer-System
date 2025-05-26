using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersBussncessLayerLib;

namespace BankProject11
{
    public partial class FrmReportUsers: Form
    {
        public FrmReportUsers()
       {
            
            InitializeComponent();
        }

        

        private void FrmReportUsers_Load(object sender, EventArgs e)
        {
            LoadUserComboBox();
        }
        private void LoadUserComboBox()
        {
            gunCombReportUsers.DataSource = clsUser.GetAllUsers();
            gunCombReportUsers. DisplayMember = "FirstName";
            gunCombReportUsers.ValueMember = "UserID";
        }

        

        private void gunCombReportUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gunCombReportUsers.SelectedValue != null && gunCombReportUsers.SelectedValue is int)
            {
                int selectedUserID = (int)gunCombReportUsers.SelectedValue;
                clsUser.loadUserActivity(selectedUserID);
            }
            else
            {

                gunDgvReportUsers.DataSource = null;
            }
        }

    }
    }
    

