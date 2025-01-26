using Microsoft.VisualBasic;

namespace PrimeFactors.Tests;

[TestClass]
public class PrimeGeneratorTests
{
    private PrimeGenerator _primeGenerator = null!;

    [TestInitialize]
    public void TestInitialize()
    {
        _primeGenerator = new PrimeGenerator();
    }
    
    [TestMethod]
    public void NotPrime_1()
    {
        var factors = _primeGenerator.FactorToPrimes(1);
        Assert.AreEqual(0, factors.Length);
    }
    
    [TestMethod]
    public void Primes_for_2()
    {
        int[] results = _primeGenerator.FactorToPrimes(2);
        CollectionAssert.AreEqual(new[] { 2 }, results);
    }
    
    [TestMethod]
    public void Primes_for_4()
    {
        var results = _primeGenerator.FactorToPrimes(4);
        CollectionAssert.AreEqual(new[] { 2, 2 }, results);
    }
    
    [TestMethod]
    public void Primes_for_7()
    {
        var results = _primeGenerator.FactorToPrimes(7);
        CollectionAssert.AreEqual(new[] { 7 }, results);
    }
}