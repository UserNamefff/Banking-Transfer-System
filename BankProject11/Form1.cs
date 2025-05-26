using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UsersBussncessLayerLib;
namespace BankProject11
{
    public partial class frmBank: Form
    {
        TabPage tPfrmAddCurrency ;
        TabPage tPfrmAddAccounts ;
        TabPage tPfrmAddCountry ;
        TabPage tPfrmAddCity ;
        TabPage tPfrmAddBoxes;
        TabPage tPfrmMoneyTransfer;
        TabPage tPfrmExchageCurrency;
        TabPage tPfrmAddPerson;
        TabPage tPfrmAddUser;
        TabPage tPfrmAddRemittenceTransfer;
        TabPage tPfrmDepositeOrWithdraw;
        TabPage tPfrmPermsissions;

        public frmBank()
        {
            
            InitializeComponent();
            SetupTabControl();
        }

        private void frmBank_Load(object sender, EventArgs e)
        {
            TimerToTime.Start();
            tabControlMain.ItemSize = new Size(130, 30);
            
        }

        private void sendTransfersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tPfrmMoneyTransfer = new TabPage();
            AddTabPage(tPfrmMoneyTransfer, " Money Transfer ", new UCTransfer());
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tPfrmAddCountry = new TabPage();
            tPfrmAddCountry.SuspendLayout();
            
            AddTabPage(tPfrmAddCountry, " Add Country ", new UCAddCountries());

        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tPfrmAddCurrency = new TabPage();
            
            AddTabPage(tPfrmAddCurrency, " Add Currency ", new UCAddCurrency());
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tPfrmAddAccounts = new TabPage();
            AddTabPage(tPfrmAddAccounts, "Add Accounts Of Clients", new UCAddNewClients());
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void citiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tPfrmAddCity = new TabPage();
            AddTabPage(tPfrmAddCity, "Add Accounts Of Clients", new UCAddCities());
        }


        private void exchangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tPfrmExchageCurrency = new TabPage();
            AddTabPage(tPfrmExchageCurrency, "Exchage Currency",new UsExchangeCurrency());
        }

        private void AddTabPage(TabPage tabPage,string TabName,UserControl UsForm)
        {
            tabPage.Controls.Add(UsForm);
            tabPage.AutoScroll = true;
            tabPage.Text = TabName;
            tabControlMain.Padding = new Point(0,0);
            tabControlMain.Controls.Add(tabPage);
            tabControlMain.SelectedTab = tabPage;

        }

        private void remittanceCashingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tPfrmAddRemittenceTransfer = new TabPage();
            AddTabPage(tPfrmAddRemittenceTransfer, "RemittanceTransfer", new UCRemittanceCashing());
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tPfrmAddPerson = new TabPage();
            
            //AddTabPage(tPfrmAddPerson, " Add Person ", new UCAddPepoles());

        }

        private void tabControlMain_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void TimerToTime_Tick(object sender, EventArgs e)
        {
            label1 .Text = DateTime.Now.ToString();
            textBox1.Text = DateTime.Now.ToString();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tPfrmAddUser = new TabPage();

            //tPfrmAddUser.Text = ;
            tPfrmAddUser.AutoScroll = true;
            AddTabPage(tPfrmAddUser, "Add Users", new UCAddUsers());
        }

        private void buyCurrenciesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void boxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tPfrmAddBoxes = new TabPage();
            AddTabPage(tPfrmAddBoxes, "Add Boxes ", new UctrlAddBoxes());
        }


        private void SetupTabControl()
        {
            tabControlMain.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControlMain.DrawItem += tabControlMain_DrawItem;
            tabControlMain.MouseDown += tabControlMain_MouseDown;
        }

        // Show confirmation and close tab if confirmed
        private void CloseTab(int index)
        {
            var result = MessageBox.Show("هل تريد إغلاق هذا التبويب؟", "تأكيد", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes && index >= 0 && index < tabControlMain.TabPages.Count)
            {
                tabControlMain.TabPages.RemoveAt(index);
            }
        }

        // Handle click on the close button area of a tab
        private void tabControlMain_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControlMain.TabPages.Count; i++)
            {
                var tabRect = tabControlMain.GetTabRect(i);
                // Defined close button rect relative to tabRect only once
                var closeButtonRect = new Rectangle(tabRect.Right - 20, tabRect.Top + 4, 16, 16);

                if (closeButtonRect.Contains(e.Location))
                {
                    CloseTab(i);
                    break;
                }
            }
        }

        // Draw tab header with close button
        private void tabControlMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabPage = tabControlMain.TabPages[e.Index];
            var tabRect = tabControlMain.GetTabRect(e.Index);

            // Fill tab background with system color for better UI consistency
            using (var backgroundBrush = new SolidBrush(SystemColors.ControlLightLight))
            {
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
            }

            // Draw tab text with padding to avoid overlapping the close button
            var textRect = new Rectangle(tabRect.Left + 2, tabRect.Top + 2, tabRect.Width - 22, tabRect.Height - 4);
            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, textRect, tabPage.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

            // Draw close button (X)
            var closeButtonRect = new Rectangle(tabRect.Right - 20, tabRect.Top + 4, 16, 16);
            TextRenderer.DrawText(e.Graphics, "×", this.Font, closeButtonRect, Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        // Helper to add tab pages with a control inside
        private void AddTabPage(TabPage tabPage, string title, Control contentControl)
        {
            tabPage.Text = title;
            contentControl.Dock = DockStyle.Fill;
            tabPage.Controls.Add(contentControl);
            tabControlMain.TabPages.Add(tabPage);
            tabControlMain.SelectedTab = tabPage;
        }

        // Menu handlers
        private void depositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tPfrmDepositeOrWithdraw = new TabPage();
            AddTabPage(tPfrmDepositeOrWithdraw, "Deposite Or Withdraw", new DepositeOrWithdraw());
        }

        private void permissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tPfrmPermissions = new TabPage();
            AddTabPage(tPfrmPermissions, "Permissions", new UCAddPermissionsToUsers());
        }

        // Empty event handler, consider removing if unused
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Implement report functionality or remove this method
        }

   
        private void messagesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabControlMain_MouseLeave(object sender, EventArgs e)
        {

        }

        private void tabControlMain_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
