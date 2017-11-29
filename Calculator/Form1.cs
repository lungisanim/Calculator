using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == "" && textBox1.Text == "0"))
            {
                textBox1.Text = /*textBox1.Text*/ "" + (double.Parse(textBox1.Text) * Math.PI);
            }
            else 
            {
                textBox1.Text = textBox1.Text + Math.PI;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text.Contains(button5.Text)))
            {
                textBox1.Text = textBox1.Text + button5.Text;
            }
            else 
            {
                textBox1.Text = textBox1.Text;
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button15.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(int.Parse(textBox1.Text), 2); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Clearing the screen");
            //textBox1.Text = textBox1.Text + "clearing the screen";
            textBox1.Clear();
            //textBox1.Text = textBox1.Text + textBox1.Text();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(int.Parse(textBox1.Text), 8);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(int.Parse(textBox1.Text), 16);
        }
    }
}
