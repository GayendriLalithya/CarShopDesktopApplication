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
    internal class Car
    {
        public int? CarId { get; set; }
        public int? ItemId { get; set; }
        public int? BrandId { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int? Year { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Default Constructor
        public Car()
        {
            // default car constructor
        }

        // Parameterized Constructor for car cards
        public Car(int itemId, int carId, int brandId, string brand, string model, int year, decimal price, string image, string description)
        {
            this.CarId = carId;
            this.ItemId = itemId;
            this.BrandId = brandId;
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.Image = image;
            this.Description = description;
        }

        // Behaviors or Methods
        // Method to Insert a new car using a stored procedure
        public void AddCar()
        {
            string storedProcedure = "usp_InsertCar";
            SqlParameter[] carParams =
            {
                new SqlParameter("@BrandID", BrandId),
                new SqlParameter("@Model", Model),
                new SqlParameter("@Year", Year),
                new SqlParameter("@Price", Price),
                new SqlParameter("@Image", Image),
                new SqlParameter("@Description", Description)
            };

            DatabaseHelper.ExecuteNonQuery(storedProcedure, carParams, System.Data.CommandType.StoredProcedure);
        }

        // Method to update an existing car using a stored procedure
        public void UpdateCar()
        {
            string storedProcedure = "usp_UpdateCar";
            SqlParameter[] carParams =
            {
                new SqlParameter("@CarID", CarId),
                new SqlParameter("@BrandID", BrandId),
                new SqlParameter("@Model", Model),
                new SqlParameter("@Year", Year),
                new SqlParameter("@Price", Price),
                new SqlParameter("@Image", Image),
                new SqlParameter("@Description", Description)
            };

            DatabaseHelper.ExecuteNonQuery(storedProcedure, carParams, System.Data.CommandType.StoredProcedure);
        }

        // Method to delete an existing car using a stored procedure
        public static void DeleteCar(int carId)
        {
            string storedProcedure = "usp_DeleteCar";
            SqlParameter[] carParams =
            {
                new SqlParameter("@CarID", carId)
            };

            DatabaseHelper.ExecuteNonQuery(storedProcedure, carParams, System.Data.CommandType.StoredProcedure);
        }

        public static void RecoverCar(int carId)
        {
            if (carId <= 0)
                throw new ArgumentException("CarId must be a positive number.", nameof(carId));

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Step 1: Get the associated item_id from the Car table
                            string getItemIdSql = "SELECT item_id FROM Car WHERE car_id = @CarId";
                            SqlParameter[] getItemIdParameters =
                            {
                                new SqlParameter("@CarId", carId)
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
                                throw new ApplicationException("The car does not have a valid associated item.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            // Rollback the transaction if an error occurs
                            transaction.Rollback();
                            throw new ApplicationException("An error occurred while recovering the car.", ex);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log the exception and handle it appropriately
                throw new ApplicationException("An error occurred while recovering the car.", ex);
            }
        }


        public static void TemporaryDeleteCar(int carId)
        {
            if (carId <= 0)
                throw new ArgumentException("CarId must be a positive number.", nameof(carId));

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Step 1: Get the associated item_id from the Car table
                            string getItemIdSql = "SELECT item_id FROM Car WHERE car_id = @CarId";
                            SqlParameter[] getItemIdParameters =
                            {
                                new SqlParameter("@CarId", carId)
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
                                throw new ApplicationException("The car does not have a valid associated item.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            // Rollback the transaction if an error occurs
                            transaction.Rollback();
                            throw new ApplicationException("An error occurred while temporarily deleting the car.", ex);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log the exception and handle it appropriately
                throw new ApplicationException("An error occurred while temporarily deleting the car.", ex);
            }
        }


        // Search for a car by ID
        public Car SearchCar(int carId)
        {
            string sqlCar = "SELECT * FROM Car WHERE car_id = @CarID";
            SqlParameter[] carParams =
            {
                new SqlParameter("@CarID", carId)
            };

            using (SqlDataReader reader = DatabaseHelper.ExecuteReader(sqlCar, carParams))
            {
                if (reader.Read())
                {
                    return new Car
                    {
                        CarId = reader.GetInt32(0),
                        ItemId = reader.GetInt32(1),
                        BrandId = reader.GetInt32(2),
                        Model = reader.GetString(3),
                        Year = reader.GetInt32(4),
                        Price = reader.GetDecimal(5),
                        Image = reader.GetString(6),
                        Description = reader.IsDBNull(7) ? string.Empty : reader.GetString(7)
                    };
                }
            }
            return null;
        }

        // Using a vw_CarDetails VIEW to Get all cars
        public static List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();
            string connectionString = ConfigurationManager.ConnectionStrings["CarDealershipDB"].ConnectionString;
            string query = "SELECT * FROM vw_CarDetails WHERE item_id IN (SELECT item_id FROM Item WHERE deleted = 0)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Car car = new Car
                    {
                        CarId = reader.GetInt32(0),
                        ItemId = reader.GetInt32(1),
                        BrandId = reader.GetInt32(2),
                        Brand = reader.GetString(3),
                        Model = reader.GetString(4),
                        Year = reader.GetInt32(5),
                        Price = reader.GetDecimal(6),
                        Image = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Description = reader.IsDBNull(8) ? string.Empty : reader.GetString(8)
                    };
                    cars.Add(car);
                }
                reader.Close();
            }
            return cars;
        }

    }
}
