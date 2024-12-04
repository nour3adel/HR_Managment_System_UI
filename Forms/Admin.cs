using HR_ManagmentSystem_Client.Logic;
using HR_ManagmentSystem_Client.Logic.Employee;
using System.Runtime.InteropServices;



namespace HR_ManagmentSystem_Client
{
    public partial class Admin : Form
    {

        #region Rounded FORM
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        #endregion
        public Admin()
        {
            InitializeComponent();
        }

        #region Form Load
        private void AdminForm_Load(object sender, EventArgs e)
        {
            // make winform rounded
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }
        #endregion

        #region PanelControl

        //open forms in panel
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

        #region Log out button

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
        private void Return_Click(object sender, EventArgs e)
        {
            LogOutAsync();
        }
        #endregion




        #region MagazineLists
        private void MagazineList_Click(object sender, EventArgs e)
        {
            LeaveRequest frm = new LeaveRequest();
            openformpanel(frm);
        }
        #endregion

        #region UserLists
        private void UserLists_Click(object sender, EventArgs e)
        {
            Employees frm = new Employees();
            openformpanel(frm);
        }
        #endregion

        #region Profile
        private void profile_Click(object sender, EventArgs e)
        {
            MyProfile frm = new MyProfile();
            openformpanel(frm);
        }
        #endregion

        #region Generate Report
        private void Settings_Click(object sender, EventArgs e)
        {
            Notifications frm = new Notifications();
            openformpanel(frm);
        }
        #endregion

        #region Dashboard
        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
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
