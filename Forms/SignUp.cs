using HR_ManagmentSystem_Client.Logic.Employee;
using System.Runtime.InteropServices;

namespace HR_ManagmentSystem_Client
{
    public partial class SignUp : Form
    {



        #region Rounded Form

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        #endregion
        public SignUp()
        {
            InitializeComponent();
        }

        #region SignUp Form Load
        private void SignUp_Load(object sender, EventArgs e)
        {
            // make winform rounded
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        #endregion

        #region Checkbox
        private void checkboxTerms_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region return button
        private void hoverButton4_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            form.Owner = this;
            this.Hide();
        }

        #endregion

        #region Password Toggle
        private void passtoggle_CheckedChanged(object sender, EventArgs e)
        {
            if (pass_toggle.CheckState == CheckState.Checked)
            {
                signup_pass.PasswordChar = false;
                signup_pass2.PasswordChar = false;

            }

            if (pass_toggle.CheckState == CheckState.Unchecked)
            {

                signup_pass.PasswordChar = true;
                signup_pass2.PasswordChar = true;
            }
        }

        #endregion


        #region Create Account
        private async void Createbtn_Click(object sender, EventArgs e)
        {
            // Retrieve form inputs
            string fullname = Fullname_txtbox.Texts.Trim();
            string email = email_txtbox.Texts.Trim();
            string usrname = username_txtbox.Texts.Trim();
            string address = address_txtbox.Texts.Trim();
            string position = position_txtbox.Texts.Trim();

            string phoneNumber = phonenumber_txtbox.Texts.Trim();
            string password = signup_pass.Texts.Trim();
            string confirm_password = signup_pass2.Texts.Trim();

            double salary;
            if (!double.TryParse(Salary_txtbox.Texts.Trim(), out salary))
            {
                RJMessageBox.Show("Please enter a valid salary.");
                return;
            }

            int department_id;
            if (!int.TryParse(department_txtbox.Texts.Trim(), out department_id))
            {
                RJMessageBox.Show("Please enter a valid department ID.");
                return;
            }
            var registrationData = new
            {
                fullName = fullname,
                email = email,
                userName = usrname,
                address = address,
                position = position,
                salary = salary,
                phoneNumber = phoneNumber,
                password = password,
                confirmPassword = confirm_password,
                departmentId = department_id,
                isAdmin = IsAdmin_chk.Checked,

            };


            // Validate inputs
            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(usrname) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirm_password) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(phoneNumber) ||
                string.IsNullOrWhiteSpace(position) ||
                string.IsNullOrWhiteSpace(fullname) ||
                salary <= 0 ||
                department_id <= 0)
            {
                RJMessageBox.Show("Make sure you correctly fill up the form.");
                return;
            }

            // Check password confirmation
            if (password != confirm_password)
            {
                RJMessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                var empService = new EmployeeService("https://localhost:7191/api");
                var response = await empService.RegisterAsync(registrationData);

                if (response != null)
                {

                    if (response.Succeeded)
                    {
                        RJMessageBox.Show("Registration successful!");
                        Login form = new Login();
                        form.Show();
                        form.Owner = this;
                        this.Hide();
                    }
                    else
                    {
                        RJMessageBox.Show($"Registration failed: {response.message ?? "Invalid Password."}");
                    }
                }
                else
                {
                    RJMessageBox.Show("No response received from the server.");
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        #endregion







        #region Signup Username
        private void signup_usr__TextChanged(object sender, EventArgs e)
        {
            if (username_txtbox.Texts != string.Empty)
            {
                if (username_txtbox.Texts.Length >= 8)
                {
                    username_txtbox.BorderColor = Color.FromArgb(0, 128, 0);
                }
                else
                {
                    username_txtbox.BorderColor = Color.FromArgb(255, 0, 0);
                }
            }
            else
            {
                username_txtbox.BorderColor = Color.FromArgb(255, 0, 0);
            }
        }

        #endregion


        #region already have ( Log in )
        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login form = new Login();
            form.Show();
            form.Owner = this;
            this.Hide();
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void email__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
