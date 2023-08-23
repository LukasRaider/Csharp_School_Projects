using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'e02)
//'Zadejte několik čísel, ukončete nulou. Potom zadáte některé z předtím zadaných čísel. Program vypíše, kolikrát toto číslo předtím padlo.
namespace E {
    internal class E02_hleda_zadane_cisla {
        public static void Mainx(string[] args) {
            const int maxPrvku = 100;
            int[] pole = new int[maxPrvku];
            int hledaneCislo, iMax, i = 0, pocitadlo = 0;

            do {
                Console.Write("Zadejte několik čísel (NULA ukončíte zadávání): ");
                pole[i] = int.Parse(Console.ReadLine());
                i++;
            } while ((pole[i - 1] != 0 && i < maxPrvku));
            iMax = i - 1;
            Console.Write("Zadejte některé z předtím zadaných čísel: ");
            hledaneCislo = int.Parse(Console.ReadLine());
            for (int j = 0; j < iMax; j++) {
                if (pole[j] == hledaneCislo) {
                    pocitadlo++;
                }
            }
            if (pocitadlo == 0) {
                Console.WriteLine("Číslo nebylo zadáno");
            }
            else {
                Console.WriteLine("Číslo {0} bylo zadáno {1}x", hledaneCislo, pocitadlo);
            }
        }
    }
}
