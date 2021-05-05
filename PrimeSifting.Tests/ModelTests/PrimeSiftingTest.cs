using Microsoft.VisualStudio.TestTools.UnitTesting;

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
  }
}
