using ADCoursework1.Entities;
using ADCoursework1.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.GUI.Forms
{
    public partial class CarForm : Form
    {
        public bool IsUpdateMode { get; set; }
        public int? CarId { get; set; }
        public bool IsViewMode { get; set; }

        public CarForm()
        {
            InitializeComponent();
            LoadBrands();

            Console.WriteLine($"CarForm initialized with CarId: {CarId}");
        }

        public CarForm(bool isUpdateMode = false, int? carId = null, bool isViewMode = false) : this()
        {
            IsUpdateMode = isUpdateMode;
            CarId = carId;
            IsViewMode = isViewMode; // Set the view mode

            if (IsViewMode)
            {
                LblFormHeading.Text = "View Car";
                BtnSubmit.Visible = false; // Hide the Submit button in view mode
                BtnChoose.Visible = false; // Hide the Choose Image button
                BtnRemove.Visible = false; // Hide the Remove Image button
                DisableFields(); // Make all fields read-only
                LoadCarDetails(CarId.Value); // Load the car details
            }
            else if (isUpdateMode && carId.HasValue)
            {
                LblFormHeading.Text = "Update Car";
                BtnSubmit.Text = "Update Car";
                LoadCarDetails(CarId.Value);
            }
            else
            {
                LblFormHeading.Text = "Add New Car";
                BtnSubmit.Text = "Add Car";
            }
        }

        private void DisableFields()
        {
            CmbBrand.Enabled = false;
            TbModel.ReadOnly = true;
            NmrcUpDwnYear.Enabled = false;
            TbPrice.ReadOnly = true;
            TbDescription.ReadOnly = true;
            PicBoxCar.Enabled = false;
        }

        private void ClearFields()
        {
            CmbBrand.SelectedIndex = -1;
            TbModel.Clear();
            NmrcUpDwnYear.Value = NmrcUpDwnYear.Minimum;  // Reset the numeric up-down to its minimum value or a default value
            TbPrice.Clear();
            PicBoxCar.Image = null;
            PicBoxCar.ImageLocation = null;
            TbDescription.Clear(); // Clear the description field
        }

        private void LoadBrands()
        {
            string sql = "SELECT brand_id, brand_name FROM Brand";
            using (SqlDataReader reader = DatabaseHelper.ExecuteReader(sql, null))
            {
                DataTable brandTable = new DataTable();
                brandTable.Load(reader);
                CmbBrand.DataSource = brandTable;
                CmbBrand.DisplayMember = "brand_name";
                CmbBrand.ValueMember = "brand_id";
            }
        }

        private void LoadCarDetails(int carId)
        {
            Car carInstance = new Car(); // Create an instance of the Car class
            Car car = carInstance.SearchCar(carId); // Call the non-static SearchCar method
            if (car != null)
            {
                CmbBrand.SelectedValue = car.BrandId;
                TbModel.Text = car.Model;

                // Ensure the year value is within the range of NmrcUpDwnYear control
                int yearValue = car.Year ?? (int)NmrcUpDwnYear.Minimum;
                NmrcUpDwnYear.Value = Math.Min(Math.Max(yearValue, NmrcUpDwnYear.Minimum), NmrcUpDwnYear.Maximum);

                TbPrice.Text = car.Price.ToString();
                PicBoxCar.ImageLocation = car.Image;
                TbDescription.Text = car.Description;
            }
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PicBoxCar.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            PicBoxCar.ImageLocation = null;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                Home.ShowAlert("Please fill in all required fields.", Alert.AlertType.Info);
                return;
            }

            Car car = new Car
            {
                BrandId = Convert.ToInt32(CmbBrand.SelectedValue),
                Model = TbModel.Text,
                Year = int.Parse(NmrcUpDwnYear.Value.ToString()),
                Price = decimal.Parse(TbPrice.Text),
                Image = PicBoxCar.ImageLocation,
                Description = TbDescription.Text
            };

            if (IsUpdateMode && CarId.HasValue)
            {
                car.CarId = CarId.Value;
                car.UpdateCar(); // Call the method to update the existing car
                Home.ShowAlert("Car updated successfully.", Alert.AlertType.Success);
            }
            else
            {
                car.AddCar(); // Call the method to insert a new car
                Home.ShowAlert("Car added successfully.", Alert.AlertType.Success);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private bool ValidateForm()
        {
            if (CmbBrand.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(TbModel.Text) ||
                NmrcUpDwnYear.Value == 0 ||
                string.IsNullOrWhiteSpace(TbPrice.Text) ||
                string.IsNullOrWhiteSpace(TbDescription.Text))
            {
                return false;
            }

            return true;
        }

    }
}
