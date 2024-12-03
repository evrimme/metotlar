using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deger_donduren_metot_6
{
    internal class Program
    {
        static int ToplaNsayi(int n,int y)
        {
            int toplam = 0;
            for(int i=1; i<=n; i++)
            {
                if(i%y==0)
                {
                    toplam = toplam + i;
                }
            }
            return toplam;
        }
        static void Main(string[] args)
        {
            /* 1'den n'e kadar y'ye bölünebilen sayıların toplamını yazan metotu yazınız.*/

            Console.Write("Sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            Console.Write("Bölen sayıyı giriniz: ");
            int bolen = int.Parse(Console.ReadLine());

            int sonuc = ToplaNsayi(sayi, bolen);
            Console.WriteLine("Toplam = "+sonuc);

            Console.ReadKey();
        }
    }
}
