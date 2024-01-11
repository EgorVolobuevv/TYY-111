using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabota_8
{
    internal class Program
    {
        static void Main()
        {
            int n, count = 0;
            bool flg1 = true, flg2 = true;
            Console.WriteLine("Введите длину одномерного массива: ");
            flg1 = Int32.TryParse(Console.ReadLine(), out n);
            if (flg1 == false)
            {
                Console.WriteLine("Введены некорректные данные");
            }
            else
            {
                int[] array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Введите {i + 1}-й элемент массива");
                    flg2 = int.TryParse(Console.ReadLine(), out array[i]);
                    if (flg2 == false)
                    {
                        break;
                    }
                }
                if (flg2 == false)
                {
                    Console.WriteLine("Введены некорректные данные");
                }
                else
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (array[j] % 2 != 0)
                            count++;
                    }
                    int[] newarray = new int[count];
                    int ind = 0;
                    for (int g = 0; g < n; g++)
                    {
                        if (array[g] % 2 != 0)
                        {
                            newarray[ind] = array[g];
                            ind++;
                        }
                    }
                    Array.Reverse(newarray);
                    Console.Write("Массив нечетных чисел, стоящих по убыванию = (");
                    for (int m = 0; m < newarray.Length; m++)
                    {
                        Console.Write(newarray[m] + (m < newarray.Length - 1 ? ", " : ")"));
                    }
                }
            }    
            Console.ReadKey(true);
        }
    }
}