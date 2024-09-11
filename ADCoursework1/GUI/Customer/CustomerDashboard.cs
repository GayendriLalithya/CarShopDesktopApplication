using ADCoursework1.Entities;
using ADCoursework1.GUI.Admin.Controller;
using ADCoursework1.GUI.Controller;
using ADCoursework1.GUI.Customer.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.GUI.Customer
{
    public partial class CustomerDashboard : Form
    {
        private int _customerId;

        public CustomerDashboard(int customerId) 
        {
            InitializeComponent();
            _customerId = customerId;  // Set the customer ID when the form is created
            LoadTabPages();
        }

        private void LoadTabPages()
        {
            // Create an instance of Dashboard user control
            CustomerControl dashboardControl = new CustomerControl(_customerId);

            // Set the Dock property to fill the tab page
            dashboardControl.Dock = DockStyle.Fill;

            // Add the user control to the TabPage 
            TbPageDashboard.Controls.Add(dashboardControl);

            // Manage Profile Tab Load
            // Create an instance of your ManageProfile user control
            ManageProfile manageProfile = new ManageProfile();

            // Set the Dock property to fill the tab page
            manageProfile.Dock = DockStyle.Fill;

            // Add the user control to the TabPage
            TbPageProfile.Controls.Add(manageProfile);

            // View cart Tab Load
            // Create an instance of your ViewCart user control
            ViewCart viewCart = new ViewCart();

            // Set the Dock property to fill the tab page
            viewCart.Dock = DockStyle.Fill;

            // Add the user control to the TabPage
            TbPageCart.Controls.Add(viewCart);

            // View Order Tab Load
            // Create an instance of your View Order user control
            ViewOrder viewOrder = new ViewOrder();

            // Set the Dock property to fill the tab page
            viewOrder.Dock = DockStyle.Fill;

            // Add the user control to the TabPage
            TbPageOrder.Controls.Add(viewOrder);
        }

        // Method to select a specific tab
        public void SelectTab(string tabName)
        {
            foreach (TabPage tab in TbControlCustomer.TabPages)
            {
                if (tab.Name == tabName)
                {
                    TbControlCustomer.SelectedTab = tab;
                    break;
                }
            }
        }

        private void ImgBtnLogout_Click(object sender, EventArgs e)
        {
            // Create an instance of the User class
            User user = new User();

            // Call the Logout method and pass the current form
            user.Logout(this);
        }

        private void ImgBtnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();  // Hide the dashboard page
        }
    }
}
