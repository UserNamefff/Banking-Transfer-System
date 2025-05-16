using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

using UsersBussncessLayerLib;


namespace BankProject11
{
    public partial class UCSenderAndRecierverInfo: UserControl
    {

        clsNonClients NonClient;
        clsNonClients RecierverClient;

        public UCSenderAndRecierverInfo()
        {
            //this.NonClient = new clsNonClients();
            //this.RecierverClient = new clsNonClients();

            InitializeComponent();
        }
        
        public UCSenderAndRecierverInfo(string SenderName,string SenderPhone,string RecierverName , string RecierverPhone)
        {
            //this.NonClient = new clsNonClients();
            //this.RecierverClient = new clsNonClients();

            InitializeComponent();
        }

        bool isSaved = false;
        public bool IsNonClientSaved()
        {
            return isSaved;
        }
        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
           
            txtbSenderName.Focus();
            errorProvider1.SetError(txtbSenderName, "Required");
        }
        private void gunaTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtbSenderName.Text))
            {
                
                
                errorProvider1.SetError(txtbSenderName, "Required");
            }
            else
            {

                errorProvider1.SetError(txtbSenderName, "");
                
            }
        }
        public bool AddNonClient()
        {
            NonClient = new clsNonClients();
            NonClient.FullName = txtbSenderName.Text.ToString();
            NonClient.PhoneNumber = txtbSenderPhone.Text.ToString() ;
            
            if(NonClient.Save() )
            {
                isSaved = true;
                return true;
            }

            return false;
        }
        public int GetSenderID()
        {
            AddNonClient();
            return NonClient.ID;
        }
        public int GetRecierverID()
        {
            RecierverClient = new clsNonClients();

            RecierverClient.FullName = txtbRecierverName.Text.ToString();
            RecierverClient.PhoneNumber = txtbRecierverPhone.Text.ToString();

            if(RecierverClient.Save())
            {
                return RecierverClient.ID;
            }
            return 0;

        }
        private void UCSenderAndRecierverInfo_Load(object sender, EventArgs e)
        {
            
        }

        public  void FillSelectedValuesOfSenderAndRecierver(string SenderName, string SenderPhon, string RecierverName, string RecierverPhon)
        {
            if(SenderName != null)
            {
                txtbSenderName.Text = SenderName;
            }
            if(SenderPhon != null)
            {
                txtbSenderPhone.Text = SenderPhon;
            }
            if(RecierverName != null)
            {
                txtbRecierverName.Text = RecierverName;
            }
            if(RecierverPhon != null)
            {
                txtbRecierverPhone.Text = RecierverPhon;   
            }
        }
    }
}
