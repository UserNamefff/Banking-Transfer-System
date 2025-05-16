namespace BankProject11
{
    partial class UCAddCurrency
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new Guna.UI.WinForms.GunaButton();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.bntCancel = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbCurrencyName = new Guna.UI.WinForms.GunaTextBox();
            this.txtbCurrencyNO = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbCurrencyRate = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(259, 414);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 225);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.bntCancel);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(426, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 87);
            this.panel1.TabIndex = 22;
            // 
            // btnPrint
            // 
            this.btnPrint.AnimationHoverSpeed = 0.07F;
            this.btnPrint.AnimationSpeed = 0.03F;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BaseColor = System.Drawing.Color.Gray;
            this.btnPrint.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::BankProject11.Properties.Resources._44993_print_icon__1_;
            this.btnPrint.ImageSize = new System.Drawing.Size(55, 55);
            this.btnPrint.Location = new System.Drawing.Point(614, 11);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPrint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint.OnHoverImage = null;
            this.btnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint.Radius = 10;
            this.btnPrint.Size = new System.Drawing.Size(141, 60);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
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
            this.btnDelete.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDelete.Location = new System.Drawing.Point(467, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 10;
            this.btnDelete.Size = new System.Drawing.Size(141, 60);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            // 
            // bntCancel
            // 
            this.bntCancel.AnimationHoverSpeed = 0.07F;
            this.bntCancel.AnimationSpeed = 0.03F;
            this.bntCancel.BackColor = System.Drawing.Color.Transparent;
            this.bntCancel.BaseColor = System.Drawing.Color.Gray;
            this.bntCancel.BorderColor = System.Drawing.Color.DarkGray;
            this.bntCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bntCancel.FocusedColor = System.Drawing.Color.Empty;
            this.bntCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bntCancel.ForeColor = System.Drawing.Color.White;
            this.bntCancel.Image = global::BankProject11.Properties.Resources._27836_approve_block_cancel_delete_reject_icon__1_;
            this.bntCancel.ImageSize = new System.Drawing.Size(50, 50);
            this.bntCancel.Location = new System.Drawing.Point(175, 11);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.bntCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bntCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.bntCancel.OnHoverImage = null;
            this.bntCancel.OnPressedColor = System.Drawing.Color.Black;
            this.bntCancel.Radius = 10;
            this.bntCancel.Size = new System.Drawing.Size(139, 60);
            this.bntCancel.TabIndex = 2;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
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
            this.btnUpdate.ImageSize = new System.Drawing.Size(50, 50);
            this.btnUpdate.Location = new System.Drawing.Point(322, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 10;
            this.btnUpdate.Size = new System.Drawing.Size(139, 60);
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
            this.btnAdd.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAdd.Location = new System.Drawing.Point(28, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(139, 60);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Currency name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Currency NO";
            // 
            // txtbCurrencyName
            // 
            this.txtbCurrencyName.BackColor = System.Drawing.Color.Transparent;
            this.txtbCurrencyName.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtbCurrencyName.BorderColor = System.Drawing.Color.Navy;
            this.txtbCurrencyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbCurrencyName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbCurrencyName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbCurrencyName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbCurrencyName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbCurrencyName.Location = new System.Drawing.Point(636, 171);
            this.txtbCurrencyName.Name = "txtbCurrencyName";
            this.txtbCurrencyName.PasswordChar = '\0';
            this.txtbCurrencyName.Radius = 10;
            this.txtbCurrencyName.SelectedText = "";
            this.txtbCurrencyName.Size = new System.Drawing.Size(359, 45);
            this.txtbCurrencyName.TabIndex = 19;
            // 
            // txtbCurrencyNO
            // 
            this.txtbCurrencyNO.BackColor = System.Drawing.Color.Transparent;
            this.txtbCurrencyNO.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtbCurrencyNO.BorderColor = System.Drawing.Color.Navy;
            this.txtbCurrencyNO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbCurrencyNO.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbCurrencyNO.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbCurrencyNO.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbCurrencyNO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbCurrencyNO.Location = new System.Drawing.Point(636, 120);
            this.txtbCurrencyNO.Name = "txtbCurrencyNO";
            this.txtbCurrencyNO.PasswordChar = '\0';
            this.txtbCurrencyNO.Radius = 10;
            this.txtbCurrencyNO.ReadOnly = true;
            this.txtbCurrencyNO.SelectedText = "";
            this.txtbCurrencyNO.Size = new System.Drawing.Size(359, 45);
            this.txtbCurrencyNO.TabIndex = 18;
            this.txtbCurrencyNO.TextChanged += new System.EventHandler(this.txtbCityNO_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Currency Rate";
            // 
            // txtbCurrencyRate
            // 
            this.txtbCurrencyRate.BackColor = System.Drawing.Color.Transparent;
            this.txtbCurrencyRate.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtbCurrencyRate.BorderColor = System.Drawing.Color.Navy;
            this.txtbCurrencyRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbCurrencyRate.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbCurrencyRate.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbCurrencyRate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbCurrencyRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbCurrencyRate.Location = new System.Drawing.Point(636, 222);
            this.txtbCurrencyRate.Name = "txtbCurrencyRate";
            this.txtbCurrencyRate.PasswordChar = '\0';
            this.txtbCurrencyRate.Radius = 10;
            this.txtbCurrencyRate.SelectedText = "";
            this.txtbCurrencyRate.Size = new System.Drawing.Size(359, 45);
            this.txtbCurrencyRate.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(685, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 35);
            this.label4.TabIndex = 27;
            this.label4.Text = "Add Currency";
            // 
            // UCAddCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbCurrencyRate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbCurrencyName);
            this.Controls.Add(this.txtbCurrencyNO);
            this.Name = "UCAddCurrency";
            this.Size = new System.Drawing.Size(1578, 831);
            this.Load += new System.EventHandler(this.UCAddCurrency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnPrint;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton bntCancel;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtbCurrencyName;
        private Guna.UI.WinForms.GunaTextBox txtbCurrencyNO;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtbCurrencyRate;
        private System.Windows.Forms.Label label4;
    }
}
