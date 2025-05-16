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
    public partial class frmAccounts: Form
    {

        public frmAccounts(int ClienID)
        {
            InitializeComponent();
            ucAddAccountToClients1 = new UCAddAccountToClients(ClienID);
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {

        }

        private void ucAddAccountToClients1_Load(object sender, EventArgs e)
        {

        }
    }
}
