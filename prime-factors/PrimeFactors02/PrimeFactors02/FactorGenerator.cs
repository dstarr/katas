using System.Collections.Generic;
using NUnit.Util;

namespace PrimeFactors02
{
    public class FactorGenerator
    {
        public int[] Factor(int numToFactor)
        {
            var factors = new List<int>();

            for (int candidate = 2; numToFactor > 1; candidate++)
                for (; numToFactor % candidate == 0; numToFactor /= candidate)
                    factors.Add(candidate);

            
            return factors.ToArray();
        }
    }
}