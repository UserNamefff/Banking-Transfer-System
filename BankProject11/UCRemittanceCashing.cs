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
    public partial class UCRemittanceCashing: UserControl
    {
        public UCRemittanceCashing()
        {
            InitializeComponent();
        }

        private void UCRemittanceCashing_Load(object sender, EventArgs e)
        {
            _FilldataGridView();
        }

        void _FilldataGridView()
        {
           dataGridView1.DataSource= clsTransactions.GetAllTransferData();
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            clsTransactions Transfer = clsTransactions.Find(Convert.ToInt32(txtTransferNumber.Text));

            if(Transfer == null)
            {
                MessageBox.Show(" The transfer not exist !!!!!!!!!!!!!!!!!!!!!!!>) ");
            }

            else
            {
                txtAmount.ReadOnly = true;

                txtAmount.Text = Transfer.FeeAmount.ToString();
                clsBoxes Box = clsBoxes.FindBox(clsGlobl.user.UserID);
                Box.BoxBalence -= Convert.ToDouble(txtAmount.Text);
                Box.Save();
                ucSenderAndRecierverInfo1.Find(Transfer.SenderID);
                ucSenderAndRecierverInfo1.Find(Transfer.RecierverID,2);

                MessageBox.Show("The transfer is exist :>>>>>> )");
            }


        }

        private void txtTransferNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            ucSenderAndRecierverInfo1.Clear();
            txtAmount.Clear();

        }
    }
}
