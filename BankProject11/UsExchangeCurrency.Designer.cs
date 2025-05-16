namespace BankProject11
{
    partial class UsExchangeCurrency
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
            this.cmbConvert_From = new Guna.UI.WinForms.GunaComboBox();
            this.cmbConvert_To = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblConvertResult = new System.Windows.Forms.Label();
            this.gunaNumeric1 = new Guna.UI.WinForms.GunaNumeric();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.updateRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gunaContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbConvert_From
            // 
            this.cmbConvert_From.BackColor = System.Drawing.Color.Transparent;
            this.cmbConvert_From.BaseColor = System.Drawing.Color.White;
            this.cmbConvert_From.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbConvert_From.BorderSize = 1;
            this.cmbConvert_From.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbConvert_From.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConvert_From.FocusedColor = System.Drawing.Color.Empty;
            this.cmbConvert_From.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbConvert_From.ForeColor = System.Drawing.Color.Black;
            this.cmbConvert_From.FormattingEnabled = true;
            this.cmbConvert_From.Location = new System.Drawing.Point(407, 218);
            this.cmbConvert_From.Name = "cmbConvert_From";
            this.cmbConvert_From.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbConvert_From.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbConvert_From.Radius = 10;
            this.cmbConvert_From.Size = new System.Drawing.Size(283, 31);
            this.cmbConvert_From.TabIndex = 0;
            // 
            // cmbConvert_To
            // 
            this.cmbConvert_To.BackColor = System.Drawing.Color.Transparent;
            this.cmbConvert_To.BaseColor = System.Drawing.Color.White;
            this.cmbConvert_To.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbConvert_To.BorderSize = 1;
            this.cmbConvert_To.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbConvert_To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConvert_To.FocusedColor = System.Drawing.Color.Empty;
            this.cmbConvert_To.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbConvert_To.ForeColor = System.Drawing.Color.Black;
            this.cmbConvert_To.FormattingEnabled = true;
            this.cmbConvert_To.Location = new System.Drawing.Point(809, 218);
            this.cmbConvert_To.Name = "cmbConvert_To";
            this.cmbConvert_To.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbConvert_To.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbConvert_To.Radius = 10;
            this.cmbConvert_To.Size = new System.Drawing.Size(283, 31);
            this.cmbConvert_To.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(403, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Convert from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(805, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Convert to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(554, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 35);
            this.label4.TabIndex = 62;
            this.label4.Text = "Currency Exchange";
            // 
            // lblConvertResult
            // 
            this.lblConvertResult.AutoSize = true;
            this.lblConvertResult.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblConvertResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblConvertResult.Location = new System.Drawing.Point(817, 299);
            this.lblConvertResult.Name = "lblConvertResult";
            this.lblConvertResult.Size = new System.Drawing.Size(91, 24);
            this.lblConvertResult.TabIndex = 63;
            this.lblConvertResult.Text = "?????????";
            // 
            // gunaNumeric1
            // 
            this.gunaNumeric1.BackColor = System.Drawing.Color.Transparent;
            this.gunaNumeric1.BaseColor = System.Drawing.Color.White;
            this.gunaNumeric1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaNumeric1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaNumeric1.ButtonForeColor = System.Drawing.Color.White;
            this.gunaNumeric1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaNumeric1.ForeColor = System.Drawing.Color.Black;
            this.gunaNumeric1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.gunaNumeric1.Location = new System.Drawing.Point(407, 299);
            this.gunaNumeric1.Maximum = ((long)(99999999999));
            this.gunaNumeric1.Minimum = ((long)(0));
            this.gunaNumeric1.Name = "gunaNumeric1";
            this.gunaNumeric1.Radius = 10;
            this.gunaNumeric1.Size = new System.Drawing.Size(283, 30);
            this.gunaNumeric1.TabIndex = 64;
            this.gunaNumeric1.Text = "Amount";
            this.gunaNumeric1.Value = ((long)(0));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(403, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 65;
            this.label3.Text = "Amount Convert ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.gunaContextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(87, 594);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1380, 194);
            this.dataGridView1.TabIndex = 66;
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gunaContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateRateToolStripMenuItem,
            this.othersToolStripMenuItem});
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(162, 52);
            // 
            // updateRateToolStripMenuItem
            // 
            this.updateRateToolStripMenuItem.Name = "updateRateToolStripMenuItem";
            this.updateRateToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.updateRateToolStripMenuItem.Text = "Update Rate";
            // 
            // othersToolStripMenuItem
            // 
            this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            this.othersToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.othersToolStripMenuItem.Text = "Others";
            // 
            // btnPrint
            // 
            this.btnPrint.AnimationHoverSpeed = 0.07F;
            this.btnPrint.AnimationSpeed = 0.03F;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrint.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Image = null;
            this.btnPrint.ImageSize = new System.Drawing.Size(55, 55);
            this.btnPrint.Location = new System.Drawing.Point(690, 443);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPrint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint.OnHoverImage = null;
            this.btnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint.Radius = 10;
            this.btnPrint.Size = new System.Drawing.Size(141, 51);
            this.btnPrint.TabIndex = 68;
            this.btnPrint.Text = "Convert";
            this.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UsExchangeCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gunaNumeric1);
            this.Controls.Add(this.lblConvertResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbConvert_To);
            this.Controls.Add(this.cmbConvert_From);
            this.Name = "UsExchangeCurrency";
            this.Size = new System.Drawing.Size(1578, 880);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gunaContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox cmbConvert_From;
        private Guna.UI.WinForms.GunaComboBox cmbConvert_To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConvertResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;
        private Guna.UI.WinForms.GunaButton btnPrint;
        private Guna.UI.WinForms.GunaNumeric gunaNumeric1;
    }
}
