using System;

namespace Classlab4
{
    public class Class
    {

        public abstract class BaseExpressionCalculator
    {
        public abstract override string ToString();

        protected string FormatExpression(string expressionName, double result)
        {
            return $"{expressionName}: {result}";
        }
    }

    public class ExpressionCalculator : BaseExpressionCalculator
    {
        private double _result;

        public ExpressionCalculator(int a, int b, int c)
        {
            _result = Calculate(a, b, c);
        }

        public ExpressionCalculator(double p, double a, double b)
        {
            _result = Calculate(p, a, b);
        }

        public double Calculate(int a, int b, int c)
        {
            // Implementation using the LinearFunc method from the previous code
            double p = (a + b + c) / 2.0;
            return LinearFunc(p, a, b);
        }

        public double Calculate(double p, double a, double b)
        {
            // Implementation using the MathF_1 method from the previous code
            return MathF_1(p);
        }

        public override string ToString()
        {
            return FormatExpression("Result", _result);
        }

        public virtual string ToString(string expressionName)
        {
            return FormatExpression(expressionName, _result);
        }

        private static double LinearFunc(double p, double a, double b)
        {
            double h = ((p * (p - a) * (p - b)) / (a * b));
            return h;
        }

        private static double MathF_1(double x)
        {
            double y = 2 * (Math.Cos(x) * Math.Cos(x) - 1);
            double s = 0;
            double pow = -1;
            int factorial = 2;
            for (int n = 1; n <= 8; n++)
            {
                s += pow * Math.Pow(2 * x, 2 * n) / factorial;
                pow *= -1;
                factorial *= (2 * n + 1) * (2 * n + 2);
            }
            return s;
        }
    }

    }
}