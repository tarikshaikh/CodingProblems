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
            ReverseString("ge eksforgee ks", 0, "ge eksforgee ks".Length - 1);
            //ReverseArray(new int[] { 1, 2, 3, 4, 5 }, 0, 4);
            //RemoveDuplicates("AACCDBDDDBBCCAA");
            //FindCommonFactors();
        }

        public static void ReverseString(string inputString, int start, int end)
        {
            Console.WriteLine(inputString);

            string reversedString = ReverseStringUsingWhileLoop(inputString, start, end);

            Console.WriteLine("Reversed String : ");
            Console.WriteLine(reversedString);
            Console.ReadLine();
        }

        public static string ReverseStringUsingWhileLoop(string inputString, int start, int end)
        {
            char[] charArr = inputString.ToCharArray();

            char temp;
            while (start < end)
            {
                temp = charArr[start];
                charArr[start] = charArr[end];
                charArr[end] = temp;
                start++;
                end--;
            }

            return String.Join("", charArr);
        }

        public static void ReverseArray(int[] inputArray, int start, int end)
        {
            Common.PrintArray(inputArray);

            // ReverseArrayUsingWhileLoop(inputArray, start, end);
            ReverseArrayRecursive(inputArray, start, end);

            Console.WriteLine("Reversed Array : ");
            Common.PrintArray(inputArray);
            Console.ReadLine();
        }

        public static void ReverseArrayUsingWhileLoop(int[] inputArray, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = inputArray[start];
                inputArray[start] = inputArray[end];
                inputArray[end] = temp;
                start++;
                end--;
            }
        }

        public static void ReverseArrayRecursive(int[] inputArray, int start, int end)
        {
            int temp;
            if (start >= end)
                return;

            temp = inputArray[start];
            inputArray[start] = inputArray[end];
            inputArray[end] = temp;
            
            ReverseArrayRecursive(inputArray, start+1, end-1);
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
