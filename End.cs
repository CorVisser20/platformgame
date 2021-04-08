using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformGame
{
    public partial class End : Form
    {
        int score = GameProps.Coins;
        int playerHealth = GameProps.Health;

        public End()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            Score.Text = "Coins: " + score;
            healthBar.Value = GameProps.Health;
        }
    }
}
