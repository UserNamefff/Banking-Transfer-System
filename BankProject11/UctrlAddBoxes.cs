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
                box.UserID = int.Parse(txtbUserBox.Text);
                box.BoxBalence = double.Parse(txtbBalence.Text);
                box.BoxName = txtbBalence.Text;
                box.BoxType1 = txtbBalence.Text;
                return box.Save();
            }

            else
            {
                MessageBox.Show("Fill the Field name or Field type");
            }
                return false;
        }

        void LoadData()
        {
            dgvOfBoxes.DataSource = clsBoxes.GetAllBoxes();
        }

        private void UctrlAddBoxes_Load(object sender, EventArgs e)
        {
           // LoadData();
        }

        void _ClearTextFields()
        {
            txtbBoxName.Text = string.Empty;
            txtbBalence.Text = string.Empty;
            txtbUserBox.Text = string.Empty;
            txtbBoxType.Text = string.Empty;
            txtbID.Text = string.Empty;
           
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!AddBoxes())
            {
                MessageBox.Show("Faild add Box", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else
            {
                _ClearTextFields();
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
    }
}
