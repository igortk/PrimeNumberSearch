using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumberSearch
{
    public static class PrimeFactorDetector
    {
        public static int getMaxPrime(int[] arrayInt)
        {
            if (arrayInt == null)
            {
                Console.WriteLine("Array is null (empty)!");
                return -1;
            }

            if (arrayInt.Length < 2 || arrayInt.Length > 10)
            {
                Console.WriteLine("Array must be of size (2<= length <=10)");
                return -1;
            }

            int maxValue = 0;
            int maxPrimeNumbers = 0;

            foreach (var item in arrayInt)
            {
                if (!isPrime(item))
                {
                    int temp = getFactorization(item).Count;
                    if (maxValue <= item && maxPrimeNumbers <= temp)
                    {
                        maxPrimeNumbers = temp;
                        maxValue = item;
                    }
                }
            }

            return maxValue;
        }

        private static bool isPrime(int value)
        {
            if (value <= 1)
            {
                return false;
            }

            for (int i = 2; i < Math.Sqrt(value); i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static List<int> getFactorization(int value)
        {
            List<int> vs = new List<int>();

            for (int i = 2; i <= value; i++)
            {
                if (isPrime(i))
                {
                    if (value % i == 0)
                    {
                        value /= i;
                        vs.Add(i);
                        i = 1;
                    }
                }
            }

            return vs;
        }
    }
}
