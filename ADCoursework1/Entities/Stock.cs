using ADCoursework1.Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.Entities
{
    public class Stock
    {
        public int StockId { get; set; }
        public int ItemId { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public int ReorderLevel { get; set; } // New property for reorder level

        // Constructor
        public Stock(int stockId, int itemId, DateTime date, int quantity, int reorderLevel)
        {
            StockId = stockId;
            ItemId = itemId;
            Date = date;
            Quantity = quantity;
            ReorderLevel = reorderLevel;
        }

        // Another constructor for adding a new stock
        public Stock(int itemId, DateTime date, int quantity, int reorderLevel)
        {
            ItemId = itemId;
            Date = date;
            Quantity = quantity;
            ReorderLevel = reorderLevel;
        }

        // Method to add a new stock record
        public static void AddStock(int itemId, DateTime date, int quantity, int reorderLevel)
        {
            string sql = "INSERT INTO Stock (item_id, date, quantity, reorder_level) VALUES (@ItemId, @Date, @Quantity, @ReorderLevel)";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ItemId", itemId),
            new SqlParameter("@Date", date),
            new SqlParameter("@Quantity", quantity),
            new SqlParameter("@ReorderLevel", reorderLevel)
            };

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        // Method to update an existing stock record
        public static void UpdateStock(int stockId, int itemId, DateTime date, int quantity, int reorderLevel)
        {
            string sql = @"
        UPDATE Stock 
        SET item_id = @ItemId, 
            date = @Date, 
            quantity = @Quantity, 
            reorder_level = @ReorderLevel 
        WHERE stock_id = @StockId";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@StockId", stockId),
        new SqlParameter("@ItemId", itemId),
        new SqlParameter("@Date", date),
        new SqlParameter("@Quantity", quantity),
        new SqlParameter("@ReorderLevel", reorderLevel)
            };

            // Debugging line to print the SQL statement and parameters
            Console.WriteLine("SQL Query: " + sql);
            foreach (var param in parameters)
            {
                Console.WriteLine($"{param.ParameterName}: {param.Value}");
            }

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }




        public static void DeleteStock(int stockId)
        {
            string storedProcedure = "usp_DeleteStock";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@StockId", stockId)
            };

            DatabaseHelper.ExecuteNonQuery(storedProcedure, parameters, System.Data.CommandType.StoredProcedure);
        }
    }
}
