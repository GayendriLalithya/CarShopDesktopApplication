using ADCoursework1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.GUI.Forms
{
    public partial class BrandForm : Form
    {
        public bool IsUpdateMode { get; set; }
        public int? BrandId { get; set; }

        public BrandForm()
        {
            InitializeComponent();
        }

        public BrandForm(bool isUpdateMode = false, int? brandId = null) : this()
        {
            IsUpdateMode = isUpdateMode;
            BrandId = brandId;

            // Check if it's in update mode
            if (IsUpdateMode && BrandId.HasValue)
            {
                LblFormHeading.Text = "Update Brand"; // Change the heading label text
                BtnSubmit.Text = "Update Brand"; // Change the button text
                LoadBrandDetails(BrandId.Value); // Load brand details into the form fields
            }
            else
            {
                LblFormHeading.Text = "Add New Brand"; // Change the heading label text
                BtnSubmit.Text = "Add Brand"; // Change the button text
            }
        }

        private void LoadBrandDetails(int brandId)
        {
            Brand brand = Brand.SearchBrand(brandId); // Fetch the brand details
            if (brand != null)
            {
                TbBrand.Text = brand.BrandName; // Set the brand name in the text box
                PicBoxBrand.ImageLocation = brand.Image; // Load the image into the picture box
                                                         // Populate other fields if necessary
            }
            else
            {
                this.Close(); // Close the form if the brand isn't found
                Home.ShowAlert("Brand not found.", Alert.AlertType.Error);
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
                    PicBoxBrand.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            PicBoxBrand.ImageLocation = null;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                Home.ShowAlert("Please fill in all required fields.", Alert.AlertType.Error);
                return;
            }

            Brand brand = new Brand
            {
                BrandName = TbBrand.Text,
                Image = PicBoxBrand.ImageLocation
            };

            if (IsUpdateMode && BrandId.HasValue)
            {
                brand.BrandId = BrandId.Value;
                brand.UpdateBrand(); // Call the method to update the existing brand
                Home.ShowAlert("Brand updated successfully.", Alert.AlertType.Success);
            }
            else
            {
                brand.AddBrand(); // Call the method to insert a new brand
                Home.ShowAlert("Brand added successfully.", Alert.AlertType.Success);
            }

            this.Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(TbBrand.Text) || PicBoxBrand.ImageLocation == null)
            {
                return false;
            }

            return true;
        }
    }
}
