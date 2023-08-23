using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'d08)
//'Varianta příkladu ze skupiny b: Uživatel opakovaně zadá znak, program vždy odpoví, zda se jedná o písmeno, číslici nebo jiný znak.
//'Zadávání končí zadáním např. nuly (nebo to pro změnu zkuste ukončit nějakým jiným znakem).
//'Řešte pomocí else if.
namespace D_ {
    internal class D08_ASCII {       //d08_ASCII
        public static void Mainx(string[] args) {
            char znak;

            Console.WriteLine("//'d08)\r\n//'Varianta příkladu ze skupiny b: Uživatel opakovaně zadá znak, program vždy odpoví, zda se jedná o písmeno, číslici nebo jiný znak.\r\n//'Zadávání končí zadáním např. nuly (nebo to pro změnu zkuste ukončit nějakým jiným znakem).\r\n//'Řešte pomocí else if.\n\n");

            do {
                Console.Write("Zadej znak: ");
                znak = char.Parse(Console.ReadLine());
                if (znak >= 'a' && znak <= 'z') {
                    Console.WriteLine("malé písmeno");
                }
                else if (znak >= 'A' && znak <= 'Z') {
                    Console.WriteLine("velké písmeno");
                }
                else if (znak >= '0' && znak <= '9') {
                    Console.WriteLine("číslo");
                }
                else {
                    Console.WriteLine("jiný znak (není písmeno ani číslo)");
                }
            } while (znak != '0');
        }
    }
}