using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HR_ManagmentSystem_Client
{

    public partial class Team : Form
    {
        #region Rounded Form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        #endregion

        public Team()
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

        #region back Button
        private void hoverButton4_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            form.Show();
            form.Owner = this;
            this.Hide();
        }

        #endregion

        private void hoverButton9_Click(object sender, EventArgs e)
        {

        }
    }
}
