using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Presentation_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();
        }

        static void Test1()

        {
            int[] array = new int[] { };

            Console.WriteLine(array);
            Console.ReadKey();
        }
        static void Test2()
        {
            object[] array = {32,'A', "Hello" };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            array[0] = Convert.ToInt32(array[0]) + 10;
            array[2] = Convert.ToString(array[2]) + ", guys";

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
        static void Test3()
        {
            Random random = new Random();

            int[] array = new int[13];

            int a = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
                Console.WriteLine(array[i]);

            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[a] > array[i])
                {
                    Console.WriteLine("  x = {0}   y = {1}", array[a], array[i]);
                    Console.ReadKey();                  
                }
                else
                {
                    a = i;
                    Console.WriteLine("  x = {0}   y = {1}", array[a], array[i]);
                    Console.ReadKey();
                }
            }
        }
    }
}
