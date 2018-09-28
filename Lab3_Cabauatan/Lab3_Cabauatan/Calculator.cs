using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Form1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            txtCompute.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCompute.Text = txtCompute.Text + "1";
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtCompute.Clear();
            txtCompute.Select();
            DeclareVariable.pointClicked = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCompute.Text = txtCompute.Text + "2";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            txtCompute.Text = txtCompute.Text + "3";
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCompute.Text = txtCompute.Text + "4";
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtCompute.Text = txtCompute.Text + "5";
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtCompute.Text = txtCompute.Text + "6";
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtCompute.Text = txtCompute.Text + "7";
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtCompute.Text = txtCompute.Text + "8";
         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtCompute.Text = txtCompute.Text + "9";
        
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtCompute.Text = txtCompute.Text + "0";
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (DeclareVariable.pointClicked == false)
            {
                if (txtCompute.Text == "")
                {
                    txtCompute.Text = txtCompute.Text + "0.";
                    DeclareVariable.pointClicked = true;
                }
                else
                {
                    txtCompute.Text = txtCompute.Text + ".";
                    DeclareVariable.pointClicked = true;
                }
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (DeclareVariable.minusButtonClicked == true)
            {
                txtCompute.Text = (DeclareVariable.total1 - Convert.ToDouble(txtCompute.Text)).ToString();
            }
            else if (DeclareVariable.multiplyButtonClicked == true)
            {
                txtCompute.Text = (DeclareVariable.total1 * Convert.ToDouble(txtCompute.Text)).ToString();
            }
            else if (DeclareVariable.divideButtonClicked == true)
            {
                txtCompute.Text = (DeclareVariable.total1 / Convert.ToDouble(txtCompute.Text)).ToString();
            }
            if (DeclareVariable.plusButtonClicked == false)
            {
                DeclareVariable.total1 = Convert.ToDouble(txtCompute.Text);
                txtCompute.Clear();
                DeclareVariable.minusButtonClicked = false;
                DeclareVariable.plusButtonClicked = true;
                DeclareVariable.multiplyButtonClicked = false;
                DeclareVariable.divideButtonClicked = false;
                DeclareVariable.pointClicked = false;
            }
            else 
            {
                DeclareVariable.total1 = DeclareVariable.total1 + Convert.ToDouble(txtCompute.Text);
                txtCompute.Text = Convert.ToString(DeclareVariable.total1);
                DeclareVariable.total1 = Convert.ToDouble(txtCompute.Text);
                txtCompute.Clear();
                DeclareVariable.minusButtonClicked = false;
                DeclareVariable.plusButtonClicked = true;
                DeclareVariable.multiplyButtonClicked = false;
                DeclareVariable.divideButtonClicked = false;
                DeclareVariable.pointClicked = false;
                
            }

           
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (DeclareVariable.plusButtonClicked == true)
            {
                txtCompute.Text = (DeclareVariable.total1 + Convert.ToDouble(txtCompute.Text)).ToString();
            }
            else if (DeclareVariable.multiplyButtonClicked == true) 
            {
                txtCompute.Text = (DeclareVariable.total1 * Convert.ToDouble(txtCompute.Text)).ToString();
            }
            else if (DeclareVariable.divideButtonClicked == true)
            {
                txtCompute.Text = (DeclareVariable.total1 / Convert.ToDouble(txtCompute.Text)).ToString();
            }
            
            if (DeclareVariable.minusButtonClicked == false)
            {
                DeclareVariable.total1 = Convert.ToDouble(txtCompute.Text);
                txtCompute.Clear();
                DeclareVariable.minusButtonClicked = true;
                DeclareVariable.plusButtonClicked = false;
                DeclareVariable.multiplyButtonClicked = false;
                DeclareVariable.divideButtonClicked = false;
                DeclareVariable.pointClicked = false;
            }
            else 
            {
                DeclareVariable.total1 = Convert.ToDouble(txtCompute.Text) - DeclareVariable.total1;
                txtCompute.Text = Convert.ToString(DeclareVariable.total1);
                DeclareVariable.total1 = Convert.ToDouble(txtCompute.Text);
                txtCompute.Clear();
                DeclareVariable.minusButtonClicked = true;
                DeclareVariable.plusButtonClicked = false;
                DeclareVariable.multiplyButtonClicked = false;
                DeclareVariable.divideButtonClicked = false;
                DeclareVariable.pointClicked = false;
               
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (DeclareVariable.plusButtonClicked == true) {
                
                txtCompute.Text = (DeclareVariable.total1 + Convert.ToDouble(txtCompute.Text)).ToString();
                DeclareVariable.minusButtonClicked = false;
                DeclareVariable.plusButtonClicked = false;
                DeclareVariable.multiplyButtonClicked = false;
                DeclareVariable.divideButtonClicked = false;
                DeclareVariable.pointClicked = false;
                
            }
            else if (DeclareVariable.minusButtonClicked == true)
            {
                
                txtCompute.Text = (DeclareVariable.total1 - Convert.ToDouble(txtCompute.Text)).ToString();
                DeclareVariable.minusButtonClicked = false;
                DeclareVariable.plusButtonClicked = false;
                DeclareVariable.multiplyButtonClicked = false;
                DeclareVariable.divideButtonClicked = false;
                DeclareVariable.pointClicked = false;

            }
            else if (DeclareVariable.multiplyButtonClicked == true)
            {

                txtCompute.Text = (DeclareVariable.total1 * Convert.ToDouble(txtCompute.Text)).ToString();
                DeclareVariable.minusButtonClicked = false;
                DeclareVariable.plusButtonClicked = false;
                DeclareVariable.multiplyButtonClicked = false;
                DeclareVariable.divideButtonClicked = false;
                DeclareVariable.pointClicked = false;

            }
            else if (DeclareVariable.divideButtonClicked == true)
            {

                txtCompute.Text = (DeclareVariable.total1 / Convert.ToDouble(txtCompute.Text)).ToString();
                DeclareVariable.minusButtonClicked = false;
                DeclareVariable.plusButtonClicked = false;
                DeclareVariable.multiplyButtonClicked = false;
                DeclareVariable.divideButtonClicked = false;
                DeclareVariable.pointClicked = false;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (DeclareVariable.plusButtonClicked == true)
            {
                txtCompute.Text = (DeclareVariable.total1 + Convert.ToDouble(txtCompute.Text)).ToString();
            }
            else if (DeclareVariable.minusButtonClicked == true)
            {
                txtCompute.Text = (DeclareVariable.total1 - Convert.ToDouble(txtCompute.Text)).ToString();
            }
            else if (DeclareVariable.divideButtonClicked == true)
            {
                txtCompute.Text = (DeclareVariable.total1 / Convert.ToDouble(txtCompute.Text)).ToString();
            }
            if (DeclareVariable.multiplyButtonClicked == false)
            {
                DeclareVariable.total1 = Convert.ToDouble(txtCompute.Text);
                txtCompute.Clear();
                DeclareVariable.minusButtonClicked = false;
                DeclareVariable.plusButtonClicked = false;
                DeclareVariable.multiplyButtonClicked = true;
                DeclareVariable.divideButtonClicked = false;
                DeclareVariable.pointClicked = false;
            }
            else 
            {
                DeclareVariable.total1 = DeclareVariable.total1 * Convert.ToDouble(txtCompute.Text);
                txtCompute.Text = Convert.ToString(DeclareVariable.total1);
                DeclareVariable.total1 = Convert.ToDouble(txtCompute.Text);
                txtCompute.Clear();
                DeclareVariable.minusButtonClicked = false;
                DeclareVariable.plusButtonClicked = false;
                DeclareVariable.multiplyButtonClicked = true;
                DeclareVariable.divideButtonClicked = false;
                DeclareVariable.pointClicked = false;
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (DeclareVariable.plusButtonClicked == true)
            {
                txtCompute.Text = (DeclareVariable.total1 + Convert.ToDouble(txtCompute.Text)).ToString();
            }
            else if (DeclareVariable.multiplyButtonClicked == true)
            {
                txtCompute.Text = (DeclareVariable.total1 * Convert.ToDouble(txtCompute.Text)).ToString();
            }
            else if (DeclareVariable.minusButtonClicked == true)
            {
                txtCompute.Text = (DeclareVariable.total1 - Convert.ToDouble(txtCompute.Text)).ToString();
            }
            if (DeclareVariable.divideButtonClicked == false)
            {
                DeclareVariable.total1 = Convert.ToDouble(txtCompute.Text);
                txtCompute.Clear();
                DeclareVariable.minusButtonClicked = false;
                DeclareVariable.plusButtonClicked = false;
                DeclareVariable.multiplyButtonClicked = false;
                DeclareVariable.divideButtonClicked = true;
                DeclareVariable.pointClicked = false;
            }
            else
            {
                DeclareVariable.total1 = DeclareVariable.total1 / Convert.ToDouble(txtCompute.Text);
                txtCompute.Text = Convert.ToString(DeclareVariable.total1);
                DeclareVariable.total1 = Convert.ToDouble(txtCompute.Text);
                txtCompute.Clear();
                DeclareVariable.minusButtonClicked = false;
                DeclareVariable.plusButtonClicked = false;
                DeclareVariable.multiplyButtonClicked = false;
                DeclareVariable.divideButtonClicked = true;
                DeclareVariable.pointClicked = false;
            }
        }
    }
}
