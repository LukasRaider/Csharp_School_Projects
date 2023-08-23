using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'b01)
//'Urcete, zda dve zadaná císla x,y císla splnují nerovnost x+3<5y-1
namespace B {
    internal class B01_nerovnice {
        public static void Mainx(string[] args) {
            double cislo1, cislo2;
            Console.WriteLine("Splnuje x a y nerovnost x+3<5y-1 ?");
            Console.Write("zadej x: ");
            cislo1 = double.Parse(Console.ReadLine());
            Console.Write("zadej y: ");
            cislo2 = double.Parse(Console.ReadLine());

            if (vratNerovnici(cislo1, cislo2) == true) {
                Console.WriteLine("Cisla splnuji nerovnost x+3<5y-1");
            }
            if (vratNerovnici(cislo1, cislo2) == false) {
                Console.WriteLine("Cisla nesplnuji nerovnost x+3<5y-1");
            }
        }
        static bool vratNerovnici(double x, double y) {
            if ((double)x + 3 < 5 * y - 1) {
                return true;
            }
            else {
                return false;
            }
        }
    }

}




