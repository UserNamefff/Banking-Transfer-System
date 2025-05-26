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
    public partial class UsExchangeCurrency: UserControl
    {
        DataTable dtOFCurrencies;
        public UsExchangeCurrency()
        {
            InitializeComponent();
            dtOFCurrencies = new DataTable();
        }

        private void cmbConvert_From_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UsExchangeCurrency_Load(object sender, EventArgs e)
        {
            DataTable dt =clsCurrency.GetAllCurrencies();

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cmbConvert_From.Items.Add(dr["CurrencyName"].ToString());
                    cmbConvert_To.Items.Add(dr["CurrencyName"].ToString());

                }

                cmbConvert_From.SelectedIndex = 0;
                cmbConvert_To.SelectedIndex = 16;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            

            if (numricAmount != null )
            {
                double CurrFrom= clsCurrency.FindCurrencyInfoByName(cmbConvert_To.Text.Trim())._Rate;
                double CurrTo = clsCurrency.FindCurrencyInfoByName(cmbConvert_To.Text.Trim())._Rate;
                double c = (double)(numricAmount.Value);
                lblConvertResult.Text = (CurrFrom * CurrTo*c ).ToString();

            }
        }
    }
}
