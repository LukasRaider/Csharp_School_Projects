using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//'Programy Doc. Homoly
//    '10) Obtížné, třídění: Sestavte funkci SerazenePole, která má jediný parametr: pole celých čísel.
//    'Výsledkem funkce je jednorozměrné celočíselné pole, ve kterém jsou stejná čísla jako v poli parametru, ale jsou seřazena vzestupně.
//    'Funkci ověřte na zadání: sestavte program, který načte pole celých čísel ukončených nulou, která už k číslům nepatří, a pak zobrazí
//    'všechna zadaná čísla ve vzestupném pořadí. (obdoba E14, ale třídění proběhne ve funkci)
namespace F2 {
    internal class F2_10_vraci_vzestupne_serazene_pole {
        public static void Mainx(string[] args) {
            const int maxPrvku = 100;
            int[] data = new int[maxPrvku];
            int[] vystupPoleF, vystupPoleS;
            int cislo, i = 0;
            string s = "";

            Console.WriteLine("Program načte pole celých čísel ukončených nulou \nPak zobrazí všechna zadaná čísla ve vzestupném pořadí.\n\nZadávej čísla: ");

            do {
                cislo = int.Parse(Console.ReadLine());
                if (cislo != 0) {
                    if (i >= maxPrvku) {
                        Console.WriteLine("Pole je plne.");
                        break;
                    }
                    data[i] = cislo;
                    s += data[i] + " ";
                    i++;
                }
            } while (cislo != 0);

            Array.Resize(ref data, i);

            vystupPoleF = SerazenePoleF(data);
            s += "\nPole serazene funkci:\n";
            foreach (int v in vystupPoleF) {
                s += v + " ";
            }

            SerazenePoleS(data, out vystupPoleS);
            s += "\nPole serazene subrutinou:\n";
            foreach (int v in vystupPoleS) {
                s += v + " ";
            }
            Console.WriteLine(s);
        }

        static int[] SerazenePoleF(int[] vstPole) {
            int pom;
            bool serazeno;
            int[] vystPole = new int[vstPole.Length];
            Array.Copy(vstPole, vystPole, vstPole.Length);

            do {
                serazeno = true;
                for (int i = 0; i < vystPole.Length - 1; i++) {
                    if (vystPole[i] > vystPole[i + 1]) {
                        pom = vystPole[i];
                        vystPole[i] = vystPole[i + 1];
                        vystPole[i + 1] = pom;
                        serazeno = false;
                    }
                }
            } while (serazeno != true);
            return vystPole;
        }

        static void SerazenePoleS(int[] vstPole, out int[] vystPole) {
            int pom;
            bool serazeno;
            vystPole = new int[vstPole.Length];
            Array.Copy(vstPole, vystPole, vstPole.Length);

            do {
                serazeno = true;
                for (int i = 0; i < vystPole.Length - 1; i++) {
                    if (vystPole[i] > vystPole[i + 1]) {
                        pom = vystPole[i];
                        vystPole[i] = vystPole[i + 1];
                        vystPole[i + 1] = pom;
                        serazeno = false;
                    }
                }
            } while (serazeno != true);
        }
    }
}

