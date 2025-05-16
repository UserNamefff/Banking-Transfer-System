namespace BankProject11
{
    partial class frmAccounts
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
            this.ucAddAccountToClients1 = new BankProject11.UCAddAccountToClients();
            this.SuspendLayout();
            // 
            // ucAddAccountToClients1
            // 
            this.ucAddAccountToClients1.ClientID = 0;
            this.ucAddAccountToClients1.ClientName = null;
            this.ucAddAccountToClients1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddAccountToClients1.Location = new System.Drawing.Point(0, 0);
            this.ucAddAccountToClients1.Name = "ucAddAccountToClients1";
            this.ucAddAccountToClients1.Size = new System.Drawing.Size(1075, 616);
            this.ucAddAccountToClients1.TabIndex = 0;
            this.ucAddAccountToClients1.Load += new System.EventHandler(this.ucAddAccountToClients1_Load);
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 616);
            this.Controls.Add(this.ucAddAccountToClients1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAccounts";
            this.Text = "frmAccounts";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCAddAccountToClients ucAddAccountToClients1;
    }
}