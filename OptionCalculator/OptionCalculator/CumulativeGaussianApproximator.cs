using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptionCalculator
{
    class CumulativeGaussianApproximator
    {
        private const double Gamma   = 0.2316419;
        private const double A1      = 0.319381530;
        private const double A2      =-0.356563782;
        private const double A3      = 1.781477937;
        private const double A4      =-1.821255978;
        private const double A5      = 1.330274429;

        public static double getCumulativeGaussian(double x)
        {
            if (x < 0.0)
                return 1.0 - getCumulativeGaussian(-x);
            double k = 1.0 / (1.0 + Gamma * x);
            double gaussian = 1.0 / Math.Sqrt(2.0 * Math.PI) * Math.Exp(-x * x / 2.0);
            return 1.0 - gaussian * ( A1 * k 
                                    + A2 * k * k
                                    + A3 * k * k * k 
                                    + A4 * k * k * k * k
                                    + A5 * k * k * k * k * k);
        }
    }
}
