using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabota_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, x0, xk, dx, alpha, beta, M, eps=0.001;
            bool flg1,flg2,flg3,flg4,flg5;
            Console.WriteLine("---Ввод значений для констант---");
            Console.Write("Введите значение alpha: ");
            flg1= Double.TryParse(Console.ReadLine(), out alpha);
            Console.Write("Введите значение beta: ");
            flg2= Double.TryParse(Console.ReadLine(), out beta);
            Console.WriteLine("---Ввод начала и конца диапазона---");
            Console.Write("Введите начало диапазона: ");
            flg3= Double.TryParse(Console.ReadLine(), out x0);
            Console.Write("Введите конец диапозона: ");
            flg4= Double.TryParse(Console.ReadLine(), out xk);
            Console.WriteLine("---Ввод шага---");
            Console.Write("Введите шаг: ");
            flg5= Double.TryParse(Console.ReadLine(), out dx);
            if (flg1&flg2&flg3&flg4&flg5)
            {
                x = x0;
                while (x <= xk)
                {
                    flg1= Math.Abs(Math.Pow(Math.E, alpha - beta) + Math.Pow(x, 3)) >= eps;
                    if (flg1)
                    {
                        M = (2.48 + Math.Cos(Math.Sin(beta))) / (Math.Pow(Math.E, alpha - beta) + Math.Pow(x, 3));
                        Console.WriteLine($"При x = {x:F3}, M(x) = {M}");
                    }
                    else
                        Console.WriteLine($"При x = {x:F3}, M(x) не существует");
                    x += dx;
                }
            }
            else
                Console.WriteLine("Введены некорректные данные");
            Console.ReadKey(true);
        }
    }
}
