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
    public partial class CarPartForm : Form
    {
        public bool IsUpdateMode { get; set; }
        public int? CarPartId { get; set; }
        public bool IsViewMode { get; set; }

        public CarPartForm()
        {
            InitializeComponent();
            LoadBrands();
        }

        public CarPartForm(bool isUpdateMode = false, int? carPartId = null, bool isViewMode = false) : this()
        {
            IsUpdateMode = isUpdateMode;
            CarPartId = carPartId;
            IsViewMode = isViewMode; // Set the view mode

            if (IsViewMode)
            {
                LblFormHeading.Text = "View Car Part";
                BtnSubmit.Visible = false; // Hide the Submit button in view mode
                BtnChoose.Visible = false; // Hide the Choose Image button
                BtnRemove.Visible = false; // Hide the Remove Image button
                DisableFields(); // Make all fields read-only
                LoadCarPartDetails(CarPartId.Value); // Load the car part details
            }
            else if (isUpdateMode && carPartId.HasValue)
            {
                LblFormHeading.Text = "Update Car Part";
                BtnSubmit.Text = "Update Car Part";
                LoadCarPartDetails(CarPartId.Value);
            }
            else
            {
                LblFormHeading.Text = "Add New Car Part";
                BtnSubmit.Text = "Add Car Part";
            }
        }

        private void DisableFields()
        {
            CmbBrand.Enabled = false;
            TbCarPart.ReadOnly = true;
            TbPartNo.ReadOnly = true;
            TbPartPrice.ReadOnly = true;
            TbDescription.ReadOnly = true;
            PicBoxCarPart.Enabled = false;
        }

        private void ClearFields()
        {
            CmbBrand.SelectedIndex = -1;
            TbCarPart.Clear();
            TbPartNo.Clear();
            TbPartPrice.Clear();
            PicBoxCarPart.Image = null;
            PicBoxCarPart.ImageLocation = null;
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

        private void LoadCarPartDetails(int carPartId)
        {
            CarPart carPartInstance = new CarPart(); // Create an instance of the CarPart class
            CarPart carPart = carPartInstance.SearchCarPart(carPartId); // Call the non-static SearchCarPart method
            if (carPart != null)
            {
                CmbBrand.SelectedValue = carPart.BrandId;
                TbCarPart.Text = carPart.CarPartName;
                TbPartNo.Text = carPart.PartNumber;
                TbPartPrice.Text = carPart.PartPrice.ToString();
                PicBoxCarPart.ImageLocation = carPart.Image;
                TbDescription.Text = carPart.Description; // Load description
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
                    PicBoxCarPart.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            PicBoxCarPart.ImageLocation = null;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                Home.ShowAlert("Please fill in all required fields.", Alert.AlertType.Info);
                return;
            }

            CarPart carPart = new CarPart
            {
                CarPartName = TbCarPart.Text,
                BrandId = Convert.ToInt32(CmbBrand.SelectedValue),
                PartNumber = TbPartNo.Text,
                PartPrice = decimal.Parse(TbPartPrice.Text),
                Image = PicBoxCarPart.ImageLocation,
                Description = TbDescription.Text
            };

            if (IsUpdateMode && CarPartId.HasValue)
            {
                carPart.CarPartId = CarPartId.Value;
                carPart.UpdateCarPart(); // Call the method to update the existing car part
                Home.ShowAlert("Car part updated successfully.", Alert.AlertType.Success);
            }
            else
            {
                carPart.AddCarPart(); // Call the method to insert a new car part
                Home.ShowAlert("Car part added successfully.", Alert.AlertType.Success);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidateForm()
        {
            // Check if Car Part name is empty
            if (string.IsNullOrWhiteSpace(TbCarPart.Text))
            {
                Home.ShowAlert("Please enter the Car Part Name.", Alert.AlertType.Error);
                TbCarPart.Focus();
                return false;
            }

            // Check if Brand is selected
            if (CmbBrand.SelectedIndex == -1)
            {
                Home.ShowAlert("Please select a Brand.", Alert.AlertType.Error);
                CmbBrand.Focus();
                return false;
            }

            // Check if Part Number is empty
            if (string.IsNullOrWhiteSpace(TbPartNo.Text))
            {
                Home.ShowAlert("Please enter the Part Number.", Alert.AlertType.Error);
                TbPartNo.Focus();
                return false;
            }

            // Check if Part Price is empty or not a valid decimal
            if (string.IsNullOrWhiteSpace(TbPartPrice.Text) || !decimal.TryParse(TbPartPrice.Text, out _))
            {
                Home.ShowAlert("Please enter a valid Part Price.", Alert.AlertType.Error);
                TbPartPrice.Focus();
                return false;
            }

            return true;
        }


    }
}
