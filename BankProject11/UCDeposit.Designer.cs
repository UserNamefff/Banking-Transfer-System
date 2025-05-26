namespace BankProject11
{
    partial class UCDeposit
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
            this.NRAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btDeposit = new Guna.UI.WinForms.GunaButton();
            this.btnCancel = new Guna.UI.WinForms.GunaButton();
            this.cbxAcountNO = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NRAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // NRAmount
            // 
            this.NRAmount.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NRAmount.Location = new System.Drawing.Point(480, 220);
            this.NRAmount.Name = "NRAmount";
            this.NRAmount.Size = new System.Drawing.Size(262, 24);
            this.NRAmount.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Acount NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(524, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 35);
            this.label4.TabIndex = 31;
            this.label4.Text = "Deposit";
            // 
            // btDeposit
            // 
            this.btDeposit.AnimationHoverSpeed = 0.07F;
            this.btDeposit.AnimationSpeed = 0.03F;
            this.btDeposit.BackColor = System.Drawing.Color.Transparent;
            this.btDeposit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btDeposit.BorderColor = System.Drawing.Color.DarkGray;
            this.btDeposit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btDeposit.FocusedColor = System.Drawing.Color.Empty;
            this.btDeposit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btDeposit.ForeColor = System.Drawing.Color.Black;
            this.btDeposit.Image = null;
            this.btDeposit.ImageSize = new System.Drawing.Size(55, 55);
            this.btDeposit.Location = new System.Drawing.Point(480, 359);
            this.btDeposit.Name = "btDeposit";
            this.btDeposit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btDeposit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btDeposit.OnHoverForeColor = System.Drawing.Color.White;
            this.btDeposit.OnHoverImage = null;
            this.btDeposit.OnPressedColor = System.Drawing.Color.Black;
            this.btDeposit.Radius = 10;
            this.btDeposit.Size = new System.Drawing.Size(141, 51);
            this.btDeposit.TabIndex = 70;
            this.btDeposit.Text = "Deposit";
            this.btDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btDeposit.Click += new System.EventHandler(this.btDeposit_Click);
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
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(55, 55);
            this.btnCancel.Location = new System.Drawing.Point(629, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Radius = 10;
            this.btnCancel.Size = new System.Drawing.Size(141, 51);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxAcountNO
            // 
            this.cbxAcountNO.FormattingEnabled = true;
            this.cbxAcountNO.Location = new System.Drawing.Point(480, 180);
            this.cbxAcountNO.Name = "cbxAcountNO";
            this.cbxAcountNO.Size = new System.Drawing.Size(262, 24);
            this.cbxAcountNO.TabIndex = 72;
            // 
            // UCDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxAcountNO);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btDeposit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NRAmount);
            this.Name = "UCDeposit";
            this.Size = new System.Drawing.Size(1239, 606);
            this.Load += new System.EventHandler(this.UCDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NRAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.NumericUpDown NRAmount;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton btDeposit;
        private Guna.UI.WinForms.GunaButton btnCancel;
        private System.Windows.Forms.ComboBox cbxAcountNO;
    }
}
