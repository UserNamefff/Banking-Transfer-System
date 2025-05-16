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
    public partial class UCAddCities: UserControl
    {
        clsCities clsCities;
        DataTable dtOFCountries;
        public UCAddCities()
        {
            InitializeComponent();
        }

        private void UCAddCities_Load(object sender, EventArgs e)
        {
            _FillDataOfCities();
        }

        void _FillDataOfCities()
        {
            dataGridView1.DataSource = clsCities.GetAllCities();
            _FillcbxContry();

        }

        private void _FillcbxContry()
        {

            dtOFCountries = clsCountry.GetAllCountries();

            if (dtOFCountries != null)
            {

                foreach (DataRow c in dtOFCountries.Rows)
                {
                    cbxContry.Items.Add(c["CountryName"].ToString());
                }

                cbxContry.SelectedIndex = 0;
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e/*What do */)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row != null)
                {

                    txtbCityNO.Text  = row.Cells["CityID"].Value.ToString();
                    txtbCityName.Text  = row.Cells["CityName"].Value.ToString();
                    cbxContry.SelectedItem = row.Cells["CountryID"].Value.ToString();
                }
            }

        }

       
       
    }
}
