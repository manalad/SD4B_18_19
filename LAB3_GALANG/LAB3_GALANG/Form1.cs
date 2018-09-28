

namespace LAB3_GALANG
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        System.Int32 a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        DecVar declare = new DecVar();


        private void button1_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button14_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button15_Click(object sender, System.EventArgs e)
        {
            while (a < 1)
            {
                textBox1.Text = textBox1.Text + ".";
                a += 1;

            }
        }

        private void button10_Click(object sender, System.EventArgs e)
        {
            a = 0;
            DecVar.total1 = DecVar.total1 + double.Parse(textBox1.Text);
            textBox1.Clear();

            DecVar.plusButtonClicked = true;


        }

        private void button18_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void button11_Click(object sender, System.EventArgs e)
        {
            a = 0; 
            DecVar.minusButtonClicked = true;
            DecVar.total1 = DecVar.total1 + double.Parse(textBox1.Text);
            textBox1.Clear();

            
        }

        private void button12_Click(object sender, System.EventArgs e)
        {
            a = 0; 
            DecVar.total1 = DecVar.total1 + double.Parse(textBox1.Text);
            textBox1.Clear();

            DecVar.multiplyButtonClicked = true;
        }

        private void button13_Click(object sender, System.EventArgs e)
        {
            a = 0; 
            DecVar.total1 = DecVar.total1 + double.Parse(textBox1.Text);
            textBox1.Clear();

            DecVar.divideButtonClicked = true;
        }

        private void button17_Click(object sender, System.EventArgs e)
        {

            if (DecVar.plusButtonClicked == true)
            {
                DecVar.total2 = System.Convert.ToDouble(textBox1.Text);
                DecVar.total2 = DecVar.total1 + DecVar.total2;
                textBox1.Text = System.Convert.ToString(DecVar.total2);

                DecVar.total1 = 0;
                DecVar.total2 = 0;
                DecVar.minusButtonClicked = false;
                DecVar.plusButtonClicked = false;
                DecVar.divideButtonClicked = false;
                DecVar.multiplyButtonClicked = false;
                
            }

            else if (DecVar.minusButtonClicked == true)
            {
                DecVar.total2 = System.Convert.ToDouble(textBox1.Text);
                DecVar.total2 = DecVar.total1 - DecVar.total2;
                textBox1.Text = System.Convert.ToString(DecVar.total2);

                DecVar.total1 = 0;
                DecVar.total2 = 0;
                DecVar.minusButtonClicked = false;
                DecVar.plusButtonClicked = false;
                DecVar.divideButtonClicked = false;
                DecVar.multiplyButtonClicked = false;
                
            }
            else if (DecVar.multiplyButtonClicked == true)
            {
                DecVar.total2 = System.Convert.ToDouble(textBox1.Text);
                DecVar.total2 = DecVar.total1 * DecVar.total2;
                textBox1.Text = System.Convert.ToString(DecVar.total2);

                DecVar.total1 = 0;
                DecVar.total2 = 0;
                DecVar.minusButtonClicked = false;
                DecVar.plusButtonClicked = false;
                DecVar.divideButtonClicked = false;
                DecVar.multiplyButtonClicked = false;

            }

            else if (DecVar.divideButtonClicked == true)
            {
                DecVar.total2 = System.Convert.ToDouble(textBox1.Text);
                DecVar.total2 = DecVar.total1 / DecVar.total2;
                textBox1.Text = System.Convert.ToString(DecVar.total2);

                DecVar.total1 = 0;
                DecVar.total2 = 0;
                DecVar.minusButtonClicked = false;
                DecVar.plusButtonClicked = false;
                DecVar.divideButtonClicked = false;
                DecVar.multiplyButtonClicked = false;

            }

        }

        private void button16_Click(object sender, System.EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
