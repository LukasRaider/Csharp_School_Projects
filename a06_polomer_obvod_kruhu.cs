using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//a06)
//Zadejte polomer kruhu. Vypocítejte obvod (o=2PIr) a plochu (P=PIr 2 ).
namespace A {
    internal class A06_polomer_obvod_kruhu {
        public static void Mainx(string[] args) {
            float polomer;
            Console.Write("Zadej polomer kruhu: ");
            polomer = float.Parse(Console.ReadLine());
            Console.WriteLine("Kruhu o polomeru " + polomer + " má obvod: " + ((float)(2 * Math.PI * polomer)) + " a plochu: " + ((float)(Math.PI * polomer * polomer)));
        }
    }
}



