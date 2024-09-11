using ADCoursework1.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCoursework1.Entities
{
    public class Brand
    {
        // Attributes of the Brand class
        public int? BrandId { get; set; }
        public string BrandName { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;


        // Default Constructor
        public Brand() { }


        // Parameterized Constructor for brand details
        public Brand(int brandId, string brandName, string image)
        {
            this.BrandId = brandId;
            this.BrandName = brandName;
            this.Image = image;
        }

        // Methods of the Brand Class

        // Insert Brand Method
        public void AddBrand()
        {
            if (string.IsNullOrWhiteSpace(BrandName))
                throw new ArgumentException("BrandName cannot be null or empty.", nameof(BrandName));

            if (string.IsNullOrWhiteSpace(Image))
                throw new ArgumentException("Image cannot be null or empty.", nameof(Image));

            try
            {
                string storedProcedure = "usp_InsertBrand";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@BrandName", BrandName),
                    new SqlParameter("@Image", Image)
                };
                DatabaseHelper.ExecuteNonQuery(storedProcedure, parameters, CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                // Log the exception and handle it appropriately
                throw new ApplicationException("An error occurred while adding the brand.", ex);
            }
        }

        // Update Brand Method
        public void UpdateBrand()
        {
            if (BrandId == null || BrandId <= 0)
                throw new ArgumentException("BrandId must be a positive number.", nameof(BrandId));

            if (string.IsNullOrWhiteSpace(BrandName))
                throw new ArgumentException("BrandName cannot be null or empty.", nameof(BrandName));

            if (string.IsNullOrWhiteSpace(Image))
                throw new ArgumentException("Image cannot be null or empty.", nameof(Image));

            try
            {
                string storedProcedure = "usp_UpdateBrand";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@BrandId", BrandId),
                    new SqlParameter("@BrandName", BrandName),
                    new SqlParameter("@Image", Image)
                };
                DatabaseHelper.ExecuteNonQuery(storedProcedure, parameters, CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                // Log the exception and handle it appropriately
                throw new ApplicationException("An error occurred while updating the brand.", ex);
            }
        }

        // Delete Brand Method
        public static void DeleteBrand(int brandId)
        {
            if (brandId <= 0)
                throw new ArgumentException("BrandId must be a positive number.", nameof(brandId));

            try
            {
                string storedProcedure = "usp_DeleteBrand";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@BrandId", brandId)
                };
                DatabaseHelper.ExecuteNonQuery(storedProcedure, parameters, CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                // Log the exception and handle it appropriately
                throw new ApplicationException("An error occurred while deleting the brand.", ex);
            }
        }

        public static void DeleteBrandTemp(int brandId)
        {
            if (brandId <= 0)
                throw new ArgumentException("BrandId must be a positive number.", nameof(brandId));

            try
            {
                // SQL query to soft delete the brand by setting the 'deleted' column to 1
                string sql = "UPDATE Brand SET deleted = 1 WHERE brand_id = @BrandId";

                // SQL parameters
                SqlParameter[] parameters =
                {
                    new SqlParameter("@BrandId", brandId)
                };

                // Execute the query
                DatabaseHelper.ExecuteNonQuery(sql, parameters, CommandType.Text);
            }
            catch (SqlException ex)
            {
                // Log the exception and handle it appropriately
                throw new ApplicationException("An error occurred while deleting the brand.", ex);
            }
        }

        public static void RecoverBrand(int brandId)
        {
            if (brandId <= 0)
                throw new ArgumentException("BrandId must be a positive number.", nameof(brandId));

            try
            {
                string sql = "UPDATE Brand SET deleted = 0 WHERE brand_id = @BrandId";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@BrandId", brandId)
                };
                DatabaseHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                // Log the exception and handle it appropriately
                throw new ApplicationException("An error occurred while recovering the brand.", ex);
            }
        }



        // Method to Search for a Brand by ID
        public static Brand SearchBrand(int id)
        {
            string sql = "SELECT * FROM Brand WHERE brand_id = @BrandId";
            SqlParameter[] parameters =
            {
                new SqlParameter("@BrandId", id)
            };

            using (SqlDataReader reader = DatabaseHelper.ExecuteReader(sql, parameters))
            {
                if (reader.Read())
                {
                    return new Brand
                    {
                        BrandId = reader.GetInt32(0),
                        BrandName = reader.GetString(1),
                        Image = reader.GetString(2)
                    };
                }
            }
            return null;
        }


        // Method to Get All Brands
        public static List<Brand> GetAllBrands()
        {
            List<Brand> brands = new List<Brand>();
            string connectionString = ConfigurationManager.ConnectionStrings["CarDealershipDB"].ConnectionString;
            string query = "SELECT brand_id, brand_name, image FROM Brand WHERE deleted = 0";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Brand brand = new Brand
                    {
                        BrandId = reader.GetInt32(0),
                        BrandName = reader.GetString(1),
                        Image = reader.GetString(2)
                    };
                    brands.Add(brand);
                }
                reader.Close();
            }
            return brands;
        }
    }
}