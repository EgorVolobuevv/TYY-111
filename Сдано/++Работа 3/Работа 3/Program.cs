using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabota_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y, b, alpha, e, beta, m, u, w, eps = 0.001;
            bool flg1, flg2, flg3, flg4, flg5;
            Console.Write("Введите значение для переменной u: ");
            flg1 = Double.TryParse(Console.ReadLine(), out u);
            Console.Write("Введите значение для переменной w: ");
            flg2 = Double.TryParse(Console.ReadLine(), out w);
            Console.Write("Введите значение для переменной alpha: ");
            flg3 = Double.TryParse(Console.ReadLine(), out alpha);
            Console.Write("Введите значение для переменной m: ");
            flg4 = Double.TryParse(Console.ReadLine(), out m);
            Console.Write("Введите значение для переменной beta: ");
            flg5 = Double.TryParse(Console.ReadLine(), out beta);
            if (flg1 && flg2 && flg3 && flg4 && flg5)
            {

                if (alpha > m)
                {
                    e = alpha * Math.Cos(alpha);
                }
                else
                {
                    e = alpha * Math.Tan(alpha);
                }
                if (alpha == m)
                {
                    e = Math.Pow(alpha, 2) + beta * Math.Sqrt(beta);
                }
                flg1 = (Math.Pow(u, 2) + alpha) > 0;
                if (flg1)
                {
                    flg2 = Math.Abs((alpha + w * Math.Cos(u))) >= eps;
                    if (flg2)
                    {
                        flg3 = (Math.Pow(beta, 2) + e) >= 0;
                        if (flg3)
                        {
                            flg4 = Math.Abs((e + Math.Sqrt(Math.Pow(beta, 2) + e))) >= eps;
                            if (flg4)
                            {
                                b = (alpha + w * Math.Cos(u)) / Math.Sqrt(Math.Pow(u, 2) + alpha);
                                y = (Math.Pow(alpha, 2) + b) / (e + Math.Sqrt(Math.Pow(beta, 2) + e));
                                Console.WriteLine("Значение арифметического выражение: " + y);

                            }
                            else
                            {
                                Console.WriteLine("Решений нет");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Решений нет");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Решений нет");
                    }
                }
                else
                {
                    Console.WriteLine("Решений нет");
                }
            }
            else
            {
                Console.WriteLine("Введены некорректные данные");
            }
            Console.ReadKey(true);
        }
    }
}
