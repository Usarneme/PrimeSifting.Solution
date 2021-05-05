using System;
using System.Collections.Generic;

namespace PrimeSifting
{
    public class SieveOfEratosthenes
    {
      public static List<int> ReturnAllPrimesUpTo(int maxNumber)
      {
        List<int> primes = new List<int>{};
        bool[] allNumbersBoolean = new bool[maxNumber - 1];
        Array.Fill(allNumbersBoolean, true);

        if (maxNumber >= 2)
        {
          primes.Add(maxNumber);
          // create a list of numbers up to the max number...
          // for (int index = 2; index <= Math.Sqrt(maxNumber); index += 1)
          // {

          // }
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
