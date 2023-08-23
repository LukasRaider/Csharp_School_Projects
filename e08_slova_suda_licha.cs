using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'e08)
//'Řadu slov z předchozího příkladu vypište v obráceném pořadí, a pak vypíše pouze sudá a pak pouze lichá slova.
//'A předělejte příklady c) a d) na pole. Tedy nezpracovávejte je v první smyčce, ale až v druhé.
namespace E {
    internal class E08_slova_suda_licha {
        public static void Mainx(string[] args) {
            const int maxPrvku = 100;
            string[] poleSlov = new string[maxPrvku];
            string retLicha = "";
            int iMax = 0, i = 0;

            do {
                Console.Write("Zadejte několik různých slov (ENTER ukončí zadávání): ");
                poleSlov[i] = Console.ReadLine();
                i++;
            } while (poleSlov[i - 1] != "");
            iMax = i - 1;
            Console.Write("Výpis slov v obráceném pořadí:");
            for (int j = iMax; j >= 0; j--) {
                Console.WriteLine(poleSlov[j]);
            }
            Console.WriteLine("Sudá:");
            for (int j = 0; j < iMax; j++) {
                if (j % 2 == 0) {
                    retLicha += poleSlov[j] + "\n";
                }
                else {
                    Console.WriteLine(poleSlov[j]);
                }
            }
            Console.Write("Licha:\n" + retLicha);
        }
    }
}
