using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Full Name");
            string Name= Console.ReadLine();
            Console.WriteLine("Enter your Year naissance ");
            string Year= Console.ReadLine();
            int Dt = Convert.ToInt32(Year);


          int  DateNow = DateTime.Now.Year;
            int result = DateNow - Dt;
            if(result >=18)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Minor");
            }

            string status = (result >= 18) ? "Adult" : "Minor";

            Console.WriteLine("Hello {0} ; your age is {1} and your  are {2}", Name, result, status);


        }
    }
}
