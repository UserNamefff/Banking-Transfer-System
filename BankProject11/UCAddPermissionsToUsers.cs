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
using Guna.UI.WinForms;

namespace BankProject11
{
    public partial class UCAddPermissionsToUsers: UserControl
    {

        int Permsissions = 0;
        public UCAddPermissionsToUsers()
        {
            InitializeComponent();
            cmbUsers.ItemHeight = 30;
        }

        private void UCAddPermissionsToUsers_Load(object sender, EventArgs e)
        {
           

            DataTable dt = clsUser.GetAllUsers();

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cmbUsers.Items.Add(dr["UserName"].ToString());
                }
               // cmbUsers.SelectedIndex = 0;
            }

            //
        }
        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //gchbManageUsers.CheckOnClick = true;
            //GunaCheckBox checkBox = (GunaCheckBox)sender;
            //foreach (Control c in gchbManageUsers.Controls)
            //{
            //    GunaCheckBox chb = (GunaCheckBox)c;
            //    chb.Checked = checkBox.Checked;
            //}

        }
        void CheckedTheCheckBox(CheckedListBox boxList,bool Checked)
        {
            if (boxList.Enabled)
            {
                for (int i = 0; i < boxList.Items.Count; i++)
                {
                    boxList.SetItemChecked(i, Checked);
                    AddPermsisions((CheckBox)boxList.SelectedItem);
                }
                
                boxList.Enabled = true;
            }
            else
            {
                boxList.Enabled = false;
            }
            CheckBox c = (CheckBox)boxList.SelectedItem;
        }
        void CheckedTheCheckedListBox(CheckedListBox boxList, bool Checked)
        {

           
                boxList.SetItemChecked(boxList.SelectedIndex, Checked);
            
            //boxList.Enabled = false;

        }
        void AddPermsisions(CheckBox c)
        {
            int i = 99;
            c.Tag = i.ToString();
        }
        private void chbManagementSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (chbManagementSystem.Checked)
            {
                chbInitialSystem.Checked = true;
                return;
            }
            else
            {
                chbInitialSystem.Checked = false;
            }
        }
        private void chbManageUsers_CheckedChanged(object sender, EventArgs e)
        {
            //if (chbManageUsers.Checked)
            //{
            //    CheckedTheCheckBox(gchbManageUsers, true);
               
            //}
            //else
            //{
               
            //    CheckedTheCheckBox(gchbManageUsers, false);

            //}
        }
        private void chbTransctions_CheckedChanged(object sender, EventArgs e)
        {
            if ( chbTransctions.Checked)
            {
                chbWithdrawAndDepost.Checked = true;
                chbRemmitanceTransfer.Checked = true;
                chbMoneyTransfer.Checked = true;
                chbDopositMoney.Checked = true;
                return;

            }
            else
            {

                chbWithdrawAndDepost.Checked = false;
                chbRemmitanceTransfer.Checked = false;
                chbMoneyTransfer.Checked = false;
                chbDopositMoney.Checked = false;

            }
        }
        private void chbCurrency_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCurrency.Checked)
            {
                chbBuysCurrencies.Checked = true;
                chbExchangeCurrencies.Checked = true;
                chbSellCurrencies.Checked = true;
                return;
            }
            else
            {
                chbBuysCurrencies.Checked = false;
                chbExchangeCurrencies.Checked = false;
                chbSellCurrencies.Checked = false;
            }



           
        }
        private void gchbTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
           // CheckedTheCheckedListBox(gchbTransactions,true);
        }
        private void gchbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CheckedTheCheckedListBox(gchbReports, true);
        }
        private void gunaCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void chbReports_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbReports.Checked)
            {
                chbReportUsers.Checked = false;
                chbReportAcounts.Checked = false;
                chbReportTransaction.Checked = false;
                chbReportCurrency.Checked = false;
                return;
            }
            else
            {
                chbReportUsers.Checked = true;
                chbReportAcounts.Checked = true;
                chbReportTransaction.Checked = true;
                chbReportCurrency.Checked = true;
            }
        }

        private void chbManageUsers_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chbManageUsers.Checked)
            {
                chbAddUser.Checked = true;
                chbDeleteuser.Checked = true;
                chbUpdateUser.Checked = true;
                return;
            }
            else
            {
                chbAddUser.Checked = false;
                chbDeleteuser.Checked = false;
                chbUpdateUser.Checked = false;

            }

        }

       

        private void chbWithdrawAndDepost_Click(object sender, EventArgs e)
        {
            GunaCheckBox ch= (GunaCheckBox)sender;
            if (ch.Checked)
            {
                Permsissions += Convert.ToInt32(ch.Tag);
                MessageBox.Show("appli");
            }

        }

        private void chbDopositMoney_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
