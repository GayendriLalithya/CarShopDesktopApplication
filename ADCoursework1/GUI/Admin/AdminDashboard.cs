using ADCoursework1.Entities;
using ADCoursework1.GUI.Admin.Controller;
using ADCoursework1.GUI.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.GUI.Admin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            LoadTabPages();
        }

        private void LoadTabPages()
        {
            // Manage Brand Tab Load
            // Create an instance of ManageBrand user control
            AdminControl dashboardControl = new AdminControl();

            // Set the Dock property to fill the tab page
            dashboardControl.Dock = DockStyle.Fill;

            // Add the user control to the TabPage (tabPage2)
            TbPageDashboard.Controls.Add(dashboardControl);


            // Manage Brand Tab Load
            // Create an instance of ManageBrand user control
            ManageBrand manageBrand = new ManageBrand();

            // Set the Dock property to fill the tab page
            manageBrand.Dock = DockStyle.Fill;

            // Add the user control to the TabPage (tabPage2)
            TbPageBrand.Controls.Add(manageBrand);


            // Manage Car Tab Load
            // Create an instance of your ManageCar user control
            ManageCar manageCar = new ManageCar();

            // Set the Dock property to fill the tab page
            manageCar.Dock = DockStyle.Fill;

            // Add the user control to the TabPage
            TbPageCar.Controls.Add(manageCar);


            // Manage Car Part Tab Load
            // Create an instance of your ManageCar user control
            ManageCarPart manageCarPart = new ManageCarPart();

            // Set the Dock property to fill the tab page
            manageCarPart.Dock = DockStyle.Fill;

            // Add the user control to the TabPage
            TbPageCarPart.Controls.Add(manageCarPart);


            // Manage User Tab Load
            // Create an instance of your ManageCar user control
            ManageUser manageUser = new ManageUser();

            // Set the Dock property to fill the tab page
            manageUser.Dock = DockStyle.Fill;

            // Add the user control to the TabPage
            TbPageUser.Controls.Add(manageUser);


            // Manage Profile Tab Load
            // Create an instance of your ManageProfile user control
            ManageProfile manageProfile = new ManageProfile();

            // Set the Dock property to fill the tab page
            manageProfile.Dock = DockStyle.Fill;

            // Add the user control to the TabPage
            TbPageProfile.Controls.Add(manageProfile);


            // Manage Order Tab Load
            // Create an instance of your ManageOrder user control
            ManageOrder manageOrder = new ManageOrder();

            // Set the Dock property to fill the tab page
            manageOrder.Dock = DockStyle.Fill;

            // Add the user control to the TabPage
            TbPageOrder.Controls.Add(manageOrder);


            // Manage Inventory Tab Load
            // Create an instance of your ManageInventory user control
            ManageInventory manageInventory = new ManageInventory();

            // Set the Dock property to fill the tab page
            manageInventory.Dock = DockStyle.Fill;

            // Add the user control to the TabPage
            TbPageInventory.Controls.Add(manageInventory);


            // Manage Report Tab Load
            // Create an instance of your ManageReport user control
            ManageReports manageReports = new ManageReports();

            // Set the Dock property to fill the tab page
            manageReports.Dock = DockStyle.Fill;

            // Add the user control to the TabPage
            TbPageReports.Controls.Add(manageReports);
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
