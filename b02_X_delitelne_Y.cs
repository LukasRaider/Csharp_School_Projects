using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'b02)
//'Zadejte dve celá císla x a y. Zjistete, zda císlo x je beze zbytku delitelné císlem y.
namespace B {
    internal class B02_X_delitelne_Y {
        public static void Mainx(string[] args) {
            int cislo1, cislo2;
            Console.Write("Zadej delenec (pouze cele císlo): ");
            cislo1 = int.Parse(Console.ReadLine());
            Console.Write("Zadej delitele (pouze cele císlo): ");
            cislo2 = int.Parse(Console.ReadLine());

            if (vratDelitelne(cislo1, cislo2) == true) {
                Console.WriteLine(cislo1 + " je delitelné " + cislo2 + " beze zbytku.");
            }
            if (vratDelitelne(cislo1, cislo2) == false) {
                Console.WriteLine((cislo1) + " není delitelné " + cislo2 + " beze zbytku.");
            }
        }
        static bool vratDelitelne(int delenec, int delitel) {
            if (delenec % delitel == 0) {
                return true;
            }
            else
                return false;
        }
    }
}


