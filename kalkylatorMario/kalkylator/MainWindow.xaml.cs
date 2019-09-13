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

namespace kalkylator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string newNr = "";
        int sum = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void adddigit(string nr)
        {
            TextBox1.Text += nr;
            newNr += nr;
        }

        private void Button_Summarize (object sender, RoutedEventArgs e)
        {
            sum = sum + Convert.ToInt32(newNr);
            newNr = "";
            TextBox1.Text = Convert.ToString(sum);
        }
        

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            sum += Convert.ToInt32(newNr);
            newNr = "";
            TextBox1.Text += "+";
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            adddigit("1");
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            adddigit("2");
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            adddigit("3");
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            adddigit("4");
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            adddigit("5");
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            adddigit("6");
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            adddigit("7");
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            adddigit("8");
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            adddigit("9");
        }
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            adddigit("0");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            sum = 0;
            newNr = "";
        }

        private void Button2_Click_1(object sender, RoutedEventArgs e)
        {
            adddigit("2");
        }

        private void Button3_Click_1(object sender, RoutedEventArgs e)
        {
            adddigit("3");
        }

        private void Button4_Click_1(object sender, RoutedEventArgs e)
        {
            adddigit("4");
        }

        private void Button5_Click_1(object sender, RoutedEventArgs e)
        {
            adddigit("5");
        }

        private void Button6_Click_1(object sender, RoutedEventArgs e)
        {
            adddigit("6");
        }

        private void Button7_Click_1(object sender, RoutedEventArgs e)
        {
            adddigit("7");
        }

        private void Button8_Click_1(object sender, RoutedEventArgs e)
        {
            adddigit("8");
        }

        private void Button9_Click_1(object sender, RoutedEventArgs e)
        {
            adddigit("9");
        }

        private void Button0_Click_1(object sender, RoutedEventArgs e)
        {
            adddigit("0");
        }
    }
}
