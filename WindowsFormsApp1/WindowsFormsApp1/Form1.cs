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
    public partial class Form1 : Form
    {
        int time = 0;
        bool study = false;
        CalcForm calc;
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
            calc = new CalcForm();
            calc.Show();
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
            comboBox1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            string temp = "0" + time / 3600 + ":";
            if (time / 60 % 60 < 10) temp += "0";
            temp += time / 60 % 60; temp += ":"; 
            if (time % 60 < 10) temp += "0";
            labelTime.Text =  temp + time % 60;

            if(time < 0)
            {
                //增加養成點數（可以用comboBox.Text來增加）
                labelTime.Text = "01:00:00";
                comboBox1.Text = "60";
                timer1.Enabled = false;
                buttonStart.Enabled = true;
                study = false;
                comboBox1.Enabled = true;
            }
        }

        private void buttonGame_MouseHover(object sender, EventArgs e)
        {
            if (study)
            {
                MessageBox.Show("期末不想歐趴了484", "不准偷懶", MessageBoxButtons.OK);
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") comboBox1.Text = "0";
            try
            {
                int tmp = int.Parse(comboBox1.Text);
            }
            catch
            {
                labelTime.Text = "00:00:00";
                comboBox1.Text = "0";
                MessageBox.Show("時間設定錯誤！", "錯誤", MessageBoxButtons.OK);
                return;
            }
            int T = int.Parse(comboBox1.Text) * 60;
            if(T > 6 * 60 * 60)
            {
                MessageBox.Show("時間上限6小時！", "休息是為了走更長的路", MessageBoxButtons.OK);
                T = 6 * 60 * 60;
                comboBox1.Text = "360";
            }else if(T < 0)
            {
                MessageBox.Show("時間不能為負！", "錯誤", MessageBoxButtons.OK);
                T = 0;
                comboBox1.Text = "0";
            }
            int M = T / 60 % 60;
            string temp = "" + M;
            if (T / 60 % 60 < 10) temp = "0" + temp;
            labelTime.Text = "0" + T / 3600 + ":" + temp + ":" + "00";
        }
    }
}
