using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabota_2
{
    internal class Program
    {
        static void Main()
        {
            #region ПрисвоениеЗначенияПеременнойНабраннойИзСочетанияДругихПеременных
            double a, b, c, d, e, f, g, h, rez, rezz;
            a = (2.7 - 0.8) * (2 + (1 / 3.0));
            b = (5.2 - 1.4) / (3 / 7.0);
            c = Math.Pow(a / b, 1 / 5.0);
            d = Math.Pow(2.625, 1 / 2.0);
            e = 8 + (9 / 11.0);
            f = (95 + (7 / (30 - (93 + (5 / 18.0))))) * 2.25;
            g = f / Math.Pow(2, 1.2);
            h = Math.Pow(Math.PI, 1 / 6.0);
            rez = c - d + e - g + h;
            #endregion
            #region ПрисвоениеЗначенияОднойПеременной
            rezz = Math.Pow(((2.7 - 0.8) * (2 + (1 / 3.0))) / ((5.2 - 1.4) / (3 / 7.0)), 1 / 5.0) - Math.Pow(2.625, 1 / 2.0) + (8 + (9 / 11.0)) - ((95 + (7 / (30 - (93 + (5 / 18.0))))) * 2.25 / Math.Pow(2, 1.2)) + Math.Pow(Math.PI, 1 / 6.0);
            #endregion                                                                                                                                             ​ ​ ​          
            Console.WriteLine("Присвоение значения всего арифметического выражения одной переменной: " + rezz);
            Console.WriteLine("Присвоение значения переменной, набранной из сочетания других переменных: " + rez);
        }
    }
}
