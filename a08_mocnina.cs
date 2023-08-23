using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'a08)
//'Zadejte císlo, pocítac vypíše: Druhá mocnina císla… je... (príliš lehké)
namespace A {
    internal class A08_mocnina {
        public static void Mainx(string[] args) {
            float cislo;

            Console.Write("Zadej cislo: ");
            cislo = float.Parse(Console.ReadLine());
            Console.WriteLine("Druha mocnina cisla " + cislo + " je " + vratMocninu(cislo));
        }
        static float vratMocninu(float c) {
            return c * c;
        }
    }
}


