using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Parser
    {
        int nextChar = 0;
        string str;
        TreeNode parseTree;
        public bool errorflag = false;
        public Parser(string str)
        {
            this.str = str;
            parseTree = this.parseE();
            if (nextChar != str.Length)
                errorflag = true;
            if (errorflag == true) {
                Console.WriteLine("Syntax error!");
            }
        }
        public double result()
        {
            return parseTree.evalTree();
        }
        //parse expression
        TreeNode parseE()
        {
            if (nextChar >= str.Length) {
                errorflag = true;
                return null;
            }
            TreeNode a = this.parseT();
            TreeNode b;
            while (true) {
                if (nextChar < str.Length && str[nextChar] == '+') {
                    scanToken();
                    b = parseT();
                    a = buildAdd(a, b);
                } else if (nextChar < str.Length && str[nextChar] == '-') {
                    scanToken();
                    b = parseT();
                    a = buildSub(a, b);
                } else
                    return a;
            }
        }
        //parse term
        TreeNode parseT()
        {
            if (nextChar >= str.Length) {
                errorflag = true;
                return null;
            }
            TreeNode a = parseF();
            TreeNode b;
            while (true) {
                if (nextChar < str.Length && str[nextChar] == '*') {
                    scanToken();
                    b = parseF();
                    a = buildMul(a, b);
                } else if (nextChar < str.Length && str[nextChar] == '/') {
                    scanToken();
                    b = parseF();
                    a = buildDiv(a, b);
                } else
                    return a;
            }
        }
        //parse factor
        TreeNode parseF()
        {
            if (nextChar >= str.Length) {
                errorflag = true;
                return null;
            }
            TreeNode a;
            if (str[nextChar] == '(')
            {
                scanToken();
                a = parseE();
                if (this.checkRightParenthesis())
                    ;
                else
                    return null;
            }
            //NEG
            else if (nextChar < str.Length && str[nextChar] == '-')
            {
                scanToken();
                a = buildNeg(parseT());
            }
            //SQRT
            else if (nextChar + 4 < str.Length && str.Substring(nextChar, 4) == "sqrt")
            {
                for (int i = 0; i < 5; i++)
                {
                    scanToken();
                }
                a = buildSqrt(parseE());
                if (this.checkRightParenthesis())
                    ;
                else
                    return null;
            }
            //LOG
            else if (nextChar + 3 < str.Length && str.Substring(nextChar, 3) == "log")
            {
                for (int i = 0; i < 4; i++)
                {
                    scanToken();
                }
                a = buildLog(parseE());
                if (this.checkRightParenthesis())
                    ;
                else
                    return null;
            }
            //LN
            else if (nextChar + 2 < str.Length && str.Substring(nextChar, 2) == "ln")
            {
                for (int i = 0; i < 3; i++)
                {
                    scanToken();
                }
                a = buildLn(parseE());
                if (this.checkRightParenthesis())
                    ;
                else
                    return null;
            }
            else if (nextChar + 3 < str.Length && str.Substring(nextChar, 3) == "cos")
            {
                //scan cos including left parethesis
                for (int i = 0; i < 4; i++)
                {
                    scanToken();
                }
                a = buildCos(parseE());
                if (this.checkRightParenthesis())
                    ;
                else
                    return null;
            }
            else if (nextChar + 3 < str.Length && str.Substring(nextChar, 3) == "sin")
            {
                //scan cos including left parethesis
                for (int i = 0; i < 4; i++)
                {
                    scanToken();
                }
                a = buildSin(parseE());
                if (this.checkRightParenthesis())
                    ;
                else
                    return null;
            }else
                a = parseNumber();
            //Power  ^ check
            if (nextChar < str.Length && str[nextChar] == '^') {
                TreeNode power;
                while (nextChar < str.Length && str[nextChar] == '^') {
                    scanToken();
                    power = parseF();
                    a = buildPow(a, power);
                }
                return a;
            }
            return a;
        }
        bool checkRightParenthesis()
        {
            if (nextChar < str.Length && str[nextChar] != ')') {
                errorflag = true;
            } else
                scanToken();
            return !errorflag;
        }
        //scan token
        void scanToken()
        {
            nextChar++;
            while (nextChar < str.Length && str[nextChar] == ' ')
                nextChar++;
        }
        //scan number from input string 
        TreeNode parseNumber()
        {
            int val = 0;
            double fraction = 0;
            int digitAfterPoint = 0;
            if(nextChar >= str.Length || !(str[nextChar] - '0' >= 0 && str[nextChar]  - '0' <= 9))
            {
                errorflag = true;
                return null;
            }
            while (nextChar < str.Length && str[nextChar] - '0' >= 0 && str[nextChar] - '0' <= 9) {
                val *= 10;
                val += str[nextChar] - '0';
                nextChar++;
            }
            if (nextChar < str.Length && str[nextChar] == '.') {
                nextChar++;
                while (nextChar < str.Length && str[nextChar] - '0' >= 0 && str[nextChar] - '0' <= 9) {
                    fraction *= 10;
                    fraction += str[nextChar] - '0';
                    digitAfterPoint++;
                    nextChar++;
                }
            }
            while (digitAfterPoint != 0) {
                fraction /= 10;
                digitAfterPoint--;
            }
            scanSpaces();
            double res = val + fraction;
            TreeNode temp = new TreeNode(NodeType.NUMBER, res, "");
            return temp;
        }
        TreeNode buildAdd(TreeNode a, TreeNode b)
        {
            TreeNode temp = new TreeNode(NodeType.ADD, 0.0f, "");
            temp.left = a;
            temp.right = b;
            return temp;
        }
        TreeNode buildSub(TreeNode a, TreeNode b)
        {
            TreeNode temp = new TreeNode(NodeType.SUB, 0.0f, "");
            temp.left = a;
            temp.right = b;
            return temp;
        }
        TreeNode buildMul(TreeNode a, TreeNode b)
        {
            TreeNode temp = new TreeNode(NodeType.MUL, 0.0f, "");
            temp.left = a;
            temp.right = b;
            return temp;
        }
        TreeNode buildDiv(TreeNode a, TreeNode b)
        {
            TreeNode temp = new TreeNode(NodeType.DIV, 0.0f, "");
            temp.left = a;
            temp.right = b;
            return temp;
        }
        TreeNode buildNeg(TreeNode a)
        {
            TreeNode temp = new TreeNode(NodeType.NEG, 0.0f, "");
            temp.left = a;
            return temp;
        }
        TreeNode buildSqrt(TreeNode a)
        {
            TreeNode temp = new TreeNode(NodeType.SQRT, 0.0f, "sqrt");
            temp.left = a;
            return temp;
        }
        TreeNode buildPow(TreeNode a, TreeNode b)
        {
            TreeNode temp = new TreeNode(NodeType.POW, 0.0f, "");
            temp.left = a;
            temp.right = b;
            return temp;
        }
        TreeNode buildLog(TreeNode a)
        {
            TreeNode temp = new TreeNode(NodeType.LOG, 0.0f, "log");
            temp.left = a;
            return temp;
        }
        TreeNode buildLn(TreeNode a)
        {
            TreeNode temp = new TreeNode(NodeType.LN, 0.0f, "ln");
            temp.left = a;
            return temp;
        }
        TreeNode buildCos(TreeNode a)
        {
            TreeNode temp = new TreeNode(NodeType.COS, 0.0f, "cos");
            temp.left = a;
            return temp;
        }
        TreeNode buildSin(TreeNode a)
        {
            TreeNode temp = new TreeNode(NodeType.SIN, 0.0f, "cos");
            temp.left = a;
            return temp;
        }
        void scanSpaces()
        {
            while (nextChar < str.Length && str[nextChar] == ' ')
                nextChar++;
            return;
        }
    }
}
