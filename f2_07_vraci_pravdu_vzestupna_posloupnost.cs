using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//' f2_7: Sestavte program, který nejprve čte řadu čísel ukončených nulou, která už do řady nepatří. Pole se předá funkci,
//' která sdělí (boolean), zda jsou čísla seřazena vzestupně, tedy každé další číslo je
//'větší než předchozí. Čili stačí jeden jediný pokles a už to není pravda.
namespace F2 {
    internal class F2_07_vraci_pravdu_vzestupna_posloupnost {
        public static void Mainx(string[] args) {
            const int maxPrvku = 100;
            int[] data = new int[maxPrvku];
            int cislo, i = 0;
            string ret = "";
            bool vystup = false;


            Console.WriteLine("Program čte řadu čísel ukončených nulou. Pole čísel se předá funkci/subrutině, která sdělí (boolean), zda jsou čísla seřazena vzestupně,\n\n");

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
            if (vzestupneF(data) == true) {
                Console.WriteLine("\"Pole je vzestupné (pomocí funkce) ");
            }
            else {
                Console.WriteLine("\"Pole není vzestupné (pomocí funkce)");
            }
            vzestupneS(data, ref vystup);
            if (vystup == true) {
                Console.WriteLine("\"Pole je vzestupné (pomocí subrutiny) ");
            }
            else {
                Console.WriteLine("\"Pole není vzestupné (pomocí subrutiny)");
            }
            Console.WriteLine("Vypis zadaných čísel:\n{0}", ret);
        }

        static bool vzestupneF(int[] x) {

            for (int i = 0; i < x.Length - 1; i++) {
                if (x[i] >= x[i + 1]) {
                    return false;
                    break;
                }
            }
            return true;
        }

        static void vzestupneS(int[] x, ref bool vysledek) {

            for (int i = 0; i < x.Length - 1; i++) {
                if (x[i] >= x[i + 1]) {
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
