using HR_ManagmentSystem_Client.Logic;
using HR_ManagmentSystem_Client.Logic.Autherization;
using HR_ManagmentSystem_Client.Logic.Employee;

namespace HR_ManagmentSystem_Client
{
    public partial class MyProfile : Form
    {



        public MyProfile()
        {

            InitializeComponent();
        }

        #region FORM LOAD
        private void MyProfile_Load(object sender, EventArgs e)
        {
            DisplayProfileAsync();

        }
        #endregion

        #region Display Profile
        async Task DisplayProfileAsync()
        {
            try
            {
                var empService = new EmployeeService("https://localhost:7191/api");
                var authService = new AutherizationService("https://localhost:7191/api");

                // Await the service call
                var userId = TokenService.GetClaimValue(sessionManager.AccessToken, "Id");

                var response = await empService.GetByIDAsync(userId);
                var response2 = await authService.GetByIDAsync(userId);

                if (response != null && response.Succeeded && response.data != null)
                {
                    username_txtbox.Texts = response.data.username;
                    fullname_txtbox.Texts = response.data.fullname;
                    email_txtbox.Texts = response.data.email;
                    address_txtbox.Texts = response.data.address;
                    phone_txtbox.Texts = response.data.phonenumber;
                    salary_txtbox.Texts = response.data.salary.ToString("F2");
                    position_txtbox.Texts = response.data.position;

                    if (response2?.data != null)
                    {

                        roles_list.DataSource = response2.data.ToList();
                    }
                    else
                    {

                        RJMessageBox.Show("No roles available to display.");
                    }

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

        #endregion

        #region Update Profile
        private async Task UpdateUserDataAsync()
        {


            try
            {


                var userId = TokenService.GetClaimValue(sessionManager.AccessToken, "Id");
                string fullname = fullname_txtbox.Texts.Trim();
                string email = email_txtbox.Texts.Trim();
                string usrname = username_txtbox.Texts.Trim();
                string address = address_txtbox.Texts.Trim();
                string phoneNumber = phone_txtbox.Texts.Trim();
                string position = position_txtbox.Texts.Trim();
                decimal salary;
                if (decimal.TryParse(salary_txtbox.Texts.Trim(), out salary))
                {
                    // Successfully parsed, now you can use the salary variable
                }
                else
                {
                    // Handle the error if the input is not a valid decimal
                    RJMessageBox.Show("Invalid salary input. Please enter a valid number.");
                }




                var editData = new
                {
                    id = userId,
                    fullName = fullname,
                    username = usrname,
                    email = email,

                    address = address,

                    phoneNumber = phoneNumber,
                    salary = salary,
                    position = position


                };
                try
                {
                    var empService = new EmployeeService("https://localhost:7191/api");
                    var response = await empService.EditAsync(editData);

                    if (response != null)
                    {

                        if (response.Succeeded)
                        {
                            RJMessageBox.Show("Edit successful!");
                            DisplayProfileAsync();
                        }
                        else
                        {
                            RJMessageBox.Show($"Edit failed: {response.message}");
                        }
                    }
                    else
                    {
                        RJMessageBox.Show("No response received from the server.");
                    }

                }
                catch (Exception ex)
                {
                    var result = RJMessageBox.Show("Error updating user data: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
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

        #region Edit Button
        private void rjButton3_Click(object sender, EventArgs e)
        {
            UpdateUserDataAsync();
        }

        #endregion

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void phone_txtbox__TextChanged(object sender, EventArgs e)
        {

        }

        private void roles_list_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void username_txtbox__TextChanged(object sender, EventArgs e)
        {

        }

        #region Delete Profile
        private async Task DeleteProfileAsync()
        {
            try
            {
                var empService = new EmployeeService("https://localhost:7191/api");

                // Retrieve the User ID from the token
                var userId = TokenService.GetClaimValue(sessionManager.AccessToken, "Id");
                if (string.IsNullOrEmpty(userId))
                {
                    RJMessageBox.Show("User ID could not be retrieved from the token.");
                    return;
                }
                // Show confirmation dialog
                var result = RJMessageBox.Show(
                    "Are you sure you want to delete your profile? This action cannot be undo.",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                {
                    RJMessageBox.Show("Profile deletion canceled.");
                    return;
                }

                // Call the Delete API
                var response = await empService.DeleteAsync(userId);

                // Check the response and provide feedback
                if (response != null && response.Succeeded)
                {


                    RJMessageBox.Show("Profile deleted successfully!");

                    // Navigate to the login form
                    Login loginForm = new Login();
                    loginForm.Show();

                    var parentForm = this.ParentForm ?? this.Owner;
                    if (parentForm != null)
                    {
                        parentForm.Close();
                    }

                    this.Close();



                }
                else
                {
                    RJMessageBox.Show($"Failed to delete profile: {response?.message ?? "Unknown error occurred."}");
                }
            }
            catch (HttpRequestException ex)
            {
                RJMessageBox.Show($"Network error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        #endregion

        private async void delete_btn_Click(object sender, EventArgs e)
        {
            await DeleteProfileAsync();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
