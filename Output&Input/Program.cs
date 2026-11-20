using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" enter your Full Name :");
             string name=Console.ReadLine();


            Console.Write(" enter your age :");
            byte age = Convert.ToByte( Console.ReadLine());

            Console.WriteLine("your full Name is :" + name);
            Console.WriteLine("age :" + age);
            Console.ReadKey();
        }
    }
}
