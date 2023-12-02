using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabota_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a1 - степень числа a
            // n - колличество элементов ряда
            // x1 - степень числа x
            // s1 - степень аргумента синуса в знаменателе 
            double x, a, M = 0, eps = 0.001, a1 = 0.5;
            bool flg1, flg2, flg3, error = false;
            int n, x1 = 0, s1 = 0;
            Console.Write("Введите значение для перменной x: ");
            flg1 = Double.TryParse(Console.ReadLine(), out x);
            Console.Write("Введите значение для перменной a: ");
            flg2 = Double.TryParse(Console.ReadLine(), out a);
            Console.Write("Введите количество элементов n: ");
            flg3 = Int32.TryParse(Console.ReadLine(), out n);
            if (flg1 && flg2 && flg3)
            {
                for (int i = 0; i < n; i++)
                {
                    x1 += 1;
                    s1 += 1;
                    a1 *= 2;
                    flg1 = Math.Abs(Math.Sin(Math.Pow((x + a), s1))) >= eps;
                    if (flg1)
                    {
                        M += (Math.Pow(x, x1) + Math.Pow(a, a1)) / Math.Sin(Math.Pow((x + a), s1));
                    }
                    else
                    {
                        error = true;
                    }

                }
                if (error == false)
                {
                    Console.WriteLine($"Результат расчета M = {M}");
                }
                else
                {
                    Console.WriteLine("Нет решений");
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


