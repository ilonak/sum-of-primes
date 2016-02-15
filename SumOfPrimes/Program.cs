using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SumOfPrimes
{
	public class Program
	{
		static void Main(string[] args)
		{
			uint primeNumbersCount = 1000;
			uint sumOfPrimes = GetSumOfPrimes(primeNumbersCount);
					
			Console.WriteLine("Sum of first {0} primes = {1}", primeNumbersCount, sumOfPrimes);
			Console.ReadLine();
		}

		public static uint GetSumOfPrimes(uint primeNumbersCount)
		{
			uint found = 0;
			uint i = 2;
			uint sumOfPrimes = 0;

			while (found < primeNumbersCount)
			{
				if (IsPrimeNumber(i))
				{
					sumOfPrimes += i;
					found++;
				}
				i++;
			}
			return sumOfPrimes;
		}

		public static bool IsPrimeNumber(uint number)
		{
			bool isPrime = true;
			if (number != 1)
			{
				for (int i = 2; i < number && isPrime; i++)
				{
					if (number % i == 0)
					{
						isPrime = false;
					}
				}
			}
			return isPrime;
		}
	}
}
