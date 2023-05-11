using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalcul
{
    public partial class Form1 : Form
    {
        double n1;
        double n2;
        double res; 
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            res = n1 - n2;
            label4.Text = Convert.ToString(res);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            res = n1 * n2;
            label4.Text = Convert.ToString(res);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            res = n1 / n2;
            label4.Text = Convert.ToString(res);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            res = n1 + n2;
            label4.Text = Convert.ToString(res); 

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
