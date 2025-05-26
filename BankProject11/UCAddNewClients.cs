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
    public partial class UCAddNewClients: UserControl
    {
        clsClient Client;
        DataTable dt;
        public UCAddNewClients()
        {
            this.AutoScroll = true;
            Client = new clsClient();
            dt = new DataTable();

            InitializeComponent();
        }
        private void _LoadDataOFClients()
        {
             dt = clsClient.GetAllClients();
            if(dt != null)
            dgvOfClients.DataSource = dt;

        }
        private void AddClient()
        {

           // int PerosnID = ucAddPerson1.PersonID();
            
            if ( (cmbClientType.SelectedIndex != -1))
            {
                Client.PersonID = ucAddPerson1.Save(0);
                Client.ClientType = (cmbClientType.Text != null) ? cmbClientType.Text:" " ;
                if(Client.Save())
                {
                    MessageBox.Show("Client Added Successfully :-) ", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Client Add failed the PersonID or Client Type is not correct ", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            
            
            
        }
        private void UCAddNewClientsAcount_Load(object sender, EventArgs e)
        {
            _LoadDataOFClients();
            cmbClientType.SelectedIndex = 0;
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            DataRow[] dr = dt.Select();

            foreach (DataRow dr2 in dr)
            {
                dr2.Delete();
            }

            dt.AcceptChanges();
        }
        private void ucAddAccountToClients1_Load(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmbClientType.SelectedIndex = 0;
            AddClient();
            _LoadDataOFClients();

        }
        private void btnAddAccounts_Click(object sender, EventArgs e)
        {

            if(dgvOfClients.SelectedRows.Count ==1)
            {
                Form frmACount = new frmAccounts(1);
                    frmACount.ShowDialog();

            }

            else
            {
                MessageBox.Show("Select Row from Table of Clients ","");

            }
        }
        private void ucAddPerson1_Load(object sender, EventArgs e)
        {
            
        }
        private void dgvOfClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataRow dr = dgvOfClients.Rows[e.RowIndex];
        }
        private void dgvOfClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvOfClients.Rows[e.RowIndex];
            if (row != null)
            {
                //txt.Text = row.Cells["BoxBalence"].Value.ToString();
                //txtbBoxName.Text = row.Cells["BoxName"].Value.ToString();
                //txtbBoxType.Text = row.Cells["BoxType"].Value.ToString();
                //txtbID.Text = row.Cells["BoxID"].Value.ToString();
               


            }
        }


    }
}
