using ADCoursework1.GUI.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ADCoursework1.GUI.Forms.Alert;

namespace ADCoursework1.Helper
{
    public static class ModalHelper
    {
        private static Form _overlay; // Store a reference to the overlay form

        public static void ShowModalWithMaximizedDimming(Form modalForm)
        {
            // Create a transparent overlay form
            Form overlay = new Form();
            overlay.FormBorderStyle = FormBorderStyle.None;
            overlay.Opacity = 0.5; // Semi-transparent (50% opacity)
            overlay.BackColor = Color.Black;
            overlay.WindowState = FormWindowState.Maximized;
            overlay.TopMost = true;
            overlay.ShowInTaskbar = false;
            overlay.Show();

            // Show the modal form on top of the overlay
            modalForm.StartPosition = FormStartPosition.CenterParent;
            modalForm.TopMost = true;

            // Show the modal form
            modalForm.ShowDialog();

            // Close the overlay when the modal form closes
            overlay.Close();
        }

        public static void CloseDimmingEffect()
        {
            if (_overlay != null)
            {
                _overlay.Close();
                _overlay.Dispose();
                _overlay = null;
            }
        }
    }
}
