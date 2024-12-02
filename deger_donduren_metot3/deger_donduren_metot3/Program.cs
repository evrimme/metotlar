using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deger_donduren_metot3
{
    internal class Program
    {
        static int UsAl(int a,int b)
        {
            int cevap=(int)Math.Pow(a,b);
            return cevap;
        }
        static void Main(string[] args)
        {
            // Girilen a sayısının b ninci dereceden kuvvetini geri döndüren metotu yazın.
            Console.Write("a sayısını giriniz: ");
            int a=int.Parse(Console.ReadLine());

            Console.Write("b sayısını giriniz: ");
            int b=int.Parse(Console.ReadLine());

            int sonuc = UsAl(a, b);
            Console.WriteLine("Sonuc = " + sonuc);

            Console.ReadKey();
        }
    }
}
