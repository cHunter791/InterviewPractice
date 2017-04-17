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

        // Find a character within an array

    }
}
