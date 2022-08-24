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
using System.Data;

namespace calculatorv2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int _firstNum;
        private char? _operator;

        public MainWindow()
        {
            InitializeComponent();
        }

        //Number 1
        private void number1_Click(object sender, RoutedEventArgs e)
        {
            int number1 = 1;
            displaybox.Text += number1;
        }
        //Number 2
        private void number2_Click(object sender, RoutedEventArgs e)
        {
            int number2 = 2;
            displaybox.Text += number2;
        }
        //Number 3
        private void number3_Click(object sender, RoutedEventArgs e)
        {
            int number3 = 3;
            displaybox.Text += number3;
        }
        //Number 4
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int number4 = 4;
            displaybox.Text += number4;
        }
        //Number 5
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            int number5 = 5;
            displaybox.Text += number5;
        }
        //Number 6
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            int number6 = 6;
            displaybox.Text += number6;
        }
        //Number 7
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            int number7 = 7;
            displaybox.Text += number7;
        }
        //Number 8
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            int number8 = 8;
            displaybox.Text += number8;
        }
        //Number 9
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            int number9 = 9;
            displaybox.Text += number9;
        }
        //Number 0
        private void button0_Click(object sender, RoutedEventArgs e)
        {
            int number0 = 0;
            displaybox.Text += number0;
        }

        //Addition    
        private void addition_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _firstNum = int.Parse(displaybox.Text);
                displaybox.Text = "";
                _operator = '+';
            }
            catch { }
        }
        //Subtraction
        private void subtraction_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _firstNum = int.Parse(displaybox.Text);
                displaybox.Text = "";
                _operator = '-';
            }
            catch { }
        }
        //Divide
        private void divide_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _firstNum = int.Parse(displaybox.Text);
                displaybox.Text = "";
                _operator = '%';
            }
            catch { }
        }
        //Multiply
        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _firstNum = int.Parse(displaybox.Text);
                displaybox.Text = "";
                _operator = '*';
            }
            catch { }
        }

        //Equals
        private void equals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (_operator)
                {
                    case '+':
                        int resultPlus = _firstNum + int.Parse(displaybox.Text);
                        displaybox.Text = "" + resultPlus;
                        break;
                    case '-':
                        int resultMinus = _firstNum - int.Parse(displaybox.Text);
                        displaybox.Text = "" + resultMinus;
                        break;
                    case '%':
                        int resultDivide = _firstNum / int.Parse(displaybox.Text);
                        displaybox.Text = "" + resultDivide;
                        break;
                    case '*':
                        int resultMultiply = _firstNum * int.Parse(displaybox.Text);
                        displaybox.Text = "" + resultMultiply;
                        break;
                }
            }
            catch { displaybox.Text = "Error"; }

        }

        //Clear Screen
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            displaybox.Text = "";
            _operator = null;

        }

        
    }
}
