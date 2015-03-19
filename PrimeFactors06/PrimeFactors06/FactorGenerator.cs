using System.Collections.Generic;

namespace PrimeFactors06
{
    public class FactorGenerator
    {
        internal int[] Factor(int numToFactor)
        {
            List<int> factors = new List<int>();
            var factorCandidate = 2;

            while (numToFactor > 1)
            {
                while (numToFactor%factorCandidate == 0)
                {
                    numToFactor /= factorCandidate;
                    factors.Add(factorCandidate);
                }
                factorCandidate++;
            }

            return factors.ToArray();
        }
    }
}