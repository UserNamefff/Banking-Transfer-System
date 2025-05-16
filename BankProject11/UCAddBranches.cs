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
using PersonBusinessLayer;
namespace BankProject11
{
    public partial class UCAddBranches: UserControl
    {
        DataTable dt;
        public UCAddBranches()
        {
            InitializeComponent();
        }

        private void Branches_Load(object sender, EventArgs e)
        {
            dt = clsRegions.GetAllRegions();
            //clsCities.GetAllCities();

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cmbCities.Items.Add(row["CityName"].ToString());
                }
            }
            
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

        }

        

    }
}
