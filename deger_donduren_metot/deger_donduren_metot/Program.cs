using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deger_donduren_metot
{
    internal class Program
    {
        static int Topla3Sayi(int a,int b,int c)
        {
            int cevap = a + b + c;
            return cevap;
        }
        static void Main(string[] args)
        {
            int sayi1; int sayi2; int sayi3;
            //Konsoldan girilen 3 sayının toplamını geri döndüren metotu yazınız.       
            Console.Write("1. sayıyı giriniz: ");
            sayi1=int.Parse(Console.ReadLine());

            Console.Write("2. sayıyı giriniz: ");
            sayi2 = int.Parse(Console.ReadLine());

            Console.Write("3. sayıyı giriniz: ");
            sayi3 = int.Parse(Console.ReadLine());

            int sonuc = Topla3Sayi(sayi1,sayi2,sayi3);
            Console.WriteLine("Sonuç = "+sonuc);
            Console.ReadKey();
        }
    }
}
