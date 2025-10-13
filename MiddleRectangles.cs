
using System;

namespace WpfApplication1
{
    public class MiddleRectangles : MyCalculator
    {
        public double Calculate(double a, double b, int n, Func<double, double> f)
        {
            double h = (b - a) / n;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double x = a + (i + 0.5) * h;
                sum += f(x);
            }
            return sum * h;
        }
    }
}