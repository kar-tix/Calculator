using System.Runtime.InteropServices;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private decimal firstValue = 0.0m, secondValue = 0.0m, finalValue = 0.0m;
        private char operators = ' ';
        bool flag = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Clear_textBox()
        {
            if(flag)
                textBox.Clear();
            flag = false;
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            Clear_textBox();

            if (!textBox.Text.Contains(","))
            {
                textBox.Text += ",";
            }
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            Clear_textBox();

            if (textBox.Text == "0")
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text += "0";
            }
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            Clear_textBox();

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
            Clear_textBox();

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
            Clear_textBox();

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
            Clear_textBox();

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
            Clear_textBox();

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
            Clear_textBox();

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
            Clear_textBox();

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
            Clear_textBox();

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
            Clear_textBox();

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
            firstValue = 0.0m;
            secondValue = 0.0m;
            finalValue = 0.0m;
            textBox.Text = "0";
            textBoxMin.Clear();
        }

        private void multiBtn_Click(object sender, EventArgs e)
        {
            if(!textBoxMin.Text.Contains("*"))
            {
                firstValue = decimal.Parse(textBox.Text);
                textBoxMin.Text = textBox.Text + " *";
                textBox.Clear();
                operators = 'x';
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if(!textBoxMin.Text.Contains("-"))
            {
                firstValue = decimal.Parse(textBox.Text);
                textBoxMin.Text = textBox.Text + " -";
                textBox.Clear();
                operators = '-';
            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            if(!textBoxMin.Text.Contains("+"))
            {
                firstValue = decimal.Parse(textBox.Text);
                textBoxMin.Text = textBox.Text + " +";
                textBox.Clear();
                operators = '+';
            }
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            if(!textBoxMin.Text.Contains("/"))
            {
                firstValue = decimal.Parse(textBox.Text);
                textBoxMin.Text = textBox.Text + " /";
                textBox.Clear();
                operators = '/';
            }
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(textBox.Text) / 100;
            textBox.Text = firstValue.ToString();
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            secondValue = decimal.Parse(textBox.Text);
            switch (operators)
            {
                case '-':
                    finalValue = firstValue - secondValue;
                    break;

                case '+':
                    finalValue = firstValue + secondValue;
                    break;

                case 'x':
                    finalValue = firstValue * secondValue;
                    break;
                case '/':
                    finalValue = firstValue / secondValue;
                    break;
                default:
                    break;
            }
            operators = ' ';
            textBoxMin.Clear();
            textBox.Text = finalValue.ToString();
            flag = true;
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