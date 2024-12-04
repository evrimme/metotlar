using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayi_tahmin_oyunu
{
    internal class Program
    {
        static int TahminYap(int x,int y)
        {         
            if(x<y)
            {
                Console.WriteLine("Daha küçük bir tahmin yapınız...");                
                return 0;               
            }
            else if(x>y)
            {
                Console.WriteLine("Daha büyük bir tahmin yapınız...");               
                return 0;
            }           
            else 
            {
                Console.WriteLine("Tebrikler,tahmininiz doğru!");               
                return 1;
            }          
        }
        static void Main(string[] args)
        {
          /*1 ile 50 arasında kullanıcıdan sayı tahmin etmesini isteyen bir program yazalım.(metot kullanarak)
         Eğer kullanıcının girdiği tahmin,tutulan sayıdan büyükse ekrana "daha küçük bir tahmin yapınız"yazdıralım
         eğer kullanıcının girdiği tahmin,tutulan sayıdan küçükse o zaman ekrana "daha büyük bir tahmin yapınız"yazdıralım
         eğer kullanıcının tahmini ve tutulan sayı aynıysa,ekrana "Tebrikler,tahmininiz doğru!" yazdıralım. */

            Random rnd = new Random(); // rastgele bir sayı tutulması için Random sınıfından bir nesne tanımladık.
            int tutulan_sayi = rnd.Next(1,51); // tutulan sayının aralığı belirtildi.
            int tahmin;
            int tahminSayaci = 0;
            while (true)
            {
                Console.WriteLine("1 ile 50 arasındaki sayı tahmininizi giriniz. (Çıkmak için 0'a basın.)");
               
                if(!int.TryParse(Console.ReadLine(),out tahmin)) //harf girildiğinde ekrana yazdırılacak hata bildirisi için koşul yazıldı.
                {
                    Console.WriteLine("Geçerli bir sayı giriniz.");
                    continue;
                }
                if(tahmin==0) // girilen sayı 0 ise döngüden çıkış yapılacak.
                {
                    Console.WriteLine("Oyundan çıkıldı.Doğru sayı: " + tutulan_sayi);
                    break;
                }
                else if (tahmin < 0 || tahmin > 50) // kullanıcıdan,verilen aralıkta tahmin alma koşulu yazıldı.
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz.");                   
                    continue; // geçersiz tahmin durumunda döngünün geri kalanı atlanır.
                }
                tahminSayaci++;
                int sonuc = TahminYap(tutulan_sayi, tahmin);
                if(sonuc==1) // doğru tahmin yapıldığında döngü sonlanır.
                {
                    break; 
                }
            }          
            Console.WriteLine("{0}.tahmininizde doğru sayıyı buldunuz.",tahminSayaci);
            Console.ReadKey();
        }
    }
}
