using System;
using System.Collections.Generic;
using System.Text;

namespace Laba14._02
{
    public class lab2
    {
       public static void NotMain()

        {
            Console.WriteLine("                     Задание 2                     ");
            Console.Write("Введите число n: ");
            string n = Console.ReadLine();
            string buff;
            buff = n.Substring(n.Length-1);
            n = n.Remove(n.Length-1);
            n = n.Insert(1, buff);
            Console.Write("Результат: ");
            Console.Write(n);
        }
    }
}
