﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            //String stringToCheck;

            //Console.WriteLine("-------- Iterative Fibonacci --------");
            //Console.WriteLine("Enter the number upto which Fibonacci series to print: ");
            //number = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Fibonacci series upto " + number + " numbers:");
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.Write(FibonacciIteration(i) + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine("-------- Recursive Fibonacci --------");
            //Console.WriteLine("Enter the number upto which Fibonacci series to print: ");
            //number = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Fibonacci series upto " + number + " numbers:");
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.Write(FibonacciRecursive(i) + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine("-------- Palindrome --------");
            //Console.WriteLine("Enter a string to check if it is a palindrome: ");
            //stringToCheck = Console.ReadLine();

            //Console.WriteLine("Checking string " + stringToCheck + " to see if it is a palindrome: ");
            //if (Palindrome(stringToCheck))
            //    Console.WriteLine("It is a palindrome");
            //else
            //    Console.WriteLine("It is not a palindrome");

            //Console.WriteLine("-------- Binary Search (Integer) --------");
            //int[] toSearchInt = { 0, 1, 2, 8, 13, 17, 19, 32, 42 };
            //Console.WriteLine("Searching in array containing [0, 1, 2, 8, 13, 17, 19, 32, 42]");
            //Console.WriteLine("Enter the number you want to search for (doesn't have to be in the array):");
            //int toFindInt = int.Parse(Console.ReadLine());

            //Console.WriteLine("Checking if " + toFindInt + " is in the array: ");
            //if (binarySearchInt(toSearchInt, toFindInt))
            //    Console.WriteLine("It exists");
            //else
            //    Console.WriteLine("It does not exist");

            //Console.WriteLine("-------- Binary Search (Char) --------");
            //char[] toSearchChar = { 'a', 'c', 'd', 'f', 'n', 'q', 'x', 'y', 'z' };
            //Console.WriteLine("Searching in array containing [a, c, d, f, n, q, x, y, z]");
            //Console.WriteLine("Enter the character you want to search for (doesn't have to be in the array):");
            //char toFindChar = char.Parse(Console.ReadLine());

            //Console.WriteLine("Checking if " + toFindChar + " is in the array: ");
            //if (binarySearchChar(toSearchChar, toFindChar))
            //    Console.WriteLine("It exists");
            //else
            //    Console.WriteLine("It does not exist");

            //Console.WriteLine("-------- FizzBuzz --------");
            //FizzBuzz();

            Console.WriteLine("-------- Converting a number to Roman numeral --------");
            Console.WriteLine("Enter a number between 1 and 3999");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberToRoman(number));

            // Keeps terminal open
            Console.Read();

        }

        // Fibonacci Sequence
        static int FibonacciIteration(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }

            int fibo1 = 1, fibo2 = 1, fibonacci = 1;

            for (int i = 3; i <= number; i++)
            {
                fibonacci = fibo1 + fibo2;
                fibo1 = fibo2;
                fibo2 = fibonacci;
            }

            return fibonacci;
        }

        static int FibonacciRecursive(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }

            return FibonacciRecursive(number - 1) + FibonacciRecursive(number - 2);
        }

        // Check if a string is a palindrome
        static Boolean Palindrome(String stringToCheck)
        {
            char[] charsToCheck = stringToCheck.ToCharArray();
            int length = charsToCheck.Length;
            int halfLength = length / 2;

            for (int i = 0; i < halfLength; i++)
            {
                if (charsToCheck[i] != charsToCheck[length - i - 1])
                    return false;
            }
            return true;
        }

        // Find a character within an array using binary search
        static Boolean binarySearchInt(int[] toSearch, int toFind)
        {
            int first = 0, last = toSearch.Length - 1, mid;
            Boolean found = false;

            while (first <= last && !found)
            {
                mid = (first + last) / 2;
                if (toSearch[mid] == toFind)
                    found = true;
                else
                {
                    if (toFind < toSearch[mid])
                        last = mid - 1;
                    else
                        first = mid + 1;
                }
            }

            return found;
        }

        static Boolean binarySearchChar(char[] toSearch, char toFind)
        {
            int first = 0, last = toSearch.Length - 1, mid;
            Boolean found = false;

            while (first <= last && !found)
            {
                mid = (first + last) / 2;
                if (toSearch[mid] == toFind)
                    found = true;
                else
                {
                    if (toFind < toSearch[mid])
                        last = mid - 1;
                    else
                        first = mid + 1;
                }
            }

            return found;
        }

        // FizzBuzz
        static void FizzBuzz()
        {
            for(int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                    Console.Write("FizzBuzz ");
                else if (i % 3 == 0)
                    Console.Write("Fizz ");
                else if (i % 5 == 0)
                    Console.Write("Buzz ");
                else
                    Console.Write(i + " ");
            }
        }

        static string NumberToRoman(int number)
        {
            //int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            //string[] numerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            if ((number < 0) || number > 3999)
                throw new ArgumentException("Value must be in range 0 - 3999");
            if (number < 1)
                return string.Empty;
            if (number >= 1000)
                return "M" + NumberToRoman(number - 1000);
            if (number >= 900)
                return "CM" + NumberToRoman(number - 900);
            if (number >= 500)
                return "D" + NumberToRoman(number - 500);
            if (number >= 400)
                return "CD" + NumberToRoman(number - 400);
            if (number >= 100)
                return "C" + NumberToRoman(number - 100);
            if (number >= 90)
                return "XC" + NumberToRoman(number - 90);
            if (number >= 50)
                return "L" + NumberToRoman(number - 50);
            if (number >= 40)
                return "XL" + NumberToRoman(number - 40);
            if (number >= 10)
                return "X" + NumberToRoman(number - 10);
            if (number >= 9)
                return "IX" + NumberToRoman(number - 9);
            if (number >= 5)
                return "V" + NumberToRoman(number - 5);
            if (number >= 4)
                return "IV" + NumberToRoman(number - 4);
            if (number >= 1)
                return "I" + NumberToRoman(number - 1);
            throw new ArgumentException("Value must be in range 0 - 3999");
        }
    }
}
