using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//'    Náročnější
//'    Složité programy Doc. Homoly
//'12) Sestavte funkci CisloDneVRoce, která má tři parametry: prvním je číslo dne, druhým číslo měsíce, třetím číslo roku včetně století.
//'Výsledkem volání funkce je pořadové číslo zadaného dne v daném roce (nebo -1, jestliže takové datum neexistuje).
//'Uvažujte i přestupné roky.
//'Funkci ověřte na zadání: sestavte program, který postupně načte den, měsíc a rok, a poté zobrazí, kolikátý den v roce To je.
//'Vyzkoušejte i pro den = 32 nebo pro měsíc = 13. Dále vyzkoušejte pro [31/12/1900] a pro [31/12/2000].
//'Pozor, Excel považuje chybně rok 1900 za přestupný.
//'Tento program je dost náročný, můžete si jej nechat na konec
namespace F1 {
    internal class F1_12_funkce_vrat_CisloDneVRoce {
        public static void Mainx(string[] args) {
            int den, mesic, rok, vystup = 0;

            Console.Write("Program postupně načte den, měsíc a rok, a poté zobrazí, kolikátý den v roce to je\n\nZadej den (dd): ");
            den = int.Parse(Console.ReadLine());
            Console.Write("Zadej mesic (mm): ");
            mesic = int.Parse(Console.ReadLine());
            Console.Write("Zadej rok(yyyy): ");
            rok = int.Parse(Console.ReadLine());
            Console.WriteLine("Vráceno funkcí: {0}", cisloDneF(den, mesic, rok));
            cisloDneS(den, mesic, rok, ref vystup);
            Console.WriteLine("Vráceno subrutinou: {0}", vystup);
        }

        static int cisloDneF(int dd, int mm, int yyyy) {
            int vystup = 0;

            if (mm > 12 || mm < 1) {
                vystup = -1;
            }
            else {
                switch (mm) {
                    case 1: vystup = 0; break;
                    case 2: vystup = 31; break;
                    case 3: vystup = 59; break;
                    case 4: vystup = 90; break;
                    case 5: vystup = 120; break;
                    case 6: vystup = 151; break;
                    case 7: vystup = 181; break;
                    case 8: vystup = 212; break;
                    case 9: vystup = 243; break;
                    case 10: vystup = 273; break;
                    case 11: vystup = 304; break;
                    case 12: vystup = 334; break;
                }
            }
            if (yyyy % 4 == 0 && yyyy % 100 != 0 || yyyy % 400 == 0) {
                if (mm >= 3) {
                    vystup++;
                }
            }
            if (vystup >= 0) {
                vystup += dd;
            }
            return vystup;
        }

        static void cisloDneS(int dd, int mm, int yyyy, ref int vysledek) {
            int vystup = 0;

            if (mm > 12 || mm < 1) {
                vystup = -1;
            }
            else {
                switch (mm) {
                    case 1: vystup = 0; break;
                    case 2: vystup = 31; break;
                    case 3: vystup = 59; break;
                    case 4: vystup = 90; break;
                    case 5: vystup = 120; break;
                    case 6: vystup = 151; break;
                    case 7: vystup = 181; break;
                    case 8: vystup = 212; break;
                    case 9: vystup = 243; break;
                    case 10: vystup = 273; break;
                    case 11: vystup = 304; break;
                    case 12: vystup = 334; break;
                }
            }
            if (yyyy % 4 == 0 && yyyy % 100 != 0 || yyyy % 400 == 0) {
                if (mm >= 3) {
                    vystup++;
                }
            }
            if (vystup >= 0) {
                vystup += dd;
            }
            vysledek = vystup;
        }
    }
}