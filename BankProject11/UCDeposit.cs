using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersBussncessLayerLib;

namespace BankProject11
{
    public partial class UCDeposit: UserControl
    {
        public UCDeposit()
        {
            InitializeComponent();
        }

        private void UCDeposit_Load(object sender, EventArgs e)
        {
            _FillAccounts();
        }

       private void _FillAccounts()
        {
            DataTable dt = clsManageAccounts.GetAllClients();

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cbxAcountNO.Items.Add(dr["AccountNumber"].ToString());
                }
            }
        }

        private void btDeposit_Click(object sender, EventArgs e)
        {
            clsManageAccounts Account = clsManageAccounts.Find(cbxAcountNO.SelectedItem.ToString().Trim());

            Account.Deposit((double)NRAmount.Value);
        }


        
    }
}
