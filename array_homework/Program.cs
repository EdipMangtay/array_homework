using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************");
            string[] name = { "E", "D", "İ", "P" };

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }



            Console.WriteLine("*****************");
            Console.WriteLine("Üçgen yapımı");
            for (int i = 1; i <= 10; i++) // yukarıdan aşağıya tek tek 10 satır ataması için 
            {
                for (int j = 0; j < i; j++) // soldan sağa yıldızları teker teker arttırarak yazdırdığı kısım 

                // ikinci for'u iptal edersek alt alta 10 adet yıldız yazdırır ama ilk for satırını iptal edersek program çalışmaz
                {
                    Console.Write("*"); // bu kısımda Write olması bizim için yıldızları yan yana yazdırması anlamını taşır
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            
            Console.Write("Kaç adet ürün gireceksiniz? ");
            int urunSayisi = Convert.ToInt32(Console.ReadLine());

            string[] urunler = new string[urunSayisi]; // decimal ve stringlerin içeriisndeki değerin aynı olma sebebi ikisi de array uzunluğu için ullanılıyor 

            decimal[] fiyatlar = new decimal[urunSayisi];

            for (int i = 0; i < urunSayisi; i++)
            {
                Console.Write($"Ürün {i + 1} adı: ");
                urunler[i] = Console.ReadLine();

                Console.Write($"Ürün {i + 1} fiyatı: ");
                fiyatlar[i] = Convert.ToDecimal(Console.ReadLine());
            }

            Console.WriteLine("Ürünler ve Fiyatları:");

            for (int i = 0; i < urunSayisi; i++)
            {
                Console.WriteLine($"{urunler[i]} - {fiyatlar[i]}");
            }
            Console.WriteLine("*****************");
            Console.ReadLine();





        }
    }
}
