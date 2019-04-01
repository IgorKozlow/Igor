using System;

namespace case_2
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int z = Convert.ToInt32(Console.ReadLine());
        
                Console.WriteLine("число z = " + z);

            do
            {
                if (z < 11) {++z;
                Console.WriteLine(z);
            }
                else Console.WriteLine("chislo больше 11 ");

            } while (z < 11);




            Console.WriteLine("число z = {0}",z);





            Console.ReadKey();

            


        }
    }
}