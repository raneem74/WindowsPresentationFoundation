using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;


namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        char[] Operations = { '/', 'X', '-', '+' };

        private void Seven(object sender, RoutedEventArgs e)
        {
            Display.Text += "7";
        }

        private void Eight(object sender, RoutedEventArgs e)
        {
            Display.Text += "8";
        }

        private void Nine(object sender, RoutedEventArgs e)
        {
            Display.Text += "9";
        }

        private void Four(object sender, RoutedEventArgs e)
        {
            Display.Text += "4";
        }

        private void Five(object sender, RoutedEventArgs e)
        {
            Display.Text += "5";
        }

        private void Six(object sender, RoutedEventArgs e)
        {
            Display.Text += "6";
        }

        private void One(object sender, RoutedEventArgs e)
        {
            Display.Text += "1";
        }

        private void Two(object sender, RoutedEventArgs e)
        {
            Display.Text += "2";
        }

        private void Three(object sender, RoutedEventArgs e)
        {
            Display.Text += "3";
        }

        private void Zero(object sender, RoutedEventArgs e)
        {
            Display.Text += "0";
        }

        private void Divide(object sender, RoutedEventArgs e)
        {
            if (Display.Text != "" &&  !Operations.Contains(Display.Text[Display.Text.Length-1]) && Display.Text[Display.Text.Length - 1]!='.')
                Display.Text += "/";
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {
            if (Display.Text != "" &&  !Operations.Contains(Display.Text[Display.Text.Length-1]) && Display.Text[Display.Text.Length - 1] != '.' )
                Display.Text += "X";
        }

        private void Subtract(object sender, RoutedEventArgs e)
        {
            if (Display.Text != "" && !Operations.Contains(Display.Text[Display.Text.Length-1]) && Display.Text[Display.Text.Length - 1] != '.' )
                Display.Text += "-";
        }
        private void Plus(object sender, RoutedEventArgs e)
        {
            if (Display.Text != "" && !Operations.Contains(Display.Text[Display.Text.Length - 1]) && Display.Text[Display.Text.Length - 1] != '.' )
                Display.Text += "+";
        }

        private void Dot(object sender, RoutedEventArgs e)
        {
            if (Display.Text != "" && !Operations.Contains(Display.Text[Display.Text.Length - 1]) && Display.Text[Display.Text.Length - 1] != '.' )
                Display.Text += ".";
        }


        private void Equal(object sender, RoutedEventArgs e)
        {
            string Equation = Display.Text, textNumber1 = string.Empty;
            char operation= default;
            decimal result = 0, number1;

            for (int i=0; i<Display.Text.Length || textNumber1!=string.Empty; i++) 
            {
                bool isLastNumber = i >= Display.Text.Length;

                if ( !isLastNumber && !Operations.Contains(Display.Text[i]) )
                {
                        textNumber1 += Display.Text[i];
                }
                else
                {
                    if (operation==default && !isLastNumber)
                    {
                        decimal.TryParse(textNumber1, out result);
                        operation = Display.Text[i];
                        textNumber1 = string.Empty;
                    }
                    else
                    {
                        decimal.TryParse(textNumber1, out number1);
                        switch (operation)
                        {
                            case '+':
                                result += number1;
                                break;
                            case 'X':
                                result *= number1;
                                break;
                            case '-':
                                result -= number1;
                                break;
                            case '/':
                                if (number1 != 0)
                                    result /= number1;
                                else
                                    MessageBox.Show("You can't divide number by zero!",
                                    "Error",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                                break;
                        }

                        if (!isLastNumber)
                            operation = Display.Text[i];
                        textNumber1 = string.Empty;
                    }
                }
            }
            Display.Text = result.ToString();
        }
    }
}
