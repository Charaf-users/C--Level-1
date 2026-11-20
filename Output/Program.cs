using System;


namespace Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // writeLine HomeWork
            // ex:1
            Console.WriteLine("Hello My name is charaf eddine jador :)");
            Console.WriteLine("I just learn c# after my journey in c++");
            Console.WriteLine("and c# is more easier than c++ because is high level programming language");
            //ex:2
            Console.WriteLine("Name : Charaf eddine jador");
            Console.WriteLine("Age : 20");
            Console.WriteLine("City : casablanca");
            // ex:3
            Console.WriteLine(" the sum of 10 + 50 = " + (10 + 50));
            Console.WriteLine(" the Multi of 10 * 50 = " + (10 * 50)+"\n\n\n");

            // write
            // ex :1
            Console.Write("hey");
            Console.Write(" my name ");
            Console.Write("is charaf eddine jador \n ");
            Console.Write("the sum of 10 + 50 = " + (10 + 50)+"\n\n\n");

            // Formatting String

            Console.WriteLine("{0} {1}", "welcome charaf", " To Programming");
            string name = "charaf eddine ";
            string city = "casablanca";
            Console.WriteLine("{0} lives in {1}", name, city);
            // Escape Characters
            Console.WriteLine("Name is : charaf eddine jador\n");
            Console.WriteLine("\t Age : 19\n");
            Console.WriteLine("\"I Said :\" C# is easy \n");
            Console.WriteLine("C:\\Program Files\\CSharp");
            Console.WriteLine("alert : ");
            Console.WriteLine("\a");

           

            Console.ReadKey();

        }
    }
}
