namespace HR_ManagmentSystem_Client
{
    partial class SignUp
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
            pass_toggle = new CustomControls.RJControls.RJToggleButton();
            signup_pass2 = new CustomControls.RJControls.RJTextBox();
            signup_pass = new CustomControls.RJControls.RJTextBox();
            username_txtbox = new CustomControls.RJControls.RJTextBox();
            email_txtbox = new CustomControls.RJControls.RJTextBox();
            lblCreate = new Label();
            lblNote = new Label();
            linkSignIn = new LinkLabel();
            Createbtn = new CustomControls.RJControls.RJButton();
            hoverButton4 = new HoverButton();
            Fullname_txtbox = new CustomControls.RJControls.RJTextBox();
            address_txtbox = new CustomControls.RJControls.RJTextBox();
            phonenumber_txtbox = new CustomControls.RJControls.RJTextBox();
            position_txtbox = new CustomControls.RJControls.RJTextBox();
            department_txtbox = new CustomControls.RJControls.RJTextBox();
            IsAdmin_chk = new CheckBox();
            Salary_txtbox = new CustomControls.RJControls.RJTextBox();
            SuspendLayout();
            // 
            // pass_toggle
            // 
            pass_toggle.AutoSize = true;
            pass_toggle.BackColor = Color.Transparent;
            pass_toggle.Cursor = Cursors.Hand;
            pass_toggle.ForeColor = Color.Transparent;
            pass_toggle.Location = new Point(374, 345);
            pass_toggle.Margin = new Padding(4, 3, 4, 3);
            pass_toggle.MinimumSize = new Size(41, 23);
            pass_toggle.Name = "pass_toggle";
            pass_toggle.OffBackColor = Color.Gray;
            pass_toggle.OffToggleColor = Color.Gainsboro;
            pass_toggle.OnBackColor = Color.MediumSlateBlue;
            pass_toggle.OnToggleColor = Color.WhiteSmoke;
            pass_toggle.Size = new Size(41, 23);
            pass_toggle.TabIndex = 49;
            pass_toggle.UseVisualStyleBackColor = false;
            pass_toggle.CheckedChanged += passtoggle_CheckedChanged;
            // 
            // signup_pass2
            // 
            signup_pass2.BackColor = Color.White;
            signup_pass2.BorderColor = Color.Black;
            signup_pass2.BorderFocusColor = Color.BlueViolet;
            signup_pass2.BorderRadius = 12;
            signup_pass2.BorderSize = 1;
            signup_pass2.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_pass2.ForeColor = Color.DimGray;
            signup_pass2.Location = new Point(461, 327);
            signup_pass2.Margin = new Padding(5);
            signup_pass2.MinimumSize = new Size(0, 58);
            signup_pass2.Multiline = false;
            signup_pass2.Name = "signup_pass2";
            signup_pass2.Padding = new Padding(14, 14, 8, 8);
            signup_pass2.PasswordChar = false;
            signup_pass2.PlaceholderColor = Color.DarkGray;
            signup_pass2.PlaceholderText = "Confirm Password";
            signup_pass2.Size = new Size(386, 58);
            signup_pass2.TabIndex = 48;
            signup_pass2.Texts = "";
            signup_pass2.UnderlinedStyle = false;
            // 
            // signup_pass
            // 
            signup_pass.BackColor = Color.White;
            signup_pass.BorderColor = Color.Black;
            signup_pass.BorderFocusColor = Color.BlueViolet;
            signup_pass.BorderRadius = 12;
            signup_pass.BorderSize = 1;
            signup_pass.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_pass.ForeColor = Color.DimGray;
            signup_pass.Location = new Point(44, 327);
            signup_pass.Margin = new Padding(5);
            signup_pass.MinimumSize = new Size(0, 58);
            signup_pass.Multiline = false;
            signup_pass.Name = "signup_pass";
            signup_pass.Padding = new Padding(14, 14, 8, 8);
            signup_pass.PasswordChar = true;
            signup_pass.PlaceholderColor = Color.DarkGray;
            signup_pass.PlaceholderText = "CreatePassword";
            signup_pass.Size = new Size(386, 58);
            signup_pass.TabIndex = 47;
            signup_pass.Texts = "";
            signup_pass.UnderlinedStyle = false;
            // 
            // username_txtbox
            // 
            username_txtbox.BackColor = Color.White;
            username_txtbox.BorderColor = Color.Black;
            username_txtbox.BorderFocusColor = Color.BlueViolet;
            username_txtbox.BorderRadius = 12;
            username_txtbox.BorderSize = 1;
            username_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_txtbox.ForeColor = Color.DimGray;
            username_txtbox.Location = new Point(44, 243);
            username_txtbox.Margin = new Padding(5);
            username_txtbox.MinimumSize = new Size(0, 58);
            username_txtbox.Multiline = false;
            username_txtbox.Name = "username_txtbox";
            username_txtbox.Padding = new Padding(14, 14, 8, 8);
            username_txtbox.PasswordChar = false;
            username_txtbox.PlaceholderColor = Color.DarkGray;
            username_txtbox.PlaceholderText = "Create Username";
            username_txtbox.Size = new Size(386, 58);
            username_txtbox.TabIndex = 50;
            username_txtbox.Texts = "";
            username_txtbox.UnderlinedStyle = false;
            username_txtbox._TextChanged += signup_usr__TextChanged;
            // 
            // email_txtbox
            // 
            email_txtbox.BackColor = Color.White;
            email_txtbox.BorderColor = Color.Black;
            email_txtbox.BorderFocusColor = Color.BlueViolet;
            email_txtbox.BorderRadius = 12;
            email_txtbox.BorderSize = 1;
            email_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email_txtbox.ForeColor = Color.DimGray;
            email_txtbox.Location = new Point(461, 243);
            email_txtbox.Margin = new Padding(5);
            email_txtbox.MinimumSize = new Size(0, 58);
            email_txtbox.Multiline = false;
            email_txtbox.Name = "email_txtbox";
            email_txtbox.Padding = new Padding(14, 14, 8, 8);
            email_txtbox.PasswordChar = false;
            email_txtbox.PlaceholderColor = Color.DarkGray;
            email_txtbox.PlaceholderText = "Enter Email";
            email_txtbox.Size = new Size(386, 58);
            email_txtbox.TabIndex = 51;
            email_txtbox.Texts = "";
            email_txtbox.UnderlinedStyle = false;
            email_txtbox._TextChanged += email__TextChanged;
            // 
            // lblCreate
            // 
            lblCreate.AutoSize = true;
            lblCreate.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold);
            lblCreate.Location = new Point(274, 32);
            lblCreate.Margin = new Padding(4, 0, 4, 0);
            lblCreate.Name = "lblCreate";
            lblCreate.Size = new Size(345, 44);
            lblCreate.TabIndex = 52;
            lblCreate.Text = "Create an account";
            // 
            // lblNote
            // 
            lblNote.BackColor = Color.Transparent;
            lblNote.Font = new Font("Microsoft Sans Serif", 12F);
            lblNote.ForeColor = Color.Gray;
            lblNote.Location = new Point(244, 76);
            lblNote.Margin = new Padding(4, 0, 4, 0);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(400, 67);
            lblNote.TabIndex = 53;
            lblNote.Text = "Please fill up the neccessary information to create your account";
            lblNote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkSignIn
            // 
            linkSignIn.AutoSize = true;
            linkSignIn.Cursor = Cursors.Hand;
            linkSignIn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkSignIn.LinkColor = Color.Black;
            linkSignIn.Location = new Point(316, 702);
            linkSignIn.Margin = new Padding(4, 0, 4, 0);
            linkSignIn.Name = "linkSignIn";
            linkSignIn.Size = new Size(246, 20);
            linkSignIn.TabIndex = 55;
            linkSignIn.TabStop = true;
            linkSignIn.Text = "Already have an account? Sign In";
            linkSignIn.LinkClicked += linkSignIn_LinkClicked;
            // 
            // Createbtn
            // 
            Createbtn.BackColor = Color.FromArgb(255, 128, 128);
            Createbtn.BackgroundColor = Color.FromArgb(255, 128, 128);
            Createbtn.BorderColor = Color.PaleVioletRed;
            Createbtn.BorderRadius = 15;
            Createbtn.BorderSize = 0;
            Createbtn.Cursor = Cursors.Hand;
            Createbtn.FlatAppearance.BorderSize = 0;
            Createbtn.FlatStyle = FlatStyle.Flat;
            Createbtn.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Createbtn.ForeColor = Color.White;
            Createbtn.Location = new Point(245, 628);
            Createbtn.Margin = new Padding(4, 3, 4, 3);
            Createbtn.Name = "Createbtn";
            Createbtn.Size = new Size(399, 62);
            Createbtn.TabIndex = 56;
            Createbtn.Text = "Create account";
            Createbtn.TextColor = Color.White;
            Createbtn.UseVisualStyleBackColor = false;
            Createbtn.Click += Createbtn_Click;
            // 
            // hoverButton4
            // 
            hoverButton4.FlatAppearance.BorderSize = 0;
            hoverButton4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            hoverButton4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            hoverButton4.FlatStyle = FlatStyle.Flat;
            hoverButton4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hoverButton4.HoverColor = Color.Chocolate;
            hoverButton4.Location = new Point(851, 15);
            hoverButton4.Margin = new Padding(4, 3, 4, 3);
            hoverButton4.Name = "hoverButton4";
            hoverButton4.Size = new Size(33, 35);
            hoverButton4.TabIndex = 57;
            hoverButton4.Text = "▶";
            hoverButton4.UseVisualStyleBackColor = true;
            hoverButton4.Click += hoverButton4_Click;
            // 
            // Fullname_txtbox
            // 
            Fullname_txtbox.BackColor = Color.White;
            Fullname_txtbox.BorderColor = Color.Black;
            Fullname_txtbox.BorderFocusColor = Color.BlueViolet;
            Fullname_txtbox.BorderRadius = 12;
            Fullname_txtbox.BorderSize = 1;
            Fullname_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fullname_txtbox.ForeColor = Color.DimGray;
            Fullname_txtbox.Location = new Point(44, 158);
            Fullname_txtbox.Margin = new Padding(5);
            Fullname_txtbox.MinimumSize = new Size(0, 58);
            Fullname_txtbox.Multiline = false;
            Fullname_txtbox.Name = "Fullname_txtbox";
            Fullname_txtbox.Padding = new Padding(14, 14, 8, 8);
            Fullname_txtbox.PasswordChar = false;
            Fullname_txtbox.PlaceholderColor = Color.DarkGray;
            Fullname_txtbox.PlaceholderText = "Enter Full Name";
            Fullname_txtbox.Size = new Size(386, 58);
            Fullname_txtbox.TabIndex = 58;
            Fullname_txtbox.Texts = "";
            Fullname_txtbox.UnderlinedStyle = false;
            // 
            // address_txtbox
            // 
            address_txtbox.BackColor = Color.White;
            address_txtbox.BorderColor = Color.Black;
            address_txtbox.BorderFocusColor = Color.BlueViolet;
            address_txtbox.BorderRadius = 12;
            address_txtbox.BorderSize = 1;
            address_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address_txtbox.ForeColor = Color.DimGray;
            address_txtbox.Location = new Point(44, 410);
            address_txtbox.Margin = new Padding(5);
            address_txtbox.MinimumSize = new Size(0, 58);
            address_txtbox.Multiline = false;
            address_txtbox.Name = "address_txtbox";
            address_txtbox.Padding = new Padding(14, 14, 8, 8);
            address_txtbox.PasswordChar = false;
            address_txtbox.PlaceholderColor = Color.DarkGray;
            address_txtbox.PlaceholderText = "Enter Address";
            address_txtbox.Size = new Size(386, 58);
            address_txtbox.TabIndex = 59;
            address_txtbox.Texts = "";
            address_txtbox.UnderlinedStyle = false;
            // 
            // phonenumber_txtbox
            // 
            phonenumber_txtbox.BackColor = Color.White;
            phonenumber_txtbox.BorderColor = Color.Black;
            phonenumber_txtbox.BorderFocusColor = Color.BlueViolet;
            phonenumber_txtbox.BorderRadius = 12;
            phonenumber_txtbox.BorderSize = 1;
            phonenumber_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phonenumber_txtbox.ForeColor = Color.DimGray;
            phonenumber_txtbox.Location = new Point(461, 410);
            phonenumber_txtbox.Margin = new Padding(5);
            phonenumber_txtbox.MinimumSize = new Size(0, 58);
            phonenumber_txtbox.Multiline = false;
            phonenumber_txtbox.Name = "phonenumber_txtbox";
            phonenumber_txtbox.Padding = new Padding(14, 14, 8, 8);
            phonenumber_txtbox.PasswordChar = false;
            phonenumber_txtbox.PlaceholderColor = Color.DarkGray;
            phonenumber_txtbox.PlaceholderText = "Enter Phone Number";
            phonenumber_txtbox.Size = new Size(386, 58);
            phonenumber_txtbox.TabIndex = 60;
            phonenumber_txtbox.Texts = "";
            phonenumber_txtbox.UnderlinedStyle = false;
            // 
            // position_txtbox
            // 
            position_txtbox.BackColor = Color.White;
            position_txtbox.BorderColor = Color.Black;
            position_txtbox.BorderFocusColor = Color.BlueViolet;
            position_txtbox.BorderRadius = 12;
            position_txtbox.BorderSize = 1;
            position_txtbox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            position_txtbox.ForeColor = Color.DimGray;
            position_txtbox.Location = new Point(461, 158);
            position_txtbox.Margin = new Padding(5);
            position_txtbox.MinimumSize = new Size(0, 58);
            position_txtbox.Multiline = false;
            position_txtbox.Name = "position_txtbox";
            position_txtbox.Padding = new Padding(14, 14, 8, 8);
            position_txtbox.PasswordChar = false;
            position_txtbox.PlaceholderColor = Color.DarkGray;
            position_txtbox.PlaceholderText = "Enter Position";
            position_txtbox.Size = new Size(386, 58);
            position_txtbox.TabIndex = 61;
            position_txtbox.Texts = "";
            position_txtbox.UnderlinedStyle = false;
            // 
            // department_txtbox
            // 
            department_txtbox.BackColor = Color.White;
            department_txtbox.BorderColor = Color.Black;
            department_txtbox.BorderFocusColor = Color.BlueViolet;
            department_txtbox.BorderRadius = 12;
            department_txtbox.BorderSize = 1;
            department_txtbox.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            department_txtbox.ForeColor = Color.DimGray;
            department_txtbox.Location = new Point(44, 493);
            department_txtbox.Margin = new Padding(5);
            department_txtbox.MinimumSize = new Size(0, 58);
            department_txtbox.Multiline = false;
            department_txtbox.Name = "department_txtbox";
            department_txtbox.Padding = new Padding(14, 14, 8, 8);
            department_txtbox.PasswordChar = false;
            department_txtbox.PlaceholderColor = Color.DarkGray;
            department_txtbox.PlaceholderText = "Enter Department ID";
            department_txtbox.Size = new Size(386, 58);
            department_txtbox.TabIndex = 62;
            department_txtbox.Texts = "";
            department_txtbox.UnderlinedStyle = false;
            // 
            // IsAdmin_chk
            // 
            IsAdmin_chk.AutoSize = true;
            IsAdmin_chk.Cursor = Cursors.Hand;
            IsAdmin_chk.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IsAdmin_chk.ForeColor = SystemColors.ControlDarkDark;
            IsAdmin_chk.Location = new Point(245, 595);
            IsAdmin_chk.Margin = new Padding(4, 3, 4, 3);
            IsAdmin_chk.Name = "IsAdmin_chk";
            IsAdmin_chk.Size = new Size(154, 27);
            IsAdmin_chk.TabIndex = 63;
            IsAdmin_chk.Text = "IS ADMIN ?";
            IsAdmin_chk.UseVisualStyleBackColor = true;
            // 
            // Salary_txtbox
            // 
            Salary_txtbox.BackColor = Color.White;
            Salary_txtbox.BorderColor = Color.Black;
            Salary_txtbox.BorderFocusColor = Color.BlueViolet;
            Salary_txtbox.BorderRadius = 12;
            Salary_txtbox.BorderSize = 1;
            Salary_txtbox.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Salary_txtbox.ForeColor = Color.DimGray;
            Salary_txtbox.Location = new Point(461, 493);
            Salary_txtbox.Margin = new Padding(5);
            Salary_txtbox.MinimumSize = new Size(0, 58);
            Salary_txtbox.Multiline = false;
            Salary_txtbox.Name = "Salary_txtbox";
            Salary_txtbox.Padding = new Padding(14, 14, 8, 8);
            Salary_txtbox.PasswordChar = false;
            Salary_txtbox.PlaceholderColor = Color.DarkGray;
            Salary_txtbox.PlaceholderText = "Enter Your Salary";
            Salary_txtbox.Size = new Size(386, 58);
            Salary_txtbox.TabIndex = 64;
            Salary_txtbox.Texts = "";
            Salary_txtbox.UnderlinedStyle = false;
            // 
            // SignUp
            // 
            AcceptButton = Createbtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(897, 771);
            Controls.Add(Salary_txtbox);
            Controls.Add(IsAdmin_chk);
            Controls.Add(department_txtbox);
            Controls.Add(position_txtbox);
            Controls.Add(phonenumber_txtbox);
            Controls.Add(address_txtbox);
            Controls.Add(Fullname_txtbox);
            Controls.Add(hoverButton4);
            Controls.Add(Createbtn);
            Controls.Add(linkSignIn);
            Controls.Add(lblNote);
            Controls.Add(lblCreate);
            Controls.Add(email_txtbox);
            Controls.Add(username_txtbox);
            Controls.Add(pass_toggle);
            Controls.Add(signup_pass2);
            Controls.Add(signup_pass);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJToggleButton pass_toggle;
        private CustomControls.RJControls.RJTextBox signup_pass2;
        private CustomControls.RJControls.RJTextBox signup_pass;
        private CustomControls.RJControls.RJTextBox username_txtbox;
        private CustomControls.RJControls.RJTextBox email_txtbox;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.LinkLabel linkSignIn;
        private CustomControls.RJControls.RJButton Createbtn;
        private HoverButton hoverButton4;
        private CustomControls.RJControls.RJTextBox Fullname_txtbox;
        private CustomControls.RJControls.RJTextBox address_txtbox;
        private CustomControls.RJControls.RJTextBox phonenumber_txtbox;
        private CustomControls.RJControls.RJTextBox position_txtbox;
        private CustomControls.RJControls.RJTextBox department_txtbox;
        private CheckBox IsAdmin_chk;
        private CustomControls.RJControls.RJTextBox Salary_txtbox;
    }
}