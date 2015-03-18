using System.Collections.Generic;

namespace PrimeFactors04
{
    public class PrimeGenerator
    {
        internal int[] Factor(int numToFactor)
        {
            var factors = new List<int>();
            var candidateFactor = 2;

            while (numToFactor > 1)
            {
                while (numToFactor%candidateFactor == 0)
                {
                    factors.Add(candidateFactor);
                    numToFactor /= candidateFactor;
                }
                candidateFactor++;
            }

            return factors.ToArray();
        }
    }
}
