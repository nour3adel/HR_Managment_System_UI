using HR_ManagmentSystem_Client.Logic;
using HR_ManagmentSystem_Client.Logic.Authentication;
using System.Runtime.InteropServices;

namespace HR_ManagmentSystem_Client
{
    public partial class Login : Form
    {
        #region  Rounded Form

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);
        #endregion
        public static Login Instance { get; private set; }
        public string username { get; set; }


        public Login()
        {
            InitializeComponent();
            Instance = this;

        }

        #region Login Form Load
        private void Login_Load(object sender, EventArgs e)
        {
            // make winform rounded
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        #endregion

        #region Password Toggle
        private void rjToggleButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton2.CheckState == CheckState.Checked)
            {
                login_pass.PasswordChar = false;

            }

            if (rjToggleButton2.CheckState == CheckState.Unchecked)
            {

                login_pass.PasswordChar = true;
            }


        }
        #endregion

        #region Don't Have Account ( Sign UP ) Button
        private void label7_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp();
            form.Show();
            form.Owner = this;
            this.Hide();
        }
        #endregion

        #region Forgot Password Button
        private void label4_Click(object sender, EventArgs e)
        {
            //Recover form = new Recover();
            //form.Show();
            //form.Owner = this;
            //this.Hide();

        }
        #endregion

        #region Signin Button
        public string x;
        private void ShowForm(Form form)
        {
            form.Show();
            form.Owner = this;
            this.Hide();
        }

        private async void Signinbtn_Click(object sender, EventArgs e)
        {

            string username = login_usrname.Texts.Trim();
            string password = login_pass.Texts.Trim();

            if (login_usrname.Texts != string.Empty && login_pass.Texts != string.Empty)
            {
                login_usrname.BorderColor = Color.Black;
                login_pass.BorderColor = Color.Black;
                var authService = new AuthenticationService("https://localhost:7191/api");
                var response = await authService.LoginAsync(username, password);

                if (response != null && response.Succeeded && response.data != null)
                {
                    // To store the token


                    sessionManager.AccessToken = response.data.AccessToken;
                    // Save the access token using AuthManager
                    AuthManager.Instance.SaveAccessToken(response.data.AccessToken);
                    // Retrieve the access token wherever needed
                    //string accessToken = AuthManager.Instance.GetAccessToken();

                    List<string> roles = TokenService.GetRoles(response.data.AccessToken);

                    if (roles.Any())
                    {
                        if (roles.Contains("Manager"))
                        {
                            RJMessageBox.Show("WELCOME ADMIN");

                            var form = new Admin();
                            ShowForm(form);
                            return;
                        }

                        if (roles.Contains("User"))
                        {
                            RJMessageBox.Show("Login successful!");

                            var form = new Users();
                            ShowForm(form);
                            return;
                        }

                        // Handle any unexpected roles
                        RJMessageBox.Show("Role not recognized.");
                    }
                    else
                    {
                        RJMessageBox.Show("No roles found in the token.");
                    }


                }
                else
                {
                    RJMessageBox.Show($"Login failed: {response?.message ?? "Unknown error"}");
                }




            }
            else
            {
                RJMessageBox.Show("Make sure you correctly fill up the form");
                login_usrname.BorderColor = Color.Red;
                login_pass.BorderColor = Color.Red;

            }


        }









        #endregion

        #region RETURN
        private void hoverButton1_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            mn.Owner = this;
            this.Hide();

        }
        #endregion

        private void login_usrname__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
