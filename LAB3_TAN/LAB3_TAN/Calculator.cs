using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_TAN
{
    public partial class Calculator : Form
    {
        Int32 a = 0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
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

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            a = 0;
            DeclareVariables.total1 = 0;
            DeclareVariables.total1 = 0;

            textBox1.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DeclareVariables.btnAdd = true;
            a = 0;
            if(textBox1.Text == "")
            {
                MessageBox.Show("Please Input A Number before Selecting Operation");
            }
            else if(DeclareVariables.total1 == 0)
            {
                DeclareVariables.total1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else if(DeclareVariables.total2 == 0 && DeclareVariables.total1 != 0)
            {
                DeclareVariables.total1 = Convert.ToDouble(textBox1.Text) + DeclareVariables.total1;
                textBox1.Text = "";


            }
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            a = 0;
            if (DeclareVariables.total1 != 0)
            {

                if (DeclareVariables.btnAdd == true)
                {
                    DeclareVariables.total2 = Convert.ToDouble(textBox1.Text);
                    DeclareVariables.total2 = DeclareVariables.total1 + DeclareVariables.total2;
                    textBox1.Text = DeclareVariables.total2.ToString();


                    DeclareVariables.total1 = 0;
                    DeclareVariables.total2 = 0;
                    DeclareVariables.btnAdd = false;
                    DeclareVariables.btnDiff = false;
                    DeclareVariables.btnMul = false;
                    DeclareVariables.btnDiv = false;

                }
                else if (DeclareVariables.btnDiff == true)
                {
                    DeclareVariables.total2 = Convert.ToDouble(textBox1.Text);
                    DeclareVariables.total2 = DeclareVariables.total1 - DeclareVariables.total2;
                    textBox1.Text = DeclareVariables.total2.ToString();

                    DeclareVariables.total1 = 0;
                    DeclareVariables.total2 = 0;
                    DeclareVariables.btnAdd = false;
                    DeclareVariables.btnDiff = false;
                    DeclareVariables.btnMul = false;
                    DeclareVariables.btnDiv = false;

                }
                else if (DeclareVariables.btnMul == true)
                {
                    DeclareVariables.total2 = Convert.ToDouble(textBox1.Text);
                    DeclareVariables.total2 = DeclareVariables.total1 * DeclareVariables.total2;
                    textBox1.Text = DeclareVariables.total2.ToString();

                    DeclareVariables.total1 = 0;
                    DeclareVariables.total2 = 0;

                    DeclareVariables.btnAdd = false;
                    DeclareVariables.btnDiff = false;
                    DeclareVariables.btnMul = false;
                    DeclareVariables.btnDiv = false;
                }
                else if (DeclareVariables.btnDiv == true)
                {
                    DeclareVariables.total2 = Convert.ToDouble(textBox1.Text);
                    DeclareVariables.total2 = DeclareVariables.total1 / DeclareVariables.total2;
                    textBox1.Text = DeclareVariables.total2.ToString();

                    DeclareVariables.total1 = 0;
                    DeclareVariables.total2 = 0; 
                    DeclareVariables.btnAdd = false;
                    DeclareVariables.btnDiff = false;
                    DeclareVariables.btnMul = false;
                    DeclareVariables.btnDiv = false;
                }
            }
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            DeclareVariables.btnDiff = true;
            a = 0;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Input A Number before Selecting Operation");
            }
            else if (DeclareVariables.total1 == 0)
            {
                DeclareVariables.total1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else if (DeclareVariables.total2 == 0 && DeclareVariables.total1 != 0)
            {
                DeclareVariables.total1 = Convert.ToDouble(textBox1.Text) + DeclareVariables.total1;
                textBox1.Text = "";


            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            a = 0;
            DeclareVariables.btnMul = true;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Input A Number before Selecting Operation");
            }
            else if (DeclareVariables.total1 == 0)
            {
                DeclareVariables.total1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else if (DeclareVariables.total2 == 0 && DeclareVariables.total1 != 0)
            {
                DeclareVariables.total1 = Convert.ToDouble(textBox1.Text) + DeclareVariables.total1;
                textBox1.Text = "";


            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            a = 0;
            DeclareVariables.btnDiv = true;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Input A Number before Selecting Operation");
            }
            else if (DeclareVariables.total1 == 0)
            {
                DeclareVariables.total1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else if (DeclareVariables.total2 == 0 && DeclareVariables.total1 != 0)
            {
                DeclareVariables.total1 = Convert.ToDouble(textBox1.Text) + DeclareVariables.total1;
                textBox1.Text = "";


            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            while (a < 1){ 
            textBox1.Text = textBox1.Text + ".";
                a += 1;

            }
        }
    }
}
