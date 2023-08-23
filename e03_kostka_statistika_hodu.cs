using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'e03)
//'Vygenerujte několik hodů kostkou. Program vypíše, kolikrát padla jednotlivá čísla a vyjádří procentuálně.
//'Jaký byl průměr? Návod: Dá se to udělat např. tak, že si deklaruji šest počitadel, např. pocet1, pocet2 až pocet6.
//'A v druhé smyčce bude struktura If-Else s šesti větvemi kde se bude zvyšovat o jedničku počitadlo pocet1 nebo pocet2 atd.
//'Pro kontrolu: jejich součet musí být roven počtu hodů.
//'Až to bude chodit, tak místo šesti proměnných pocet1 až pocet6 použít pole (nazvané např. pocty). Tedy jedná se o další pole.
//'V jednom poli jsou všechny hody a v druhém poli je šest čísel s počtem četností jednotlivých hodnot.
//'Druhá varianta: ověřte, že při zaokrouhlování pomocí Round padají krajní čísla (1 a 6) s poloviční četností. Přitom Int pracoval správně, všechny hodnoty mají kolem 100/6=16,6 %.
namespace E {
    internal class E03_kostka_statistika_hodu {
        public static void Mainx(string[] args) {
            const int maxPrvku = 20;
            int[] hody = new int[maxPrvku];
            int[] cetnosti = new int[7]; //viy přednaska doc. Homola, nulté pole nepoužívám
            int hod, sumaHodu = 0;
            Random rnd = new Random();

            for (int i = 0; i < maxPrvku; i++) {
                hody[i] = rnd.Next(1, 7);
                sumaHodu += hody[i];
                Console.Write("{0,2}", hody[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < maxPrvku; i++) {
                hod = hody[i];
                cetnosti[hod]++;
            }
            for (int i = 1; i <= 6; i++) {
                Console.WriteLine("Číslo {0} padlo {1}x {2}%", i, cetnosti[i], Math.Round((double)cetnosti[i] / maxPrvku * 100, 2).ToString("0.00"));
            }
        }
    }
}