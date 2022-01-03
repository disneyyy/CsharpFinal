using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace WindowsFormsApp1
{
    public partial class Piano : Form
    {
        SoundPlayer Music = new SoundPlayer();
        bool open;
        int time = 6;
        


        public Piano()
        {
            InitializeComponent();
        }

        private void Piano_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = 500;
            NotePic1.Visible = false;
            NotePic2.Visible = false;
            open = false;
            catpicture.Image = Image.FromFile(@"..\..\cats\cat7.png");//左上角的pop貓
            catpicture.SizeMode = PictureBoxSizeMode.Zoom;
            NotePic1.SizeMode = PictureBoxSizeMode.Zoom;
            NotePic2.SizeMode = PictureBoxSizeMode.Zoom;

            label11.Text = "滑鼠點擊琴鍵\nor\n依照畫底線者按鍵\n\n來彈奏鋼琴~";


        }

        private void Piano_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.A:
                    Music.SoundLocation = @"..\..\notes\C.wav";
                    open = PlayNote(open);
                    break;
                case Keys.S:
                    Music.SoundLocation = @"..\..\notes\D.wav";
                    open = PlayNote(open);
                    break;
                case Keys.D:
                    Music.SoundLocation = @"..\..\notes\E.wav";
                    open = PlayNote(open);
                    break;
                case Keys.F:
                    Music.SoundLocation = @"..\..\notes\F.wav";
                    open = PlayNote(open);
                    break;
                case Keys.G:
                    Music.SoundLocation = @"..\..\notes\G.wav";
                    open = PlayNote(open);
                    break;
                case Keys.H:
                    Music.SoundLocation = @"..\..\notes\A.wav";
                    open = PlayNote(open);
                    break;
                case Keys.J:
                    Music.SoundLocation = @"..\..\notes\B.wav";
                    open = PlayNote(open);
                    break;
                case Keys.K:
                    Music.SoundLocation = @"..\..\notes\C1.wav";
                    open = PlayNote(open);
                    break;
                case Keys.L:
                    Music.SoundLocation = @"..\..\notes\D1.wav";
                    open = PlayNote(open);
                    break;
                case Keys.P:
                    Music.SoundLocation = @"..\..\notes\E1.wav";
                    open = PlayNote(open);
                    break;

                case Keys.W:
                    Music.SoundLocation = @"..\..\notes\Db.wav";
                    open = PlayNote(open);
                    break;
                case Keys.E:
                    Music.SoundLocation = @"..\..\notes\Eb.wav";
                    open = PlayNote(open);
                    break;
                case Keys.R:
                    Music.SoundLocation = @"..\..\notes\Gb.wav";
                    open = PlayNote(open);
                    break;
                case Keys.T:
                    Music.SoundLocation = @"..\..\notes\Ab.wav";
                    open = PlayNote(open);
                    break;
                case Keys.Y:
                    Music.SoundLocation = @"..\..\notes\Bb.wav";
                    open = PlayNote(open);
                    break;
                case Keys.I:
                    Music.SoundLocation = @"..\..\notes\Db1.wav";
                    open = PlayNote(open);
                    break;
                case Keys.O:
                    Music.SoundLocation = @"..\..\notes\Eb1.wav";
                    open = PlayNote(open);
                    break;
            }

        }


        bool PlayNote(bool open)
        {
            Music.Play();
            open = POP(open);
            NoteDance();
            return open;
        }

        private void NoteC_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\C.wav";
            open = PlayNote(open);
        }


        private void NoteD_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\D.wav";
            open = PlayNote(open);
        }

 
        private void NoteE_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\E.wav";
            open = PlayNote(open);
        }

        private void NoteF_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\F.wav";
            open = PlayNote(open);
        }


        private void NoteG_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\G.wav";
            open = PlayNote(open);
        }


        private void NoteA_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\A.wav";
            open = PlayNote(open);
        }

        private void NoteB_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\B.wav";
            open = PlayNote(open);
        }


        private void NoteC1_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\C1.wav";
            open = PlayNote(open);
        }

        private void NoteD1_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\D1.wav";
            open = PlayNote(open);
        }

        private void NoteE1_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\E1.wav";
            open = PlayNote(open);
        }

        private void NoteDb_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\Db.wav";
            open = PlayNote(open);
        }

        private void NoteEb_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\Eb.wav";
            open = PlayNote(open);
        }

        private void NoteGb_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\Gb.wav";
            open = PlayNote(open);
        }

        private void NoteAb_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\Ab.wav";
            open = PlayNote(open);
        }

        private void NoteCb_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\Cb.wav";
            open = PlayNote(open);
        }

        private void NoteDb1_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\Db1.wav";
            open = PlayNote(open);
        }

        private void NoteEb1_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\Eb1.wav";
            open = PlayNote(open);
        }

        private void NoteBb_Click(object sender, EventArgs e)
        {
            Music.SoundLocation = @"..\..\notes\Bb.wav";
            open = PlayNote(open);
        }


        bool POP(bool open)
        {
            if (open == true)
            {
                catpicture.Image = Image.FromFile(@"..\..\cats\cat7.png");
                open = false;
            }
            else
            {
                catpicture.Image = Image.FromFile(@"..\..\cats\cat4.png");
                open = true;
            }

            return open;
        }


        void NoteDance()
        {
            time = 6;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NotePic1.Visible = true;
            NotePic2.Visible = true;
            Random random = new Random();
            int num = random.Next(1, 4);
            int num2 = random.Next(1, 4);
            NotePic1.Image = Image.FromFile(@"..\..\notes\Music" + num + ".png");
            NotePic2.Image = Image.FromFile(@"..\..\notes\Music" + num2 + ".png");
            time--;

            if(time==0)
            {
                timer1.Enabled = false;
                time = 6;
                NotePic1.Visible = false;
                NotePic2.Visible = false;
            }
        }
    }

}
