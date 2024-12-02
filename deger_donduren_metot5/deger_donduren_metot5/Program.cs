using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deger_donduren_metot5
{
    internal class Program
    {
        static int Topla(int n)
        {
            int toplam = 0;
            for(int i=0; i<=n; i++)
            {
                toplam = toplam + i;
            }
            return toplam;
        }
        static void Main(string[] args)
        {
            // 1'den klavyeden girilen sayıya kadar olan sayıların toplamını geri döndüren metotu yazınız.
            Console.Write("Sayı giriniz: ");
            int n=int.Parse(Console.ReadLine());

            int sonuc = Topla(n);
            Console.WriteLine(sonuc);

            Console.ReadKey();

        }
    }
}
