using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deger_donduren_metot2
{
    internal class Program
    {
        static int KupAl(int n)
        {
            int cevap = n * n * n;
            return cevap;
        }
        static void Main(string[] args)
        {
            // Girilen sayının küpünü geri döndüren metotu yazınız.

            Console.Write("Sayı giriniz: ");
            int sayi=int.Parse(Console.ReadLine());

            int sonuc = KupAl(sayi);
            Console.WriteLine("Sonuç = " + sonuc);

            Console.ReadKey();
        }
    }
}
