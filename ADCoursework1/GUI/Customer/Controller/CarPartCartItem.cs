using ADCoursework1.Entities;
using ADCoursework1.GUI.Forms;
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

namespace ADCoursework1.GUI.Customer.Controller
{
    public partial class CarPartCartItem : UserControl
    {
        private FlowLayoutPanel _parentPanel;
        public int CartId { get; set; }
        public int CarPartId { get; set; }
        public int ItemId { get; set; }

        public CarPartCartItem(FlowLayoutPanel parentPanel)
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
                LoadPartImage(value);
            }
        }

        private void LoadPartImage(string imagePath)
        {
            Console.WriteLine("Loading image from path: " + imagePath);  // Log the path to debug
            try
            {
                if (!string.IsNullOrWhiteSpace(imagePath))
                {
                    PicBoxCarPart.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Optionally, log when no path is provided
                    Console.WriteLine("No image path provided.");
                }
            }
            catch (Exception ex)
            {
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

        // Property for Car Part Name
        private string _carpartname;
        public string CarPartName
        {
            get { return _carpartname; }
            set
            {
                _carpartname = value;
                LblPartName.Text = value;
            }
        }

        // Property for Car Part Name
        private string _partnumber;
        public string PartNumber
        {
            get { return _partnumber; }
            set
            {
                _partnumber = value;
                LblPartNo.Text = value;
            }
        }

        // Property for Part Price
        private string _partprice;
        public string PartPrice
        {
            get { return _partprice; }
            set
            {
                _partprice = value;
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
                NmrcUpDwnQuantity.Value = value; // Set the quantity value to the NumericUpDown
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

                    Home.ShowAlert("Quantity updated successfully.", Alert.AlertType.Info);
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
