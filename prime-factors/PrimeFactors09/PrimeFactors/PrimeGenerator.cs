namespace PrimeFactors;

public class PrimeGenerator
{
    public int[] FactorToPrimes(int numToFactor)
    {
        var factors = new List<int>();
        var factorCandidate = 2;

        while (numToFactor > 1)
        {
            while (numToFactor % factorCandidate == 0)
            {
                factors.Add(factorCandidate);
                numToFactor /= factorCandidate;
            }
            factorCandidate++;
        }

        return factors.ToArray();
    }
}