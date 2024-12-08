using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace not_sonucu_donduren_metot
{
    internal class Program
    {
        static char NotKontrol(int vize,int v_yuzde,int final,int f_yuzde)
        {
            int ortalama = (vize * v_yuzde) / 100 + (final * f_yuzde) / 100;   
            
            if(ortalama>=85)
            {
                return 'A';
            }
            if(85>ortalama && ortalama>=70)
            {
                return 'B';
            }
            if(70>ortalama && ortalama>=55)
            {
                return 'C';
            }
            if(55>ortalama && ortalama>=45)
            {
                return 'D';
            }
            if(45>ortalama)
            {
                return 'F';
            }
                return 'X'; // buraya ulaşılmaz ama derleyicinin hata vermemesi için her ihtimale karşı bir değer döndürmek gerekebilir.
        }
        static void Main(string[] args)
        {
            Console.Write("Vize notunuzu giriniz: ");
            int vize=int.Parse(Console.ReadLine());
            Console.Write("Yüzde kaç etkilediğini giriniz: ");
            int v_yuzde=int.Parse(Console.ReadLine());
            Console.Write("Final notunuzu giriniz: ");
            int final=int.Parse(Console.ReadLine());
            Console.Write("Yüzde kaç etkilediğini giriniz: ");
            int f_yuzde = int.Parse(Console.ReadLine());
          
            char sonuc = NotKontrol(vize, v_yuzde, final, f_yuzde);
            Console.WriteLine("Sonuç = "+sonuc);

            Console.ReadKey();
        }
    }
}
