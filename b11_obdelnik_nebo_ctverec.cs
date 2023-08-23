using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'b11)
//'Zadejte dve kladná císla, která predstavují délky stran obdélníka.
//'Zjistete, zda se jedná o ctverec a zobrazte zprávu ve tvaru: "ctverec má dálku strany..." nebo "Obdélník má rozmery ... x ..."
namespace B {
    internal class B11_obdelnik_nebo_ctverec {
        public static void Mainx(string[] args) {
            double a, b;
            Console.WriteLine("Zadejte dve kladná čísla, která představují délky stran obdélníka");
            Console.Write("Zadej stranu a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Zadej stranu b: ");
            b = double.Parse(Console.ReadLine());
            if (a == b) {
                Console.WriteLine("Čtverec má délku strany " + a + ".");
            }
            else {
                Console.WriteLine("Obdélník má rozměry " + a + " x " + b + ".");
            }
        }
    }
}
