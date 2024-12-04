namespace HR_ManagmentSystem_Client
{
    partial class UserLeaveRequest
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            BtnCerrar = new Button();
            exit = new Button();
            LeaveRequestsGrid = new DataGridView();
            rjButton1 = new CustomControls.RJControls.RJButton();
            create_btn = new RoundedButton();
            Description_txtbox = new CustomControls.RJControls.RJTextBox();
            startDatePicker = new DateTimePicker();
            label1 = new Label();
            endDatePicker = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)LeaveRequestsGrid).BeginInit();
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
            exit.TabIndex = 25;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // LeaveRequestsGrid
            // 
            LeaveRequestsGrid.AllowUserToAddRows = false;
            LeaveRequestsGrid.AllowUserToDeleteRows = false;
            LeaveRequestsGrid.AllowUserToResizeColumns = false;
            LeaveRequestsGrid.AllowUserToResizeRows = false;
            LeaveRequestsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LeaveRequestsGrid.BackgroundColor = Color.FromArgb(22, 22, 22);
            LeaveRequestsGrid.BorderStyle = BorderStyle.None;
            LeaveRequestsGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            LeaveRequestsGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            LeaveRequestsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            LeaveRequestsGrid.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 22, 22);
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            LeaveRequestsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            LeaveRequestsGrid.EnableHeadersVisualStyles = false;
            LeaveRequestsGrid.GridColor = Color.LightGray;
            LeaveRequestsGrid.Location = new Point(727, 69);
            LeaveRequestsGrid.Margin = new Padding(4, 3, 4, 3);
            LeaveRequestsGrid.MultiSelect = false;
            LeaveRequestsGrid.Name = "LeaveRequestsGrid";
            LeaveRequestsGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSalmon;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            LeaveRequestsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            LeaveRequestsGrid.RowHeadersVisible = false;
            LeaveRequestsGrid.RowHeadersWidth = 25;
            LeaveRequestsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LeaveRequestsGrid.Size = new Size(725, 724);
            LeaveRequestsGrid.TabIndex = 100;
            LeaveRequestsGrid.CellContentClick += dataGridView1_CellContentClick;
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
            rjButton1.Location = new Point(716, 61);
            rjButton1.Margin = new Padding(4, 3, 4, 3);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(745, 742);
            rjButton1.TabIndex = 99;
            rjButton1.Text = "rjButton1";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // create_btn
            // 
            create_btn.BackColor = Color.FromArgb(255, 128, 128);
            create_btn.CornerRadius = 25;
            create_btn.Cursor = Cursors.Hand;
            create_btn.FlatAppearance.BorderSize = 0;
            create_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 158);
            create_btn.FlatStyle = FlatStyle.Flat;
            create_btn.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            create_btn.ForeColor = Color.White;
            create_btn.Location = new Point(140, 643);
            create_btn.Margin = new Padding(4, 3, 4, 3);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(369, 62);
            create_btn.TabIndex = 27;
            create_btn.Text = "CREATE";
            create_btn.UseVisualStyleBackColor = false;
            create_btn.Click += roundedButton1_Click;
            // 
            // Description_txtbox
            // 
            Description_txtbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Description_txtbox.AutoSize = true;
            Description_txtbox.BackColor = Color.FromArgb(22, 22, 22);
            Description_txtbox.BorderColor = Color.FromArgb(255, 128, 128);
            Description_txtbox.BorderFocusColor = Color.DarkMagenta;
            Description_txtbox.BorderRadius = 12;
            Description_txtbox.BorderSize = 3;
            Description_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Description_txtbox.ForeColor = Color.White;
            Description_txtbox.Location = new Point(209, 344);
            Description_txtbox.Margin = new Padding(5);
            Description_txtbox.MaximumSize = new Size(500, 500);
            Description_txtbox.MinimumSize = new Size(0, 200);
            Description_txtbox.Multiline = false;
            Description_txtbox.Name = "Description_txtbox";
            Description_txtbox.Padding = new Padding(8);
            Description_txtbox.PasswordChar = false;
            Description_txtbox.PlaceholderColor = Color.DarkGray;
            Description_txtbox.PlaceholderText = "";
            Description_txtbox.Size = new Size(405, 200);
            Description_txtbox.TabIndex = 126;
            Description_txtbox.Texts = "";
            Description_txtbox.UnderlinedStyle = false;
            Description_txtbox._TextChanged += Description_txtbox__TextChanged;
            // 
            // startDatePicker
            // 
            startDatePicker.CustomFormat = "yyyy-MM-dd";
            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.Location = new Point(222, 197);
            startDatePicker.MinDate = new DateTime(2024, 12, 4, 0, 0, 0, 0);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.ShowUpDown = true;
            startDatePicker.Size = new Size(314, 23);
            startDatePicker.TabIndex = 127;
            startDatePicker.Value = new DateTime(2024, 12, 4, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(530, 75);
            label1.TabIndex = 129;
            label1.Text = "Leave Requests";
            // 
            // endDatePicker
            // 
            endDatePicker.CalendarForeColor = Color.White;
            endDatePicker.CalendarMonthBackground = Color.FromArgb(22, 22, 22);
            endDatePicker.CustomFormat = "yyyy-MM-dd";
            endDatePicker.Format = DateTimePickerFormat.Custom;
            endDatePicker.Location = new Point(222, 267);
            endDatePicker.MinDate = new DateTime(2024, 12, 4, 0, 0, 0, 0);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.ShowUpDown = true;
            endDatePicker.Size = new Size(314, 23);
            endDatePicker.TabIndex = 131;
            endDatePicker.Value = new DateTime(2024, 12, 4, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 16.25F);
            label2.Location = new Point(38, 355);
            label2.Name = "label2";
            label2.Size = new Size(149, 26);
            label2.TabIndex = 132;
            label2.Text = "Description :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 16.25F);
            label3.Location = new Point(38, 267);
            label3.Name = "label3";
            label3.Size = new Size(123, 26);
            label3.TabIndex = 133;
            label3.Text = "End Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 16.25F);
            label4.Location = new Point(38, 197);
            label4.Name = "label4";
            label4.Size = new Size(135, 26);
            label4.TabIndex = 134;
            label4.Text = "Start Date :";
            // 
            // UserLeaveRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(1475, 878);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(endDatePicker);
            Controls.Add(label1);
            Controls.Add(startDatePicker);
            Controls.Add(Description_txtbox);
            Controls.Add(LeaveRequestsGrid);
            Controls.Add(rjButton1);
            Controls.Add(create_btn);
            Controls.Add(exit);
            Controls.Add(BtnCerrar);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserLeaveRequest";
            Text = "FormMembresia";
            Load += CategoryLists_Load;
            ((System.ComponentModel.ISupportInitialize)LeaveRequestsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button exit;
        private RoundedButton create_btn;
        private System.Windows.Forms.DataGridView LeaveRequestsGrid;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJTextBox Description_txtbox;
        private DateTimePicker startDatePicker;
        private Label label1;
        private DateTimePicker endDatePicker;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}