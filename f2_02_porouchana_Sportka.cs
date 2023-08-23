using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'2) Stroj na losování Sazky se porouchal. Tahal sice z osudí čísla 1 až 49, ale některá opakovaně.
//'Vytvořte funkci, které se předá pole takovýchto čísel, funkce pole vrátí očištěné od druhých a dalších výskytů opakujících se čísel.
//'Nevadí, že tedy může být ve výsledku méně čísel než požadovaných pět.
namespace F2 {
    internal class F2_02_porouchana_Sportka {
        public static void Mainx(string[] args) {
            int[] poleSportka = new int[5];
            int[] novePoleSportkaS, novePoleSportkaF;
            Random rnd = new Random();
            string ret = "", retNovyS = "", retNovyF = "";

            Console.WriteLine("Porouchaná Sportka\n\n");
            for (int i = 0; i < 5; i++) {
                poleSportka[i] = rnd.Next(1, 7); //pro testovani hazim kostkou
                ret += poleSportka[i] + " ";
            }
            vratOpravenouSportkuS(poleSportka, out novePoleSportkaS);
            for (int i = 0; i < novePoleSportkaS.Length; i++) {
                retNovyS += novePoleSportkaS[i] + " ";
            }

            novePoleSportkaF = vratOpravenouSportkuF(poleSportka);
            for (int i = 0; i < novePoleSportkaF.Length; i++) {
                retNovyF += novePoleSportkaF[i] + " ";
            }
             Console.WriteLine("Původní čísla: " + ret + "\nVráceno funkcí: " + retNovyF);
           Console.WriteLine("Vráceno subrutinou: " + retNovyS);
        }

        static int[] vratOpravenouSportkuF(int[] pole) {
            int[] poleNove = new int[0];
            int n = 0, hledane;
            bool opakujese;

            for (int i = 0; i < 5; i++) {
                hledane = pole[i];
                opakujese = false;  //inicializace
                for (int j = (i + 1); j < 5; j++) {
                    if (hledane != pole[j]) {
                        opakujese = false;
                    }
                    else {
                        opakujese = true;
                        break;
                    }
                }
                if (opakujese == false) {
                    Array.Resize(ref poleNove, n + 1);
                    poleNove[n] = pole[i];
                    n++;
                }
            }
            return poleNove;
        }

        static void vratOpravenouSportkuS(int[] pole, out int[] vysledek) {
            int[] poleNove = new int[0];
            int n = 0, hledane;
            bool opakujese;

            for (int i = 0; i < 5; i++) {
                hledane = pole[i];
                opakujese = false;  //inicializace
                for (int j = (i + 1); j < 5; j++) {
                    if (hledane != pole[j]) {
                        opakujese = false;
                    }
                    else {
                        opakujese = true;
                        break;
                    }
                }
                if (opakujese == false) {
                    Array.Resize(ref poleNove, n + 1);
                    poleNove[n] = pole[i];
                    n++;
                }
            }
            vysledek = poleNove;
        }
    }
}
