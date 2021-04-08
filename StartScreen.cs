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
    public partial class StartScreen : Form
    {


        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadGame(object sender, EventArgs e)
        {
            Form1 gameWindow = new Form1();
            gameWindow.Show();
            this.Hide();
        }

        private void LoadHelp(object sender, EventArgs e)
        {
            Help helpWindow = new Help();
            helpWindow.Show();
            this.Hide();
        }

        private void CloseStartScreen(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
