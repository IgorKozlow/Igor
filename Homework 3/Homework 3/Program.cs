using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vvedity operati + ili - ");
            string op = Console.ReadLine();

            Console.WriteLine(" vvedite chislo a");
            string a = Console.ReadLine();
            int a1 = Convert.ToInt32(a);

            Console.WriteLine("vvedity chislo b");
            string b = Console.ReadLine();
            int b1 = Convert.ToInt32(b);

            Console.WriteLine("Vvedity  resultat ");
            string c = Console.ReadLine();
            int c1 = Convert.ToInt32(c);

            int z = 0;


            if (op == "+")
                z = a1 + b1;
            if (op == "-")
                z = a1 - b1;
            if (z == c1)
                Console.WriteLine("pravilno");
            if (z != c1)
                Console.WriteLine("net");
            if (z > c1)
                Console.WriteLine("chislo menshe");
            if (z < c1)
                Console.WriteLine("chislo bolshe");

            Console.WriteLine(z);
            

            Console.ReadKey();





        }
    }
}
