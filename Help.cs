﻿using System;
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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartScreen StartScreen = new StartScreen();
            StartScreen.Show();
            this.Hide();
        }

        private void CloseHelpScreen(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
