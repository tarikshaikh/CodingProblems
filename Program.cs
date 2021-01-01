using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //RemoveDuplicates("AACCDBDDDBBCCAA");
            FindCommonFactors();
        }

        public static void RemoveDuplicates(string inputString)
        {
            Console.WriteLine(inputString);
            Console.ReadLine();
        }

        public static void FindCommonFactors()
        {
            string input = Console.ReadLine();
            List<int> int1Factors = new List<int>();
            List<int> int2Factors = new List<int>();

            int int1 = Convert.ToInt32(input.Split(" ")[0]);
            int int2 = Convert.ToInt32(input.Split(" ")[1]);

            for (int i = 1; i <= int1; i++)
            {
                if (int1 % i == 0)
                {
                    int1Factors.Add(i);
                }
            }

            for (int i = 1; i <= int2; i++)
            {
                if (int2 % i == 0)
                {
                    int2Factors.Add(i);
                }
            }

            int commonFactorsCount = int1Factors.Intersect(int2Factors).ToList().Count;

            Console.WriteLine(commonFactorsCount);
            Console.ReadLine();
        }
    }
}
