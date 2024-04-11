using System;
using System.Collections.Generic;

namespace SortingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers_Anonymous = new List<int> { 5, 2, 8, 1, 9, 3 };
            List<int> numbers_lambda = new List<int> { 8, 3, 9, 2, 1, 5 };

            // Sort using anonymous method
            numbers_Anonymous.Sort(delegate (int a, int b)
            {
                return a.CompareTo(b);
            });
            Console.WriteLine("Sorted List (Anonymous Method): " + string.Join(", ", numbers_Anonymous));

            // Sort using lambda expression
            numbers_lambda.Sort((a, b) => a - b);
            
            Console.WriteLine("Sorted List (numbers): " + string.Join(", ", numbers_lambda));
        }
    }
}
