using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public double leftValue = 0;
        public double rightValue = 0;
        public double result = 0;
        public char op = 'f';
        public bool eq = false;
        public bool isfirst = true;
        public double firstproc = 0;
        private double memory = 0;
        public MyCalc calc = new MyCalc();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(calc.warning == true)
            {
                calc.Delete_all();
                textBox1.Clear();
                texttop.Clear();
            }
            Button number = (Button)sender;
            Number(number.Content.ToString());
        }
        private void Number(string value)
        {
            if (textBox1.Text == "0")
                textBox1.Text = value;
            else
                textBox1.Text = textBox1.Text + value;
        }
        private void Back_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && !textBox1.Text.Contains("E") && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Back();
                textBox1.Text = calc.num;
            }
        }
        private void Comma_Button(object sender, RoutedEventArgs e)
        {
            if ((textBox1.Text == "0") && calc.warning == false)
            {
                textBox1.Text = "0,";
            }
            else
            {
                if (!textBox1.Text.Contains(",") && calc.warning == false)
                {
                    textBox1.Text =  textBox1.Text + ",";
                }
            }
        }

        private void Plus_Minus_Button(object sender, RoutedEventArgs e)
        {
            if (calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Plus_Minus();
                textBox1.Text = calc.num;
            }
        }
        public void Plus_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Plus();
                textBox1.Clear();
                if(calc.warning == true)
                {
                    textBox1.Text = "Деление на ноль невозможно";
                }
                texttop.Text = calc.numup;
            }

        }
        private void Minus_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {

                calc.num = textBox1.Text.ToString();
                calc.Minus();
                textBox1.Clear();
                if (calc.warning == true)
                {
                    textBox1.Text = "Деление на ноль невозможно";
                }
                texttop.Text = calc.numup;

            }
        }

        private void Multi_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Multi();
                textBox1.Clear();
                if (calc.warning == true)
                {
                    textBox1.Text = "Деление на ноль невозможно";
                }
                texttop.Text = calc.numup;
            }
        }
        private void Division_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Division();
                textBox1.Clear();
                if (calc.warning == true)
                {
                    textBox1.Text = "Деление на ноль невозможно";
                }
                texttop.Text = calc.numup;
            }
        }
        private void Proc_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Proc();
                textBox1.Text = calc.num;
                texttop.Text = calc.numup;
            }
        }
        public void Equality_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Equality();
                texttop.Text = calc.numup;
                textBox1.Text = calc.num;
            }
        }
        private void Sqrt_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Sqrt();
                texttop.Text = calc.numup;
                textBox1.Text = calc.num;
            }
        }

        private void Division1_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Division1();
                texttop.Text = calc.numup;
                textBox1.Text = calc.num;
            }
        }

        private void sqr_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.sqr();
                texttop.Text = calc.numup;
                textBox1.Text = calc.num;
            }
        }

        private void Delete_all_Button(object sender, RoutedEventArgs e)
        {
            texttop.Clear();
            textBox1.Text = "0";
            calc.Delete_all();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (calc.warning == false) { 
                textBox1.Text = "0";
                calc.num = " ";
            }
        }

        private void MC_Button(object sender, RoutedEventArgs e)
        {
            calc.num = textBox1.Text.ToString();
            calc.MC();
            textBox1.Text = calc.num;
            MC_button.IsEnabled = false;
            MR_button.IsEnabled = false;
        }

        private void MS_Button(object sender, RoutedEventArgs e)
        {
            calc.num = textBox1.Text.ToString();
            calc.MS();
            MC_button.IsEnabled = true;
            MR_button.IsEnabled = true;
        }

        private void MR_button_Click(object sender, RoutedEventArgs e)
        {
            calc.num = textBox1.Text.ToString();
            calc.MR();
            textBox1.Text = calc.num;
        }

        private void MPlus_Button_Click(object sender, RoutedEventArgs e)
        {
            calc.num = textBox1.Text.ToString();
            calc.MPlus();
        }

        private void MMinus_button_Click(object sender, RoutedEventArgs e)
        {
            calc.num = textBox1.Text.ToString();
            calc.MMinus();
        }

        private void TwoOperanddegree_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Twooperanddegree();
                texttop.Text = calc.numup;
                textBox1.Text = calc.num;
            }
        }

        private void Tendegree_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Tendegree();
                texttop.Text = calc.numup;
                textBox1.Text = calc.num;
            }
        }

        private void Log_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Log();
                texttop.Text = calc.numup;
                textBox1.Text = calc.num;
            }
        }

        private void ln_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Ln();
                texttop.Text = calc.numup;
                textBox1.Text = calc.num;
            }
        }

        private void Pi_Button(object sender, RoutedEventArgs e)
        {
            if (((textBox1.Text.Length == 0) || textBox1.Text == "0") && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Pi();
                texttop.Text = calc.numup;
                textBox1.Text = calc.num;
            }
        }

        private void Mod_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Mod();
                texttop.Text = calc.numup;
                textBox1.Text = calc.num;
            }
        }
        private void Sin_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Sin();
                texttop.Text = calc.numup;
                textBox1.Text = calc.num;
            }
        }

        private void Cos_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Cos();
                texttop.Text = calc.numup;
                textBox1.Text = calc.num;
            }
        }

        private void Tn_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Tg();
                texttop.Text = calc.numup;
                textBox1.Text = calc.num;
            }
        }

        private void Ctn_Button(object sender, RoutedEventArgs e)
        {
            if (!(textBox1.Text.Length == 0) && calc.warning == false)
            {
                calc.num = textBox1.Text.ToString();
                calc.Ctg();
                texttop.Text = calc.numup;
                textBox1.Text = calc.num;
            }
        }
    }
}
