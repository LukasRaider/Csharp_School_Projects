using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'b13)
//'Počítač se zeptá:  "Chcete skončit?  (A/N)" Při stisku A program skončí, při stisku čehokoliv jiného se vypíše "A stejnì skončím!" a program skončí.
namespace B {
    internal class B13_chces_skoncit {
        public static void Mainx(string[] args) {
            string volba;
            Console.WriteLine("Chcete skoncit? [A/N] ");
            volba = Console.ReadLine();
            if (volba != "a" && volba != "A") {
                Console.WriteLine("A stejne skoncim!");
            }

        }
    }
}