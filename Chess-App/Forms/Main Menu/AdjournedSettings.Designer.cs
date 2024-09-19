namespace ChessApp.Forms.Main_Menu
{
    partial class AdjournedSettings
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
            labelNoAdjourned = new Label();
            labelAdjournedSettings = new Label();
            labelSettings = new Label();
            buttonPlay = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // labelNoAdjourned
            // 
            labelNoAdjourned.Anchor = AnchorStyles.None;
            labelNoAdjourned.AutoSize = true;
            labelNoAdjourned.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            labelNoAdjourned.ForeColor = Color.White;
            labelNoAdjourned.Location = new Point(110, 415);
            labelNoAdjourned.Name = "labelNoAdjourned";
            labelNoAdjourned.Size = new Size(1002, 142);
            labelNoAdjourned.TabIndex = 4;
            labelNoAdjourned.Text = "No adjourned board is currently saved \r\nfor this account";
            labelNoAdjourned.TextAlign = ContentAlignment.MiddleCenter;
            labelNoAdjourned.Visible = false;
            // 
            // labelAdjournedSettings
            // 
            labelAdjournedSettings.Anchor = AnchorStyles.None;
            labelAdjournedSettings.AutoSize = true;
            labelAdjournedSettings.Font = new Font("Segoe UI", 25.875F, FontStyle.Bold, GraphicsUnit.Point);
            labelAdjournedSettings.ForeColor = Color.White;
            labelAdjournedSettings.Location = new Point(164, 101);
            labelAdjournedSettings.Name = "labelAdjournedSettings";
            labelAdjournedSettings.Size = new Size(873, 92);
            labelAdjournedSettings.TabIndex = 5;
            labelAdjournedSettings.Text = "Adjourned Game Settings";
            labelAdjournedSettings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSettings
            // 
            labelSettings.Anchor = AnchorStyles.None;
            labelSettings.AutoSize = true;
            labelSettings.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            labelSettings.ForeColor = Color.White;
            labelSettings.Location = new Point(318, 209);
            labelSettings.Name = "labelSettings";
            labelSettings.Size = new Size(574, 74);
            labelSettings.TabIndex = 6;
            labelSettings.Text = "Game Type: Local Play";
            labelSettings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonPlay
            // 
            buttonPlay.BackColor = SystemColors.HotTrack;
            buttonPlay.FlatAppearance.BorderSize = 0;
            buttonPlay.FlatStyle = FlatStyle.Flat;
            buttonPlay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPlay.ForeColor = Color.White;
            buttonPlay.Location = new Point(211, 714);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(817, 69);
            buttonPlay.TabIndex = 8;
            buttonPlay.Text = "Play";
            buttonPlay.UseVisualStyleBackColor = false;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(211, 816);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(817, 69);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // AdjournedSettings
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(1219, 995);
            Controls.Add(buttonDelete);
            Controls.Add(buttonPlay);
            Controls.Add(labelSettings);
            Controls.Add(labelAdjournedSettings);
            Controls.Add(labelNoAdjourned);
            Name = "AdjournedSettings";
            Text = "AdjournedSettings";
            Load += AdjournedSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNoAdjourned;
        private Label labelAdjournedSettings;
        private Label labelSettings;
        private Button buttonPlay;
        private Button buttonDelete;
    }
}