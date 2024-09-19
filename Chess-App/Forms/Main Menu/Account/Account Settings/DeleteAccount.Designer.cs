namespace ChessApp
{
    partial class DeleteAccount
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
            textBoxPassword = new TextBox();
            labelDeleteAccount = new Label();
            labelDeleteAccountPrompt = new Label();
            buttonCancel = new Button();
            buttonDelete = new Button();
            labelPassword = new Label();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.HighlightText;
            textBoxPassword.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Location = new Point(113, 405);
            textBoxPassword.MaxLength = 15;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(434, 46);
            textBoxPassword.TabIndex = 10;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelDeleteAccount
            // 
            labelDeleteAccount.AutoSize = true;
            labelDeleteAccount.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            labelDeleteAccount.ForeColor = SystemColors.ButtonFace;
            labelDeleteAccount.Location = new Point(125, 93);
            labelDeleteAccount.Name = "labelDeleteAccount";
            labelDeleteAccount.Size = new Size(403, 71);
            labelDeleteAccount.TabIndex = 8;
            labelDeleteAccount.Text = "Delete account";
            // 
            // labelDeleteAccountPrompt
            // 
            labelDeleteAccountPrompt.AutoSize = true;
            labelDeleteAccountPrompt.BackColor = SystemColors.ControlDarkDark;
            labelDeleteAccountPrompt.ForeColor = Color.Gainsboro;
            labelDeleteAccountPrompt.Location = new Point(70, 164);
            labelDeleteAccountPrompt.Name = "labelDeleteAccountPrompt";
            labelDeleteAccountPrompt.Size = new Size(514, 96);
            labelDeleteAccountPrompt.TabIndex = 13;
            labelDeleteAccountPrompt.Text = "Are you sure you want to delete your account?\r\nThe application will be automatically closed \r\nif you do choose to delete.\r\n";
            labelDeleteAccountPrompt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.HighlightText;
            buttonCancel.Location = new Point(350, 483);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(196, 64);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.Highlight;
            buttonDelete.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = SystemColors.HighlightText;
            buttonDelete.Location = new Point(113, 483);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(196, 64);
            buttonDelete.TabIndex = 14;
            buttonDelete.Text = "Confirm";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(113, 370);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(111, 32);
            labelPassword.TabIndex = 16;
            labelPassword.Text = "Password";
            // 
            // DeleteAccount
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(654, 779);
            Controls.Add(labelPassword);
            Controls.Add(buttonCancel);
            Controls.Add(buttonDelete);
            Controls.Add(labelDeleteAccountPrompt);
            Controls.Add(textBoxPassword);
            Controls.Add(labelDeleteAccount);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DeleteAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHESS - Delete Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxPassword;
        private Label labelDeleteAccount;
        private Label labelDeleteAccountPrompt;
        private Button buttonCancel;
        private Button buttonDelete;
        private Label labelPassword;
    }
}