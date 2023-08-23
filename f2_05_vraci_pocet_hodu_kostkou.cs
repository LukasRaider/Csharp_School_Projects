using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'f2_5: Sestavte funkci PocetPadlych, která kromě předaného pole má i parametr, kolikrát se kostkou hodilo.
//'Výsledkem funkce je jednorozměrné celočíselné pole udávající, kolikrát padla ta která hodnota na kostce.
//'Funkci ověřte na zadání: sestavte program, který se zeptá na počet hodù, a pak zobrazí, kolikrát každé číslo padlo.
//'povšimněte si, že čím více hodù, tím více se počty vyrovnají   (podobné e9, ale zde je to s použitím funkce)
namespace F2 {
    internal class F2_05_vraci_pocet_hodu_kostkou {
        public static void Mainx(string[] args) {
            const int maxPrvku = 100;
            int[] hody = new int[maxPrvku], vysledekF, vysledekS = new int[maxPrvku];
            int pocetHodu;
            Random rnd = new Random();

            Console.WriteLine("Výsledkem funkce je jednorozměrné celočíselné pole udávající, kolikrát padla ta která hodnota na kostce.\n\n");

            Console.Write("Zadej pocet hodu: ");
            pocetHodu = int.Parse(Console.ReadLine());
            for (int i = 0; i < pocetHodu; i++) {
                hody[i] = rnd.Next(1, 7);
            }
            Array.Resize(ref hody, pocetHodu); //pole se timto zmensi pouze na pole s hodnotami

            vysledekF = cetnostiF(hody, pocetHodu);
            Console.WriteLine("Výsledek vrácený funkcí: ");
            for (int i = 0; i < vysledekF.Length; i++) {
                Console.WriteLine(" {0} padla {1}x", i + 1, vysledekF[i]);
            }
            cetnostiS(hody, pocetHodu, ref vysledekS);
            Console.WriteLine("Výsledek vrácený subrutinou: ");
            for (int i = 0; i < vysledekS.Length; i++) {
                Console.WriteLine(" {0} padla {1}x", i + 1, vysledekS[i]);
            }
        }

        static int[] cetnostiF(int[] cetnosti, int pocet) {
            int[] poleVystup = new int[6];

            int hod;
            for (int i = 0; i < pocet; i++) {
                hod = cetnosti[i];
                poleVystup[hod - 1]++;
            }
            return poleVystup;
        }

        static void cetnostiS(int[] cetnosti, int pocet, ref int[] vysledek) {
            int[] poleVystup = new int[6];

            int hod;
            for (int i = 0; i < pocet; i++) {
                hod = cetnosti[i];
                poleVystup[hod - 1]++;
            }
            vysledek = poleVystup;
        }
    }
}
