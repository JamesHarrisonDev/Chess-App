namespace ChessApp
{
    partial class PasswordChange
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
            buttonConfirm = new Button();
            textBoxConfirmNewPassword = new TextBox();
            textBoxNewPassword = new TextBox();
            textBoxCurrentPassword = new TextBox();
            labelChangePassword = new Label();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = SystemColors.Highlight;
            buttonConfirm.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.ForeColor = SystemColors.HighlightText;
            buttonConfirm.Location = new Point(117, 500);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(196, 64);
            buttonConfirm.TabIndex = 12;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // textBoxConfirmNewPassword
            // 
            textBoxConfirmNewPassword.BackColor = SystemColors.HighlightText;
            textBoxConfirmNewPassword.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxConfirmNewPassword.ForeColor = Color.Black;
            textBoxConfirmNewPassword.Location = new Point(116, 422);
            textBoxConfirmNewPassword.MaxLength = 15;
            textBoxConfirmNewPassword.Name = "textBoxConfirmNewPassword";
            textBoxConfirmNewPassword.PlaceholderText = "Confirm New Password";
            textBoxConfirmNewPassword.Size = new Size(434, 46);
            textBoxConfirmNewPassword.TabIndex = 11;
            textBoxConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.BackColor = SystemColors.HighlightText;
            textBoxNewPassword.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNewPassword.ForeColor = Color.Black;
            textBoxNewPassword.Location = new Point(116, 343);
            textBoxNewPassword.MaxLength = 15;
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.PlaceholderText = "New Password";
            textBoxNewPassword.Size = new Size(434, 46);
            textBoxNewPassword.TabIndex = 10;
            textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // textBoxCurrentPassword
            // 
            textBoxCurrentPassword.BackColor = SystemColors.HighlightText;
            textBoxCurrentPassword.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCurrentPassword.ForeColor = Color.Black;
            textBoxCurrentPassword.Location = new Point(116, 265);
            textBoxCurrentPassword.MaxLength = 15;
            textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            textBoxCurrentPassword.PlaceholderText = "Current Password";
            textBoxCurrentPassword.Size = new Size(434, 46);
            textBoxCurrentPassword.TabIndex = 9;
            textBoxCurrentPassword.UseSystemPasswordChar = true;
            // 
            // labelChangePassword
            // 
            labelChangePassword.AutoSize = true;
            labelChangePassword.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            labelChangePassword.ForeColor = SystemColors.ButtonFace;
            labelChangePassword.Location = new Point(38, 138);
            labelChangePassword.Name = "labelChangePassword";
            labelChangePassword.Size = new Size(591, 71);
            labelChangePassword.TabIndex = 8;
            labelChangePassword.Text = "Update your password";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.HighlightText;
            buttonCancel.Location = new Point(354, 500);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(196, 64);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // PasswordChange
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(654, 779);
            Controls.Add(buttonCancel);
            Controls.Add(buttonConfirm);
            Controls.Add(textBoxConfirmNewPassword);
            Controls.Add(textBoxNewPassword);
            Controls.Add(textBoxCurrentPassword);
            Controls.Add(labelChangePassword);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PasswordChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHESS - Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConfirm;
        private TextBox textBoxConfirmNewPassword;
        private TextBox textBoxNewPassword;
        private TextBox textBoxCurrentPassword;
        private Label labelChangePassword;
        private Button buttonCancel;
    }
}