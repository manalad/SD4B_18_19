
/*
Limayo, Paula Ann A.
BSCS-SD4B
September 27, 2018
This program is will compute the input number w/ diff operations the calculator */


using System;
using System.Text;
using System.Windows.Forms;

namespace Lab3_LIMAYO
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "1";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "1";
            }  
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "2";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "2";
            }  
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "3";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "3";
            }  
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "4";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "4";
            }  
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "5";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "5";
            }  
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "6";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "7";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "8";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "9";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtboxinput.Text = txtboxinput.Text + "0"; 
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            txtboxinput.Text = txtboxinput.Text + ".";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            DeclareVar.total = Double.Parse(txtboxinput.Text);
            txtboxinput.Clear();
            DeclareVar.minusButtonClicked = false;
            DeclareVar.plusButtonClicked = true;
            DeclareVar.divideButtonClicked = false;
            DeclareVar.multiplyButtonClicked = false;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            DeclareVar.total = Double.Parse(txtboxinput.Text);
            txtboxinput.Clear();
            DeclareVar.minusButtonClicked = true;
            DeclareVar.plusButtonClicked = false;
            DeclareVar.divideButtonClicked = false;
            DeclareVar.multiplyButtonClicked = false;
        }

        private void btntimes_Click(object sender, EventArgs e)
        {
            DeclareVar.total = Double.Parse(txtboxinput.Text);
            txtboxinput.Clear();
            DeclareVar.minusButtonClicked = false;
            DeclareVar.plusButtonClicked = false;
            DeclareVar.divideButtonClicked = false;
            DeclareVar.multiplyButtonClicked = true;
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            DeclareVar.total = Double.Parse(txtboxinput.Text);
            txtboxinput.Clear();
            DeclareVar.minusButtonClicked = false;
            DeclareVar.plusButtonClicked = false;
            DeclareVar.divideButtonClicked = true;
            DeclareVar.multiplyButtonClicked = false;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            if (DeclareVar.plusButtonClicked == true) {
                DeclareVar.total2 = Double.Parse(txtboxinput.Text) + DeclareVar.total;
                
            }
            else if (DeclareVar.minusButtonClicked == true) {
                DeclareVar.total2 = DeclareVar.total - Double.Parse(txtboxinput.Text);
                
            }
            else if (DeclareVar.multiplyButtonClicked == true)
            {
                DeclareVar.total2 = DeclareVar.total * Double.Parse(txtboxinput.Text);
                
            }
            else
            {
                DeclareVar.total2 = DeclareVar.total / Double.Parse(txtboxinput.Text);
                
            }
            txtboxinput.Text = (DeclareVar.total2).ToString();
        }

       

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtboxinput.Clear();
        }
       
    }
}
