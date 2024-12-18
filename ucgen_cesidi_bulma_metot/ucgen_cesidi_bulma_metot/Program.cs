using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucgen_cesidi_bulma_metot
{
    internal class Program
    {
        static string Ucgencesidi(int kenar1, int kenar2, int kenar3)
        {
            string cevap;

            if ((Math.Abs(kenar1 - kenar2) < kenar3 && kenar3 < kenar1 + kenar2) ||
                (Math.Abs(kenar1 - kenar3) < kenar2 && kenar2 < kenar1 + kenar3) ||
                (Math.Abs(kenar2 - kenar3) < kenar1 && kenar1 < kenar2 + kenar3))
            {
                if ((kenar1 == kenar2 && kenar1 != kenar3) || 
                    (kenar1 == kenar3 && kenar1 != kenar2) || 
                    (kenar2 == kenar3 && kenar2 != kenar1))
                {
                    cevap = "İkizkenar üçgen";
                    return cevap;
                }
                else if (kenar1 == kenar2 && kenar1 == kenar3)
                {
                    cevap = "Eşkenar üçgen";
                    return cevap;
                }
                else
                {
                    cevap = "Çeşitkenar üçgen";
                    return cevap;
                }
            }
            else
            {
                cevap = "Bu değerlerle üçgen oluşturamazsınız.";
                return cevap;
            }
        }
        static void Main(string[] args)
        {
            /*Üç kenar uzunluğu girilen üçgenin çeşidini 
            bulan programı geriye dönük metot kullanarak 
            yazınız.  */

            Console.Write("Birinci kenar uzunluğunu giriniz: ");
            int kenar1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci kenar uzunluğu giriniz: ");
            int kenar2 = int.Parse(Console.ReadLine());

            Console.Write("Üçüncü kenar uzunluğu giriniz: ");
            int kenar3 = int.Parse(Console.ReadLine());

            string sonuc = Ucgencesidi(kenar1, kenar2, kenar3);

            Console.WriteLine("\n" + sonuc);

            Console.ReadKey();
        }
    }
}
