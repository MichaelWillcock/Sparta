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
using CalculatorLib;

namespace Lab_11_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int _num1 = 0;
        private static int _num2 = 0;
        private static int _num3 = 0;
        private static string _operation = "";
        private static string _sumFinished = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddNumber_Click(object sender, RoutedEventArgs e)
        {
            if (_sumFinished.Length != 0)
            {
                LabelOutput.Content = "";
            }
            if (_operation.Length != 0)
            {
                string addNumber2 = (sender as Button).Content.ToString();
                if (_num2 == 0)
                {
                    _num2 = Int32.Parse(addNumber2);
                }
                else
                {
                    string num2 = _num2.ToString();
                    num2 = num2 + addNumber2;
                    _num2 = Int32.Parse(num2);
                }
                LabelOutput.Content = _num2;
            }
            else
            {
                string addNumber1 = (sender as Button).Content.ToString();
                if (_num1 == 0)
                {
                    _num1 = Int32.Parse(addNumber1);
                }
                else
                {
                    string num1 = _num1.ToString();
                    num1 = num1 + addNumber1;
                    _num1 = Int32.Parse(num1);
                }
                LabelOutput.Content = _num1;
            }
        }

        private void OperationAndOtherNumber_Click(object sender, RoutedEventArgs e)
        {
            LabelOutput.Content = "";
            if (sender.Equals(ButtonAdd))
            {
                _operation = "+";
            }
            else if (sender.Equals(ButtonSubtract))
            {
                _operation = "-";
            }
            else if (sender.Equals(ButtonMultiply))
            {
                _operation = "x";
            }
            else
            {
                _operation = "/";
            }
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            _sumFinished = "Yes";
            if (_operation.Contains("+"))
            {
                if (_num1 == 0)
                {
                    var answerAdd = Calculator.Add(_num3, _num2);
                    LabelOutput.Content = answerAdd;
                    _num3 = answerAdd;
                }
                else
                {
                    var answerAdd = Calculator.Add(_num1, _num2);
                    LabelOutput.Content = answerAdd;
                    _num3 = answerAdd;
                }
            }
            else if (_operation.Contains("-"))
            {
                if (_num1 == 0)
                {
                    var answerMinus = Calculator.Subtract(_num3, _num2);
                    LabelOutput.Content = answerMinus;
                    _num3 = answerMinus;
                }
                else
                {
                    var answerMinus = Calculator.Subtract(_num1, _num2);
                    LabelOutput.Content = answerMinus;
                    _num3 = answerMinus;
                }
            }
            else if (_operation.Contains("x"))
            {
                if (_num1 == 0)
                {
                    var answerTimes = Calculator.Multiply(_num3, _num2);
                    LabelOutput.Content = answerTimes;
                    _num3 = answerTimes;
                }
                else
                {
                    var answerTimes = Calculator.Multiply(_num1, _num2);
                    LabelOutput.Content = answerTimes;
                    _num3 = answerTimes;
                }
            }
            else if (_operation.Contains("/"))
            {
                int answerDivide = 0;
                if (_num1 == 0)
                {
                    try
                    {
                        answerDivide = Calculator.Divide(_num3, _num2);
                        LabelOutput.Content = answerDivide;
                    }
                    catch (DivideByZeroException)
                    {
                        LabelOutput.Content = "Error, cannot divide by zero";
                    }
                    _num3 = answerDivide;
                }
                else
                {
                    try
                    {
                        answerDivide = Calculator.Divide(_num1, _num2);
                        LabelOutput.Content = answerDivide;
                    }
                    catch (DivideByZeroException)
                    {
                        LabelOutput.Content = "Error, cannot divide by zero";
                    }
                    _num3 = answerDivide;
                }
            }
            else
            {
                LabelOutput.Content = "Error";
            }
            _num1 = 0;
            _num2 = 0;
            _operation = "";
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            _sumFinished = "";
            LabelOutput.Content = "";
            _operation = "";
            _num1 = 0;
            _num2 = 0;
            _num3 = 0;
        }
    }
}