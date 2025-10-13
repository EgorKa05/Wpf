using System;

namespace WpfApplication1
{
    public interface MyCalculator
    {
        double Calculate(double a, double b, int n, Func<double, double> f);
    }
}