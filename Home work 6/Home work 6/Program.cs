using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Home_work_6
{
    class Program
    {

        static void Main(string[] args)
        {
            Task5();
        }        
        static void Task1()
        {
            string stih = Console.ReadLine();
            string name = stih.Replace('o', 'a');
            char[] seps = { ';' };
            string[] array = name.Split(seps);            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
             }
                Console.ReadKey();
        } 
        static void Task2()
        {
            string stih = "Let me introduce myself. My full name is Andrei Andreevich Ivanov.";
            char[] seps = { ' ' };
            string[] parts = stih.Split(seps);
            int a = 0; int l = 0;
            for (int i = 1; i < parts.Length; i++)
            {
                if (parts[a].Length > parts[i].Length)
                {
                }                                                                                                                
                else 
                {
                 a = i;
                }
                if (parts[l].Length < parts[i].Length)
                {
                }
                else
                {
                    l = i;
                }                
            }            
            Console.WriteLine("Самое длинное слово = {0}. Самое короткое слово {1}", parts[a], parts[l]);            
            Console.ReadKey();            
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length == parts[a].Length)
                {                    
                    parts[i] = string.Empty;
                }
            }                     
            string jj = string.Join(" ",parts);            
            Console.WriteLine(jj);
            Console.WriteLine(stih);
            Console.ReadKey();             
        }        
        static void Task3()
        {
            string stih = "Let me introduce myself. My full name is Andrei Andreevich Ivanov.";

            char[] seps = { ' ' };
            string[] parts = stih.Split(seps);
            int a = 0; int l = 0;
            for (int i = 1; i < parts.Length; i++)
            {
                if (parts[a].Length > parts[i].Length)
                {
                }
                else
                {  a = i;
                }
                if (parts[l].Length < parts[i].Length)
                {
                }
                else
                {  l = i;
                }
            }            
            Console.WriteLine("Самое длинное слово = {0}. Самое короткое слово = {1}", parts[a], parts[l]);
            Console.ReadKey();        
            string rep = parts[a];
            parts[a] = parts[l];
            parts[l] = rep;                     
            string result = string.Join(" ", parts);
            Console.WriteLine(result);
            Console.WriteLine(stih);
            Console.ReadKey();

        }
        static void Task4()
        {
            string stih = "Let me introduce myself. My full name is Andrei Andreevich Ivanov.";
            int a = 0; //пунктационные знаки
            int b = 0; // буквы
            foreach (char i in stih)
            { 
                if (Convert.ToInt32(i) < 60 && Convert.ToInt32(i)>33)
                {                                     
                    a++;
                    Console.WriteLine(" Pribavlyaem a  = {0} i simbol u nas ({1}). Potomushto - i = {2}", a, i, Convert.ToInt32(i) );                    
                }
                else
                {
                    b++;
                    Console.WriteLine(" Pribavlyaem b = {0} i simbol u nas ({1}). Potomushto - i = {2}", b, i, Convert.ToInt32(i));                   
                }            
            }
            Console.WriteLine("В строке {0}- пунктуационных знаков и {1} - букв", a, b);
            Console.ReadKey();
        }
        static void Task5()
        {
            string stih = "Let me introduce myself. My full name is Andrei Andreevich Ivanov.";
            char[] seps = { ' ' };
            string[] parts = stih.Split(seps);
            string[] array = new string [parts.Length];
            int a = 0;
            for (int i1 = 0; i1 < parts.Length; i1++)
            {              
                for (int i = 1; i < parts.Length; i++)
                {
                    if (parts[a].Length > parts[i].Length)
                    {
                    }
                    else
                    {
                        a = i;                        
                    }    
                }                       
                array[i1] = parts[a];
                parts[a] = string.Empty;                      
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                Console.ReadKey();
            }
        }
        static void Test6()
        {
        }
    }
    }

