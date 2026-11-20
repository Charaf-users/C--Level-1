using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime td1 = new DateTime();
            Console.WriteLine(td1.ToString());
            DateTime td2 = new DateTime(2024,10,25);
            Console.WriteLine(td2);
            DateTime td3 = new DateTime(2024, 10, 25,12,40,22);
            Console.WriteLine(td3);
            DateTime dt4 = new DateTime(2024, 10, 25, 12, 40, 22, DateTimeKind.Utc);
            Console.WriteLine(dt4);
            Console.WriteLine(dt4.Kind);
            Console.WriteLine(td3.Kind);

            // Get current Date

            DateTime td5 = new DateTime();
            td5 = DateTime.Now;
           Console.WriteLine(td5);
            // Ticks


            DateTime td6 = new DateTime();
            Console.WriteLine(DateTime.MinValue.Ticks);
            Console.WriteLine(DateTime.MaxValue.Ticks);

            DateTime CurrentDateTime = DateTime.Now;
            DateTime todayDate = DateTime.Today;
             DateTime currentDateTimeUTC = DateTime.UtcNow;
            DateTime maxDateTimeValue = DateTime.MaxValue; 
            DateTime minDateTimeValue = DateTime.MinValue;



            Console.WriteLine("current Date Time : " + CurrentDateTime);
            Console.WriteLine("Today: " + todayDate);
            Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);
            Console.WriteLine("minDateTimeValue: " + minDateTimeValue);
            Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);

            DateTime DT = new DateTime(2026, 1, 27);
            TimeSpan ts= new TimeSpan(48,10,22);

            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Seconds);
            Console.WriteLine(ts.Milliseconds);
            DateTime newDate = DT.Add(ts);

            Console.WriteLine(newDate);
            DateTime Date1 = new DateTime(2025, 10, 22);
            DateTime Date2 = new DateTime(2025, 10, 10);

            TimeSpan subDate = Date1.Subtract(Date2);
            Console.WriteLine(subDate.Days);

            DateTime dt1 = new DateTime(2015, 12, 20);
            DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(dt2 + time); // 1/10/2017 10:36:10 AM 
            Console.WriteLine(dt2 - dt1); //377.05:10:20 
            Console.WriteLine(dt1 == dt2); //False 
            Console.WriteLine(dt1 != dt2); //True 
            Console.WriteLine(dt1 > dt2); //False 
            Console.WriteLine(dt1 < dt2); //True 
            Console.WriteLine(dt1 >= dt2); //False 
            Console.WriteLine(dt1 <= dt2);//True 

            var str = "6/12/2023";
            DateTime dt;

            var isValidDate = DateTime.TryParse(str, out dt);

            if (isValidDate)
                Console.WriteLine(dt);
            else
                Console.WriteLine($"{str} is not a valid date string");

            //invalid string date 
            var str2 = "6/65/2023";
            DateTime dt7;

            var isValidDate2 = DateTime.TryParse(str2, out dt7);

            if (isValidDate2)
                Console.WriteLine(dt7);
            else
                Console.WriteLine($"{str2} is not a valid date string");


            Console.ReadKey();

        }
    }
}
