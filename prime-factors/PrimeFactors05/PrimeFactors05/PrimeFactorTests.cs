using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PrimeFactors05
{

    public class PrimeFactorTests
    {
        private PrimeGenerator _generator;

        public PrimeFactorTests()
        {
            _generator = new PrimeGenerator();
        }

        [Fact]
        public void Testing1()
        {
            int[] factors = _generator.Factor(1);
            Assert.Equal(new int[]{}, factors);
        }

        [Fact]
        public void Testing2()
        {
            int[] factors = _generator.Factor(2);
            Assert.Equal(new int[] { 2 }, factors);
        }

        [Fact]
        public void Testing3()
        {
            int[] factors = _generator.Factor(3);
            Assert.Equal(new int[] { 3 }, factors);
        }

        [Fact]
        public void Testing4()
        {
            int[] factors = _generator.Factor(4);
            Assert.Equal(new int[] { 2, 2 }, factors);
        }

        [Fact]
        public void Testing6()
        {
            int[] factors = _generator.Factor(6);
            Assert.Equal(new int[] { 2, 3 }, factors);
        }

        [Fact]
        public void Testing8()
        {
            int[] factors = _generator.Factor(8);
            Assert.Equal(new int[] { 2, 2, 2 }, factors);
        }

        [Fact]
        public void Testing9()
        {
            int[] factors = _generator.Factor(9);
            Assert.Equal(new int[] { 3, 3 }, factors);
        }

        [Fact]
        public void Testing100()
        {
            int[] factors = _generator.Factor(100);
            Assert.Equal(new int[] { 2, 2, 5, 5 }, factors);
        }
    }
}
