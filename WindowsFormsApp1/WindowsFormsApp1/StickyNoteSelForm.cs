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
    public partial class StickyNoteSelForm : Form
    {
        public StickyNoteSelForm()
        {
            InitializeComponent();
        }

        private void addDrawBtn_Click(object sender, EventArgs e)
        {
            Form note = new StickyNoteDrawForm();
            note.Show();
        }

        private void addTextBtn_Click(object sender, EventArgs e)
        {
            Form note = new StickyNoteTextForm();
            note.Show();
        }

        private void StickyNoteSelForm_Load(object sender, EventArgs e)
        {
            this.Text = "選擇便利貼";
        }
    }
}
