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
using Microsoft.VisualBasic.ApplicationServices;
using PersonBusinessLayer;

namespace BankProject11
{
    public partial class UCAddUsers: UserControl
    {

        clsUser User;
        UCAddPerson UCperson;
        DataTable dt;
        public UCAddUsers()
        {
            DataTable dt = new DataTable();
            User = new clsUser();
            UCperson = new UCAddPerson();

            InitializeComponent();
        }
        private void ucAddPerson1_Load(object sender, EventArgs e)
        {

        }
        private void UCAddUsers_Load(object sender, EventArgs e)
        {
             dt = new DataTable();
            dt = clsBranches.GetAllBranches();
            foreach(DataRow dr in dt.Rows)
            {
                cmbBranches.Items.Add(dr["BranchName"].ToString());
            }

          

                
        }
        void _FillDataGrideView()
        {
            DataTable dt = clsUser.GetAllUsers();
            
            if (dt !=  null)
            {

                dgUsersData.DataSource = dt;

            }
        }

        void _Refrish()
        {
            _FillDataGrideView();
        }
        private void ucAddPerson2_Load(object sender, EventArgs e)
        {
            _FillDataGrideView();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            User.UserName = txtbUserName.Text;
            User.Password = txtPassword.Text;
            User.JobID = 0;


            

            User.IsActive = true;
            
            clsPerson1 p = ucAddPerson2.Save();
            if (p.Save())
            {

                User.PersonID = p.ID;

                if (User.Save())
                {
                    MessageBox.Show("Added User Successfully -:) ");
                    _FillDataGrideView();
                }

            }

            else
            {
                MessageBox.Show(" Could not add user , Failed -:) ");
            }

           


        }
        private void BranchIndex(object sender, EventArgs e)
        {
            clsBranches B = clsBranches.Find(cmbBranches.Text);
            if (B != null)
            {
                User.BranchID = B.BranchID;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //dt.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            
            //dt.AcceptChanges();
            //_Refrish();


        }

        private void dgUsersData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgUsersData.Rows[e.RowIndex];
                txtbUserName .Text = row.Cells["UserName"].Value.ToString();
                txtPassword .Text = row.Cells["Password"].Value.ToString();
                ucAddPerson2.FillBoxes(Convert.ToInt32(row.Cells["PersonID"].Value));
            }
        }

        void ClearBoxes()
        {
            txtbUserName.Clear();
            txtPassword.Clear();
            ucAddPerson2.ClearBoxes();
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
    }
}
