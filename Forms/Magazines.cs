using CustomControls.RJControls;

namespace HR_ManagmentSystem_Client
{
    public partial class Magazines : Form
    {
        #region Database Connection
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";


        #endregion
        public Magazines()
        {
            InitializeComponent();
        }

        #region FORM LOAD
        private void Settings_Load(object sender, EventArgs e)
        {
            rjButton5.Visible = false;
            rjDropdownMenu1.IsMainMenu = true;



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

        #region Search By Name
        private void rjButton2_Click(object sender, EventArgs e)
        {
            rjButton5.Visible = true;

            string x = rjTextBox1.Texts.Trim();

            string q = "select * from MAGAZINE where NAMEE = '" + x + "'";

        }

        #endregion

        #region Search By Author
        private void rjButton4_Click(object sender, EventArgs e)
        {
            rjButton5.Visible = true;

            string x = rjTextBox3.Texts.Trim();

            string q = "select * from MAGAZINE where AUTHOR = '" + x + "'";

        }

        #endregion

        #region Search by Category

        private void DropdownMenu_VisibleChanged(object sender, EventArgs e, Control ctrl)
        {
            rjButton5.Visible = true;

            RJDropdownMenu dropdownMenu = (RJDropdownMenu)sender;
            if (!DesignMode)
            {
                if (dropdownMenu.Visible)
                    ctrl.BackColor = Color.FromArgb(29, 34, 39);
                else ctrl.BackColor = Color.FromArgb(29, 34, 39);

            }
        }
        private void Open_DropdownMenu2(RJDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev)
              => DropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width, 0);
        }


        private void rjButton3_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu2(rjDropdownMenu1, sender);
        }


        private void rjDropdownMenu1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            string x = e.ClickedItem.Text; // retrieve the clicked item's text
            string q = "select * from MAGAZINE where CATEGORY = '" + x + "'";

        }



        #endregion

        #region Show All Button
        private void rjButton5_Click(object sender, EventArgs e)
        {
            string q = "select * from MAGAZINE ";

        }

        #endregion

    }
}
