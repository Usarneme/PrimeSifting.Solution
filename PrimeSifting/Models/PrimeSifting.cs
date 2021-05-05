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

// algorithm Sieve of Eratosthenes is
//     input: an integer n > 1.
//     output: all prime numbers from 2 through n.

//     let A be an array of Boolean values, indexed by integers 2 to n,
//     initially all set to true.

//     for i = 2, 3, 4, ..., not exceeding √n do
//         if A[i] is true
//             for j = i2, i2+i, i2+2i, i2+3i, ..., not exceeding n do
//                 A[j] := false

//     return all i such that A[i] is true.
