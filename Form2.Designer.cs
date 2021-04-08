
namespace PlatformGame
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.background = new System.Windows.Forms.PictureBox();
            this.platform = new System.Windows.Forms.PictureBox();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.keyScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackgroundImage = global::PlatformGame.Properties.Resources.background;
            this.background.Location = new System.Drawing.Point(-3, -1);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(4000, 480);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // platform
            // 
            this.platform.BackgroundImage = global::PlatformGame.Properties.Resources.GrassMid;
            this.platform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.platform.Location = new System.Drawing.Point(-8, 445);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(101, 37);
            this.platform.TabIndex = 3;
            this.platform.TabStop = false;
            this.platform.Tag = "platform";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(8, 22);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(143, 13);
            this.healthBar.TabIndex = 10;
            this.healthBar.Tag = "healthBar";
            this.healthBar.Value = 100;
            // 
            // keyScore
            // 
            this.keyScore.AutoSize = true;
            this.keyScore.Location = new System.Drawing.Point(63, 4);
            this.keyScore.Name = "keyScore";
            this.keyScore.Size = new System.Drawing.Size(45, 13);
            this.keyScore.TabIndex = 8;
            this.keyScore.Tag = "keyScore";
            this.keyScore.Text = "Key: No";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Location = new System.Drawing.Point(8, 5);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(45, 13);
            this.txtScore.TabIndex = 9;
            this.txtScore.Tag = "txtScore";
            this.txtScore.Text = "Coins: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player.Image = global::PlatformGame.Properties.Resources.character_idle;
            this.player.Location = new System.Drawing.Point(12, 389);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(47, 57);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 11;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.Controls.Add(this.player);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.keyScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.background);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseGame);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Label keyScore;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox player;
    }
}