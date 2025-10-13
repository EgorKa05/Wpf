using System;

namespace WpfApplication1
{
    public class Trapecia : MyCalculator
    {
        public double Calculate(double a, double b, int n, Func<double, double> f)
        {
            double h = (b - a) / n;
            double sum = 0.5 * (f(a) + f(b));
            for (int i = 1; i < n; i++)
            {
                double x = a + i * h;
                sum += f(x);
            }
            return sum * h;
        }
    }
}