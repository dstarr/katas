﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PrimeFactors06
{
    public class PrimeFactorTests
    {
        private FactorGenerator _generator;

        public PrimeFactorTests()
        {
            _generator = new FactorGenerator();
        }

        [Fact]
        public void Test1()
        {
            int[] factors = _generator.Factor(1);
            Assert.Equal(new int[]{}, factors);
        }

        [Fact]
        public void Test2()
        {
            int[] factors = _generator.Factor(2);
            Assert.Equal(new int[] { 2 }, factors);
        }

        [Fact]
        public void Test3()
        {
            int[] factors = _generator.Factor(3);
            Assert.Equal(new int[] { 3 }, factors);
        }

        [Fact]
        public void Test4()
        {
            int[] factors = _generator.Factor(4);
            Assert.Equal(new int[] { 2, 2 }, factors);
        }

        [Fact]
        public void Test6()
        {
            int[] factors = _generator.Factor(6);
            Assert.Equal(new int[] { 2, 3 }, factors);
        }

        [Fact]
        public void Test8()
        {
            int[] factors = _generator.Factor(8);
            Assert.Equal(new int[] { 2, 2, 2 }, factors);
        }

        [Fact]
        public void Test9()
        {
            int[] factors = _generator.Factor(9);
            Assert.Equal(new int[] { 3, 3 }, factors);
        }

    }
}
