using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'f02)
//'Napište funkci, které se zadá znak a která vrátí jeho ASCII hodnotu.  (příliš lehké)
namespace F1 {
    internal class F1_02_ASCII_vraci_hodnotu_znaku {
        public static void Mainx(string[] args) {
            string znak;
            int vystup;

            Console.WriteLine("Zadej znak, fukce vrátí jeho hodnotu v ASCII\n");

            Console.Write("Zadej znak: ");
            znak = Console.ReadLine();
            vratAsciiS(znak, out vystup);
            Console.WriteLine("Vraceno subrutinou: " + vystup);
            Console.WriteLine("Vraceno funkci: " + vratAsciiF(znak));
        }

        static int vratAsciiF(string x) {
            return Convert.ToChar(x);
        }

        static void vratAsciiS(string x, out int vysledek) {
            vysledek = Convert.ToChar(x);
        }

    }
}
