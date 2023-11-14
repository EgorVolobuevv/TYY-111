using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabota_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flg;
            char symbol;
            int ostatok;

            Console.Write("Введите кириллический символ: ");
            flg = char.TryParse(Console.ReadLine(), out symbol);

            if (flg)
            {
                ostatok = (int)symbol % 4;

                switch (ostatok)
                {
                    case 0:
                        Console.WriteLine("(" + Convert.ToChar((int)symbol + 1) + ")");
                        break;
                    case 1:
                        Console.WriteLine("[" + Convert.ToChar((int)symbol + 1) + "]");
                        break;
                    case 2:
                        Console.WriteLine("<" + Convert.ToChar((int)symbol + 1) + ">");
                        break;
                    case 3:
                        Console.WriteLine("{" + Convert.ToChar((int)symbol + 1) + "}");
                        break;
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