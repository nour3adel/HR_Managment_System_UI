namespace HR_ManagmentSystem_Client
{
    partial class Attendance
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
            attendanceGrid = new DataGridView();
            clockOut_btn = new CustomControls.RJControls.RJButton();
            clockIn_btn = new CustomControls.RJControls.RJButton();
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
            ((System.ComponentModel.ISupportInitialize)attendanceGrid).BeginInit();
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
            exit.ForeColor = Color.White;
            exit.Location = new Point(1428, 2);
            exit.Margin = new Padding(4, 3, 4, 3);
            exit.Name = "exit";
            exit.Size = new Size(46, 45);
            exit.TabIndex = 23;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // attendanceGrid
            // 
            attendanceGrid.AllowUserToAddRows = false;
            attendanceGrid.AllowUserToDeleteRows = false;
            attendanceGrid.AllowUserToResizeColumns = false;
            attendanceGrid.AllowUserToResizeRows = false;
            attendanceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            attendanceGrid.BackgroundColor = Color.FromArgb(22, 22, 22);
            attendanceGrid.BorderStyle = BorderStyle.None;
            attendanceGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            attendanceGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            attendanceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            attendanceGrid.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 22, 22);
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            attendanceGrid.DefaultCellStyle = dataGridViewCellStyle2;
            attendanceGrid.EnableHeadersVisualStyles = false;
            attendanceGrid.GridColor = Color.LightGray;
            attendanceGrid.Location = new Point(48, 227);
            attendanceGrid.Margin = new Padding(4, 3, 4, 3);
            attendanceGrid.MultiSelect = false;
            attendanceGrid.Name = "attendanceGrid";
            attendanceGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSalmon;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            attendanceGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            attendanceGrid.RowHeadersVisible = false;
            attendanceGrid.RowHeadersWidth = 25;
            attendanceGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            attendanceGrid.Size = new Size(1381, 637);
            attendanceGrid.TabIndex = 26;
            attendanceGrid.CellContentClick += attendanceGrid_CellContentClick;
            // 
            // clockOut_btn
            // 
            clockOut_btn.BackColor = Color.FromArgb(255, 128, 128);
            clockOut_btn.BackgroundColor = Color.FromArgb(255, 128, 128);
            clockOut_btn.BorderColor = Color.PaleVioletRed;
            clockOut_btn.BorderRadius = 15;
            clockOut_btn.BorderSize = 0;
            clockOut_btn.FlatAppearance.BorderSize = 0;
            clockOut_btn.FlatStyle = FlatStyle.Flat;
            clockOut_btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clockOut_btn.ForeColor = Color.White;
            clockOut_btn.Location = new Point(823, 69);
            clockOut_btn.Margin = new Padding(4, 3, 4, 3);
            clockOut_btn.Name = "clockOut_btn";
            clockOut_btn.Size = new Size(454, 80);
            clockOut_btn.TabIndex = 124;
            clockOut_btn.Text = "CLOCK OUT";
            clockOut_btn.TextColor = Color.White;
            clockOut_btn.UseVisualStyleBackColor = false;
            clockOut_btn.Click += rjButton4_Click;
            // 
            // clockIn_btn
            // 
            clockIn_btn.BackColor = Color.FromArgb(255, 128, 128);
            clockIn_btn.BackgroundColor = Color.FromArgb(255, 128, 128);
            clockIn_btn.BorderColor = Color.PaleVioletRed;
            clockIn_btn.BorderRadius = 15;
            clockIn_btn.BorderSize = 0;
            clockIn_btn.FlatAppearance.BorderSize = 0;
            clockIn_btn.FlatStyle = FlatStyle.Flat;
            clockIn_btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clockIn_btn.ForeColor = Color.White;
            clockIn_btn.Location = new Point(193, 69);
            clockIn_btn.Margin = new Padding(4, 3, 4, 3);
            clockIn_btn.Name = "clockIn_btn";
            clockIn_btn.Size = new Size(454, 77);
            clockIn_btn.TabIndex = 116;
            clockIn_btn.Text = "CLOCK IN";
            clockIn_btn.TextColor = Color.White;
            clockIn_btn.UseVisualStyleBackColor = false;
            clockIn_btn.Click += rjButton2_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(255, 128, 128);
            rjButton1.BackgroundColor = Color.FromArgb(255, 128, 128);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 20;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(34, 211);
            rjButton1.Margin = new Padding(4, 3, 4, 3);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(1409, 673);
            rjButton1.TabIndex = 25;
            rjButton1.Text = "rjButton1";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
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
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(1475, 878);
            Controls.Add(clockOut_btn);
            Controls.Add(clockIn_btn);
            Controls.Add(attendanceGrid);
            Controls.Add(rjButton1);
            Controls.Add(exit);
            Controls.Add(BtnCerrar);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Attendance";
            Text = "FormMembresia";
            Load += Settings_Load;
            ((System.ComponentModel.ISupportInitialize)attendanceGrid).EndInit();
            rjDropdownMenu1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button exit;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton clockIn_btn;
        private CustomControls.RJControls.RJButton clockOut_btn;
        public System.Windows.Forms.DataGridView attendanceGrid;
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
    }
}