using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'e01)
//'Zadejte řadu čísel ukončenou nulou. Zjistěte nejmenší a vypište, kolikrát se v řadě opakuje. (návod: v druhé smyčce se najde minimum.
//'A tentokrát bude i smyčka třetí, ve které se zjistí, kolikrát se v poli toto minimum vyskytuje).
//'Pozn.: lze řešit i dvěma smyčkami, první a druhá se spojí do jedné. Tedy čísla se zadávají a hned se zjišuje, zdali není menší, než dosavadní minimum.
//'Pozn.: šlo by to i jednou smyčkou, ale to už je náročnější. A nebylo by v tom případě nutné pole.
namespace E {
    internal class E01_hleda_min_cislo {
        public static void Mainx(string[] args) {
            const int maxPrvku = 100;
            int[] pole = new int[maxPrvku];
            int pocitadloVolnychPoli, iMax, pocitadlo = 0, i = 0, min;

            Console.Write("Zadejte několik čísel (NULA ukončíte zadávání): ");
            pole[i] = int.Parse(Console.ReadLine());
            min = pole[i];

            while (pole[i] != 0 && i < maxPrvku - 1) {
                i++;
                Console.Write("Zadejte několik čísel (NULA ukončíte zadávání): ");
                pole[i] = int.Parse(Console.ReadLine());
            }
            iMax = i;
            for (int j = 0; j <= iMax; j++) {
                if (pole[j] < min && pole[j] != 0) {
                    min = pole[j];
                }
                else if (min == pole[j]) {
                    pocitadlo++;
                }
            }
            Console.WriteLine("Nejmenší zadané: {0} \nPočet výskytů:{1}", min, pocitadlo);
        }
    }
}