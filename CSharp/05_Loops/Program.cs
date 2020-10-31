using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _05_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoop();

            Console.WriteLine(" \n################################ \n");

            WhileLoop();

            Console.WriteLine(" \n################################ \n");

            DoWhileLoop();

            Console.WriteLine(" \n################################ \n");

            ForEachLoop();

        }



        //ForEachLoop();

        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Ali", "Ahmet", "Veli" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        /* https://docs.microsoft.com/tr-tr/dotnet/csharp/language-reference/keywords/foreach-in */


        //DoWhileLoop();

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }


        //WhileLoop

        private static void WhileLoop()
        {
            int number = 50;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        //ForLoop();

        private static void ForLoop()
        {
            for (int i = 50; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
        }
    }
}
