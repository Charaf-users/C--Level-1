using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "charaf eddine jador";
            Console.WriteLine(name.Length);

            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Replace("e", "a"));
            Console.WriteLine(name.IndexOf("j"));
            Console.WriteLine(name.Insert(8, "e"));
            Console.WriteLine(name.Contains("e"));
            Console.WriteLine(name.Contains("x"));
            Console.WriteLine(name.LastIndexOf("e"));

            string S2 = "Ali Ahmed Khalid";

            string[] NamesList = S2.Split(' ');

            Console.WriteLine(NamesList[0]);
            Console.WriteLine(NamesList[1]);
            Console.WriteLine(NamesList[2]);

            string S3 = "  Charaf-eddine ";
            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimStart());
            Console.WriteLine(S3.TrimEnd());

            string firstName = "charaf eddine ";
            string lastName = "Jador ";
            string code = "100";

            //You shold use $ to $ to identify an interpolated string  
            string fullName = $"Mr. {firstName} {lastName}, Code: {code}";

            Console.WriteLine(fullName);


            Console.ReadKey();
        }
    }
}
