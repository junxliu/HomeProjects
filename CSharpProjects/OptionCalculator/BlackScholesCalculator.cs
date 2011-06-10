using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptionCalculator
{
    class BlackScholesCalculator
    {
        public static double calculateOptionPrice( double currentPrice,
                                            double strikePrice,
                                            double yearsToMaturity,
                                            double interstRate,
                                            double volatility,
                                            bool isCall)
        {
            double d1 = (Math.Log(currentPrice / strikePrice) + (interstRate + volatility * volatility / 2.0) * yearsToMaturity)
                        / (volatility * Math.Sqrt(yearsToMaturity));
            double d2 = d1 - volatility * Math.Sqrt(yearsToMaturity);
            if (isCall)
                return currentPrice * CumulativeGaussianApproximator.getCumulativeGaussian(d1)
                    - strikePrice * Math.Exp(-interstRate * yearsToMaturity) * CumulativeGaussianApproximator.getCumulativeGaussian(d2);
            else
                return strikePrice * Math.Exp(-interstRate * yearsToMaturity) * CumulativeGaussianApproximator.getCumulativeGaussian(-d2)
                    - currentPrice * CumulativeGaussianApproximator.getCumulativeGaussian(-d1);
        }

    }
}
