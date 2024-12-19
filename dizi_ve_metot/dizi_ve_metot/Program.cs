using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_ve_metot
{
    internal class Program
    {
        static bool ElemanVarMi(int[]dizi,int aranan)
        {
            foreach(int eleman in dizi)
            {
                if(eleman == aranan)
                {
                    return true;
                }               
            }
            return false;
        }
        static void Tekrar(int[]dizi,int aranan)
        {
            int sayac = 0;
            foreach(int eleman in dizi)
            {
                if(eleman==aranan)
                {
                    sayac++; // aranan sayıya,dizide kaç kere rastlanırsa sayac o kadar artacak.        
                }             
            }  
            if(sayac>0) // sayac 0'dan büyükse dizide o eleman vardır ve kaç kere bulunduğunu ekrana yazdırıyoruz.
            {
                Console.WriteLine("Aranan sayıdan dizide {0} tane vardır.", sayac);
            }
        }
        static void Main(string[] args)
        {
            /* Kullanıcının oluşturduğu 10 boyutlu bir dizi 
             içinden yine kullanıcının girmiş olduğu bir sayının 
             olup olmadığını geriye değer döndüren metotla ve 
             tekrar sayısını ekrana metot içinde yazdıracak 
             programı yazınız. */

            int[] dizi = new int[10]; // dizi oluşturuldu.

            for(int i=0; i<10; i++) // kullanıcıdan değer almak için döngü oluşturuldu.
            {
                Console.Write("Dizinin {0}. elemanını giriniz: ",i+1);
                int sayi=int.Parse(Console.ReadLine());
                dizi[i]= sayi; // kullanıcıdan alınan sayı diziye atıldı.
            }
            Console.Write("Aranacak sayıyı giriniz: ");
            int aranacak_sayi = int.Parse(Console.ReadLine());

            bool cevap= ElemanVarMi(dizi,aranacak_sayi); // metotta dönen değeri cevap değişkenine atadık.

            if(cevap==true) 
            {
                Console.WriteLine("Aranan sayı dizide var.");

            }
            else
            {
                Console.WriteLine("Aranan sayı dizide yok.");
            }
            Tekrar(dizi,aranacak_sayi); // değer döndürmeyen metotumuzu çağırıp gereken sonucu ekrana yazdırdık.

            Console.ReadKey();
        }
    }
}
