using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'d03)
//'Zadejte první, druhy a poslední člen lineární celočíselné posloupnosti (lineární posloupnost je taková, kde mezi jednotlivými členy jsou stejné odstupy, např. 12, 15, 18, 21...).
//'Program zobrazí pod sebou všechny prvky posloupnosti.
//'Pozn.: program musí fungovat, i kdyby třetí zadané číslo se nestrefilo do členù posloupnosti (tedy kdyby toto číslo nebylo v posloupnosti obsaženo).
//'Takže je to třeba chápat spíše tak, že třetí zadané číslo je limit.
//'Varianta: Zadá se první a druhy krok a počet prvku posloupnosti.
namespace D_ {
    internal class D03_linearni_posloupnost {
        public static void Mainx(string[] args) {
            int a, b, limit, posloupnost;

            Console.Write("Zadejte první, druhy člen a počet kroků celočíselné lineární posloupnosti.\nProgram zobrazí pod sebou všechny prvky posloupnosti.\n\nZadej první člen: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Zadej drůhý člen: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Zadej počet kroků posloupnosti: ");
            limit = int.Parse(Console.ReadLine());
            Console.WriteLine("\nVypis posloupnosti: \n{0}.\t{1}", 1, a);
            if (a < b) {
                posloupnost = b - a;
                for (int i = 2; i <= limit; i++) {
                    Console.WriteLine("{0}.\t{1}", i, a += posloupnost);
                }
            }
            else {
                posloupnost = a - b;
                for (int i = 1; i <= limit; i++) {
                    Console.WriteLine("{0}.\t{1}", i, a -= posloupnost);
                }
            }
        }
    }
}