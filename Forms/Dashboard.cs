using HR_ManagmentSystem_Client.Logic.Attendance;
using HR_ManagmentSystem_Client.Logic.Autherization;
using HR_ManagmentSystem_Client.Logic.Employee;
using HR_ManagmentSystem_Client.Logic.LeaveRequest;
using Newtonsoft.Json;

namespace HR_ManagmentSystem_Client
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }



        #region FORM lOAD
        private void Dashboard_Load(object sender, EventArgs e)
        {

            DisplayProfileAsync();



        }
        #endregion

        #region Display Profile

        EmployeeService empService = new EmployeeService("https://localhost:7191/api");
        LeaveRequestService leaveService = new LeaveRequestService("https://localhost:7191/api");
        AutherizationService authService = new AutherizationService("https://localhost:7191/api");
        AttendanceService attService = new AttendanceService("https://localhost:7191/api");
        async Task DisplayProfileAsync()
        {
            try
            {
                var empresponse = await empService.GetAllAsync();
                var response = await leaveService.GetAllAsync();
                var attResponse = await attService.GetAllAttendance();

                if (response != null && response.Succeeded && response.data != null)
                {

                    LeaveRequestGrid.DataSource = response.data;
                    label3.Text = response.data?.Count().ToString() ?? "0";
                    label5.Text = response.data?.Where(x => x.Status == "Approved").Count().ToString() ?? "0";
                    label7.Text = response.data?.Where(x => x.Status == "Rejected").Count().ToString() ?? "0";
                    label8.Text = response.data?.Where(x => x.Status == "Pending").Count().ToString() ?? "0";
                    label4.Text = empresponse.data?.Count().ToString() ?? "0";

                    int adminCounter = 0;

                    foreach (var employee in empresponse.data)
                    {

                        var authresponse = await authService.GetByIDAsync(employee.id);

                        if (authresponse?.data != null)
                        {
                            if (authresponse.data.Contains("Manager"))
                            {
                                adminCounter++;
                                continue;

                            }
                        }
                    }

                    label6.Text = adminCounter.ToString();


                    if (LeaveRequestGrid.Columns.Contains("employeeId"))
                    {
                        LeaveRequestGrid.Columns["employeeId"].Visible = false;
                    }



                    dataGridView1.DataSource = attResponse.data;

                    LeaveRequestGrid.ClearSelection();
                    dataGridView1.ClearSelection();

                    dataGridView1.CellFormatting += (sender, e) =>
                    {
                        // Check if the column being formatted is the "Status" column
                        if (e.ColumnIndex == dataGridView1.Columns["status"].Index)
                        {
                            var status = e.Value?.ToString().ToLower().Trim();

                            // Apply colors based on the status
                            if (status == "leaveearly")
                            {
                                e.CellStyle.BackColor = Color.Green;
                                e.CellStyle.ForeColor = Color.White;
                            }
                            else if (status == "present")
                            {
                                e.CellStyle.BackColor = Color.Yellow;
                                e.CellStyle.ForeColor = Color.Black;
                            }
                            else if (status == "absent")
                            {
                                e.CellStyle.BackColor = Color.Blue;
                                e.CellStyle.ForeColor = Color.White;
                            }
                            else if (status == "late")
                            {
                                e.CellStyle.BackColor = Color.Red;
                                e.CellStyle.ForeColor = Color.White;
                            }
                            else
                            {
                                // Default color for unknown status
                                e.CellStyle.BackColor = Color.Gray;
                                e.CellStyle.ForeColor = Color.White;
                            }
                        }
                    };


                    LeaveRequestGrid.CellFormatting += (sender, e) =>
                    {
                        // Check if the column being formatted is the "Status" column
                        if (e.ColumnIndex == LeaveRequestGrid.Columns["Status"].Index)
                        {
                            var status = e.Value?.ToString().ToLower().Trim();

                            // Apply colors based on the status
                            if (status == "approved")
                            {
                                e.CellStyle.BackColor = Color.Green;
                                e.CellStyle.ForeColor = Color.White;
                            }
                            else if (status == "rejected")
                            {
                                e.CellStyle.BackColor = Color.Red;
                                e.CellStyle.ForeColor = Color.White;
                            }
                            else if (status == "pending")
                            {
                                e.CellStyle.BackColor = Color.Yellow;
                                e.CellStyle.ForeColor = Color.Black;
                            }
                            else
                            {
                                // Default color for unknown status
                                e.CellStyle.BackColor = Color.Gray;
                                e.CellStyle.ForeColor = Color.White;
                            }
                        }
                    };
                }
                else
                {
                    // Handle error if the request failed
                    RJMessageBox.Show($"Failed to load LeaveRequest data: {response?.message ?? "Unknown error"}");
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


        private void LeaveRequestGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        private async Task ShowByDate()
        {
            try
            {




                if (datePicker.Value == DateTime.MinValue)
                {
                    RJMessageBox.Show("Please select a valid date.");
                    return;
                }
                DateOnly dateValue = DateOnly.FromDateTime(datePicker.Value.Date);


                // Attempt to send the data
                var dailyresponse = await attService.GetDailyAsync(dateValue);

                // Process response
                if (dailyresponse != null)
                {
                    if (dailyresponse.Succeeded)
                    {

                        dataGridView1.DataSource = dailyresponse.data;


                        dataGridView1.ClearSelection();

                        dataGridView1.CellFormatting += (sender, e) =>
                        {
                            // Check if the column being formatted is the "Status" column
                            if (e.ColumnIndex == dataGridView1.Columns["status"].Index)
                            {
                                var status = e.Value?.ToString().ToLower().Trim();

                                // Apply colors based on the status
                                if (status == "leaveearly")
                                {
                                    e.CellStyle.BackColor = Color.Green;
                                    e.CellStyle.ForeColor = Color.White;
                                }
                                else if (status == "present")
                                {
                                    e.CellStyle.BackColor = Color.Yellow;
                                    e.CellStyle.ForeColor = Color.Black;
                                }
                                else if (status == "absent")
                                {
                                    e.CellStyle.BackColor = Color.Blue;
                                    e.CellStyle.ForeColor = Color.White;
                                }
                                else if (status == "late")
                                {
                                    e.CellStyle.BackColor = Color.Red;
                                    e.CellStyle.ForeColor = Color.White;
                                }
                                else
                                {
                                    // Default color for unknown status
                                    e.CellStyle.BackColor = Color.Gray;
                                    e.CellStyle.ForeColor = Color.White;
                                }
                            }
                        };

                        //await DisplayProfileAsync(); // Refresh or update the UI
                    }
                    else
                    {
                        RJMessageBox.Show($"{dailyresponse.message}");
                    }
                }
                else
                {
                    RJMessageBox.Show("No response received from the server.");
                }
            }
            catch (HttpRequestException httpEx)
            {
                RJMessageBox.Show($"A network error occurred: {httpEx.Message}");
            }
            catch (JsonSerializationException jsonEx)
            {
                RJMessageBox.Show($"A data error occurred: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }
        private void show_btn_Click(object sender, EventArgs e)
        {
            ShowByDate();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
