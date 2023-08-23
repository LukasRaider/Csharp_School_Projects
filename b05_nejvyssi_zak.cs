using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'b05)
//'Sestavte program, který postupne nacte jméno a výšku prvního žáka, a jméno a výšku druhého žáka. Poté zobrazí jméno
//'vyššího z nich.
namespace B {
    internal class B05_nejvyssi_zak {
        public static void Mainx(string[] args) {
            byte vyska1, vyska2;
            string jmeno1, jmeno2;
            Console.WriteLine("Který ze dvou žáků je vyšší?");
            Console.Write("Zadej jméno prvního žáka: ");
            jmeno1 = Console.ReadLine();
            Console.Write("Zadej výšku prvního žáka (cm): ");
            vyska1 = byte.Parse(Console.ReadLine());
            Console.Write("Zadej jméno druhého žáka: ");
            jmeno2 = Console.ReadLine();
            Console.Write("Zadej výšku druhého žáka (cm): ");
            vyska2 = byte.Parse(Console.ReadLine());
            if (vyska1 > vyska2) {
                Console.WriteLine(jmeno1 + " meří " + vyska1 + " cm a je vyšší než " + jmeno2 + ", který meří " + vyska2 + " cm.");
            }
            else if (vyska1 == vyska2) {
                Console.WriteLine("Oba žáci " + jmeno1 + " a " + jmeno2 + " meří " + vyska1 + " cm.");
            }
            else {
                Console.WriteLine(jmeno2 + " meří " + vyska2 + " cm a je vyšší než " + jmeno1 + ", který meří " + vyska1 + " cm.");
            }
        }
    }
}

