using Guna.UI.WinForms;
using PersonBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using UsersBussncessLayerLib;

namespace BankProject11
{
    public partial class UCAddPerson: UserControl
    {


        clsPerson1 Person;
        
        public UCAddPerson()
        {
            Person = new clsPerson1();
            InitializeComponent();
        }

        public UCAddPerson(clsPerson1 Person)
        {
           // txtAddress.Text = Person.Add   
            
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                linkLabel2.Visible = true;
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pictureBox1.Load(selectedFilePath);
                // ...
            }


        }

        private void UCAddPerson_Load(object sender, EventArgs e)
        {
            _FillCountryBox();
        }

        public void _FillCountryBox()
        {
            DataTable dt = new DataTable();
            dt = clsCountry.GetAllCountries();

            foreach (DataRow dr in dt.Rows)
            {
                cmbcounties.Items.Add(dr["CountryName"].ToString());
            }

            if(cmbcounties.Items.Count > 0) 
            cmbcounties.SelectedIndex = 0;
        }

        public int PersonID()
        {
            return Person.ID;
        }

        public clsPerson1 Save()
        {
            //MessageBox.Show(""+ cmbcounties.Text.ToString()+ "  ");
            //Person.CountryID = clsCountry.Find(cmbcounties.Text.ToString()).CountryID;
            clsRegions Region = clsRegions.Find("Aldabab");
            Person.CountryID = clsCountry.Find(cmbcounties.SelectedItem.ToString()).CountryID;
            Person.PhoneNumber = txtbPhon.Text.ToString();
            
            Person.Email = txtbEmail.Text;
            Person.Adrress = Convert.ToInt32(Region.RegionID);
            Person.LName = txtbLasstName.Text;
            Person.FName = txtbFistName.Text;
            Person.DateOfBirth = (DateTime)DTB.Value;
            //Person.Adrress = Region.RegionID;
            return Person;

        }

        public int Save(int ID = 0)
        {
            //MessageBox.Show(""+ cmbcounties.Text.ToString()+ "  ");
            //Person.CountryID = clsCountry.Find(cmbcounties.Text.ToString()).CountryID;
            clsRegions Region = clsRegions.Find("Aldabab");
            Person.CountryID = clsCountry.Find(cmbcounties.SelectedItem.ToString()).CountryID;
            Person.PhoneNumber = txtbPhon.Text.ToString();

            Person.Email = txtbEmail.Text;
            Person.Adrress = Convert.ToInt32(Region.RegionID);
            Person.LName = txtbLasstName.Text;
            Person.FName = txtbFistName.Text;
            Person.DateOfBirth = (DateTime)DTB.Value;
            Person.Save();
            //Person.Adrress = Region.RegionID;
            return Person.ID;

        }

        public static clsPerson1 Find(string Name)
        {
           return clsPerson1.FindByFName(Name);
        }
        public static clsPerson1 Find(int ID)
        {
            return clsPerson1.FindByID(ID);
        }
     

        private void txtbPhon_TextChanged(object sender, EventArgs e)
        {
            Person.PhoneNumber = txtbPhon.Text;
        }

        private void txtbEmail_TextChanged(object sender, EventArgs e)
        {
            Person.Email = txtbEmail.Text;

            string email = txtbEmail.Text.Trim();
            string emailPattern = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";

            if (string.IsNullOrEmpty(email))
            {
                errorProvider1.SetError(txtbEmail, "");
                return;
            }


            Regex emailRegex = new Regex(emailPattern);

            if (emailRegex.IsMatch(email))
            {
                errorProvider1.SetError(txtbEmail, "");
                Person.Email = txtbEmail.Text;
            }
            else
            {
                errorProvider1.SetError(txtbEmail, "الرجاء إدخال بريد إلكتروني بصيغة صحيحة (e.g., user@example.com).");
            }
        }


        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
           
            Person.Adrress = clsRegions.Find("Aldabab").RegionID; 
        }

        private void txtbLasstName_TextChanged(object sender, EventArgs e)
        {
           
            Person.LName = txtbLasstName.Text;
        }

        private void txtbFistName_TextChanged(object sender, EventArgs e)
        {

            Person.FName = txtbFistName.Text;
        }

        private void DTB_ValueChanged(object sender, EventArgs e)
        {
            
            Person.DateOfBirth = (DateTime)DTB.Value;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
            linkLabel2.Visible = false;
        }

        private void llChooseImage(object sender, LinkLabelLinkClickedEventArgs e)
        {


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { 
                Person.ImagePath = openFileDialog1.FileName; 
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
                    
        }

        private void cmbcounties_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person.CountryID = clsCountry.Find(cmbcounties.SelectedItem.ToString()).CountryID;
        }

        public void FillBoxes(int UserID )
        {
            int PersonID = clsUser.Find(UserID).PersonID;
           // clsUser User= clsUser.Find(UserID).PersonID;
            clsPerson1 person  = clsPerson1.FindByID(PersonID);

            if (person != null)
            {

                gunaTextBox1.Text = PersonID.ToString();
                txtAddress.Text = clsRegions.Find(person.Adrress).NameRegion;
                txtbEmail.Text = person.Email;
                txtbPhon.Text = person.PhoneNumber;
                txtbFistName.Text = person.FName;
                txtbLasstName.Text = person.LName;

                if (!string.IsNullOrEmpty(person.ImagePath))
                {
                    pictureBox1.Image = Image.FromFile(person.ImagePath);
                }
                
            }
        }
        public void ClearBoxes()
        {
            gunaTextBox1.Clear();
            txtAddress.  Clear();
            txtbEmail.   Clear();
            txtbPhon.    Clear();
            txtbFistName.Clear();
            txtbLasstName.Clear();
            pictureBox1.Image = Properties.Resources.Male_512;

        }

        private void txtbEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtbEmail.Text.Trim();
            string emailPattern = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";

            if (string.IsNullOrEmpty(email))
            {
                errorProvider1.SetError(txtbEmail, "");
                return;
            }


          


            Regex emailRegex = new Regex(emailPattern);

            if (emailRegex.IsMatch(email))
            {
                errorProvider1.SetError(txtbEmail, "");
                Person.Email = txtbEmail.Text;
            }
            else
            {
                errorProvider1.SetError(txtbEmail, "الرجاء إدخال بريد إلكتروني بصيغة صحيحة (e.g., user@example.com).");
            }
        }

        private void txtbPhon_Validating(object sender, CancelEventArgs e)
        {
            Regex phonRegex = new Regex("^\\+?\\d+$");
            // string checkein = "+0123456789";
            string phonNumber = txtbPhon.Text.Trim();
            if (string.IsNullOrEmpty(phonNumber))
            {
                errorProvider1.SetError(txtbPhon, "please enter phone nunber");
                e.Cancel = true;
                return;
            }
            else if (phonRegex.IsMatch(phonNumber))
            {

                Person.PhoneNumber = txtbPhon.Text;
                errorProvider1.SetError(txtbPhon, "");
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(txtbPhon, "error phon number ");
                e.Cancel = true;
            }
        }
    }
}
