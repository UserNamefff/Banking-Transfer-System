namespace BankProject11
{
    partial class frmChooseUserORClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChooseUserORClient));
            this.ucAddPerson1 = new BankProject11.UCAddPerson();
            this.SuspendLayout();
            // 
            // ucAddPerson1
            // 
            this.ucAddPerson1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucAddPerson1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddPerson1.Location = new System.Drawing.Point(0, 0);
            this.ucAddPerson1.Name = "ucAddPerson1";
            this.ucAddPerson1.Size = new System.Drawing.Size(1086, 705);
            this.ucAddPerson1.TabIndex = 0;
            // 
            // frmChooseUserORClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 705);
            this.Controls.Add(this.ucAddPerson1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChooseUserORClient";
            this.Text = "Poeple";
            this.ResumeLayout(false);

        }

        #endregion

        private UCAddPerson ucAddPerson1;
    }
}