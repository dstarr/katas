using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PrimeFactors03
{
    
    [TestFixture]
    public class PrimeFactorTests
    {
        private PrimeGenerator _primeGenerator;

        [Test]
        public void Test1()
        {
            _primeGenerator = new PrimeGenerator();
            int[] primes = _primeGenerator.GetPrimes(1);
            primes.ShouldEqual(new int[]{});
        }

        [Test]
        public void Test2()
        {
            _primeGenerator = new PrimeGenerator();
            int[] primes = _primeGenerator.GetPrimes(2);
            primes.ShouldEqual(new int[] {2});
        }

        [Test]
        public void Test3()
        {
            _primeGenerator = new PrimeGenerator();
            int[] primes = _primeGenerator.GetPrimes(3);
            primes.ShouldEqual(new int[] { 3 });
        }

        [Test]
        public void Test4()
        {
            _primeGenerator = new PrimeGenerator();
            int[] primes = _primeGenerator.GetPrimes(4);
            primes.ShouldEqual(new int[] { 2, 2 });
        }

        [Test]
        public void Test6()
        {
            _primeGenerator = new PrimeGenerator();
            int[] primes = _primeGenerator.GetPrimes(6);
            primes.ShouldEqual(new int[] { 2, 3 });
        }

        [Test]
        public void Test8()
        {
            _primeGenerator = new PrimeGenerator();
            int[] primes = _primeGenerator.GetPrimes(8);
            primes.ShouldEqual(new int[] { 2, 2, 2 });
        }

        [Test]
        public void Test9()
        {
            _primeGenerator = new PrimeGenerator();
            int[] primes = _primeGenerator.GetPrimes(9);
            primes.ShouldEqual(new int[] { 3, 3 });
        }
    }
}
