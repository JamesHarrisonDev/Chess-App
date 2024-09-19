namespace ChessApp.Forms.Main_Menu.Play.Computer_Play
{
    partial class PlayComputerSettings
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
            labellDifficulty = new Label();
            panelDifficulty = new Panel();
            hScrollBarDifficulty = new HScrollBar();
            labelDifficultyValue = new Label();
            buttonPlay = new Button();
            labelPlayAs = new Label();
            panelPlayAs = new Panel();
            checkBoxRandom = new CheckBox();
            checkBoxBlack = new CheckBox();
            checkBoxWhite = new CheckBox();
            panelDifficulty.SuspendLayout();
            panelPlayAs.SuspendLayout();
            SuspendLayout();
            // 
            // labellDifficulty
            // 
            labellDifficulty.Anchor = AnchorStyles.None;
            labellDifficulty.AutoSize = true;
            labellDifficulty.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            labellDifficulty.ForeColor = Color.White;
            labellDifficulty.Location = new Point(202, 427);
            labellDifficulty.Name = "labellDifficulty";
            labellDifficulty.Size = new Size(184, 50);
            labellDifficulty.TabIndex = 5;
            labellDifficulty.Text = "Difficulty";
            // 
            // panelDifficulty
            // 
            panelDifficulty.Anchor = AnchorStyles.None;
            panelDifficulty.BackColor = Color.FromArgb(70, 70, 70);
            panelDifficulty.Controls.Add(hScrollBarDifficulty);
            panelDifficulty.Controls.Add(labelDifficultyValue);
            panelDifficulty.Location = new Point(202, 480);
            panelDifficulty.Name = "panelDifficulty";
            panelDifficulty.Size = new Size(817, 155);
            panelDifficulty.TabIndex = 4;
            // 
            // hScrollBarDifficulty
            // 
            hScrollBarDifficulty.LargeChange = 6;
            hScrollBarDifficulty.Location = new Point(25, 69);
            hScrollBarDifficulty.Maximum = 7;
            hScrollBarDifficulty.Name = "hScrollBarDifficulty";
            hScrollBarDifficulty.Size = new Size(768, 59);
            hScrollBarDifficulty.TabIndex = 2;
            hScrollBarDifficulty.ValueChanged += hScrollBarTimer_ValueChanged;
            // 
            // labelDifficultyValue
            // 
            labelDifficultyValue.AutoSize = true;
            labelDifficultyValue.BackColor = Color.FromArgb(70, 70, 70);
            labelDifficultyValue.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            labelDifficultyValue.ForeColor = Color.LightGreen;
            labelDifficultyValue.Location = new Point(25, 20);
            labelDifficultyValue.Name = "labelDifficultyValue";
            labelDifficultyValue.Size = new Size(147, 37);
            labelDifficultyValue.TabIndex = 0;
            labelDifficultyValue.Text = "Value: Easy";
            // 
            // buttonPlay
            // 
            buttonPlay.BackColor = SystemColors.HotTrack;
            buttonPlay.FlatAppearance.BorderSize = 0;
            buttonPlay.FlatStyle = FlatStyle.Flat;
            buttonPlay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPlay.ForeColor = Color.White;
            buttonPlay.Location = new Point(213, 786);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(817, 69);
            buttonPlay.TabIndex = 7;
            buttonPlay.Text = "Play";
            buttonPlay.UseVisualStyleBackColor = false;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // labelPlayAs
            // 
            labelPlayAs.Anchor = AnchorStyles.None;
            labelPlayAs.AutoSize = true;
            labelPlayAs.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlayAs.ForeColor = Color.White;
            labelPlayAs.Location = new Point(202, 147);
            labelPlayAs.Name = "labelPlayAs";
            labelPlayAs.Size = new Size(148, 50);
            labelPlayAs.TabIndex = 9;
            labelPlayAs.Text = "Play As";
            // 
            // panelPlayAs
            // 
            panelPlayAs.Anchor = AnchorStyles.None;
            panelPlayAs.BackColor = Color.FromArgb(70, 70, 70);
            panelPlayAs.Controls.Add(checkBoxRandom);
            panelPlayAs.Controls.Add(checkBoxBlack);
            panelPlayAs.Controls.Add(checkBoxWhite);
            panelPlayAs.Location = new Point(202, 200);
            panelPlayAs.Name = "panelPlayAs";
            panelPlayAs.Size = new Size(817, 155);
            panelPlayAs.TabIndex = 8;
            // 
            // checkBoxRandom
            // 
            checkBoxRandom.AutoSize = true;
            checkBoxRandom.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxRandom.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxRandom.ForeColor = SystemColors.ActiveBorder;
            checkBoxRandom.Location = new Point(567, 48);
            checkBoxRandom.Name = "checkBoxRandom";
            checkBoxRandom.Size = new Size(226, 63);
            checkBoxRandom.TabIndex = 3;
            checkBoxRandom.Text = "Random";
            checkBoxRandom.UseVisualStyleBackColor = true;
            checkBoxRandom.CheckedChanged += checkBoxRandom_CheckedChanged;
            // 
            // checkBoxBlack
            // 
            checkBoxBlack.AutoSize = true;
            checkBoxBlack.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxBlack.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxBlack.ForeColor = SystemColors.ActiveBorder;
            checkBoxBlack.Location = new Point(311, 48);
            checkBoxBlack.Name = "checkBoxBlack";
            checkBoxBlack.Size = new Size(165, 63);
            checkBoxBlack.TabIndex = 2;
            checkBoxBlack.Text = "Black";
            checkBoxBlack.UseVisualStyleBackColor = true;
            checkBoxBlack.CheckedChanged += checkBoxBlack_CheckedChanged;
            // 
            // checkBoxWhite
            // 
            checkBoxWhite.AutoSize = true;
            checkBoxWhite.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxWhite.Checked = true;
            checkBoxWhite.CheckState = CheckState.Checked;
            checkBoxWhite.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxWhite.ForeColor = SystemColors.ButtonFace;
            checkBoxWhite.Location = new Point(25, 48);
            checkBoxWhite.Name = "checkBoxWhite";
            checkBoxWhite.Size = new Size(178, 63);
            checkBoxWhite.TabIndex = 1;
            checkBoxWhite.Text = "White";
            checkBoxWhite.UseVisualStyleBackColor = true;
            checkBoxWhite.CheckedChanged += checkBoxWhite_CheckedChanged;
            // 
            // PlayComputerSettings
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(1234, 993);
            Controls.Add(labelPlayAs);
            Controls.Add(panelPlayAs);
            Controls.Add(buttonPlay);
            Controls.Add(labellDifficulty);
            Controls.Add(panelDifficulty);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlayComputerSettings";
            Text = "PlayComputerSettings";
            FormClosing += PlayComputerSettings_FormClosing;
            panelDifficulty.ResumeLayout(false);
            panelDifficulty.PerformLayout();
            panelPlayAs.ResumeLayout(false);
            panelPlayAs.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labellDifficulty;
        private Panel panelDifficulty;
        private Label labelDifficultyValue;
        private Button buttonPlay;
        private Label labelPlayAs;
        private Panel panelPlayAs;
        public static HScrollBar hScrollBarDifficulty;
        public static CheckBox checkBoxRandom;
        public static CheckBox checkBoxBlack;
        public static CheckBox checkBoxWhite;
    }
}