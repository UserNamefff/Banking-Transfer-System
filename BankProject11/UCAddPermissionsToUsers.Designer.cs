namespace BankProject11
{
    partial class UCAddPermissionsToUsers
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
            this.label3 = new System.Windows.Forms.Label();
            this.chbManagementSystem = new Guna.UI.WinForms.GunaCheckBox();
            this.chbTransctions = new Guna.UI.WinForms.GunaCheckBox();
            this.chbReports = new Guna.UI.WinForms.GunaCheckBox();
            this.chbCurrency = new Guna.UI.WinForms.GunaCheckBox();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.btnPrint = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chbInitialSystem = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.chbMoneyTransfer = new Guna.UI.WinForms.GunaCheckBox();
            this.chbRemmitanceTransfer = new Guna.UI.WinForms.GunaCheckBox();
            this.chbWithdrawAndDepost = new Guna.UI.WinForms.GunaCheckBox();
            this.chbBuysCurrencies = new Guna.UI.WinForms.GunaCheckBox();
            this.chbSellCurrencies = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.chbUpdateUser = new Guna.UI.WinForms.GunaCheckBox();
            this.chbDeleteuser = new Guna.UI.WinForms.GunaCheckBox();
            this.chbAddUser = new Guna.UI.WinForms.GunaCheckBox();
            this.chbManageUsers = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.chbDopositMoney = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.chbExchangeCurrencies = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.chbReportTransaction = new Guna.UI.WinForms.GunaCheckBox();
            this.chbReportCurrency = new Guna.UI.WinForms.GunaCheckBox();
            this.chbReportAcounts = new Guna.UI.WinForms.GunaCheckBox();
            this.chbReportUsers = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(642, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "User name";
            // 
            // chbManagementSystem
            // 
            this.chbManagementSystem.BaseColor = System.Drawing.Color.White;
            this.chbManagementSystem.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbManagementSystem.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbManagementSystem.FillColor = System.Drawing.Color.White;
            this.chbManagementSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbManagementSystem.Location = new System.Drawing.Point(126, 318);
            this.chbManagementSystem.Name = "chbManagementSystem";
            this.chbManagementSystem.Size = new System.Drawing.Size(207, 25);
            this.chbManagementSystem.TabIndex = 51;
            this.chbManagementSystem.Text = "Management system";
            this.chbManagementSystem.CheckedChanged += new System.EventHandler(this.chbManagementSystem_CheckedChanged);
            // 
            // chbTransctions
            // 
            this.chbTransctions.BaseColor = System.Drawing.Color.White;
            this.chbTransctions.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbTransctions.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbTransctions.FillColor = System.Drawing.Color.White;
            this.chbTransctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbTransctions.Location = new System.Drawing.Point(655, 318);
            this.chbTransctions.Name = "chbTransctions";
            this.chbTransctions.Size = new System.Drawing.Size(130, 25);
            this.chbTransctions.TabIndex = 52;
            this.chbTransctions.Text = "Transctions";
            this.chbTransctions.CheckedChanged += new System.EventHandler(this.chbTransctions_CheckedChanged);
            // 
            // chbReports
            // 
            this.chbReports.BaseColor = System.Drawing.Color.White;
            this.chbReports.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbReports.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbReports.FillColor = System.Drawing.Color.White;
            this.chbReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbReports.Location = new System.Drawing.Point(1186, 310);
            this.chbReports.Name = "chbReports";
            this.chbReports.Size = new System.Drawing.Size(98, 25);
            this.chbReports.TabIndex = 54;
            this.chbReports.Text = "Reports";
            this.chbReports.CheckedChanged += new System.EventHandler(this.chbReports_CheckedChanged);
            // 
            // chbCurrency
            // 
            this.chbCurrency.BaseColor = System.Drawing.Color.White;
            this.chbCurrency.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbCurrency.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbCurrency.FillColor = System.Drawing.Color.White;
            this.chbCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbCurrency.Location = new System.Drawing.Point(925, 318);
            this.chbCurrency.Name = "chbCurrency";
            this.chbCurrency.Size = new System.Drawing.Size(109, 25);
            this.chbCurrency.TabIndex = 56;
            this.chbCurrency.Text = "Currency";
            this.chbCurrency.CheckedChanged += new System.EventHandler(this.chbCurrency_CheckedChanged);
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.ItemHeight = 16;
            this.cmbUsers.Location = new System.Drawing.Point(766, 127);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(311, 24);
            this.cmbUsers.TabIndex = 58;
            // 
            // btnPrint
            // 
            this.btnPrint.AnimationHoverSpeed = 0.07F;
            this.btnPrint.AnimationSpeed = 0.03F;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrint.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Image = null;
            this.btnPrint.ImageSize = new System.Drawing.Size(55, 55);
            this.btnPrint.Location = new System.Drawing.Point(779, 221);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPrint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint.OnHoverImage = null;
            this.btnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint.Radius = 10;
            this.btnPrint.Size = new System.Drawing.Size(136, 30);
            this.btnPrint.TabIndex = 69;
            this.btnPrint.Text = "Save";
            this.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(55, 55);
            this.gunaButton1.Location = new System.Drawing.Point(925, 221);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(136, 30);
            this.gunaButton1.TabIndex = 70;
            this.gunaButton1.Text = "Cancel";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chbInitialSystem
            // 
            this.chbInitialSystem.BaseColor = System.Drawing.Color.White;
            this.chbInitialSystem.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbInitialSystem.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbInitialSystem.FillColor = System.Drawing.Color.White;
            this.chbInitialSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbInitialSystem.Location = new System.Drawing.Point(-1, 3);
            this.chbInitialSystem.Name = "chbInitialSystem";
            this.chbInitialSystem.Size = new System.Drawing.Size(144, 25);
            this.chbInitialSystem.TabIndex = 75;
            this.chbInitialSystem.Tag = "1";
            this.chbInitialSystem.Text = "Initial System";
            this.chbInitialSystem.Click += new System.EventHandler(this.chbWithdrawAndDepost_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel1.Controls.Add(this.chbInitialSystem);
            this.gunaPanel1.Location = new System.Drawing.Point(126, 342);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(252, 267);
            this.gunaPanel1.TabIndex = 76;
            // 
            // chbMoneyTransfer
            // 
            this.chbMoneyTransfer.BaseColor = System.Drawing.Color.White;
            this.chbMoneyTransfer.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbMoneyTransfer.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbMoneyTransfer.FillColor = System.Drawing.Color.White;
            this.chbMoneyTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbMoneyTransfer.Location = new System.Drawing.Point(0, 22);
            this.chbMoneyTransfer.Name = "chbMoneyTransfer";
            this.chbMoneyTransfer.Size = new System.Drawing.Size(164, 25);
            this.chbMoneyTransfer.TabIndex = 76;
            this.chbMoneyTransfer.Tag = "32";
            this.chbMoneyTransfer.Text = "Money Transfer";
            this.chbMoneyTransfer.Click += new System.EventHandler(this.chbWithdrawAndDepost_Click);
            // 
            // chbRemmitanceTransfer
            // 
            this.chbRemmitanceTransfer.BaseColor = System.Drawing.Color.White;
            this.chbRemmitanceTransfer.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbRemmitanceTransfer.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbRemmitanceTransfer.FillColor = System.Drawing.Color.White;
            this.chbRemmitanceTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbRemmitanceTransfer.Location = new System.Drawing.Point(0, 47);
            this.chbRemmitanceTransfer.Name = "chbRemmitanceTransfer";
            this.chbRemmitanceTransfer.Size = new System.Drawing.Size(207, 25);
            this.chbRemmitanceTransfer.TabIndex = 77;
            this.chbRemmitanceTransfer.Tag = "64";
            this.chbRemmitanceTransfer.Text = "Remmitance transfer";
            this.chbRemmitanceTransfer.Click += new System.EventHandler(this.chbWithdrawAndDepost_Click);
            // 
            // chbWithdrawAndDepost
            // 
            this.chbWithdrawAndDepost.BaseColor = System.Drawing.Color.White;
            this.chbWithdrawAndDepost.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbWithdrawAndDepost.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbWithdrawAndDepost.FillColor = System.Drawing.Color.White;
            this.chbWithdrawAndDepost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbWithdrawAndDepost.Location = new System.Drawing.Point(0, 72);
            this.chbWithdrawAndDepost.Name = "chbWithdrawAndDepost";
            this.chbWithdrawAndDepost.Size = new System.Drawing.Size(214, 25);
            this.chbWithdrawAndDepost.TabIndex = 78;
            this.chbWithdrawAndDepost.Tag = "128";
            this.chbWithdrawAndDepost.Text = "Withdraw And Depost";
            this.chbWithdrawAndDepost.Click += new System.EventHandler(this.chbWithdrawAndDepost_Click);
            // 
            // chbBuysCurrencies
            // 
            this.chbBuysCurrencies.BaseColor = System.Drawing.Color.White;
            this.chbBuysCurrencies.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbBuysCurrencies.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbBuysCurrencies.FillColor = System.Drawing.Color.White;
            this.chbBuysCurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbBuysCurrencies.Location = new System.Drawing.Point(0, 22);
            this.chbBuysCurrencies.Name = "chbBuysCurrencies";
            this.chbBuysCurrencies.Size = new System.Drawing.Size(171, 25);
            this.chbBuysCurrencies.TabIndex = 80;
            this.chbBuysCurrencies.Tag = "512";
            this.chbBuysCurrencies.Text = "Buys Currencies";
            this.chbBuysCurrencies.Click += new System.EventHandler(this.chbWithdrawAndDepost_Click);
            // 
            // chbSellCurrencies
            // 
            this.chbSellCurrencies.BaseColor = System.Drawing.Color.White;
            this.chbSellCurrencies.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbSellCurrencies.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbSellCurrencies.FillColor = System.Drawing.Color.White;
            this.chbSellCurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbSellCurrencies.Location = new System.Drawing.Point(0, 45);
            this.chbSellCurrencies.Name = "chbSellCurrencies";
            this.chbSellCurrencies.Size = new System.Drawing.Size(160, 25);
            this.chbSellCurrencies.TabIndex = 81;
            this.chbSellCurrencies.Tag = "1024";
            this.chbSellCurrencies.Text = "Sell Currencies";
            this.chbSellCurrencies.Click += new System.EventHandler(this.chbWithdrawAndDepost_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel2.Controls.Add(this.chbUpdateUser);
            this.gunaPanel2.Controls.Add(this.chbDeleteuser);
            this.gunaPanel2.Controls.Add(this.chbAddUser);
            this.gunaPanel2.Location = new System.Drawing.Point(396, 341);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(252, 268);
            this.gunaPanel2.TabIndex = 83;
            // 
            // chbUpdateUser
            // 
            this.chbUpdateUser.BaseColor = System.Drawing.Color.White;
            this.chbUpdateUser.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbUpdateUser.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbUpdateUser.FillColor = System.Drawing.Color.White;
            this.chbUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbUpdateUser.Location = new System.Drawing.Point(3, 49);
            this.chbUpdateUser.Name = "chbUpdateUser";
            this.chbUpdateUser.Size = new System.Drawing.Size(138, 25);
            this.chbUpdateUser.TabIndex = 83;
            this.chbUpdateUser.Tag = "8";
            this.chbUpdateUser.Text = "Update User";
            this.chbUpdateUser.Click += new System.EventHandler(this.chbWithdrawAndDepost_Click);
            // 
            // chbDeleteuser
            // 
            this.chbDeleteuser.BaseColor = System.Drawing.Color.White;
            this.chbDeleteuser.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbDeleteuser.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbDeleteuser.FillColor = System.Drawing.Color.White;
            this.chbDeleteuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbDeleteuser.Location = new System.Drawing.Point(3, 24);
            this.chbDeleteuser.Name = "chbDeleteuser";
            this.chbDeleteuser.Size = new System.Drawing.Size(132, 25);
            this.chbDeleteuser.TabIndex = 82;
            this.chbDeleteuser.Tag = "4";
            this.chbDeleteuser.Text = "Delete User";
            this.chbDeleteuser.Click += new System.EventHandler(this.chbWithdrawAndDepost_Click);
            // 
            // chbAddUser
            // 
            this.chbAddUser.BaseColor = System.Drawing.Color.White;
            this.chbAddUser.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbAddUser.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbAddUser.FillColor = System.Drawing.Color.White;
            this.chbAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbAddUser.Location = new System.Drawing.Point(3, -1);
            this.chbAddUser.Name = "chbAddUser";
            this.chbAddUser.Size = new System.Drawing.Size(120, 25);
            this.chbAddUser.TabIndex = 75;
            this.chbAddUser.Tag = "2";
            this.chbAddUser.Text = "Add Users";
            this.chbAddUser.Click += new System.EventHandler(this.chbWithdrawAndDepost_Click);
            // 
            // chbManageUsers
            // 
            this.chbManageUsers.BaseColor = System.Drawing.Color.White;
            this.chbManageUsers.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbManageUsers.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbManageUsers.FillColor = System.Drawing.Color.White;
            this.chbManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbManageUsers.Location = new System.Drawing.Point(397, 318);
            this.chbManageUsers.Name = "chbManageUsers";
            this.chbManageUsers.Size = new System.Drawing.Size(155, 25);
            this.chbManageUsers.TabIndex = 84;
            this.chbManageUsers.Text = "Manage Users";
            this.chbManageUsers.CheckedChanged += new System.EventHandler(this.chbManageUsers_CheckedChanged_1);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel3.Controls.Add(this.chbDopositMoney);
            this.gunaPanel3.Controls.Add(this.chbMoneyTransfer);
            this.gunaPanel3.Controls.Add(this.chbRemmitanceTransfer);
            this.gunaPanel3.Controls.Add(this.chbWithdrawAndDepost);
            this.gunaPanel3.Location = new System.Drawing.Point(654, 341);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(261, 280);
            this.gunaPanel3.TabIndex = 77;
            // 
            // chbDopositMoney
            // 
            this.chbDopositMoney.BaseColor = System.Drawing.Color.White;
            this.chbDopositMoney.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbDopositMoney.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbDopositMoney.FillColor = System.Drawing.Color.White;
            this.chbDopositMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbDopositMoney.Location = new System.Drawing.Point(-1, 0);
            this.chbDopositMoney.Name = "chbDopositMoney";
            this.chbDopositMoney.Size = new System.Drawing.Size(158, 25);
            this.chbDopositMoney.TabIndex = 75;
            this.chbDopositMoney.Tag = "16";
            this.chbDopositMoney.Text = "Doposit Money";
            this.chbDopositMoney.CheckedChanged += new System.EventHandler(this.chbDopositMoney_CheckedChanged);
            this.chbDopositMoney.Click += new System.EventHandler(this.chbWithdrawAndDepost_Click);
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel4.Controls.Add(this.chbExchangeCurrencies);
            this.gunaPanel4.Controls.Add(this.chbBuysCurrencies);
            this.gunaPanel4.Controls.Add(this.chbSellCurrencies);
            this.gunaPanel4.Location = new System.Drawing.Point(922, 341);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(252, 280);
            this.gunaPanel4.TabIndex = 77;
            // 
            // chbExchangeCurrencies
            // 
            this.chbExchangeCurrencies.BaseColor = System.Drawing.Color.White;
            this.chbExchangeCurrencies.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbExchangeCurrencies.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbExchangeCurrencies.FillColor = System.Drawing.Color.White;
            this.chbExchangeCurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbExchangeCurrencies.Location = new System.Drawing.Point(-1, 0);
            this.chbExchangeCurrencies.Name = "chbExchangeCurrencies";
            this.chbExchangeCurrencies.Size = new System.Drawing.Size(213, 25);
            this.chbExchangeCurrencies.TabIndex = 75;
            this.chbExchangeCurrencies.Tag = "256";
            this.chbExchangeCurrencies.Text = "Exchange Currencies";
            this.chbExchangeCurrencies.Click += new System.EventHandler(this.chbWithdrawAndDepost_Click);
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel5.Controls.Add(this.chbReportTransaction);
            this.gunaPanel5.Controls.Add(this.chbReportCurrency);
            this.gunaPanel5.Controls.Add(this.chbReportAcounts);
            this.gunaPanel5.Controls.Add(this.chbReportUsers);
            this.gunaPanel5.Location = new System.Drawing.Point(1182, 341);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(252, 280);
            this.gunaPanel5.TabIndex = 82;
            // 
            // chbReportTransaction
            // 
            this.chbReportTransaction.BaseColor = System.Drawing.Color.White;
            this.chbReportTransaction.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbReportTransaction.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbReportTransaction.FillColor = System.Drawing.Color.White;
            this.chbReportTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbReportTransaction.Location = new System.Drawing.Point(-3, 72);
            this.chbReportTransaction.Name = "chbReportTransaction";
            this.chbReportTransaction.Size = new System.Drawing.Size(188, 25);
            this.chbReportTransaction.TabIndex = 86;
            this.chbReportTransaction.Tag = "8192";
            this.chbReportTransaction.Text = "ReportTransaction";
            // 
            // chbReportCurrency
            // 
            this.chbReportCurrency.BaseColor = System.Drawing.Color.White;
            this.chbReportCurrency.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbReportCurrency.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbReportCurrency.FillColor = System.Drawing.Color.White;
            this.chbReportCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbReportCurrency.Location = new System.Drawing.Point(-3, 103);
            this.chbReportCurrency.Name = "chbReportCurrency";
            this.chbReportCurrency.Size = new System.Drawing.Size(170, 25);
            this.chbReportCurrency.TabIndex = 85;
            this.chbReportCurrency.Tag = "16384";
            this.chbReportCurrency.Text = "Report Currency";
            // 
            // chbReportAcounts
            // 
            this.chbReportAcounts.BaseColor = System.Drawing.Color.White;
            this.chbReportAcounts.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbReportAcounts.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbReportAcounts.FillColor = System.Drawing.Color.White;
            this.chbReportAcounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbReportAcounts.Location = new System.Drawing.Point(3, 38);
            this.chbReportAcounts.Name = "chbReportAcounts";
            this.chbReportAcounts.Size = new System.Drawing.Size(162, 25);
            this.chbReportAcounts.TabIndex = 84;
            this.chbReportAcounts.Tag = "4096";
            this.chbReportAcounts.Text = "Report Acounts";
            // 
            // chbReportUsers
            // 
            this.chbReportUsers.BaseColor = System.Drawing.Color.White;
            this.chbReportUsers.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbReportUsers.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbReportUsers.FillColor = System.Drawing.Color.White;
            this.chbReportUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chbReportUsers.Location = new System.Drawing.Point(3, 7);
            this.chbReportUsers.Name = "chbReportUsers";
            this.chbReportUsers.Size = new System.Drawing.Size(143, 25);
            this.chbReportUsers.TabIndex = 82;
            this.chbReportUsers.Tag = "2048";
            this.chbReportUsers.Text = "Report Users";
            // 
            // UCAddPermissionsToUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPanel5);
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.chbManageUsers);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.chbCurrency);
            this.Controls.Add(this.chbReports);
            this.Controls.Add(this.chbTransctions);
            this.Controls.Add(this.chbManagementSystem);
            this.Controls.Add(this.label3);
            this.Name = "UCAddPermissionsToUsers";
            this.Size = new System.Drawing.Size(1656, 646);
            this.Tag = "";
            this.Load += new System.EventHandler(this.UCAddPermissionsToUsers_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            this.gunaPanel4.ResumeLayout(false);
            this.gunaPanel4.PerformLayout();
            this.gunaPanel5.ResumeLayout(false);
            this.gunaPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaCheckBox chbManagementSystem;
        private Guna.UI.WinForms.GunaCheckBox chbTransctions;
        private Guna.UI.WinForms.GunaCheckBox chbReports;
        private Guna.UI.WinForms.GunaCheckBox chbCurrency;
        private System.Windows.Forms.ComboBox cmbUsers;
        private Guna.UI.WinForms.GunaButton btnPrint;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaCheckBox chbInitialSystem;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaCheckBox chbMoneyTransfer;
        private Guna.UI.WinForms.GunaCheckBox chbRemmitanceTransfer;
        private Guna.UI.WinForms.GunaCheckBox chbWithdrawAndDepost;
        private Guna.UI.WinForms.GunaCheckBox chbBuysCurrencies;
        private Guna.UI.WinForms.GunaCheckBox chbSellCurrencies;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaCheckBox chbAddUser;
        private Guna.UI.WinForms.GunaCheckBox chbUpdateUser;
        private Guna.UI.WinForms.GunaCheckBox chbDeleteuser;
        private Guna.UI.WinForms.GunaCheckBox chbManageUsers;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaCheckBox chbDopositMoney;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaCheckBox chbExchangeCurrencies;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private Guna.UI.WinForms.GunaCheckBox chbReportAcounts;
        private Guna.UI.WinForms.GunaCheckBox chbReportUsers;
        private Guna.UI.WinForms.GunaCheckBox chbReportTransaction;
        private Guna.UI.WinForms.GunaCheckBox chbReportCurrency;
    }
}
