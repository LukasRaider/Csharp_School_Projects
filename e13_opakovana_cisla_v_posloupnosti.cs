using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'    '    Náročnější
//'13) Je dána posloupnost kladných celých čísel (ne lineární, tedy čísla budou nějak na přeskáčku).
//'Zjistěte, zda se v dané posloupnosti nějaké číslo opakuje.

//'13 b) zjistěte, která čísla se opakují.

//'13 c) přidejte ještě informaci, kolikrát se opakují.
namespace E {
    internal class E13_opakovana_cisla_v_posloupnosti {
        public static void Mainx(string[] args) {
            const int maxPrvku = 50;
            int[] pole = new int[maxPrvku];
            int hledane, pocitadlo;
            Random rnd = new Random();

            Console.WriteLine("Je dána posloupnost kladných celých čísel (ne lineární, tedy čísla budou nějak na přeskáčku)");
            for (int i = 0; i < maxPrvku; i++) {
                pole[i] = rnd.Next(1, 100);
                if (i == maxPrvku - 1) {
                    Console.WriteLine("{0,3}", pole[i]);
                }
                else
                    Console.Write("{0,3}", pole[i]);
            }
            for (int i = 0; i < maxPrvku; i++) {
                hledane = pole[i];
                pocitadlo = 0;
                for (int j = 0; j < maxPrvku; j++) {
                    if (j < i && hledane == pole[j]) {
                        break;
                    }
                    else if (hledane == pole[j]) {
                        pocitadlo++;
                    }
                }
                if (pocitadlo > 1) {
                    Console.WriteLine("Číslo " + hledane + " se opakuje " + pocitadlo);
                }
            }
        }
    }
}
