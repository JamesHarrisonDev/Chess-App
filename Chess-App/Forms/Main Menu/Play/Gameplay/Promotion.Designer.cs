namespace ChessApp.Forms.Main_Menu.Play
{
    partial class Promotion
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
            labelPromotion = new Label();
            labelPromotionPrompt = new Label();
            buttonQueen = new Button();
            buttonRook = new Button();
            buttonKnight = new Button();
            buttonBishop = new Button();
            SuspendLayout();
            // 
            // labelPromotion
            // 
            labelPromotion.AutoSize = true;
            labelPromotion.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            labelPromotion.ForeColor = SystemColors.ButtonFace;
            labelPromotion.Location = new Point(155, 31);
            labelPromotion.Name = "labelPromotion";
            labelPromotion.Size = new Size(297, 71);
            labelPromotion.TabIndex = 9;
            labelPromotion.Text = "Promotion";
            // 
            // labelPromotionPrompt
            // 
            labelPromotionPrompt.AutoSize = true;
            labelPromotionPrompt.BackColor = SystemColors.ControlDarkDark;
            labelPromotionPrompt.ForeColor = Color.Gainsboro;
            labelPromotionPrompt.Location = new Point(114, 102);
            labelPromotionPrompt.Name = "labelPromotionPrompt";
            labelPromotionPrompt.Size = new Size(352, 64);
            labelPromotionPrompt.TabIndex = 14;
            labelPromotionPrompt.Text = "What piece would you like your\r\npawn to be promoted to?\r\n";
            labelPromotionPrompt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonQueen
            // 
            buttonQueen.BackColor = SystemColors.Highlight;
            buttonQueen.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonQueen.ForeColor = SystemColors.HighlightText;
            buttonQueen.Location = new Point(78, 205);
            buttonQueen.Name = "buttonQueen";
            buttonQueen.Size = new Size(196, 64);
            buttonQueen.TabIndex = 15;
            buttonQueen.Text = "Queen";
            buttonQueen.UseVisualStyleBackColor = false;
            buttonQueen.Click += buttonQueen_Click;
            // 
            // buttonRook
            // 
            buttonRook.BackColor = SystemColors.Highlight;
            buttonRook.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRook.ForeColor = SystemColors.HighlightText;
            buttonRook.Location = new Point(336, 205);
            buttonRook.Name = "buttonRook";
            buttonRook.Size = new Size(196, 64);
            buttonRook.TabIndex = 16;
            buttonRook.Text = "Rook";
            buttonRook.UseVisualStyleBackColor = false;
            buttonRook.Click += buttonRook_Click;
            // 
            // buttonKnight
            // 
            buttonKnight.BackColor = SystemColors.Highlight;
            buttonKnight.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonKnight.ForeColor = SystemColors.HighlightText;
            buttonKnight.Location = new Point(78, 315);
            buttonKnight.Name = "buttonKnight";
            buttonKnight.Size = new Size(196, 64);
            buttonKnight.TabIndex = 17;
            buttonKnight.Text = "Knight";
            buttonKnight.UseVisualStyleBackColor = false;
            buttonKnight.Click += buttonKnight_Click;
            // 
            // buttonBishop
            // 
            buttonBishop.BackColor = SystemColors.Highlight;
            buttonBishop.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBishop.ForeColor = SystemColors.HighlightText;
            buttonBishop.Location = new Point(336, 315);
            buttonBishop.Name = "buttonBishop";
            buttonBishop.Size = new Size(196, 64);
            buttonBishop.TabIndex = 18;
            buttonBishop.Text = "Bishop";
            buttonBishop.UseVisualStyleBackColor = false;
            buttonBishop.Click += buttonBishop_Click;
            // 
            // Promotion
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(623, 450);
            Controls.Add(buttonBishop);
            Controls.Add(buttonKnight);
            Controls.Add(buttonRook);
            Controls.Add(buttonQueen);
            Controls.Add(labelPromotionPrompt);
            Controls.Add(labelPromotion);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Promotion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHESS - Promotion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPromotion;
        private Label labelPromotionPrompt;
        private Button buttonQueen;
        private Button buttonRook;
        private Button buttonKnight;
        private Button buttonBishop;
    }
}