using HR_ManagmentSystem_Client.Logic.Autherization;
using HR_ManagmentSystem_Client.Logic.Employee;
using HR_ManagmentSystem_Client.Logic.Employee.DTOs;

namespace HR_ManagmentSystem_Client
{
    public partial class Employees : Form
    {

        #region Database Connection
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";


        #endregion
        public Employees()
        {
            InitializeComponent();
        }

        #region FORM LOAD
        private void UserLists_Load(object sender, EventArgs e)
        {
            DisplayProfileAsync();

        }
        #endregion

        #region Display Profile
        EmployeeService empService = new EmployeeService("https://localhost:7191/api");
        AutherizationService authService = new AutherizationService("https://localhost:7191/api");
        async Task DisplayProfileAsync()
        {
            try
            {

                var response = await empService.GetAllAsync();



                if (response != null && response.Succeeded && response.data != null)
                {
                    // If the response is successful, convert the data to a list of employees
                    var employees = response.data.ToList();

                    // Now you can use 'employees' as needed
                    foreach (var employee in employees)
                    {
                        Console.WriteLine($"Name: {employee.fullname}, Position: {employee.position}, Salary: {employee.salary}");
                    }
                    DisplayCardsAsync(employees);
                }
                else
                {
                    // Handle error if the request failed
                    RJMessageBox.Show($"Failed to load employee data: {response?.message ?? "Unknown error"}");
                }


            }
            catch (Exception ex)
            {
                // Handle exceptions
                RJMessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private async Task DisplayCardsAsync(IEnumerable<SelectCustomerDTO> employees)
        {
            flpCards.Controls.Clear();

            foreach (var item in employees)
            {
                var response2 = await authService.GetByIDAsync(item.id);

                Panel shadowPanel = new Panel
                {
                    Width = 345,
                    Height = 350,
                    BackColor = Color.FromArgb(255, 128, 128),
                    Margin = new Padding(10),
                };

                Panel card = new Panel
                {
                    Width = 335,
                    Height = 340,
                    BackColor = Color.FromArgb(22, 22, 22),
                    BorderStyle = BorderStyle.None
                };


                card.Left = (shadowPanel.Width - card.Width) / 2;
                card.Top = (shadowPanel.Height - card.Height) / 2;
                shadowPanel.Controls.Add(card);
                this.Controls.Add(shadowPanel);

                Label lblName = new Label
                {
                    Text = item.fullname.ToUpper(),
                    Font = new Font("Arial Rounded MT Bold", 15, FontStyle.Bold),
                    ForeColor = Color.White,

                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 40
                };

                Label lbluserName = new Label
                {
                    Text = $"Username: {item.username}",
                    Font = new Font("Arial Rounded MT Bold", 12),
                    ForeColor = Color.White,

                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 5, 10, 5),
                    Dock = DockStyle.Top,
                    Height = 30
                };

                Label lblPosition = new Label
                {
                    Text = $"Position: {item.position}",
                    Font = new Font("Arial Rounded MT Bold", 12),
                    ForeColor = Color.White,

                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 5, 10, 5),
                    Dock = DockStyle.Top,
                    Height = 30
                };

                Label lblPhone = new Label
                {
                    Text = $"Phone: {item.phonenumber}",
                    Font = new Font("Arial Rounded MT Bold", 12),
                    ForeColor = Color.White,

                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 5, 10, 5),
                    Dock = DockStyle.Top,
                    Height = 30
                };

                Label lblEmail = new Label
                {
                    Text = $"Email: {item.email}",
                    Font = new Font("Arial Rounded MT Bold", 12),
                    ForeColor = Color.White,

                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 5, 10, 5),
                    Dock = DockStyle.Top,
                    Height = 30
                };

                Label lblSalary = new Label
                {
                    Text = $"Salary: ${item.salary:N2}",
                    Font = new Font("Arial Rounded MT Bold", 12),
                    ForeColor = Color.White,

                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 5, 10, 5),
                    Dock = DockStyle.Top,
                    Height = 30
                };

                Label lblAddress = new Label
                {
                    Text = $"Address: {item.address}",
                    Font = new Font("Arial Rounded MT Bold", 12),
                    ForeColor = Color.White,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 5, 10, 5),
                    Dock = DockStyle.Top,
                    Height = 30
                };

                Label lblRoles = new Label
                {
                    Text = "Roles: ",
                    Font = new Font("Arial Rounded MT Bold", 12),
                    ForeColor = Color.DeepPink,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 5, 10, 5),
                    Dock = DockStyle.Top,
                    Height = 30
                };
                string rolesText = string.Join(", ", response2.data.Select(role => role.ToString()));
                lblRoles.Text += rolesText;

                RoundedButton deleteBtn = new RoundedButton
                {
                    Text = "DELETE",
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(255, 128, 128),
                    Cursor = Cursors.Hand,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0), // Smaller font size
                    CornerRadius = 15, // Reduced corner radius for a less rounded button
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter, // Center the text
                    Padding = new Padding(10, 5, 10, 5),
                    Size = new Size(120, 35), // Reduced size of the button
                    UseVisualStyleBackColor = false,

                };


                deleteBtn.Left = (card.Width - deleteBtn.Width) / 2;
                deleteBtn.Top = card.Height - deleteBtn.Height - 10;



                card.Controls.Add(deleteBtn);
                card.Controls.Add(lblRoles);
                card.Controls.Add(lblSalary);
                card.Controls.Add(lblAddress);
                card.Controls.Add(lblPhone);
                card.Controls.Add(lblEmail);
                card.Controls.Add(lblPosition);
                card.Controls.Add(lbluserName);
                card.Controls.Add(lblName);
                flpCards.Controls.Add(shadowPanel);


                // When Click Delete
                deleteBtn.Click += async (sender, e) =>
                {
                    await DeleteProfileAsync(item.id);

                };
            }
        }
        #endregion

        #region Delete Profile
        private async Task DeleteProfileAsync(string id)
        {
            try
            {
                var empService = new EmployeeService("https://localhost:7191/api");


                if (string.IsNullOrEmpty(id))
                {
                    RJMessageBox.Show("User ID Not FOund");
                    return;
                }
                // Show confirmation dialog
                var result = RJMessageBox.Show(
                    "Are you sure you want to delete This User? This action cannot be undo.",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                {
                    RJMessageBox.Show("User deletion canceled.");
                    return;
                }

                // Call the Delete API
                var response = await empService.DeleteAsync(id);

                // Check the response and provide feedback
                if (response != null && response.Succeeded)
                {


                    RJMessageBox.Show("User deleted successfully!");

                    await DisplayProfileAsync();



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

        #region Save Changes
        private void rjButton1_Click(object sender, EventArgs e)
        {

            try
            {

                var result = RJMessageBox.Show("Update Succefuly");


            }
            catch (Exception)
            {
                var result = RJMessageBox.Show("Update Failed",
               "",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);

            }

        }
        #endregion

        #region EXIT Button
        private void exit_Click_1(object sender, EventArgs e)
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

        private void flpCards_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
