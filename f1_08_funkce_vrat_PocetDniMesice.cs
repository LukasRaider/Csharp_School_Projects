using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'    Náročnější
//'Doporučuji do C# i Javy předělat i předchozí programy sekce f1.
//'8) Sestavte funkci PocetDniMesice, která má jako jediný parametr číslo měsíce. Výsledkem volání funkce je počet dní tohoto
//'měsíce (nebo -1, není-li hodnota měsíce správná). Přestupné roky pro únor neuvažujte. Funkci ověřte na zadání: sestavte
//'program, který načte číslo měsíce a poté zobrazí, kolik dní má tento měsíc. Vyzkoušejte i pro měsíc = 13. Návod: řešte
//'pomocí složené podmínky nebo konstrukcí Select Case. (program Doc. Homoly)
//'Pozor: Vstupy a výstupy budou v hlavním programu, předávat se budou přes parametry funkce či subrutiny. V hlavním
//'programu musí být použity jiné názvy proměnných než v subrutině či funkci.
namespace F1 {
    internal class F1_08_funkce_vrat_PocetDniMesice {
        public static void Mainx(string[] args) {
            byte cisloMesice;
            int vystup;

            Console.Write("Zadej číslo měsíce: ");
            cisloMesice = byte.Parse(Console.ReadLine());
            Console.WriteLine("Vráceno funkci: Zadaný měsíc má {0} dnů", PocetDniMesiceF(cisloMesice));
            PocetDniMesiceS(cisloMesice, out vystup);
            Console.WriteLine("Vráceno subrutinou: Zadaný měsíc má {0} dnů", vystup);
        }

        static int PocetDniMesiceF(byte x) {
            switch (x) {
                case 1: return 31; break;
                case 2: return 28; break;
                case 3: return 31; break;
                case 4: return 30; break;
                case 5: return 31; break;
                case 6: return 30; break;
                case 7: return 31; break;
                case 8: return 31; break;
                case 9: return 30; break;
                case 10: return 31; break;
                case 11: return 30; break;
                case 12: return 31; break;
                default: return -1; break;
            }
        }

        static void PocetDniMesiceS(byte x, out int vysledek) {

            if (x < 1) {
                vysledek = -1;
            }
            else if (x == 1) {
                vysledek = 31;
            }
            else if (x == 2) {
                vysledek = 28;
            }
            else if (x == 3) {
                vysledek = 31;
            }
            else if (x == 4) {
                vysledek = 30;
            }
            else if (x == 5) {
                vysledek = 31;
            }
            else if (x == 6) {
                vysledek = 30;
            }
            else if (x == 7) {
                vysledek = 31;
            }
            else if (x == 8) {
                vysledek = 31;
            }
            else if (x == 9) {
                vysledek = 30;
            }
            else if (x == 10) {
                vysledek = 31;
            }
            else if (x == 11) {
                vysledek = 30;
            }
            else if (x == 12) {
                vysledek = 31;
            }
            else {
                vysledek = -1;
            }
        }
    }
}
