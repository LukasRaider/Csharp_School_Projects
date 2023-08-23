using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'A13) Zadejte délku odvěsen pravoúhlého trojúhelníka. Program pomocí Pythagorovy věty vypočte délku přepony.
//'Pro kontrolu: zadáte-li odvěsny o délce 3 a 4, pak výsledek je 5 (přesněji 5,0, protože výsledek odmocniny se musí ukládat do
//'desetinného typu)
namespace A {
    internal class A13_trojuhelnik {
        public static void Mainx(string[] args) {
            double odvesna1, odvesna2;
            Console.Write("Zadej prvni odvesnu pravoúhlého trojúhelníku: ");
            odvesna1 = double.Parse(Console.ReadLine());
            Console.Write("Zadej druhou odvesnu pravoúhlého trojúhelníku: ");
            odvesna2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Pravoúhlý trojúhelník s odvěsnami " + odvesna1 + " a " + odvesna2 + " ma přeponu o délce " + vratPreponu(odvesna1, odvesna2));
        }
        static double vratPreponu(double a,  Double b) {
            return Math.Round(Math.Sqrt(a * a + b * b), 1);
        }
    }
}
