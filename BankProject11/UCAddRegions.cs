using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonBusinessLayer;
using UsersBussncessLayerLib;

namespace BankProject11
{
    public partial class UCAddRegions: UserControl
    {
        clsRegions Region;
        public UCAddRegions()
        {
            InitializeComponent();

            Region = new clsRegions();
        }



        private bool _AddRegion()
        {
            Region.NameRegion = txtbBranchName.Text;
            Region.RegionID = clsCities.Find(gunaComboBox1.SelectedText.ToString()).CityID;
            return Region.Save();
        }

        private void FillDataTable()
        {
            dataGridView1.DataSource = clsRegions.GetAllRegions();
        }

        private void UCAddRegions_Load(object sender, EventArgs e)
        {
            FillDataTable();
        }

        void ClearTextFielde()
        {
            txtbBranchName.Clear();
            txtbRegionNO.Clear();
            if (gunaComboBox1 != null)
            {
                gunaComboBox1.SelectedIndex = 0;
            }

        }
        private void bntCancel_Click(object sender, EventArgs e)
        {
            ClearTextFielde();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
