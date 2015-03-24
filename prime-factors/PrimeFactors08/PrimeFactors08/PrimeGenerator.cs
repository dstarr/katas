using System.Collections.Generic;

namespace PrimeFactors08
{
    public class PrimeGenerator
    {
        public int[] Factor(int numToFactor)
        {
            var factors = new List<int>();
            var possiblePrime = 2;

            while (numToFactor > 1)
            {
                while (numToFactor%possiblePrime == 0)
                {
                    factors.Add(possiblePrime);
                    numToFactor /= possiblePrime;
                }
                possiblePrime++;
            }
            return factors.ToArray();
        }
    }
}