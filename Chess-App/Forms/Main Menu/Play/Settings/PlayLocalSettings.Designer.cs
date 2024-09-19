namespace ChessApp.Forms.Main_Menu.Play.Local_Play
{
    partial class PlayLocalSettings
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
            labelTimer = new Label();
            panelTimer = new Panel();
            hScrollBarTimer = new HScrollBar();
            labelTimerValue = new Label();
            labelIncrement = new Label();
            panelIncrement = new Panel();
            hScrollBarIncrement = new HScrollBar();
            labelIncrementValue = new Label();
            buttonPlay = new Button();
            panelTimer.SuspendLayout();
            panelIncrement.SuspendLayout();
            SuspendLayout();
            // 
            // labelTimer
            // 
            labelTimer.Anchor = AnchorStyles.None;
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            labelTimer.ForeColor = Color.White;
            labelTimer.Location = new Point(202, 147);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(124, 50);
            labelTimer.TabIndex = 3;
            labelTimer.Text = "Timer";
            // 
            // panelTimer
            // 
            panelTimer.Anchor = AnchorStyles.None;
            panelTimer.BackColor = Color.FromArgb(70, 70, 70);
            panelTimer.Controls.Add(hScrollBarTimer);
            panelTimer.Controls.Add(labelTimerValue);
            panelTimer.Location = new Point(202, 200);
            panelTimer.Name = "panelTimer";
            panelTimer.Size = new Size(817, 155);
            panelTimer.TabIndex = 2;
            // 
            // hScrollBarTimer
            // 
            hScrollBarTimer.Location = new Point(25, 69);
            hScrollBarTimer.Maximum = 69;
            hScrollBarTimer.Name = "hScrollBarTimer";
            hScrollBarTimer.Size = new Size(768, 59);
            hScrollBarTimer.TabIndex = 2;
            hScrollBarTimer.ValueChanged += hScrollBarTimer_ValueChanged;
            // 
            // labelTimerValue
            // 
            labelTimerValue.AutoSize = true;
            labelTimerValue.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimerValue.ForeColor = SystemColors.ActiveBorder;
            labelTimerValue.Location = new Point(25, 20);
            labelTimerValue.Name = "labelTimerValue";
            labelTimerValue.Size = new Size(131, 37);
            labelTimerValue.TabIndex = 0;
            labelTimerValue.Text = "Value: Off";
            // 
            // labelIncrement
            // 
            labelIncrement.Anchor = AnchorStyles.None;
            labelIncrement.AutoSize = true;
            labelIncrement.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            labelIncrement.ForeColor = Color.White;
            labelIncrement.Location = new Point(202, 427);
            labelIncrement.Name = "labelIncrement";
            labelIncrement.Size = new Size(199, 50);
            labelIncrement.TabIndex = 5;
            labelIncrement.Text = "Increment";
            // 
            // panelIncrement
            // 
            panelIncrement.Anchor = AnchorStyles.None;
            panelIncrement.BackColor = Color.FromArgb(70, 70, 70);
            panelIncrement.Controls.Add(hScrollBarIncrement);
            panelIncrement.Controls.Add(labelIncrementValue);
            panelIncrement.Location = new Point(202, 480);
            panelIncrement.Name = "panelIncrement";
            panelIncrement.Size = new Size(817, 155);
            panelIncrement.TabIndex = 4;
            // 
            // hScrollBarIncrement
            // 
            hScrollBarIncrement.Enabled = false;
            hScrollBarIncrement.Location = new Point(25, 69);
            hScrollBarIncrement.Maximum = 69;
            hScrollBarIncrement.Name = "hScrollBarIncrement";
            hScrollBarIncrement.Size = new Size(768, 59);
            hScrollBarIncrement.TabIndex = 2;
            hScrollBarIncrement.ValueChanged += hScrollBarIncrement_ValueChanged;
            // 
            // labelIncrementValue
            // 
            labelIncrementValue.AutoSize = true;
            labelIncrementValue.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            labelIncrementValue.ForeColor = SystemColors.ActiveBorder;
            labelIncrementValue.Location = new Point(25, 20);
            labelIncrementValue.Name = "labelIncrementValue";
            labelIncrementValue.Size = new Size(131, 37);
            labelIncrementValue.TabIndex = 0;
            labelIncrementValue.Text = "Value: Off";
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
            buttonPlay.TabIndex = 6;
            buttonPlay.Text = "Play";
            buttonPlay.UseVisualStyleBackColor = false;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // PlayLocalSettings
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(1234, 993);
            Controls.Add(buttonPlay);
            Controls.Add(labelIncrement);
            Controls.Add(panelIncrement);
            Controls.Add(labelTimer);
            Controls.Add(panelTimer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlayLocalSettings";
            Text = "PlayLocalSettings";
            FormClosing += PlayLocalSettings_FormClosing;
            panelTimer.ResumeLayout(false);
            panelTimer.PerformLayout();
            panelIncrement.ResumeLayout(false);
            panelIncrement.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTimer;
        private Panel panelTimer;
        private Button buttonSave;
        private Label labelTimerValue;
        private Label labelIncrement;
        private Panel panelIncrement;
        private Label labelIncrementValue;
        private Button buttonPlay;
        public static HScrollBar hScrollBarTimer;
        public static HScrollBar hScrollBarIncrement;
    }
}