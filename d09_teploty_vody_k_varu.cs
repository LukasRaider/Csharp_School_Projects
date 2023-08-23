using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'d09)
//'Uživatel bude zadávat postupně teploty vody s přesností na desetinu stupně.
//'Zadávání ukončí zadáním teploty přesahující 100° (tato teplota je ale také součástí dat!).
//'Zadávání končí, protože pak už voda vyvřela. Program zobrazí zadané teploty, minimální teplotu a kolikátá v pořadí tato teplota byla.
//'A také prěměr teplot
namespace D_ {
    internal class D09_teploty_vody_k_varu {
        public static void Mainx(string[] args) {
            const int maxPrvku = 100;
            double[] poleTeplot = new double[maxPrvku];
            double teplota, suma = 0, min, poradiMinima = 0;
            int i = 0;

            Console.WriteLine("Zadávej postupně teplotu vody (C°) s přesností na desetinu.\nZadávání ukončí zadáním teploty přesahující 100°. Voda vyvařila!\n\n");

            Console.Write("Zadejte teplotu: ");
            teplota = double.Parse(Console.ReadLine());
            poleTeplot[i] = teplota;
            min = teplota;
            poradiMinima++;
            i++;
            while (teplota <= 100) {
                Console.Write("Zadejte teplotu: ");
                teplota = double.Parse(Console.ReadLine());
                poleTeplot[i] = teplota;
                i++;
            }
            Console.WriteLine("Výpis teplot: ");
            for (int j = 0; j < i; j++) {
                Console.Write(poleTeplot[j] + "°C ");
                suma += poleTeplot[j];
                if (poleTeplot[j] < min) {
                    min = poleTeplot[j];
                    poradiMinima++;
                }
            }
            Console.WriteLine("\nMinimalni teplota: {0}°C\nPořadí zadání minimální teploty: {1}\nPrůměrá teplota: {2}°C", min, poradiMinima, Math.Round((suma / i), 2));
        }
    }
}

