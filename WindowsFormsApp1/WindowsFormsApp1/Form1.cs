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
    public partial class Form1 : Form
    {
        int time = 0;
        bool study = false;
        //int 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGame_Click(object sender, EventArgs e)
        {

        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {

        }

        private void buttonNote_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            time = int.Parse(comboBox1.Text) * 60;
            timer1.Enabled = true;
            buttonStart.Enabled = false;
            study = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
        }

        private void buttonGame_MouseHover(object sender, EventArgs e)
        {
            if (study)
            {
                MessageBox.Show("期末不想歐趴了484", "不准偷懶", MessageBoxButtons.OK);
            }
        }
    }
}
