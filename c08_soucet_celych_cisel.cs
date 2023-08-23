using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'c08)
//'Zadej celé kladné číslo a pak program vypíše součet celých čísel od jedné do udaného čísla
namespace C {
    internal class C08_soucet_celych_cisel {
        public static void Mainx(string[] args) {
            int maxCislo, suma = 0;

            Console.Write("Program vypíše součet celých čísel od jedné do udaného čísla.\n\nZadej číslo: ");
            maxCislo = int.Parse(Console.ReadLine());

            for (int i = 1; i <= maxCislo; i++) {
                suma = suma + i;
            }
            Console.WriteLine("Soucet cisel: " + suma);
        }
    }
}
