namespace BankProject11
{
    partial class UCAddPepoles
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
            this.ucAddPerson2 = new BankProject11.UCAddPerson();
            this.SuspendLayout();
            // 
            // ucAddPerson2
            // 
            this.ucAddPerson2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucAddPerson2.Location = new System.Drawing.Point(152, 142);
            this.ucAddPerson2.Name = "ucAddPerson2";
            this.ucAddPerson2.Size = new System.Drawing.Size(1091, 222);
            this.ucAddPerson2.TabIndex = 1;
            // 
            // UCAddPepoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucAddPerson2);
            this.Name = "UCAddPepoles";
            this.Size = new System.Drawing.Size(1533, 842);
            this.ResumeLayout(false);

        }

        #endregion

        private UCAddPerson ucAddPerson2;
    }
}
