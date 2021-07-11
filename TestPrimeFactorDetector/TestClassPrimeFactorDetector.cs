using NUnit.Framework;
using PrimeNumberSearch;

namespace TestPrimeFactorDetector
{
    public class TestsPrimeFactorDetector
    {
        [Test]
        public void TestArrayNull()
        {
            int[] arrayInt = null;
            Assert.AreEqual(-1, PrimeFactorDetector.getMaxPrime(arrayInt));
        }

        [Test]
        public void TestEquivalence1()
        {
            int[] arrayInt = { 5 };
            Assert.AreEqual(-1, PrimeFactorDetector.getMaxPrime(arrayInt));
        }

        [Test]
        public void TestEquivalence2()
        {
            int[] arrayInt = { 5, 6 };
            Assert.AreEqual(6, PrimeFactorDetector.getMaxPrime(arrayInt));
        }

        [Test]
        public void TestEquivalence3()
        {
            int[] arrayInt = new int[11];
            Assert.AreEqual(-1, PrimeFactorDetector.getMaxPrime(arrayInt));
        }

        [Test]
        public void TestEquivalence4()
        {
            int[] arrayInt = { -2, 5, 9, 3, 27, 108, 9, 12, 42, 13};
            Assert.AreEqual(108, PrimeFactorDetector.getMaxPrime(arrayInt));
        }

        [Test]
        public void TestEquivalence5()
        {
            int[] arrayInt = { 12,3,5};
            Assert.AreEqual(12, PrimeFactorDetector.getMaxPrime(arrayInt));
        }
    }
}