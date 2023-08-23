using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//'    Náročnější x2
//    'Dvojitý cyklus For
//    '18) Program vypíše všechna prvočísla do čísla 1000. Prvočísla jsou čísla dělitelná jen jedničkou a sama sebou. (použij modulo)
namespace C {
    internal class C18_vypis_prvocisel {
        public static void Mainx(string[] args) {
            string vypisPrvocisel = "";
            bool jePrvocislo = true;

            for (int i = 1000; i >= 2; --i) {
                for (int j = 2; j < i; ++j) {
                    if (j != i) {
                        if (i % j == 0) {
                            jePrvocislo = false; break;
                        }
                        else {
                            jePrvocislo = true;
                        }
                    }
                }
                if (jePrvocislo == true) {
                    vypisPrvocisel += i + " ";
                }
            }
            Console.WriteLine("Prvočísla do čísla 1000:\n" + vypisPrvocisel);
        }
    }
}