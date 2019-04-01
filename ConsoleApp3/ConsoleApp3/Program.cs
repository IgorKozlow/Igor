using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        // Данный метод выводит таблицу умножения
        // размерностью b x b
        static void tab(byte b)
        {
            Console.WriteLine("Таблица умножения {0} x {0}\n", b);
            // Этот цикл проходит по строкам
            for (int i = 1; i <= b; i++)
            {
                // Этот цикл проходит по столбцам
                for (int j = 1; j <= b; j++)
                    Console.Write("{0}\t", j * i);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            tab(8);

            // Давайте разберем нестандартные возможности цикла for
            // ************************************************* //

            // Применение нескольких переменных управления циклом
            for (byte i = 0, j = 20; i <= j; i += 5, j -= 5)
                Console.WriteLine("i = {0}, j = {1}", i, j);
            Console.WriteLine();

            // Использование условного выражения в цикле
            bool b = false;
            for (byte i = 1, j = 100; !b; i++, j--)
                if (i < Math.Sqrt(j))
                    Console.WriteLine("Число {0} меньше квадратного корня из {1}", i, j);
                else b = true;

            // Отсутствие части цикла
            int k = 0;
            for (; k < 10;)
            {
                k++;
                Console.Write(k);
            }
            Console.WriteLine("\n");

            // Цикл без тела
            int sum = 0;
            for (int i = 1; i <= 10; sum += ++i) ;

            Console.WriteLine("Значение суммы: {0}", sum);

            Console.ReadLine();
        }
    }
}