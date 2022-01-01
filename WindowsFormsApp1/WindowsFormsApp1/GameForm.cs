using System;
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
        public GameForm()
        {
            InitializeComponent();
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
    }
}
