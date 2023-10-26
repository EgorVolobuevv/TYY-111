using System;
class Program
{
    static void Main(string[] args)
    {
        double xAbs, xACosSinTan, xAtan21, xAtan22, xCosSinTan, xCoshSinhTanh, xEquals1, xEquals2, xExp, xLog1, xLog2, xLog10, xMaxMin1, xMaxMin2, xPow1, xPow2, xRound, xSign, xSqrt;
        int xBigMul1, xBigMul2;
        decimal xCeiling, xFloor, xTruncate;


        Console.WriteLine("Нажмите на любую кнопку, чтобы начать общую часть работы");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");

        Console.WriteLine("Введите число, для получения его модуля");
        xAbs = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число от -1 до 1, для получения тригонометрических функций");
        xACosSinTan = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число, чтобы получить угол, тангенс которого равен отношению двух указанных чисел");
        Console.WriteLine("Введите занчение x и y:");
        xAtan21 = Convert.ToDouble(Console.ReadLine());
        xAtan22 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите два целых числа для их произведения:");
        xBigMul1 = Convert.ToInt32(Console.ReadLine());
        xBigMul2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число, чтобы получить наименьшее целое число, которое больше или равно указанному числу");
        xCeiling = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Введите угол, измеряемый в радианах, для получение его косинуса, синуса и тангенса");
        xCosSinTan = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите угол, измеряемый в радианах, для получения гиперболического косинуса, синуса и тангенса");
        xCoshSinhTanh = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Нажмите любую клавишу, для получения математических констант");
        Console.ReadKey(true);
        Console.WriteLine("Введите два числа, чтобы проверить их равность");
        xEquals1 = Convert.ToInt32(Console.ReadLine());
        xEquals2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число, для возведения числа 'e' в указанную степень");
        xExp = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число, чтобы получить наибольшее целое число, которое меньше или равно указанному числу");
        xFloor = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Введите аргумент и основание для логарифма, чтобы получить ответ на логарифм");
        xLog1 = Convert.ToInt32(Console.ReadLine());
        xLog2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите аргумент, для десятичного логарифма, чтобы получить ответ на десятичный логарифм");
        xLog10 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите два числа, чтобы получить максимальное и минимальное из них");
        xMaxMin1 = Convert.ToInt32(Console.ReadLine());
        xMaxMin2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число и степень, в которую его нужно возвести");
        xPow1 = Convert.ToInt32(Console.ReadLine());
        xPow2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число, для его округления");
        xRound = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число. Если оно отрицательное, то программа вернет '-1', если положительное, то '1', если число равно 0, '0'");
        xSign = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число, чтобы узнать его корень");
        xSqrt = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите десятичное число, чтобы получить его целую часть");
        xTruncate = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
        Console.ReadKey(true);
        Console.WriteLine("-------------------------------------------------------------------------------------------------");

        Console.WriteLine("Модуль данного числа равен" + " " + Math.Abs(xAbs));
        Console.WriteLine("Угол, косинус которого равен указанному числу равен" + " " + Math.Acos(xACosSinTan));
        Console.WriteLine("Угол, синус которого равен указанному числу равен" + " " + Math.Asin(xACosSinTan));
        Console.WriteLine("Угол, тангенс которого равен указанному числу равен " + " " + Math.Atan(xACosSinTan));
        Console.WriteLine("Угол, тангенс которого равен отношению двух указанных чисел:" + " " + Math.Atan2(xAtan21, xAtan22));
        Console.WriteLine("Произведение данных чисел равно" + " " + Math.BigMul(xBigMul1, xBigMul2));
        Console.WriteLine("Наименьшее целое число, которое больше или равно указанному числу:" + "" + Math.Ceiling(xCeiling));
        Console.WriteLine("косинус:" + " " + Math.Cos(xCosSinTan));
        Console.WriteLine("синус:" + " " + Math.Sin(xCosSinTan));
        Console.WriteLine("тангенс" + " " + Math.Tan(xCosSinTan));
        Console.WriteLine("гиперболический косинус:" + " " + Math.Cosh(xCoshSinhTanh));
        Console.WriteLine("гиперболический синус:" + " " + Math.Sinh(xCoshSinhTanh));
        Console.WriteLine("гиперболический тангенс:" + " " + Math.Tanh(xCoshSinhTanh));
        Console.WriteLine("Экспонента:" + " " + Math.E);
        Console.WriteLine("Число ПИ:" + " " + Math.PI);
        Console.WriteLine("Равны?" + " " + Math.Equals(xEquals1, xEquals2));
        Console.WriteLine("Результат возведения числа 'e' в эту степень:" + " " + Math.Exp(xExp));
        Console.WriteLine("Наибольшее целое число, которое меньше или равно указанному числу:" + " " + Math.Floor(xFloor));
        Console.WriteLine("Ответ на логарифм:" + " " + Math.Log(xLog1, xLog2));
        Console.WriteLine("Ответ на логарифм:" + " " + Math.Log10(xLog10));
        Console.WriteLine("максимальное число:" + " " + Math.Max(xMaxMin1, xMaxMin2));
        Console.WriteLine("минимальное число:" + " " + Math.Min(xMaxMin1, xMaxMin2));
        Console.WriteLine("Число в степени:" + " " + Math.Pow(xPow1, xPow2));
        Console.WriteLine("Округленное число:" + " " + Math.Round(xRound));
        Console.WriteLine(Math.Sign(xSign));
        Console.WriteLine("Корень этого числа:" + " " + Math.Sqrt(xSqrt));
        Console.WriteLine("Целая часть этого числа:" + " " + Math.Truncate(xTruncate));
        Console.WriteLine("-------------------------------------------------------------------------------------------------");

        Console.WriteLine("Нажмите любую кнопку, чтобы начать вторую часть работы");
        Console.ReadKey(true);
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