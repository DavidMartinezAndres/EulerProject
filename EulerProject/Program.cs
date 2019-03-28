﻿using System;
using System.Collections.Generic;

namespace EulerProject
{
    class Program
    {

        static void Main(string[] args)
        {
            //int ex1 = getMultiples(3, 5);
            //int ex2 = getFibonacci();
            //long ex3 = getHigherPrime(600851475143);
            //int ex4 = getLargestPalindrome();
            //int ex5 = smallestMultiple();
            //int ex6 = squareDiff();
            //int ex7 = getPrime(10001);
            int ex8 = largestProduct();
            Console.Write("ex8: "+ex8);
 
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        //1- Multiples of 3 and 5
        static int getMultiples(int a, int b)
        {
            int TotalSum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % a == 0 || i % b == 0)
                {
                    TotalSum += i;
                }
            }
            return TotalSum;
        }

        //2- Even Fibonacci numbers
        static int getFibonacci()
        {
            int firstNumber = 1;
            int secondNumber = 2;
            int oldSecondNumber = 0;

            int total = 0;

            while(secondNumber < 4000000)
            {
 
                if (secondNumber % 2 == 0) { total += secondNumber; }
  
                oldSecondNumber = secondNumber;
                secondNumber += firstNumber;
                firstNumber = oldSecondNumber;

            }
            return total;
        }

        //3- Largest prime factor
        static long getHigherPrime(long num)
        {
            long higherPrime = 0;
            long x = num;

            for (long i = 1; i < num / 2; i++)
            {
 
                if (x % i == 0)
                {
                    higherPrime = i;
                    x = x/i;
                }
            }

            return higherPrime;
        }

        //4- Largest palindrome product
        static int getLargestPalindrome()
        {
            int result = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int calc = i * j;
                    if (calc.ToString().Equals(Reverse(calc.ToString())))
                    {
                        if (calc > result) { result = calc; }
                    }
                }
            }
            return result ;
        }

        //5- smallest multiple
        static int smallestMultiple()
        {
            bool found = false;
            int limit = 20;
            int number = limit;
            while (!found)
            {
                for (int i = 1; i <= limit; i++)
                {
                    if (number % i != 0) { break; }
                    if ( (number % i == 0) && i == limit)
                    {
                        found = true;
                    }
                }
                if (!found) { number+=20; }

            }
            return number;
        }

        //6-Sum square difference
        static int squareDiff()
        {
            int maxNumber = 100;
            int a = squareSums(maxNumber);
            int b = sumSquares(maxNumber);
            return a-b;
        }

        private static int squareSums(int maxNumber)
        {
            for (int i = maxNumber - 1; i > 0; i--)
            {
                maxNumber += i;
            }
            return maxNumber * maxNumber;
        }
        static int sumSquares(int maxNumber)
        {
            int ae = 0;
            for (int i = 1; i <= maxNumber; i++)
            {
                ae += i * i;
            }
            return ae;
        }

        //7-10001st prime
        static int getPrime(int countWanted)
        {
            int number = 2;
            int count = 0;
            while (count != countWanted)
            {
                bool isPrime = true;
                for (int i = 2; i < number; i++)
                {
      
                    if (number % i == 0) { isPrime = false; break; }
                }
                if (isPrime) { count++; }
                if (count != countWanted) { number++; }
                
            }
            return number;
        }

        //8-Largest product in a series
        private static int largestProduct()
        {
            return 0;
        }
    }
}