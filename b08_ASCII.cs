using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'b08)
//'Uživatel zadá znak, program odpoví, zda se jedná o velké písmeno, malé písmeno, èíslici nebo jiný znak.
//'Øešte pomocí else if. (nebo je možno øešit i složenou podmínkou).
//'U písmen uvažujte jen písmena anglické abecedy (tedy bez háèkù a èárek).
//'Øešte intervalem (èili od-do), tedy využijte toho, že èíslice jsou v ASCII za sebou seøazeny podle hodnoty (podobnì velká písmena seøazená podle anglické abecedy a stejnì tak i malá písmena).
//'Tedy neøešte výètem (vyjmenováním jednotlivých písmenek).
namespace B {
    internal class B08_ASCII {
        public static void Mainx(string[] args) {
            char vstup;
            Console.WriteLine("Zadej znak, program odpoví, zda se jedná o velké písmeno, malé písmeno, číslici nebo jiný znak");
            Console.Write("Zadej znak: ");
            vstup = char.Parse(Console.ReadLine());
            Console.WriteLine(vratZnak(vstup));
        }
        public static string vratZnak(char znak) {
            if (znak >= '0' && znak <= '9') {
                return "číslo";
            }
            else if (znak >= 'A' && znak <= 'Z') {
                return "velké písmeno";
            }
            else if (znak >= 'a' && znak <= 'z') {
                return "malé písmeno";
            }
            else {
                return "jiný znak";
            }
        }
    }
}
