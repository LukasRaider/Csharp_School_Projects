using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'f05)
//'Sestavte funkci Kurs, která má dva parametry: prvním je číslo ve významu korun, druhým je tříznakový řetězec ve významu kódu měny (“EUR“, “USD“, “GBP“), na kterou se tyto koruny mají vyměnit.
//'Výsledkem volání funkce je částka v dané měně, rovnající se danému počtu korun (nebo hodnota -1, jestliže jde o měnu, pro kterou není kurs znám).
//'Kurz bude ve funkci zadán „natvrdo“, např. 27,35 pro euro. Tedy volat se tedy měla např. takto
//'MsgBox kurs(273.5, "EUR")
//'Vypsat by měla 10. Tedy že 255,3 Kč je 10 Euro.
//'(program Doc. Homoly)
namespace F1 {
    internal class F1_05_funkce_Kurz {
        public static void Mainx(string[] args) {
            double kc, vystup;
            string mena;

            Console.Write("Směnárna\n\nZadej počet Kč, které chcete převést na cizí měnu: ");
            kc = double.Parse(Console.ReadLine());
            Console.Write("Zadejte měnu na kterou chcete Kč převést. (EUR, USD, GBP): ");
            mena = (Console.ReadLine());
            KursS(kc, mena, out vystup);
            if (KursF(kc, mena) == -1) {
                Console.WriteLine("Funkce.Neznámá měna, převod není možný");
            }
            else {
                Console.WriteLine("Funkce.Za {0},- Kč dostanete {1} {2}", kc, vystup, mena);
            }
            if (vystup == -1) {
                Console.WriteLine("Subrutina.Neznámá měna, převod není možný");

            }
            else {
                Console.WriteLine("Subrutina.Za {0},- Kč dostanete {1} {2}", kc, vystup, mena);

            }
        }

        static double KursF(double castka, string valuty) {

            if (valuty == "EUR" || valuty == "eur") {
                return Math.Round(castka / 23.73, 2);
            }
            else if (valuty == "USD" || valuty == "usd") {
                return Math.Round(castka / 22.25, 2);
            }
            else if (valuty == "GBP" || valuty == "gbp") {
                return Math.Round(castka / 26.88, 2);
            }
            else {
                return -1;
            }
        }
        static void KursS(double castka, string valuty, out double vysledek) {

            if (valuty == "EUR" || valuty == "eur") {
                vysledek = Math.Round(castka / 23.73, 2);
            }
            else if (valuty == "USD" || valuty == "usd") {
                vysledek = Math.Round(castka / 22.25, 2);
            }
            else if (valuty == "GBP" || valuty == "gbp") {
                vysledek = Math.Round(castka / 26.88, 2);
            }
            else {
                vysledek = -1;
            }
        }
    }
}