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
using System.Threading;
using System.Data.SqlClient;

namespace BankProject11
{
    public partial class UCTransfer: UserControl
    {
        clsTransactions Transfer;
        public UCTransfer()
        {
            InitializeComponent();
            Transfer = new clsTransactions();
        }

        private void _FillBranches()
        {
            DataTable dt = clsBranches.GetAllBranches();

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cmbSourceBranch.Items.Add(dr["BranchName"] );
                    cmbTargeteBranch.Items.Add(dr["BranchName"] );
                }
            }
        }

        private void _FillCurrencies()
        {
            DataTable currency_dt = clsCurrency.GetAllCurrencies();
            if (currency_dt != null)
            {
                foreach(DataRow dr in currency_dt.Rows)
                {
                    cmbCurrencyName.Items.Add(dr["CurrencyName"] );
                }
            }
        }

        private void _FillTransactionStatus()
        {
            DataTable dt =clsTransactionStatus.GetAllTransactionStatus();
            foreach (DataRow dr in dt.Rows )
            {
                cmbTransferStatus.Items.Add(dr["StatusName"] );
            }

        }

        private void _FillTransaction_types()
        {
            

            DataTable dt1 = clsTransaction_type.GetAllTransaction_types();
            foreach (DataRow dr in dt1.Rows)
            {
                cmbTransferType.Items.Add(dr["Transaction_typeName"] );
            }
           
            DataTable dt2 = clsTransaction_type.GetAllTransaction_types(false);
            foreach (DataRow dr in dt2.Rows)
            {
                cmbRemmitanceType.Items.Add(dr["Transaction_typeName"] );
            }


        }

        private void UCTransfer_Load(object sender, EventArgs e)
        {
            
            try
            {
                dgTransfer.DataSource = clsTransactions.GetAllTransferData();//clsCountry.GetAllCountries();
                _FillCurrencies();
                _FillTransactionStatus();
                _FillTransaction_types();
                _FillBranches();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message , "");
            }
            finally
            {
                cmbSourceBranch.SelectedItem = 0;
                cmbTargeteBranch.SelectedItem = 0;
            }
            cmbCurrencyName.DropDownStyle = ComboBoxStyle.DropDown;
            cmbSourceBranch.DropDownStyle = ComboBoxStyle.DropDown;
            cmbTransferType.DropDownStyle = ComboBoxStyle.DropDown;

           
        }

        private void cmbTransferType_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbSourceBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Transfer.SourceBranchID = clsBranches.Find(cmbSourceBranch.Text)._BranchID;
        }

        private void ucSenderAndRecierverInfo1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            
            Transfer.SenderID = ucSenderAndRecierverInfo1.GetRecierverID();
            Transfer.RecierverID = ucSenderAndRecierverInfo1.GetRecierverID();
            Transfer.Transaction_Status_ID = clsTransactionStatus.Find(cmbTransferStatus.Text).ID;
            
            Transfer.Transacion_type = clsTransaction_type.Find(cmbTransferType.Text).ID;

            Transfer.CurrencyID = clsCurrency.FindByCurrencyCode(cmbCurrencyName.Text).CurrencyID;
            Transfer.TargeteBranchID = clsBranches.Find(cmbTargeteBranch.Text)._BranchID;
            Transfer.SourceBranchID = clsBranches.Find(cmbSourceBranch.Text)._BranchID;

            Transfer.FeeAmount = 0.0;
            
            Transfer.TransferAmount = 0.0;
            Transfer.Description = txtDescription.Text ;

            if(Transfer.Save())
            {
                MessageBox.Show("Sended transfer Successfully ! ");
            }

            Transfer.isClientRecierver = false;
            Transfer.isClientSender = false;

        }

        private void cmbCurrencyName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void cmbTransferStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbTransferType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbTargeteBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dgTransfer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgTransfer.Rows[e.RowIndex];
                if (row != null)
                {
                    
                    //txtbCityNO.Text = row.Cells["CityID"].Value.ToString();
                    //txtbCityName.Text = row.Cells["CityName"].Value.ToString();
                    //cbxContry.SelectedItem = row.Cells["CountryID"].Value.ToString();
                    // txtbAccountRecierver.Text;
                    clsNonClients Sender = clsNonClients.Find(Convert.ToInt32(row.Cells["RecierverID"].Value));
                    clsNonClients Recierver = clsNonClients.Find(Convert.ToInt32(row.Cells["SenderID"].Value));

                    if (Sender != null && Recierver != null) {
                        ucSenderAndRecierverInfo1.FillSelectedValuesOfSenderAndRecierver(Sender.FullName, Sender.PhoneNumber,Recierver.FullName,Recierver.PhoneNumber);
                    }

                }
            }
        }
    }
}
