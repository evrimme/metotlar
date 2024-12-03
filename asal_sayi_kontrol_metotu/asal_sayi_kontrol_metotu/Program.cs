using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asal_sayi_kontrol_metotu
{
    internal class Program
    {
        static bool AsalMi(int a)
        {
           if(a<=0) // 0 ya da negatif sayı girilirse sayı asal olmadığından false döndürüyoruz.
            {
                return false;
            }
            for(int i=2; i<a; i++) // asal sayı kontrolü için döngü açıldı.
            {
                if(a%i==0) // eğer girilen sayı i'ye bölünürse asal sayı değildir bundan dolayı false döndürüldü.
                {
                    return false;
                }             
            }
            return true; //döngüde bölen bulunmazsa sayı asal sayı demektir ve true döndürülür.
        }
        static void Main(string[] args)
        {
            /* Girilen sayının asal sayı olup olmadığına bakıp asal ise true,değilse false geri döndüren metotu
             yazınız */
            
            Console.Write("Sayı giriniz: "); // kullanıcıdan sayı alındı.
            int sayi = int.Parse(Console.ReadLine());

            bool sonuc=AsalMi(sayi); // metot sonucunu değişkene atıyoruz.
            Console.WriteLine("Sonuç = " + sonuc); // sonucu ekrana yazdırıyoruz.

            Console.ReadKey();
        }
    }
}
