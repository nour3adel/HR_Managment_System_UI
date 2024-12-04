namespace HR_ManagmentSystem_Client
{
    partial class MyProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProfile));
            label3 = new Label();
            label1 = new Label();
            pictureBox9 = new PictureBox();
            label10 = new Label();
            exit = new Button();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            label11 = new Label();
            label12 = new Label();
            edit_btn = new CustomControls.RJControls.RJButton();
            roles_list = new CustomControls.RJControls.RJComboBox();
            fullname_txtbox = new CustomControls.RJControls.RJTextBox();
            address_txtbox = new CustomControls.RJControls.RJTextBox();
            phone_txtbox = new CustomControls.RJControls.RJTextBox();
            username_txtbox = new CustomControls.RJControls.RJTextBox();
            email_txtbox = new CustomControls.RJControls.RJTextBox();
            delete_btn = new CustomControls.RJControls.RJButton();
            label4 = new Label();
            salary_txtbox = new CustomControls.RJControls.RJTextBox();
            SALARY = new Label();
            position_txtbox = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(32, 22, 16);
            label3.Location = new Point(319, 41);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(623, 33);
            label3.TabIndex = 106;
            label3.Text = "______________________________________";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(264, 75);
            label1.TabIndex = 105;
            label1.Text = "ABOUT";
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Location = new Point(914, 77);
            pictureBox9.Margin = new Padding(4, 3, 4, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(547, 518);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 104;
            pictureBox9.TabStop = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Radley Sans", 27.75F);
            label10.Location = new Point(72, 698);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(103, 34);
            label10.TabIndex = 101;
            label10.Text = "Roles";
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Location = new Point(1420, 3);
            exit.Margin = new Padding(4, 3, 4, 3);
            exit.Name = "exit";
            exit.Size = new Size(46, 45);
            exit.TabIndex = 83;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Radley Sans", 27.75F);
            label6.Location = new Point(73, 357);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 34);
            label6.TabIndex = 96;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Radley Sans", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(71, 133);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(162, 34);
            label7.TabIndex = 95;
            label7.Text = "USERNAME";
            label7.Click += label7_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Radley Sans", 27.75F);
            label2.Location = new Point(71, 281);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(230, 34);
            label2.TabIndex = 94;
            label2.Text = "Phone Number";
            label2.Click += label2_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Radley Sans", 27.75F);
            label11.Location = new Point(71, 205);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(156, 34);
            label11.TabIndex = 93;
            label11.Text = "Fullname";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Radley Sans", 27.75F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(71, 437);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(140, 34);
            label12.TabIndex = 92;
            label12.Text = "Address";
            // 
            // edit_btn
            // 
            edit_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            edit_btn.BackColor = Color.FromArgb(255, 128, 128);
            edit_btn.BackgroundColor = Color.FromArgb(255, 128, 128);
            edit_btn.BorderColor = Color.PaleVioletRed;
            edit_btn.BorderRadius = 15;
            edit_btn.BorderSize = 0;
            edit_btn.Cursor = Cursors.Hand;
            edit_btn.FlatAppearance.BorderSize = 0;
            edit_btn.FlatStyle = FlatStyle.Flat;
            edit_btn.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edit_btn.ForeColor = Color.White;
            edit_btn.Location = new Point(1006, 648);
            edit_btn.Margin = new Padding(4, 3, 4, 3);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(391, 68);
            edit_btn.TabIndex = 103;
            edit_btn.Text = "Edit Data";
            edit_btn.TextColor = Color.White;
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += rjButton3_Click;
            // 
            // roles_list
            // 
            roles_list.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roles_list.BackColor = Color.FromArgb(255, 128, 128);
            roles_list.BorderColor = Color.Transparent;
            roles_list.BorderSize = 1;
            roles_list.DropDownStyle = ComboBoxStyle.DropDownList;
            roles_list.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roles_list.ForeColor = Color.White;
            roles_list.IconColor = Color.White;
            roles_list.Items.AddRange(new object[] { "Male", "Female" });
            roles_list.ListBackColor = Color.FromArgb(255, 192, 192);
            roles_list.ListTextColor = Color.White;
            roles_list.Location = new Point(346, 692);
            roles_list.Margin = new Padding(4, 3, 4, 3);
            roles_list.MinimumSize = new Size(239, 35);
            roles_list.Name = "roles_list";
            roles_list.Padding = new Padding(1);
            roles_list.Size = new Size(239, 40);
            roles_list.TabIndex = 91;
            roles_list.Texts = "Select";
            roles_list.OnSelectedIndexChanged += roles_list_OnSelectedIndexChanged;
            // 
            // fullname_txtbox
            // 
            fullname_txtbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            fullname_txtbox.BackColor = Color.FromArgb(22, 22, 22);
            fullname_txtbox.BorderColor = Color.FromArgb(255, 128, 128);
            fullname_txtbox.BorderFocusColor = Color.DarkMagenta;
            fullname_txtbox.BorderRadius = 12;
            fullname_txtbox.BorderSize = 2;
            fullname_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullname_txtbox.ForeColor = Color.White;
            fullname_txtbox.Location = new Point(346, 205);
            fullname_txtbox.Margin = new Padding(5);
            fullname_txtbox.Multiline = false;
            fullname_txtbox.Name = "fullname_txtbox";
            fullname_txtbox.Padding = new Padding(8);
            fullname_txtbox.PasswordChar = false;
            fullname_txtbox.PlaceholderColor = Color.DarkGray;
            fullname_txtbox.PlaceholderText = "";
            fullname_txtbox.Size = new Size(386, 42);
            fullname_txtbox.TabIndex = 90;
            fullname_txtbox.Texts = "";
            fullname_txtbox.UnderlinedStyle = false;
            // 
            // address_txtbox
            // 
            address_txtbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            address_txtbox.BackColor = Color.FromArgb(22, 22, 22);
            address_txtbox.BorderColor = Color.FromArgb(255, 128, 128);
            address_txtbox.BorderFocusColor = Color.DarkMagenta;
            address_txtbox.BorderRadius = 12;
            address_txtbox.BorderSize = 2;
            address_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address_txtbox.ForeColor = Color.White;
            address_txtbox.Location = new Point(346, 437);
            address_txtbox.Margin = new Padding(5);
            address_txtbox.Multiline = false;
            address_txtbox.Name = "address_txtbox";
            address_txtbox.Padding = new Padding(8);
            address_txtbox.PasswordChar = false;
            address_txtbox.PlaceholderColor = Color.DarkGray;
            address_txtbox.PlaceholderText = "";
            address_txtbox.Size = new Size(386, 42);
            address_txtbox.TabIndex = 89;
            address_txtbox.Texts = "";
            address_txtbox.UnderlinedStyle = false;
            // 
            // phone_txtbox
            // 
            phone_txtbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            phone_txtbox.BackColor = Color.FromArgb(22, 22, 22);
            phone_txtbox.BorderColor = Color.FromArgb(255, 128, 128);
            phone_txtbox.BorderFocusColor = Color.DarkMagenta;
            phone_txtbox.BorderRadius = 12;
            phone_txtbox.BorderSize = 2;
            phone_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phone_txtbox.ForeColor = Color.White;
            phone_txtbox.Location = new Point(346, 273);
            phone_txtbox.Margin = new Padding(5);
            phone_txtbox.Multiline = false;
            phone_txtbox.Name = "phone_txtbox";
            phone_txtbox.Padding = new Padding(8);
            phone_txtbox.PasswordChar = false;
            phone_txtbox.PlaceholderColor = Color.DarkGray;
            phone_txtbox.PlaceholderText = "";
            phone_txtbox.Size = new Size(386, 42);
            phone_txtbox.TabIndex = 86;
            phone_txtbox.Texts = "";
            phone_txtbox.UnderlinedStyle = false;
            phone_txtbox._TextChanged += phone_txtbox__TextChanged;
            // 
            // username_txtbox
            // 
            username_txtbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            username_txtbox.BackColor = Color.FromArgb(22, 22, 22);
            username_txtbox.BorderColor = Color.FromArgb(255, 128, 128);
            username_txtbox.BorderFocusColor = Color.DarkMagenta;
            username_txtbox.BorderRadius = 12;
            username_txtbox.BorderSize = 2;
            username_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_txtbox.ForeColor = Color.White;
            username_txtbox.Location = new Point(346, 133);
            username_txtbox.Margin = new Padding(5);
            username_txtbox.Multiline = false;
            username_txtbox.Name = "username_txtbox";
            username_txtbox.Padding = new Padding(8);
            username_txtbox.PasswordChar = false;
            username_txtbox.PlaceholderColor = Color.DarkGray;
            username_txtbox.PlaceholderText = "";
            username_txtbox.Size = new Size(386, 42);
            username_txtbox.TabIndex = 107;
            username_txtbox.Texts = "";
            username_txtbox.UnderlinedStyle = false;
            username_txtbox._TextChanged += username_txtbox__TextChanged;
            // 
            // email_txtbox
            // 
            email_txtbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            email_txtbox.BackColor = Color.FromArgb(22, 22, 22);
            email_txtbox.BorderColor = Color.FromArgb(255, 128, 128);
            email_txtbox.BorderFocusColor = Color.DarkMagenta;
            email_txtbox.BorderRadius = 12;
            email_txtbox.BorderSize = 2;
            email_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email_txtbox.ForeColor = Color.White;
            email_txtbox.Location = new Point(346, 349);
            email_txtbox.Margin = new Padding(5);
            email_txtbox.Multiline = false;
            email_txtbox.Name = "email_txtbox";
            email_txtbox.Padding = new Padding(8);
            email_txtbox.PasswordChar = false;
            email_txtbox.PlaceholderColor = Color.DarkGray;
            email_txtbox.PlaceholderText = "";
            email_txtbox.Size = new Size(386, 42);
            email_txtbox.TabIndex = 108;
            email_txtbox.Texts = "";
            email_txtbox.UnderlinedStyle = false;
            // 
            // delete_btn
            // 
            delete_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            delete_btn.BackColor = Color.Red;
            delete_btn.BackgroundColor = Color.Red;
            delete_btn.BorderColor = Color.PaleVioletRed;
            delete_btn.BorderRadius = 15;
            delete_btn.BorderSize = 0;
            delete_btn.Cursor = Cursors.Hand;
            delete_btn.FlatAppearance.BorderSize = 0;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(1006, 753);
            delete_btn.Margin = new Padding(4, 3, 4, 3);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(391, 68);
            delete_btn.TabIndex = 109;
            delete_btn.Text = "Delete Account";
            delete_btn.TextColor = Color.White;
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Radley Sans", 27.75F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(72, 527);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(139, 34);
            label4.TabIndex = 111;
            label4.Text = "Position";
            // 
            // salary_txtbox
            // 
            salary_txtbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            salary_txtbox.BackColor = Color.FromArgb(22, 22, 22);
            salary_txtbox.BorderColor = Color.FromArgb(255, 128, 128);
            salary_txtbox.BorderFocusColor = Color.DarkMagenta;
            salary_txtbox.BorderRadius = 12;
            salary_txtbox.BorderSize = 2;
            salary_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salary_txtbox.ForeColor = Color.White;
            salary_txtbox.Location = new Point(346, 606);
            salary_txtbox.Margin = new Padding(5);
            salary_txtbox.Multiline = false;
            salary_txtbox.Name = "salary_txtbox";
            salary_txtbox.Padding = new Padding(8);
            salary_txtbox.PasswordChar = false;
            salary_txtbox.PlaceholderColor = Color.DarkGray;
            salary_txtbox.PlaceholderText = "";
            salary_txtbox.Size = new Size(386, 42);
            salary_txtbox.TabIndex = 112;
            salary_txtbox.Texts = "";
            salary_txtbox.UnderlinedStyle = false;
            // 
            // SALARY
            // 
            SALARY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SALARY.AutoSize = true;
            SALARY.Font = new Font("Radley Sans", 27.75F);
            SALARY.ForeColor = Color.White;
            SALARY.Location = new Point(73, 606);
            SALARY.Margin = new Padding(4, 0, 4, 0);
            SALARY.Name = "SALARY";
            SALARY.Size = new Size(119, 34);
            SALARY.TabIndex = 113;
            SALARY.Text = "SALARY";
            // 
            // position_txtbox
            // 
            position_txtbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            position_txtbox.BackColor = Color.FromArgb(22, 22, 22);
            position_txtbox.BorderColor = Color.FromArgb(255, 128, 128);
            position_txtbox.BorderFocusColor = Color.DarkMagenta;
            position_txtbox.BorderRadius = 12;
            position_txtbox.BorderSize = 2;
            position_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            position_txtbox.ForeColor = Color.White;
            position_txtbox.Location = new Point(346, 519);
            position_txtbox.Margin = new Padding(5);
            position_txtbox.Multiline = false;
            position_txtbox.Name = "position_txtbox";
            position_txtbox.Padding = new Padding(8);
            position_txtbox.PasswordChar = false;
            position_txtbox.PlaceholderColor = Color.DarkGray;
            position_txtbox.PlaceholderText = "";
            position_txtbox.Size = new Size(386, 42);
            position_txtbox.TabIndex = 114;
            position_txtbox.Texts = "";
            position_txtbox.UnderlinedStyle = false;
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(1475, 878);
            Controls.Add(position_txtbox);
            Controls.Add(SALARY);
            Controls.Add(salary_txtbox);
            Controls.Add(label4);
            Controls.Add(delete_btn);
            Controls.Add(email_txtbox);
            Controls.Add(username_txtbox);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox9);
            Controls.Add(edit_btn);
            Controls.Add(label10);
            Controls.Add(exit);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(roles_list);
            Controls.Add(fullname_txtbox);
            Controls.Add(address_txtbox);
            Controls.Add(phone_txtbox);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MyProfile";
            Text = "FormMembresia";
            Load += MyProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private CustomControls.RJControls.RJButton edit_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private CustomControls.RJControls.RJTextBox fullname_txtbox;
        private CustomControls.RJControls.RJTextBox address_txtbox;
        private CustomControls.RJControls.RJTextBox phone_txtbox;
        private CustomControls.RJControls.RJComboBox roles_list;
        private CustomControls.RJControls.RJTextBox username_txtbox;
        private CustomControls.RJControls.RJTextBox email_txtbox;
        private CustomControls.RJControls.RJButton delete_btn;
        private Label label4;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJTextBox salary_txtbox;
        private Label SALARY;
        private CustomControls.RJControls.RJTextBox position_txtbox;
    }
}