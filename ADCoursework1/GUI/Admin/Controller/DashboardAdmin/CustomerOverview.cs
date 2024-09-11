using ADCoursework1.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.GUI.Admin.Controller.DashboardComponents
{
    public partial class CustomerOverview : UserControl
    {
        public CustomerOverview()
        {
            InitializeComponent();
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            string sql = @"
                        SELECT 
                        CONCAT(u.first_name, ' ', u.last_name) AS CustomerName,
                        c.points AS Points
                    FROM 
                        Customers c
                    INNER JOIN 
                        Users u ON c.user_id = u.user_id
                    ORDER BY 
                        c.points DESC;
                    ";

            DataTable customerTable = DatabaseHelper.ExecuteDataTable(sql, null);

            // Set the row height
            DgvCustomer.RowTemplate.Height = 60;

            // Clear existing rows if any
            DgvCustomer.Rows.Clear();

            foreach (DataRow row in customerTable.Rows)
            {
                int rowIndex = DgvCustomer.Rows.Add(
                    row["CustomerName"].ToString(),
                    row["Points"].ToString()
                );
            }
        }
    }
}
