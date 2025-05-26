namespace BankProject11
{
    partial class UCAddPerson
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.rdbFelmal = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbPhon = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbLasstName = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbEmail = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbFistName = new Guna.UI.WinForms.GunaTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DTB = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbcounties = new Guna.UI.WinForms.GunaComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI.WinForms.GunaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(859, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Gender";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.rdbFelmal);
            this.gunaPanel1.Controls.Add(this.rdbMale);
            this.gunaPanel1.Location = new System.Drawing.Point(840, 163);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(217, 36);
            this.gunaPanel1.TabIndex = 27;
            // 
            // rdbFelmal
            // 
            this.rdbFelmal.AutoSize = true;
            this.rdbFelmal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFelmal.Location = new System.Drawing.Point(105, 2);
            this.rdbFelmal.Name = "rdbFelmal";
            this.rdbFelmal.Size = new System.Drawing.Size(99, 27);
            this.rdbFelmal.TabIndex = 1;
            this.rdbFelmal.Text = "Female";
            this.rdbFelmal.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Checked = true;
            this.rdbMale.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.Location = new System.Drawing.Point(14, 4);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(76, 27);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.Location = new System.Drawing.Point(428, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Phon";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbPhon
            // 
            this.txtbPhon.BackColor = System.Drawing.Color.Transparent;
            this.txtbPhon.BaseColor = System.Drawing.Color.White;
            this.txtbPhon.BorderColor = System.Drawing.Color.Black;
            this.txtbPhon.BorderSize = 1;
            this.txtbPhon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbPhon.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbPhon.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbPhon.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbPhon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtbPhon.Location = new System.Drawing.Point(530, 13);
            this.txtbPhon.Name = "txtbPhon";
            this.txtbPhon.PasswordChar = '\0';
            this.txtbPhon.Radius = 10;
            this.txtbPhon.SelectedText = "";
            this.txtbPhon.Size = new System.Drawing.Size(273, 43);
            this.txtbPhon.TabIndex = 23;
            this.txtbPhon.TextChanged += new System.EventHandler(this.txtbPhon_TextChanged);
            this.txtbPhon.Validating += new System.ComponentModel.CancelEventHandler(this.txtbPhon_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(5, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Last Name";
            // 
            // txtbLasstName
            // 
            this.txtbLasstName.BackColor = System.Drawing.Color.Transparent;
            this.txtbLasstName.BaseColor = System.Drawing.Color.White;
            this.txtbLasstName.BorderColor = System.Drawing.Color.Black;
            this.txtbLasstName.BorderSize = 1;
            this.txtbLasstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbLasstName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbLasstName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbLasstName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbLasstName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtbLasstName.Location = new System.Drawing.Point(111, 111);
            this.txtbLasstName.Name = "txtbLasstName";
            this.txtbLasstName.PasswordChar = '\0';
            this.txtbLasstName.Radius = 10;
            this.txtbLasstName.SelectedText = "";
            this.txtbLasstName.Size = new System.Drawing.Size(273, 43);
            this.txtbLasstName.TabIndex = 21;
            this.txtbLasstName.TextChanged += new System.EventHandler(this.txtbLasstName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(428, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Email";
            // 
            // txtbEmail
            // 
            this.txtbEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtbEmail.BaseColor = System.Drawing.Color.White;
            this.txtbEmail.BorderColor = System.Drawing.Color.Black;
            this.txtbEmail.BorderSize = 1;
            this.txtbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtbEmail.Location = new System.Drawing.Point(530, 62);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.PasswordChar = '\0';
            this.txtbEmail.Radius = 10;
            this.txtbEmail.SelectedText = "";
            this.txtbEmail.Size = new System.Drawing.Size(273, 43);
            this.txtbEmail.TabIndex = 19;
            this.txtbEmail.TextChanged += new System.EventHandler(this.txtbEmail_TextChanged);
            this.txtbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtbEmail_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fist Name";
            // 
            // txtbFistName
            // 
            this.txtbFistName.BackColor = System.Drawing.Color.Transparent;
            this.txtbFistName.BaseColor = System.Drawing.Color.White;
            this.txtbFistName.BorderColor = System.Drawing.Color.Black;
            this.txtbFistName.BorderSize = 1;
            this.txtbFistName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbFistName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbFistName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbFistName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbFistName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtbFistName.Location = new System.Drawing.Point(111, 62);
            this.txtbFistName.Name = "txtbFistName";
            this.txtbFistName.PasswordChar = '\0';
            this.txtbFistName.Radius = 10;
            this.txtbFistName.SelectedText = "";
            this.txtbFistName.Size = new System.Drawing.Size(273, 43);
            this.txtbFistName.TabIndex = 17;
            this.txtbFistName.TextChanged += new System.EventHandler(this.txtbFistName_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankProject11.Properties.Resources.Male_512;
            this.pictureBox1.Location = new System.Drawing.Point(889, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(122, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // DTB
            // 
            this.DTB.BackColor = System.Drawing.Color.Transparent;
            this.DTB.BaseColor = System.Drawing.Color.White;
            this.DTB.BorderColor = System.Drawing.Color.Black;
            this.DTB.BorderSize = 1;
            this.DTB.CustomFormat = null;
            this.DTB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DTB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTB.ForeColor = System.Drawing.Color.Black;
            this.DTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTB.Location = new System.Drawing.Point(529, 111);
            this.DTB.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.DTB.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.DTB.Name = "DTB";
            this.DTB.OnHoverBaseColor = System.Drawing.Color.White;
            this.DTB.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DTB.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DTB.OnPressedColor = System.Drawing.Color.Black;
            this.DTB.Radius = 7;
            this.DTB.Size = new System.Drawing.Size(274, 44);
            this.DTB.TabIndex = 31;
            this.DTB.Text = "1426/11/29";
            this.DTB.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.DTB.ValueChanged += new System.EventHandler(this.DTB_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label7.Location = new System.Drawing.Point(428, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "Birth Date";
            // 
            // cmbcounties
            // 
            this.cmbcounties.BackColor = System.Drawing.Color.Transparent;
            this.cmbcounties.BaseColor = System.Drawing.Color.Transparent;
            this.cmbcounties.BorderColor = System.Drawing.Color.Black;
            this.cmbcounties.BorderSize = 1;
            this.cmbcounties.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbcounties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcounties.FocusedColor = System.Drawing.Color.Empty;
            this.cmbcounties.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbcounties.ForeColor = System.Drawing.Color.Black;
            this.cmbcounties.FormattingEnabled = true;
            this.cmbcounties.ItemHeight = 35;
            this.cmbcounties.Location = new System.Drawing.Point(530, 161);
            this.cmbcounties.Name = "cmbcounties";
            this.cmbcounties.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbcounties.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbcounties.Radius = 10;
            this.cmbcounties.Size = new System.Drawing.Size(273, 41);
            this.cmbcounties.TabIndex = 33;
            this.cmbcounties.SelectedIndexChanged += new System.EventHandler(this.cmbcounties_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label8.Location = new System.Drawing.Point(428, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 34;
            this.label8.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label9.Location = new System.Drawing.Point(5, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 23);
            this.label9.TabIndex = 36;
            this.label9.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BaseColor = System.Drawing.Color.White;
            this.txtAddress.BorderColor = System.Drawing.Color.Black;
            this.txtAddress.BorderSize = 1;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddress.Location = new System.Drawing.Point(111, 160);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.Radius = 10;
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(273, 43);
            this.txtAddress.TabIndex = 35;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label10.Location = new System.Drawing.Point(8, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 23);
            this.label10.TabIndex = 37;
            this.label10.Text = "ID";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Black;
            this.gunaTextBox1.BorderSize = 1;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaTextBox1.Location = new System.Drawing.Point(111, 13);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(273, 43);
            this.gunaTextBox1.TabIndex = 38;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.linkLabel1.Location = new System.Drawing.Point(846, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 18);
            this.linkLabel1.TabIndex = 40;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Choose image";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llChooseImage);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.linkLabel2.Location = new System.Drawing.Point(952, 12);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(106, 18);
            this.linkLabel2.TabIndex = 41;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Remove image";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // UCAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbcounties);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DTB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbPhon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbLasstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbFistName);
            this.Name = "UCAddPerson";
            this.Size = new System.Drawing.Size(1202, 211);
            this.Load += new System.EventHandler(this.UCAddPerson_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.RadioButton rdbFelmal;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtbPhon;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtbLasstName;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtbEmail;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtbFistName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDateTimePicker DTB;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaComboBox cmbcounties;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
