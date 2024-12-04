namespace HR_ManagmentSystem_Client
{
    public partial class MagazineList : Form
    {
        #region Database Connection
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";


        #endregion
        public MagazineList()
        {
            InitializeComponent();
        }

        #region FORM LOAD
        private void MagazineList_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Save Changes Buttin
        private void rjButton1_Click(object sender, EventArgs e)
        {

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

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
