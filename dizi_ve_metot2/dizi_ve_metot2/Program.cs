using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_ve_metot2
{
    internal class Program
    {
        static int PozitifeCevir(int sayi)
        {
            if (sayi < 0)
            {
                return (sayi * -1);
            }
            else
            {
                return sayi;
            }
        }
        static int[] diziyisirala(int[] yenidizi)
        {
            Array.Sort(yenidizi);
            return yenidizi;
        }
        static void diziyigoster(int[] sondizi)
        {
            foreach(int eleman in sondizi)
            {
                Console.Write(eleman);
                Console.Write(" ");
            }
        }
        static void Main(string[] args)
        {         
            int[] dizi = new int[10];           
            Random rnd = new Random();
            for(int i=0; i<10; i++)
            {            
                int sayi=rnd.Next(-100,101);
                dizi[i] = PozitifeCevir(sayi);
            }
            int[] yenidizi = diziyisirala(dizi);

            diziyigoster(yenidizi);

            Console.ReadKey();
        }
    }
}
