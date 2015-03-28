using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PrimeFactors07
{
    [TestFixture]
    public class PrimeGeneratorTests
    {
        private PrimeGenerator _generator;

        [SetUp]
        public void Init()
        {
            _generator = new PrimeGenerator();
        }


        [Test]
        public void Testing1()
        {
            int[] primes = _generator.Factor(1);
            Assert.AreEqual(new int[] {}, primes);
        }

        [Test]
        public void Testing2()
        {
            int[] primes = _generator.Factor(2);
            Assert.AreEqual(new int[] { 2 }, primes);
        }

        [Test]
        public void Testing3()
        {
            int[] primes = _generator.Factor(3);
            Assert.AreEqual(new int[] { 3 }, primes);
        }

        [Test]
        public void Testing4()
        {
            int[] primes = _generator.Factor(4);
            Assert.AreEqual(new int[] { 2, 2 }, primes);
        }

        [Test]
        public void Testing6()
        {
            int[] primes = _generator.Factor(6);
            Assert.AreEqual(new int[] { 2, 3 }, primes);
        }

        [Test]
        public void Testing8()
        {
            int[] primes = _generator.Factor(8);
            Assert.AreEqual(new int[] { 2, 2, 2 }, primes);
        }

        [Test]
        public void Testing9()
        {
            _generator = new PrimeGenerator();
            int[] primes = _generator.Factor(9);
            Assert.AreEqual(new int[] { 3, 3 }, primes);
        }
    }
}
