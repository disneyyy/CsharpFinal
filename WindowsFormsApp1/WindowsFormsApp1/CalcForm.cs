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
    public partial class CalcForm : Form
    {

        Calc calc;
        public CalcForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            calc = new Calc(input.Text);
            if (calc.errorInput == true)
                input.Text = "Syntax error";
            else
                input.Text = calc.getResult().ToString();
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {

        }

        private void num1Btn_Click(object sender, EventArgs e)
        {
            input.Text += '1';
        }

        private void num2Btn_Click(object sender, EventArgs e)
        {
            input.Text += '2';
        }

        private void num3Btn_Click(object sender, EventArgs e)
        {
            input.Text += '3';
        }

        private void num4Btn_Click(object sender, EventArgs e)
        {
            input.Text += '4';
        }

        private void num5Btn_Click(object sender, EventArgs e)
        {
            input.Text += '5';
        }

        private void num6Btn_Click(object sender, EventArgs e)
        {
            input.Text += '6';
        }

        private void num7Btn_Click(object sender, EventArgs e)
        {
            input.Text += '7';
        }

        private void num8Btn_Click(object sender, EventArgs e)
        {
            input.Text += '8';
        }

        private void num9Btn_Click(object sender, EventArgs e)
        {
            input.Text += '9';
        }

        private void num0Btn_Click(object sender, EventArgs e)
        {
            input.Text += '0';
        }

        private void numDotBtn_Click(object sender, EventArgs e)
        {
            input.Text += '.';
        }

        private void num10PowerBtn_Click(object sender, EventArgs e)
        {
            input.Text += "*10^(";
        }

        private void numRootBtn_Click(object sender, EventArgs e)
        {
            input.Text += "sqrt(";
        }

        private void numDivBtn_Click(object sender, EventArgs e)
        {
            input.Text += '/';
        }

        private void numMulBtn_Click(object sender, EventArgs e)
        {
            input.Text += '*';
        }

        private void numSubBtn_Click(object sender, EventArgs e)
        {
            input.Text += '-';
        }

        private void numAddBtn_Click(object sender, EventArgs e)
        {
            input.Text += '+';
        }

        private void numLogBtn_Click(object sender, EventArgs e)
        {
            input.Text += "log(";
        }

        private void numLnBtn_Click(object sender, EventArgs e)
        {
            input.Text += "ln(";
        }

        private void numSinBtn_Click(object sender, EventArgs e)
        {
            input.Text += "sin(";
        }

        private void numCosBtn_Click(object sender, EventArgs e)
        {
            input.Text += "cos(";
        }

        private void numRightParBtn_Click(object sender, EventArgs e)
        {
            input.Text += ')';
        }

        private void numDelBtn_Click(object sender, EventArgs e)
        {
            if(input.Text.Length > 0)
                input.Text = input.Text.Remove(input.Text.Length - 1, 1);
        }

        private void numACBtn_Click(object sender, EventArgs e)
        {
            input.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input.Text += '^';
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            input.Text += '(';
        }
    }
}
