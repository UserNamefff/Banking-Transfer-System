using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject11
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtbPassword.Text) && string.IsNullOrEmpty(txtbUserName.Text))
            {
                MessageBox.Show("Fill All fileds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                clsLogin login = clsLogin.Find(txtbUserName.Text.Trim(), txtbPassword.Text.Trim());

                if (login != null)
                {
                    MessageBox.Show("loggened Successfully");
                    Form Mainform = new frmBank();
                    Mainform.ShowDialog();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("User Name Or Password not found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
