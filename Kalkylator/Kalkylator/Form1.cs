using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkylator
{
    public partial class Form1 : Form
    {
        int sum = 0;
        string newNr = "";

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Adddigit(string nr)
        {
            textBox1.AppendText(nr);
            newNr += nr;
        }
        private void Summarize ()
        {
            sum = sum + Convert.ToInt32(newNr);
            newNr = "";
            textBox1.Text = Convert.ToString(sum);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Adddigit("1");
        }

        private void button9_Click(object sender, EventArgs e)
        {
             Adddigit("9");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Adddigit("0");
        }

        
        
        private void button2_Click(object sender, EventArgs e)
        {
            Adddigit("2");
        }

        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("+");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adddigit("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Adddigit("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Adddigit("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Adddigit("6");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Adddigit("7");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Adddigit("8");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Adddigit("-");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(new DataTable().Compute(textBox1.Text, null));
            textBox1.Text = result.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("*");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("/");
        }
    }
}
