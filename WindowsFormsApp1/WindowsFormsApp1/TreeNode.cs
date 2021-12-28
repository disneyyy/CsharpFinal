using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public NodeType t;
        public double val;
        public string func;
        public TreeNode(NodeType t, double data, string str)
        {
            this.left = null;
            this.right = null;
            this.t = t;
            this.val = data;
            this.func = str;
        }
        public void printTree()
        {
            switch (this.t) {
                case NodeType.NUMBER:
                    //print out Number
                    Console.Write(String.Format("{0:F2}", this.val));
                    break;
                case NodeType.NEG:
                    //print out minus sign
                    Console.Write("-");
                    this.left.printTree();
                    break;
                case NodeType.ADD:
                    //print (
                    Console.Write("(");
                    this.left.printTree();
                    //print +
                    Console.Write("+");
                    this.right.printTree();
                    //print )
                    Console.Write(")");
                    break;
                case NodeType.SUB:
                    //print (
                    Console.Write("(");
                    this.left.printTree();
                    //print -
                    Console.Write("-");
                    this.right.printTree();
                    //print )
                    Console.Write(")");
                    break;
                case NodeType.MUL:
                    //print (
                    Console.Write("(");
                    this.left.printTree();
                    //print *
                    Console.Write("*");
                    this.right.printTree();
                    //print )
                    Console.Write(")");
                    break;
                case NodeType.DIV:
                    //print (
                    Console.Write("(");
                    this.left.printTree();
                    //print /
                    Console.Write("/");
                    this.right.printTree();
                    //print )
                    Console.Write(")");
                    break;
                case NodeType.SQRT:
                    Console.Write("sqrt(");
                    this.left.printTree();
                    Console.Write(")");
                    break;
                case NodeType.POW:
                    Console.Write("(");
                    this.left.printTree();
                    Console.Write("^");
                    this.right.printTree();
                    Console.Write(")");
                    break;
                case NodeType.LOG:
                    Console.Write("log(");
                    this.left.printTree();
                    Console.Write(")");
                    break;
                case NodeType.LN:
                    Console.Write("ln(");
                    this.left.printTree();
                    Console.Write(")");
                    break;
                default:
                    //print printTree error
                    Console.WriteLine("PrintTree error");
                    break;
            }
        }
        public double evalTree()
        {
            if (this.t == NodeType.NUMBER) {
                return this.val;
            }
            switch (this.t) {
                case NodeType.NEG:
                    return -this.left.evalTree();
                case NodeType.ADD:
                    return this.left.evalTree() + this.right.evalTree();
                case NodeType.SUB:
                    return this.left.evalTree() - this.right.evalTree();
                case NodeType.DIV:
                    return this.left.evalTree() / this.right.evalTree();
                case NodeType.MUL:
                    return this.left.evalTree() * this.right.evalTree();
                case NodeType.SQRT:
                    return Math.Sqrt(this.left.evalTree());
                case NodeType.POW:
                    return Math.Pow(this.left.evalTree(), this.right.evalTree());
                case NodeType.LOG:
                    return Math.Log10(this.left.evalTree());
                case NodeType.LN:
                    return Math.Log(this.left.evalTree());
                case NodeType.COS:
                    return Math.Cos(this.left.evalTree());
                case NodeType.SIN:
                    return Math.Sin(this.left.evalTree());
                default:
                    Console.WriteLine("Error evaluating");
                    return 0.0f;
            }
            return 0.0f;
        }

    }
    enum NodeType
    {
        NUMBER,
        ADD,
        SUB,
        MUL,
        NEG,
        DIV,
        SQRT,
        POW,
        LOG,
        LN,
        COS,
        SIN
    }
}
