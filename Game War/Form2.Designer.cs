namespace Game_War
{
    partial class Fmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmain));
            this.button1 = new System.Windows.Forms.Button();
            this.cardPicturePlayer1 = new System.Windows.Forms.PictureBox();
            this.cardPicturePlayer2 = new System.Windows.Forms.PictureBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.player1WinnerLabel = new System.Windows.Forms.Label();
            this.player2WinnerLabel = new System.Windows.Forms.Label();
            this.drawLabel = new System.Windows.Forms.Label();
            this.buttonReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicturePlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicturePlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 711);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cardPicturePlayer1
            // 
            this.cardPicturePlayer1.Location = new System.Drawing.Point(133, 309);
            this.cardPicturePlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardPicturePlayer1.Name = "cardPicturePlayer1";
            this.cardPicturePlayer1.Size = new System.Drawing.Size(193, 263);
            this.cardPicturePlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPicturePlayer1.TabIndex = 2;
            this.cardPicturePlayer1.TabStop = false;
            this.cardPicturePlayer1.Visible = false;
            // 
            // cardPicturePlayer2
            // 
            this.cardPicturePlayer2.Location = new System.Drawing.Point(837, 309);
            this.cardPicturePlayer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardPicturePlayer2.Name = "cardPicturePlayer2";
            this.cardPicturePlayer2.Size = new System.Drawing.Size(193, 263);
            this.cardPicturePlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPicturePlayer2.TabIndex = 3;
            this.cardPicturePlayer2.TabStop = false;
            this.cardPicturePlayer2.Visible = false;
            this.cardPicturePlayer2.Click += new System.EventHandler(this.cardPicturePlayer2_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(517, 551);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(138, 81);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // player1WinnerLabel
            // 
            this.player1WinnerLabel.AutoSize = true;
            this.player1WinnerLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.player1WinnerLabel.Location = new System.Drawing.Point(199, 202);
            this.player1WinnerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player1WinnerLabel.Name = "player1WinnerLabel";
            this.player1WinnerLabel.Size = new System.Drawing.Size(49, 16);
            this.player1WinnerLabel.TabIndex = 5;
            this.player1WinnerLabel.Text = "Winner";
            this.player1WinnerLabel.Visible = false;
            // 
            // player2WinnerLabel
            // 
            this.player2WinnerLabel.AutoSize = true;
            this.player2WinnerLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.player2WinnerLabel.Location = new System.Drawing.Point(904, 179);
            this.player2WinnerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player2WinnerLabel.Name = "player2WinnerLabel";
            this.player2WinnerLabel.Size = new System.Drawing.Size(49, 16);
            this.player2WinnerLabel.TabIndex = 6;
            this.player2WinnerLabel.Text = "Winner";
            this.player2WinnerLabel.Visible = false;
            // 
            // drawLabel
            // 
            this.drawLabel.AutoSize = true;
            this.drawLabel.BackColor = System.Drawing.Color.LawnGreen;
            this.drawLabel.Location = new System.Drawing.Point(559, 202);
            this.drawLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drawLabel.Name = "drawLabel";
            this.drawLabel.Size = new System.Drawing.Size(38, 16);
            this.drawLabel.TabIndex = 7;
            this.drawLabel.Text = "Draw";
            this.drawLabel.Visible = false;
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(1018, 739);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(138, 81);
            this.buttonReload.TabIndex = 8;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // Fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1164, 675);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.drawLabel);
            this.Controls.Add(this.player2WinnerLabel);
            this.Controls.Add(this.player1WinnerLabel);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.cardPicturePlayer2);
            this.Controls.Add(this.cardPicturePlayer1);
            this.Controls.Add(this.button1);
            this.Name = "Fmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fereastra de Joc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fmain_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardPicturePlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicturePlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox cardPicturePlayer1;
        private System.Windows.Forms.PictureBox cardPicturePlayer2;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label player1WinnerLabel;
        private System.Windows.Forms.Label player2WinnerLabel;
        private System.Windows.Forms.Label drawLabel;
        private System.Windows.Forms.Button buttonReload;
    }
}