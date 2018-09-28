
namespace LAB3_MATIBAG
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            DeclareVariable.total1 = double.Parse(textBox1.Text);
            textBox1.Clear();

            DeclareVariable.btnAdd = true;
            DeclareVariable.btnMinus = false;
            DeclareVariable.btnMult = false;
            DeclareVariable.btnDivide = false;


        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            textBox1.Clear();
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

        private void btnDot_Click(object sender, System.EventArgs e)
        {
            

            while (DeclareVariable.a < 1) {
                textBox1.Text = textBox1.Text + ".";
                DeclareVariable.a += 1;
            }


        }

        private void btnEquals_Click(object sender, System.EventArgs e)
        {
            if (DeclareVariable.btnAdd == true)
            {
                DeclareVariable.total2 = System.Convert.ToDouble(textBox1.Text);
                DeclareVariable.total2 = DeclareVariable.total1 + DeclareVariable.total2;
                textBox1.Text = DeclareVariable.total2.ToString();

                DeclareVariable.btnAdd = false;
                DeclareVariable.btnMinus = false;
                DeclareVariable.btnMult = false;
                DeclareVariable.btnDivide = false;

            }

            if (DeclareVariable.btnMinus == true)
            {
                DeclareVariable.total2 = System.Convert.ToDouble(textBox1.Text);
                DeclareVariable.total2 = DeclareVariable.total1 - DeclareVariable.total2;
                textBox1.Text = DeclareVariable.total2.ToString();

                DeclareVariable.btnAdd = false;
                DeclareVariable.btnMinus = false;
                DeclareVariable.btnMult = false;
                DeclareVariable.btnDivide = false;
            }

            if (DeclareVariable.btnMult == true)
            {
                DeclareVariable.total2 = System.Convert.ToDouble(textBox1.Text);
                DeclareVariable.total2 = DeclareVariable.total1 * DeclareVariable.total2;
                textBox1.Text = DeclareVariable.total2.ToString();

                DeclareVariable.btnAdd = false;
                DeclareVariable.btnMinus = false;
                DeclareVariable.btnMult = false;
                DeclareVariable.btnDivide = false;
            }

            if (DeclareVariable.btnDivide == true)
            {
                DeclareVariable.total2 = System.Convert.ToDouble(textBox1.Text);
                DeclareVariable.total2 = DeclareVariable.total1 / DeclareVariable.total2;
                textBox1.Text = DeclareVariable.total2.ToString();

                DeclareVariable.btnAdd = false;
                DeclareVariable.btnMinus = false;
                DeclareVariable.btnMult = false;
                DeclareVariable.btnDivide = false;
            }
        }

        private void btnMinus_Click(object sender, System.EventArgs e)
        {
            DeclareVariable.total1 = System.Convert.ToDouble(textBox1.Text);
            textBox1.Clear();

            DeclareVariable.btnAdd = false;
            DeclareVariable.btnMinus = true;
            DeclareVariable.btnMult = false;
            DeclareVariable.btnDivide = false;
        }

        private void btnMult_Click(object sender, System.EventArgs e)
        {
            DeclareVariable.total1 = double.Parse(textBox1.Text);
            textBox1.Clear();

            DeclareVariable.btnAdd = false;
            DeclareVariable.btnMinus = false;
            DeclareVariable.btnMult = true;
            DeclareVariable.btnDivide = false;
        }

        private void btnDivide_Click(object sender, System.EventArgs e)
        {
            DeclareVariable.total1 = double.Parse(textBox1.Text);
            textBox1.Clear();

            DeclareVariable.btnAdd = false;
            DeclareVariable.btnMinus = false;
            DeclareVariable.btnMult = false;
            DeclareVariable.btnDivide = true;
        }
    }
}
