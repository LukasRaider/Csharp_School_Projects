using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'f07)
//'Funkci se předá znak a funkce vrátí řetězec: „malé písmeno“, „velké písmeno“, „číslice“, „ostatní“.
namespace F1 {
    internal class F1_07_ASCII_vraci_typ_znaku {
        public static void Mainx(string[] args) {
            char znak;
            string vystup;

            Console.Write("Zadej znak: ");
            znak = char.Parse(Console.ReadLine());
            Console.WriteLine("Vráceno funkcí: " + vratTypZnakuF(znak));
            vratTypZnakuS(znak, out vystup);
            Console.WriteLine("Vráceno subrutinou: " + vystup);
        }
        static string vratTypZnakuF(char x) {

            if (x >= 'a' && x <= 'z') {
                return "malé písmeno";
            }
            else if (x >= 'A' && x <= 'Z') {
                return "velké písmeno";
            }
            else if (x >= '0' && x <= '9') {
                return "číslo";
            }
            else {
                return "jiný znak (není písmeno ani číslo)";
            }
        }

        static void vratTypZnakuS(char x, out string vysledek) {

            if (x >= 'a' && x <= 'z') {
                vysledek = "malé písmeno";
            }
            else if (x >= 'A' && x <= 'Z') {
                vysledek = "velké písmeno";
            }
            else if (x >= '0' && x <= '9') {
                vysledek = "číslo";
            }
            else {
                vysledek = "jiný znak (není písmeno ani číslo)";
            }

        }
    }
}
