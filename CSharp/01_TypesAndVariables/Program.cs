using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01_TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            //Value Types
            //veri türü  değişken ismi =;

            int number1 = 2147483647;
            int number00 = 25;

            /*
            int -> işaretli tamsayı
            - Byte:4
            - Alt Üst Sınırlar: -2147483648 ile 2147483647
             
             */


            Console.WriteLine(number1);

            Console.WriteLine("Number1 is {0}   {1}", number1, number00);

            long number2 = 9223372036854775807;

            /*
             long -> işaretli tamsayı
             - Byte: 8
             - Alt Üst Sınırlar: -9223372036854775808 ile 9223372036854775807
             
             */


            Console.WriteLine("Number2 is {0}", number2);

            short number3 = 32767;

            /*
             short -> işaretli tamsayı
             - Byte: 2
             - Alt Üst Sınırlar: 	-32768 ile 32767
             
             */

            Console.WriteLine("Number3 is {0}", number3);

            byte number4 = 136;

            /*
             byte -> işaretsiz tamsayı
             - Byte: 1
             - Alt Üst Sınırlar: 0 ile 255
             
             */


            Console.WriteLine("Number4 is {0}", number4);

            bool condition = false;

            /*
             bool -> 
             - Byte: 2
             - Değer Aralığı: true-false
             
             */

            char character = 'A';


            /*
             char -> Unicode karakterler
             - Byte: 2
             - Alt Üst Sınırlar: U + u + ffff 0000
             
             */


            double number5 = 10.4;

            /*
             double -> çift kayan sayı
             - Byte: 8
             - Alt Üst Sınırlar: 
             
             */

            Console.WriteLine("Number5 is {0}", number5);

            decimal number6 = 10;
            decimal number60 = 10.4M;

            /*
             decimal -> ondalıklı sayı
             - Byte: 16
             - Alt Üst Sınırlar: 
             Virgülden sonra 28 29 tane değer tutabiliyor.

           */

            Console.WriteLine("Number6 is {0} {1}", number6, number60);

            var number7 = 10;


            Console.WriteLine("Number7 is {0}", number7);

            number7 = 'A';

            //number7 = "A";

            Console.WriteLine(character);

            Console.WriteLine("Character is : {0}", (int)character); //ASCII CODE

            Console.WriteLine((int)Days.Friday);

            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday = 10, Tuesday = 20, Wednesday = 30, Thursday, Friday, Saturday, Sunday
    }
}
