using System.Collections.Generic;

namespace PrimeFactors01
{
    public static class PrimeFactors
    {

        public static List<int> Generate(int numberToFactor)
        {
            var factors = new List<int>();
            int candidate = 2;

            while (numberToFactor > 1)
            {
                while (numberToFactor % candidate == 0)
                {
                    factors.Add(candidate);
                    numberToFactor /= candidate;
                }
                candidate++;
            }

            return factors;
        }
    }
}