using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//'    Náročnější
//'12) Program zjistí indexy všech lokálních maxim (tedy prvků pole, které sousedí s nižšími hodnotami, čili které mají vlevo i vpravo nižší hodnotu).
//'Např. mějme pole
//'1 2 3 1 5 6 7 4 3 2 6 5
//'Lokální maxima jsou 3, 7, 6
namespace E {
    internal class E12_lokalni_Maxima {
        public static void Mainx(string[] args) {
            const int maxPrvku = 50;
            int[] pole = new int[maxPrvku];
            Random rnd = new Random();
            string retMaxima = "";

            for (int i = 0; i < maxPrvku; i++) {
                pole[i] = rnd.Next(1, 10);
                Console.Write("{0,2}", pole[i]);
            }
            Console.WriteLine("\nLokální maxima");
            for (int i = 1; i < maxPrvku - 1; i++) {
                if (pole[i - 1] < pole[i] && pole[i + 1] < pole[i]) {
                    Console.WriteLine(pole[i] + " s indexem " + i);
                }
            }
        }
    }
}
