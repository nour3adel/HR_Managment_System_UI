using HR_ManagmentSystem_Client.Logic.Notification;
using HR_ManagmentSystem_Client.Logic.Notification.DTOs;
using Newtonsoft.Json;

namespace HR_ManagmentSystem_Client
{
    public partial class Notifications : Form
    {

        #region Databsae Connection
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";



        #endregion

        public Notifications()
        {
            InitializeComponent();
        }

        #region FORM LOAD
        private void CategoryLists_Load(object sender, EventArgs e)
        {
            DisplayProfileAsync();
        }

        #endregion


        NotificationService attService = new NotificationService("https://localhost:7191/api");


        #region Display Profile
        async Task DisplayProfileAsync()
        {
            try
            {




                var response = await attService.GetAllAsync();

                if (response != null && response.Succeeded && response.data != null)
                {
                    // Directly bind the list of attendance records to the DataGridView
                    dataGridView1.DataSource = response.data;
                    if (dataGridView1.Columns.Contains("Id"))
                    {
                        dataGridView1.Columns["Id"].Visible = false;
                    }

                    if (dataGridView1.Columns.Contains("isUrgent"))
                    {
                        dataGridView1.Columns["isUrgent"].Visible = false;
                    }
                }
                else
                {
                    RJMessageBox.Show("No Notification data found.");
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
                // Validate inputs
                string subject = subject_txtbox.Texts.Trim();
                if (string.IsNullOrWhiteSpace(subject))
                {
                    RJMessageBox.Show("Subject is required.");
                    return;
                }

                string emp_ID = empID_txtbox.Texts.Trim();
                if (string.IsNullOrWhiteSpace(emp_ID))
                {
                    RJMessageBox.Show("Employee ID is required.");
                    return;
                }

                string content = content_txtbox.Texts.Trim();
                if (string.IsNullOrWhiteSpace(content))
                {
                    RJMessageBox.Show("Message content is required.");
                    return;
                }

                // Validate Date
                if (date.Value == DateTime.MinValue)
                {
                    RJMessageBox.Show("Please select a valid date.");
                    return;
                }
                DateTime dateValue = date.Value;

                // Validate Notification Type
                string type = typeMenu.SelectedItem?.ToString()?.Trim();
                if (string.IsNullOrWhiteSpace(type) || !Enum.TryParse(type, out NotificationType notificationType))
                {
                    RJMessageBox.Show("Please select a valid notification type.");
                    return;
                }
                RJMessageBox.Show(type);
                RJMessageBox.Show(notificationType.ToString());

                // Get urgency checkbox value
                bool isUrgen = isUrgent.Checked;

                // Create the DTO
                var sendDTO = new SendDTO
                {
                    subject = subject,
                    EmployeeId = emp_ID,
                    MessageContent = content,
                    Date = dateValue,
                    Type = notificationType,
                    isUrgent = isUrgen
                };

                // Attempt to send the data
                var response = await attService.SendAsync(sendDTO);

                // Process response
                if (response != null)
                {
                    if (response.Succeeded)
                    {
                        RJMessageBox.Show("Notification sent successfully!");
                        await DisplayProfileAsync(); // Refresh or update the UI
                    }
                    else
                    {
                        RJMessageBox.Show($"Send failed: {response.message}");
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


        private void roundedButton1_Click(object sender, EventArgs e)
        {
            UpdateUserDataAsync();
        }
    }
}
