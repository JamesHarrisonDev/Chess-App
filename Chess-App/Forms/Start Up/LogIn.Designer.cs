namespace ChessApp
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
            pictureBoxLogo = new PictureBox();
            labelWelcome = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogIn = new Button();
            labelAccountPrompt = new Label();
            buttonRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(95, 70);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(464, 102);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            labelWelcome.ForeColor = SystemColors.ButtonFace;
            labelWelcome.Location = new Point(159, 193);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(332, 59);
            labelWelcome.TabIndex = 2;
            labelWelcome.Text = "Welcome back!";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = SystemColors.HighlightText;
            textBoxUsername.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.ForeColor = Color.Black;
            textBoxUsername.Location = new Point(111, 294);
            textBoxUsername.MaxLength = 10;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Username";
            textBoxUsername.Size = new Size(434, 46);
            textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.HighlightText;
            textBoxPassword.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Location = new Point(111, 366);
            textBoxPassword.MaxLength = 15;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(434, 46);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = SystemColors.Highlight;
            buttonLogIn.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogIn.ForeColor = SystemColors.HighlightText;
            buttonLogIn.Location = new Point(111, 440);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(434, 64);
            buttonLogIn.TabIndex = 5;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // labelAccountPrompt
            // 
            labelAccountPrompt.AutoSize = true;
            labelAccountPrompt.ForeColor = SystemColors.HighlightText;
            labelAccountPrompt.Location = new Point(111, 528);
            labelAccountPrompt.Name = "labelAccountPrompt";
            labelAccountPrompt.Size = new Size(266, 32);
            labelAccountPrompt.TabIndex = 6;
            labelAccountPrompt.Text = "Don't have an account?";
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = SystemColors.ControlDarkDark;
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.ForeColor = SystemColors.GradientActiveCaption;
            buttonRegister.Location = new Point(371, 521);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(110, 46);
            buttonRegister.TabIndex = 7;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(654, 779);
            Controls.Add(buttonRegister);
            Controls.Add(labelAccountPrompt);
            Controls.Add(buttonLogIn);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelWelcome);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHESS - Log In";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label labelWelcome;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogIn;
        private Label labelAccountPrompt;
        private Button buttonRegister;
    }
}