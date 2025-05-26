namespace BankProject11
{
    partial class frmLogIn
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblInvalied = new System.Windows.Forms.Label();
            this.LogOut = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtbuserName = new Guna.UI.WinForms.GunaTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.lblInvalied);
            this.panel1.Controls.Add(this.LogOut);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtbuserName);
            this.panel1.Location = new System.Drawing.Point(78, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 509);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(5, 453);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 17);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hafed_Alqadi.com";
            // 
            // lblInvalied
            // 
            this.lblInvalied.AutoSize = true;
            this.lblInvalied.Location = new System.Drawing.Point(133, 252);
            this.lblInvalied.Name = "lblInvalied";
            this.lblInvalied.Size = new System.Drawing.Size(12, 17);
            this.lblInvalied.TabIndex = 6;
            this.lblInvalied.Text = ".";
            // 
            // LogOut
            // 
            this.LogOut.AnimationHoverSpeed = 0.07F;
            this.LogOut.AnimationSpeed = 0.03F;
            this.LogOut.BackColor = System.Drawing.Color.Transparent;
            this.LogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogOut.BaseColor = System.Drawing.Color.Indigo;
            this.LogOut.BorderColor = System.Drawing.Color.Transparent;
            this.LogOut.BorderSize = 2;
            this.LogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogOut.FocusedColor = System.Drawing.Color.Empty;
            this.LogOut.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LogOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LogOut.Image = null;
            this.LogOut.ImageSize = new System.Drawing.Size(45, 45);
            this.LogOut.Location = new System.Drawing.Point(173, 305);
            this.LogOut.Name = "LogOut";
            this.LogOut.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.LogOut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LogOut.OnHoverForeColor = System.Drawing.Color.White;
            this.LogOut.OnHoverImage = null;
            this.LogOut.OnPressedColor = System.Drawing.Color.Black;
            this.LogOut.Radius = 10;
            this.LogOut.Size = new System.Drawing.Size(109, 48);
            this.LogOut.TabIndex = 5;
            this.LogOut.Text = "exist";
            this.LogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.BaseColor = System.Drawing.Color.DarkMagenta;
            this.btnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderSize = 2;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAdd.Location = new System.Drawing.Point(40, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(109, 48);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Log In";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13F);
            this.label2.Location = new System.Drawing.Point(20, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13F);
            this.label1.Location = new System.Drawing.Point(20, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Purple;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(25, 196);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Radius = 6;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(337, 34);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtbuserName
            // 
            this.txtbuserName.BackColor = System.Drawing.Color.Transparent;
            this.txtbuserName.BaseColor = System.Drawing.Color.White;
            this.txtbuserName.BorderColor = System.Drawing.Color.Purple;
            this.txtbuserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuserName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbuserName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbuserName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbuserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbuserName.Location = new System.Drawing.Point(24, 122);
            this.txtbuserName.Name = "txtbuserName";
            this.txtbuserName.PasswordChar = '\0';
            this.txtbuserName.Radius = 6;
            this.txtbuserName.SelectedText = "";
            this.txtbuserName.Size = new System.Drawing.Size(338, 34);
            this.txtbuserName.TabIndex = 0;
            this.txtbuserName.TextChanged += new System.EventHandler(this.txtbuserName_TextChanged);
            this.txtbuserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtbuserName_Validating);
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
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(546, 566);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogIn";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtbuserName;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblInvalied;
        private Guna.UI.WinForms.GunaButton LogOut;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}