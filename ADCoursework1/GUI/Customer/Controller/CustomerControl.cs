using ADCoursework1.GUI.Admin.Controller.DashboardComponents;
using ADCoursework1.GUI.Customer.Controller.DashboardCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.GUI.Customer.Controller
{
    public partial class CustomerControl : UserControl
    {
        private int _customerId;  // Assuming you can set this when creating an instance

        public CustomerControl(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;  // Set the customer ID
            SpendingOverview(_customerId);  // Now pass it to the method
            CustomerRank(_customerId);
            MostPurchasedBrand(_customerId);
            OrderOverview(_customerId);
        }

        private void SpendingOverview(int customerId)
        {
            // Create an instance of the SpendingOverview user control with the required customer ID
            SpendingOverview spendingOverview = new SpendingOverview(customerId);

            // Set the Dock property, typically you may want to use Top or None
            spendingOverview.Dock = DockStyle.Top;

            // Add the SpendingOverview control to the flow panel
            FlwPnlSpendingOverview.Controls.Add(spendingOverview);
        }

        private void CustomerRank(int customerId)
        {
            // Create an instance of the customerRank user control with the required customer ID
            CustomerRank customerRank = new CustomerRank();

            // Set the Dock property, typically you may want to use Top or None
            customerRank.Dock = DockStyle.Top;

            // Add the customerRank control to the flow panel
            FlwPnlCustomerRank.Controls.Add(customerRank);
        }

        private void MostPurchasedBrand(int customerId)
        {
            // Create an instance of the customerRank user control with the required customer ID
            MostPurchasedBrand mostPurchasedBrand = new MostPurchasedBrand();

            // Set the Dock property, typically you may want to use Top or None
            mostPurchasedBrand.Dock = DockStyle.Top;

            // Add the customerRank control to the flow panel
            FlwPnlBrand.Controls.Add(mostPurchasedBrand);
        }

        private void OrderOverview(int customerId)
        {
            // Create an instance of the customerRank user control with the required customer ID
            OrderDetailsOverview orderDetailsOverview = new OrderDetailsOverview();

            // Set the Dock property, typically you may want to use Top or None
            orderDetailsOverview.Dock = DockStyle.Top;

            // Add the customerRank control to the flow panel
            FlwPnlOrder.Controls.Add(orderDetailsOverview);
        }
    }
}
