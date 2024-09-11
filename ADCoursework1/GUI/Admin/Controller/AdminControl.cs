using ADCoursework1.GUI.Admin.Controller.DashboardComponents;
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
    public partial class AdminControl : UserControl
    {
        public AdminControl()
        {
            InitializeComponent();
            LoadStockManagementOverview();
            LoadTopSaleOverview();
            LoadCustomerOverview();
            LoadMonthlySalesManagementOverview();
        }

        private void LoadStockManagementOverview()
        {
            // Create an instance of the StockManagement user control
            StockManagement stockManagementControl = new StockManagement();

            // Set the Dock property, typically you may want to use Top or None
            stockManagementControl.Dock = DockStyle.Top;

            // Add the StockManagement control to the flow panel
            FlwPnlStockOverview.Controls.Add(stockManagementControl);
        }

        private void LoadTopSaleOverview()
        {
            // Create an instance of the TopSalesOverview user control
            TopSalesOverview topSalesOverview = new TopSalesOverview();

            // Set the Dock property
            topSalesOverview.Dock = DockStyle.Top;

            // Add the TopSalesOverview control to the FlwPnlTopSales panel
            FlwPnlTopSalse.Controls.Add(topSalesOverview);
        }

        private void LoadCustomerOverview()
        {
            // Create an instance of the CustomerOverview user control
            CustomerOverview customerOverview = new CustomerOverview();

            // Set the Dock property
            customerOverview.Dock = DockStyle.Top;

            // Add the CustomerOverview control to the FlwPnlTopSales panel
            FlwPnlCustomer.Controls.Add(customerOverview);
        }

        private void LoadMonthlySalesManagementOverview()
        {
            // Create an instance of the SalesManagementOverview user control
            SalesManagementOverview salesManagementOverview = new SalesManagementOverview();

            // Set the Dock property to Top
            salesManagementOverview.Dock = DockStyle.Top;

            // Add the SalesManagementOverview control to the flow panel
            FlwPnlSalesOverview.Controls.Add(salesManagementOverview);
        }

    }
}
