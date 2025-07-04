﻿namespace BankProject11
{
    partial class DepositeOrWithdraw
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucWithdraw1 = new BankProject11.UCWithdraw();
            this.ucDeposit1 = new BankProject11.UCDeposit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1551, 895);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucWithdraw1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1543, 866);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Withdraw";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucDeposit1);
            this.tabPage2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1452, 827);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deposite";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucWithdraw1
            // 
            this.ucWithdraw1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucWithdraw1.Location = new System.Drawing.Point(3, 3);
            this.ucWithdraw1.Name = "ucWithdraw1";
            this.ucWithdraw1.Size = new System.Drawing.Size(1537, 860);
            this.ucWithdraw1.TabIndex = 0;
            // 
            // ucDeposit1
            // 
            this.ucDeposit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDeposit1.Location = new System.Drawing.Point(3, 3);
            this.ucDeposit1.Margin = new System.Windows.Forms.Padding(4);
            this.ucDeposit1.Name = "ucDeposit1";
            this.ucDeposit1.Size = new System.Drawing.Size(1446, 821);
            this.ucDeposit1.TabIndex = 0;
            // 
            // DepositeOrWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "DepositeOrWithdraw";
            this.Size = new System.Drawing.Size(1460, 895);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UCDeposit ucDeposit1;
        private UCWithdraw ucWithdraw1;
    }
}
