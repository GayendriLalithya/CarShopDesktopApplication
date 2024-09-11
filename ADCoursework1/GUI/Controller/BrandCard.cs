using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.GUI.Controller
{
    public partial class BrandCard : UserControl
    {
        public BrandCard()
        {
            InitializeComponent();
        }

        // Property to set the brand name
        public string BrandName
        {
            get { return LblBrandName.Text; }
            set { LblBrandName.Text = value; }
        }

        // Property to set the brand image
        public string ImagePath
        {
            get { return PicBoxBrand.ImageLocation; }
            set
            {
                if (System.IO.File.Exists(value))
                {
                    PicBoxBrand.ImageLocation = value;
                }
                else
                {
                    PicBoxBrand.Image = null; // or set to a default image
                }
            }
        }
    }
}
