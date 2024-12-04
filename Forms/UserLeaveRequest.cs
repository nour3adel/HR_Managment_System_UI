using HR_ManagmentSystem_Client.Logic;
using HR_ManagmentSystem_Client.Logic.LeaveRequest;
using HR_ManagmentSystem_Client.Logic.LeaveRequest.DTOs;

namespace HR_ManagmentSystem_Client
{
    public partial class UserLeaveRequest : Form
    {

        #region Databsae Connection
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";



        #endregion

        public UserLeaveRequest()
        {
            InitializeComponent();
        }

        #region FORM LOAD
        private void CategoryLists_Load(object sender, EventArgs e)
        {
            DisplayProfileAsync();
        }

        #endregion


        LeaveRequestService leaveService = new LeaveRequestService("https://localhost:7191/api");
        string userId = TokenService.GetClaimValue(sessionManager.AccessToken, "Id");

        #region Display
        async Task DisplayProfileAsync()
        {
            try
            {
                // Retrieve the user ID from the token claims

                if (string.IsNullOrEmpty(userId))
                {
                    RJMessageBox.Show("Unable to retrieve user ID from token. Please log in again.");
                    return;
                }

                // Call the leave service to get the leave request by ID
                var response = await leaveService.GetByIDAsync(userId);

                if (response != null && response.Succeeded && response.data != null)
                {
                    // Bind the list of leave requests to the DataGridView
                    LeaveRequestsGrid.DataSource = response.data;

                    // Optionally hide columns
                    if (LeaveRequestsGrid.Columns.Contains("id"))
                    {
                        LeaveRequestsGrid.Columns["id"].Visible = false;
                    }
                    if (LeaveRequestsGrid.Columns.Contains("EmployeeName"))
                    {
                        LeaveRequestsGrid.Columns["EmployeeName"].Visible = false;
                    }
                    if (LeaveRequestsGrid.Columns.Contains("EmployeeId"))
                    {
                        LeaveRequestsGrid.Columns["EmployeeId"].Visible = false;
                    }
                }
                else
                {
                    RJMessageBox.Show("No leave request data found.");
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                RJMessageBox.Show($"Unauthorized access: {ex.Message}");
                // Optionally, redirect to login
                var loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
            catch (HttpRequestException ex)
            {
                RJMessageBox.Show($"HTTP request failed: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                RJMessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        #endregion



        #region EXIT
        private void exit_Click(object sender, EventArgs e)
        {
            var result = RJMessageBox.Show("Close Application? ",
                "Alert",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async Task UpdateUserDataAsync()
        {
            try
            {
                // Validate message content
                string content = Description_txtbox.Texts.Trim();
                if (string.IsNullOrWhiteSpace(content))
                {
                    RJMessageBox.Show("Message content is required.");
                    return;
                }

                // Validate start date
                if (!startDatePicker.Checked)
                {
                    RJMessageBox.Show("Please select a valid start date.");
                    return;
                }
                DateOnly startDate = DateOnly.FromDateTime(startDatePicker.Value);

                // Validate end date
                if (!endDatePicker.Checked)
                {
                    RJMessageBox.Show("Please select a valid end date.");
                    return;
                }
                DateOnly endDate = DateOnly.FromDateTime(endDatePicker.Value);

                // Validate that the end date is not earlier than the start date
                if (endDate < startDate)
                {
                    RJMessageBox.Show("End date cannot be earlier than the start date.");
                    return;
                }

                // Create the DTO
                CreateLeaveRequestDTO sendDTO = new CreateLeaveRequestDTO
                {
                    employeeId = userId,
                    startDate = startDate,
                    endDate = endDate,
                    description = content,
                };

                // Attempt to send the data
                var response = await leaveService.CreateAsync(sendDTO);


                // Process the response
                if (response?.Succeeded == true)
                {
                    RJMessageBox.Show("Leave request created successfully!");
                    await DisplayProfileAsync(); // Refresh the profile UI
                }
                else
                {
                    RJMessageBox.Show($"Failed to create leave request: {response?.message ?? "Unknown error"}");
                }
            }

            catch (Exception ex)
            {
                RJMessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            UpdateUserDataAsync();
        }

        private void Description_txtbox__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
