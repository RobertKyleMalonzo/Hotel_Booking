namespace Hotel_Booking
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            cmbrole = new ComboBox();
            btnRegister = new Button();
            btnLogIn = new Button();
            label1 = new Label();
            txtUsername = new TextBox();
            txtMobile = new TextBox();
            txtEmailAddress = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // cmbrole
            // 
            cmbrole.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbrole.FormattingEnabled = true;
            cmbrole.Items.AddRange(new object[] { "Admin", "Staff", "Customer" });
            cmbrole.Location = new Point(504, 280);
            cmbrole.Name = "cmbrole";
            cmbrole.Size = new Size(230, 25);
            cmbrole.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ControlDark;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(428, 329);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 28);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.MediumSeaGreen;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(591, 329);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(130, 28);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(564, 335);
            label1.Name = "label1";
            label1.Size = new Size(21, 17);
            label1.TabIndex = 3;
            label1.Text = "or";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(509, 151);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Username";
            txtUsername.Size = new Size(218, 18);
            txtUsername.TabIndex = 4;
            // 
            // txtMobile
            // 
            txtMobile.BorderStyle = BorderStyle.None;
            txtMobile.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMobile.Location = new Point(509, 183);
            txtMobile.Name = "txtMobile";
            txtMobile.PlaceholderText = "Enter Mobile";
            txtMobile.Size = new Size(218, 18);
            txtMobile.TabIndex = 5;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BorderStyle = BorderStyle.None;
            txtEmailAddress.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmailAddress.Location = new Point(509, 216);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.PlaceholderText = "Enter Email Adress";
            txtEmailAddress.Size = new Size(218, 18);
            txtEmailAddress.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(509, 248);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(218, 18);
            txtPassword.TabIndex = 7;
            txtPassword.TextChanged += textBox4_TextChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtEmailAddress);
            Controls.Add(txtMobile);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(btnLogIn);
            Controls.Add(btnRegister);
            Controls.Add(cmbrole);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbrole;
        private Button btnRegister;
        private Button btnLogIn;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtMobile;
        private TextBox txtEmailAddress;
        private TextBox txtPassword;
    }
}