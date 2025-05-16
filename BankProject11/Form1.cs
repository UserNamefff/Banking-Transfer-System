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
            
            AddTabPage(tPfrmAddPerson, " Add Person ", new UCAddPepoles());

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

        // إغلاق التبويب مع تأكيد
        private void CloseTab(int index)
        {
            if (MessageBox.Show("هل تريد إغلاق هذا التبويب؟", "تأكيد",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tabControlMain.TabPages.RemoveAt(index);
            }
        }

        // التعامل مع النقر على زر الإغلاق
        private void tabControlMain_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControlMain.TabPages.Count; i++)
            {
                var tabRect = tabControlMain.GetTabRect(i);
                var closeButtonRect = new Rectangle(tabRect.Right - 20, tabRect.Top + 4, 16, 16);

                if (closeButtonRect.Contains(e.Location))
                {
                    CloseTab(i);
                    break;
                }
            }
        }

        // رسم التبويب وزر الإغلاق
        private void tabControlMain_DrawItem(object sender, DrawItemEventArgs e)
        {

            var tabPage = tabControlMain.TabPages[e.Index];
            var tabRect = tabControlMain.GetTabRect(e.Index);

            // رسم خلفية التبويب
            e.Graphics.FillRectangle(Brushes.Snow , e.Bounds);

            // رسم نص التبويب
            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                tabRect, tabPage.ForeColor, TextFormatFlags.Left);

            // رسم زر الإغلاق (X)
            Rectangle closeButtonRect = new Rectangle(tabRect.Right - 20, tabRect.Top + 4, 16, 16);
            


            e.Graphics.DrawString("X", this.Font, Brushes.Black, closeButtonRect);
        }

        private void depositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tPfrmDepositeOrWithdraw = new TabPage();

            AddTabPage(tPfrmDepositeOrWithdraw, "Deposite Or Withdraw", new DepositeOrWithdraw());
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
