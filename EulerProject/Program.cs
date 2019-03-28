using System;
using System.Collections.Generic;
using System.Numerics;

namespace EulerProject
{
    class Program
    {

        static void Main(string[] args)
        {
            //int ex1 = GetMultiples(3, 5);
            //int ex2 = GetFibonacci();
            //long ex3 = GetHigherPrime(600851475143);
            //int ex4 = GetLargestPalindrome();
            //int ex5 = SmallestMultiple();
            //int ex6 = SquareDiff();
            //int ex7 = GetPrime(10001);
            //long ex10 = LargestProduct(2000000);
            //int ex13 = Collatz(1000000);
            BigInteger ex16 = SumNumbers(2,1000);
            Console.Write("ex16: "+ex16.ToString());
 
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        //1- Multiples of 3 and 5
        static int GetMultiples(int a, int b)
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
        static int GetFibonacci()
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
        static long GetHigherPrime(long num)
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
        static int GetLargestPalindrome()
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
        static int SmallestMultiple()
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
        static int SquareDiff()
        {
            int maxNumber = 100;
            int a = SquareSums(maxNumber);
            int b = sumSquares(maxNumber);
            return a-b;
        }

        private static int SquareSums(int maxNumber)
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
        static int GetPrime(int countWanted)
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

        //10-Summation of primes
        static long LargestProduct(long limit)
        {
            long number = 0;
            long result = 0;
            for (long i = 0; i < limit; i++)
            {
                if (number == 1) { number++; continue; }
                
                bool isPrime = true;
                for (long j = 2; j < number; j++)
                {
                
                    if (number % j == 0) { isPrime = false; break; }
                }
                if (isPrime) {
                    result += number;
                  //  Console.Write("number: "+number+" suma: " + result);
                }
                
                number++;
            }
            return result;
        }

        //14-Longest Collatz sequence
        static int Collatz(int limit)
        {
            int result = 0;
            long maxSequence = 0;
            for (int i = 1; i < limit; i++)
            {
                long ae = CollatzSequenceLength(i);
                if (ae > maxSequence)   
                {
                    maxSequence = ae;
                    result = i;
                }
            }
            return result;
        }
        static int CollatzSequenceLength(long number)
        {
            long orig = number;
            
            int count = 0;
            while (number != 1)
            {
                if (number %2 == 0) {
                    number /= 2;
                } else {
                    number = number * 3 + 1;
                }
                count++;
            }


            return count;
        }

        //16- Power digit sum
        static BigInteger SumNumbers(uint number,int potency)
        {

            BigInteger numberPower = GetPowerSum(number, potency);
            char[] fragmentedNumber = numberPower.ToString().ToCharArray();
            BigInteger result = 0;
            foreach (char c in fragmentedNumber)
            {
                result += uint.Parse(c.ToString());
            }
            return result;
        }
        static BigInteger GetPowerSum(uint number, int potency)
        {


            BigInteger result = 1;
            for (int i = 0; i < potency; i++)
            {
                result *= number;
            }
            return result;
        }

            
       
        }
    }

