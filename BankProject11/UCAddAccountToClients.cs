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
using Microsoft.VisualBasic;


namespace BankProject11
{
    public partial class UCAddAccountToClients: UserControl
    {

        clsManageAccounts Accounts;
        //clsClient Client;
        public UCAddAccountToClients()
        {
            Accounts = new clsManageAccounts();

            InitializeComponent();
        }
        clsClient client;
        

        //To Choose Client 
        public UCAddAccountToClients(int ClientID)
        {
             client = clsClient.Find(ClientID);

            if(client != null)
            {
                this.ClientID = client.ClientID;
                this.ClientName = client.GetClientName();
              //  txtClientName.Text = client.GetClientName();
            }

            Accounts = new clsManageAccounts();

            InitializeComponent();
        }


        void _FillCurrencyBox()
        {
            
            DataTable dataTable = clsCurrency.GetAllCurrencies();

            foreach (DataRow row in dataTable.Rows)
            {
                cmbCurrency.Items.Add(row["CurrencyName"].ToString());
            }

            cmbCurrency.SelectedIndex = 0;
        }
        private bool _Save()
        {
            Accounts.PineCode = txtbPinCode.Text;
            Accounts.Balence = (double)txtbBalence.Value;
            Accounts.CurrencyID = clsCurrency.FindCurrencyInfoByName(cmbCurrency.Text.Trim()).CurrencyID;
            Accounts.AccountNumber = txtbAccountNumbet.Text;
            Accounts.Type_Account = txtbAccount_type.Text;
            Accounts.CreatedByUsers = clsGlobl.user.UserID;
            Accounts.Save();
            Accounts.ClientID = this.GetClientID();


            return Accounts.Save();
        }

        public int ClientID { set; get; }
        public string ClientName { set; get; }
        private int GetClientID()
        {
           
            return ClientID;
        }


        private void _Fill()
        {
            DataTable dataTable = clsClient.GetAllClients();

            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    cmbClients.Items.Add(row["ClientID"].ToString());
                }
            }
        }
        private void UCAddAccountToClients_Load(object sender, EventArgs e)
        {
            _Fill();
            _FillCurrencyBox();
            dgvAccounts.DataSource = clsManageAccounts.GetAllClients();
            
        }

        private void txtbAccount_type_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this._Save())
            {
                MessageBox.Show("Added Successfully :-) ","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
