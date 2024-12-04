namespace HR_ManagmentSystem_Client
{
    partial class Notifications
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
            dataGridView1 = new DataGridView();
            rjButton1 = new CustomControls.RJControls.RJButton();
            hoverButton4 = new HoverButton();
            hoverButton1 = new HoverButton();
            typeMenu = new CustomControls.RJControls.RJComboBox();
            roundedButton1 = new RoundedButton();
            hoverButton5 = new HoverButton();
            subject_txtbox = new CustomControls.RJControls.RJTextBox();
            empID_txtbox = new CustomControls.RJControls.RJTextBox();
            hoverButton6 = new HoverButton();
            content_txtbox = new CustomControls.RJControls.RJTextBox();
            hoverButton7 = new HoverButton();
            date = new DateTimePicker();
            isUrgent = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(22, 22, 22);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 22, 22);
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(727, 69);
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
            dataGridView1.Size = new Size(725, 724);
            dataGridView1.TabIndex = 100;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // hoverButton4
            // 
            hoverButton4.BackColor = Color.Transparent;
            hoverButton4.Cursor = Cursors.Hand;
            hoverButton4.FlatAppearance.BorderSize = 0;
            hoverButton4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            hoverButton4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            hoverButton4.FlatStyle = FlatStyle.Flat;
            hoverButton4.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hoverButton4.ForeColor = Color.White;
            hoverButton4.HoverColor = Color.LightCoral;
            hoverButton4.Location = new Point(25, 556);
            hoverButton4.Margin = new Padding(4, 3, 4, 3);
            hoverButton4.Name = "hoverButton4";
            hoverButton4.Size = new Size(204, 37);
            hoverButton4.TabIndex = 98;
            hoverButton4.Text = "Notification Type :";
            hoverButton4.UseVisualStyleBackColor = false;
            // 
            // hoverButton1
            // 
            hoverButton1.BackColor = Color.Transparent;
            hoverButton1.Cursor = Cursors.Hand;
            hoverButton1.FlatAppearance.BorderSize = 0;
            hoverButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            hoverButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            hoverButton1.FlatStyle = FlatStyle.Flat;
            hoverButton1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hoverButton1.ForeColor = Color.White;
            hoverButton1.HoverColor = Color.LightCoral;
            hoverButton1.Location = new Point(24, 491);
            hoverButton1.Margin = new Padding(4, 3, 4, 3);
            hoverButton1.Name = "hoverButton1";
            hoverButton1.Size = new Size(205, 35);
            hoverButton1.TabIndex = 96;
            hoverButton1.Text = "Notification Date :";
            hoverButton1.UseVisualStyleBackColor = false;
            // 
            // typeMenu
            // 
            typeMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            typeMenu.BackColor = Color.FromArgb(255, 128, 128);
            typeMenu.BorderColor = Color.Transparent;
            typeMenu.BorderSize = 1;
            typeMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            typeMenu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeMenu.ForeColor = Color.White;
            typeMenu.IconColor = Color.White;
            typeMenu.Items.AddRange(new object[] { "Payroll", "LeaveRequest", "Attendance", "PerformanceReview" });
            typeMenu.ListBackColor = Color.FromArgb(255, 192, 192);
            typeMenu.ListTextColor = Color.White;
            typeMenu.Location = new Point(266, 553);
            typeMenu.Margin = new Padding(4, 3, 4, 3);
            typeMenu.MinimumSize = new Size(239, 35);
            typeMenu.Name = "typeMenu";
            typeMenu.Padding = new Padding(1);
            typeMenu.Size = new Size(405, 40);
            typeMenu.TabIndex = 94;
            typeMenu.Texts = "Select";
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(255, 128, 128);
            roundedButton1.CornerRadius = 25;
            roundedButton1.Cursor = Cursors.Hand;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 158);
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(185, 719);
            roundedButton1.Margin = new Padding(4, 3, 4, 3);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(369, 62);
            roundedButton1.TabIndex = 27;
            roundedButton1.Text = "SEND";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // hoverButton5
            // 
            hoverButton5.BackColor = Color.Transparent;
            hoverButton5.Cursor = Cursors.Hand;
            hoverButton5.FlatAppearance.BorderSize = 0;
            hoverButton5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            hoverButton5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            hoverButton5.FlatStyle = FlatStyle.Flat;
            hoverButton5.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hoverButton5.ForeColor = Color.White;
            hoverButton5.HoverColor = Color.LightCoral;
            hoverButton5.Location = new Point(0, 165);
            hoverButton5.Margin = new Padding(4, 3, 4, 3);
            hoverButton5.Name = "hoverButton5";
            hoverButton5.Size = new Size(264, 62);
            hoverButton5.TabIndex = 121;
            hoverButton5.Text = "Notification Subject:";
            hoverButton5.UseVisualStyleBackColor = false;
            // 
            // subject_txtbox
            // 
            subject_txtbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            subject_txtbox.BackColor = Color.FromArgb(22, 22, 22);
            subject_txtbox.BorderColor = Color.FromArgb(255, 128, 128);
            subject_txtbox.BorderFocusColor = Color.DarkMagenta;
            subject_txtbox.BorderRadius = 12;
            subject_txtbox.BorderSize = 3;
            subject_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subject_txtbox.ForeColor = Color.White;
            subject_txtbox.Location = new Point(266, 174);
            subject_txtbox.Margin = new Padding(5);
            subject_txtbox.Multiline = false;
            subject_txtbox.Name = "subject_txtbox";
            subject_txtbox.Padding = new Padding(8);
            subject_txtbox.PasswordChar = false;
            subject_txtbox.PlaceholderColor = Color.DarkGray;
            subject_txtbox.PlaceholderText = "";
            subject_txtbox.Size = new Size(405, 42);
            subject_txtbox.TabIndex = 122;
            subject_txtbox.Texts = "";
            subject_txtbox.UnderlinedStyle = false;
            // 
            // empID_txtbox
            // 
            empID_txtbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            empID_txtbox.BackColor = Color.FromArgb(22, 22, 22);
            empID_txtbox.BorderColor = Color.FromArgb(255, 128, 128);
            empID_txtbox.BorderFocusColor = Color.DarkMagenta;
            empID_txtbox.BorderRadius = 12;
            empID_txtbox.BorderSize = 3;
            empID_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empID_txtbox.ForeColor = Color.White;
            empID_txtbox.Location = new Point(266, 270);
            empID_txtbox.Margin = new Padding(5);
            empID_txtbox.Multiline = false;
            empID_txtbox.Name = "empID_txtbox";
            empID_txtbox.Padding = new Padding(8);
            empID_txtbox.PasswordChar = false;
            empID_txtbox.PlaceholderColor = Color.DarkGray;
            empID_txtbox.PlaceholderText = "";
            empID_txtbox.Size = new Size(405, 42);
            empID_txtbox.TabIndex = 124;
            empID_txtbox.Texts = "";
            empID_txtbox.UnderlinedStyle = false;
            // 
            // hoverButton6
            // 
            hoverButton6.BackColor = Color.Transparent;
            hoverButton6.Cursor = Cursors.Hand;
            hoverButton6.FlatAppearance.BorderSize = 0;
            hoverButton6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            hoverButton6.FlatAppearance.MouseOverBackColor = Color.Transparent;
            hoverButton6.FlatStyle = FlatStyle.Flat;
            hoverButton6.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hoverButton6.ForeColor = Color.White;
            hoverButton6.HoverColor = Color.LightCoral;
            hoverButton6.Location = new Point(24, 270);
            hoverButton6.Margin = new Padding(4, 3, 4, 3);
            hoverButton6.Name = "hoverButton6";
            hoverButton6.Size = new Size(161, 42);
            hoverButton6.TabIndex = 123;
            hoverButton6.Text = "Employee ID :";
            hoverButton6.UseVisualStyleBackColor = false;
            // 
            // content_txtbox
            // 
            content_txtbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            content_txtbox.AutoSize = true;
            content_txtbox.BackColor = Color.FromArgb(22, 22, 22);
            content_txtbox.BorderColor = Color.FromArgb(255, 128, 128);
            content_txtbox.BorderFocusColor = Color.DarkMagenta;
            content_txtbox.BorderRadius = 12;
            content_txtbox.BorderSize = 3;
            content_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            content_txtbox.ForeColor = Color.White;
            content_txtbox.Location = new Point(266, 364);
            content_txtbox.Margin = new Padding(5);
            content_txtbox.MaximumSize = new Size(500, 500);
            content_txtbox.MinimumSize = new Size(0, 100);
            content_txtbox.Multiline = false;
            content_txtbox.Name = "content_txtbox";
            content_txtbox.Padding = new Padding(8);
            content_txtbox.PasswordChar = false;
            content_txtbox.PlaceholderColor = Color.DarkGray;
            content_txtbox.PlaceholderText = "";
            content_txtbox.Size = new Size(405, 100);
            content_txtbox.TabIndex = 126;
            content_txtbox.Texts = "";
            content_txtbox.UnderlinedStyle = false;
            // 
            // hoverButton7
            // 
            hoverButton7.BackColor = Color.Transparent;
            hoverButton7.Cursor = Cursors.Hand;
            hoverButton7.FlatAppearance.BorderSize = 0;
            hoverButton7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            hoverButton7.FlatAppearance.MouseOverBackColor = Color.Transparent;
            hoverButton7.FlatStyle = FlatStyle.Flat;
            hoverButton7.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hoverButton7.ForeColor = Color.White;
            hoverButton7.HoverColor = Color.LightCoral;
            hoverButton7.Location = new Point(14, 364);
            hoverButton7.Margin = new Padding(4, 3, 4, 3);
            hoverButton7.Name = "hoverButton7";
            hoverButton7.Size = new Size(243, 42);
            hoverButton7.TabIndex = 125;
            hoverButton7.Text = "Notification Content:";
            hoverButton7.UseVisualStyleBackColor = false;
            // 
            // date
            // 
            date.CustomFormat = "yyyy-MM-dd";
            date.Format = DateTimePickerFormat.Custom;
            date.Location = new Point(266, 491);
            date.MinDate = new DateTime(2024, 12, 4, 0, 0, 0, 0);
            date.Name = "date";
            date.ShowUpDown = true;
            date.Size = new Size(270, 23);
            date.TabIndex = 127;
            date.Value = new DateTime(2024, 12, 4, 0, 0, 0, 0);
            // 
            // isUrgent
            // 
            isUrgent.AutoSize = true;
            isUrgent.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isUrgent.Location = new Point(200, 678);
            isUrgent.Name = "isUrgent";
            isUrgent.Size = new Size(135, 26);
            isUrgent.TabIndex = 128;
            isUrgent.Text = "IS URGENT";
            isUrgent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(547, 75);
            label1.TabIndex = 129;
            label1.Text = "NOTIFICATIONS";
            // 
            // Notifications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(1475, 878);
            Controls.Add(label1);
            Controls.Add(isUrgent);
            Controls.Add(date);
            Controls.Add(content_txtbox);
            Controls.Add(hoverButton7);
            Controls.Add(empID_txtbox);
            Controls.Add(hoverButton6);
            Controls.Add(subject_txtbox);
            Controls.Add(hoverButton5);
            Controls.Add(dataGridView1);
            Controls.Add(rjButton1);
            Controls.Add(hoverButton4);
            Controls.Add(hoverButton1);
            Controls.Add(typeMenu);
            Controls.Add(roundedButton1);
            Controls.Add(exit);
            Controls.Add(BtnCerrar);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Notifications";
            Text = "FormMembresia";
            Load += CategoryLists_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button exit;
        private RoundedButton roundedButton1;
        private HoverButton hoverButton1;
        private HoverButton hoverButton4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJComboBox typeMenu;
        private HoverButton hoverButton5;
        private CustomControls.RJControls.RJTextBox subject_txtbox;
        private CustomControls.RJControls.RJTextBox empID_txtbox;
        private HoverButton hoverButton6;
        private CustomControls.RJControls.RJTextBox content_txtbox;
        private HoverButton hoverButton7;
        private DateTimePicker date;
        private CheckBox isUrgent;
        private Label label1;
    }
}