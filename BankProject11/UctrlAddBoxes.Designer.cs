namespace BankProject11
{
    partial class UctrlAddBoxes
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
            this.dgvOfBoxes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbID = new Guna.UI.WinForms.GunaTextBox();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtbBoxName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtbBalence = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtbBoxType = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmbUsers = new Guna.UI.WinForms.GunaComboBox();
            this.cmbCurrecy = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfBoxes)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOfBoxes
            // 
            this.dgvOfBoxes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOfBoxes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfBoxes.Location = new System.Drawing.Point(279, 394);
            this.dgvOfBoxes.Name = "dgvOfBoxes";
            this.dgvOfBoxes.RowHeadersWidth = 51;
            this.dgvOfBoxes.RowTemplate.Height = 26;
            this.dgvOfBoxes.Size = new System.Drawing.Size(1069, 290);
            this.dgvOfBoxes.TabIndex = 39;
            this.dgvOfBoxes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOfBoxes_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(577, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 76);
            this.panel1.TabIndex = 40;
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.Gray;
            this.btnDelete.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::BankProject11.Properties.Resources._27874_delete_remove_icon;
            this.btnDelete.ImageSize = new System.Drawing.Size(33, 33);
            this.btnDelete.Location = new System.Drawing.Point(200, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 10;
            this.btnDelete.Size = new System.Drawing.Size(132, 51);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.Gray;
            this.btnUpdate.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::BankProject11.Properties.Resources._27883_refresh_sync_synchronize_icon;
            this.btnUpdate.ImageSize = new System.Drawing.Size(33, 33);
            this.btnUpdate.Location = new System.Drawing.Point(338, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 10;
            this.btnUpdate.Size = new System.Drawing.Size(130, 51);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.Gray;
            this.btnAdd.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::BankProject11.Properties.Resources.remove;
            this.btnAdd.ImageSize = new System.Drawing.Size(33, 33);
            this.btnAdd.Location = new System.Drawing.Point(84, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(110, 51);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToUserToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 76);
            // 
            // addToUserToolStripMenuItem
            // 
            this.addToUserToolStripMenuItem.Name = "addToUserToolStripMenuItem";
            this.addToUserToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.addToUserToolStripMenuItem.Text = "Add to User";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // txtbID
            // 
            this.txtbID.BackColor = System.Drawing.Color.Transparent;
            this.txtbID.BaseColor = System.Drawing.Color.White;
            this.txtbID.BorderColor = System.Drawing.Color.Black;
            this.txtbID.BorderSize = 1;
            this.txtbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbID.Location = new System.Drawing.Point(414, 134);
            this.txtbID.Name = "txtbID";
            this.txtbID.PasswordChar = '\0';
            this.txtbID.Radius = 10;
            this.txtbID.ReadOnly = true;
            this.txtbID.SelectedText = "";
            this.txtbID.Size = new System.Drawing.Size(304, 34);
            this.txtbID.TabIndex = 43;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lblID.Location = new System.Drawing.Point(296, 140);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(83, 27);
            this.lblID.TabIndex = 44;
            this.lblID.Text = "Box No";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.gunaLabel1.Location = new System.Drawing.Point(296, 179);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(111, 27);
            this.gunaLabel1.TabIndex = 47;
            this.gunaLabel1.Text = "Box Name";
            // 
            // txtbBoxName
            // 
            this.txtbBoxName.BackColor = System.Drawing.Color.Transparent;
            this.txtbBoxName.BaseColor = System.Drawing.Color.White;
            this.txtbBoxName.BorderColor = System.Drawing.Color.Black;
            this.txtbBoxName.BorderSize = 1;
            this.txtbBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbBoxName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbBoxName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbBoxName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbBoxName.Location = new System.Drawing.Point(414, 174);
            this.txtbBoxName.Name = "txtbBoxName";
            this.txtbBoxName.PasswordChar = '\0';
            this.txtbBoxName.Radius = 10;
            this.txtbBoxName.SelectedText = "";
            this.txtbBoxName.Size = new System.Drawing.Size(304, 34);
            this.txtbBoxName.TabIndex = 46;
            this.txtbBoxName.TextChanged += new System.EventHandler(this.txtbBoxName_TextChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.gunaLabel3.Location = new System.Drawing.Point(801, 134);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(97, 27);
            this.gunaLabel3.TabIndex = 51;
            this.gunaLabel3.Text = "User Box";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.gunaLabel4.Location = new System.Drawing.Point(802, 214);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(85, 27);
            this.gunaLabel4.TabIndex = 49;
            this.gunaLabel4.Text = "Balence";
            // 
            // txtbBalence
            // 
            this.txtbBalence.BackColor = System.Drawing.Color.Transparent;
            this.txtbBalence.BaseColor = System.Drawing.Color.White;
            this.txtbBalence.BorderColor = System.Drawing.Color.Black;
            this.txtbBalence.BorderSize = 1;
            this.txtbBalence.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbBalence.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbBalence.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbBalence.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbBalence.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbBalence.Location = new System.Drawing.Point(904, 214);
            this.txtbBalence.Name = "txtbBalence";
            this.txtbBalence.PasswordChar = '\0';
            this.txtbBalence.Radius = 10;
            this.txtbBalence.SelectedText = "";
            this.txtbBalence.Size = new System.Drawing.Size(304, 34);
            this.txtbBalence.TabIndex = 48;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.gunaLabel2.Location = new System.Drawing.Point(298, 218);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(100, 27);
            this.gunaLabel2.TabIndex = 53;
            this.gunaLabel2.Text = "Box Type";
            // 
            // txtbBoxType
            // 
            this.txtbBoxType.BackColor = System.Drawing.Color.Transparent;
            this.txtbBoxType.BaseColor = System.Drawing.Color.White;
            this.txtbBoxType.BorderColor = System.Drawing.Color.Black;
            this.txtbBoxType.BorderSize = 1;
            this.txtbBoxType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbBoxType.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbBoxType.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbBoxType.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbBoxType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbBoxType.Location = new System.Drawing.Point(414, 214);
            this.txtbBoxType.Name = "txtbBoxType";
            this.txtbBoxType.PasswordChar = '\0';
            this.txtbBoxType.Radius = 10;
            this.txtbBoxType.SelectedText = "";
            this.txtbBoxType.Size = new System.Drawing.Size(304, 34);
            this.txtbBoxType.TabIndex = 52;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel5.Location = new System.Drawing.Point(726, 22);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(112, 43);
            this.gunaLabel5.TabIndex = 54;
            this.gunaLabel5.Text = "Boxes";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // cmbUsers
            // 
            this.cmbUsers.BackColor = System.Drawing.Color.Transparent;
            this.cmbUsers.BaseColor = System.Drawing.Color.White;
            this.cmbUsers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbUsers.BorderSize = 1;
            this.cmbUsers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.FocusedColor = System.Drawing.Color.Empty;
            this.cmbUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUsers.ForeColor = System.Drawing.Color.Black;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(904, 130);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbUsers.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbUsers.Radius = 10;
            this.cmbUsers.Size = new System.Drawing.Size(304, 31);
            this.cmbUsers.TabIndex = 55;
            // 
            // cmbCurrecy
            // 
            this.cmbCurrecy.BackColor = System.Drawing.Color.Transparent;
            this.cmbCurrecy.BaseColor = System.Drawing.Color.White;
            this.cmbCurrecy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbCurrecy.BorderSize = 1;
            this.cmbCurrecy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCurrecy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrecy.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCurrecy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCurrecy.ForeColor = System.Drawing.Color.Black;
            this.cmbCurrecy.FormattingEnabled = true;
            this.cmbCurrecy.Location = new System.Drawing.Point(904, 174);
            this.cmbCurrecy.Name = "cmbCurrecy";
            this.cmbCurrecy.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCurrecy.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCurrecy.Radius = 10;
            this.cmbCurrecy.Size = new System.Drawing.Size(304, 31);
            this.cmbCurrecy.TabIndex = 57;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.gunaLabel6.Location = new System.Drawing.Point(801, 177);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(97, 27);
            this.gunaLabel6.TabIndex = 56;
            this.gunaLabel6.Text = "Currency";
            // 
            // UctrlAddBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbCurrecy);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtbBoxType);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtbBalence);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtbBoxName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtbID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvOfBoxes);
            this.Name = "UctrlAddBoxes";
            this.Size = new System.Drawing.Size(1509, 737);
            this.Load += new System.EventHandler(this.UctrlAddBoxes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfBoxes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOfBoxes;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI.WinForms.GunaTextBox txtbID;
        private Guna.UI.WinForms.GunaLabel lblID;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtbBoxName;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtbBalence;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtbBoxType;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private Guna.UI.WinForms.GunaComboBox cmbUsers;
        private Guna.UI.WinForms.GunaComboBox cmbCurrecy;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
    }
}
