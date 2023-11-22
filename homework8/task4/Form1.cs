using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4
{
    public partial class Form1 : Form
    {
        string operation;
        public Form1()
        {
            InitializeComponent();
        }
        float Calculate(float operand1, float operand2, string operation)
        {
            if (operation == "%")
            {
                return operand1 % operand2;
            }
            else if (operation == "stage")
            {
                
                for (int i = 0; i < operand2; i++)
                {
                    operand1 *= operand1;
                }
                return operand1;
            }
            else if (operation == "concatenation")
            {
                return operand1 + operand2;
            }
            else if (operation == "/")
            {
                return operand1 / operand2;
            }
            else
            {
                return 0;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            operation = "%";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            operation = "stage";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            operation = "concatenation";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Calculate(float.Parse(textBox1.Text), float.Parse(textBox2.Text), operation)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            operation = "/";
        }
    }
}
