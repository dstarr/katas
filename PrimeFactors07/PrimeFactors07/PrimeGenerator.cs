using System.Collections.Generic;

namespace PrimeFactors07
{
    public class PrimeGenerator
    {
        public int[] Factor(int numToFactor)
        {
            List<int> factors = new List<int>();
            var factorCandidate = 2;

            while (numToFactor > 1)
            {
                while (numToFactor%factorCandidate == 0)
                {
                    factors.Add(factorCandidate);
                    numToFactor /= factorCandidate;
                }
                factorCandidate++;
            }

            return factors.ToArray();
        }
    }
}