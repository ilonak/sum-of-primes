using System;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SumOfPrimes.Tests
{
	[TestClass]
	public class SumOfPrimeTest
	{
		[TestMethod]
		public void GetSumOfPrimes_ForOne_ExpectedSumIsOne()
		{
			uint expected = 1;
			var actual = Program.GetSumOfPrimes(1);
			Assert.AreEqual(expected, actual, "Wrong sum returned");
		}

		[TestMethod]
		public void GetSumOfPrimes_ForFive_ExpectedSumIs18()
		{
			uint expected = 18;
			var actual = Program.GetSumOfPrimes(5);
			Assert.AreEqual(expected, actual, "Wrong sum returned");
		}

		[TestMethod]
		public void IsPrimeNumber_ManyDifferent_ExpectedProperResult()
		{
			var data = new List<Tuple<uint,bool>> {
				new Tuple<uint,bool>(829, true),
				new Tuple<uint,bool>(2, true),
				new Tuple<uint,bool>(7, true),
				new Tuple<uint,bool>(102, false),
			};

			foreach (var item in data)
			{
				var actual = Program.IsPrimeNumber(item.Item1);
				if (item.Item2)
					Assert.IsTrue(actual, string.Format("Should be true, {0} is prime number", item.Item1));
				else
					Assert.IsFalse(actual, string.Format("Should be false, {0} is NOT prime number", item.Item1));
			}
		}

		[TestMethod]
		public void IsPrimeNumber_For829_ExpectedTrue()
		{
			var actual = Program.IsPrimeNumber(829);
			Assert.IsTrue(actual, "Should be true - 829 is prime number");
		}
	}
}
