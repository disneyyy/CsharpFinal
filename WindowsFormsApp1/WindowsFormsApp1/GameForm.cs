﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GameForm : Form
    {
        snake snake;
        Blocks blocks;
        Piano piano;

        public GameForm()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"..\..\Resources\GameBackground.jpeg");
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            game1.Text = "貪食蛇";
        }

        private void game1_Click(object sender, EventArgs e)
        {
            snake = new snake();
            snake.Show();
        }

        private void game3_Click(object sender, EventArgs e)
        {
            blocks = new Blocks();
            blocks.Show();
        }

        private void game2_Click(object sender, EventArgs e)
        {
            piano = new Piano();
            piano.Show();
        }

        private void game4_Click(object sender, EventArgs e)
        {
            Form f = new BreakoutClone();
            f.Show();
        }
    }
}
