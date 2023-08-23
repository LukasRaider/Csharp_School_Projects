using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'    Náročnější x2
//'Dvojitý cyklus For
//'16) Vypište 10 řádků. Na prvním řádku číslo 1, na druhém řádku 12, na třetím 123 atd. (použijte vnořenou smyčku)
namespace C {
    internal class C16_vypis_cisel {
        public static void Mainx(string[] args) {
            string ret = "", retRadek;

            for (int i = 1; i <= 10; ++i) {
                retRadek = "";
                for (int j = 1; j <= i; j++) {
                    retRadek += j;
                }
                ret += retRadek + "\n";
            }
            Console.WriteLine(ret);
        }
    }
}
