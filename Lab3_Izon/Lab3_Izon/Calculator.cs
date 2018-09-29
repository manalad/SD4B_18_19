using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Izon
{   
    public partial class Calculator : Form
    {
      
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '3';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '4';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '5';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '6';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '7';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '8';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '9';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '0';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (DeclareVariable.dec == false)
            {
                textBox1.Text = textBox1.Text + '.';
            }
            DeclareVariable.dec = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeclareVariable.plusButtonClicked = true;
            DeclareVariable.minusButtonClicked = false;
            DeclareVariable.multiplyButtonClicked = false;
            DeclareVariable.divideButtonClicked = false;
            DeclareVariable.equalsButtonClicked = false;
            DeclareVariable.dec = false;
            DeclareVariable.total2 = Convert.ToDouble(textBox1.Text);
            if (textBox1.Text != null)
            {
                if (DeclareVariable.total1 != 0)
                {
                    DeclareVariable.total1 = DeclareVariable.total1 + DeclareVariable.total2;
                    DeclareVariable.total2 = 0;
                }
                else
                {
                    DeclareVariable.total1 = DeclareVariable.total2;
                    DeclareVariable.total2 = 0;
                }
                textBox1.Text = "";
                DeclareVariable.plusButtonClicked = true;
            }
            else
            {
                MessageBox.Show("Input A Number First");
            }
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DeclareVariable.plusButtonClicked = false;
            DeclareVariable.minusButtonClicked = true;
            DeclareVariable.multiplyButtonClicked = false;
            DeclareVariable.divideButtonClicked = false;
            DeclareVariable.equalsButtonClicked = false;
            DeclareVariable.dec = false;
            DeclareVariable.total2 = Convert.ToDouble(textBox1.Text);
            if (textBox1.Text != null)
            {
                if (DeclareVariable.total1 != 0)
                {
                    DeclareVariable.total1 = DeclareVariable.total1 - DeclareVariable.total2;
                    DeclareVariable.total2 = 0;
                }
                else
                {
                    DeclareVariable.total1 = DeclareVariable.total2;
                    DeclareVariable.total2 = 0;
                }
                textBox1.Text = "";
                DeclareVariable.minusButtonClicked = true;
            }
            else
            {
                MessageBox.Show("Input A Number First");
            }
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DeclareVariable.plusButtonClicked = false;
            DeclareVariable.minusButtonClicked = false;
            DeclareVariable.multiplyButtonClicked = true;
            DeclareVariable.divideButtonClicked = false;
            DeclareVariable.equalsButtonClicked = false;
            DeclareVariable.dec = false;
            DeclareVariable.total2 = Convert.ToDouble(textBox1.Text);
            if (textBox1.Text != null)
            {
                if (DeclareVariable.total1 != 0)
                {
                    DeclareVariable.total1 = DeclareVariable.total1 * DeclareVariable.total2;
                    DeclareVariable.total2 = 0;
                }
                else
                {
                    DeclareVariable.total1 = DeclareVariable.total2;
                    DeclareVariable.total2 = 0;
                }
                textBox1.Text = "";
                DeclareVariable.multiplyButtonClicked = true;
            }
            else
            {
                MessageBox.Show("Input A Number First");
            }
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DeclareVariable.plusButtonClicked = false;
            DeclareVariable.minusButtonClicked = false;
            DeclareVariable.multiplyButtonClicked = false;
            DeclareVariable.divideButtonClicked = true;
            DeclareVariable.equalsButtonClicked = false;
            DeclareVariable.dec = false;
            DeclareVariable.total2 = Convert.ToDouble(textBox1.Text);
            if (textBox1.Text != null)
            {
                if (DeclareVariable.total1 != 0)
                {
                    DeclareVariable.total1 = DeclareVariable.total1 / DeclareVariable.total2;
                    DeclareVariable.total2 = 0; 
                }
                else
                {
                    DeclareVariable.total1 = DeclareVariable.total2;
                    DeclareVariable.total2 = 0;
                }
                textBox1.Text = "";
                DeclareVariable.divideButtonClicked = true;
            }
            else
            {
                MessageBox.Show("Input A Number First");
            }
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //textBox1.Text = Convert.ToString(DeclareVariable.total1);

            if (DeclareVariable.plusButtonClicked == true)
            {
                DeclareVariable.total1 = DeclareVariable.total1 + Convert.ToDouble(textBox1.Text);
                
                textBox1.Text = Convert.ToString(DeclareVariable.total1);
            }
            if (DeclareVariable.minusButtonClicked == true)
            {
                DeclareVariable.total1 = DeclareVariable.total1 - Convert.ToDouble(textBox1.Text);
                
                textBox1.Text = Convert.ToString(DeclareVariable.total1);
            }
            if (DeclareVariable.multiplyButtonClicked == true)
            {
                DeclareVariable.total1 = DeclareVariable.total1 * Convert.ToDouble(textBox1.Text);
                
                textBox1.Text = Convert.ToString(DeclareVariable.total1);
            }
            if (DeclareVariable.divideButtonClicked == true)
            {
                DeclareVariable.total1 = DeclareVariable.total1 / Convert.ToDouble(textBox1.Text);
                
                textBox1.Text = Convert.ToString(DeclareVariable.total1);
            }
            DeclareVariable.total1 = 0;
            DeclareVariable.plusButtonClicked = false;
            DeclareVariable.minusButtonClicked = false;
            DeclareVariable.multiplyButtonClicked = false;
            DeclareVariable.divideButtonClicked = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
