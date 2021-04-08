using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PlatformGame
{
    public partial class Form3 : Form
    {

        bool goLeft, goRight, jumping;
        int jumpSpeed = 10;
        int jumpingDirection = 1;
        int force = 8;
        int score = GameProps.Coins;
        int playerSpeed = 5;
        int backgroundSpeed = 8;
        int enemy1Speed = 5;

        int playerHealth = GameProps.Health;

        // Sounds //
        WindowsMediaPlayer sound1 = new WindowsMediaPlayer();
        WindowsMediaPlayer sound2 = new WindowsMediaPlayer();
        WindowsMediaPlayer music = new WindowsMediaPlayer();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            music.URL = "music.mp3";
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                player.Image = Properties.Resources.character_idle_flip;
                goLeft = true;
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                player.Image = Properties.Resources.character_idle;
                goRight = true;
            }

            if (e.KeyCode == Keys.Space)
            {
                jumping = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (jumping == true)
            {
                jumping = false;
            }
        }

        private void CloseGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Coins: " + score;
            player.Top += jumpSpeed;

            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else
            {
                sound1.URL = "sound1.mp3";
                music.controls.stop();
                GameTimer.Stop();

                MessageBox.Show("You died. " + Environment.NewLine + "Click OK to play again.");
                RestartGame();
                sound1.controls.stop();
            }

            if (goLeft == true && player.Left > 60)
            {
                player.Left -= playerSpeed;
            }

            if (goRight == true && player.Left + (player.Width + 60) < this.ClientSize.Width)
            {
                player.Left += playerSpeed;
            }

            if (goLeft == true && background.Left < 0)
            {
                background.Left += backgroundSpeed;
                MoveGameElements("forward");
            }

            if (goRight == true && background.Left > -3072)
            {
                background.Left -= backgroundSpeed;
                MoveGameElements("back");
            }

            if (jumping == true)
            {
                if (force < 0)
                {
                    jumpSpeed = 10;
                    jumpingDirection = -1;
                }
                else if (force >= 8)
                {
                    jumpSpeed = -8;
                    jumpingDirection = 1;
                }
                force -= 1 * jumpingDirection;

            }
            else
            {
                jumpSpeed = 12;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && jumping == false)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                        jumpSpeed = 0;
                    }

                    x.BringToFront();
                }

                // When Player Touches Water Restart Game //
                if (x is PictureBox && (string)x.Tag == "platform_water")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop();
                        sound1.URL = "sound1.mp3";
                        music.controls.stop();
                        MessageBox.Show("You fell into the water and drowned. " + Environment.NewLine + "Click OK to play again.");
                        RestartGame();
                    }
                }

                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        sound2.URL = "sound2.mp3";
                        x.Visible = false;
                        score += 1;
                        GameProps.Coins = score;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "enemy1" || x is PictureBox && (string)x.Tag == "enemySaw")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 2;
                        GameProps.Health = playerHealth;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "door")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        End end = new End();
                        music.controls.stop();
                        end.Show();
                        GameTimer.Stop();
                        this.Hide();
                    }
                }

                // Move Enemy 1 //
                enemy1.Left -= enemy1Speed;

                if (enemy1.Left < pictureBox13.Left || enemy1.Left + enemy1.Width > pictureBox13.Left + pictureBox13.Width)
                {
                    enemy1Speed = -enemy1Speed;
                }
            }

            // If Player Falls Of The World Restart Game //
            if (player.Top + player.Height > this.ClientSize.Height)
            {
                GameTimer.Stop();
                MessageBox.Show("You fell of the world and died. " + Environment.NewLine + "Click OK to play again.");
                RestartGame();
            }
        }

        private void RestartGame()
        {
            Platformgame newWindow = new Platformgame();
            newWindow.Show();
            this.Hide();
        }

        private void MoveGameElements(string direction)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "key" || x is PictureBox && (string)x.Tag == "door" || x is PictureBox && (string)x.Tag == "test" || x is PictureBox && (string)x.Tag == "platform_water" || x is PictureBox && (string)x.Tag == "enemy1" || x is PictureBox && (string)x.Tag == "enemySaw" || x is PictureBox && (string)x.Tag == "coin")
                {
                    if (direction == "back")
                    {
                        x.Left -= backgroundSpeed;
                    }

                    if (direction == "forward")
                    {
                        x.Left += backgroundSpeed;
                    }
                }
            }
        }
    }
}
