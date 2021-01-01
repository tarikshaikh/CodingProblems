using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodingProblems
{
    static class Common
    {
        public static void PrintArray(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}