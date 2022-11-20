using System;

namespace _11._45
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            a = int.Parse(Console.ReadLine());
            b = a / 10;
            c = a % 10;
            d = Convert.ToInt32(Math.Pow(a, 2));
            e = 4 * Convert.ToInt32(Math.Pow(b, 3)) + 4 * Convert.ToInt32(Math.Pow(c, 3));
            if (d == e)
                Console.WriteLine("Равен");
            else
                Console.WriteLine("Не равен");
        }
    }
}
