using HR_ManagmentSystem_Client.Logic.LeaveRequest;
using HR_ManagmentSystem_Client.Logic.LeaveRequest.DTOs;

namespace HR_ManagmentSystem_Client
{
    public partial class LeaveRequest : Form
    {



        public LeaveRequest()
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
        LeaveRequestService leaveService = new LeaveRequestService("https://localhost:7191/api");
        async Task DisplayProfileAsync()
        {
            try
            {
                // Fetch the data from the leave service
                var response = await leaveService.GetAllAsync();

                if (response != null && response.Succeeded && response.data != null)
                {
                    var employees = response.data;

                    // Check if there are no employees with "Pending" status
                    if (!employees.Any(x => x.Status == "Pending"))
                    {

                        label1.Visible = true;

                    }
                    else
                    {
                        label1.Visible = false;
                        // Display the employee cards
                        await DisplayCardsAsync(employees);
                    }
                }
                else
                {
                    // Handle error if the request failed
                    RJMessageBox.Show($"Failed to load employee data: {response?.message ?? "Unknown error"}");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the execution
                RJMessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private async Task DisplayCardsAsync(IEnumerable<GetLeaveRequestDTO> employees)
        {
            // Clear previous controls
            flpCards.Controls.Clear();

            foreach (var item in employees)
            {
                // Ensure the item is valid before continuing
                if (item == null) continue;



                // Create the shadow panel
                Panel shadowPanel = new Panel
                {
                    Width = 345,
                    Height = 250, // Increase height for better visibility
                    BackColor = Color.FromArgb(255, 128, 128),
                    Margin = new Padding(10),
                };

                // Create the card panel
                Panel card = new Panel
                {
                    Width = 335,
                    Height = 240, // Increase height to fit content
                    BackColor = Color.FromArgb(22, 22, 22),
                    BorderStyle = BorderStyle.None
                };

                // Check the leave request status and proceed with layout
                if (item.Status.ToLower().Trim() == "pending")
                {

                    // Center the card within the shadow panel
                    card.Left = (shadowPanel.Width - card.Width) / 2;
                    card.Top = (shadowPanel.Height - card.Height) / 2;
                    shadowPanel.Controls.Add(card);
                    flpCards.Controls.Add(shadowPanel); // Add the shadowPanel to flpCards



                    // Create Labels and Buttons for card content
                    Label lblName = CreateLabel(item.EmployeeName.ToUpper(), 15, Color.White, ContentAlignment.MiddleCenter, 40);
                    Label lblStartDate = CreateLabel($"Start Date: {item.StartDate.ToShortDateString()}", 12, Color.White, ContentAlignment.MiddleLeft, 30);
                    Label lblEndDate = CreateLabel($"End Date: {item.EndDate.ToShortDateString()}", 12, Color.White, ContentAlignment.MiddleLeft, 30);
                    Label lblDescription = CreateLabel($"Description: {item.Description}", 12, Color.White, ContentAlignment.MiddleLeft, 30);
                    Label lblStatus = CreateLabel($"Status: {item.Status}", 12, Color.White, ContentAlignment.MiddleLeft, 30);

                    // Add Labels to the card
                    card.Controls.Add(lblStatus);
                    card.Controls.Add(lblDescription);
                    card.Controls.Add(lblEndDate);
                    card.Controls.Add(lblStartDate);
                    card.Controls.Add(lblName);

                    // Create Approve and Reject buttons
                    RoundedButton ApproveBtn = CreateButton("APPROVE", Color.Green);
                    RoundedButton RejectBtn = CreateButton("REJECT", Color.Red);

                    // Set button positions
                    int buttonSpacing = 10;
                    int totalButtonWidth = ApproveBtn.Width + RejectBtn.Width + buttonSpacing;

                    ApproveBtn.Left = (card.Width - totalButtonWidth) / 2;
                    ApproveBtn.Top = card.Height - ApproveBtn.Height - 10;

                    RejectBtn.Left = ApproveBtn.Left + ApproveBtn.Width + buttonSpacing;
                    RejectBtn.Top = card.Height - RejectBtn.Height - 10;

                    // Add buttons to card
                    card.Controls.Add(RejectBtn);
                    card.Controls.Add(ApproveBtn);

                    // Button event handlers
                    ApproveBtn.Click += async (sender, e) =>
                    {
                        await ApproveLeaveRequest(item.id); // Make sure `item.Id` is correct
                    };
                    RejectBtn.Click += async (sender, e) =>
                    {
                        await RejectLeaveRequest(item.id); // Make sure `item.Id` is correct
                    };
                }

            }
        }
        #endregion
        private Label CreateLabel(string text, int fontSize, Color foreColor, ContentAlignment alignment, int height)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Arial Rounded MT Bold", fontSize, FontStyle.Bold),
                ForeColor = foreColor,
                AutoSize = false,
                TextAlign = alignment,
                Dock = DockStyle.Top,
                Height = height,
                Padding = new Padding(10, 5, 10, 5),
            };
        }

        private RoundedButton CreateButton(string text, Color backColor)
        {
            return new RoundedButton
            {
                Text = text,
                ForeColor = Color.White,
                BackColor = backColor,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial Rounded MT Bold", 12F),
                CornerRadius = 15,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(10, 5, 10, 5),
                Size = new Size(120, 35),
                UseVisualStyleBackColor = false,
            };
        }


        #region Approve Profile
        private async Task ApproveLeaveRequest(int id)
        {
            try
            {



                if (id == null)
                {
                    RJMessageBox.Show("Leave Request ID Not FOund");
                    return;
                }



                // Call the Delete API
                var response = await leaveService.ApproveRequestAsync(id);

                // Check the response and provide feedback
                if (response != null && response.Succeeded)
                {


                    RJMessageBox.Show("Approved successfully!");

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

        #region Reject Profile
        private async Task RejectLeaveRequest(int id)
        {
            try
            {



                if (id == null)
                {
                    RJMessageBox.Show("Leave Request ID Not FOund");
                    return;
                }



                // Call the Delete API
                var response = await leaveService.RejectRequestAsync(id);

                // Check the response and provide feedback
                if (response != null && response.Succeeded)
                {


                    RJMessageBox.Show("Rejected successfully!");

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
