using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class MyCalc

    {
        public double leftValue = 0;
        public double rightValue = 0;
        public double result = 0;
        public char op = 'f';
        public bool eq = false;
        public bool isfirst = true;
        public bool warning = false;
        public double firstproc = 0;
        private double memory = 0;
        public string num;
        public string numup;
        public void Back()
        {
            num = num.Remove(num.Length - 1, 1);
            if (num.Length == 0)
            {
                num = "0";
            }
        }
        public void Plus()
        {
            leftValue = Convert.ToDouble(num);
            if (isfirst == true)
            {
                result = leftValue;
                isfirst = false;
            }
            else
            {
                switch (op)
                {
                    case '+':
                       result += leftValue;
                        break;
                    case '-':
                        result -= leftValue;
                        break;
                    case '*':
                        result *= leftValue;
                        break;
                    case '/':
                        if (leftValue == 0)
                        {
                            warning = true;
                        }
                        else result /= leftValue;
                        break;
                    case '^':
                        result = Math.Pow(result, rightValue);
                        break;
                    default:
                        break;
                }
            }
            numup = result + " + ";
            op = '+';
            eq = false;
        }
        public void Minus()
        {
            leftValue = Convert.ToDouble(num);
            if (isfirst == true)
            {
                result = leftValue;
                isfirst = false;
            }
            else
            {
                switch (op)
                {
                    case '+':
                        result += leftValue;
                        break;
                    case '-':
                        result -= leftValue;
                        break;
                    case '*':
                        result *= leftValue;
                        break;
                    case '/':
                        if (leftValue == 0)
                        {
                            warning = true;
                        }
                        else result /= leftValue;
                        break;
                    case '^':
                        result = Math.Pow(result, rightValue);
                        break;
                    default:
                        break;
                }
            }
            numup = result + " - ";
            op = '-';
            eq = false;
        }
        public void Multi()
        {
            leftValue = Convert.ToDouble(num);
            if (isfirst == true)
            {
                result = leftValue;
                isfirst = false;
            }
            else
            {
                switch (op)
                {
                    case '+':
                        result += leftValue;
                        break;
                    case '-':
                        result -= leftValue;
                        break;
                    case '*':
                        result *= leftValue;
                        break;
                    case '/':
                        if (leftValue == 0)
                        {
                            warning = true;
                        }
                        else result /= leftValue;
                        break;
                    case '^':
                        result = Math.Pow(result, rightValue);
                        break;
                    default:
                        break;
                }
            }
            numup = result + " * ";
            op = '*';
            eq = false;
        }
        public void Division()
        {
            leftValue = Convert.ToDouble(num);
            if (isfirst == true)
            {
                result = leftValue;
                isfirst = false;
            }
            else
            {
                switch (op)
                {
                    case '+':
                        result += leftValue;
                        break;
                    case '-':
                        result -= leftValue;
                        break;
                    case '*':
                        result *= leftValue;
                        break;
                    case '/':
                        if (leftValue == 0)
                        {
                            warning = true;
                        }
                        else result /= leftValue;
                        break;
                    case '^':
                        result = Math.Pow(result, rightValue);
                        break;
                    default:
                        break;
                }
            }
            numup = result + " / ";
            op = '/';
            eq = false;
        }
        public void Equality()
        {
            if (eq == true && op != 'f')
            {
                result = Convert.ToDouble(num);
                numup = num + op + rightValue + " =";
            }
            else
            {
                rightValue = Convert.ToDouble(num);
                numup = numup + num + " =";

            }
            switch (op)
            {
                case '+':
                    num = (rightValue + result).ToString();
                    isfirst = true;
                    break;
                case '-':
                    num = (result - rightValue).ToString();
                    isfirst = true;
                    break;
                case '*':
                    num = (result * rightValue).ToString();
                    isfirst = true;
                    break;
                case '/':
                    if (rightValue == 0)
                    {
                       num = "Деление на ноль невозможно";
                        warning = true;
                    }
                    else num = (result / rightValue).ToString();
                    isfirst = true;
                    break;
                case '^':
                    num = Math.Pow(result, rightValue).ToString();
                    isfirst = true;
                    break;
                default:
                    break;
            }
            if(!warning) firstproc = Convert.ToDouble(num);
            eq = true;
        }
        public void Delete_all()
        {
            op = 'f';
            leftValue = 0;
            rightValue = 0;
            firstproc = 0;
            result = 0;
            isfirst = true;
            eq = false;
            warning = false;
            num = " ";
            numup = " ";
        }
        public void Proc()
        {
            if (eq == true)
            {
                numup = " ";
                num = ((firstproc * Convert.ToDouble(num)) / 100).ToString();
            }
            else num = ((leftValue * Convert.ToDouble(num)) / 100).ToString();
        }
        public void Sqrt()
        {
            if (Double.Parse(num) < 0)
            {
                num = ("Неверный ввод");
                warning = true;
            }
            else
            {
                num = (Math.Sqrt(Double.Parse(num))).ToString();
            }
        }
        public void Division1()
        {
            if (Double.Parse(num) == 0)
            {
                  num = ("Неверный ввод");
                warning = true;
            }
            else
            {
                num = (1 / (Double.Parse(num))).ToString();
            }
        }
        public void sqr()
        {
            num = ((Double.Parse(num)) * (Double.Parse(num))).ToString();
        }
        public void Twooperanddegree()
        {
            leftValue = Convert.ToDouble(num);
            if (isfirst == true)
            {
                result = leftValue;
                isfirst = false;
            }
            else result = Math.Pow(result, leftValue);
            numup = result + " ^ ";
            op = '^';
            eq = false;
            num = " ";
        }
        public void Tendegree()
        {
            num = Math.Pow(10, Double.Parse(num)).ToString();
        }
        public void Log()
        {
            if (Double.Parse(num) <= 0)
            {
                num = ("Неверный ввод");
                warning = true;
            }
            else num = Math.Log10(Double.Parse(num)).ToString();
        }
        public void Ln()
        {
            if (Double.Parse(num) <= 0)
            {
                num = ("Неверный ввод");
                warning = true;
            }
            else num = Math.Log(Double.Parse(num)).ToString();
        }
        public void Pi()
        {
            num = Math.PI.ToString();
            num = 123.ToString();
        }
        public void Mod()
        {
            if (Double.Parse(num) < 0)
            {
                num = (Double.Parse(num) * (-1)).ToString();
            }
        }
        public void Sin()
        {
            num = Math.Sin(Double.Parse(num)).ToString();
        }
        public void Cos()
        {
            num = Math.Cos(Double.Parse(num)).ToString();
        }
        public void Tg()
        {
            num = Math.Tan(Double.Parse(num)).ToString();
        }
        public void Ctg()
        {
            num = (1 / Math.Tan(Double.Parse(num))).ToString();
        }
        public void Plus_Minus()
        {
            if ((num.Length == 0))
            {
                num = (result * (-1)).ToString();
            }
            else
            {
                num = (Convert.ToDouble(num) * (-1)).ToString();
            }
        }
        public void Comma()
        {
            if ((num.Length == 0) && warning == false)
            {
                num = "0,";
            }
            else
            {
                if (!num.Contains(",") && warning == false)
                {
                    num = num + ",";
                }
            }
        }
        public void MC()
        {
            num = "0";
            memory = 0;
        }
        public void MS()
        {
            memory = Double.Parse(num);
        }
        public void MR()
        {
            num = memory.ToString();
        }
        public void MMinus()
        {
            memory -= Double.Parse(num);
        }
        public void MPlus()
        {
            memory += Double.Parse(num);
        }
    }
}
