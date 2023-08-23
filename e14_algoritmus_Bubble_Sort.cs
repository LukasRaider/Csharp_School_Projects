using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using static System.Net.Mime.MediaTypeNames;
//'    Náročnější
//'14) Vygenerujte deset celých čísel a setřiďte je. Použijte např. algoritmus Bublinkového třídění (Bubble sort)
namespace E {
    internal class E14_algoritmus_Bubble_Sort {
        public static void Mainx(string[] args) {
            const int maxPrvku = 15;
            int[] pole = new int[maxPrvku];
            int pom;
            Random rnd = new Random();

            Console.WriteLine("Původní pořadí vygenerovaných čísel:");
            for (int i = 0; i < maxPrvku; i++) {
                pole[i] = rnd.Next(1, 1001);
                Console.Write("{0,5}", pole[i]);
            }
            for (int i = 0; i < maxPrvku - 1; i++) {
                for (int j = 0; j < maxPrvku - 1; j++) {
                    if (pole[j] > pole[j + 1]) {
                        pom = pole[j];
                        pole[j] = pole[j + 1];
                        pole[j + 1] = pom;
                    }
                }
            }
            Console.WriteLine("\nSetříděná čísla v poli pomocí algoritmu Bubble Sort:");
            foreach (var item in pole) {
                Console.Write("{0,5}", item);
            }
            Console.WriteLine("\n");
        }
    }
}
