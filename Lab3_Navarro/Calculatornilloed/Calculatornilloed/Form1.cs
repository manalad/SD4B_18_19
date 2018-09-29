namespace Calculatornilloed
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        //for decimal
        System.Int32 x = 0;
        public Form1()
        {
            //false lahat ng mga nakatrue sa sama sama
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
          textBox1.Text = textBox1.Text + "1";
        }

        

        private void button2_Click(object sender, System.EventArgs e)
        {
            
          textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
          textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            
          textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            
           textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            
           textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            
           textBox1.Text = textBox1.Text + "7";

        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            
           textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, System.EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "0";
        }

        private void button14_Click(object sender, System.EventArgs e)
        {
            while (x < 1)
            {
                textBox1.Text = textBox1.Text + ".";
                x += 1;

            }
        }

        private void button20_Click(object sender, System.EventArgs e)
        {
            x = 0;
            DeclareVariable.total1 = 0;
            DeclareVariable.total1 = 0;
            textBox1.Text = "";
        }

        

        private void button13_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, System.EventArgs e)
        {
            //equals
            x = 0;
            if (DeclareVariable.total1 != 0)
            {

                if (DeclareVariable.plusButtonClicked == true)
                {
                    DeclareVariable.total2 = System.Convert.ToDouble(textBox1.Text);
                    DeclareVariable.total2 = DeclareVariable.total1 + DeclareVariable.total2;
                    textBox1.Text = DeclareVariable.total2.ToString();


                    DeclareVariable.total1 = 0;
                    DeclareVariable.total2 = 0;
                    DeclareVariable.plusButtonClicked = false;
                    DeclareVariable.minusButtonClicked = false;
                    DeclareVariable.multiplyButtonClicked = false;
                    DeclareVariable.divideButtonClicked = false;

                }
                else if (DeclareVariable.multiplyButtonClicked == true)
                {
                    DeclareVariable.total2 = System.Convert.ToDouble(textBox1.Text);
                    DeclareVariable.total2 = DeclareVariable.total1 * DeclareVariable.total2;
                    textBox1.Text = DeclareVariable.total2.ToString();

                    DeclareVariable.total1 = 0;
                    DeclareVariable.total2 = 0;
                    DeclareVariable.plusButtonClicked = false;
                    DeclareVariable.minusButtonClicked = false;
                    DeclareVariable.multiplyButtonClicked = false;
                    DeclareVariable.divideButtonClicked = false;

                }
                else if (DeclareVariable.divideButtonClicked == true)
                {
                    DeclareVariable.total2 = System.Convert.ToDouble(textBox1.Text);
                    DeclareVariable.total2 = DeclareVariable.total1 / DeclareVariable.total2;
                    textBox1.Text = DeclareVariable.total2.ToString();

                    DeclareVariable.total1 = 0;
                    DeclareVariable.total2 = 0;

                    DeclareVariable.plusButtonClicked = false;
                    DeclareVariable.minusButtonClicked = false;
                    DeclareVariable.multiplyButtonClicked = false;
                    DeclareVariable.divideButtonClicked = false;
                }
                else if (DeclareVariable.minusButtonClicked == true)
                {
                    DeclareVariable.total2 = System.Convert.ToDouble(textBox1.Text);
                    DeclareVariable.total2 = DeclareVariable.total1 - DeclareVariable.total2;
                    textBox1.Text = DeclareVariable.total2.ToString();

                    DeclareVariable.total1 = 0;
                    DeclareVariable.total2 = 0;
                    DeclareVariable.plusButtonClicked = false;
                    DeclareVariable.minusButtonClicked = false;
                    DeclareVariable.multiplyButtonClicked = false;
                    DeclareVariable.divideButtonClicked = false;
                }
            }
        }

        private void plunButton_Click(object sender, System.EventArgs e)
        {
            //add
            DeclareVariable.plusButtonClicked = true;
            x = 0;
            if (textBox1.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Enter a valid input!");
            }
            else if (DeclareVariable.total1 == 0)
            {
                DeclareVariable.total1 = System.Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else if (DeclareVariable.total2 == 0 && DeclareVariable.total1 != 0)
            {
                DeclareVariable.total1 = System.Convert.ToDouble(textBox1.Text) + DeclareVariable.total1;
                textBox1.Text = "";


            }
        }

        private void minusButton_Click(object sender, System.EventArgs e)
        {
            //minus
            DeclareVariable.minusButtonClicked = true;
            x = 0;
            if (textBox1.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Enter a valid input!");
            }
            else if (DeclareVariable.total1 == 0)
            {
                DeclareVariable.total1 = System.Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else if (DeclareVariable.total2 == 0 && DeclareVariable.total1 != 0)
            {
                DeclareVariable.total1 = System.Convert.ToDouble(textBox1.Text) + DeclareVariable.total1;
                textBox1.Text = "";


            }
        }

        private void multiplyButton_Click(object sender, System.EventArgs e)
        {
            //times
            x = 0;
            DeclareVariable.multiplyButtonClicked = true;

            if (textBox1.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Enter a valid input!");
            }
            else if (DeclareVariable.total1 == 0)
            {
                DeclareVariable.total1 = System.Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else if (DeclareVariable.total2 == 0 && DeclareVariable.total1 != 0)
            {
                DeclareVariable.total1 = System.Convert.ToDouble(textBox1.Text) + DeclareVariable.total1;
                textBox1.Text = "";
            }
        }

        private void divideButton_Click(object sender, System.EventArgs e)
        {
            //divide
            x = 0;
            DeclareVariable.divideButtonClicked = true;

            if (textBox1.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Enter a valid input!");
            }
            else if (DeclareVariable.total1 == 0)
            {
                DeclareVariable.total1 = System.Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else if (DeclareVariable.total2 == 0 && DeclareVariable.total1 != 0)
            {
                DeclareVariable.total1 = System.Convert.ToDouble(textBox1.Text) + DeclareVariable.total1;
                textBox1.Text = "";


            }
        }
    }
}
