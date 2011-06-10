using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JLNumerics
{
    public delegate double UnaryFunction(double x);
    public class RootFinder
    {
        public static bool findRootSecantMethod(UnaryFunction f, ref double x, double accuracy = 1.0E-10, int maxIters = 50, double minX = double.MinValue, double maxX= double.MaxValue)
        {
            double x2 = x - 1.0E-3;
            double y  = f(x);
            double y2 = f(x2);
            for (int count = 0; count < maxIters; ++count)
            {
                if (Math.Abs(y) < accuracy)
                    return true;
                double diff = y - y2;
                if (Math.Abs(diff) < 2.0 * double.Epsilon)
                    return false;
                double new_x = x - y*(x - x2)/(y - y2);
                x2 = x;
                x = new_x;
                x = Math.Max(x, minX);
                x = Math.Min(x, maxX);
                y2 = y;
                y = f(x);
            }
            return false;
        }

    }

    public class DerivativeCalculator
    {
        public static double numericalDifferentiation(UnaryFunction f, double x, double delta = 1.0E-4)
        {
            return (f(x + delta) - f(x - delta)) / (2.0 * delta);
        }
    }
}
