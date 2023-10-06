﻿
using System;
class Program
{
    static void Main(string[] args)
    {
        int a;
        int b;
        double c;
        decimal d;

        Console.WriteLine("Нажмите на любую кнопку, чтобы начать общую часть работы");

        Console.ReadKey(true);

        Console.WriteLine("Введите число, для получения его модуля");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Модуль данного числа равен" + " " + Math.Abs(a));

        Console.WriteLine("Введите число от -1 до 1, для получения тригонометрических функций");
        c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Угол, косинус которого равен указанному числу равен" + " " + Math.Acos(c));
        Console.WriteLine("Угол, синус которого равен указанному числу равен" + " " + Math.Asin(c));
        Console.WriteLine("Угол, тангенс которого равен указанному числу равен " + " " + Math.Atan(c));

        Console.WriteLine("Введите число, чтобы получить угол, тангенс которого равен отношению двух указанных чисел");
        double x;
        double y;
        Console.WriteLine("Введите занчение x и y:");
        x = Convert.ToDouble(Console.ReadLine());
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Угол, тангенс которого равен отношению двух указанных чисел:" + " " + Math.Atan2(x, y));

        Console.WriteLine("Введите два целых числа для их произведения:");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Произведение данных чисел равно" + " " + Math.BigMul(a, b));

        Console.WriteLine("Введите число, чтобы получить наименьшее целое число, которое больше или равно указанному числу");
        d = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine(Math.Ceiling(d));

        Console.WriteLine("Введите угол, измеряемый в радианах, для получение его косинуса, синуса и тангенса");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("косинус:" + " " + Math.Cos(a));
        Console.WriteLine("синус:" + " " + Math.Sin(a));
        Console.WriteLine("тангенс" + " " + Math.Tan(a));

        Console.WriteLine("Введите угол, измеряемый в радианах, для получения гиперболического косинуса, синуса и тангенса");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("гиперболический косинус:" + " " + Math.Cosh(a));
        Console.WriteLine("гиперболический синус:" + " " + Math.Sinh(a));
        Console.WriteLine("гиперболический тангенс:" + " " + Math.Tanh(a));

        Console.WriteLine("Нажмите любую клавишу, для получения математических констант");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Экспонента:" + " " + Math.E);
        Console.WriteLine("Число ПИ:" + " " + Math.PI);

        Console.WriteLine("Введите два числа, чтобы проверить их равность");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine(Math.Equals(a, b));

        Console.WriteLine("Введите число, для возведения числа 'e' в указанную степень");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Результат возведения числа 'e' в эту степень:" + " " + Math.Exp(a));

        Console.WriteLine("Введите число, чтобы получить наибольшее целое число, которое меньше или равно указанному числу");
        d = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Наибольшее целое число, которое меньше или равно указанному числу:" + " " + Math.Floor(d));

        Console.WriteLine("Введите аргумент и основание для логарифма, чтобы получить ответ на логарифм");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Ответ на логарифм:" + " " + Math.Log(a, b));

        Console.WriteLine("Введите аргумент, для десятичного логарифма, чтобы получить ответ на десятичный логарифм");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Ответ на логарифм:" + " " + Math.Log10(a));

        Console.WriteLine("Введите два числа, чтобы получить максимальное и минимальное из них");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("максимальное число:" + " " + Math.Max(a, b));
        Console.WriteLine("минимальное число:" + " " + Math.Min(a, b));

        Console.WriteLine("Введите число и степень, в которую его нужно возвести");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Число в степени:" + " " + Math.Pow(a, b));

        Console.WriteLine("Введите число, для его округления");
        c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Округленное число:" + " " + Math.Round(c));

        Console.WriteLine("Введите число. Если оно отрицательное, то программа вернет '-1', если положительное, то '1', если число равно 0, '0'");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine(Math.Sign(a));

        Console.WriteLine("Введите число, чтобы узнать его корень");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Корень этого числа:" + " " + Math.Sqrt(a));

        Console.WriteLine("Введите десятичное число, чтобы получить его целую часть");
        d = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Целая часть этого числа:" + " " + Math.Truncate(d));

        Console.WriteLine("Нажмите любую кнопку, чтобы начать вторую часть работы");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Вариант 13");
        double left = Math.Round(Math.Acos(1 / 2.0) * (180.0 / Math.PI));
        double right = 60.0;
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Левая часть выражения: " + " " + left);
        Console.WriteLine("Правая часть выражения: " + " " + right);
        Console.WriteLine(left.Equals(right));
    }
}
