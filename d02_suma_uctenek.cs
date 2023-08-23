using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'d02)
//'Máte schované účtenky z různých nákupů, nevíte ale, kolik účtenek je.
//'Proto částky na účtenkách budete zadávat postupně, jako poslední zadáte nulu.
//'Program spočítá, kolik jste utratili a zároveň oznámí, kolik nákupů přesáhlo částku 100 Kč.
namespace D_ {
    internal class D02_suma_uctenek {
        public static void Mainx(string[] args) {
            int nadSto = 0, uctenka, suma = 0;

            Console.Write("Zadejte zaplacenou částku (Jako poslední zadejte nulu): ");
            uctenka = int.Parse(Console.ReadLine());
            if (uctenka > 100) {
                nadSto++;
            }
            while (uctenka != 0) {
                suma += uctenka;
                Console.Write("Zadejte zaplacenou částku (Jako poslední zadejte nulu): ");
                uctenka = int.Parse(Console.ReadLine());
                if (uctenka > 100) {
                    nadSto++;
                }
            }
            Console.WriteLine("Utratili jste {0},- Kč\nNákupů nad 100 Kč bylo: {1}", suma, nadSto);
        }
    }
}