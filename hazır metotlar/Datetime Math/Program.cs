using System;

namespace Datetime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            
            Console.WriteLine(DateTime.Now.ToLongDateString()); //saturday, april 24 2021
            Console.WriteLine(DateTime.Now.ToShortDateString());// 4/24/2021
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddMinutes(30));
            Console.WriteLine(DateTime.Now.AddMonths(10));
            Console.WriteLine(DateTime.Now.AddYears(4));
            
            // Datetime format
            
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));


            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));


            // Math kütüphanesi
            
            System.Console.WriteLine(Math.Abs(-25)); // Mutlak değer 25
            System.Console.WriteLine(Math.Sin(10));
            System.Console.WriteLine(Math.Cos(10));
            System.Console.WriteLine(Math.Tan(10));

            System.Console.WriteLine(Math.Ceiling(22.3)); // 23
            System.Console.WriteLine(Math.Round(22.3)); // 22
            System.Console.WriteLine(Math.Floor(22.7)); // 22

            System.Console.WriteLine(Math.Max(2,6));
            System.Console.WriteLine(Math.Min(2,6));

            System.Console.WriteLine(Math.Pow(3,4));// 3^4
            System.Console.WriteLine(Math.Sqrt(9));// karekök
            System.Console.WriteLine(Math.Log(9));// e tabanında logaritma
            System.Console.WriteLine(Math.Exp(3));// e^3
            System.Console.WriteLine(Math.Log10(10));// 10 tabanında logaritma
        }
    }
}
