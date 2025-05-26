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
    public partial class UctrlAddBoxes: UserControl
    {
        clsBoxes box;
        public UctrlAddBoxes()
        {
            InitializeComponent();
            box = new clsBoxes();
        }

        bool AddBoxes()
        {
            if (txtbBalence.Text != null && txtbBoxName.Text != null)
            {
                box.UserID = clsUser.Find(cmbUsers.Text.Trim()).UserID;
                box.CurrencyID = clsCurrency.FindCurrencyInfoByName(cmbCurrecy.Text.Trim()).CurrencyID;
                box.BoxBalence = double.Parse(txtbBalence.Text);
                box.BoxName = txtbBoxName.Text;
                box.BoxType1 = txtbBoxType.Text;
                return box.Save();
            }

            else
            {
                MessageBox.Show("Fill the Field name or Field type");
            }
                return false;
        }

        void _FillCurrecies()
        {
            DataTable dt = new DataTable();

            dt = clsCurrency.GetAllCurrencies();

            foreach (DataRow row in dt.Rows)
            {
                cmbCurrecy.Items.Add(row["CurrencyName"].ToString());
            }

        }

        void _FillUsers()
        {
            DataTable dt = new DataTable();

            dt = clsUser.GetAllUsers();

            foreach (DataRow row in dt.Rows)
            {
                cmbUsers.Items.Add(row["UserName"].ToString());
            }
        }
        void LoadData()
        {
            
            dgvOfBoxes.DataSource = clsBoxes.GetAllBoxes();
            _FillCurrecies();
            _FillUsers();
        }

        void _Refreshe()
        {
            dgvOfBoxes.DataSource = clsBoxes.GetAllBoxes();
            _ClearTextFields();
        }
         
        private void UctrlAddBoxes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void _ClearTextFields()
        {
            txtbBoxName.Text = string.Empty;
            txtbBalence.Text = string.Empty;
            cmbUsers.SelectedIndex = -1;
            cmbCurrecy.SelectedIndex = -1;
            txtbBoxType.Text = string.Empty;
            txtbID.Text =      string.Empty;
           
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!AddBoxes())
            {
                MessageBox.Show("Faild add Box", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else
            {
                _Refreshe();
                MessageBox.Show("added Box successfully :-) ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtbBoxName_TextChanged(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(txtbBoxName.Text))
            {
                //do notyfyIcon
            }

            else
            {

            }
        }



        private void dgvOfBoxes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvOfBoxes.Rows[e.RowIndex];
            if (row != null)
            {
                txtbBalence.Text = row.Cells["BoxBalence"].Value.ToString();
                txtbBoxName.Text = row.Cells["BoxName"].Value.ToString();
                txtbBoxType.Text = row.Cells["BoxType"].Value.ToString();
                txtbID.Text = row.Cells["BoxID"].Value.ToString();

            }
        
       }
    }
}
