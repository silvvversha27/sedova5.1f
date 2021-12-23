using System;

namespace sedova5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты сторон треугольника");
            Console.WriteLine("");
            Console.WriteLine("Введите сторону аx");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону аy");
            double a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону bx");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону by");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону сx");
            double c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону сy");
            double c2 = double.Parse(Console.ReadLine());
            double a = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b1 - b2, 2));
            double b = Math.Sqrt(Math.Pow(b2 - b1, 2) + Math.Pow(c1 - c2, 2));
            double c = Math.Sqrt(Math.Pow(c2 - c1, 2) + Math.Pow(a1 - a2, 2));
            double alpha = 0;
            double betta = 0;
            double gamma = 0;
            Console.WriteLine("");
            alpha = (((Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180)) / Math.PI);
            Console.WriteLine("alpha = {0:f2}", alpha);
            betta = (((Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180)) / Math.PI);
            Console.WriteLine("betta = {0:f2}", betta);
            gamma = (((Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180)) / Math.PI);
            Console.WriteLine("gamma = {0:f2}", gamma);
            Console.WriteLine("");
            if ((a < b + c) & (b < c + a) & (c < b + a))
            {
                if ((alpha == 90) || (betta == 90) || (gamma == 90)) Console.WriteLine(" Треугольник прямоугольный");
                else
                    if ((alpha > 90) || (betta > 90) || (gamma > 90)) Console.WriteLine("Треугольник тупоугольный");
                else
                    Console.WriteLine("Треугольник остроугольный");
            }
            else
                Console.WriteLine("Теугольник не существует");
            Console.ReadKey();
        }
    }
}
