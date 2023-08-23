using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'e05)
//'Zadejte v jednom cyklu řadu čísel. V dalších cyklech program poté spočítá jejich součet, průměr, maximum, minimum.
//'Pak se program ještě zeptá, zda chcete zobrazit součet druhých mocnin.
namespace E {
    internal class E05_rada_cisle_dva_cykly {
        public static void Mainx(string[] args) {
            const int maxPrvku = 100;
            int[] pole = new int[maxPrvku];
            int soucet = 0, maximum, minimum, i = 0, iMax;
            double prumer, vysledekMocnin = 0;
            string dotazNaMocninu = "";

            Console.Write("Zadejte několik čísel (Nulou ukončíte zadávání): ");
            pole[i] = int.Parse(Console.ReadLine());
            maximum = pole[i];
            minimum = pole[i];

            do {
                i++;
                Console.Write("Zadejte několik čísel (Nulou ukončíte zadávání): ");
                pole[i] = int.Parse(Console.ReadLine());
            } while (pole[i] != 0 && i < maxPrvku);
            iMax = i;
            Console.WriteLine("Výpis čísel:");
            for (int j = 0; j < iMax; j++) {
                soucet += pole[j];
                Console.Write("{0,4}", pole[j]);
                if (pole[j] > maximum) {
                    maximum = pole[j];
                }
                else if (pole[j] < minimum) {
                    minimum = pole[j];
                }
            }
            prumer = Math.Round((double)soucet / iMax, 2);
            Console.WriteLine("\nSoučet: {0}\nPrůměr: {1}\nMaximum: {2}\nMinimum: {3}\nChcete zobrazit součet druhých mocnin (a/n)?", soucet, prumer, maximum, minimum);
            dotazNaMocninu = Console.ReadLine();
            if (dotazNaMocninu == "a" || dotazNaMocninu == "A") {
                foreach (int item in pole) {
                    vysledekMocnin += (item * item);
                }
                Console.WriteLine("Součet druhých mocnin je: {0}", vysledekMocnin);
            }
            else {
                Console.WriteLine("Program byl ukončen.");
            }
        }
    }

}