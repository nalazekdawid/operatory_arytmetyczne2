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

namespace operatory_arytmetyczne
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
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            textBlock4.Text = textBlock5.Text = "";
            
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            dzialanie(Convert.ToDouble(textBox.Text), Convert.ToDouble(textBox1.Text), 0);
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            dzialanie(Convert.ToDouble(textBox.Text), Convert.ToDouble(textBox1.Text), 1);
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            dzialanie(Convert.ToDouble(textBox.Text), Convert.ToDouble(textBox1.Text), 2);
        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            dzialanie(Convert.ToDouble(textBox.Text), Convert.ToDouble(textBox1.Text), 3);
        }

        private void radioButton4_Checked(object sender, RoutedEventArgs e)
        {
            dzialanie(Convert.ToDouble(textBox.Text), Convert.ToDouble(textBox1.Text), 4);
        }
        private void dzialanie (double arg1, double arg2, int zadanie)
        {
            if (zadanie == 0)
            {
                textBlock4.Text = textBox.Text + " + " + textBox1.Text;
                textBlock5.Text = Convert.ToString(arg1 + arg2);
            }
            else if (zadanie == 1)
            {
                textBlock4.Text = textBox.Text + " - " + textBox1.Text;
                textBlock5.Text = Convert.ToString(arg1 - arg2);
            }
            else if (zadanie == 2)
            {
                textBlock4.Text = textBox.Text + " * " + textBox1.Text;
                textBlock5.Text = Convert.ToString(arg1 * arg2);
            }
            else if (zadanie == 3)
            {
                textBlock4.Text = textBox.Text + " / " + textBox1.Text;
                textBlock5.Text = Convert.ToString(arg1 / arg2);
            }
            else if (zadanie == 4)
            {
                textBlock4.Text = textBox.Text + " % " + textBox1.Text;
                textBlock5.Text = Convert.ToString(arg1 % arg2);
            }

        }
    }
}
