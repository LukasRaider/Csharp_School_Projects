using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'d05)
//'Zadejte několik celých čísel, ukončete nulou (ta již do dat nepatří).
//'Program v MsgBoxu vypíše daná čísla, jejich počet, součet, průměr, minimum, maximum.
//'Případně ještě vypíše ta z nich, která jsou sudá a jejich počet.
//'Případně ještě vypíše ta z nich, která jsou větší, než první číslo.
namespace D_ {
    internal class D05_vypis_cisle {
        public static void Mainx(string[] args) {
            double cislo, soucet = 0, max, min, prvni, prumer;
            int pocitadlo = 0, pocetSude = 0, pocetVetsich = 0;
            const int maxPrvku = 200;
            int[] poleSudych = new int[maxPrvku];
            double[] poleVetsichNezPrvni = new double[maxPrvku];
            double[] poleCisel = new double[maxPrvku];

            Console.WriteLine("//'d05)\r\n//'Zadejte několik celých čísel, ukončete nulou (ta již do dat nepatří).\r\n//'Program v MsgBoxu vypíše daná čísla, jejich počet, součet, průměr, minimum, maximum.\r\n//'Případně ještě vypíše ta z nich, která jsou sudá a jejich počet.\r\n//'Případně ještě vypíše ta z nich, která jsou větší, než první číslo.\n\n");

            Console.Write("Zadej celé číslo, ukonči 0: ");
            cislo = double.Parse(Console.ReadLine());
            poleCisel[pocitadlo] = cislo;
            prvni = cislo;
            min = cislo;
            max = cislo;
            while (cislo != 0) {
                pocitadlo++;
                soucet += cislo;
                if (cislo > max) {
                    max = cislo;
                }
                if (cislo < min) {
                    min = cislo;
                }
                if (cislo % 2 == 0) {
                    poleSudych[pocetSude] = (int)cislo;
                    pocetSude++;
                }
                if (cislo > prvni) {
                    poleVetsichNezPrvni[pocetVetsich] = cislo;
                    pocetVetsich++;
                }
                Console.Write("Zadej celé číslo, ukonči 0: ");
                cislo = double.Parse(Console.ReadLine());
                poleCisel[pocitadlo] = cislo;
            }
            Console.WriteLine("\nVýpis zadaných čísl: ");
            prumer = Math.Round((soucet / (pocitadlo)), 2);
            for (int i = 0; i < pocitadlo; i++) {
                Console.Write(poleCisel[i] + " ");
            }
            Console.WriteLine("\nPočet: {0}\nSoučet: {1}\nPrůměr: {2}\nMinimum: {3}\nMaximum: {4}", pocitadlo, soucet, prumer, min, max);
            Console.WriteLine("Počet sudých: {0}\nVýpis sudých čísel: ", pocetSude);
            for (int i = 0; i < pocetSude; i++) {
                Console.Write(poleSudych[i] + " ");
            }
            Console.WriteLine("\nVýpis větší než první zadané: ");
            for (int i = 0; i < pocetVetsich; i++) {
                Console.Write(poleVetsichNezPrvni[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
