using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Veysel_s_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number1;
        string Operation="";
        bool Rad_or_Degree = false, Answer_Displayed = false;
        double Answer;
        public Result result
        { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            result = new Result { Num1="0"};
            this.DataContext = result;
        }
        /*public string RemoveBrackets(string text)
        {
            while(Display_Process.Text.Contains('(') && Display_Process.Text.Contains(')'))
            {
                int openIndex = 0;
                int closeIndex = 0;
                for(int i=0;i< Display_Process.Text.Length; i++)
                {
                    if(text[i] == '(')
                    {
                        openIndex = i;
                    }
                    if(text[i] == ')')
                    {
                        closeIndex = i;

                        Display_Process.Text = 
                            Display_Process.Text.Remove(openIndex, closeIndex - openIndex + 1).
                            Insert(openIndex, ResolveBrackets(openIndex, closeIndex, Display_Process.Text));
                        break;
                    }
                }
            }
            return Calculate(Display_Process.Text);
        }*/
        public string Calculate(string text)
        {
            double finalAnswer = 3.15;/*Substract(Display_Process.Text);*/
            string ans = finalAnswer.ToString();
            return ans;
        }
        /*public double Substract(string text, char sign)
        {
            double result = 0;
            string[] words;

           

            result = Convert.ToDouble(text);
            return result;
        }*/
       /* public string ResolveBrackets(int openIndex, int closeIndex, string text)
        {
            string bracketAnswer = Calculate(Display_Process.Text.Substring(openIndex + 1, closeIndex - openIndex - 1));
            return bracketAnswer;
        }*/

        private void First_Check(string element)
        {
            if (Display_Process.Text == "0" || Answer_Displayed)
            {
                Display_Process.Text = element;
                Answer_Displayed = false;
            }
            else
                Display_Process.Text = Display_Process.Text + element;
        }
        private void Operations_Func(string element)
        {
            number1 = Convert.ToDouble(Display_Process.Text);
            Operation = element;
            Display_Process.Text = "0";
            Operation_Display.Text = "Op: " + element;
        }
        private double Make_Operation()
        {
            double result = 1;
            switch (Operation)
            {
                case "+":
                    result = number1 + Convert.ToDouble(Display_Process.Text);
                    break;
                case "-":
                    result = number1 - Convert.ToDouble(Display_Process.Text);
                    break;
                case "*":
                    result = number1 * Convert.ToDouble(Display_Process.Text);
                    break;
                case "/":
                    result = number1 / Convert.ToDouble(Display_Process.Text);
                    break;
                case "%":
                    result = number1 % Convert.ToDouble(Display_Process.Text);
                    break;
                case "!":
                    for (double i = number1; i > 0.0; i--)
                        result *= i;
                    break;
                case "Pow":
                    result = Math.Pow(number1, Convert.ToDouble(Display_Process.Text));
                    break;
                case "Root":
                    result = Math.Sqrt(Convert.ToDouble(Display_Process.Text));
                    break;
                case "log":
                    result = Math.Log10(Convert.ToDouble(Display_Process.Text));
                    break;
                case "ln":
                    result = Math.Log(Convert.ToDouble(Display_Process.Text));
                    break;
                case "EXP":
                    result = number1 * Math.Pow(10, Convert.ToDouble(Display_Process.Text));
                    break;
                case "tan":
                    if(!Rad_or_Degree)
                        result = Math.Tan(Convert.ToDouble(Display_Process.Text) * Math.PI / 180);
                    else
                        result = Math.Tan(Convert.ToDouble(Display_Process.Text));
                    break;
                case "sin":
                    if (!Rad_or_Degree)
                        result = Math.Sin(Convert.ToDouble(Display_Process.Text) * Math.PI / 180);
                    else
                        result = Math.Sin(Convert.ToDouble(Display_Process.Text));
                    break;
                case "cos":
                    if (!Rad_or_Degree)
                        result = Math.Cos(Convert.ToDouble(Display_Process.Text) * Math.PI / 180);
                    else
                        result = Math.Cos(Convert.ToDouble(Display_Process.Text));
                    break;
                default:
                    break;
            }
            Operation = "";
            Operation_Display.Text = "";
            Answer = result;
            return result;
        }

        // Column 0
        private void Ans_Button_Click(object sender, RoutedEventArgs e)
        {
            // Call Answer;
            Display_Process.Text = Convert.ToString(Answer);
        }
        private void e_Button_Click(object sender, RoutedEventArgs e)
        {
            Display_Process.Text = Convert.ToString(2.71828182846);
        }
        private void PI_Button_Click(object sender, RoutedEventArgs e)
        {
            Display_Process.Text = Convert.ToString(3.14159265359);
        }
        private void Inv_Button_Click(object sender, RoutedEventArgs e)
        {
            // Change Some Operations on the Calculator.

        }
        private void Rad_Button_Click(object sender, RoutedEventArgs e)
        {
            Rad_or_Degree = true;
            RadOrDeg.Text = "Rad";
        }

        // Column 1
        private void EXP_Button_Click(object sender, RoutedEventArgs e)
        {
            Operations_Func("EXP");
        }
        private void tan_Button_Click(object sender, RoutedEventArgs e)
        {
            Operation = "tan";
            Operation_Display.Text = "Op: " + Operation;
        }
        private void cos_Button_Click(object sender, RoutedEventArgs e)
        {
            Operation = "cos";
            Operation_Display.Text = "Op: " + Operation;
        }
        private void sin_Button_Click(object sender, RoutedEventArgs e)
        {
            Operation = "sin";
            Operation_Display.Text = "Op: " + Operation;
        }
        private void Deg_Button_Click(object sender, RoutedEventArgs e)
        {
            Rad_or_Degree = false;
            RadOrDeg.Text = "Deg";
        }

        // Column 2
        private void Over_Button_Click(object sender, RoutedEventArgs e)
        {
            Operations_Func("Pow");
        }
        private void Root_Button_Click(object sender, RoutedEventArgs e)
        {
            Operation = "Root";
            Operation_Display.Text = "Op: " + Operation;
        }
        private void log_Button_Click(object sender, RoutedEventArgs e)
        {
            Operation = "log";
            Operation_Display.Text = "Op: " + Operation;
        }
        private void ln_Button_Click(object sender, RoutedEventArgs e)
        {
            Operation = "ln";
            Operation_Display.Text = "Op: " + Operation;
        }
        private void Factor_Button_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(Display_Process.Text);
            Display_Process.Text += "!";
            Operation = "!";
            Operation_Display.Text = "Op: " + Operation;
        }

        // Column 3
        private void Zero_Button_Click(object sender, RoutedEventArgs e)
        {
            First_Check("0");
        }
        private void One_Button_Click(object sender, RoutedEventArgs e)
        {
            First_Check("1");
        }
        private void Four_Button_Click(object sender, RoutedEventArgs e)
        {
            First_Check("4");
        }
        private void Seven_Button_Click(object sender, RoutedEventArgs e)
        {
            First_Check("7");
        }
        private void LP_Button_Click(object sender, RoutedEventArgs e)
        {
            //First_Check("(");
        }
        // Column 4
        private void Dot_Button_Click(object sender, RoutedEventArgs e)
        {
            First_Check(",");
        }
        private void Two_Button_Click(object sender, RoutedEventArgs e)
        {
            First_Check("2");
        }
        private void Five_Button_Click(object sender, RoutedEventArgs e)
        {
            First_Check("5");
        }
        private void Eight_Button_Click(object sender, RoutedEventArgs e)
        {
            First_Check("8");
        }
        private void RP_Button_Click(object sender, RoutedEventArgs e)
        {
            //First_Check(")");
        }

        // Column 5
        private void Eq_Button_Click(object sender, RoutedEventArgs e)
        {
            if(Operation != "")
                Display_Process.Text = Convert.ToString(Make_Operation());
            Answer_Displayed = true;
        }
        private void Three_Button_Click(object sender, RoutedEventArgs e)
        {
            First_Check("3");
        }
        private void Six_Button_Click(object sender, RoutedEventArgs e)
        {
            First_Check("6");
        }
        private void Nine_Button_Click(object sender, RoutedEventArgs e)
        {
            First_Check("9");
        }
        private void Mode_Button_Click(object sender, RoutedEventArgs e)
        {
            Operations_Func("%");
        }

        // Column 6
        private void AC_Button_Click(object sender, RoutedEventArgs e)
        {
            Display_Process.Text = "0";
        }

        private void Plus_Button_Click(object sender, RoutedEventArgs e)
        {
            // Add
            Operations_Func("+");
        }
        private void Negative_Button_Click(object sender, RoutedEventArgs e)
        {
            // Minus
            Operations_Func("-");
        }
        private void Multiply_Button_Click(object sender, RoutedEventArgs e)
        {
            // Multiply
            Operations_Func("*");
        }
        private void Divide_Button_Click(object sender, RoutedEventArgs e)
        {
            // Divide
            Operations_Func("/");
        }
    }
}
