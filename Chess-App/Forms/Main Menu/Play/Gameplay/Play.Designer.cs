namespace ChessApp
{
    partial class Play
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
            components = new System.ComponentModel.Container();
            panelBoard = new Panel();
            labelPlayerTurn = new Label();
            labelWhiteTimer = new Label();
            labelBlackTimer = new Label();
            timer = new System.Windows.Forms.Timer(components);
            labelCheck = new Label();
            buttonAdjourn = new Button();
            buttonDraw = new Button();
            buttonResign = new Button();
            labelUser = new Label();
            labelAI = new Label();
            labelDifficulty = new Label();
            SuspendLayout();
            // 
            // panelBoard
            // 
            panelBoard.BackColor = Color.Gray;
            panelBoard.Location = new Point(18, 20);
            panelBoard.Name = "panelBoard";
            panelBoard.Size = new Size(948, 948);
            panelBoard.TabIndex = 1;
            // 
            // labelPlayerTurn
            // 
            labelPlayerTurn.AutoSize = true;
            labelPlayerTurn.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlayerTurn.ForeColor = SystemColors.ButtonFace;
            labelPlayerTurn.Location = new Point(983, 20);
            labelPlayerTurn.Name = "labelPlayerTurn";
            labelPlayerTurn.Size = new Size(261, 59);
            labelPlayerTurn.TabIndex = 2;
            labelPlayerTurn.Text = "Turn: White";
            labelPlayerTurn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWhiteTimer
            // 
            labelWhiteTimer.AutoSize = true;
            labelWhiteTimer.BackColor = Color.CadetBlue;
            labelWhiteTimer.Font = new Font("Segoe UI", 22.125F, FontStyle.Bold, GraphicsUnit.Point);
            labelWhiteTimer.ForeColor = Color.White;
            labelWhiteTimer.Location = new Point(18, 974);
            labelWhiteTimer.Name = "labelWhiteTimer";
            labelWhiteTimer.Size = new Size(185, 78);
            labelWhiteTimer.TabIndex = 9;
            labelWhiteTimer.Text = "00:00";
            labelWhiteTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelBlackTimer
            // 
            labelBlackTimer.AutoSize = true;
            labelBlackTimer.BackColor = Color.CadetBlue;
            labelBlackTimer.Font = new Font("Segoe UI", 22.125F, FontStyle.Bold, GraphicsUnit.Point);
            labelBlackTimer.ForeColor = Color.White;
            labelBlackTimer.Location = new Point(781, 974);
            labelBlackTimer.Name = "labelBlackTimer";
            labelBlackTimer.Size = new Size(185, 78);
            labelBlackTimer.TabIndex = 10;
            labelBlackTimer.Text = "00:00";
            labelBlackTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // labelCheck
            // 
            labelCheck.AutoSize = true;
            labelCheck.Font = new Font("Segoe UI", 22.125F, FontStyle.Bold, GraphicsUnit.Point);
            labelCheck.ForeColor = SystemColors.ButtonFace;
            labelCheck.Location = new Point(377, 974);
            labelCheck.Name = "labelCheck";
            labelCheck.Size = new Size(221, 78);
            labelCheck.TabIndex = 12;
            labelCheck.Text = "CHECK";
            labelCheck.TextAlign = ContentAlignment.MiddleCenter;
            labelCheck.Visible = false;
            // 
            // buttonAdjourn
            // 
            buttonAdjourn.BackColor = SystemColors.HotTrack;
            buttonAdjourn.FlatAppearance.BorderSize = 0;
            buttonAdjourn.FlatStyle = FlatStyle.Flat;
            buttonAdjourn.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdjourn.ForeColor = Color.White;
            buttonAdjourn.Location = new Point(983, 355);
            buttonAdjourn.Name = "buttonAdjourn";
            buttonAdjourn.Size = new Size(250, 80);
            buttonAdjourn.TabIndex = 13;
            buttonAdjourn.Text = "Adjourn";
            buttonAdjourn.UseVisualStyleBackColor = false;
            buttonAdjourn.Click += buttonAdjourn_Click;
            // 
            // buttonDraw
            // 
            buttonDraw.BackColor = SystemColors.HotTrack;
            buttonDraw.FlatAppearance.BorderSize = 0;
            buttonDraw.FlatStyle = FlatStyle.Flat;
            buttonDraw.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDraw.ForeColor = Color.White;
            buttonDraw.Location = new Point(983, 456);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(250, 80);
            buttonDraw.TabIndex = 14;
            buttonDraw.Text = "Draw";
            buttonDraw.UseVisualStyleBackColor = false;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // buttonResign
            // 
            buttonResign.BackColor = Color.IndianRed;
            buttonResign.FlatAppearance.BorderSize = 0;
            buttonResign.FlatStyle = FlatStyle.Flat;
            buttonResign.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResign.ForeColor = Color.White;
            buttonResign.Location = new Point(983, 556);
            buttonResign.Name = "buttonResign";
            buttonResign.Size = new Size(250, 80);
            buttonResign.TabIndex = 15;
            buttonResign.Text = "Resign";
            buttonResign.UseVisualStyleBackColor = false;
            buttonResign.Click += buttonResign_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            labelUser.ForeColor = SystemColors.ButtonFace;
            labelUser.Location = new Point(983, 868);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(245, 50);
            labelUser.TabIndex = 16;
            labelUser.Text = "User: White  ";
            labelUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAI
            // 
            labelAI.AutoSize = true;
            labelAI.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            labelAI.ForeColor = SystemColors.ButtonFace;
            labelAI.Location = new Point(983, 918);
            labelAI.Name = "labelAI";
            labelAI.Size = new Size(184, 50);
            labelAI.TabIndex = 17;
            labelAI.Text = "AI: Black ";
            labelAI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDifficulty
            // 
            labelDifficulty.AutoSize = true;
            labelDifficulty.Font = new Font("Segoe UI", 22.125F, FontStyle.Bold, GraphicsUnit.Point);
            labelDifficulty.ForeColor = Color.LightGreen;
            labelDifficulty.Location = new Point(983, 20);
            labelDifficulty.Name = "labelDifficulty";
            labelDifficulty.Size = new Size(154, 78);
            labelDifficulty.TabIndex = 18;
            labelDifficulty.Text = "Easy";
            labelDifficulty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Play
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(1245, 1066);
            Controls.Add(labelDifficulty);
            Controls.Add(labelAI);
            Controls.Add(labelUser);
            Controls.Add(buttonResign);
            Controls.Add(buttonDraw);
            Controls.Add(buttonAdjourn);
            Controls.Add(labelCheck);
            Controls.Add(labelBlackTimer);
            Controls.Add(labelWhiteTimer);
            Controls.Add(labelPlayerTurn);
            Controls.Add(panelBoard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Play";
            Text = "PlayLocal";
            Load += PlayLocal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Panel panelBoard;
        public Label labelPlayerTurn;
        public Label labelWhiteTimer;
        public Label labelBlackTimer;
        public System.Windows.Forms.Timer timer;
        public Label labelCheck;
        private Button buttonAdjourn;
        private Button buttonDraw;
        private Button buttonResign;
        public Label labelUser;
        public Label labelAI;
        public Label labelDifficulty;
    }
}