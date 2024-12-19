using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dort_islem_metot
{
    internal class Program
    {
        static void DortIslem(int sayi1, int sayi2, char secim) //değer döndürmeyen sadece işlem yapan bir metot oluşturduk.
            {
              switch(secim)
             {
                case '+':
                    Console.WriteLine("Toplam = "+ (sayi1+sayi2));
                    break;
                case '-':
                    Console.WriteLine("Fark = "+ (Math.Abs(sayi1-sayi2)));
                    break;
                case '*':
                    Console.WriteLine("Çarpım = " + (sayi1 * sayi2));
                    break;
                case '/':
                    if(sayi2!=0)
                    {
                    Console.WriteLine("Bölüm = " + (sayi1 / sayi2));
                    }
                    else
                    {
                    Console.WriteLine("Bölme işlemi için ikinci sayı sıfır olamaz."); // 0'a bölme hatasının önüne geçmek için
                                                                                      // böyle bir koşul oluşturduk.
                    }
                    break;
                default:
                    Console.WriteLine("Geçerli bir değer giriniz.");
                    break;
             }          
            }
        static void Main(string[] args)
        {
            /*Kullanıcının girdiği iki sayı üzerinden 
            menüden yapılan seçime göre 4 işlem uygulayan 
            programı metot kullanarak yazınız*/

            Console.Write("Bir sayı giriniz: ");
            int sayi1=int.Parse(Console.ReadLine());

            Console.Write("Bir sayı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("İşlem seçiniz.(Toplama '+' , Çıkarma '-' , Çarpma '*' , Bölme '/') ");
            char secim = Convert.ToChar(Console.ReadLine());

            DortIslem(sayi1, sayi2, secim); //metodu çağırdık
            
            Console.ReadKey();
        }
    }
}
