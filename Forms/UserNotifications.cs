using HR_ManagmentSystem_Client.Logic;
using HR_ManagmentSystem_Client.Logic.Notification;

namespace HR_ManagmentSystem_Client
{
    public partial class UserNotifications : Form
    {

        #region Databsae Connection
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";



        #endregion

        public UserNotifications()
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





                // Await the service call
                var userId = TokenService.GetClaimValue(sessionManager.AccessToken, "Id");

                var response = await attService.GetEmployeeNotificationsAsync(userId);

                if (response != null && response.Succeeded && response.data != null)
                {
                    // Directly bind the list of attendance records to the DataGridView
                    dataGridView1.DataSource = response.data;
                    if (dataGridView1.Columns.Contains("employeeName"))
                    {
                        dataGridView1.Columns["employeeName"].Visible = false;
                    }

                    //if (dataGridView1.Columns.Contains("isUrgent"))
                    //{
                    //    dataGridView1.Columns["isUrgent"].Visible = false;
                    //}
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
    }
}
