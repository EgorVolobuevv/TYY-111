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
        double  y,b, alpha, e, beta, m, u, w, eps = 0.001;
        bool flg1, flg2, flg3, flg4, flg5;
            Console.Write("Введите значение для переменной u: ");
            flg1=Double.TryParse(Console.ReadLine(), out u);
            Console.Write("Введите значение для переменной w: ");
            flg2=Double.TryParse(Console.ReadLine(), out w);
            Console.Write("Введите значение для переменной alpha: ");
            flg3=Double.TryParse(Console.ReadLine(), out alpha);
            Console.Write("Введите значение для переменной m: ");
            flg4=Double.TryParse(Console.ReadLine(), out m);
            Console.Write("Введите значение для переменной beta: ");
            flg5=Double.TryParse(Console.ReadLine(), out beta);
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
                if (alpha==m)
                {
                    e = Math.Pow(alpha, 2) + beta * Math.Sqrt(beta);

                }
                flg1 = (alpha + w * Math.Cos(u)) >= eps;
                flg2 = (Math.Pow(beta, 2) + e) >= 0;
                flg3 = (Math.Pow(u, 2) + alpha) >= 0;
                flg4 = (Math.Sqrt(Math.Pow(u, 2) + alpha)) != 0;
                flg5 = (e + Math.Sqrt(Math.Pow(beta, 2) + e)) != 0;
                b = (alpha + w * Math.Cos(u)) / Math.Sqrt(Math.Pow(u, 2) + alpha);
                y = (Math.Pow(alpha, 2) + b) / (e + Math.Sqrt(Math.Pow(beta, 2) + e));
                if (flg1 && flg2 && flg3 && flg4 && flg5)
                {
                    Console.WriteLine("Значение арифметического выражение: " + y);
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
