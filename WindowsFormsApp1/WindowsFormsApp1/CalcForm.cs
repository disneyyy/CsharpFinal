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
    }
}
