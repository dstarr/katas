using NUnit.Framework;

namespace PrimeFactors02
{
    [TestFixture]
    public class PrimeSpecs
    {
        private FactorGenerator _factorGenerator;

        [Test]
        public void Test1()
        {
            _factorGenerator = new FactorGenerator();
            int[] factors = _factorGenerator.Factor(1);
            Assert.AreEqual(new int[]{}, factors);
        }

        [Test]
        public void Test2()
        {
            _factorGenerator = new FactorGenerator();
            int[] factors = _factorGenerator.Factor(2);
            Assert.AreEqual(new [] { 2 }, factors);
        }

        [Test]
        public void Test3()
        {
            _factorGenerator = new FactorGenerator();
            int[] factors = _factorGenerator.Factor(3);
            Assert.AreEqual(new[] { 3 }, factors);
        }

        [Test]
        public void Test4()
        {
            _factorGenerator = new FactorGenerator();
            int[] factors = _factorGenerator.Factor(4);
            Assert.AreEqual(new[] { 2, 2 }, factors);
        }
        
        [Test]
        public void Test6()
        {
            _factorGenerator = new FactorGenerator();
            int[] factors = _factorGenerator.Factor(6);
            Assert.AreEqual(new[] { 2, 3 }, factors);
        }

        [Test]
        public void Test8()
        {
            _factorGenerator = new FactorGenerator();
            int[] factors = _factorGenerator.Factor(8);
            Assert.AreEqual(new[] { 2, 2, 2 }, factors);
        }

        [Test]
        public void Test9()
        {
            _factorGenerator = new FactorGenerator();
            int[] factors = _factorGenerator.Factor(9);
            Assert.AreEqual(new[] { 3, 3 }, factors);
        }

    }
}
