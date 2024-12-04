namespace HR_ManagmentSystem_Client
{
    partial class Magazines
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            BtnCerrar = new Button();
            exit = new Button();
            dataGridView1 = new DataGridView();
            rjButton5 = new CustomControls.RJControls.RJButton();
            rjButton3 = new CustomControls.RJControls.RJButton();
            rjButton4 = new CustomControls.RJControls.RJButton();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            rjTextBox3 = new CustomControls.RJControls.RJTextBox();
            rjButton2 = new CustomControls.RJControls.RJButton();
            rjButton1 = new CustomControls.RJControls.RJButton();
            rjDropdownMenu1 = new CustomControls.RJControls.RJDropdownMenu(components);
            Art = new ToolStripMenuItem();
            Beauty = new ToolStripMenuItem();
            Horror = new ToolStripMenuItem();
            ENtertainment = new ToolStripMenuItem();
            Soccer = new ToolStripMenuItem();
            danceToolStripMenuItem = new ToolStripMenuItem();
            actionToolStripMenuItem = new ToolStripMenuItem();
            comedyToolStripMenuItem = new ToolStripMenuItem();
            romanceToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            rjDropdownMenu1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCerrar
            // 
            BtnCerrar.Cursor = Cursors.Hand;
            BtnCerrar.FlatAppearance.BorderSize = 0;
            BtnCerrar.FlatStyle = FlatStyle.Flat;
            BtnCerrar.Location = new Point(0, 0);
            BtnCerrar.Margin = new Padding(4, 3, 4, 3);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(50, 50);
            BtnCerrar.TabIndex = 22;
            BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Location = new Point(1428, 2);
            exit.Margin = new Padding(4, 3, 4, 3);
            exit.Name = "exit";
            exit.Size = new Size(46, 45);
            exit.TabIndex = 23;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(100, 150, 200);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(48, 301);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSalmon;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1381, 563);
            dataGridView1.TabIndex = 26;
            // 
            // rjButton5
            // 
            rjButton5.BackColor = Color.MediumSlateBlue;
            rjButton5.BackgroundColor = Color.MediumSlateBlue;
            rjButton5.BorderColor = Color.PaleVioletRed;
            rjButton5.BorderRadius = 15;
            rjButton5.BorderSize = 0;
            rjButton5.FlatAppearance.BorderSize = 0;
            rjButton5.FlatStyle = FlatStyle.Flat;
            rjButton5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton5.ForeColor = Color.White;
            rjButton5.Location = new Point(1194, 180);
            rjButton5.Margin = new Padding(4, 3, 4, 3);
            rjButton5.Name = "rjButton5";
            rjButton5.Size = new Size(327, 59);
            rjButton5.TabIndex = 125;
            rjButton5.Text = "Show All";
            rjButton5.TextColor = Color.White;
            rjButton5.UseVisualStyleBackColor = false;
            rjButton5.Click += rjButton5_Click;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.MediumSlateBlue;
            rjButton3.BackgroundColor = Color.MediumSlateBlue;
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 15;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton3.ForeColor = Color.White;
            rjButton3.Location = new Point(-38, 193);
            rjButton3.Margin = new Padding(4, 3, 4, 3);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(304, 46);
            rjButton3.TabIndex = 123;
            rjButton3.Text = "Search By Category";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click;
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.MediumSlateBlue;
            rjButton4.BackgroundColor = Color.MediumSlateBlue;
            rjButton4.BorderColor = Color.PaleVioletRed;
            rjButton4.BorderRadius = 15;
            rjButton4.BorderSize = 0;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton4.ForeColor = Color.White;
            rjButton4.Location = new Point(683, 203);
            rjButton4.Margin = new Padding(4, 3, 4, 3);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(304, 46);
            rjButton4.TabIndex = 124;
            rjButton4.Text = "CLOCK OUT";
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            rjButton4.Click += rjButton4_Click;
            // 
            // rjTextBox1
            // 
            rjTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rjTextBox1.BackColor = Color.White;
            rjTextBox1.BorderColor = Color.FromArgb(113, 96, 232);
            rjTextBox1.BorderFocusColor = Color.DarkMagenta;
            rjTextBox1.BorderRadius = 12;
            rjTextBox1.BorderSize = 3;
            rjTextBox1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox1.ForeColor = Color.Gray;
            rjTextBox1.Location = new Point(308, 30);
            rjTextBox1.Margin = new Padding(5, 5, 5, 5);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(8, 8, 8, 8);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(443, 42);
            rjTextBox1.TabIndex = 119;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox3
            // 
            rjTextBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rjTextBox3.BackColor = Color.White;
            rjTextBox3.BorderColor = Color.FromArgb(113, 96, 232);
            rjTextBox3.BorderFocusColor = Color.DarkMagenta;
            rjTextBox3.BorderRadius = 12;
            rjTextBox3.BorderSize = 3;
            rjTextBox3.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox3.ForeColor = Color.Gray;
            rjTextBox3.Location = new Point(308, 115);
            rjTextBox3.Margin = new Padding(5, 5, 5, 5);
            rjTextBox3.Multiline = false;
            rjTextBox3.Name = "rjTextBox3";
            rjTextBox3.Padding = new Padding(8, 8, 8, 8);
            rjTextBox3.PasswordChar = false;
            rjTextBox3.PlaceholderColor = Color.DarkGray;
            rjTextBox3.PlaceholderText = "";
            rjTextBox3.Size = new Size(443, 42);
            rjTextBox3.TabIndex = 117;
            rjTextBox3.Texts = "";
            rjTextBox3.UnderlinedStyle = false;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.MediumSlateBlue;
            rjButton2.BackgroundColor = Color.MediumSlateBlue;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 15;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(318, 203);
            rjButton2.Margin = new Padding(4, 3, 4, 3);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(304, 46);
            rjButton2.TabIndex = 116;
            rjButton2.Text = "CLOCK IN";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(113, 96, 232);
            rjButton1.BackgroundColor = Color.FromArgb(113, 96, 232);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 20;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(34, 285);
            rjButton1.Margin = new Padding(4, 3, 4, 3);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(1409, 599);
            rjButton1.TabIndex = 25;
            rjButton1.Text = "rjButton1";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjDropdownMenu1
            // 
            rjDropdownMenu1.IsMainMenu = false;
            rjDropdownMenu1.Items.AddRange(new ToolStripItem[] { Art, Beauty, Horror, ENtertainment, Soccer, danceToolStripMenuItem, actionToolStripMenuItem, comedyToolStripMenuItem, romanceToolStripMenuItem });
            rjDropdownMenu1.MenuItemHeight = 25;
            rjDropdownMenu1.MenuItemTextColor = Color.Empty;
            rjDropdownMenu1.Name = "rjDropdownMenu1";
            rjDropdownMenu1.PrimaryColor = Color.Empty;
            rjDropdownMenu1.Size = new Size(150, 202);
            rjDropdownMenu1.ItemClicked += rjDropdownMenu1_ItemClicked;
            // 
            // Art
            // 
            Art.Name = "Art";
            Art.Size = new Size(149, 22);
            Art.Text = "Art";
            // 
            // Beauty
            // 
            Beauty.Name = "Beauty";
            Beauty.Size = new Size(149, 22);
            Beauty.Text = "Beauty";
            // 
            // Horror
            // 
            Horror.Name = "Horror";
            Horror.Size = new Size(149, 22);
            Horror.Text = "Entertainment";
            // 
            // ENtertainment
            // 
            ENtertainment.Name = "ENtertainment";
            ENtertainment.Size = new Size(149, 22);
            ENtertainment.Text = "Soccer";
            // 
            // Soccer
            // 
            Soccer.Name = "Soccer";
            Soccer.Size = new Size(149, 22);
            Soccer.Text = "Culture";
            // 
            // danceToolStripMenuItem
            // 
            danceToolStripMenuItem.Name = "danceToolStripMenuItem";
            danceToolStripMenuItem.Size = new Size(149, 22);
            danceToolStripMenuItem.Text = "Dance";
            // 
            // actionToolStripMenuItem
            // 
            actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            actionToolStripMenuItem.Size = new Size(149, 22);
            actionToolStripMenuItem.Text = "Action";
            // 
            // comedyToolStripMenuItem
            // 
            comedyToolStripMenuItem.Name = "comedyToolStripMenuItem";
            comedyToolStripMenuItem.Size = new Size(149, 22);
            comedyToolStripMenuItem.Text = "Comedy";
            // 
            // romanceToolStripMenuItem
            // 
            romanceToolStripMenuItem.Name = "romanceToolStripMenuItem";
            romanceToolStripMenuItem.Size = new Size(149, 22);
            romanceToolStripMenuItem.Text = "Romance";
            // 
            // Magazines
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1475, 878);
            Controls.Add(rjButton5);
            Controls.Add(rjButton3);
            Controls.Add(rjButton4);
            Controls.Add(rjTextBox1);
            Controls.Add(rjTextBox3);
            Controls.Add(rjButton2);
            Controls.Add(dataGridView1);
            Controls.Add(rjButton1);
            Controls.Add(exit);
            Controls.Add(BtnCerrar);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Magazines";
            Text = "FormMembresia";
            Load += Settings_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            rjDropdownMenu1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button exit;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJTextBox rjTextBox3;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private CustomControls.RJControls.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem Art;
        private System.Windows.Forms.ToolStripMenuItem Beauty;
        private System.Windows.Forms.ToolStripMenuItem Horror;
        private System.Windows.Forms.ToolStripMenuItem ENtertainment;
        private System.Windows.Forms.ToolStripMenuItem Soccer;
        private System.Windows.Forms.ToolStripMenuItem danceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comedyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romanceToolStripMenuItem;
        private CustomControls.RJControls.RJButton rjButton5;
    }
}