using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//'e04)
//'Upravte program pro Sportku (c03) tak, aby se tažená čísla nemohla opakovat.
//'Testujte na větším počtu tahů, aby se opakování projevilo. Ještě lépe se projeví, pokud budete testovat na hodech kostkou (1-6), také nemá padnout stejné číslo dvakrát.
//'Srovnejte s e2): tam se zjišuje, kolikrát které číslo padlo. A nyní se má zajistit, aby vícekrát nepadlo. Pokud padne, hod se opakuje.
//'Tento program je dost obtížný. Pokud zabere neúměrně hodně času, tak jej nechte až na druhou etapu přípravy, tedy po prvním vstupním testu.
namespace E {
    internal class E04_Sportka_bez_opakovani {
        public static void Mainx(string[] args) {
            const int maxPrvku = 5;
            int[] pole = new int[maxPrvku];
            int tah;
            Random rnd = new Random();

            pole[0] = rnd.Next(1, 50);
            Console.WriteLine("Průběh losování:\n" + pole[0]);

            for (int i = 1; i <= maxPrvku - 1; i++) {
                tah = rnd.Next(1, 50);
                Console.WriteLine(tah);
                for (int j = 0; j < i; j++) {
                    if (tah == pole[j]) {
                        tah = rnd.Next(1, 50);
                        Console.WriteLine("\topakovaný tah " + tah);
                    }
                }
                pole[i] = tah;
            }
            Console.WriteLine("\nZávěrečný stav: ");
            foreach (var item in pole) {
                Console.WriteLine(item);
            }
        }
    }
}