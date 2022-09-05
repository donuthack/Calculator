using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int first_number;
        int second_number;
        char option;
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void Button7_Click(object sender, RoutedEventArgs e)
        //{
        //    NumbersInputOutput.Text += Button7.Content;
        //}

        //private void Button8_Click(object sender, RoutedEventArgs e)
        //{
        //    NumbersInputOutput.Text += Button8.Content;
        //}

        //private void Button9_Click(object sender, RoutedEventArgs e)
        //{
        //    NumbersInputOutput.Text += Button9.Content;
        //}

        //private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        //{
        //    NumbersInputOutput.Text += ButtonMultiply.Content;
        //}

        //private void Button4_Click(object sender, RoutedEventArgs e)
        //{
        //    NumbersInputOutput.Text += Button4.Content;
        //}

        //private void Button5_Click(object sender, RoutedEventArgs e)
        //{
        //    NumbersInputOutput.Text += Button5.Content;
        //}

        //private void Button6_Click(object sender, RoutedEventArgs e)
        //{
        //    NumbersInputOutput.Text += Button6.Content;
        //}

        //private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        //{
        //    NumbersInputOutput.Text += ButtonMinus.Content;
        //}

        //private void Button1_Click(object sender, RoutedEventArgs e)
        //{
        //    NumbersInputOutput.Text += Button1.Content;
        //}

        //private void Button2_Click(object sender, RoutedEventArgs e)
        //{
        //    NumbersInputOutput.Text += Button2.Content;
        //}

        //private void Button3_Click(object sender, RoutedEventArgs e)
        //{
        //    NumbersInputOutput.Text += Button3.Content;
        //}

        //private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        //{
        //    NumbersInputOutput.Text = NumbersInputOutput.Text + " " + ButtonPlus.Content;
        //}

        //private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        //{
        //    NumbersInputOutput.Text += ButtonDivide.Content;
        //}

        //private void Button0_Click(object sender, RoutedEventArgs e)
        //{
        //    NumbersInputOutput.Text += Button0.Content;
        //}

        //private void ButtonClear_Click(object sender, RoutedEventArgs e)
        //{
        //    NumbersInputOutput.Text += ButtonClear.Content;
        //}

        //private void ButtonIs_Click(object sender, RoutedEventArgs e)
        //{
        //    //NumbersInputOutput.Text += ButtonIs.Content;
            
        //    ConcatenateToString();
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            NumbersInputOutput.Text += btn.Content;
            second_number = Int16.Parse(NumbersInputOutput.Text);
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            first_number = Int16.Parse(NumbersInputOutput.Text);
            option = '-';
            NumbersInputOutput.Text = "";

        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            first_number = Int16.Parse(NumbersInputOutput.Text);
            option = '*';
            NumbersInputOutput.Text = "";
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            first_number = Int16.Parse(NumbersInputOutput.Text);
            option = '+';
            NumbersInputOutput.Text = "";
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            first_number = Int16.Parse(NumbersInputOutput.Text);
            option = '/';
            NumbersInputOutput.Text = " ";
        }

        private void ButtonIs_Click(object sender, RoutedEventArgs e)
        {
            second_number = Int16.Parse(NumbersInputOutput.Text);
            int result = 0;

            if (option == '+')
            {
                result = first_number + second_number;
            }
            else if (option == '-')
            {
                result = first_number - second_number;
            }
            else if (option == '*')
            {
                result = first_number * second_number;
            }
            else if (option == '/')
            {
                result = first_number / second_number;
            }
            NumbersInputOutput.Text = result.ToString();
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            NumbersInputOutput.Text = "";
        }
    }
}