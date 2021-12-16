using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class Calc
    {
        Parser calcParser;
        double res;
        public bool errorInput = false;
        public Calc(string str)
        {
            calcParser = new Parser(str);
            if (!calcParser.errorflag) {
                errorInput = false;
                res = calcParser.result();
            }
            else {
                errorInput = true;
            }
        }

        public double getResult()
        {
            return res;
        }
    }
}
