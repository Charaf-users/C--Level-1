using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void PrintName()
        {
            Console.WriteLine("charaf eddine jador");
        }
        static void PrintInfo(string name ,byte age ,string adress=" No Adress here")
        {
            Console.WriteLine("Name :{0}  Age:{1}   Adress : {2} ", name, age,adress);
        }

        static int mysum(int num1,int num2)
        {
            return num1 + num2;
        }
        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }
        static int mysum(int Num1, int Num2, int Num3)

        {
            return Num1 + Num2 + Num3;
        }
        static int mysum(int Num1, int Num2, int Num3, int Num4)

        {
            return Num1 + Num2 + Num3 + Num4;
        }


        static void Main(string[] args)
        {
            PrintName();
            PrintInfo("charaf eddine jador", 20);
            PrintInfo("charaf eddine jador", 20,"Casablanca hayhassani ");
            MyMethod(child3: "Omar", child1: "Saqer", child2: "Hamza");
             Console.WriteLine(mysum(10, 20));
            Console.WriteLine( mysum(10, 20,50));
            Console.WriteLine(mysum(10, 20,50,20));

            Console.ReadKey();
        }
    }
}
