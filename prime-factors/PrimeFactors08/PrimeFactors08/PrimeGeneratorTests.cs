using Xunit;

namespace PrimeFactors08
{
    public class PrimeGeneratorTests
    {
        private readonly PrimeGenerator generator;

        public PrimeGeneratorTests()
        {
            generator = new PrimeGenerator();
        }

        [Fact]
        public void Testing1()
        {
            var factors = generator.Factor(1);
            Assert.Equal(new int[] {}, factors);
        }

        [Fact]
        public void Testing2()
        {
            var factors = generator.Factor(2);
            Assert.Equal(new[] {2}, factors);
        }

        [Fact]
        public void Testing3()
        {
            var factors = generator.Factor(3);
            Assert.Equal(new[] {3}, factors);
        }

        [Fact]
        public void Testing4()
        {
            var factors = generator.Factor(4);
            Assert.Equal(new[] {2, 2}, factors);
        }

        [Fact]
        public void Testing6()
        {
            var factors = generator.Factor(6);
            Assert.Equal(new[] {2, 3}, factors);
        }

        [Fact]
        public void Testing8()
        {
            var factors = generator.Factor(8);
            Assert.Equal(new[] {2, 2, 2}, factors);
        }

        [Fact]
        public void Testing9()
        {
            var factors = generator.Factor(9);
            Assert.Equal(new[] {3, 3}, factors);
        }
    }
}