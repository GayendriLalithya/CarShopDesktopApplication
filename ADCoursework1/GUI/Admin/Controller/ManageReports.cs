using ADCoursework1.GUI.Admin.Controller.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.GUI.Admin.Controller
{
    public partial class ManageReports : UserControl
    {
        public ManageReports()
        {
            InitializeComponent();
            LoadTabPages();
        }

        public void LoadTabPages()
        {
            // Manage Finance Report Tab Load
            // Create an instance of Finance Report user control
            FinanceReport financeReport = new FinanceReport();

            // Set the Dock property to fill the tab page
            financeReport.Dock = DockStyle.Fill;

            // Add the user control to the TabPage
            TbPageFinance.Controls.Add(financeReport);


            // Manage Daily Income Report Tab Load
            // Create an instance of Daily Income Report user control
            DailyIncomeReport dailyIncomeReport = new DailyIncomeReport();

            // Set the Dock property to fill the tab page
            dailyIncomeReport.Dock = DockStyle.Fill;

            // Add the user control to the TabPage 
            TbPageDailyIncome.Controls.Add(dailyIncomeReport);


            // Manage Inventory Status Tab Load
            // Create an instance of Inventory Status user control
            InventoryStatus inventoryStatus = new InventoryStatus();

            // Set the Dock property to fill the tab page
            inventoryStatus.Dock = DockStyle.Fill;

            // Add the user control to the TabPage 
            TbPageInventory.Controls.Add(inventoryStatus);


            // Manage Order Quantity Report Tab Load
            // Create an instance of Order Quantity Report  user control
            OrderQuantityStatus orderQuantityStatus = new OrderQuantityStatus();

            // Set the Dock property to fill the tab page
            orderQuantityStatus.Dock = DockStyle.Fill;

            // Add the user control to the TabPage (tabPage2)
            TbPageOrder.Controls.Add(orderQuantityStatus);
        }
    }
}
