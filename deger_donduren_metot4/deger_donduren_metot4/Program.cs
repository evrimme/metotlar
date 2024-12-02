using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deger_donduren_metot4
{
    internal class Program
    {
        static int Faktoriyel(int n)
        {
            int fak = 1;
            for(int i=1; i<=n; i++)
            {
                fak = fak * i;
            }
            return fak;
        }
        static void Main(string[] args)
        {
            // Girilen sayının faktöriyelini geri döndüren metotu yazınız.
            Console.Write("Sayı giriniz: ");
            int sayi=int.Parse(Console.ReadLine());

            int sonuc = Faktoriyel(sayi);
            Console.WriteLine("Sayının faktöriyeli = " + sonuc);

            Console.ReadKey();
        }
    }
}
