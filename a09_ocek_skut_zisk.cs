using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'a09)
//'Z klávesnice se zadá ocekávaný a skutecný príjem. Pocítac oznámí, kolika procent bylo dosaženo.
namespace A {
    internal class A09_ocek_skut_zisk {
        public static void Mainx(string[] args) {
            float ocekavany, skutecny;
            Console.Write("Zadaj ocekávaný príjem (Kc): ");
            ocekavany = float.Parse(Console.ReadLine());
            Console.Write("Zadej skutecný príjem (Kc): ");
            skutecny = float.Parse(Console.ReadLine());
            Console.WriteLine("Bylo dosaženo " + vratPlneniPlanu(skutecny, ocekavany) + " % ocekávaného príjmu.");
        }
        static float vratPlneniPlanu(float skut, float ocek) {
            return (float)Math.Round((skut / ocek * 100), 2);
        }
    }
}

