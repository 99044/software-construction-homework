using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private StringBuilder value = new StringBuilder("",20);
        
        private void button_number_Click(object sender, EventArgs e)
        {
            Button button = sender as Button; // 将触发事件的控件转换为按钮
            switch (button.Text)
            {
                case "1":
                    value.Append("1");
                    break;
                case "2":
                    value.Append("2");
                    break;
                case "3":
                    value.Append("3");
                    break;
                case "4":
                    value.Append("4");
                    break;
                case "5":
                    value.Append("5");
                    break;
                case "6":
                    value.Append("6");
                    break;
                case "7":
                    value.Append("7");
                    break;
                case "8":
                    value.Append("8");
                    break;
                case "9":
                    value.Append("9");
                    break;
                case "+":
                    value.Append("+");
                    break;
                case "-":
                    value.Append("-");
                    break;
                case "x":
                    value.Append("*");
                    break;
                case "\u00f7":
                    value.Append("/");
                    break;
            }
            textBox1.Text = value.ToString();
        }

        private void button_bracket_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Text)
            {
                case "(":
                    if (value.Length==0 || !(value[value.Length - 1] >= '0' || value[value.Length - 1] <= 9))
                    {
                        value.Append("(");
                    }
                    break;
                case ")":
                    if (value.Length!=0)
                    {
                        if (value[value.Length - 1] >= '0' || value[value.Length - 1] <= 9)
                        {
                            value.Append(")");
                        }
                    }
                    break;
            }
            textBox1.Text = value.ToString();
        }
        private void button_0_and_operation_Click(object sender, EventArgs e)// 0
        {
            Button button = sender as Button; // 将触发事件的控件转换为按钮
            if (value.Length!=0)
            {
                if (value[value.Length-1].ToString() != "+" && 
                    value[value.Length-1].ToString() != "-" && 
                    value[value.Length-1].ToString() != "*" && 
                    value[value.Length-1].ToString() != "/" && 
                    value[value.Length-1].ToString() != "("
                    )
                {
                    switch (button.Text)
                    {
                        case "+":
                            value.Append("+");
                            break;
                        case "-":
                            value.Append("-");
                            break;
                        case "x":
                            value.Append("*");
                            break;
                        case "\u00f7":
                            value.Append("/");
                            break;
                        case "0":
                            value.Append("0");
                            break;
                    }
                }
                textBox1.Text = value.ToString();
            }
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            if (value.Length!=0)
            {
                value.Remove(value.Length - 1, 1);
            }
            textBox1.Text = value.ToString();
        }
        
        private void button_AC_Click(object sender, EventArgs e)
        {
            value.Remove(0, value.Length);
            textBox1.Text = value.ToString();
        }

        private void button_getResult_Click(object sender, EventArgs e)
        {
            try
            {
                // 转换中缀表达式为后缀表达式
                string postfixExpression = InfixToPostfix(value.ToString());

                // 计算后缀表达式的值
                textBox1.Text= EvaluatePostfix(postfixExpression).ToString();
            }
            catch (Exception ex)
            {
                // 捕获异常并输出错误信息
                Console.WriteLine("Expression error: " + ex.Message);
                textBox1.Text=double.NaN.ToString(); // 返回 NaN 表示表达式有误
                
            }
        }

        private void button_getResult(object sender, EventArgs e)
        {
            
        }
        
       // 将中缀表达式转换为后缀表达式
    private static string InfixToPostfix(string infixExpression)
    {
        StringBuilder postfix = new StringBuilder();
        Stack<char> operators = new Stack<char>();

        int i = 0;
        while (i < infixExpression.Length)
        {
            char token = infixExpression[i];

            if (char.IsDigit(token))
            {
                // 读取连续的数字字符
                StringBuilder number = new StringBuilder();
                while (i < infixExpression.Length && (char.IsDigit(infixExpression[i]) || infixExpression[i] == '.'))
                {
                    number.Append(infixExpression[i]);
                    i++;
                }
                i--;

                postfix.Append(number.ToString()).Append(' ');
            }
            else if (IsOperator(token))
            {
                while (operators.Count > 0 && operators.Peek() != '(' && Precedence(operators.Peek()) >= Precedence(token))
                {
                    postfix.Append(operators.Pop()).Append(' ');
                }
                operators.Push(token);
            }
            else if (token == '(')
            {
                operators.Push(token);
            }
            else if (token == ')')
            {
                while (operators.Count > 0 && operators.Peek() != '(')
                {
                    postfix.Append(operators.Pop()).Append(' ');
                }
                operators.Pop(); // 弹出 '('
            }

            i++;
        }

        while (operators.Count > 0)
        {
            postfix.Append(operators.Pop()).Append(' ');
        }

        return postfix.ToString().TrimEnd();
    }

    // 判断字符是否为运算符
    private static bool IsOperator(char c)
    {
        return c == '+' || c == '-' || c == '*' || c == '/';
    }

    // 返回运算符的优先级
    private static int Precedence(char op)
    {
        switch (op)
        {
            case '+':
            case '-':
                return 1;
            case '*':
            case '/':
                return 2;
            default:
                return 0;
        }
    }

    // 计算后缀表达式的值
    private static double EvaluatePostfix(string postfixExpression)
    {
        Stack<double> operands = new Stack<double>();

        string[] tokens = postfixExpression.Split(' ');
        foreach (string token in tokens)
        {
            if (double.TryParse(token, out double number))
            {
                operands.Push(number);
            }
            else if (IsOperator(token[0]))
            {
                double operand2 = operands.Pop();
                double operand1 = operands.Pop();
                double result = PerformOperation(operand1, operand2, token[0]);
                operands.Push(result);
            }
        }

        return operands.Pop();
    }

    // 执行运算
    private static double PerformOperation(double operand1, double operand2, char op)
    {
        switch (op)
        {
            case '+':
                return operand1 + operand2;
            case '-':
                return operand1 - operand2;
            case '*':
                return operand1 * operand2;
            case '/':
                if (operand2 == 0)
                    throw new DivideByZeroException("Division by zero");
                return operand1 / operand2;
            default:
                throw new ArgumentException("Invalid operator");
        }
    }
        
        
        
    }
}