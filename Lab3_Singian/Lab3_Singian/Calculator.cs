using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3_Singian
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtEnter.Text = txtEnter.Text + "1";
        }

        private void bntTwo_Click(object sender, EventArgs e)
        {
            txtEnter.Text = txtEnter.Text + "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtEnter.Text = txtEnter.Text + "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtEnter.Text = txtEnter.Text + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtEnter.Text = txtEnter.Text + "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtEnter.Text = txtEnter.Text + "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtEnter.Text = txtEnter.Text + "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtEnter.Text = txtEnter.Text + "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtEnter.Text = txtEnter.Text + "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtEnter.Text = txtEnter.Text + "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtEnter.Text = txtEnter.Text + ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnter.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            DeclareVariable.total1 = Convert.ToDouble(txtEnter.Text);
            txtEnter.Clear();
            DeclareVariable.btnPlus = true;
            DeclareVariable.btnMinus = false;
            DeclareVariable.btnMultiply = false;
            DeclareVariable.btnDivide = false;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            DeclareVariable.total1 = Convert.ToDouble(txtEnter.Text);
            txtEnter.Clear();
            DeclareVariable.btnPlus = false;
            DeclareVariable.btnMinus = true;
            DeclareVariable.btnMultiply = false;
            DeclareVariable.btnDivide = false;

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            DeclareVariable.total1 = Convert.ToDouble(txtEnter.Text);
            txtEnter.Clear();
            DeclareVariable.btnPlus = false;
            DeclareVariable.btnMinus = false;
            DeclareVariable.btnMultiply = true;
            DeclareVariable.btnDivide = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            DeclareVariable.total1 = Convert.ToDouble(txtEnter.Text);
            txtEnter.Clear();
            DeclareVariable.btnPlus = false;
            DeclareVariable.btnMinus = false;
            DeclareVariable.btnMultiply = false;
            DeclareVariable.btnDivide = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (DeclareVariable.btnPlus == true)
            {
                txtEnter.Text = (DeclareVariable.total1 = DeclareVariable.total1 + double.Parse(txtEnter.Text)).ToString();
            }
            else if (DeclareVariable.btnMinus == true)
            {
                txtEnter.Text = (DeclareVariable.total1 = DeclareVariable.total1 - double.Parse(txtEnter.Text)).ToString();
            }
            else if (DeclareVariable.btnMultiply == true)
            {
                txtEnter.Text = (DeclareVariable.total1 = DeclareVariable.total1 * double.Parse(txtEnter.Text)).ToString();
            }
            else if (DeclareVariable.btnDivide)
            {
                txtEnter.Text = (DeclareVariable.total1 = DeclareVariable.total1 / double.Parse(txtEnter.Text)).ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
