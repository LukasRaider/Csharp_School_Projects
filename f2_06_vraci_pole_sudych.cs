using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//' f2_6) Sestavte funkci SudaCislaZpole, která má jediný parametr: pole celých čísel. Výsledkem funkce je jednorozměrné celočíselné pole,
//' ve kterém jsou jen sudá čísla obsažená v poli parametru. Funkci ověřte na zadání: sestavte program, který načte pole celých
//' čísel ukončených nulou, která už k číslům nepatří, a pak zobrazí všechna ze zadaných čísel, která jsou sudá.
namespace F2 {
    internal class F2_06_vraci_pole_sudych {
        public static void Mainx(string[] args) {
            const int maxPrvku = 100;
            int[] data = new int[maxPrvku];
            int cislo, i = 0;
            string ret = "";
            int[] vystupPoleF, vystupPoleS = new int[maxPrvku];     //pro subrutinu musi byt pole inicializovane

            Console.WriteLine("Program čte řadu čísel ukončených nulou. Pole čísel se předá funkci/subrutině, která vrátí pole sudých čísel.\n\n");

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

            vystupPoleF = sudaF(data);
            Console.WriteLine("Výběr sudých čísel pomocí funkce:");
            foreach (int item in vystupPoleF) {
                Console.WriteLine(item);
            }
            sudaS(data, ref vystupPoleS);
            Console.WriteLine("Výběr sudých čísel pomocí subrutiny:");
            foreach (int item in vystupPoleS) {
                Console.WriteLine(item);
            }
            Console.WriteLine("Vypis zadaných čísel:\n{0}", ret);
        }
        static int[] sudaF(int[] x) {
            int[] vystPole = new int[x.Length];
            int j = 0;

            for (int i = 0; i < x.Length; i++) {
                if (x[i] % 2 == 0) {
                    vystPole[j] = x[i];
                    j++;
                }
            }
            Array.Resize(ref vystPole, j);
            return vystPole;
        }

        static void sudaS(int[] x, ref int[] vystPole) {
            int j = 0;

            for (int i = 0; i < x.Length; i++) {
                if (x[i] % 2 == 0) {
                    vystPole[j] = x[i];
                    j++;
                }
            }
            Array.Resize(ref vystPole, j);
        }
    }
}










