using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'c11)
//'Tabulka ASCII: zobrazit v MsgBoxu v levém sloupci  čísla např. 65 až 100 a v pravém příslušný znak.
namespace C {
    internal class C11_ASCII {
        public static void Mainx(string[] args) {

            Console.WriteLine("Tabulka ASCII [65-100]\nASCII\tZNAK");
            for (int i = 65; i <= 100; i++) {
                Console.WriteLine(i + "\t" + Convert.ToChar(i));
            }
        }
    }
}
