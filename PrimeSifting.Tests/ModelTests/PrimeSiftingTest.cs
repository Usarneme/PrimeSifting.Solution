using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace PrimeSifting.Test
{
  [TestClass]
  public class PrimeSiftingTests
  {
    [TestMethod]
    public void SieveOfEratosthenes_Exists_True()
    {
      // arrange, act, assert
      SieveOfEratosthenes _mySieve = new SieveOfEratosthenes();
      Assert.IsInstanceOfType(_mySieve, typeof(SieveOfEratosthenes));
    }

    [TestMethod]
    public void ReturnAllPrimesUpTo_One_EmptyList()
    {
      List<int> primeNumbersListExpected = new List<int>{};
      int userInput = 1;

      List<int> primeNumbersListResult = SieveOfEratosthenes.ReturnAllPrimesUpTo(userInput);

      CollectionAssert.AreEqual(primeNumbersListExpected, primeNumbersListResult);
    }

    [TestMethod]

    public void ReturnAllPrimesUpTo_Two_ListContainingTwo()
    {
      List<int> primeNumbersListExpected = new List<int>{2};
      int userInput = 2;

      List<int> primeNumbersListResult = SieveOfEratosthenes.ReturnAllPrimesUpTo(userInput);

      CollectionAssert.AreEqual(primeNumbersListExpected, primeNumbersListResult);
    }

    [TestMethod]

    public void ReturnAllPrimesUpTo_Fourteen_ListContainingPrimes()
    {
      List<int> primeNumbersListExpected = new List<int>{2, 3, 5, 7, 11, 13};
      int userInput = 14;

      List<int> primeNumbersListResult = SieveOfEratosthenes.ReturnAllPrimesUpTo(userInput);
      // primeNumbersListResult.ForEach(i => Console.Write("{0}, ", i));
      CollectionAssert.AreEqual(primeNumbersListExpected, primeNumbersListResult);
    }
  }
}
