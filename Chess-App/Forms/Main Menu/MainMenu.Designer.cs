namespace ChessApp
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panelSideBar = new Panel();
            buttonAdjourned = new Button();
            pictureBoxSmallLogo = new PictureBox();
            buttonPuzzles = new Button();
            panelPlaySubmenu = new Panel();
            buttonPlayComputer = new Button();
            buttonPlayLocal = new Button();
            buttonPlay = new Button();
            panelAccountSubmenu = new Panel();
            buttonAccountSettings = new Button();
            buttonAccountStatistics = new Button();
            buttonAccount = new Button();
            panelUser = new Panel();
            labelUsername = new Label();
            pictureBoxUser = new PictureBox();
            panelChildForm = new Panel();
            pictureBoxChessImage = new PictureBox();
            pictureBoxLogo = new PictureBox();
            panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSmallLogo).BeginInit();
            panelPlaySubmenu.SuspendLayout();
            panelAccountSubmenu.SuspendLayout();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChessImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelSideBar
            // 
            panelSideBar.BackColor = Color.FromArgb(11, 7, 17);
            panelSideBar.Controls.Add(buttonAdjourned);
            panelSideBar.Controls.Add(pictureBoxSmallLogo);
            panelSideBar.Controls.Add(buttonPuzzles);
            panelSideBar.Controls.Add(panelPlaySubmenu);
            panelSideBar.Controls.Add(buttonPlay);
            panelSideBar.Controls.Add(panelAccountSubmenu);
            panelSideBar.Controls.Add(buttonAccount);
            panelSideBar.Controls.Add(panelUser);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Location = new Point(0, 0);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(309, 1064);
            panelSideBar.TabIndex = 0;
            // 
            // buttonAdjourned
            // 
            buttonAdjourned.Dock = DockStyle.Top;
            buttonAdjourned.FlatAppearance.BorderSize = 0;
            buttonAdjourned.FlatStyle = FlatStyle.Flat;
            buttonAdjourned.ForeColor = Color.Gainsboro;
            buttonAdjourned.Location = new Point(0, 795);
            buttonAdjourned.Name = "buttonAdjourned";
            buttonAdjourned.Padding = new Padding(30, 0, 0, 0);
            buttonAdjourned.Size = new Size(309, 66);
            buttonAdjourned.TabIndex = 5;
            buttonAdjourned.Text = "Adjourned";
            buttonAdjourned.TextAlign = ContentAlignment.MiddleLeft;
            buttonAdjourned.UseVisualStyleBackColor = true;
            buttonAdjourned.Click += buttonAdjourned_Click;
            buttonAdjourned.MouseLeave += buttonAdjourned_MouseLeave;
            buttonAdjourned.MouseHover += buttonAdjourned_MouseHover;
            // 
            // pictureBoxSmallLogo
            // 
            pictureBoxSmallLogo.Image = (Image)resources.GetObject("pictureBoxSmallLogo.Image");
            pictureBoxSmallLogo.Location = new Point(32, 960);
            pictureBoxSmallLogo.Name = "pictureBoxSmallLogo";
            pictureBoxSmallLogo.Size = new Size(246, 73);
            pictureBoxSmallLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSmallLogo.TabIndex = 2;
            pictureBoxSmallLogo.TabStop = false;
            // 
            // buttonPuzzles
            // 
            buttonPuzzles.Dock = DockStyle.Top;
            buttonPuzzles.FlatAppearance.BorderSize = 0;
            buttonPuzzles.FlatStyle = FlatStyle.Flat;
            buttonPuzzles.ForeColor = Color.Gainsboro;
            buttonPuzzles.Location = new Point(0, 729);
            buttonPuzzles.Name = "buttonPuzzles";
            buttonPuzzles.Padding = new Padding(30, 0, 0, 0);
            buttonPuzzles.Size = new Size(309, 66);
            buttonPuzzles.TabIndex = 4;
            buttonPuzzles.Text = "Generate Puzzle";
            buttonPuzzles.TextAlign = ContentAlignment.MiddleLeft;
            buttonPuzzles.UseVisualStyleBackColor = true;
            buttonPuzzles.Click += buttonPuzzles_Click;
            buttonPuzzles.MouseLeave += buttonPuzzles_MouseLeave;
            buttonPuzzles.MouseHover += buttonPuzzles_MouseHover;
            // 
            // panelPlaySubmenu
            // 
            panelPlaySubmenu.BackColor = Color.FromArgb(35, 32, 39);
            panelPlaySubmenu.Controls.Add(buttonPlayComputer);
            panelPlaySubmenu.Controls.Add(buttonPlayLocal);
            panelPlaySubmenu.Dock = DockStyle.Top;
            panelPlaySubmenu.Location = new Point(0, 594);
            panelPlaySubmenu.Name = "panelPlaySubmenu";
            panelPlaySubmenu.Size = new Size(309, 135);
            panelPlaySubmenu.TabIndex = 3;
            // 
            // buttonPlayComputer
            // 
            buttonPlayComputer.Dock = DockStyle.Top;
            buttonPlayComputer.FlatAppearance.BorderSize = 0;
            buttonPlayComputer.FlatStyle = FlatStyle.Flat;
            buttonPlayComputer.ForeColor = Color.LightGray;
            buttonPlayComputer.Location = new Point(0, 66);
            buttonPlayComputer.Name = "buttonPlayComputer";
            buttonPlayComputer.Padding = new Padding(90, 0, 0, 0);
            buttonPlayComputer.Size = new Size(309, 66);
            buttonPlayComputer.TabIndex = 2;
            buttonPlayComputer.Text = "Computer";
            buttonPlayComputer.TextAlign = ContentAlignment.MiddleLeft;
            buttonPlayComputer.UseVisualStyleBackColor = true;
            buttonPlayComputer.Click += buttonPlayComputer_Click;
            // 
            // buttonPlayLocal
            // 
            buttonPlayLocal.Dock = DockStyle.Top;
            buttonPlayLocal.FlatAppearance.BorderSize = 0;
            buttonPlayLocal.FlatStyle = FlatStyle.Flat;
            buttonPlayLocal.ForeColor = Color.LightGray;
            buttonPlayLocal.Location = new Point(0, 0);
            buttonPlayLocal.Name = "buttonPlayLocal";
            buttonPlayLocal.Padding = new Padding(90, 0, 0, 0);
            buttonPlayLocal.Size = new Size(309, 66);
            buttonPlayLocal.TabIndex = 1;
            buttonPlayLocal.Text = "Local";
            buttonPlayLocal.TextAlign = ContentAlignment.MiddleLeft;
            buttonPlayLocal.UseVisualStyleBackColor = true;
            buttonPlayLocal.Click += buttonPlayLocal_Click;
            // 
            // buttonPlay
            // 
            buttonPlay.Dock = DockStyle.Top;
            buttonPlay.FlatAppearance.BorderSize = 0;
            buttonPlay.FlatStyle = FlatStyle.Flat;
            buttonPlay.ForeColor = Color.Gainsboro;
            buttonPlay.Location = new Point(0, 528);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Padding = new Padding(30, 0, 0, 0);
            buttonPlay.Size = new Size(309, 66);
            buttonPlay.TabIndex = 2;
            buttonPlay.Text = "Play";
            buttonPlay.TextAlign = ContentAlignment.MiddleLeft;
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            buttonPlay.MouseLeave += buttonPlay_MouseLeave;
            buttonPlay.MouseHover += buttonPlay_MouseHover;
            // 
            // panelAccountSubmenu
            // 
            panelAccountSubmenu.BackColor = Color.FromArgb(35, 32, 39);
            panelAccountSubmenu.Controls.Add(buttonAccountSettings);
            panelAccountSubmenu.Controls.Add(buttonAccountStatistics);
            panelAccountSubmenu.Dock = DockStyle.Top;
            panelAccountSubmenu.Location = new Point(0, 393);
            panelAccountSubmenu.Name = "panelAccountSubmenu";
            panelAccountSubmenu.Size = new Size(309, 135);
            panelAccountSubmenu.TabIndex = 1;
            // 
            // buttonAccountSettings
            // 
            buttonAccountSettings.Dock = DockStyle.Top;
            buttonAccountSettings.FlatAppearance.BorderSize = 0;
            buttonAccountSettings.FlatStyle = FlatStyle.Flat;
            buttonAccountSettings.ForeColor = Color.LightGray;
            buttonAccountSettings.Location = new Point(0, 66);
            buttonAccountSettings.Name = "buttonAccountSettings";
            buttonAccountSettings.Padding = new Padding(90, 0, 0, 0);
            buttonAccountSettings.Size = new Size(309, 66);
            buttonAccountSettings.TabIndex = 1;
            buttonAccountSettings.Text = "Settings";
            buttonAccountSettings.TextAlign = ContentAlignment.MiddleLeft;
            buttonAccountSettings.UseVisualStyleBackColor = true;
            buttonAccountSettings.Click += buttonAccountSettings_Click;
            // 
            // buttonAccountStatistics
            // 
            buttonAccountStatistics.Dock = DockStyle.Top;
            buttonAccountStatistics.FlatAppearance.BorderSize = 0;
            buttonAccountStatistics.FlatStyle = FlatStyle.Flat;
            buttonAccountStatistics.ForeColor = Color.LightGray;
            buttonAccountStatistics.Location = new Point(0, 0);
            buttonAccountStatistics.Name = "buttonAccountStatistics";
            buttonAccountStatistics.Padding = new Padding(90, 0, 0, 0);
            buttonAccountStatistics.Size = new Size(309, 66);
            buttonAccountStatistics.TabIndex = 0;
            buttonAccountStatistics.Text = "Statistics";
            buttonAccountStatistics.TextAlign = ContentAlignment.MiddleLeft;
            buttonAccountStatistics.UseVisualStyleBackColor = true;
            buttonAccountStatistics.Click += buttonAccountStatistics_Click;
            // 
            // buttonAccount
            // 
            buttonAccount.BackColor = Color.FromArgb(11, 7, 17);
            buttonAccount.Dock = DockStyle.Top;
            buttonAccount.FlatAppearance.BorderSize = 0;
            buttonAccount.FlatStyle = FlatStyle.Flat;
            buttonAccount.ForeColor = Color.Gainsboro;
            buttonAccount.Location = new Point(0, 327);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Padding = new Padding(30, 0, 0, 0);
            buttonAccount.Size = new Size(309, 66);
            buttonAccount.TabIndex = 1;
            buttonAccount.Text = "Account";
            buttonAccount.TextAlign = ContentAlignment.MiddleLeft;
            buttonAccount.UseVisualStyleBackColor = false;
            buttonAccount.Click += buttonAccount_Click;
            buttonAccount.MouseLeave += buttonAccount_MouseLeave;
            buttonAccount.MouseHover += buttonAccount_MouseHover;
            // 
            // panelUser
            // 
            panelUser.Controls.Add(labelUsername);
            panelUser.Controls.Add(pictureBoxUser);
            panelUser.Dock = DockStyle.Top;
            panelUser.Location = new Point(0, 0);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(309, 327);
            panelUser.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.None;
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(93, 235);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(122, 59);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "label";
            labelUsername.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Image = (Image)resources.GetObject("pictureBoxUser.Image");
            pictureBoxUser.Location = new Point(61, 44);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(183, 188);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUser.TabIndex = 0;
            pictureBoxUser.TabStop = false;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(56, 56, 56);
            panelChildForm.Controls.Add(pictureBoxChessImage);
            panelChildForm.Controls.Add(pictureBoxLogo);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(309, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1260, 1064);
            panelChildForm.TabIndex = 1;
            // 
            // pictureBoxChessImage
            // 
            pictureBoxChessImage.Anchor = AnchorStyles.None;
            pictureBoxChessImage.Image = (Image)resources.GetObject("pictureBoxChessImage.Image");
            pictureBoxChessImage.Location = new Point(290, 456);
            pictureBoxChessImage.Name = "pictureBoxChessImage";
            pictureBoxChessImage.Size = new Size(672, 297);
            pictureBoxChessImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxChessImage.TabIndex = 1;
            pictureBoxChessImage.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(255, 261);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(730, 195);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 59, 53);
            ClientSize = new Size(1569, 1064);
            Controls.Add(panelChildForm);
            Controls.Add(panelSideBar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimumSize = new Size(1351, 892);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHESS - Main Menu";
            Load += MainMenu_Load;
            panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSmallLogo).EndInit();
            panelPlaySubmenu.ResumeLayout(false);
            panelAccountSubmenu.ResumeLayout(false);
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxChessImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Label labelUsername;
        public Panel panelUser;

        private Panel panelAccountSubmenu;
        private Panel panelSideBar;
        private Button buttonAccount;
        private Button buttonAccountSettings;
        private Button buttonAccountStatistics;
        private Panel panelPlaySubmenu;
        private Button buttonPlayLocal;
        private Button buttonPlay;
        private Button buttonPuzzles;
        private Button buttonPlayComputer;
        private PictureBox pictureBoxChessImage;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxUser;
        private Panel panelUsername;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxSmallLogo;
        private Button buttonAdjourned;
        public static Panel panelChildForm;
    }
}