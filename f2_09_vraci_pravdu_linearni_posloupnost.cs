using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
//'f2_9) Sestavte program, který nejprve čte řadu čísel ukončených nulou, která už do řady nepatří. Pole se předá funkci,
//'která sdělí (boolean), zda čísla tvoří aritmetickou (lineární) posloupnost (rozdíl dvou sousedních je vždy tentýž).
namespace F2 {
    internal class F2_09_vraci_pravdu_linearni_posloupnost {
        public static void Mainx(string[] args) {
            const int maxPrvku = 100;
            int[] data = new int[maxPrvku];
            int cislo, i = 0;
            string ret = "";
            bool vystup = false;

            Console.WriteLine("Program nejprve čte řadu čísel ukončených nulou. Funkce/subrutina sdělí (boolean), zda čísla tvoří aritmetickou (lineární) posloupnost.\n\n");

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

            if (jeAritmF(data) == true) {
                Console.WriteLine("Je to aritmetická řada? (pomocí funkce)");
            }
            else {
                Console.WriteLine("NENÍ to aritmetická řada? (pomocí funkce)");
            }
            jeAritmS(data, ref vystup);
            if (vystup == true) {
                Console.WriteLine("Je to aritmetická řada? (pomocí subruitny)");
            }
            else {
                Console.WriteLine("NENÍ to aritmetická řada? (pomocí subruitny)");
            }
            Console.WriteLine(ret);
        }

        static bool jeAritmF(int[] x) {
            int rozdil = x[1] - x[0];

            for (int i = 0; i < x.Length - 1; i++) {
                if (x[i + 1] - x[i] != rozdil) {
                    return false;
                    break;
                }
            }
            return true;
        }

        static void jeAritmS(int[] x, ref bool vysledek) {
            int rozdil = x[1] - x[0];

            for (int i = 0; i < x.Length - 1; i++) {
                if (x[i + 1] - x[i] != rozdil) {
                    vysledek = false;
                    break;
                }
                else {
                    vysledek = true;
                }
            }
        }
    }
}