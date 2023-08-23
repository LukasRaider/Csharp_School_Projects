using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'b06)
//'První auto ujelo trasu s1 za cas t1 a druhé trasu s2 za cas t2. (údaje zadejte). Spocítejte prumernou rychlost obou aut a
//'vypište zprávu "... auto je o ... rychlejší".
namespace B {
    internal class B06_rychlejsi_auto {
        public static void Mainx(string[] args) {
            double s1, t1, s2, t2, r1, r2;

            Console.Write("Zadej delku trasy prvniho auta [km]: ");
            s1 = double.Parse(Console.ReadLine());
            Console.Write("Zadej cas jizdy prvniho auta [h]: ");
            t1 = double.Parse(Console.ReadLine());
            Console.Write("Zadej delku trasy druheho auta [km]: ");
            s2 = double.Parse(Console.ReadLine());
            Console.Write("Zadej cas jizdy druheho auta [h]: ");
            t2 = double.Parse(Console.ReadLine());
            r1 = s1 / t1;
            r2 = s2 / t2;
            if (r1 > r2) {
                Console.WriteLine("Prvni auto je o " + Math.Round((r1 - r2), 2) + " km/h rychlejsi");
            }
            else if (r1 == r2) {
                Console.WriteLine("Obe auta jedou stejnou rychlosti " + Math.Round(r1, 2) + " km/h");
            }
            else {
                Console.WriteLine("Druhe auto je o " + Math.Round((r2 - r1), 2) + " km/h rychlejsi");
            }
        }
    }
}
