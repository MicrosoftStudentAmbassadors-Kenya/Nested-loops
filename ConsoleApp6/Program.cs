using System;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            for (int i = 1; i <=number ; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");
            for (int i = 1; i <=9; i++)
           {
               for (int j = 1; j <=9; j++)
               {
                   if ((i * j) < 10)
                   {
                       Console.Write(j * i + "  ");
                    }
                   else
                   {
                       Console.Write(j * i + " ");
                   }
               }

               Console.WriteLine();
           }
       
            Console.ReadKey();
        }

       
    }
}
