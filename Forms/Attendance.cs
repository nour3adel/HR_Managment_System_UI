using CustomControls.RJControls;
using HR_ManagmentSystem_Client.Logic;
using HR_ManagmentSystem_Client.Logic.Attendance;
using HR_ManagmentSystem_Client.Logic.Attendance.DTOs;

namespace HR_ManagmentSystem_Client
{
    public partial class Attendance : Form
    {

        public Attendance()
        {
            InitializeComponent();
        }

        #region FORM LOAD
        private void Settings_Load(object sender, EventArgs e)
        {


            DisplayProfileAsync();


        }
        #endregion

        #region Display Profile
        async Task DisplayProfileAsync()
        {
            try
            {
                // Assuming attendanceGrid is a DataGridView
                var attService = new AttendanceService("https://localhost:7191/api");

                // Await the service call
                var userId = TokenService.GetClaimValue(sessionManager.AccessToken, "Id");

                var response = await attService.GetByIDAsync(userId);

                if (response != null && response.Succeeded && response.data != null)
                {
                    // Directly bind the list of attendance records to the DataGridView
                    attendanceGrid.DataSource = response.data;
                }
                else
                {
                    RJMessageBox.Show("No attendance data found.");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                RJMessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        #endregion



        #region EXIT
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


        private async void rjButton2_Click(object sender, EventArgs e)
        {
            var attService = new AttendanceService("https://localhost:7191/api");

            try
            {
                // Retrieve the employee ID (you can replace it with the actual value from the token or a text box)
                var userId = TokenService.GetClaimValue(sessionManager.AccessToken, "Id");

                if (string.IsNullOrEmpty(userId))
                {
                    RJMessageBox.Show("User ID is missing.");
                    return;
                }

                var clockInDto = new ClockInDTO
                {
                    EmployeeId = userId
                };

                var response = await attService.ClockIn(clockInDto);

                if (response != null && response.Succeeded)
                {
                    RJMessageBox.Show("Clock In successful!");
                }
                else
                {
                    RJMessageBox.Show($"Clock In failed: {response?.message ?? "Unknown error"}");
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"An error occurred: {ex.Message}");
            }
            DisplayProfileAsync();
        }

        private async void rjButton4_Click(object sender, EventArgs e)
        {
            var attService = new AttendanceService("https://localhost:7191/api");

            try
            {
                // Retrieve the employee ID (you can replace it with the actual value from the token or a text box)
                var userId = TokenService.GetClaimValue(sessionManager.AccessToken, "Id");

                if (string.IsNullOrEmpty(userId))
                {
                    RJMessageBox.Show("User ID is missing.");
                    return;
                }

                var clockOutDto = new ClockOutDTO
                {
                    EmployeeId = userId
                };

                var response = await attService.ClockOut(clockOutDto);

                if (response != null && response.Succeeded)
                {
                    RJMessageBox.Show("Clock Out successful!");
                }
                else
                {
                    RJMessageBox.Show($"Clock Out failed: {response?.message ?? "Unknown error"}");
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"An error occurred: {ex.Message}");
            }
            DisplayProfileAsync();

        }



        #region Search by Category

        private void DropdownMenu_VisibleChanged(object sender, EventArgs e, Control ctrl)
        {


            RJDropdownMenu dropdownMenu = (RJDropdownMenu)sender;
            if (!DesignMode)
            {
                if (dropdownMenu.Visible)
                    ctrl.BackColor = Color.FromArgb(29, 34, 39);
                else ctrl.BackColor = Color.FromArgb(29, 34, 39);

            }
        }
        private void Open_DropdownMenu2(RJDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev)
              => DropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width, 0);
        }


        private void rjButton3_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu2(rjDropdownMenu1, sender);
        }


        private void rjDropdownMenu1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            string x = e.ClickedItem.Text; // retrieve the clicked item's text
            string q = "select * from MAGAZINE where CATEGORY = '" + x + "'";

        }



        #endregion

        #region Show All Button
        private void rjButton5_Click(object sender, EventArgs e)
        {


        }

        #endregion

        private void attendanceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
