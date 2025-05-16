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
            this.bntCancel = new Guna.UI.WinForms.GunaButton();
            this.btnDeposit = new Guna.UI.WinForms.GunaButton();
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
            this.label3.Location = new System.Drawing.Point(441, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
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
            this.label1.Location = new System.Drawing.Point(441, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Acount NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(871, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Date";
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
            this.bntCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bntCancel.ForeColor = System.Drawing.Color.White;
            this.bntCancel.Image = global::BankProject11.Properties.Resources._27836_approve_block_cancel_delete_reject_icon__1_;
            this.bntCancel.ImageSize = new System.Drawing.Size(50, 50);
            this.bntCancel.Location = new System.Drawing.Point(676, 395);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.bntCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bntCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.bntCancel.OnHoverImage = null;
            this.bntCancel.OnPressedColor = System.Drawing.Color.Black;
            this.bntCancel.Radius = 10;
            this.bntCancel.Size = new System.Drawing.Size(153, 66);
            this.bntCancel.TabIndex = 39;
            this.bntCancel.Text = "Cancel";
            // 
            // btnDeposit
            // 
            this.btnDeposit.AnimationHoverSpeed = 0.07F;
            this.btnDeposit.AnimationSpeed = 0.03F;
            this.btnDeposit.BackColor = System.Drawing.Color.Transparent;
            this.btnDeposit.BaseColor = System.Drawing.Color.Gray;
            this.btnDeposit.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeposit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeposit.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Image = global::BankProject11.Properties.Resources.remove;
            this.btnDeposit.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDeposit.Location = new System.Drawing.Point(504, 395);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDeposit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeposit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeposit.OnHoverImage = null;
            this.btnDeposit.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeposit.Radius = 10;
            this.btnDeposit.Size = new System.Drawing.Size(153, 66);
            this.btnDeposit.TabIndex = 38;
            this.btnDeposit.Text = "Withdraw";
            // 
            // UCWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtbNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxAcountNO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NRAmount);
            this.Name = "UCWithdraw";
            this.Size = new System.Drawing.Size(1377, 670);
            ((System.ComponentModel.ISupportInitialize)(this.NRAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton bntCancel;
        private Guna.UI.WinForms.GunaButton btnDeposit;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cbxAcountNO;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.NumericUpDown NRAmount;
        private Guna.UI.WinForms.GunaTextBox txtbNotes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}
