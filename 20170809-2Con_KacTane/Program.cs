using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170809_2Con_KacTane
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  10 isim girdirip, seçilen ismin kaç kere geçtiğini bulan uygulamayı yazınız.
             */

            string aranacak;
            int sayac = 0;

            string[] isimler = new string[10];

            //Lenght dizinin uzunluğunu verir. kaç eleman alacağını öğrenebiliriz.
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Write((i+1)+". İsmi giriniz : ");
                isimler[i] = Console.ReadLine();
            }

            Console.WriteLine("--------------------------------------------------");
            Console.Write("Aranacak ismi giriniz : ");
            aranacak = Console.ReadLine();

            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i] == aranacak)
                {
                    sayac++;
                }
            }

            Console.WriteLine("{0} ismi girilen elemanlar içerisinde {1} adet vardır.",aranacak,sayac);
            Console.Read();

        }
    }
}
