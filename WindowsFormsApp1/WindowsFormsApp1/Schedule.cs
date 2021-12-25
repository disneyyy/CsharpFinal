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
    public partial class Schedule : Form
    {
        Schedule schedule;
        string filename = "plans.txt";
        Button[] plans = new Button[119];
        int[] plans_number_array = new int[119];
        string[] plans_text_array = new string[119];
        string text = "";
        public Schedule()
        {
            InitializeComponent();
        }
        
        private void study_Load(object sender, EventArgs e)
        {
            DateTime myDate = DateTime.Now;
            string myDateString = myDate.ToString("yyyy-MM-dd HH:mm:ss");
            label1.Text = myDateString;
            read_text(ref plans_text_array);
            set_button(ref plans);
            text = textBox1.Text;
        }
        private void set_button(ref Button [] plans)
        {
            int perh = 30;
            int perw = 95;
            int x = 0, y = 0;
            for (int i = 0; i < 119; i++)
            {
                if (x % 7 == 0)
                {
                    y++;
                    x = 0;
                }
                plans[i] = new Button();
                plans[i].SetBounds((60 + (perw + 5) * x), (30 + (perh + 4) * y), perw, perh);//(starting point X, starting point Y, width, heighth)
                plans[i].BackColor = Color.White;
                plans[i].Click += btn1_Click;
                if(plans_text_array[i] != "")
                {
                    plans[i].BackColor = Color.NavajoWhite;
                    text = plans_text_array[i];
                    plans[i].Text = text;
                }
                Controls.Add(plans[i]);
                x++;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Button btnClick = (Button)sender;
            int index = Array.IndexOf(plans, btnClick);
            if(radioButton1.Checked == true)
            {
                MessageBox.Show(btnClick.Text);
            }
            else if (text != "" && radioButton1.Checked == false)
            {
                btnClick.Text = text;
                btnClick.BackColor = Color.NavajoWhite;
                plans_text_array[index] = text;
                write_text(plans_text_array);
            }
            else if (text == "" && radioButton1.Checked == false)
            {
                btnClick.Text = "";
                btnClick.BackColor = Color.White;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = textBox1.Text;
        }
        private void write_text(string[] plans_text)
        {
            try{
                StreamWriter str = new StreamWriter(filename);
                for(int i = 0; i < 119; i++)
                {
                    str.WriteLine(i.ToString() + ":" + plans_text_array[i] + ":");
                }
                str.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        private void read_text(ref string[] plans_text)
        {
            try
            {
                StreamReader str = new StreamReader(filename);
                do
                {
                    text = str.ReadLine();
                    string[] content = text.Split(':');
                    int number = Int32.Parse(content[0]);
                    plans_text_array[number] = content[1];
                } while (text != null);
                str.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
