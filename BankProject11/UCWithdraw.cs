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
    public partial class UCWithdraw: UserControl
    {
        clsManageAccounts WithDrawFromAccount;
        public UCWithdraw()
        {
            InitializeComponent();
        }

        private void btnWithdrawt_Click(object sender, EventArgs e)
        {
          
            if(_WithDraw())
            {
                MessageBox.Show("Withdraw successfully :-) ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        bool _WithDraw()
        {
            double Amount = (double)NRAmount.Value;
            if (Amount == 0)
            {
                MessageBox.Show("Enter Amount ?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                //clsManageAccounts WithDrawFromAccount = clsManageAccounts.Find(cbxAcountNO.SelectedItem.ToString().Trim());

                if (WithDrawFromAccount != null)
                {
                    if (Amount < WithDrawFromAccount.Balence)
                    {
                        lblCurrentAmount.Text = "Current Amount" + " : " + WithDrawFromAccount.Balence.ToString();
                        return WithDrawFromAccount.WithDraw(Amount);
                    }

                    else
                    {
                        MessageBox.Show("The Balece less than Amount Entered :-( ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
                return false;
        }

        private void UCWithdraw_Load(object sender, EventArgs e)
        {
            _FillAccounts();
        }

        private void cbxAcountNO_SelectedIndexChanged(object sender, EventArgs e)
        {
             WithDrawFromAccount = clsManageAccounts.Find(cbxAcountNO.SelectedItem.ToString().Trim());
            
            if (WithDrawFromAccount != null)
            {
                lblCurrentAmount.Text = "Current Amount" + " : " + WithDrawFromAccount.Balence.ToString();
               // WithDrawFromAccount.WithDraw(Amount);
            }
        }
    }
}
