using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter number between 1 to 3");
            int number= Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    {
                        for (int i = 0; i <= 10; i++)
                        {
                            if (i == 5)
                                continue;
                            Console.WriteLine(i);
                        }
                        break;
                    }
                case 2:
                    {
                        int i = 0;
                        while (i < 10)
                        {
                            i++;
                           
                            Console.WriteLine(i);

                            if (i == 7)
                                break;
                        }
                        break;
                    }
                case 3:
                    {
                        int i = 0;
                        do
                        {
                            ++i;
                            
                            Console.WriteLine(i);
                        } while (i <= 4);
                        break;
                    }
                default:
                    Console.WriteLine(" invalid choice");
                    break;
            }
        }
    }
}
