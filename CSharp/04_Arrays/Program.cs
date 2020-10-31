using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] students = new string[3];

            students[0] = "Ali";
            students[1] = "Ahmet";
            students[2] = "Veli";

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(" \n ################################ \n");

            string[] students02 = new string[3] { "Ali", "Ahmet", "Veli" };


            foreach (var student in students02)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(" \n ################################ \n");

            string[,] regions = new string[5, 3] // 5 satır 3 sütun
                        {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" }
                        };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*********");
            }

            Console.ReadLine();

        }
    }
}
