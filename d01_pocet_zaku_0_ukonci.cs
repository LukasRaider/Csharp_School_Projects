using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
//'d01)
//'Zadejte postupně, kolik je v každé třídě žákù (0=konec). Program spočítá, kolik je žákù v celé škole a prùměrný počet žákù ve třídě.
//'Ověřte, že nula do platných dat nepatří.
//'Nesmí se tedy stát, že při zadání 30 a 0 (tedy jen jedna třída a to s 30 žáky) vyjde prùměrný počet žákù 15 (omylem se uvažovaly dvě třídy, jedna má 30 a druhá 0 žákù)
namespace D_ {
    internal class D01_pocet_zaku_0_ukonci {
        public static void Mainx(string[] args) {
            const int maxPrvku = 100;
            int[] polePocetZaku = new int[maxPrvku];
            int iMax, i = 0, suma = 0;

            Console.Write("Zadej počet žáků {0}. třídy: ", i + 1);
            polePocetZaku[i] = int.Parse(Console.ReadLine());
            i++;
            do {
                Console.Write("Zadej počet žáků {0}. třídy: ", i + 1);
                polePocetZaku[i] = int.Parse(Console.ReadLine());
                i++;
            } while (polePocetZaku[i - 1] != 0);
            iMax = i - 1;
            for (int j = 0; j <= iMax; ++j) {
                suma = suma + polePocetZaku[j];
            }
            Console.WriteLine("Do školy chodí celkem {0} žáků.\nVe {1} třídách je průměrně {2} žáků.", suma, iMax, (double)suma / iMax);
        }
    }
}
