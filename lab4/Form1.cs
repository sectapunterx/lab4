using System;
using System.Windows.Forms;
using Classlab4;


namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rbTriangle.Checked)
            {
                CalculateTriangleExpression();
            }
            else if (rbMathF1.Checked)
            {
                CalculateMathF1Expression();
            }
            else
            {
                MessageBox.Show("Please select an expression to calculate.");
            }
        }

        private void CalculateTriangleExpression()
        {
            if (int.TryParse(txtParam1.Text, out int a) &&
                int.TryParse(txtParam2.Text, out int b) &&
                int.TryParse(txtParam3.Text, out int c))
            {
                Class.ExpressionCalculator calculator = new Class.ExpressionCalculator(a, b, c);
                txtResult.Text = calculator.ToString("Triangle Expression");
            }
            else
            {
                MessageBox.Show("Please enter valid integer values for a, b, and c.");
            }
        }

        private void CalculateMathF1Expression()
        {
            if (double.TryParse(txtParam1.Text, out double p))
            {
                Class.ExpressionCalculator calculator = new Class.ExpressionCalculator(p, 0, 0);
                txtResult.Text = calculator.ToString("MathF_1 Expression");
            }
            else
            {
                MessageBox.Show("Please enter a valid double value for p.");
            }
        }
    }
}