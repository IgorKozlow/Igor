using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stress_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }

        static void Task1()
        {
            int[] array = new int[0];

           
                Console.WriteLine(array.Length);
            
            Console.ReadKey();
        }
        static void Task2()
        {
            object[] array = new object[3] {32, 'A', "hello"};
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(array[i]);

            }


            array[1] = new int();
            
            Console.WriteLine(array[1]);
            Console.ReadKey();
        }
    }
}
