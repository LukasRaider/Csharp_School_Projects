using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'    Náročnější
//'    Složité programy Doc. Homoly
//'11) Sestavte funkci Vyskyty se dvěma parametry - textovými řetězci. Druhý parametr je subřetězec, případně jen jednoznakový řetězec.
//'Výsledkem volání funkce je počet opakování druhého parametru v parametru prvním.
//'Funkci ověřte na zadání: sestavte program, který načte textový řetězec a zobrazí například počet písmen "A" v tomto řetězci.
namespace F1 {
    internal class F1_11_funkce_vrat_Vyskyt {
        public static void Mainx(string[] args) {
            string retText;
            char hledanyZnak;
            int vystup = 0;

            Console.Write("Počet opakování znaku v textu\n\nZadej Text: ");
            retText = Console.ReadLine();
            Console.WriteLine("Zadej hledaný znak: ");
            hledanyZnak = char.Parse(Console.ReadLine());
            Console.WriteLine("Funkce.Znak '{0}' se v řetězci '{1}' vyskytuje {2} krát.", hledanyZnak, retText, vyskytZnakuF(retText, hledanyZnak));
            vyskytZnakuS(retText, hledanyZnak, ref vystup);
            Console.WriteLine("Subrutina.Znak '{0}' se v řetězci '{1}' vyskytuje {2} krát.", hledanyZnak, retText, vystup);
        }

        static int vyskytZnakuF(string text, char znak) {
            int pocitadlo = 0;

            for (int i = 0; i < text.Length; i++) {
                if (znak == text[i]) {
                    pocitadlo++;
                }
            }
            return pocitadlo;
        }

        static void vyskytZnakuS(string text, char znak, ref int vysledek) {
            int pocitadlo = 0;

            for (int i = 0; i < text.Length; i++) {
                if (znak == text[i]) {
                    pocitadlo++;
                }
            }
            vysledek = pocitadlo;
        }
    }
}