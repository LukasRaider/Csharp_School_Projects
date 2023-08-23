using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'c07b)
//'Pokud je příklad 7) moc těžký, tak zkuste nejprve jednodušší úkol: Ve smyčce for jdoucí od 1 do 20 vypisujte počitadlo (tedy postupně 1 až 20).
//'Ale ne všechna čísla na jednom řádku nebo všechna čísla pod sebou, nýbrž takto:
//'1 2 3 4 5
//'6 7 8 9 10
//'11 12 13 14 15 
//'16 17 18 19 20
//'  Odřádkování řešte pomocí operátoru Mod. Tedy zeptáte se, zda je právě pořadí čísla dělitelné pěti. A pokud ano, tak odřádkujete.
namespace C {
    internal class C07b_odradkovany_vypis {
        public static void Mainx(string[] args) {
            string ret = "";

            for (int i = 1; i <= 20; i++) {
                if (i % 5 == 0) {
                    ret = ret + i + "\n";
                }
                else {
                    ret = ret + i + " ";
                }
            }
            Console.WriteLine(ret);
        }
    }
}
