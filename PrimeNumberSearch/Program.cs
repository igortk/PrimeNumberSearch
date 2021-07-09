using System;

namespace PrimeNumberSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an array of integers separated by a space.\nSample:1 2 3 5 10 11");
                int[] arrayInt;
                string[] inputLine = Console.ReadLine().Trim().Split(' ');
                arrayInt = new int[inputLine.Length];
                for (int i = 0; i < arrayInt.Length; i++)
                {
                    arrayInt[i] = int.Parse(inputLine[i]);
                }

                Console.WriteLine(PrimeFactorDetector.getMaxPrime(arrayInt));
            }
            catch (Exception)
            {
                Console.WriteLine("Error!\nThe input string was not formatted correctly!");
            }

        }
    }
}
