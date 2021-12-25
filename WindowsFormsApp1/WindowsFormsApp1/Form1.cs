using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int time = 0;//時間（秒數）
        bool study = false;
        int distracted = 0;//分心次數
        int level = 1;//目前顯示圖片(貓貓等級)
        int point = 0;//養成點數
        bool newopen = true;//判斷重新開啟(for歡迎語)
        CalcForm calc;//計算機by電神Jacob
        GameForm game;
        Schedule schedule;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pic_cat.Image = Image.FromFile(@"..\..\cats\cat" + level + ".png"); //目前貓咪圖片
            pic_cat.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void buttonGame_Click(object sender, EventArgs e)//遊戲
        {
            game = new GameForm();
            if (!study)
            {
                game.Show();
            }
        }

        private void buttonSchedule_Click(object sender, EventArgs e)//讀書計畫表
        {
            schedule = new Schedule();
            schedule.Show();
        }

        private void buttonCalculator_Click(object sender, EventArgs e)//計算機
        {
            calc = new CalcForm();
            calc.Show();
        }

        private void buttonNote_Click(object sender, EventArgs e)//日記
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)//按下開始讀書
        {
            newopen = false;
            load_btn.Enabled = false;

            time = int.Parse(comboBox1.Text) * 60;
            timer1.Enabled = true;
            buttonStart.Enabled = false;
            study = true;
            comboBox1.Enabled = false;
            distracted = 0;

            message.Text = "讀書中~";
        }

        private void timer1_Tick(object sender, EventArgs e)//倒數計時
        {
            time--;
            string temp = "0" + time / 3600 + ":";
            if (time / 60 % 60 < 10) temp += "0";
            temp += time / 60 % 60; temp += ":";
            if (time % 60 < 10) temp += "0";
            labelTime.Text = temp + time % 60;

            if (time < 0)
            {
                point += int.Parse(comboBox1.Text);point_Label.Text = Convert.ToString(point); //增加養成點數（用comboBox.Text來增加）
                level = levelup(point, level,newopen);level_Label.Text = Convert.ToString(level);
                pic_cat.Image = Image.FromFile(@"..\..\cats\cat" + level + ".png");//貓貓等級更新
                load_btn.Enabled = true;

                labelTime.Text = "01:00:00";
                comboBox1.Text = "60";
                timer1.Enabled = false;
                buttonStart.Enabled = true;
                study = false;
                comboBox1.Enabled = true;
                buttonGame.Enabled = true;
            }
        }

        private void buttonGame_MouseHover(object sender, EventArgs e)//滑鼠在讀書時滑過Game
        {
            if (study)
            {
                MessageBox.Show("期末不想歐趴了484", "不准偷懶", MessageBoxButtons.OK);
                distracted++;
                //分心累積?次扣成長點數
                if (distracted >= 5)//暫時隨便設的ㄏㄏ
                {
                    point -=30;
                    level = levelup(point, level,newopen); level_Label.Text = Convert.ToString(level);
                    if (point < 0) point = 0;
                    point_Label.Text = Convert.ToString(point); 
                    buttonGame.Enabled = false;
                }
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)//即時更改顯示倒數
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
            if (T > 6 * 60 * 60)
            {
                MessageBox.Show("時間上限6小時！", "休息是為了走更長的路", MessageBoxButtons.OK);
                T = 6 * 60 * 60;
                comboBox1.Text = "360";
            } else if (T < 0)
            {
                MessageBox.Show("時間不能為負！", "你沒有時間寶石", MessageBoxButtons.OK);
                T = 0;
                comboBox1.Text = "0";
            }
            int M = T / 60 % 60;
            string temp = "" + M;
            if (T / 60 % 60 < 10) temp = "0" + temp;
            labelTime.Text = "0" + T / 3600 + ":" + temp + ":" + "00";
        }

        public int levelup(int point,int level,bool newopen) //累積點數進化貓貓
        {
            int currentlevel = level;

            if (point <= 0)
            {
                level = 0;
                breed_Label.Text = "X";
                message.Text = "感覺大事不喵";
            }
            else if (point > 0 && point <= 120){level = 1; breed_Label.Text = "普通貓貓";}//120
            else if (point <= 240) { level = 2; breed_Label.Text = "眼鏡貓貓"; }//240
            else if (point <= 420) { level = 3; breed_Label.Text = "學士帽貓貓"; }//420
            else if (point <= 660) { level = 4; breed_Label.Text = "POP貓貓"; }//660
            else if (point <= 1000) { level = 5; breed_Label.Text = "氣到咪咪貓貓"; }//1000
            else { level = 6; breed_Label.Text = "奇怪的姿勢又增加ㄌ貓貓"; }

            pic_cat.Image = Image.FromFile(@"..\..\cats\cat" + level + ".png");


            if (newopen == true) { message.Text = "歡迎回來!"; return level; }


                if (level>currentlevel)
            {
                if(currentlevel==0)
                {
                 message.Text = "是普通貓貓!";
                }
                else
                 message.Text = "你的貓貓進化了!";
            }
                else if(currentlevel<level)
            {
                message.Text = "你的貓貓退化了...";
            }
                else if(currentlevel==level)
            { message.Text = "繼續努力ㄅ!"; }

            return level;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            String stFilter = "TXT(*.txt)|*.txt";
            saveFileDialog1.Filter = stFilter;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(point_Label.Text);
                    sw.WriteLine(level_Label.Text);
                    sw.WriteLine(breed_Label.Text);
                }
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            String stFilter = "TXT(*.txt)|*.txt";
            openFileDialog1.Filter = stFilter;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] mydata = new string[3];

                int k = 0;
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                do
                {
                    string line = sr.ReadLine();                //逐行讀取清單中歌曲路徑
                    if (sr.Peek() == -1) break;
                    mydata[k] = line;
                    k++;
                } while (true);

                point_Label.Text = mydata[0];
                level_Label.Text = mydata[1];
                breed_Label.Text = mydata[2];
                point = int.Parse(mydata[0]);
                level = int.Parse(mydata[1]);
                newopen = true;

                levelup(point, level, newopen);

            }
        }
    }
}
