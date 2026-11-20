using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int j = 0; j < 9; j++)
            {
                Console.WriteLine(rnd.Next(10, 20)); // returns random integers >= 10 and < 20
            }
        }
    }
}
