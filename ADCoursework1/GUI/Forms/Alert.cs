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
    public partial class Alert : Form
    {
        // Enum to specify the type of alert (Success, Warning, Error, Info)
        public enum AlertType
        {
            Success,
            Warning,
            Error,
            Info
        }

        // Enum to manage the current action state (Wait, Start, Close)
        private enum Action
        {
            Wait,
            Start,
            Close
        }

        // Action to control the state of the alert
        private Action _action;
        // Variables to store the X and Y positions of the alert on the screen
        private int _x, _y;

        public Alert()
        {
            InitializeComponent();
        }

        // Method to display the alert message with a specific alert type (Success, Error, Warning, Info)
        public void ShowAlert(string message, AlertType type)
        {
            // Set initial opacity to make the alert appear smoothly
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual; // Manual positioning of the alert
            string formName;

            // Loop through up to 10 possible positions to stack multiple alerts
            for (int i = 0; i < 10; i++)
            {
                formName = "alert" + i.ToString();
                // Check if an alert form with this name is already open
                Alert existingForm = (Alert)Application.OpenForms[formName];

                if (existingForm == null)
                {
                    // Set the form's name and position it on the screen
                    this.Name = formName;
                    _x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 5;
                    _y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * (i + 1) - 5 * i;
                    this.Location = new Point(_x, _y);
                    break;
                }
            }

            // Position the alert at the right side of the screen
            _x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            // Customize the alert appearance based on the type (Success, Error, Warning, Info)
            switch (type)
            {
                case AlertType.Success:
                    this.PicBoxIcon.Image = Properties.Resources.success_icon;
                    this.LblMessage.ForeColor = Color.ForestGreen;
                    this.PnlMessageBox.BorderColor = Color.LimeGreen;
                    this.PnlMessageBox.FillColor = Color.FromArgb(192, 255, 192);
                    break;
                case AlertType.Error:
                    this.PicBoxIcon.Image = Properties.Resources.error_icon;
                    this.LblMessage.ForeColor = Color.Red;
                    this.PnlMessageBox.BorderColor = Color.Red;
                    this.PnlMessageBox.FillColor = Color.FromArgb(255, 192, 192);
                    break;
                case AlertType.Warning:
                    this.PicBoxIcon.Image = Properties.Resources.warning_icon;
                    this.LblMessage.ForeColor = Color.FromArgb(192, 64, 0);
                    this.PnlMessageBox.BorderColor = Color.DarkOrange;
                    this.PnlMessageBox.FillColor = Color.FromArgb(255, 224, 192);
                    break;
                case AlertType.Info:
                    this.PicBoxIcon.Image = Properties.Resources.info_icon;
                    this.LblMessage.ForeColor = Color.Blue;
                    this.PnlMessageBox.BorderColor = Color.Blue;
                    this.PnlMessageBox.FillColor = Color.FromArgb(192, 192, 255);
                    break;
            }

            // Set the alert message text
            this.LblMessage.Text = message;

            // Show the alert and initiate the start action
            this.Show();
            _action = Action.Start;
            TimerAlert.Interval = 1; // Short interval to begin showing the alert
            TimerAlert.Start();
        }

        // Event handler for closing the alert when the close button is clicked
        private void CtrlBoxClose_Click(object sender, EventArgs e)
        {
            TimerAlert.Interval = 1; // Short interval for closing
            _action = Action.Close; // Change action state to close
        }

        // Timer tick event to control the different actions (Start, Wait, Close)
        private void TimerAlert_Tick(object sender, EventArgs e)
        {
            switch (_action)
            {
                // Wait action - after showing the alert, wait for a few seconds
                case Action.Wait:
                    TimerAlert.Interval = 5000; // 5-second wait before closing
                    _action = Action.Close;
                    break;

                // Start action - gradually increase the opacity and move the alert into view
                case Action.Start:
                    TimerAlert.Interval = 1; // Set interval for fast execution
                    this.Opacity += 0.1; // Increase opacity
                    if (_x < this.Location.X)
                    {
                        // Move the alert left into position
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            // Once fully visible, switch to Wait action
                            _action = Action.Wait;
                        }
                    }
                    break;

                // Close action - decrease opacity and move the alert off-screen
                case Action.Close:
                    TimerAlert.Interval = 1; // Set interval for fast execution
                    this.Opacity -= 0.1; // Decrease opacity

                    this.Left -= 3; // Move the alert off-screen to the left

                    // Close the form once the opacity reaches zero
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }
    }
}