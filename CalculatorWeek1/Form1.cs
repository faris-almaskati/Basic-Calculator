using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatorWeek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        // THIS IS YOUR CALCULATE BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Convert text from inputs to numbers
            double num11 = Convert.ToDouble(num1.Text);
            double num22 = Convert.ToDouble(num2.Text);
            double result = 0;

            // 2. Check which radio button is active and do the math
            if (Addition.Checked)
            {
                result = num11 + num22;
            }
            else if (Subtraction.Checked)
            {
                result = num11 - num22;
            }
            else if (Multiplication.Checked)
            {
                result = num11 * num22;
            }
            else if (Division.Checked)
            {
                if (num22 != 0)
                {
                    result = num11 / num22;
                }
                else
                {
                    MessageBox.Show("Cannot divide by zero!");
                    return;
                }
            }

            // 3. Display the final answer in your display box
            // Note: If your display box is named something else (like displayTxt), change 'num3' to that name.
            num3.Text = result.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
        }

        private void num2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void Addition_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Multiplication_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Division_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
