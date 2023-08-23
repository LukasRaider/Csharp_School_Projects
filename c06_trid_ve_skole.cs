using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'c06)
//'Zadejte, kolik je tříd ve škole. Potom postupně zadávejte, kolik je v každé třídě žáků.
//'Program spočítá, kolik je žáků v celé škole a průměrný počet žáků ve třídě. (obdoba d1)
namespace C {
    internal class C06_trid_ve_skole {
        public static void Mainx(string[] args) {
            int pocetTrid, pocetZaku, suma = 0;

            Console.Write("Zadej počet tříd ve škole: ");
            pocetTrid = int.Parse(Console.ReadLine());

            for (int i = 1; i <= pocetTrid; ++i) {
                Console.Write("Zadej počet žáků " + i + ". třídy: ");
                pocetZaku = int.Parse(Console.ReadLine());
                suma = suma + pocetZaku;
            }
            Console.WriteLine("Do školy chodí celkem " + suma + " žáků.\nVe třídách je průměrně " + (suma / pocetTrid) + " žáků.");
        }
    }
}