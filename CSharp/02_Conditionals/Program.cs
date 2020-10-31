using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;


            // Else If Bloğuyla Çalışmak

            if (number == 10)
            {
                Console.WriteLine("Number is 10 \n");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20 \n");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20 \n");
            }


            Console.WriteLine("################################ \n");

            // Switch Bloğuyla Çalışmak

            var number2 = 20;

            switch (number2)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }


            Console.WriteLine("################################ \n");

            // Çoklu Şartlarla Çalışmak

            var number3 = 250;

            if (number3 >= 0 && number3 <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number3 > 100 && number3 <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number3 > 200 || number3 < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }


            // İç İçe If Bloklarıyla Çalışmak

            if (number < 100)
            {
                if (number >= 90 && number < 95)
                {

                }
                else
                {

                }


            }
            Console.ReadLine();
        }
    }
}
