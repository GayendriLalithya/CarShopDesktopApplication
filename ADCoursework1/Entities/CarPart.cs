using ADCoursework1.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCoursework1.Entities
{
    public class CarPart
    {
        // Attributes of the CarPart class
        public int? CarPartId { get; set; }
        public int? ItemId { get; set; }
        public string CarPartName { get; set; } = string.Empty;
        public int? BrandId { get; set; }
        public string BrandName { get; set; } = string.Empty;
        public string PartNumber { get; set; } = string.Empty;
        public decimal PartPrice { get; set; }
        public string Image { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Default Constructor
        public CarPart()
        {
            // default constructor
        }

        // Parameterized Constructor
        public CarPart(int itemId, int carPartId, string carPartName, int brandId, string brandName, string partNumber, decimal partPrice, string image, string description)
        {
            this.CarPartId = carPartId;
            this.ItemId = itemId;
            this.CarPartName = carPartName;
            this.BrandId = brandId;
            this.BrandName = brandName;
            this.PartNumber = partNumber;
            this.PartPrice = partPrice;
            this.Image = image;
            this.Description = description;
        }

        // Behaviors or Methods

        // Method to Insert a new CarPart using a stored procedure
        public void AddCarPart()
        {
            string storedProcedure = "usp_InsertCarPart";
            SqlParameter[] carPartParams =
            {
                new SqlParameter("@CarPartName", CarPartName),
                new SqlParameter("@BrandID", BrandId),
                new SqlParameter("@PartNumber", PartNumber),
                new SqlParameter("@PartPrice", PartPrice),
                new SqlParameter("@Image", Image),
                new SqlParameter("@Description", Description)
            };

            DatabaseHelper.ExecuteNonQuery(storedProcedure, carPartParams, System.Data.CommandType.StoredProcedure);
        }

        // Method to update an existing CarPart using a stored procedure
        public void UpdateCarPart()
        {
            string storedProcedure = "usp_UpdateCarPart";
            SqlParameter[] carPartParams =
            {
                new SqlParameter("@CarPartID", CarPartId),
                new SqlParameter("@CarPartName", CarPartName),
                new SqlParameter("@BrandID", BrandId),
                new SqlParameter("@PartNumber", PartNumber),
                new SqlParameter("@PartPrice", PartPrice),
                new SqlParameter("@Image", Image),
                new SqlParameter("@Description", Description)
            };

            DatabaseHelper.ExecuteNonQuery(storedProcedure, carPartParams, System.Data.CommandType.StoredProcedure);
        }

        // Method to delete an existing CarPart using a stored procedure
        public static void DeleteCarPart(int carPartId)
        {
            string storedProcedure = "usp_DeleteCarPart";
            SqlParameter[] carPartParams =
            {
                new SqlParameter("@CarPartID", carPartId)
            };

            DatabaseHelper.ExecuteNonQuery(storedProcedure, carPartParams, System.Data.CommandType.StoredProcedure);
        }

        public static void TemporaryDeleteCarPart(int carPartId)
        {
            if (carPartId <= 0)
                throw new ArgumentException("CarPartId must be a positive number.", nameof(carPartId));

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Step 1: Get the associated item_id from the CarPart table
                            string getItemIdSql = "SELECT item_id FROM CarPart WHERE car_part_id = @CarPartId";
                            SqlParameter[] getItemIdParameters =
                            {
                        new SqlParameter("@CarPartId", carPartId)
                    };

                            int itemId;
                            using (SqlCommand cmd = new SqlCommand(getItemIdSql, conn, transaction))
                            {
                                cmd.Parameters.AddRange(getItemIdParameters);
                                itemId = (int)cmd.ExecuteScalar();
                            }

                            if (itemId > 0)
                            {
                                // Step 2: Update the Item table to set deleted = 1 for the associated item
                                string sqlItem = "UPDATE Item SET deleted = 1 WHERE item_id = @ItemId";
                                SqlParameter[] itemParameters =
                                {
                            new SqlParameter("@ItemId", itemId)
                        };
                                DatabaseHelper.ExecuteNonQuery(sqlItem, itemParameters, transaction, conn);

                                // Commit the transaction
                                transaction.Commit();
                            }
                            else
                            {
                                throw new ApplicationException("The car part does not have a valid associated item.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            // Rollback the transaction if an error occurs
                            transaction.Rollback();
                            throw new ApplicationException("An error occurred while temporarily deleting the car part.", ex);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log the exception and handle it appropriately
                throw new ApplicationException("An error occurred while temporarily deleting the car part.", ex);
            }
        }

        public static void RecoverCarPart(int carPartId)
        {
            if (carPartId <= 0)
                throw new ArgumentException("CarPartId must be a positive number.", nameof(carPartId));

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Step 1: Get the associated item_id from the CarPart table
                            string getItemIdSql = "SELECT item_id FROM CarPart WHERE car_part_id = @CarPartId";
                            SqlParameter[] getItemIdParameters =
                            {
                        new SqlParameter("@CarPartId", carPartId)
                    };

                            int itemId;
                            using (SqlCommand cmd = new SqlCommand(getItemIdSql, conn, transaction))
                            {
                                cmd.Parameters.AddRange(getItemIdParameters);
                                itemId = (int)cmd.ExecuteScalar();
                            }

                            if (itemId > 0)
                            {
                                // Step 2: Update the Item table to set deleted = 0 for the associated item
                                string sqlItem = "UPDATE Item SET deleted = 0 WHERE item_id = @ItemId";
                                SqlParameter[] itemParameters =
                                {
                            new SqlParameter("@ItemId", itemId)
                        };
                                DatabaseHelper.ExecuteNonQuery(sqlItem, itemParameters, transaction, conn);

                                // Commit the transaction
                                transaction.Commit();
                            }
                            else
                            {
                                throw new ApplicationException("The car part does not have a valid associated item.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            // Rollback the transaction if an error occurs
                            transaction.Rollback();
                            throw new ApplicationException("An error occurred while recovering the car part.", ex);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log the exception and handle it appropriately
                throw new ApplicationException("An error occurred while recovering the car part.", ex);
            }
        }

        // Search for a CarPart by ID
        public CarPart SearchCarPart(int carPartId)
        {
            string sqlCarPart = "SELECT * FROM CarPart WHERE car_part_id = @CarPartID";
            SqlParameter[] carPartParams =
            {
                new SqlParameter("@CarPartID", carPartId)
            };

            using (SqlDataReader reader = DatabaseHelper.ExecuteReader(sqlCarPart, carPartParams))
            {
                if (reader.Read())
                {
                    return new CarPart
                    {
                        CarPartId = reader.GetInt32(0),
                        ItemId = reader.GetInt32(1),
                        CarPartName = reader.GetString(2),
                        BrandId = reader.GetInt32(3),
                        PartNumber = reader.GetString(4),
                        PartPrice = reader.GetDecimal(5),  // Use GetDecimal here for part_price
                        Image = reader.GetString(6),
                        Description = reader.IsDBNull(7) ? string.Empty : reader.GetString(7)  // Use GetString for description
                    };
                }
            }
            return null;
        }


        // Using a vw_CarDetails VIEW to Get all cars
        public static List<CarPart> GetAllCarParts()
        {
            List<CarPart> carParts = new List<CarPart>();
            string connectionString = ConfigurationManager.ConnectionStrings["CarDealershipDB"].ConnectionString;
            string query = "SELECT * FROM vw_CarPartDetails WHERE item_id IN (SELECT item_id FROM Item WHERE deleted = 0)"; 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CarPart carPart = new CarPart
                    {
                        CarPartId = reader.GetInt32(0),
                        ItemId = reader.GetInt32(1),
                        CarPartName = reader.GetString(2),
                        BrandId = reader.GetInt32(3),
                        BrandName = reader.GetString(4),
                        PartNumber = reader.GetString(5),
                        PartPrice = reader.GetDecimal(6),
                        Image = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Description = reader.IsDBNull(8) ? string.Empty : reader.GetString(8)
                    };
                    carParts.Add(carPart);
                }
                reader.Close();
            }
            return carParts;
        }
    }
}
