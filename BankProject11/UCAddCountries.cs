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
    public partial class UCAddCountries: UserControl
    {

        DataTable DTOfCountries;
        public UCAddCountries()
        {
            InitializeComponent();

        }

        private void UCAddCountries_Load(object sender, EventArgs e)
        {
            txtbCountrtyNO.ReadOnly = true;
            _RefreshDataTable();
        }

        private void _RefreshDataTable()
        {
            dataGridView1.DataSource = clsCountry.GetAllCountries();
            
        }

        private void _AddNewCountry()
        {

           
            if (!string.IsNullOrWhiteSpace(txtbCountryCode.Text) && !string.IsNullOrWhiteSpace(txtbCountryName.Text))
            {
                clsCountry country = new clsCountry();

                country.CountryCode = txtbCountryCode.Text.ToString();
                country.CountryName = txtbCountryName.Text.ToString();
                //country.CountryID = int.Parse(txtbCountrtyNO.ToString());
                if (country.Save())
                {
                    MessageBox.Show("Added Successfully ! ", "");
                    ClearTextFieldes();
                }

                else
                {
                    MessageBox.Show("Add Fail", "", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }

            else
            {
                MessageBox.Show("Fill the field", "", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            _AddNewCountry();
            _RefreshDataTable() ;
          



        }

        private void ClearTextFieldes()
        {
            txtbCountrtyNO.Clear();
            txtbCountryName.Clear();
            txtbCountryCode.Clear();
        }

        private void txtbCountryName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbCountryCode.Text) )
            {
                txtbCountryCode.Focus();
                errorProvider1.SetError(txtbCountryCode, "Fill the fields");
            }

            if (string.IsNullOrWhiteSpace(txtbCountryName.Text))
            {
                txtbCountryName.Focus();
                errorProvider1.SetError(txtbCountryName, "Fill the fields");
            }
        }

        private void txtbCountrtyNO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
