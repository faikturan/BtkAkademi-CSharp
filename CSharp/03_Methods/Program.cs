using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();

            Console.WriteLine(" \n ################################ \n");


            var result = Add2();

            int number1;

            int number2 = 100;

            var result2 = Add3(out number1, number2);

            Console.WriteLine(result2);

            Console.WriteLine("\n ################################ \n");

            Console.WriteLine(number1);

            Console.WriteLine("\n ################################ \n");

            Console.WriteLine(Multiply(3, 5));  //method overloading

            Console.WriteLine("\n ################################ \n");

            Console.WriteLine(Multiply(1, 4, 5));  //method overloading

            Console.WriteLine("\n ################################ \n");

            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!!! \n");
        }

        static int Add2(int number1 = 15, int number2 = 40)
        {
            var result = number1 + number2;

            return result;
        }

        static int Add3(out int number1, int number2)
        {
            number1 = 50;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //params keyword
        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}