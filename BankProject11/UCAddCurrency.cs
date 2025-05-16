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
    public partial class UCAddCurrency: UserControl
    {
        public UCAddCurrency()
        {
            InitializeComponent();
        }

        private void UCAddCurrency_Load(object sender, EventArgs e)
        {
            _FillDataGrideView();
        }

        void _FillDataGrideView()
        {
            dataGridView1.DataSource = clsCurrency.GetAllCurrencies();
        }
        private void txtbCityNO_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0) 
            {
                bntCancel.Enabled = true;
               DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtbCurrencyNO.Text = (row.Cells["CurrencyID"].Value.ToString());
                txtbCurrencyName.Text = (row.Cells["CurrencyName"].Value.ToString());
                txtbCurrencyRate.Text = (row.Cells["Rate"].Value.ToString())+" $";
            }
        }

        void ClearBoxes()
        {
            txtbCurrencyNO.Clear();
            txtbCurrencyName.Clear();
            txtbCurrencyRate.Clear();
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            bntCancel.Enabled = false;
        }
    }
}
