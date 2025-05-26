using Microsoft.Win32;
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
    public partial class frmLogIn: Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtbuserName.Text) && !string.IsNullOrEmpty(txtPassword.Text) )
            {
                clsGlobl.user = clsUser.Find(txtbuserName.Text.Trim(), txtPassword.Text.Trim());
                
                if(clsGlobl.user != null)
                {
                    lblInvalied.Text = "Loggined Successfully :-( ";
                    lblInvalied.ForeColor = Color.Green;
                    //this.Hide();
                    Form frmMain = new frmBank();
                    frmMain.Show();

                }

                else
                {
                    Clear();
                    lblInvalied.Text = "Error ; Invalide UserName\\Password ";
                    lblInvalied.ForeColor = Color.Red;
                }
            }

            else
            {
                Clear();
                lblInvalied.Text = "Error ; Fill the Fieldes UserName and Password ";
               
                lblInvalied.ForeColor = Color.Red;
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipTitle = "Error";
                notifyIcon1.BalloonTipText = "Invalid User name Or password";

                notifyIcon1.ShowBalloonTip(10000);

            }

            
        }

        void Clear()
        {
            txtbuserName.Clear(); 
            txtPassword.Clear();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void txtbuserName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtbuserName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtbuserName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbuserName, "Required");
                txtbuserName.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtbuserName, "");
                
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Required");
                txtbuserName.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");

            }
        }
    }
}
