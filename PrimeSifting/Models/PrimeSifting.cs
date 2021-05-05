using System;
using System.Collections.Generic;

namespace PrimeSifting
{
    public class SieveOfEratosthenes
    {
      public static List<int> ReturnAllPrimesUpTo(int maxNumber)
      {
        List<int> primes = new List<int>{};

        if (maxNumber >= 2)
        {
          bool[] allNumbersBoolean = new bool[maxNumber - 1];
          Array.Fill(allNumbersBoolean, true);

          // fill boolean array with false where there is no prime number
          for (int currentNumber = 2; currentNumber <= Math.Sqrt(maxNumber); currentNumber += 1)
          {
            int indexOfAssociatedBoolean = currentNumber - 2;
            if(allNumbersBoolean[indexOfAssociatedBoolean] == true)
            {
              for (int nonPrimeNumber = currentNumber * currentNumber; nonPrimeNumber <= maxNumber; nonPrimeNumber += currentNumber)
              {
                int indexOfNonPrime = nonPrimeNumber - 2;
                allNumbersBoolean[indexOfNonPrime] = false;
              }
            }
          }

          // add numbers to list that are prime (boolean value = true)
          for (int index = 0; index < allNumbersBoolean.Length; index++)
          {
            if (allNumbersBoolean[index] == true)
            {
              primes.Add(index + 2);
            }
          }
        }
        return primes;
      }
    }
}
