using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Demo_App
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            if (FirstNumberTextBox.Text != "" && SecondNumberTextBox.Text != "")
            {
                int firstNumber = Convert.ToInt32(FirstNumberTextBox.Text);
                int secondNumber = Convert.ToInt32(SecondNumberTextBox.Text);

                int result = firstNumber + secondNumber;

                //MessageBox.Show(result.ToString());

                ResultLabel.Text = "Addition of "+ firstNumber + " and " + secondNumber +" is " + result.ToString();
                ResultLabel.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter valid input in both fields");
            }
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            if (FirstNumberTextBox.Text != "" && SecondNumberTextBox.Text != "")
            {
                if(Convert.ToInt32(SecondNumberTextBox.Text)> Convert.ToInt32(FirstNumberTextBox.Text)) 
                {
                    MessageBox.Show("Second number cannot be greater than first number");
                }
                else 
                {
                    int firstNumber = Convert.ToInt32(FirstNumberTextBox.Text);
                    int secondNumber = Convert.ToInt32(SecondNumberTextBox.Text);

                    int result = firstNumber - secondNumber;

                    //MessageBox.Show(result.ToString());

                    ResultLabel.Text = "Subtraction of " + firstNumber + " and " + secondNumber + " is " + result.ToString();
                    ResultLabel.Visible = true;
                 }
            }
            else
            {
                MessageBox.Show("Please enter valid input in both fields");
            }
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            if (FirstNumberTextBox.Text != "" && SecondNumberTextBox.Text != "")
            {
                int firstNumber = Convert.ToInt32(FirstNumberTextBox.Text);
                int secondNumber = Convert.ToInt32(SecondNumberTextBox.Text);

                int result = firstNumber * secondNumber;

                //MessageBox.Show(result.ToString());

                ResultLabel.Text = "Multiplication of " + firstNumber + " and " + secondNumber + " is " + result.ToString();
                ResultLabel.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter valid input in both fields");
            }
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            if (FirstNumberTextBox.Text != "" && SecondNumberTextBox.Text != "")
            {
                if (Convert.ToInt32(SecondNumberTextBox.Text) > Convert.ToInt32(FirstNumberTextBox.Text))
                {
                    MessageBox.Show("Second number cannot be greater than first number");
                }
                else if (SecondNumberTextBox.Text == "0")
                {
                    MessageBox.Show("Cannot divide by Zero");
                }
                else
                {
                    int firstNumber = Convert.ToInt32(FirstNumberTextBox.Text);
                    int secondNumber = Convert.ToInt32(SecondNumberTextBox.Text);

                    int result = firstNumber / secondNumber;

                    //MessageBox.Show(result.ToString());

                    ResultLabel.Text = "Division of " + firstNumber + " and " + secondNumber + " is " + result.ToString();
                    ResultLabel.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please enter valid input in both fields");
            }
        }

        private void Remainder_Click(object sender, EventArgs e)
        {
            if (FirstNumberTextBox.Text != "" && SecondNumberTextBox.Text != "")
            {
                if (Convert.ToInt32(SecondNumberTextBox.Text) > Convert.ToInt32(FirstNumberTextBox.Text))
                {
                    MessageBox.Show("Second number cannot be greater than first number");
                }
                else if (SecondNumberTextBox.Text == "0")
                {
                    MessageBox.Show("Cannot divide by Zero");
                }
                else
                {
                    int firstNumber = Convert.ToInt32(FirstNumberTextBox.Text);
                    int secondNumber = Convert.ToInt32(SecondNumberTextBox.Text);

                    int result = firstNumber % secondNumber;

                    //MessageBox.Show(result.ToString());

                    ResultLabel.Text = "Division of " + firstNumber + " and " + secondNumber + " is " + result.ToString();
                    ResultLabel.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please enter valid input in both fields");
            }
        }
    }
}
