using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'    Select Case
//'17) Zadejte částku v Kč a pak si z nabídky vyberte měnu, na kterou chcete směnit (např. DEM, USD, FRF atd.).
//'Počítač přepočítá částku na tuto měnu.
namespace B {
    internal class B17_smenarna_valut {
        public static void Mainx(string[] args) {
            double castka;
            int mena;

            Console.Write("Smenarna Kc na valuty \nZadejte částku v Kč, kterou chcete smenit: ");
            castka = double.Parse(Console.ReadLine());
            Console.Write("Měny na které lze Kč směnit.\n1 - USD\n2 - GBP\n3 - EUR\n4 - PLN\n5 - CHF\n6 - JPY\n7 - CNY\nZvol měnu: ");
            mena = int.Parse(Console.ReadLine());

            if ((VratValuty(castka, mena) == -1)) {
                Console.WriteLine("Možnost neni k dispozici");
            }
            else {
                Console.WriteLine(VratValuty(castka, mena));
            }
        }
        static double VratValuty(double hotovost, int mena) {
            switch (mena) {
                case 1: return Math.Round(hotovost / 22.5, 2); break; //" USD, Amerických dolaru"
                case 2: return Math.Round(hotovost / 27.4, 2); break; //" GBP, Britskych liber"
                case 3: return Math.Round(hotovost / 23.9, 2); break; //" Eur"
                case 4: return Math.Round(hotovost / 5.1, 2); break;  //" PLN, Polských zlotých"
                case 5: return Math.Round(hotovost / 24.3, 2); break; //" CHF, Švýcarských franku"
                case 6: return Math.Round(hotovost * 100 / 17, 2); break; //" JPY, Japonských jenu"     '100 jenu za 17 Kc
                case 7: return Math.Round(hotovost / 3.3, 2); break; //" CNY, Čínských juanu"
                default: return -1;
            }
        }
    }
}
