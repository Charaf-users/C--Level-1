using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace castingTypes
{
    internal class Program
    {
        enum enweekDays
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        static void Main(string[] args)
        {
            int age = 25;
            double salary = 3500.50;

          
            long largeNumber = age;

            Console.WriteLine(age);
            Console.WriteLine(largeNumber);


       
            int truncatedSalary = (int)salary;

            Console.WriteLine(salary);
            Console.WriteLine(truncatedSalary);

            int myInt = 20;
            double myDouble = 7.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string 
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double 
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int 
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string 
          
            Console.WriteLine(enweekDays.Friday);
            int days = (int)enweekDays.Friday;
            Console.WriteLine(days);

            var  day = (enweekDays)5;
            Console.WriteLine(day);

            Console.ReadKey();
        }
    }
}
