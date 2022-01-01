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
    public partial class StickyNoteTextForm : Form
    {
        bool isMoving;
        Point formLastLocation;
        public StickyNoteTextForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void StickyNoteTextForm_Load(object sender, EventArgs e)
        {
            formLastLocation = this.Location;
            this.ControlBox = false;
            this.Text = String.Empty;
        }
    }
}
