using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 51, -1, 2, 14, 18, 40, 178 };

            // get the minimum element 
            Console.WriteLine("Smallest  Element: " + numbers.Min());

            // Max() returns the largest number in array 
            Console.WriteLine("Largest Element: " + numbers.Max());

            // compute Count 
            Console.WriteLine("Count : " + numbers.Count());

            // compute Sum 
            Console.WriteLine("Sum : " + numbers.Sum());

            // compute the average 
            Console.WriteLine("Average: " + numbers.Average());

            Console.ReadKey();
        }
    }
}
