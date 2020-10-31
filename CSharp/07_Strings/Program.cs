using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Metinsel verileri tutmak için kullanılan değişken tipine -string- denir.
     
     
 */


namespace _07_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();


            Console.WriteLine(" \n ################################ \n");

            string sentence = "My name is Rüveyda Solmaz";

            var result = sentence.Length; /* .Length: kaç karakterden oluştuğunu gösterir*/

            Console.WriteLine(result);

            Console.WriteLine(" \n ################################ \n");

            var result2 = sentence.Clone(); /* aynısı gibi kopyalar*/

            sentence = "My name is Ali Veli";

            Console.WriteLine(result2);





            Console.WriteLine(" \n ################################ \n");

            bool result3 = sentence.EndsWith("ğ"); /* Bu cümle ğ ile bitiyor mu*/

            bool result4 = sentence.StartsWith("My name"); /* Bu cümle My name ile başlıyor mu*/

            var result5 = sentence.IndexOf("namee"); /* Belli bir ifadeyi aramak için bakılır*/
            var result6 = sentence.IndexOf(" ");

            var result7 = sentence.LastIndexOf(" ");

            var result8 = sentence.Insert(0, "Hello, ");

            var result9 = sentence.Substring(3, 4);

            var result10 = sentence.ToLower(); /*  metinleri küçük harfe çevirir */
            var result11 = sentence.ToUpper(); /*  metinleri büyük harfe çevirir*/

            var result12 = sentence.Replace(" ", "-"); /* karakter değiştirmek için kullanılır*/
            var result13 = sentence.Remove(2, 5);

            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";

            Console.WriteLine(city[0]); //Stringler aslında char array i olduğundan ekrana ilk eleman olan A yı yazar.

            Console.WriteLine(" \n ################################ \n");

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" \n ################################ \n");

            string city2 = "İstanbul";

            Console.WriteLine(String.Format("{0} {1}", city, city2)); // İki tane string i yanyana getirir.
        }
    }
}
