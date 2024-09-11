using ADCoursework1.Entities;
using ADCoursework1.GUI.Forms;
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

namespace ADCoursework1.GUI.Customer.Controller
{
    public partial class CarCartItem : UserControl
    {
        private FlowLayoutPanel _parentPanel;
        public int CartId { get; set; }
        public int CarId { get; set; }
        public int ItemId { get; set; }

        public CarCartItem(FlowLayoutPanel parentPanel)
        {
            InitializeComponent();

            // Assign the passed panel to the private field
            _parentPanel = parentPanel;

            // Enable double buffering To stop screen flickering 
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            // Hook up the delete button event
            BtnDelete.Click += BtnDelete_Click;

            // Hook up the NumericUpDown value changed event
            NmrcUpDwnQuantity.ValueChanged += NmrcUpDwnQuantity_ValueChanged;
        }

        // Property for Image
        private string _imagePath;
        public string ImagePath
        {
            get { return _imagePath; }
            set
            {
                _imagePath = value;
                LoadImage(value);
            }
        }

        private void LoadImage(string imagePath)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(imagePath))
                {
                    // If the imagePath is a file path
                    PicBoxCar.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // If not specified, use a default image
                    //pictureBoxCar.Image = Properties.Resources.DefaultImage; // Make sure this resource is added to your project
                }
            }
            catch (Exception ex)
            {
                // Log the error or display a default error image
                //pictureBoxCar.Image = Properties.Resources.DefaultImage; // Fallback if image fails to load
                Console.WriteLine("Failed to load image: " + ex.Message);
            }
        }

        // Property for Brand
        private string _brand;
        public string Brand
        {
            get { return _brand; }
            set
            {
                _brand = value;
                LblBrand.Text = value; 
            }
        }

        // Property for Model
        private string _model;
        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
                LblModel.Text = value; 
            }
        }

        // Property for Year
        private string _year;
        public string Year
        {
            get { return _year; }
            set
            {
                _year = value;
                LblYear.Text = value;
            }
        }

        // Property for Price
        private string _price;
        public string Price
        {
            get { return _price; }
            set
            {
                _price = value;
                LblPrice.Text = "$" + value; 
            }
        }

        // Property for Quantity
        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                NmrcUpDwnQuantity.Value = value;
            }
        }

        // Event handler for the NumericUpDown value changed event
        private void NmrcUpDwnQuantity_ValueChanged(object sender, EventArgs e)
        {
            int newQuantity = (int)NmrcUpDwnQuantity.Value;

            if (newQuantity != Quantity)
            {
                try
                {
                    // Update the quantity in the database
                    Cart.UpdateCartQuantity(CartId, newQuantity);

                    // Update the local Quantity property
                    Quantity = newQuantity;

                    //MessageBox.Show("Quantity updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Home.ShowAlert("An error occurred while updating the quantity: " + ex.Message, Alert.AlertType.Error);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int cartId = this.CartId;  // Use the CartId directly

            if (cartId > 0)
            {
                try
                {
                    // Call the method to remove the item from the database using the CartId
                    Cart.RemoveFromCartByCartId(cartId);

                    // Remove the item from the parent FlowLayoutPanel
                    if (_parentPanel != null)
                    {
                        _parentPanel.Controls.Remove(this);
                        Home.ShowAlert("Item removed from cart successfully.", Alert.AlertType.Info);
                    }
                    else
                    {
                        Home.ShowAlert("_parentPanel is null.", Alert.AlertType.Error);
                    }
                }
                catch (Exception ex)
                {
                    Home.ShowAlert("An error occurred: " + ex.Message, Alert.AlertType.Error);
                }
            }
            else
            {
                Home.ShowAlert("Failed to find Cart ID.", Alert.AlertType.Error);
            }
        }
    }
}
