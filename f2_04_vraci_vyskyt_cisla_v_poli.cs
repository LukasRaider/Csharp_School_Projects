using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'   Programy Doc. Homoly
//'4) Sestavte funkci PocetVyskytu, která má dva parametry: Prvním je jednorozměrné pole čísel A, druhým je číslo C.
//'Výsledkem funkce je celé číslo udávající, kolikrát se číslo C vyskytuje v poli A.
//'Funkci ověřte na zadání: sestavte 
namespace F2 {
    internal class F2_04_vraci_vyskyt_cisla_v_poli {
        public static void Mainx(string[] args) {
            const int maxPrvku = 100;
            int[] data = new int[maxPrvku];
            int cislo, hledane, vysledek = 0, i = 0;
            string ret = "";
            //int[] vystupPoleF, vystupPoleS = new int[maxPrvku];     //pro subrutinu musi byt pole inicializovane

            Console.WriteLine("Program, který postupně načte pole A a hodnotu C, a poté zobrazí počet výskytů hodnoty C v poli A.\n\n");

            do {
                Console.Write("Zadej číslo. Nula ukončuje: ");
                cislo = int.Parse(Console.ReadLine());
                if (cislo != 0) {
                    if (i >= maxPrvku) {
                        Console.WriteLine("Pole je plne.");
                        break;
                    }
                    data[i] = cislo;
                    ret += data[i] + " ";
                    i++;
                }
            } while (cislo != 0);
            Array.Resize(ref data, i); //pole se timto zmensi pouze na pole s hodnotami
            Console.WriteLine("Zadej znovu jedno číslo: ");
            hledane = int.Parse(Console.ReadLine());

            Console.WriteLine("Vráceno funkcí. Číslo {0} se vyskytuje {1}x.", hledane, pocetVyskytuF(data, hledane));
            pocetVyskytuS(data, hledane, ref vysledek);
            Console.WriteLine("Vráceno subrutinou. Číslo {0} se vyskytuje {1}x.", hledane, vysledek);
        }
        static int pocetVyskytuF(int[] x, int cisloVyskyt) {
            int pocet = 0;

            for (int i = 0; i < x.Length; i++) {
                if (x[i] == cisloVyskyt) {
                    pocet++;
                }
            }
            return pocet;
        }

        static void pocetVyskytuS(int[] x, int cisloVyskyt, ref int vysledek) {
            int pocet = 0;

            for (int i = 0; i < x.Length; i++) {
                if (x[i] == cisloVyskyt) {
                    pocet++;
                }
            }
            vysledek = pocet;
        }
    }
}
