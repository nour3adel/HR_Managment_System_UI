namespace HR_ManagmentSystem_Client
{
    public partial class Print : Form
    {


        #region Database Connection
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";

        #endregion
        int r;
        public Print(int x)
        {
            r = x;
            InitializeComponent();
        }

        #region Form Load
        private void Print_Load(object sender, EventArgs e)
        {
            string str = Login.Instance.username;

            int orderid = r;


        }

        #endregion

        #region Get User ID


        #endregion

    }
}
