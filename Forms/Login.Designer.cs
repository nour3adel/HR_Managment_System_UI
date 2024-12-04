namespace HR_ManagmentSystem_Client
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblAlt = new Label();
            Lgin_hello = new Label();
            lgin_signup = new Label();
            pictureBox1 = new PictureBox();
            rjToggleButton2 = new CustomControls.RJControls.RJToggleButton();
            Signin_btn = new CustomControls.RJControls.RJButton();
            login_usrname = new CustomControls.RJControls.RJTextBox();
            login_pass = new CustomControls.RJControls.RJTextBox();
            hoverButton1 = new HoverButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAlt
            // 
            lblAlt.BackColor = Color.Transparent;
            lblAlt.Font = new Font("Microsoft Sans Serif", 12F);
            lblAlt.ForeColor = Color.Gray;
            lblAlt.Location = new Point(74, 329);
            lblAlt.Margin = new Padding(4, 0, 4, 0);
            lblAlt.Name = "lblAlt";
            lblAlt.Size = new Size(400, 67);
            lblAlt.TabIndex = 45;
            lblAlt.Text = "Please enter your email address and password to get sign in to your account";
            lblAlt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lgin_hello
            // 
            Lgin_hello.BackColor = Color.Transparent;
            Lgin_hello.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lgin_hello.Location = new Point(48, 85);
            Lgin_hello.Margin = new Padding(4, 0, 4, 0);
            Lgin_hello.Name = "Lgin_hello";
            Lgin_hello.Size = new Size(240, 90);
            Lgin_hello.TabIndex = 44;
            Lgin_hello.Text = "Hello!";
            Lgin_hello.UseMnemonic = false;
            // 
            // lgin_signup
            // 
            lgin_signup.AutoSize = true;
            lgin_signup.Cursor = Cursors.Hand;
            lgin_signup.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lgin_signup.Location = new Point(136, 667);
            lgin_signup.Margin = new Padding(4, 0, 4, 0);
            lgin_signup.Name = "lgin_signup";
            lgin_signup.Size = new Size(263, 20);
            lgin_signup.TabIndex = 42;
            lgin_signup.Text = "Don't have an account yet? Sign Up";
            lgin_signup.Click += label7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(293, 50);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // rjToggleButton2
            // 
            rjToggleButton2.AutoSize = true;
            rjToggleButton2.BackColor = Color.Transparent;
            rjToggleButton2.Cursor = Cursors.Hand;
            rjToggleButton2.ForeColor = Color.Transparent;
            rjToggleButton2.Location = new Point(408, 516);
            rjToggleButton2.Margin = new Padding(4, 3, 4, 3);
            rjToggleButton2.MinimumSize = new Size(41, 23);
            rjToggleButton2.Name = "rjToggleButton2";
            rjToggleButton2.OffBackColor = Color.Gray;
            rjToggleButton2.OffToggleColor = Color.Gainsboro;
            rjToggleButton2.OnBackColor = Color.MediumSlateBlue;
            rjToggleButton2.OnToggleColor = Color.WhiteSmoke;
            rjToggleButton2.Size = new Size(41, 23);
            rjToggleButton2.TabIndex = 46;
            rjToggleButton2.UseVisualStyleBackColor = false;
            rjToggleButton2.CheckedChanged += rjToggleButton2_CheckedChanged;
            // 
            // Signin_btn
            // 
            Signin_btn.BackColor = Color.FromArgb(255, 128, 128);
            Signin_btn.BackgroundColor = Color.FromArgb(255, 128, 128);
            Signin_btn.BorderColor = Color.PaleVioletRed;
            Signin_btn.BorderRadius = 15;
            Signin_btn.BorderSize = 0;
            Signin_btn.Cursor = Cursors.Hand;
            Signin_btn.FlatAppearance.BorderSize = 0;
            Signin_btn.FlatStyle = FlatStyle.Flat;
            Signin_btn.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Signin_btn.ForeColor = Color.White;
            Signin_btn.Location = new Point(75, 592);
            Signin_btn.Margin = new Padding(4, 3, 4, 3);
            Signin_btn.Name = "Signin_btn";
            Signin_btn.Size = new Size(399, 62);
            Signin_btn.TabIndex = 40;
            Signin_btn.Text = "Sign In";
            Signin_btn.TextColor = Color.White;
            Signin_btn.UseVisualStyleBackColor = false;
            Signin_btn.Click += Signinbtn_Click;
            // 
            // login_usrname
            // 
            login_usrname.BackColor = Color.White;
            login_usrname.BorderColor = Color.Black;
            login_usrname.BorderFocusColor = Color.BlueViolet;
            login_usrname.BorderRadius = 12;
            login_usrname.BorderSize = 1;
            login_usrname.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_usrname.ForeColor = Color.DimGray;
            login_usrname.Location = new Point(78, 414);
            login_usrname.Margin = new Padding(5);
            login_usrname.MinimumSize = new Size(0, 58);
            login_usrname.Multiline = false;
            login_usrname.Name = "login_usrname";
            login_usrname.Padding = new Padding(14, 14, 8, 8);
            login_usrname.PasswordChar = false;
            login_usrname.PlaceholderColor = Color.DarkGray;
            login_usrname.PlaceholderText = "Enter Username";
            login_usrname.Size = new Size(386, 58);
            login_usrname.TabIndex = 34;
            login_usrname.Texts = "";
            login_usrname.UnderlinedStyle = false;
            // 
            // login_pass
            // 
            login_pass.BackColor = Color.White;
            login_pass.BorderColor = Color.Black;
            login_pass.BorderFocusColor = Color.BlueViolet;
            login_pass.BorderRadius = 12;
            login_pass.BorderSize = 1;
            login_pass.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_pass.ForeColor = Color.DimGray;
            login_pass.Location = new Point(78, 498);
            login_pass.Margin = new Padding(5);
            login_pass.MinimumSize = new Size(0, 58);
            login_pass.Multiline = false;
            login_pass.Name = "login_pass";
            login_pass.Padding = new Padding(14, 14, 8, 8);
            login_pass.PasswordChar = true;
            login_pass.PlaceholderColor = Color.DarkGray;
            login_pass.PlaceholderText = "Password";
            login_pass.Size = new Size(386, 58);
            login_pass.TabIndex = 33;
            login_pass.Texts = "";
            login_pass.UnderlinedStyle = false;
            // 
            // hoverButton1
            // 
            hoverButton1.FlatAppearance.BorderSize = 0;
            hoverButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            hoverButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            hoverButton1.FlatStyle = FlatStyle.Flat;
            hoverButton1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hoverButton1.HoverColor = Color.Chocolate;
            hoverButton1.Location = new Point(527, 8);
            hoverButton1.Margin = new Padding(4, 3, 4, 3);
            hoverButton1.Name = "hoverButton1";
            hoverButton1.Size = new Size(33, 35);
            hoverButton1.TabIndex = 47;
            hoverButton1.Text = "▶";
            hoverButton1.UseVisualStyleBackColor = true;
            hoverButton1.Click += hoverButton1_Click;
            // 
            // Login
            // 
            AcceptButton = Signin_btn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(561, 790);
            Controls.Add(hoverButton1);
            Controls.Add(rjToggleButton2);
            Controls.Add(lblAlt);
            Controls.Add(Lgin_hello);
            Controls.Add(lgin_signup);
            Controls.Add(Signin_btn);
            Controls.Add(login_usrname);
            Controls.Add(login_pass);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControls.RJControls.RJTextBox login_pass;
        private CustomControls.RJControls.RJTextBox login_usrname;
        private CustomControls.RJControls.RJButton Signin_btn;
        private CustomControls.RJControls.RJToggleButton rjToggleButton2;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Label Lgin_hello;
        private System.Windows.Forms.Label lgin_signup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private HoverButton hoverButton1;
    }
}