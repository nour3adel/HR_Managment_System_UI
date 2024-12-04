using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HR_ManagmentSystem_Client
{

    public partial class About : Form
    {
        #region Rounded Form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        #endregion

        public About()
        {
            InitializeComponent();
        }

        #region Home Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            // make winform rounded
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        #endregion

        #region Back Button
        private void hoverButton4_Click_1(object sender, EventArgs e)
        {
            Main form = new Main();
            form.Show();
            form.Owner = this;
            this.Hide();
        }

        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hoverButton3_Click(object sender, EventArgs e)
        {

        }

        private void hoverButton2_Click(object sender, EventArgs e)
        {

        }

        private void hoverButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
