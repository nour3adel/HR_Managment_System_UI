namespace HR_ManagmentSystem_Client
{
    public partial class generate : Form
    {


        #region Database Connection



        #endregion
        public generate()
        {
            InitializeComponent();
        }

        #region FORM LOAD
        private void CategoryLists_Load(object sender, EventArgs e)
        {

            displayUsers();


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

        #region Display all Users
        void displayUsers()
        {
            try
            {





            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data");
            }
        }

        #endregion

        #region Generate Specific User Info
        private void rjButton1_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region Generate Complete Report
        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
