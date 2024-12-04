namespace HR_ManagmentSystem_Client
{
    public partial class UserLists : Form
    {





        public UserLists()
        {
            InitializeComponent();
        }

        #region FORM LOAD
        private void UserLists_Load(object sender, EventArgs e)
        {
            string q = "select * from USERR ";

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
