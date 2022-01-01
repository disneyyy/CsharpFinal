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
    public partial class StickyNoteDrawForm : Form
    {
        Graphics g;
        int penPosX = -1;
        int penPosY = -1;
        bool isMoving = false;
        Form F;
        Pen pen;
        Color back;
        Panel pallete;
        Point formLastLocation;
        public StickyNoteDrawForm()
        {
            InitializeComponent();
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            penPosX = e.X;
            penPosY = e.Y;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMoving == true && penPosX != -1 && penPosY != -1) {
                g.DrawLine(pen, new Point(penPosX, penPosY), e.Location);
                penPosX = e.X;
                penPosY = e.Y;
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
            penPosX = -1;
            penPosY = -1;
        }

        private void blackSel_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void blueSel_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void RedSel_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void StickyNoteDrawForm_Load(object sender, EventArgs e)
        {
            F = this;
            reloadCanvas();
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            back = canvas.BackColor;
            pallete = colorSelPanel;
            pallete.Hide();
            this.ControlBox = false;
            this.Text = String.Empty;
        }

        private void canvas_SizeChanged(object sender, EventArgs e)
        {
            reloadCanvas();
        }
        void reloadCanvas()
        {
            g = canvas.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            F.Close();
        }

        private void eraserBtn_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = back;
        }

        private void closePalleteBtn_Click(object sender, EventArgs e)
        {
            pallete.Hide();
            openPalleteBtn.Show();
        }

        private void openPalleteBtn_Click(object sender, EventArgs e)
        {
            pallete.Show();
            openPalleteBtn.Hide();
        }


        private void penSizeSel_Scroll(object sender, EventArgs e)
        {
            pen = new Pen(pen.Color, penSizeSel.Value);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void moveBtn_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            formLastLocation = e.Location;
        }

        private void moveBtn_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving) {
                this.Location = new Point((this.Location.X - formLastLocation.X) + e.X, (this.Location.Y + formLastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void moveBtn_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }
    }
}
