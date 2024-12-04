﻿using HR_ManagmentSystem_Client.Logic;
using HR_ManagmentSystem_Client.Logic.Autherization;
using HR_ManagmentSystem_Client.Logic.Employee;
using System.Runtime.InteropServices;




namespace HR_ManagmentSystem_Client
{
    public partial class Users : Form
    {
        #region Rounded FORM
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        #endregion

        public Users()
        {
            InitializeComponent();

        }

        #region FORM LOAD
        private void USERSFORM_Load(object sender, EventArgs e)
        {
            var authService = new AutherizationService("https://localhost:7191/api");
            var username = TokenService.GetClaimValue(sessionManager.AccessToken, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name");

            label1.Text = username.ToUpper();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

        }
        #endregion

        #region Exit BUTTON
        private void exit_Click(object sender, EventArgs e)
        {
            var result = RJMessageBox.Show("Close Application? ",
                       "Alert",
                       MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        #endregion

        #region LogOut
        async Task LogOutAsync()
        {

            // Display a confirmation message box before logging out
            var result = RJMessageBox.Show("Are you sure you want to log out?",
               "Confirm Log Out",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            // If the user clicks 'Yes' to confirm
            if (result == DialogResult.Yes)
            {
                try
                {
                    var empService = new EmployeeService("https://localhost:7191/api");




                    var response = await empService.LogOut();


                    if (response != null && response.Succeeded)
                    {


                        sessionManager.AccessToken = null;
                        // Open the login form
                        Login form = new Login();
                        form.Show();
                        form.Owner = this;

                        // Hide the current form
                        this.Hide();

                    }
                    else
                    {
                        // Handle cases where the response is unsuccessful
                        RJMessageBox.Show($"Failed to load employee data: {response?.message ?? "Unknown error"}");
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    RJMessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                // If logout failed, show an error message
                RJMessageBox.Show("Log out failed. Please try again.");
            }
        }
        private void LogOut_Click(object sender, EventArgs e)
        {

            LogOutAsync();

        }
        #endregion

        #region profile
        private void Profile_Click(object sender, EventArgs e)
        {
            MyProfile frm = new MyProfile();

            openformpanel(frm);
        }
        #endregion


        #region My Orders
        private void Favorites_Click(object sender, EventArgs e)
        {
            UserNotifications frm = new UserNotifications();

            openformpanel(frm);
        }

        #endregion

        #region PanelControl
        private void openformpanel(Form form)
        {
            // Remove all controls from the panel
            this.ContainerPanel.Controls.Clear();

            // Add the new form to the panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.ContainerPanel.Controls.Add(form);
            this.ContainerPanel.Tag = form;
            form.Show();

        }


        #endregion

        #region Magazine List Button
        private void MagazineList_Click(object sender, EventArgs e)
        {
            Attendance frm = new Attendance();
            openformpanel(frm);
        }
        #endregion

        #region Category List Button
        private void button1_Click(object sender, EventArgs e)
        {
            UserLeaveRequest frm = new UserLeaveRequest();
            openformpanel(frm);
        }

        #endregion

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
