using System;

namespace Laba14._02
{
    class lab1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double chislo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите степень: ");
            double stepen = Convert.ToDouble(Console.ReadLine());

            double result = 1;

            for (int i = 0; i < stepen; i++)
            {
                result *= chislo;
            }

            Console.Write("Результат: ");
            Console.WriteLine(result);
        }
    }
}