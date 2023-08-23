using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'b10)
//'Zadejte císlo. Pocítac vypíše: "Odmocnina císla ... je  ..." nebo oznámí, že odmocninu záporného císla pocítat nebude.
namespace B {
    internal class B10_odmocnina_cisla {
        public static void Mainx(string[] args) {
            double c;
            Console.WriteLine("Zadejte císlo. Pocítac vypíše: \"Odmocnina císla ... je  ...\" nebo oznámí, že odmocninu záporného císla pocítat nebude");
            Console.Write("zadej cislo: ");
            c = double.Parse(Console.ReadLine());
            if (c < 0) {
                Console.WriteLine("Zaporne cilo pocitat nebudu");
            }
            else {
                Console.WriteLine("Odmocnina císla " + c + " je " + VratOdmocninu(c));
            }
        }
        public static double VratOdmocninu(double cislo) {
            return Math.Sqrt(cislo);
        }
    }
}

