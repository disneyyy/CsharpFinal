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
    public partial class Blocks : Form
    {
        Button[] enemy = new Button[8];
        Button background = new Button();
        Button player = new Button();
        Random rnd = new Random();
        int role = 0;
        int vis;
        int score;
        public Blocks()
        {
            InitializeComponent();
        }

        private void Blocks_Load(object sender, EventArgs e)
        {
            label3.Text = "Press A to go left\nPress D to go right\nPink block:     1 point\nYellow block: 5 point\nPurple block: deadly\n\nDon't let Pink blocks reach\nthe floor!";
            this.KeyPreview = true;
            background.SetBounds(179, 34, 41 * 8+1, 41 * 7+1);
            background.BackColor = Color.Black;
            background.FlatStyle = FlatStyle.Flat;
            background.FlatAppearance.MouseDownBackColor = background.BackColor;
            background.FlatAppearance.MouseOverBackColor = background.BackColor;

            player.SetBounds(180, 35+41*6, 40, 40);
            player.BackColor = Color.White;
            player.FlatStyle = FlatStyle.Flat;
            player.FlatAppearance.BorderSize = 0;
            player.FlatAppearance.MouseDownBackColor = player.BackColor;
            player.FlatAppearance.MouseOverBackColor = player.BackColor;
            Controls.Add(player);
            
            for (int i = 0; i < 8; i++)
            {
                enemy[i] = new Button();
                enemy[i].SetBounds(180+41*i, 35, 40, 40);
                enemy[i].FlatStyle = FlatStyle.Flat;
                enemy[i].FlatAppearance.BorderSize = 0;
                enemy[i].BackColor = Color.HotPink;
                enemy[i].FlatAppearance.MouseOverBackColor = enemy[i].BackColor;
                enemy[i].FlatAppearance.MouseDownBackColor = enemy[i].BackColor;
                enemy[i].Text = "";
                Controls.Add(enemy[i]);
                enemy[i].Visible = false;
            }
            Controls.Add(background);
        }
        private void generate()
        {
            vis = rnd.Next(8);
            int color = rnd.Next(6);
            enemy[vis].Visible = true;
            enemy[vis].Top = 35-41;
            if(role >= 35)
                if (color == 1)
                {
                    enemy[vis].BackColor = Color.Purple;
                    enemy[vis].FlatAppearance.MouseOverBackColor = enemy[vis].BackColor;
                    enemy[vis].FlatAppearance.MouseDownBackColor = enemy[vis].BackColor;
                    enemy[vis].Text = "X";
                }
                else if (color == 2)
                {
                    enemy[vis].BackColor = Color.Yellow;
                    enemy[vis].FlatAppearance.MouseOverBackColor = enemy[vis].BackColor;
                    enemy[vis].FlatAppearance.MouseDownBackColor = enemy[vis].BackColor;
                    enemy[vis].Text = "$";
                }
                else
                {
                    enemy[vis].BackColor = Color.HotPink;
                    enemy[vis].FlatAppearance.MouseOverBackColor = enemy[vis].BackColor;
                    enemy[vis].FlatAppearance.MouseDownBackColor = enemy[vis].BackColor;
                    enemy[vis].Text = "";
                }
        }
        private void reset()
        {
            timer1.Enabled = false;
            MessageBox.Show("Game Over!\n Score: " + score, "", MessageBoxButtons.OK);
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "" + role/7;
            if(role % 7 == 6 && role > 0)
            {
                if(enemy[vis].BackColor == Color.Purple && player.Left == enemy[vis].Left)
                {
                    enemy[vis].Top += 41;
                    player.Text = ":(";
                    player.BackColor = Color.MediumPurple;
                    reset();
                }
                else if (enemy[vis].BackColor == Color.HotPink && enemy[vis].Left == player.Left)
                {
                    score++;
                    labelScore.Text = "" + score;
                    enemy[vis].Visible = false;
                    enemy[vis].Top = 35 - 41;
                }
                else if (enemy[vis].BackColor == Color.Yellow && enemy[vis].Left == player.Left)
                {
                    score += 5;
                    labelScore.Text = "" + score;
                    enemy[vis].Visible = false;
                    enemy[vis].Top = 35 - 41;
                }
                else if (enemy[vis].BackColor == Color.HotPink && enemy[vis].Left != player.Left)
                {
                    //end game
                    enemy[vis].BackColor = Color.Red;
                    enemy[vis].FlatAppearance.MouseOverBackColor = enemy[vis].BackColor;
                    enemy[vis].FlatAppearance.MouseDownBackColor = enemy[vis].BackColor;
                    enemy[vis].Top += 41;
                    player.Text = ":<";
                    reset();
                }
                else if (enemy[vis].BackColor == Color.Purple && player.Left != enemy[vis].Left)
                {
                    enemy[vis].Text = ":)";
                    enemy[vis].BackColor = Color.GreenYellow;
                    enemy[vis].FlatAppearance.MouseOverBackColor = enemy[vis].BackColor;
                    enemy[vis].FlatAppearance.MouseDownBackColor = enemy[vis].BackColor;
                }
            }
            if(role % 7 == 0)
            {
                enemy[vis].Visible = false;
                generate();
            }
            role++;
            if (role >= 21 && role < 35) timer1.Interval = 700;
            else if (role >= 35 && role < 70) timer1.Interval = 500;
            else if (role >= 70 && role < 140) timer1.Interval = 300;
            else if (role >= 140 && role < 350) timer1.Interval = 200;
            else if (role >= 350 && role < 700) timer1.Interval = 150;
            else if (role >= 700 && role < 1050) timer1.Interval = 120;
            else if (role >= 1050) timer1.Interval = 100;
            enemy[vis].Top += 41;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Enabled = false;
        }

        private void Blocks_KeyDown(object sender, KeyEventArgs e)
        {
            Keys code = e.KeyCode;
            switch (code)
            {
                case Keys.A:
                    if(player.Left > 180)
                        player.Left -= 41;
                    break;
                case Keys.D:
                    if (player.Left < 180 + 41*7)
                        player.Left += 41;
                    break;
            }
        }
    }
}
