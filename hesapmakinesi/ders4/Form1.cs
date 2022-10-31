using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String operasyon;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }
        double sayi1;
        private void button10_Click(object sender, EventArgs e)
        {

            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            operasyon = "+";

        }
        double sayi2;
        private void button13_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(textBox1.Text);
            if (operasyon == "+")
            {
                double sonuc = sayi1 + sayi2;
                textBox1.Text = sonuc.ToString();
            }
            if (operasyon == "-")
            {
                double sonuc = sayi1 - sayi2;
                textBox1.Text = sonuc.ToString();
            }
            if (operasyon == "*")
            {
                double sonuc = sayi1 * sayi2;
                textBox1.Text = sonuc.ToString();
            }
            if (operasyon == "/")
            {
                double sonuc = sayi1 / sayi2;
                textBox1.Text = sonuc.ToString();
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            operasyon = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            operasyon = "*";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            operasyon = "/";
        }
    }
}
