using System;
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
            String stringToCheck;

            Console.WriteLine("-------- Iterative Fibonacci --------");
            Console.WriteLine("Enter the number upto which Fibonacci series to print: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine(" Fibonacci series upto " + number + " numbers:");
            for (int i = 1; i <= number; i++)
            {
                Console.Write(FibonacciIteration(i) + " ");
            }
            Console.WriteLine();

            Console.WriteLine("-------- Recursive Fibonacci --------");
            Console.WriteLine("Enter the number upto which Fibonacci series to print: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine(" Fibonacci series upto " + number + " numbers:");
            for (int i = 1; i <= number; i++)
            {
                Console.Write(FibonacciRecursive(i) + " ");
            }
            Console.WriteLine();

            Console.WriteLine("-------- Palindrome --------");
            Console.WriteLine("Enter a string to check if it is a palindrome: ");
            stringToCheck = Console.ReadLine();

            Console.WriteLine("Checking string " + stringToCheck + " to see if it is a palindrome: ");
            if (Palindrome(stringToCheck))
                Console.WriteLine("It is a palindrome");
            else
                Console.WriteLine("It is not a palindrome");

            Console.WriteLine("-------- Binary Search (Integer) --------");
            int[] toSearchInt = { 0, 1, 2, 8, 13, 17, 19, 32, 42 };
            Console.WriteLine("Searching in array containing [0, 1, 2, 8, 13, 17, 19, 32, 42]");
            Console.WriteLine("Enter the number you want to search for (doesn't have to be in the array):");
            int toFindInt = int.Parse(Console.ReadLine());

            Console.WriteLine("Checking if " + toFindInt + " is in the array: ");
            if (binarySearchInt(toSearchInt, toFindInt))
                Console.WriteLine("It exists");
            else
                Console.WriteLine("It does not exist");

            Console.WriteLine("-------- Binary Search (Char) --------");
            char[] toSearchChar = { 'a', 'c', 'd', 'f', 'n', 'q', 'x', 'y', 'z' };
            Console.WriteLine("Searching in array containing [a, c, d, f, n, q, x, y, z]");
            Console.WriteLine("Enter the character you want to search for (doesn't have to be in the array):");
            char toFindChar = char.Parse(Console.ReadLine());

            Console.WriteLine("Checking if " + toFindChar + " is in the array: ");
            if (binarySearchChar(toSearchChar, toFindChar))
                Console.WriteLine("It exists");
            else
                Console.WriteLine("It does not exist");

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
    }
}
