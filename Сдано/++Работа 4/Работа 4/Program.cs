using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabota_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, x4, y1, y2, y3, y4, k1, k2;
            bool flg1, flg2, flg3, flg4, flg5, flg6, flg7, flg8;
            Console.WriteLine("Введите координаты точек A и B для первой прямой:");
            Console.Write("Введите значение для координаты x точки A: ");
            flg1=Double.TryParse(Console.ReadLine(), out x1);
            Console.Write("Введите значение для координаты y точки A: ");
            flg2=Double.TryParse(Console.ReadLine(), out y1);
            Console.Write("Введите значение для координаты x точки B: ");
            flg3=Double.TryParse(Console.ReadLine(), out x2);
            Console.Write("Введите значение для координаты y точки B: ");
            flg4=Double.TryParse(Console.ReadLine(), out y2);

            Console.WriteLine("Введите координаты точек C и D для второй прямой:");
            Console.Write("Введите значение для координаты x точки C: ");
            flg5=Double.TryParse(Console.ReadLine(), out x3);
            Console.Write("Введите значение для координаты y точки C: ");
            flg6=Double.TryParse(Console.ReadLine(), out y3);
            Console.Write("Введите значение для координаты x точки D: ");
            flg7=Double.TryParse(Console.ReadLine(), out x4);
            Console.Write("Введите значение для координаты y точки D: ");
            flg8=Double.TryParse(Console.ReadLine(), out y4);
            if (flg1 && flg2 && flg3 && flg4 && flg5 && flg6 && flg7 && flg8)
            {
                // Вычисляем угловые коэффициенты для обеих прямых 
                k1 = (y2 - y1) / (x2 - x1);
                k2 = (y4 - y3) / (x4 - x3);

                // Проверяем, являются ли прямые перпендикулярными 
                if (k1 * k2 == -1)
                {
                    Console.WriteLine("Прямые перпендикулярны");
                }
                else
                {
                    Console.WriteLine("Прямые не перпендикулярны");
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