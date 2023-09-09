namespace StudentManager
{
    partial class Login_Form
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
            pictureBox1 = new PictureBox();
            Account_Login = new Label();
            lbUsername = new Label();
            lbPassword = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            Loginbtn = new Button();
            Cancelbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(48, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Account_Login
            // 
            Account_Login.AutoSize = true;
            Account_Login.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Account_Login.Location = new Point(359, 88);
            Account_Login.Name = "Account_Login";
            Account_Login.Size = new Size(236, 46);
            Account_Login.TabIndex = 1;
            Account_Login.Text = "Account Login";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsername.Location = new Point(73, 304);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(127, 35);
            lbUsername.TabIndex = 2;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbPassword.Location = new Point(80, 379);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(120, 35);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(258, 313);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(236, 27);
            tbUsername.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(258, 387);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(236, 27);
            tbPassword.TabIndex = 5;
            // 
            // Loginbtn
            // 
            Loginbtn.BackColor = Color.FromArgb(128, 255, 128);
            Loginbtn.Location = new Point(536, 434);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(164, 102);
            Loginbtn.TabIndex = 6;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // Cancelbtn
            // 
            Cancelbtn.BackColor = Color.FromArgb(255, 128, 128);
            Cancelbtn.Location = new Point(330, 434);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(164, 102);
            Cancelbtn.TabIndex = 7;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = false;
            Cancelbtn.Click += Cancelbtn_Click;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(762, 567);
            Controls.Add(Cancelbtn);
            Controls.Add(Loginbtn);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(Account_Login);
            Controls.Add(pictureBox1);
            Name = "Login_Form";
            Text = "Login_Form";
            Load += Login_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Account_Login;
        private Label lbUsername;
        private Label lbPassword;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button Loginbtn;
        private Button Cancelbtn;
    }
}