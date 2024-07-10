using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(5));
            Console.WriteLine(DateTime.Now.AddSeconds(20));
            Console.WriteLine(DateTime.Now.AddMonths(3));
            Console.WriteLine(DateTime.Now.AddYears(7));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // Datetime Format

            Console.WriteLine(DateTime.Now.ToString("dd")); // 24
            Console.WriteLine(DateTime.Now.ToString("ddd")); // mon, sat, tue,
            Console.WriteLine(DateTime.Now.ToString("dddd")); // monday

            Console.WriteLine(DateTime.Now.ToString("MM")); //  04,06
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

            Console.WriteLine(DateTime.Now.ToString("yy")); // 24
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2024


            // Math Kütüphanesi

            Console.WriteLine(Math.Abs(-25)); // 25 mutlak değer
            Console.WriteLine(Math.Sin(25));
            Console.WriteLine(Math.Cos(25));
            Console.WriteLine(Math.Tan(30));


            Console.WriteLine(Math.Ceiling(15.3)); //16 yukarıya yuvarlar
            Console.WriteLine(Math.Round(12.3)); // 12 hangisine yakınsa ona yuvarlar
            Console.WriteLine(Math.Round(12.7)); // 13
            Console.WriteLine(Math.Floor(15.7)); // 15 asağıya yuvarlar


            Console.WriteLine(Math.Max(6,2));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4)); // üs alir 3^4
            Console.WriteLine(Math.Sqrt(4)); // karesini alir
            Console.WriteLine(Math.Log(9));  // e tabanında logaritma alır
            Console.WriteLine(Math.Log10(10)); // 10 tabanında logaritma alir
            Console.WriteLine(Math.Exp(8)); //  e üzeri 8 verir.

            









        }
    }
}