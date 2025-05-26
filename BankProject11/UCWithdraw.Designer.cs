namespace BankProject11
{
    partial class UCWithdraw
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxAcountNO = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NRAmount = new System.Windows.Forms.NumericUpDown();
            this.txtbNotes = new Guna.UI.WinForms.GunaTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWithdrawt = new Guna.UI.WinForms.GunaButton();
            this.btnCancel = new Guna.UI.WinForms.GunaButton();
            this.lblCurrentAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NRAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(572, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 35);
            this.label4.TabIndex = 40;
            this.label4.Text = "Withdraw";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label3.Location = new System.Drawing.Point(360, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 27);
            this.label3.TabIndex = 37;
            this.label3.Text = "Note";
            // 
            // cbxAcountNO
            // 
            this.cbxAcountNO.BackColor = System.Drawing.Color.Transparent;
            this.cbxAcountNO.BaseColor = System.Drawing.Color.White;
            this.cbxAcountNO.BorderColor = System.Drawing.Color.Silver;
            this.cbxAcountNO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxAcountNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAcountNO.FocusedColor = System.Drawing.Color.Empty;
            this.cbxAcountNO.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxAcountNO.ForeColor = System.Drawing.Color.Black;
            this.cbxAcountNO.FormattingEnabled = true;
            this.cbxAcountNO.Location = new System.Drawing.Point(531, 221);
            this.cbxAcountNO.Name = "cbxAcountNO";
            this.cbxAcountNO.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxAcountNO.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxAcountNO.Size = new System.Drawing.Size(259, 31);
            this.cbxAcountNO.TabIndex = 34;
            this.cbxAcountNO.SelectedIndexChanged += new System.EventHandler(this.cbxAcountNO_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label2.Location = new System.Drawing.Point(360, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "Amount";
            // 
            // NRAmount
            // 
            this.NRAmount.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NRAmount.Location = new System.Drawing.Point(532, 267);
            this.NRAmount.Name = "NRAmount";
            this.NRAmount.Size = new System.Drawing.Size(258, 24);
            this.NRAmount.TabIndex = 32;
            // 
            // txtbNotes
            // 
            this.txtbNotes.BaseColor = System.Drawing.Color.White;
            this.txtbNotes.BorderColor = System.Drawing.Color.Silver;
            this.txtbNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbNotes.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbNotes.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbNotes.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbNotes.Location = new System.Drawing.Point(531, 303);
            this.txtbNotes.Name = "txtbNotes";
            this.txtbNotes.PasswordChar = '\0';
            this.txtbNotes.SelectedText = "";
            this.txtbNotes.Size = new System.Drawing.Size(258, 34);
            this.txtbNotes.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(924, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 24);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label1.Location = new System.Drawing.Point(360, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 27);
            this.label1.TabIndex = 35;
            this.label1.Text = "Acount Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label5.Location = new System.Drawing.Point(862, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 27);
            this.label5.TabIndex = 43;
            this.label5.Text = "Date";
            // 
            // btnWithdrawt
            // 
            this.btnWithdrawt.AnimationHoverSpeed = 0.07F;
            this.btnWithdrawt.AnimationSpeed = 0.03F;
            this.btnWithdrawt.BackColor = System.Drawing.Color.Transparent;
            this.btnWithdrawt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnWithdrawt.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWithdrawt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnWithdrawt.FocusedColor = System.Drawing.Color.Empty;
            this.btnWithdrawt.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.btnWithdrawt.ForeColor = System.Drawing.Color.Black;
            this.btnWithdrawt.Image = null;
            this.btnWithdrawt.ImageSize = new System.Drawing.Size(55, 55);
            this.btnWithdrawt.Location = new System.Drawing.Point(534, 509);
            this.btnWithdrawt.Name = "btnWithdrawt";
            this.btnWithdrawt.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnWithdrawt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnWithdrawt.OnHoverForeColor = System.Drawing.Color.White;
            this.btnWithdrawt.OnHoverImage = null;
            this.btnWithdrawt.OnPressedColor = System.Drawing.Color.Black;
            this.btnWithdrawt.Radius = 10;
            this.btnWithdrawt.Size = new System.Drawing.Size(141, 51);
            this.btnWithdrawt.TabIndex = 69;
            this.btnWithdrawt.Text = "Withdraw";
            this.btnWithdrawt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnWithdrawt.Click += new System.EventHandler(this.btnWithdrawt_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.Red;
            this.btnCancel.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(55, 55);
            this.btnCancel.Location = new System.Drawing.Point(681, 509);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Radius = 10;
            this.btnCancel.Size = new System.Drawing.Size(141, 51);
            this.btnCancel.TabIndex = 70;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurrentAmount
            // 
            this.lblCurrentAmount.AutoSize = true;
            this.lblCurrentAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.lblCurrentAmount.ForeColor = System.Drawing.Color.Green;
            this.lblCurrentAmount.Location = new System.Drawing.Point(878, 280);
            this.lblCurrentAmount.Name = "lblCurrentAmount";
            this.lblCurrentAmount.Size = new System.Drawing.Size(161, 25);
            this.lblCurrentAmount.TabIndex = 72;
            this.lblCurrentAmount.Text = "Current Amount";
            // 
            // UCWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCurrentAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnWithdrawt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtbNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxAcountNO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NRAmount);
            this.Name = "UCWithdraw";
            this.Size = new System.Drawing.Size(1377, 670);
            this.Load += new System.EventHandler(this.UCWithdraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NRAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cbxAcountNO;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.NumericUpDown NRAmount;
        private Guna.UI.WinForms.GunaTextBox txtbNotes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaButton btnWithdrawt;
        private Guna.UI.WinForms.GunaButton btnCancel;
        private System.Windows.Forms.Label lblCurrentAmount;
    }
}
