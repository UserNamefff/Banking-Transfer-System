namespace BankProject11
{
    partial class UCAddCountries
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new Guna.UI.WinForms.GunaButton();
            this.bntCancel = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbCountryName = new Guna.UI.WinForms.GunaTextBox();
            this.txtbCountrtyNO = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbCountryCode = new Guna.UI.WinForms.GunaTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(427, 449);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(920, 275);
            this.dataGridView1.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.bntCancel);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(427, 354);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(920, 89);
            this.panel1.TabIndex = 22;
            // 
            // btnPrint
            // 
            this.btnPrint.AnimationHoverSpeed = 0.07F;
            this.btnPrint.AnimationSpeed = 0.03F;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.btnPrint.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::BankProject11.Properties.Resources._44993_print_icon__1_;
            this.btnPrint.ImageSize = new System.Drawing.Size(55, 55);
            this.btnPrint.Location = new System.Drawing.Point(642, 17);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPrint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint.OnHoverImage = null;
            this.btnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint.Radius = 10;
            this.btnPrint.Size = new System.Drawing.Size(159, 66);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            // 
            // bntCancel
            // 
            this.bntCancel.AnimationHoverSpeed = 0.07F;
            this.bntCancel.AnimationSpeed = 0.03F;
            this.bntCancel.BackColor = System.Drawing.Color.Transparent;
            this.bntCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.bntCancel.BorderColor = System.Drawing.Color.DarkGray;
            this.bntCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bntCancel.FocusedColor = System.Drawing.Color.Empty;
            this.bntCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancel.ForeColor = System.Drawing.Color.White;
            this.bntCancel.Image = global::BankProject11.Properties.Resources._27836_approve_block_cancel_delete_reject_icon__1_;
            this.bntCancel.ImageSize = new System.Drawing.Size(50, 50);
            this.bntCancel.Location = new System.Drawing.Point(309, 14);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.bntCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bntCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.bntCancel.OnHoverImage = null;
            this.bntCancel.OnPressedColor = System.Drawing.Color.Black;
            this.bntCancel.Radius = 10;
            this.bntCancel.Size = new System.Drawing.Size(159, 66);
            this.bntCancel.TabIndex = 2;
            this.bntCancel.Text = "Cancel";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::BankProject11.Properties.Resources._27883_refresh_sync_synchronize_icon;
            this.btnUpdate.ImageSize = new System.Drawing.Size(50, 50);
            this.btnUpdate.Location = new System.Drawing.Point(477, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 10;
            this.btnUpdate.Size = new System.Drawing.Size(159, 66);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.btnAdd.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::BankProject11.Properties.Resources.Add1;
            this.btnAdd.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAdd.Location = new System.Drawing.Point(145, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(154, 66);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(517, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Country Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Country NO";
            // 
            // txtbCountryName
            // 
            this.txtbCountryName.BackColor = System.Drawing.Color.Transparent;
            this.txtbCountryName.BaseColor = System.Drawing.Color.White;
            this.txtbCountryName.BorderColor = System.Drawing.Color.Black;
            this.txtbCountryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbCountryName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbCountryName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbCountryName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbCountryName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.errorProvider1.SetIconPadding(this.txtbCountryName, 2);
            this.errorProvider2.SetIconPadding(this.txtbCountryName, 2);
            this.txtbCountryName.Location = new System.Drawing.Point(681, 222);
            this.txtbCountryName.Name = "txtbCountryName";
            this.txtbCountryName.PasswordChar = '\0';
            this.txtbCountryName.Radius = 10;
            this.txtbCountryName.SelectedText = "";
            this.txtbCountryName.Size = new System.Drawing.Size(413, 45);
            this.txtbCountryName.TabIndex = 19;
            this.txtbCountryName.Validating += new System.ComponentModel.CancelEventHandler(this.txtbCountryName_Validating);
            // 
            // txtbCountrtyNO
            // 
            this.txtbCountrtyNO.BackColor = System.Drawing.Color.Transparent;
            this.txtbCountrtyNO.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtbCountrtyNO.BorderColor = System.Drawing.Color.Black;
            this.txtbCountrtyNO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbCountrtyNO.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbCountrtyNO.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbCountrtyNO.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbCountrtyNO.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtbCountrtyNO.Location = new System.Drawing.Point(681, 171);
            this.txtbCountrtyNO.Name = "txtbCountrtyNO";
            this.txtbCountrtyNO.PasswordChar = '\0';
            this.txtbCountrtyNO.Radius = 10;
            this.txtbCountrtyNO.ReadOnly = true;
            this.txtbCountrtyNO.SelectedText = "";
            this.txtbCountrtyNO.Size = new System.Drawing.Size(413, 45);
            this.txtbCountrtyNO.TabIndex = 18;
            this.txtbCountrtyNO.TextChanged += new System.EventHandler(this.txtbCountrtyNO_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(754, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 35);
            this.label4.TabIndex = 28;
            this.label4.Text = "Add Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Country Code";
            // 
            // txtbCountryCode
            // 
            this.txtbCountryCode.BackColor = System.Drawing.Color.Transparent;
            this.txtbCountryCode.BaseColor = System.Drawing.Color.White;
            this.txtbCountryCode.BorderColor = System.Drawing.Color.Black;
            this.txtbCountryCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbCountryCode.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbCountryCode.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbCountryCode.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbCountryCode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtbCountryCode.Location = new System.Drawing.Point(681, 273);
            this.txtbCountryCode.Name = "txtbCountryCode";
            this.txtbCountryCode.PasswordChar = '\0';
            this.txtbCountryCode.Radius = 10;
            this.txtbCountryCode.SelectedText = "";
            this.txtbCountryCode.Size = new System.Drawing.Size(413, 45);
            this.txtbCountryCode.TabIndex = 29;
            this.txtbCountryCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtbCountryName_Validating);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(90, 28);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.dToolStripMenuItem.Text = "D";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // UCAddCountries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbCountryCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbCountryName);
            this.Controls.Add(this.txtbCountrtyNO);
            this.Name = "UCAddCountries";
            this.Size = new System.Drawing.Size(1803, 831);
            this.Load += new System.EventHandler(this.UCAddCountries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnPrint;
        private Guna.UI.WinForms.GunaButton bntCancel;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtbCountryName;
        private Guna.UI.WinForms.GunaTextBox txtbCountrtyNO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtbCountryCode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
