namespace Calculator
{
    public partial class Calculator : Form
    {
        private decimal firstValue = 0.0m, secondValue = 0.0m, finalValue = 0.0m;
        private string operators = "+";
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if(textBox.Text == "0")
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text += "0";
            }
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if(!textBox.Text.Contains(","))
            {
                textBox.Text += ",";
            }
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text += "1";
            }
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text += "2";
            }
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text += "3";
            }
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text += "4";
            }
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text += "5";
            }
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text += "6";
            }
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text += "7";
            }
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text += "8";
            }
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text += "9";
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

        }

        private void multiBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "x";
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "-";

        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "+";
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "/";
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {

        }

        private void plusMinusBtn_Click(object sender, EventArgs e)
        {
            if(textBox.Text.Contains("-"))
            {
                textBox.Text = textBox.Text.Trim('-');
            }
            else
            {
                textBox.Text = "-" + textBox.Text;
            }
        }
    }
}