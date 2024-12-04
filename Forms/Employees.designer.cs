namespace HR_ManagmentSystem_Client
{
    partial class Employees
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
            BtnCerrar = new Button();
            flpCards = new FlowLayoutPanel();
            exit = new Button();
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
            // flpCards
            // 
            flpCards.AutoScroll = true;
            flpCards.BackColor = Color.FromArgb(22, 22, 22);
            flpCards.Dock = DockStyle.Fill;
            flpCards.ForeColor = Color.White;
            flpCards.Location = new Point(0, 0);
            flpCards.Name = "flpCards";
            flpCards.Size = new Size(1475, 878);
            flpCards.TabIndex = 32;
            flpCards.Paint += flpCards_Paint;
            // 
            // exit
            // 
            exit.BackColor = Color.FromArgb(22, 22, 22);
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.ForeColor = Color.White;
            exit.Location = new Point(1416, 3);
            exit.Margin = new Padding(4, 3, 4, 3);
            exit.Name = "exit";
            exit.Size = new Size(46, 45);
            exit.TabIndex = 25;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click_1;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1475, 878);
            Controls.Add(exit);
            Controls.Add(flpCards);
            Controls.Add(BtnCerrar);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Employees";
            Text = "FormMembresia";
            Load += UserLists_Load;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button BtnCerrar;
        private FlowLayoutPanel flpCards;
        private Button exit;
    }
}