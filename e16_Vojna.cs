using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'    Náročnější
//'16) Simulace karetní hry Vojna pro dva hráče a 32 karet (čtyři barvy s hodnotami 7 až 14, tedy 7,8,9,10, spodek, svršek, král, eso).
//'Na začátku oba hráči dostanou náhodně šestnáct karet. Na monitoru se zobrazí šestnáct vyložení obou hráčů
//'s informací, kdo dané vyložení vyhrál. Na konci vyhrává ten, který vyhrál nejvíce vyložení. V jednodušší variantě se neřeší
//'vyložení stejných hodnot. V dokonalejší variantě se vykládá ještě jednou, vítěz si pak připíše dvě vítězství.
//'(Dost náročný, řešit až jako poslední program tohoto souboru.)
namespace E {
    internal class E16_Vojna {
        public static void Mainx(string[] args) {
            const int maxPrvku = 32;
            int[] poleKaret = new int[maxPrvku];
            int bodyHrac1 = 0, bodyHrac2 = 0, pocitadlo, nah;
            Random rnd = new Random();

            for (int i = 7; i <= 14; i++) {
                pocitadlo = 0;
                for (int j = 0; pocitadlo < 4; j++) {
                    nah = rnd.Next(0, 32);
                    if (poleKaret[nah] == 0) {
                        poleKaret[nah] = i;
                        pocitadlo++;
                    }
                }
            }
            Console.WriteLine("Karetní hra Vojna\n\nVyložení\tVítěz");
            for (int i = 0; i < maxPrvku - 1; i += 2) {
                if (poleKaret[i] > poleKaret[i + 1]) {
                    bodyHrac1++;
                    Console.WriteLine("{0}>{1}\t\thráče č.1", poleKaret[i], poleKaret[i + 1]);
                }
                else if (poleKaret[i] == poleKaret[i + 1]) {
                    Console.WriteLine("{0}={1}\t\tplichta", poleKaret[i], poleKaret[i + 1]);
                }
                else {
                    bodyHrac2++;
                    Console.WriteLine("{0}<{1}\t\thráče č.2", poleKaret[i], poleKaret[i + 1]);
                }
            }
            if (bodyHrac1 > bodyHrac2) {
                Console.WriteLine("\nýtěz je Hráč č.1, který získal " + bodyHrac1 + " vyložení.\nHráč č.2 získal " + bodyHrac2 + " vyložení.");
            }
            else if (bodyHrac2 == bodyHrac1) {
                Console.WriteLine("\nRemíza xD");
            }
            else {
                Console.WriteLine("\nVýtěz je Hráč č.2, který získal " + bodyHrac2 + " vyložení.\nHráč č.1 získal " + bodyHrac1 + " vyložení.");
            }
        }
    }
}