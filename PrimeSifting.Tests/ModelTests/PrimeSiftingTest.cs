using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
  }
}
