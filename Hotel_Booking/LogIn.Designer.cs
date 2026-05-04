namespace Hotel_Booking
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            chkShowPassword = new CheckBox();
            btnLogIn = new Button();
            btnSignUp = new Button();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.White;
            chkShowPassword.Location = new Point(439, 278);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(122, 21);
            chkShowPassword.TabIndex = 0;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = false;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.SteelBlue;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(497, 305);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(164, 30);
            btnLogIn.TabIndex = 1;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.MediumSeaGreen;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(497, 360);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(164, 30);
            btnSignUp.TabIndex = 2;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(568, 338);
            label2.Name = "label2";
            label2.Size = new Size(21, 17);
            label2.TabIndex = 4;
            label2.Text = "or";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(439, 175);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter Email";
            txtEmail.Size = new Size(279, 18);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(439, 244);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(279, 18);
            txtPassword.TabIndex = 6;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogIn);
            Controls.Add(chkShowPassword);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkShowPassword;
        private Button btnLogIn;
        private Button btnSignUp;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
    }
}