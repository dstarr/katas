using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PrimeFactors01
{
    
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(MakeFactorsList(), PrimeFactors.Generate(1));            
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(MakeFactorsList(2), PrimeFactors.Generate(2));            
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(MakeFactorsList(3), PrimeFactors.Generate(3));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal(MakeFactorsList(2,2), PrimeFactors.Generate(4));
        }

        [Fact]
        public void Test5()
        {
            Assert.Equal(MakeFactorsList(5), PrimeFactors.Generate(5));
        }

        [Fact]
        public void Test6()
        {
            Assert.Equal(MakeFactorsList(2, 3), PrimeFactors.Generate(6));
        }

        [Fact]
        public void Test7()
        {
            Assert.Equal(MakeFactorsList(7), PrimeFactors.Generate(7));
        }

        [Fact]
        public void Test8()
        {
            Assert.Equal(MakeFactorsList(2, 2, 2), PrimeFactors.Generate(8));
        }

        [Fact]
        public void Test9()
        {
            Assert.Equal(MakeFactorsList(3, 3), PrimeFactors.Generate(9));
        }










        private List<int> MakeFactorsList(params int[] factors)
        {
            List<int> factorsList = new List<int>();
            for (int i = 0; i < factors.Length; i++)
            {
                factorsList.Add(factors[i]);
            }
            return factorsList;
        }
    }
}
