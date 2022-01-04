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
    public partial class BreakoutClone : Form
    {
        int startX = 20;
        int startY = 200;
        int blockWidth = 30;
        int blockHeight = 20;
        Label[,] board;
        int[,] grid;
        int gridRowSize = 20;
        int gridColSize = 16;
        Point platePos;
        Point ballPos;
        Point velocity;
        Color backgroundColor = Color.Black;
        Color stoneColor1 = Color.Blue;
        Color stoneColor2 = Color.Yellow;
        Color ballColor = Color.Red;
        Color plateColor = Color.White;
        public BreakoutClone()
        {
            InitializeComponent();
        }

        private void BreakoutClone_Load(object sender, EventArgs e)
        {
            board = new Label[gridRowSize, gridColSize];
            grid = new int[gridRowSize, gridColSize];
            init_game();
            init_grid();
            init_board();
            draw_board();
        }
        void init_game()
        {
            platePos = new Point(gridRowSize - 1, gridColSize/2);
            ballPos = new Point(platePos.X - 1, platePos.Y);
            velocity = new Point(1, -1);
        }
        void draw_board()
        {
            for(int i = 0; i < gridRowSize; i++) {
                for(int j = 0; j < gridColSize; j++) {
                    switch (grid[i, j]) {
                        case 1:
                        case 2:
                            board[i, j].BackColor = stoneColor1;
                            break;
                        case 3:
                        case 4:
                            board[i, j].BackColor = stoneColor2;
                            break;
                        case -1:
                            board[i, j].BackColor = plateColor;
                            break;
                        case -2:
                            board[i, j].BackColor = ballColor;
                            break;
                        default:
                            board[i, j].BackColor = backgroundColor;
                            break;
                    }
                }
            }
        }
        //One obstacle takes to blocks
        //(1,2) and (3,4) to label the obstacles
        void init_grid()
        {
            for(int i = 0; i < gridRowSize; i++) {
                for(int j = 0; j < gridColSize; j++) {
                    grid[i, j] = 0;
                }
            }
            for(int i = 0; i < 5; i++) {
                int interval = i%2 == 0 ? 1 : 0;
                for(int j = 0; j < 15; j += 2) {
                    if (interval % 2 == 0) {
                        grid[i, j] = 1;
                        grid[i, j + 1] = 2;
                    } else {
                        grid[i, j] = 3;
                        grid[i, j + 1] = 4;
                    }
                    interval++;
                }
            }
            //init plate
            grid[platePos.X, platePos.Y] = -1;
            grid[platePos.X, platePos.Y + 1] = -1;
            grid[platePos.X, platePos.Y - 1] = -1;
            //init ball
            grid[ballPos.X , ballPos.Y] = -2;
        }
        void init_board()
        {
            for(int i = 0; i < gridRowSize; i++) {
                for(int j = 0; j < gridColSize; j++) {
                    board[i, j] = new Label();
                    board[i, j].BackColor = backgroundColor;
                    board[i, j].Width = blockWidth;
                    board[i, j].Height = blockHeight;
                    board[i, j].Top = blockHeight * i + startX;
                    board[i, j].Left = blockWidth * j + startY;
                    board[i, j].Visible = true;
                    this.Controls.Add(board[i, j]);
                }
            }
        }
        void update()
        {
            collide();
            grid[ballPos.X, ballPos.Y] = 0;
            ballPos.X += velocity.X;
            ballPos.Y += velocity.Y;
            grid[ballPos.X, ballPos.Y] = -2;
            if(ballPos.X == gridRowSize - 1) {
                //Game over
                timer1.Enabled = false;
                this.KeyPreview = false;
                draw_board();
                MessageBox.Show("Game over!");
                gameStartBtn.Enabled = true;
            }
        }
        void collide()
        {
            int x = ballPos.X + velocity.X, y = ballPos.Y + velocity.Y;
            //Upleft
            if (x >= 0 && x + 1 < gridRowSize && y + 1 < gridColSize && y - 1 >= 0 && x % 2 == 1 && grid[x + 1, y] == 0 && grid[x, y + 1] == 0 && grid[x, y] != 0) {
                velocity.X = -velocity.X;
                velocity.Y = -velocity.Y;
                //Delete blocks
                grid[x, y] = 0;
                grid[x, y - 1] = 0;
            }
            //UpRight
            if (x >= 0 && x + 1 < gridRowSize && y + 1 < gridColSize && y - 1 >= 0 && x % 2 == 0 && grid[x + 1, y] == 0 && grid[x, y - 1] == 0 && grid[x, y] != 0) {
                velocity.X = -velocity.X;
                velocity.Y = -velocity.Y;
                //Delete blocks
                grid[x, y] = 0;
                grid[x, y + 1] = 0;
            }
            //Down Right
            if (x >= 0 && x + 1 < gridRowSize && y + 1 < gridColSize && y - 1 >= 0 && x % 2 == 0 && grid[x + 1, y] == 0 && grid[x + 1, y - 1] == 0 && grid[x, y] != 0) {
                velocity.X = -velocity.X;
                velocity.Y = -velocity.Y;
                //Delete blocks
                if (grid[x, y] != -1) {
                    grid[x, y] = 0;
                    grid[x, y + 1] = 0;
                }
            }
            //DownLeft
            if (x >= 0 && x + 1 < gridRowSize && y + 1 < gridColSize && y - 1 >= 0 && x % 2 == 1 && grid[x + 1, y] == 0 && grid[x + 1, y + 1] == 0 && grid[x, y] != 0) {
                velocity.X = -velocity.X;
                velocity.Y = -velocity.Y;
                //Delete blocks
                if (grid[x, y] != -1) {
                    grid[x, y] = 0;
                    grid[x, y - 1] = 0;
                }
            }
            //Left
            int left, right, up, down;
            if (ballPos.Y - 1 < 0)
                velocity.Y = -velocity.Y;
            else if((left = grid[ballPos.X, ballPos.Y - 1]) != 0) {
                velocity.Y = -velocity.Y;
                if (left == -1) {
                    ;
                }
                else {
                    grid[ballPos.X, ballPos.Y - 1] = 0;
                    grid[ballPos.X, ballPos.Y - 2] = 0;
                }
            }
            //Right
            if (ballPos.Y + 1 >= gridColSize)
                velocity.Y = -velocity.Y;
            else if((right = grid[ballPos.X, ballPos.Y + 1]) != 0) {
                velocity.Y = -velocity.Y;
                if (right == -1) {
                    ;
                }
                else {
                    grid[ballPos.X, ballPos.Y + 1] = 0;
                    grid[ballPos.X, ballPos.Y + 2] = 0;
                }
            }
            //Up
            if(ballPos.X - 1 < 0)
                velocity.X = -velocity.X;
            else if((up = grid[ballPos.X - 1, ballPos.Y]) != 0) {
                velocity.X = -velocity.X;
                switch (up) {
                    case 1:
                    case 3:
                        grid[ballPos.X - 1, ballPos.Y] = 0;
                        grid[ballPos.X - 1, ballPos.Y + 1] = 0;
                        break;
                    case 2:
                    case 4:
                        grid[ballPos.X - 1, ballPos.Y] = 0;
                        grid[ballPos.X - 1, ballPos.Y - 1] = 0;
                        break;
                }
            }
            //Down
            if((down = grid[ballPos.X + 1, ballPos.Y]) != 0) {
                velocity.X = -velocity.X;
                if (down == -1) {
                    Random rand = new Random();
                    velocity.Y = rand.Next() % 2 == 0 ? velocity.Y : -velocity.Y;
                }
                else
                switch (down) {
                    case 1:
                    case 3:
                        grid[ballPos.X + 1, ballPos.Y] = 0;
                        grid[ballPos.X + 1, ballPos.Y + 1] = 0;
                        break;
                    case 2:
                    case 4:
                        grid[ballPos.X + 1, ballPos.Y] = 0;
                        grid[ballPos.X + 1, ballPos.Y - 1] = 0;
                        break;
                }
            }
        }
        //dir = 0 for moving left
        //dir = 1 for moving right
        void movePlate(int dir)
        {
            switch (dir) {
                case 0:
                    if (platePos.Y - 1 > 0) {
                        grid[platePos.X, platePos.Y - 2] = -1;
                        grid[platePos.X, platePos.Y + 1] = 0;
                        platePos.Y--;
                    }
                    break;
                case 1:
                    if (platePos.Y + 1 != gridColSize - 1) {
                        grid[platePos.X, platePos.Y + 2] = -1;
                        grid[platePos.X, platePos.Y - 1] = 0;
                        platePos.Y++;
                    }
                    break;
            }
        }

        private void BreakoutClone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                movePlate(0);
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                movePlate(1);
            draw_board();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            update();
            draw_board();
            if (isWin()) {
                timer1.Enabled = false;
                MessageBox.Show("You Win!\nPress Start game to restart.");
                this.KeyPreview = false;
            }
        }

        private void gameStartBtn_Click(object sender, EventArgs e)
        {
            init_game();
            init_grid();
            this.KeyPreview = true;
            timer1.Enabled = true;
        }
        bool isWin()
        {
            for(int i = 0; i < gridRowSize; i++) {
                for(int j = 0;  j< gridColSize; j++) {
                    if (grid[i, j] == 1 || grid[i, j] == 2 || grid[i, j] == 3 || grid[i, j] == 4)
                        return false;
                }
            }
            return true;
        }
    }
}
