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
    public partial class snake : Form
    {
        const int position_x = 200, position_y = 20, row = 20, column = 20, width = 20, height = 20;
        const int snake_init_length = 5, snake_row = 10, snake_length = row * column + 100, snake_add = 5;
        Color snake_body_color = Color.White;
        Color snake_head_color = Color.Red;
        Color background_color = Color.Black;
        Color bonus_color = Color.Red;
        int R = 255, G = 255, B = 255;
        Label[,] grids = new Label[row, column];
        Point[] snake_q = new Point[snake_length];
        Point bonus = new Point();
        int snake_head, snake_tail, snake_dir, snake_move = 1, game_mode = 1, score = 0;
        Random rander = new Random(System.DateTime.Now.Millisecond);

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false; button1.Visible = false;
            button1.Text = "重新開始";
            gmae_init();
            timer1.Enabled = true;
        }

        public snake()
        {
            InitializeComponent();
            this.KeyPreview = true;
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                {
                    grids[i, j] = new Label();
                    grids[i, j].Width = width; grids[i, j].Height = height;
                    grids[i, j].BackColor = background_color;
                    grids[i, j].Left = j * width + position_x;
                    grids[i, j].Top = i * height + position_y;
                    grids[i, j].Visible = true;
                    this.Controls.Add(grids[i, j]);
                }
            label1.Text = "遊戲說明\n點擊左上方開始遊戲\nW:轉向上方\nA:轉向左邊\nS:轉向後面\nD:轉向右邊\nP:暫停遊戲\n分數越高貪食蛇速度越快喔!!";
            label1.Visible = true;
            label2.Text = "分數:";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int y = snake_q[snake_head].Y, x = snake_q[snake_head].X;

            if (++snake_head == snake_length) snake_head = 0;

            snake_q[snake_head].Y = y; snake_q[snake_head].X = x;

            switch (snake_dir)
            {
                case 1:
                    if (--snake_q[snake_head].Y < 0) snake_q[snake_head].Y = row - 1;
                    break;
                case 2:
                    if (++snake_q[snake_head].Y >= row) snake_q[snake_head].Y = 0;
                    break;
                case 3:
                    if (--snake_q[snake_head].X < 0) snake_q[snake_head].X = column - 1;
                    break;
                case 4:
                    if (++snake_q[snake_head].X >= column) snake_q[snake_head].X = 0;
                    break;
            }
            grids[snake_q[snake_head].Y, snake_q[snake_head].X].BackColor = snake_head_color;
            grids[y, x].BackColor = snake_body_color;

            if (inside_snake(1, bonus.X, bonus.Y))
            {
                new_bonus();
                snake_move += snake_add;
                score += 100;
                if (timer1.Interval > 5)
                {
                    timer1.Interval -= 5;
                }
                label2.Text = "分數:" + score;
                if (R > 0) { R -= 8; if (R < 0) R = 0; }
                else { G -= 8; if (G < 0) G = 0; }
                snake_body_color = Color.FromArgb(R, G, B);
            }

            if (inside_snake(0, snake_q[snake_head].X, snake_q[snake_head].Y))
            {
                timer1.Enabled = false;
                draw_snake();
                label1.Text = "遊戲結束";
                label1.Visible = true;
                button1.Enabled = true; button1.Visible = true;
                return;
            }
            if (snake_move == 1)
            {
                grids[snake_q[snake_tail].Y, snake_q[snake_tail].X].BackColor = background_color;
                if (++snake_tail == snake_length) snake_tail = 0;
            }
            else
                snake_move--;
        }

        void gmae_init()
        {
            label1.Text = "遊戲說明\n點擊左上方開始遊戲\nW:轉向上方\nA:轉向左邊\nS:轉向後面\nD:轉向右邊\nP:暫停遊戲\n分數越高貪食蛇速度越快喔!!";
            snake_body_color = Color.White;
            R = G = B = 255;

            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    grids[i, j].BackColor = background_color;

            for (int i = 0; i < snake_init_length; i++)
            {
                snake_q[i].Y = snake_row; snake_q[i].X = i;
                grids[snake_row, i].BackColor = snake_body_color;
            }
            snake_head = snake_init_length - 1; snake_tail = 0;
            grids[snake_q[snake_head].Y, snake_q[snake_head].X].BackColor = snake_head_color;

            do { snake_dir = rander.Next(0, 4) + 1; } while (snake_dir == 3);

            game_mode = 1; snake_move = 1; score = 0;
            label2.Text = "分數:" + score;
            new_bonus();
        }
        void new_bonus()
        {
            do
            {
                bonus.X = rander.Next(0, row);
                bonus.Y = rander.Next(0, column);
            } while (inside_snake(1, bonus.X, bonus.Y));
            grids[bonus.Y, bonus.X].BackColor = bonus_color;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) { if (snake_dir != 2) snake_dir = 1; }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) { if (snake_dir != 1) snake_dir = 2; }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) { if (snake_dir != 4) snake_dir = 3; }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) { if (snake_dir != 3) snake_dir = 4; }

            if (e.KeyCode == Keys.P)
            {
                if (game_mode == 1) { game_mode = 0; timer1.Enabled = false; }
                else { game_mode = 1; timer1.Enabled = true; }
            }
        }
        bool inside_snake(int mode, int x, int y)
        { // mode:0 => head exclusive, 1=> head inclusive
            int s, e;
            s = snake_head; e = snake_tail;
            if (mode == 1) { if (x == snake_q[s].X && y == snake_q[s].Y) return true; }

            do
            {
                if (--s == -1) s = snake_length - 1;
                if (x == snake_q[s].X && y == snake_q[s].Y) return true;

            } while (s != e);

            return false;
        }

        void draw_snake()
        {
            int s, e;
            s = snake_head; e = snake_tail;
            do
            {
                if (--s == -1) s = snake_length - 1;

                grids[snake_q[s].Y, snake_q[s].X].BackColor = snake_head_color;

            } while (s != e);

            grids[snake_q[snake_head].Y, snake_q[snake_head].X].BackColor = Color.Blue;
        }
        private void snake_Load(object sender, EventArgs e)
        {

        }
    }
}
