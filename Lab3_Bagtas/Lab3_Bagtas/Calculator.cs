using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Bagtas
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

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
            textBox1.Text = textBox1.Text + "3";
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            if (DeclareVar.minusButtonClicked == true)
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 - double.Parse(textBox1.Text)).ToString();
            }
            else if (DeclareVar.minusButtonClicked == true)
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 * double.Parse(textBox1.Text)).ToString();
            }
            else if (DeclareVar.multiplyButtonClicked == true)
            {

            }
            else if (DeclareVar.divideButtonClicked == true)
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 / double.Parse(textBox1.Text)).ToString();
            }
            if (DeclareVar.plusButtonClicked == false)
            {
                DeclareVar.total1 = System.Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                DeclareVar.plusButtonClicked = true;
                DeclareVar.minusButtonClicked = false;
                DeclareVar.multiplyButtonClicked = false;
                DeclareVar.divideButtonClicked = false;
            }
            else
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 + double.Parse(textBox1.Text)).ToString();
                DeclareVar.total1 = System.Convert.ToDouble(textBox1.Text);
                textBox1.Clear();

            }
        }





        private void buttonsubtract_Click(object sender, EventArgs e)
        {

            if (DeclareVar.plusButtonClicked == true)
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 + double.Parse(textBox1.Text)).ToString();
            }
            else if (DeclareVar.divideButtonClicked == true)
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 / double.Parse(textBox1.Text)).ToString();
            }
            else if (DeclareVar.multiplyButtonClicked == true)
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 * double.Parse(textBox1.Text)).ToString();
            }

            if (DeclareVar.minusButtonClicked == false)
            {
                DeclareVar.total1 = System.Convert.ToDouble(textBox1.Text);
                textBox1.Clear();

                DeclareVar.minusButtonClicked = true;
                DeclareVar.plusButtonClicked = false;
                DeclareVar.multiplyButtonClicked = false;
                DeclareVar.divideButtonClicked = false;
            }
            else
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 - double.Parse(textBox1.Text)).ToString();
                DeclareVar.total1 = System.Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
            }

        }

        private void buttonmultiply_Click(object sender, EventArgs e)
        {
            if (DeclareVar.plusButtonClicked == true)
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 + double.Parse(textBox1.Text)).ToString();
            }
            else if (DeclareVar.minusButtonClicked == true)
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 - double.Parse(textBox1.Text)).ToString();
            }
            else if (DeclareVar.divideButtonClicked == true)
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 / double.Parse(textBox1.Text)).ToString();
            }

            if (DeclareVar.multiplyButtonClicked == false)
            {
                DeclareVar.total1 = System.Convert.ToDouble(textBox1.Text);
                textBox1.Clear();

                DeclareVar.minusButtonClicked = false;
                DeclareVar.plusButtonClicked = false;
                DeclareVar.multiplyButtonClicked = true;
                DeclareVar.divideButtonClicked = false;

            }
            else
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 * double.Parse(textBox1.Text)).ToString();
                DeclareVar.total1 = System.Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (DeclareVar.plusButtonClicked == true)
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 + double.Parse(textBox1.Text)).ToString();
            }
            else if (DeclareVar.minusButtonClicked == true)
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 - double.Parse(textBox1.Text)).ToString();
            }
            else if (DeclareVar.multiplyButtonClicked == true)
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 * double.Parse(textBox1.Text)).ToString();
            }

            if (DeclareVar.divideButtonClicked == false)
            {
                DeclareVar.total1 = System.Convert.ToDouble(textBox1.Text);
                textBox1.Clear();

                DeclareVar.minusButtonClicked = false;
                DeclareVar.plusButtonClicked = false;
                DeclareVar.multiplyButtonClicked = false;
                DeclareVar.divideButtonClicked = true;
            }
            else
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 / double.Parse(textBox1.Text)).ToString();
                DeclareVar.total1 = System.Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
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

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {

            if (DeclareVar.plusButtonClicked == true)
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 + double.Parse(textBox1.Text)).ToString();
                DeclareVar.plusButtonClicked = false;
            }
            else if (DeclareVar.minusButtonClicked == true)
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 - double.Parse(textBox1.Text)).ToString();
                DeclareVar.minusButtonClicked = false;
            }
            else if (DeclareVar.multiplyButtonClicked == true)
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 * double.Parse(textBox1.Text)).ToString();
                DeclareVar.multiplyButtonClicked = false;
            }
            else if (DeclareVar.divideButtonClicked == true)
            {
                textBox1.Text = (DeclareVar.total1 = DeclareVar.total1 / double.Parse(textBox1.Text)).ToString();
                DeclareVar.divideButtonClicked = false;
            }
        }
    }
}











