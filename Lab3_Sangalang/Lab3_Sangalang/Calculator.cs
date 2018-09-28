//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

namespace Lab3_Sangalang
{
    public partial class Calculator : System.Windows.Forms.Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, System.EventArgs e)
        {
            inputBox.Text = "";
            declareVariables.total1 = 0;
            declareVariables.total2 = 0;
            declareVariables.minusbuttonclicked = false;
            declareVariables.plusbuttonclicked = false;
            declareVariables.dividebuttonclicked = false;
            declareVariables.multiplybuttonclicked = false;
            declareVariables.equalsbuttonclicked = false;

        }

        private void clearbutton_Click(object sender, System.EventArgs e)
        {
            inputBox.Text = "";
            declareVariables.total1 = 0;
            declareVariables.total2 = 0;
            declareVariables.minusbuttonclicked = false;
            declareVariables.plusbuttonclicked = false;
            declareVariables.dividebuttonclicked = false;
            declareVariables.multiplybuttonclicked = false;
            declareVariables.equalsbuttonclicked = false;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            inputBox.Text = inputBox.Text + "1";
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            inputBox.Text = inputBox.Text + "2";
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            inputBox.Text = inputBox.Text + "3";
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            inputBox.Text = inputBox.Text + "4";
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            inputBox.Text = inputBox.Text + "5";
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            inputBox.Text = inputBox.Text + "6";
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            inputBox.Text = inputBox.Text + "7";
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            inputBox.Text = inputBox.Text + "8";
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            inputBox.Text = inputBox.Text + "9";
        }

        private void button0_Click(object sender, System.EventArgs e)
        {
            inputBox.Text = inputBox.Text + "0";
        }

        private void decimalbutton_Click(object sender, System.EventArgs e)
        {
            inputBox.Text = inputBox.Text + ".";
        }

        private void plusbutton_Click(object sender, System.EventArgs e)
        {
            declareVariables.total1 = 0;
            declareVariables.minusbuttonclicked = false;
            declareVariables.plusbuttonclicked = true;
            declareVariables.dividebuttonclicked = false;
            declareVariables.multiplybuttonclicked = false;
            declareVariables.equalsbuttonclicked = false;
            declareVariables.total1 = System.Convert.ToDouble(inputBox.Text) + declareVariables.total1;
            inputBox.Clear();

        }

        private void minusbutton_Click(object sender, System.EventArgs e)
        {
            declareVariables.total1 = 0;
            declareVariables.minusbuttonclicked = true;
            declareVariables.plusbuttonclicked = false;
            declareVariables.dividebuttonclicked = false;
            declareVariables.multiplybuttonclicked = false;
            declareVariables.equalsbuttonclicked = false;
            declareVariables.total1 = System.Convert.ToDouble(inputBox.Text) + declareVariables.total1;
            inputBox.Clear();
        }

        private void timesbutton_Click(object sender, System.EventArgs e)
        {
            declareVariables.total1 = 0;
            declareVariables.minusbuttonclicked = false;
            declareVariables.plusbuttonclicked = false;
            declareVariables.dividebuttonclicked = false;
            declareVariables.multiplybuttonclicked = true;
            declareVariables.equalsbuttonclicked = false;
            declareVariables.total1 = System.Convert.ToDouble(inputBox.Text) + declareVariables.total1;
            inputBox.Clear();
        }

        private void dividebutton_Click(object sender, System.EventArgs e)
        {
            declareVariables.total1 = 0;
            declareVariables.minusbuttonclicked = false;
            declareVariables.plusbuttonclicked = false;
            declareVariables.dividebuttonclicked = true;
            declareVariables.multiplybuttonclicked = false;
            declareVariables.equalsbuttonclicked = false;
            declareVariables.total1 = System.Convert.ToDouble(inputBox.Text) + declareVariables.total1;
            inputBox.Clear();
        }

        private void equalsbutton_Click(object sender, System.EventArgs e)
        { 

            if (declareVariables.plusbuttonclicked == true)
            {
                declareVariables.total2 = declareVariables.total1 + System.Convert.ToDouble(inputBox.Text);

                inputBox.Text = System.Convert.ToString(declareVariables.total2);
                declareVariables.minusbuttonclicked = false;
                declareVariables.plusbuttonclicked = false;
                declareVariables.dividebuttonclicked = false;
                declareVariables.multiplybuttonclicked = false;
                declareVariables.equalsbuttonclicked = false;
            }

            else if (declareVariables.multiplybuttonclicked == true )
            {
                declareVariables.total2 = declareVariables.total1 * System.Convert.ToDouble(inputBox.Text);

                inputBox.Text = System.Convert.ToString(declareVariables.total2);
                declareVariables.minusbuttonclicked = false;
                declareVariables.plusbuttonclicked = false;
                declareVariables.dividebuttonclicked = false;
                declareVariables.multiplybuttonclicked = false;
                declareVariables.equalsbuttonclicked = false;
            }

            else if (declareVariables.minusbuttonclicked == true)
            {
                declareVariables.total2 = declareVariables.total1 - System.Convert.ToDouble(inputBox.Text);

                inputBox.Text = System.Convert.ToString(declareVariables.total2);
                declareVariables.minusbuttonclicked = false;
                declareVariables.plusbuttonclicked = false;
                declareVariables.dividebuttonclicked = false;
                declareVariables.multiplybuttonclicked = false;
                declareVariables.equalsbuttonclicked = false;
            }

            else if (declareVariables.dividebuttonclicked == true)
            {
                declareVariables.total2 = declareVariables.total1 / System.Convert.ToDouble(inputBox.Text);

                inputBox.Text = System.Convert.ToString(declareVariables.total2);
                declareVariables.minusbuttonclicked = false;
                declareVariables.plusbuttonclicked = false;
                declareVariables.dividebuttonclicked = false;
                declareVariables.multiplybuttonclicked = false;
                declareVariables.equalsbuttonclicked = false;
            }
        }

        private void closebutton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
