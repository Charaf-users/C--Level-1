using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxInC_
{
    internal class Program
    {
        static void Main()
        {
          

            //Console.Write(" Enter your Number : ");
            //int x=int.Parse(Console.ReadLine());
            //if(x<0)
            //{
            //    Console.Write("  your Number is Not Positive  enter again : ");
            //    int y = int.Parse(Console.ReadLine());
            //    Console.WriteLine(" your number is  :" + y);
            //}
            //else

            //    Console.WriteLine(" your number is  :" + x);
          
            int N=int.Parse(Console.ReadLine());
            int fact = 1;

            for(int i=2;i<=N;i++)
            {
                fact=fact*i;
            }
          Console.WriteLine(fact);



        }
    }
}
