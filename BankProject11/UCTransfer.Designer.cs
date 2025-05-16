namespace BankProject11
{
    partial class UCTransfer
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAccountSender = new System.Windows.Forms.Label();
            this.txtbAccountSender = new Guna.UI.WinForms.GunaTextBox();
            this.cmbCurrencyName = new Guna.UI.WinForms.GunaComboBox();
            this.cmbSourceBranch = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTargeteBranch = new Guna.UI.WinForms.GunaComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTransferType = new Guna.UI.WinForms.GunaComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTransferStatus = new Guna.UI.WinForms.GunaComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new Guna.UI.WinForms.GunaButton();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.bntCancel = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaNumeric2 = new Guna.UI.WinForms.GunaNumeric();
            this.gunaNumeric3 = new Guna.UI.WinForms.GunaNumeric();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbRemmitanceType = new Guna.UI.WinForms.GunaComboBox();
            this.lblAccountRecierver = new System.Windows.Forms.Label();
            this.txtbAccountRecierver = new Guna.UI.WinForms.GunaTextBox();
            this.gunaComboBox2 = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgTransfer = new System.Windows.Forms.DataGridView();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.ucSenderAndRecierverInfo1 = new BankProject11.UCSenderAndRecierverInfo();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransfer)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(1031, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fee Amount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(133, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "send Amount ";
            // 
            // lblAccountSender
            // 
            this.lblAccountSender.AutoSize = true;
            this.lblAccountSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAccountSender.Location = new System.Drawing.Point(1026, 166);
            this.lblAccountSender.Name = "lblAccountSender";
            this.lblAccountSender.Size = new System.Drawing.Size(126, 24);
            this.lblAccountSender.TabIndex = 26;
            this.lblAccountSender.Text = "Account Num";
            this.lblAccountSender.Visible = false;
            // 
            // txtbAccountSender
            // 
            this.txtbAccountSender.BackColor = System.Drawing.Color.Transparent;
            this.txtbAccountSender.BaseColor = System.Drawing.Color.White;
            this.txtbAccountSender.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbAccountSender.BorderSize = 1;
            this.txtbAccountSender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbAccountSender.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbAccountSender.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbAccountSender.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbAccountSender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbAccountSender.Location = new System.Drawing.Point(1196, 163);
            this.txtbAccountSender.Name = "txtbAccountSender";
            this.txtbAccountSender.PasswordChar = '\0';
            this.txtbAccountSender.Radius = 10;
            this.txtbAccountSender.SelectedText = "";
            this.txtbAccountSender.Size = new System.Drawing.Size(277, 33);
            this.txtbAccountSender.TabIndex = 25;
            this.txtbAccountSender.Visible = false;
            // 
            // cmbCurrencyName
            // 
            this.cmbCurrencyName.BackColor = System.Drawing.Color.Transparent;
            this.cmbCurrencyName.BaseColor = System.Drawing.Color.White;
            this.cmbCurrencyName.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbCurrencyName.BorderSize = 1;
            this.cmbCurrencyName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCurrencyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrencyName.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCurrencyName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCurrencyName.ForeColor = System.Drawing.Color.Black;
            this.cmbCurrencyName.FormatString = "C2";
            this.cmbCurrencyName.FormattingEnabled = true;
            this.cmbCurrencyName.Location = new System.Drawing.Point(741, 241);
            this.cmbCurrencyName.Name = "cmbCurrencyName";
            this.cmbCurrencyName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCurrencyName.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCurrencyName.Radius = 10;
            this.cmbCurrencyName.Size = new System.Drawing.Size(264, 31);
            this.cmbCurrencyName.TabIndex = 33;
            this.cmbCurrencyName.SelectedIndexChanged += new System.EventHandler(this.cmbCurrencyName_SelectedIndexChanged);
            // 
            // cmbSourceBranch
            // 
            this.cmbSourceBranch.BackColor = System.Drawing.Color.Transparent;
            this.cmbSourceBranch.BaseColor = System.Drawing.Color.White;
            this.cmbSourceBranch.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbSourceBranch.BorderSize = 1;
            this.cmbSourceBranch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSourceBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSourceBranch.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSourceBranch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSourceBranch.ForeColor = System.Drawing.Color.Black;
            this.cmbSourceBranch.FormattingEnabled = true;
            this.cmbSourceBranch.Location = new System.Drawing.Point(290, 129);
            this.cmbSourceBranch.Name = "cmbSourceBranch";
            this.cmbSourceBranch.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbSourceBranch.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbSourceBranch.Radius = 10;
            this.cmbSourceBranch.Size = new System.Drawing.Size(262, 31);
            this.cmbSourceBranch.TabIndex = 34;
            this.cmbSourceBranch.SelectedIndexChanged += new System.EventHandler(this.cmbSourceBranch_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(133, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Source Branch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(594, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Currency Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(592, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "Targete Branch";
            // 
            // cmbTargeteBranch
            // 
            this.cmbTargeteBranch.AllowDrop = true;
            this.cmbTargeteBranch.BackColor = System.Drawing.Color.Transparent;
            this.cmbTargeteBranch.BaseColor = System.Drawing.Color.White;
            this.cmbTargeteBranch.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbTargeteBranch.BorderSize = 1;
            this.cmbTargeteBranch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTargeteBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargeteBranch.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTargeteBranch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTargeteBranch.ForeColor = System.Drawing.Color.Black;
            this.cmbTargeteBranch.FormattingEnabled = true;
            this.cmbTargeteBranch.Location = new System.Drawing.Point(739, 129);
            this.cmbTargeteBranch.MaxDropDownItems = 10;
            this.cmbTargeteBranch.Name = "cmbTargeteBranch";
            this.cmbTargeteBranch.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbTargeteBranch.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbTargeteBranch.Radius = 10;
            this.cmbTargeteBranch.Size = new System.Drawing.Size(264, 31);
            this.cmbTargeteBranch.TabIndex = 37;
            this.cmbTargeteBranch.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.cmbTargeteBranch.SelectedIndexChanged += new System.EventHandler(this.cmbTargeteBranch_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(1023, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 24);
            this.label8.TabIndex = 42;
            this.label8.Text = "Transfer Type";
            // 
            // cmbTransferType
            // 
            this.cmbTransferType.AllowDrop = true;
            this.cmbTransferType.BackColor = System.Drawing.Color.Transparent;
            this.cmbTransferType.BaseColor = System.Drawing.Color.White;
            this.cmbTransferType.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbTransferType.BorderSize = 1;
            this.cmbTransferType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTransferType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransferType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTransferType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTransferType.ForeColor = System.Drawing.Color.Black;
            this.cmbTransferType.FormattingEnabled = true;
            this.cmbTransferType.Location = new System.Drawing.Point(1196, 129);
            this.cmbTransferType.MaxDropDownItems = 10;
            this.cmbTransferType.Name = "cmbTransferType";
            this.cmbTransferType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbTransferType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbTransferType.Radius = 10;
            this.cmbTransferType.Size = new System.Drawing.Size(277, 31);
            this.cmbTransferType.TabIndex = 41;
            this.cmbTransferType.SelectedIndexChanged += new System.EventHandler(this.cmbTransferType_SelectedIndexChanged);
            this.cmbTransferType.Click += new System.EventHandler(this.cmbTransferType_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(134, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 25);
            this.label9.TabIndex = 44;
            this.label9.Text = "NotesTransfer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(130, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 25);
            this.label10.TabIndex = 45;
            this.label10.Text = "Transfer Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(594, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Transfer status";
            // 
            // cmbTransferStatus
            // 
            this.cmbTransferStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbTransferStatus.BaseColor = System.Drawing.Color.White;
            this.cmbTransferStatus.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbTransferStatus.BorderSize = 1;
            this.cmbTransferStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTransferStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransferStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTransferStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTransferStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbTransferStatus.FormattingEnabled = true;
            this.cmbTransferStatus.Location = new System.Drawing.Point(743, 274);
            this.cmbTransferStatus.MaxDropDownItems = 10;
            this.cmbTransferStatus.Name = "cmbTransferStatus";
            this.cmbTransferStatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbTransferStatus.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbTransferStatus.Radius = 10;
            this.cmbTransferStatus.Size = new System.Drawing.Size(262, 31);
            this.cmbTransferStatus.TabIndex = 46;
            this.cmbTransferStatus.SelectedIndexChanged += new System.EventHandler(this.cmbTransferStatus_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.bntCancel);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(507, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 80);
            this.panel1.TabIndex = 48;
            // 
            // btnPrint
            // 
            this.btnPrint.AnimationHoverSpeed = 0.07F;
            this.btnPrint.AnimationSpeed = 0.03F;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BaseColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPrint.BorderColor = System.Drawing.Color.Black;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::BankProject11.Properties.Resources._44993_print_icon__1_;
            this.btnPrint.ImageSize = new System.Drawing.Size(45, 45);
            this.btnPrint.Location = new System.Drawing.Point(581, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPrint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint.OnHoverImage = null;
            this.btnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint.Radius = 10;
            this.btnPrint.Size = new System.Drawing.Size(134, 57);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::BankProject11.Properties.Resources._27874_delete_remove_icon;
            this.btnDelete.ImageSize = new System.Drawing.Size(45, 45);
            this.btnDelete.Location = new System.Drawing.Point(440, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 10;
            this.btnDelete.Size = new System.Drawing.Size(134, 57);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            // 
            // bntCancel
            // 
            this.bntCancel.AnimationHoverSpeed = 0.07F;
            this.bntCancel.AnimationSpeed = 0.03F;
            this.bntCancel.BackColor = System.Drawing.Color.Transparent;
            this.bntCancel.BaseColor = System.Drawing.SystemColors.InactiveCaption;
            this.bntCancel.BorderColor = System.Drawing.Color.Black;
            this.bntCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bntCancel.FocusedColor = System.Drawing.Color.Empty;
            this.bntCancel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancel.ForeColor = System.Drawing.Color.White;
            this.bntCancel.Image = global::BankProject11.Properties.Resources._27836_approve_block_cancel_delete_reject_icon__1_;
            this.bntCancel.ImageSize = new System.Drawing.Size(45, 45);
            this.bntCancel.Location = new System.Drawing.Point(155, 12);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.bntCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bntCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.bntCancel.OnHoverImage = null;
            this.bntCancel.OnPressedColor = System.Drawing.Color.Black;
            this.bntCancel.Radius = 10;
            this.bntCancel.Size = new System.Drawing.Size(132, 57);
            this.bntCancel.TabIndex = 2;
            this.bntCancel.Text = "Cancel";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::BankProject11.Properties.Resources._27883_refresh_sync_synchronize_icon;
            this.btnUpdate.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUpdate.Location = new System.Drawing.Point(294, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 10;
            this.btnUpdate.Size = new System.Drawing.Size(138, 57);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::BankProject11.Properties.Resources.remove;
            this.btnAdd.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAdd.Location = new System.Drawing.Point(25, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(121, 57);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 839);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1537, 21);
            this.panel2.TabIndex = 50;
            // 
            // gunaNumeric2
            // 
            this.gunaNumeric2.BackColor = System.Drawing.Color.Transparent;
            this.gunaNumeric2.BaseColor = System.Drawing.Color.White;
            this.gunaNumeric2.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaNumeric2.ButtonColor = System.Drawing.Color.Maroon;
            this.gunaNumeric2.ButtonForeColor = System.Drawing.Color.White;
            this.gunaNumeric2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaNumeric2.ForeColor = System.Drawing.Color.Black;
            this.gunaNumeric2.Location = new System.Drawing.Point(1196, 267);
            this.gunaNumeric2.Maximum = ((long)(9999999));
            this.gunaNumeric2.Minimum = ((long)(0));
            this.gunaNumeric2.Name = "gunaNumeric2";
            this.gunaNumeric2.Radius = 10;
            this.gunaNumeric2.Size = new System.Drawing.Size(277, 30);
            this.gunaNumeric2.TabIndex = 54;
            this.gunaNumeric2.Text = "gunaNumeric2";
            this.gunaNumeric2.Value = ((long)(0));
            // 
            // gunaNumeric3
            // 
            this.gunaNumeric3.BackColor = System.Drawing.Color.Transparent;
            this.gunaNumeric3.BaseColor = System.Drawing.Color.White;
            this.gunaNumeric3.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaNumeric3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaNumeric3.ButtonForeColor = System.Drawing.Color.White;
            this.gunaNumeric3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaNumeric3.ForeColor = System.Drawing.Color.Black;
            this.gunaNumeric3.Location = new System.Drawing.Point(293, 245);
            this.gunaNumeric3.Maximum = ((long)(9999999));
            this.gunaNumeric3.Minimum = ((long)(0));
            this.gunaNumeric3.Name = "gunaNumeric3";
            this.gunaNumeric3.Radius = 10;
            this.gunaNumeric3.Size = new System.Drawing.Size(266, 30);
            this.gunaNumeric3.TabIndex = 55;
            this.gunaNumeric3.Text = "gunaNumeric3";
            this.gunaNumeric3.Value = ((long)(0));
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(290, 281);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(269, 48);
            this.txtDescription.TabIndex = 57;
            this.txtDescription.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(1027, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 24);
            this.label11.TabIndex = 59;
            this.label11.Text = "Remmitance Type";
            // 
            // cmbRemmitanceType
            // 
            this.cmbRemmitanceType.BackColor = System.Drawing.Color.Transparent;
            this.cmbRemmitanceType.BaseColor = System.Drawing.Color.White;
            this.cmbRemmitanceType.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbRemmitanceType.BorderSize = 1;
            this.cmbRemmitanceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRemmitanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRemmitanceType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRemmitanceType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRemmitanceType.ForeColor = System.Drawing.Color.Black;
            this.cmbRemmitanceType.FormattingEnabled = true;
            this.cmbRemmitanceType.Location = new System.Drawing.Point(1196, 199);
            this.cmbRemmitanceType.MaxDropDownItems = 10;
            this.cmbRemmitanceType.Name = "cmbRemmitanceType";
            this.cmbRemmitanceType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbRemmitanceType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbRemmitanceType.Radius = 10;
            this.cmbRemmitanceType.Size = new System.Drawing.Size(277, 31);
            this.cmbRemmitanceType.TabIndex = 58;
            // 
            // lblAccountRecierver
            // 
            this.lblAccountRecierver.AutoSize = true;
            this.lblAccountRecierver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAccountRecierver.Location = new System.Drawing.Point(1027, 237);
            this.lblAccountRecierver.Name = "lblAccountRecierver";
            this.lblAccountRecierver.Size = new System.Drawing.Size(126, 24);
            this.lblAccountRecierver.TabIndex = 61;
            this.lblAccountRecierver.Text = "Account Num";
            this.lblAccountRecierver.Visible = false;
            // 
            // txtbAccountRecierver
            // 
            this.txtbAccountRecierver.BackColor = System.Drawing.Color.Transparent;
            this.txtbAccountRecierver.BaseColor = System.Drawing.Color.White;
            this.txtbAccountRecierver.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbAccountRecierver.BorderSize = 1;
            this.txtbAccountRecierver.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbAccountRecierver.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbAccountRecierver.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbAccountRecierver.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbAccountRecierver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbAccountRecierver.Location = new System.Drawing.Point(1196, 232);
            this.txtbAccountRecierver.Name = "txtbAccountRecierver";
            this.txtbAccountRecierver.PasswordChar = '\0';
            this.txtbAccountRecierver.Radius = 10;
            this.txtbAccountRecierver.SelectedText = "";
            this.txtbAccountRecierver.Size = new System.Drawing.Size(277, 33);
            this.txtbAccountRecierver.TabIndex = 60;
            this.txtbAccountRecierver.Visible = false;
            // 
            // gunaComboBox2
            // 
            this.gunaComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox2.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox2.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaComboBox2.BorderSize = 1;
            this.gunaComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox2.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox2.FormattingEnabled = true;
            this.gunaComboBox2.Location = new System.Drawing.Point(141, 425);
            this.gunaComboBox2.MaxDropDownItems = 10;
            this.gunaComboBox2.Name = "gunaComboBox2";
            this.gunaComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox2.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox2.Radius = 10;
            this.gunaComboBox2.Size = new System.Drawing.Size(223, 31);
            this.gunaComboBox2.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(141, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "Filter";
            // 
            // dgTransfer
            // 
            this.dgTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransfer.Location = new System.Drawing.Point(141, 462);
            this.dgTransfer.Name = "dgTransfer";
            this.dgTransfer.RowHeadersWidth = 51;
            this.dgTransfer.RowTemplate.Height = 26;
            this.dgTransfer.Size = new System.Drawing.Size(1339, 328);
            this.dgTransfer.TabIndex = 66;
            this.dgTransfer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTransfer_CellClick);
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePicker1.CustomFormat = null;
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(288, 43);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(2077, 11, 16, 23, 59, 59, 999);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1900, 4, 30, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Radius = 10;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(264, 45);
            this.gunaDateTimePicker1.TabIndex = 40;
            this.gunaDateTimePicker1.Text = "1446/شوال/10";
            this.gunaDateTimePicker1.Value = new System.DateTime(2025, 4, 8, 0, 43, 36, 792);
            // 
            // ucSenderAndRecierverInfo1
            // 
            this.ucSenderAndRecierverInfo1.Location = new System.Drawing.Point(131, 163);
            this.ucSenderAndRecierverInfo1.Name = "ucSenderAndRecierverInfo1";
            this.ucSenderAndRecierverInfo1.Size = new System.Drawing.Size(880, 76);
            this.ucSenderAndRecierverInfo1.TabIndex = 65;
            this.ucSenderAndRecierverInfo1.Load += new System.EventHandler(this.ucSenderAndRecierverInfo1_Load);
            // 
            // UCTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgTransfer);
            this.Controls.Add(this.ucSenderAndRecierverInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaComboBox2);
            this.Controls.Add(this.lblAccountRecierver);
            this.Controls.Add(this.txtbAccountRecierver);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbRemmitanceType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.gunaNumeric3);
            this.Controls.Add(this.gunaNumeric2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTransferStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTransferType);
            this.Controls.Add(this.gunaDateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTargeteBranch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSourceBranch);
            this.Controls.Add(this.cmbCurrencyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAccountSender);
            this.Controls.Add(this.txtbAccountSender);
            this.Name = "UCTransfer";
            this.Size = new System.Drawing.Size(1537, 860);
            this.Load += new System.EventHandler(this.UCTransfer_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransfer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAccountSender;
        private Guna.UI.WinForms.GunaTextBox txtbAccountSender;
        private Guna.UI.WinForms.GunaComboBox cmbCurrencyName;
        private Guna.UI.WinForms.GunaComboBox cmbSourceBranch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaComboBox cmbTargeteBranch;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaComboBox cmbTransferType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cmbTransferStatus;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnPrint;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton bntCancel;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaNumeric gunaNumeric2;
        private Guna.UI.WinForms.GunaNumeric gunaNumeric3;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaComboBox cmbRemmitanceType;
        private System.Windows.Forms.Label lblAccountRecierver;
        private Guna.UI.WinForms.GunaTextBox txtbAccountRecierver;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private UCSenderAndRecierverInfo ucSenderAndRecierverInfo1;
        private System.Windows.Forms.DataGridView dgTransfer;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
    }
}
