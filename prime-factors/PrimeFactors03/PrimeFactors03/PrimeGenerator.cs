using System.Collections.Generic;

namespace PrimeFactors03
{
    public class PrimeGenerator
    {
        public int[] GetPrimes(int numToFactor)
        {
            var primes = new List<int>();
            var candidate = 2;

            while (numToFactor > 1)
            {
                while (numToFactor%candidate == 0)
                {
                    primes.Add(candidate);
                    numToFactor /= candidate;
                }
                candidate++;
            }

            return primes.ToArray();
        }
    }
}