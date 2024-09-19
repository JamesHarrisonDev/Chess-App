namespace ChessApp
{
    partial class AccountSettings
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
            panelAccountDetails = new Panel();
            buttonSave = new Button();
            textBoxUsername = new TextBox();
            labelUsernameTitle = new Label();
            labelAccountDetails = new Label();
            labelAuthentication = new Label();
            panelAuthentication = new Panel();
            buttonChangePassword = new Button();
            labelAccountRemoval = new Label();
            panelAccountRemoval = new Panel();
            buttonLogOut = new Button();
            buttonDeleteAccount = new Button();
            panelAccountDetails.SuspendLayout();
            panelAuthentication.SuspendLayout();
            panelAccountRemoval.SuspendLayout();
            SuspendLayout();
            // 
            // panelAccountDetails
            // 
            panelAccountDetails.Anchor = AnchorStyles.None;
            panelAccountDetails.BackColor = Color.FromArgb(70, 70, 70);
            panelAccountDetails.Controls.Add(buttonSave);
            panelAccountDetails.Controls.Add(textBoxUsername);
            panelAccountDetails.Controls.Add(labelUsernameTitle);
            panelAccountDetails.Location = new Point(200, 191);
            panelAccountDetails.Name = "panelAccountDetails";
            panelAccountDetails.Size = new Size(817, 121);
            panelAccountDetails.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.HotTrack;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(677, 29);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(105, 58);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.FromArgb(70, 70, 70);
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.ForeColor = Color.White;
            textBoxUsername.Location = new Point(30, 55);
            textBoxUsername.MaxLength = 10;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(200, 43);
            textBoxUsername.TabIndex = 1;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // labelUsernameTitle
            // 
            labelUsernameTitle.AutoSize = true;
            labelUsernameTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsernameTitle.ForeColor = SystemColors.ActiveBorder;
            labelUsernameTitle.Location = new Point(25, 20);
            labelUsernameTitle.Name = "labelUsernameTitle";
            labelUsernameTitle.Size = new Size(121, 32);
            labelUsernameTitle.TabIndex = 0;
            labelUsernameTitle.Text = "Username";
            // 
            // labelAccountDetails
            // 
            labelAccountDetails.Anchor = AnchorStyles.None;
            labelAccountDetails.AutoSize = true;
            labelAccountDetails.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            labelAccountDetails.ForeColor = Color.White;
            labelAccountDetails.Location = new Point(200, 138);
            labelAccountDetails.Name = "labelAccountDetails";
            labelAccountDetails.Size = new Size(294, 50);
            labelAccountDetails.TabIndex = 1;
            labelAccountDetails.Text = "Account Details";
            // 
            // labelAuthentication
            // 
            labelAuthentication.Anchor = AnchorStyles.None;
            labelAuthentication.AutoSize = true;
            labelAuthentication.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            labelAuthentication.ForeColor = Color.White;
            labelAuthentication.Location = new Point(200, 411);
            labelAuthentication.Name = "labelAuthentication";
            labelAuthentication.Size = new Size(281, 50);
            labelAuthentication.TabIndex = 3;
            labelAuthentication.Text = "Authentication";
            // 
            // panelAuthentication
            // 
            panelAuthentication.Anchor = AnchorStyles.None;
            panelAuthentication.BackColor = Color.FromArgb(70, 70, 70);
            panelAuthentication.Controls.Add(buttonChangePassword);
            panelAuthentication.Location = new Point(200, 464);
            panelAuthentication.Name = "panelAuthentication";
            panelAuthentication.Size = new Size(817, 121);
            panelAuthentication.TabIndex = 2;
            // 
            // buttonChangePassword
            // 
            buttonChangePassword.BackColor = SystemColors.HotTrack;
            buttonChangePassword.FlatAppearance.BorderSize = 0;
            buttonChangePassword.FlatStyle = FlatStyle.Flat;
            buttonChangePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonChangePassword.ForeColor = Color.White;
            buttonChangePassword.Location = new Point(30, 33);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(293, 58);
            buttonChangePassword.TabIndex = 2;
            buttonChangePassword.Text = "Change Password";
            buttonChangePassword.UseVisualStyleBackColor = false;
            buttonChangePassword.Click += buttonChangePassword_Click;
            // 
            // labelAccountRemoval
            // 
            labelAccountRemoval.Anchor = AnchorStyles.None;
            labelAccountRemoval.AutoSize = true;
            labelAccountRemoval.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            labelAccountRemoval.ForeColor = Color.White;
            labelAccountRemoval.Location = new Point(200, 686);
            labelAccountRemoval.Name = "labelAccountRemoval";
            labelAccountRemoval.Size = new Size(325, 50);
            labelAccountRemoval.TabIndex = 5;
            labelAccountRemoval.Text = "Account Removal";
            // 
            // panelAccountRemoval
            // 
            panelAccountRemoval.Anchor = AnchorStyles.None;
            panelAccountRemoval.BackColor = Color.FromArgb(70, 70, 70);
            panelAccountRemoval.Controls.Add(buttonLogOut);
            panelAccountRemoval.Controls.Add(buttonDeleteAccount);
            panelAccountRemoval.Location = new Point(200, 739);
            panelAccountRemoval.Name = "panelAccountRemoval";
            panelAccountRemoval.Size = new Size(817, 121);
            panelAccountRemoval.TabIndex = 4;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = SystemColors.HotTrack;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogOut.ForeColor = Color.White;
            buttonLogOut.Location = new Point(25, 30);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(153, 58);
            buttonLogOut.TabIndex = 6;
            buttonLogOut.Text = "Log Out";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonDeleteAccount
            // 
            buttonDeleteAccount.BackColor = Color.IndianRed;
            buttonDeleteAccount.FlatAppearance.BorderSize = 0;
            buttonDeleteAccount.FlatStyle = FlatStyle.Flat;
            buttonDeleteAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteAccount.ForeColor = Color.White;
            buttonDeleteAccount.Location = new Point(210, 30);
            buttonDeleteAccount.Name = "buttonDeleteAccount";
            buttonDeleteAccount.Size = new Size(293, 58);
            buttonDeleteAccount.TabIndex = 2;
            buttonDeleteAccount.Text = "Delete Account";
            buttonDeleteAccount.UseVisualStyleBackColor = false;
            buttonDeleteAccount.Click += buttonDeleteAccount_Click;
            // 
            // AccountSettings
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(1234, 993);
            Controls.Add(labelAccountRemoval);
            Controls.Add(panelAccountRemoval);
            Controls.Add(labelAuthentication);
            Controls.Add(panelAuthentication);
            Controls.Add(labelAccountDetails);
            Controls.Add(panelAccountDetails);
            Name = "AccountSettings";
            Text = "AccountSettings";
            Load += AccountSettings_Load;
            panelAccountDetails.ResumeLayout(false);
            panelAccountDetails.PerformLayout();
            panelAuthentication.ResumeLayout(false);
            panelAccountRemoval.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelAccountDetails;
        private Label labelAccountDetails;
        private Label labelUsername;
        private Label labelUsernameTitle;
        private TextBox textBoxUsername;
        private Button buttonSave;
        private Label labelAuthentication;
        private Panel panelAuthentication;
        private Button buttonChangePassword;
        private Label labelAccountRemoval;
        private Panel panelAccountRemoval;
        private Button buttonDeleteAccount;
        private Button buttonLogOut;
    }
}