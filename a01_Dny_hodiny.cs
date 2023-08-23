using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//a01)
//Zadejte počet dnů a hodin. Program vypočte, kolik je to hodin (výsledek mùže být reálné číslo)
namespace A {
    internal class A01_Dny_hodiny {
        public static void Mainx(string[] args) {
            float hodiny, dny;
            Console.WriteLine("Zadej pocet dnu:");
            dny = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej pocet hodin: ");
            hodiny = float.Parse(Console.ReadLine());
            Console.WriteLine(dny + "d a " + hodiny + "h = " + soucetHodinyDnyF(dny, hodiny) + "h\n(d=den; h=hodina)");
        }

        static float soucetHodinyDnyF(float X, float Y) {
            const int Denhod = 24;
            return X * Denhod + Y;
        }
    }
}
