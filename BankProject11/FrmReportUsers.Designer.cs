namespace BankProject11
{
    partial class FrmReportUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gunCombReportUsers = new Guna.UI.WinForms.GunaComboBox();
            this.gunDgvReportUsers = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gunDgvReportUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Report Users";
            // 
            // gunCombReportUsers
            // 
            this.gunCombReportUsers.BackColor = System.Drawing.Color.Transparent;
            this.gunCombReportUsers.BaseColor = System.Drawing.Color.White;
            this.gunCombReportUsers.BorderColor = System.Drawing.Color.Silver;
            this.gunCombReportUsers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunCombReportUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunCombReportUsers.FocusedColor = System.Drawing.Color.Empty;
            this.gunCombReportUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunCombReportUsers.ForeColor = System.Drawing.Color.Black;
            this.gunCombReportUsers.FormattingEnabled = true;
            this.gunCombReportUsers.Location = new System.Drawing.Point(279, 53);
            this.gunCombReportUsers.Name = "gunCombReportUsers";
            this.gunCombReportUsers.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunCombReportUsers.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunCombReportUsers.Size = new System.Drawing.Size(206, 31);
            this.gunCombReportUsers.TabIndex = 3;
            this.gunCombReportUsers.SelectedIndexChanged += new System.EventHandler(this.gunCombReportUsers_SelectedIndexChanged);
            // 
            // gunDgvReportUsers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunDgvReportUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunDgvReportUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunDgvReportUsers.BackgroundColor = System.Drawing.Color.White;
            this.gunDgvReportUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunDgvReportUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunDgvReportUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunDgvReportUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunDgvReportUsers.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunDgvReportUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunDgvReportUsers.EnableHeadersVisualStyles = false;
            this.gunDgvReportUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunDgvReportUsers.Location = new System.Drawing.Point(145, 126);
            this.gunDgvReportUsers.Name = "gunDgvReportUsers";
            this.gunDgvReportUsers.RowHeadersVisible = false;
            this.gunDgvReportUsers.RowHeadersWidth = 51;
            this.gunDgvReportUsers.RowTemplate.Height = 24;
            this.gunDgvReportUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunDgvReportUsers.Size = new System.Drawing.Size(504, 278);
            this.gunDgvReportUsers.TabIndex = 4;
            this.gunDgvReportUsers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunDgvReportUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunDgvReportUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunDgvReportUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunDgvReportUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunDgvReportUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunDgvReportUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunDgvReportUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunDgvReportUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunDgvReportUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunDgvReportUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunDgvReportUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunDgvReportUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunDgvReportUsers.ThemeStyle.HeaderStyle.Height = 4;
            this.gunDgvReportUsers.ThemeStyle.ReadOnly = false;
            this.gunDgvReportUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunDgvReportUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunDgvReportUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunDgvReportUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunDgvReportUsers.ThemeStyle.RowsStyle.Height = 24;
            this.gunDgvReportUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunDgvReportUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FrmReportUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunDgvReportUsers);
            this.Controls.Add(this.gunCombReportUsers);
            this.Controls.Add(this.label1);
            this.Name = "FrmReportUsers";
            this.Text = "FrmReportUsers3";
            this.Load += new System.EventHandler(this.FrmReportUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunDgvReportUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox gunCombReportUsers;
        private Guna.UI.WinForms.GunaDataGridView gunDgvReportUsers;
    }
}