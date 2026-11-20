using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    internal class Program
    {

        enum enWekend
        {
            Monday,  //0
            Tuesday,    // 1 
            Wednesday,  // 2 
            Thursday,   // 3 
            Friday,     // 4 
            Saturday,   // 5 
            Sunday
        }

        struct stStudent
        {
            public int ID;
            public string Name;
        }
        static void Main(string[] args)
        {
            byte b1 = 200;
            sbyte b2 = -122;
            int b3 = 1600;
            short b4 = -345;
            bool b5 = false;
            double b6 = 1346.35d;
            float b7 = 245.56F;
            long b8 =12345666526;
            decimal b9 = 5000000000000;

         


            Console.WriteLine( " Min={0}     Max={1} ",Byte.MinValue,Byte.MaxValue);

            Console.WriteLine(" Min={0}     Max={1} ", SByte.MinValue, SByte.MaxValue);
            Console.WriteLine("b3 = {0}", b3);
            Console.WriteLine("b4 ={0} ", b4);
            Console.WriteLine("b5 ={0}", b5);
            Console.WriteLine("b6 ={0}", b6);
            Console.WriteLine("b7 ={0}", b7);
            Console.WriteLine("b8 ={0}", b8);
            Console.WriteLine("b9 ={0}", b9);

           
            int b10 = default(int);
            short b11 = default(short);
            bool b12 = default(bool);
            double b13 = default(double);
            decimal b14 = default(decimal);
            char b15 = default(char);

            Console.WriteLine("b10 = {0}", b10);
            Console.WriteLine("b11 ={0} ", b11);
            Console.WriteLine("b12 ={0}", b12);
            Console.WriteLine("b13 ={0}", b13);
            Console.WriteLine("b14 ={0}", b14);
            Console.WriteLine("b15 ={0}", b15);

            enWekend weekDays;

            weekDays = enWekend.Thursday;
            Console.WriteLine(weekDays);

            Nullable<int> i = null;
            // Console.WriteLine(i);

            var persone = new
            {
                id = 1,
                firstName = "charaf eddine",
                LastName = "Jador",
                Age=20,
                Adress =new{ city="casablanca",country="Morrocco" }

            };

            Console.WriteLine(persone.id);
            Console.WriteLine(persone.firstName);
            Console.WriteLine(persone.LastName);
            Console.WriteLine(persone.Age);
            Console.WriteLine(persone.Adress.city);
            Console.WriteLine(persone.Adress.country);




            stStudent student;
            stStudent student2 = new stStudent();

            student.ID = 22;
            student.Name = "Charaf eddine Jador";
            Console.WriteLine(student.ID);
            Console.WriteLine(student.Name);

            Console.WriteLine(student2.ID);
            Console.WriteLine(student2.Name);



            dynamic number = 45;
            dynamic name = " charaf eddine jador";
            Console.WriteLine(" number value ={0}   type = {1}", number, number.GetType());
            Console.WriteLine(" Name value ={0}   type = {1}", name, name.GetType());
            Console.ReadKey();
        }
    }
}
