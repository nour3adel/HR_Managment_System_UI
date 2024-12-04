using System.Data;


namespace HR_ManagmentSystem_Client
{
    public partial class MyOrder : Form
    {
        #region Database Connection 

        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";


        DataSet ds;

        #endregion
        public MyOrder()
        {
            InitializeComponent();
        }

        #region FORM LOAD
        private void CategoryLists_Load(object sender, EventArgs e)
        {
            roundedButton2.Visible = false;
            roundedButton4.Visible = false;


        }
        #endregion


        #region Display Order
        void displayorder()
        {
            try
            {

            }
            catch (Exception)
            {
                RJMessageBox.Show("Invalid data displayorder");
            }
        }

        #endregion

        #region Display Items
        void displayitem()
        {
            try
            {

            }
            catch (Exception)
            {
                RJMessageBox.Show("Invalid data displayitem");
            }
        }

        #endregion

        #region Delete Order
        void deleteorder()
        {

        }

        #endregion

        #region Delete one Item
        void deleteoneitem(int i)
        {

        }

        #endregion



    }
}
