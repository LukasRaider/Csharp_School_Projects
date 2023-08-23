using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//'8) Sestavte program, který nejprve čte řadu čísel ukončených nulou, která už do řady nepatří. Pole se předá funkci, která sdělí,
//'kolikátý prvek v řadě porušuje vzestupné řazení čísel. Pokud je pole celé vzestupné, pak vrátí -1
namespace F2 {
    internal class F2_08_vraci_poradi_ktere_nesplnuje_poradi {
        public static void Mainx(string[] args) {
            const int maxPrvku = 100;
            int[] data = new int[maxPrvku];
            int cislo, i = 0, vystup = 0;
            string ret = "";

            Console.WriteLine("Program čte řadu čísel ukončených nulou. Pole čésel se předá funkci/subrutině, která sdělí kolikátý prvek v řadě porušuje vzestupné řazení čísel.\n\n");

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
            if (poradiF(data) == -1) {
                Console.WriteLine("\"Pole je vzestupné (pomocí funkce) ");
            }
            else {
                Console.WriteLine("\"První klesající prvek je na {0}. místě (to tvrdí funkce)", poradiF(data));
            }
            poradiS(data, ref vystup);
            if (vystup == -1) {
                Console.WriteLine("\"Pole je vzestupné (pomocí subrutiny) ");
            }
            else {
                Console.WriteLine("\"První klesající prvek je na {0}. místě (to tvrdí subrutina)", vystup);
            }
            Console.WriteLine("Vypis zadaných čísel:\n{0}", ret);
        }

        static int poradiF(int[] x) {
            int pocitadlo = -1;

            for (int i = 0; i < x.Length - 1; i++) {
                if (x[i] >= x[i + 1]) {
                    pocitadlo = i + 2;
                    return pocitadlo;
                    break;
                }
            }
            return pocitadlo;
        }

        static void poradiS(int[] x, ref int vysledek) {
            int pocitadlo = -1;

            for (int i = 0; i < x.Length - 1; i++) {
                if (x[i] >= x[i + 1]) {
                    pocitadlo = i + 2;
                    vysledek = pocitadlo;
                    break;
                }
            }
            vysledek = pocitadlo;
        }
    }
}