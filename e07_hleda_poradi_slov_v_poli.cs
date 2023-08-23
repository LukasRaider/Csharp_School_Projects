using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
//'e07)
//'Zadejte postupně do pole několik různých slov. Každé slovo přitom budete zadávat zvlášť.
//'Poté znovu zadejte jedno z těchto slov. Program vypíše číslo pořadí, v jakém bylo toto slovo zadáno (na jaké pozici se vyskytuje v poli).
namespace E {
    internal class E07_hleda_poradi_slov_v_poli {
        public static void Mainx(string[] args) {
            const int maxPrvku = 100;
            string[] poleSlov = new string[maxPrvku];
            string slovo;
            int poradi = -1, iMax = 0, i = 0;

            do {
                Console.Write("Zadejte několik různých slov (ENTER ukončí zadávání): ");
                poleSlov[i] = Console.ReadLine();
                i++;
            } while (poleSlov[i - 1] != "");
            iMax = i;
            Console.Write("Zadej znovu jedno ze zadaných slov: ");
            slovo = Console.ReadLine();
            for (int j = 0; j < iMax; j++) {
                if (slovo == poleSlov[j]) {
                    poradi = j + 1;
                }
            }
            if (poradi > 0) {
                Console.WriteLine("Slovo {0} bylo zadáno v pořadí jako {1}", slovo, poradi);
            }
            else {
                Console.WriteLine("Zadané slovo v sadě není");
            }

        }
    }
}

