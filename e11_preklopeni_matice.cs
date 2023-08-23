using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'    Náročnější
//'11) Program Doc. Homoly: Dvojrozměrné pole: Naplňte zadáním pole 4x4.
//'Poté ji zobrazí překlopenou kolem hlavní diagonály (tedy prohodí indexy řádků a sloupců).
//'Takže například místo pole

//'1 2 3 4
//'5 6 7 8
//'9 10 11 12
//'13 14 15 16
//'bude pole
//'1 5 9 13
//'2 6 10 14
//'3 7 11 15
//'4 8 12 16
namespace E {
    internal class E11_preklopeni_matice {
        public static void Mainx(string[] args) {
            int[,] pole = new int[4, 4];
            int cislo = 1;

            Console.WriteLine("Původní matice:");
            for (int r = 0; r < 4; r++) {
                for (int s = 0; s < 4; s++) {
                    pole[r, s] = cislo;
                    cislo++;
                    Console.Write("{0,5}", pole[r, s]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Překlopená matice:");
            for (int s = 0; s < 4; s++) {
                for (int r = 0; r < 4; r++) {
                    Console.Write("{0,5}", pole[r, s]);
                }
                Console.WriteLine();
            }
        }
    }
}
