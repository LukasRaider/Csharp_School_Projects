using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'e06)
//'Zadejte postupně několik písmen. Program potom náhodně vygeneruje slovo (shluk písmen), které se bude skládat z těchto písmen (např. vždy 5 znaků).
//'Písmena se mohou opakovat a nemusí být použita všechna. Pozn. zadávání můžete ukončit třeba číslem 0 nebo třeba stiskem klávesy enter. (Varianta: vygenerujte třeba 10 slov.)
//'Varianta: Místo zadání z klávesnice vygeneruje prvotních několik písmen počítač.
namespace E {
    internal class E06_shluk_pismen {
        public static void Mainx(string[] args) {
            const int maxPrvku = 100;
            string[] pole = new string[maxPrvku];
            string retSlova = "", nahZnak, abeceda = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int iMax = 0, i = 20;
            Random rnd = new Random();

            Console.Write("Náhodně vygenerované znaky: ");
            for (int j = 0; j < 20; j++) {                          //20 nahodnych vygenererovaných znaku
                char c = abeceda[rnd.Next(abeceda.Length)];
                pole[j] = c.ToString();
                Console.Write("{0,2}", pole[j]);
            }
            Console.WriteLine();
            do {
                Console.Write("Zadejte další znak(Enter ukončí zadávání): ");
                pole[i] = Console.ReadLine();
                i++;
            } while (pole[i - 1] != "");

            iMax = i - 1;
            Console.WriteLine("10 náhodných slov: ");
            for (int j = 0; j < 10; j++) {
                retSlova = "";
                for (int x = 0; x < 5; x++) {
                    nahZnak = pole[rnd.Next(0, iMax)];
                    retSlova += nahZnak;
                }
                Console.WriteLine(retSlova);
            }
        }
    }
}