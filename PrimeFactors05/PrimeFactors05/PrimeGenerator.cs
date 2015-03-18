using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeFactors05
{
    class PrimeGenerator
    {
        internal int[] Factor(int numToFactor)
        {
            var factors = new List<int>();

            for (int candidate = 2; numToFactor > 1; candidate++)
            {
                for (; numToFactor%candidate == 0; numToFactor/= candidate)
                {
                    factors.Add(candidate);
                }
            }
            
            return factors.ToArray();
        }
    }
}
