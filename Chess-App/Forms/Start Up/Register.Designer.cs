namespace ChessApp
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
            labelCreateAccount = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            textBoxConfirmPassword = new TextBox();
            buttonCreate = new Button();
            buttonLogIn = new Button();
            labelLogInPrompt = new Label();
            SuspendLayout();
            // 
            // labelCreateAccount
            // 
            labelCreateAccount.AutoSize = true;
            labelCreateAccount.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            labelCreateAccount.ForeColor = SystemColors.ButtonFace;
            labelCreateAccount.Location = new Point(87, 76);
            labelCreateAccount.Name = "labelCreateAccount";
            labelCreateAccount.Size = new Size(479, 71);
            labelCreateAccount.TabIndex = 3;
            labelCreateAccount.Text = "Create an account";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = SystemColors.HighlightText;
            textBoxUsername.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.ForeColor = Color.Black;
            textBoxUsername.Location = new Point(111, 217);
            textBoxUsername.MaxLength = 10;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Username";
            textBoxUsername.Size = new Size(434, 46);
            textBoxUsername.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.HighlightText;
            textBoxPassword.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Location = new Point(111, 295);
            textBoxPassword.MaxLength = 15;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(434, 46);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.BackColor = SystemColors.HighlightText;
            textBoxConfirmPassword.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxConfirmPassword.ForeColor = Color.Black;
            textBoxConfirmPassword.Location = new Point(111, 374);
            textBoxConfirmPassword.MaxLength = 15;
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PlaceholderText = "Confirm Password";
            textBoxConfirmPassword.Size = new Size(434, 46);
            textBoxConfirmPassword.TabIndex = 6;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = SystemColors.Highlight;
            buttonCreate.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.ForeColor = SystemColors.HighlightText;
            buttonCreate.Location = new Point(112, 452);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(434, 64);
            buttonCreate.TabIndex = 7;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = SystemColors.ControlDarkDark;
            buttonLogIn.FlatAppearance.BorderSize = 0;
            buttonLogIn.FlatStyle = FlatStyle.Flat;
            buttonLogIn.ForeColor = SystemColors.GradientActiveCaption;
            buttonLogIn.Location = new Point(391, 531);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(107, 46);
            buttonLogIn.TabIndex = 9;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // labelLogInPrompt
            // 
            labelLogInPrompt.AutoSize = true;
            labelLogInPrompt.ForeColor = SystemColors.HighlightText;
            labelLogInPrompt.Location = new Point(112, 538);
            labelLogInPrompt.Name = "labelLogInPrompt";
            labelLogInPrompt.Size = new Size(287, 32);
            labelLogInPrompt.TabIndex = 8;
            labelLogInPrompt.Text = "Already have an account?";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(654, 779);
            Controls.Add(buttonLogIn);
            Controls.Add(labelLogInPrompt);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelCreateAccount);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHESS - Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCreateAccount;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private TextBox textBoxConfirmPassword;
        private Button buttonCreate;
        private Button buttonLogIn;
        private Label labelLogInPrompt;
    }
}