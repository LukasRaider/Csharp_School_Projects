using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'c07)
//'Nasimulujte minutu po minutě kurz koruny k euru prvních dvacet minut po opuštění kurzového závazku čNB.
//'Bude oscilovat mezi 26 (včetně) a 28 (ne včetně) Kč/Euro. V MsgBoxu je vypište (pomocí Mod) tak, že budou vždy po pěti na řádku (oddělené tabulátorem či čárkou nebo mezerou).
//'Vypište s dvěma desetinnými čísly.
namespace C {
    internal class C07a_kurz_Kc_k_Euru {
        public static void Mainx(string[] args) {
            double kurz;
            string ret;
            Random rnd = new Random();

            ret = "Minutu po minutě kurz Kč k Euru prvních dvacet minut, po opuštění kurzového závazku ČNB.\n";
            for (int i = 1; i <= 20; i++) {
                kurz = Math.Round(rnd.NextDouble() * (28 - 26) + 26, 2);
                if (i % 5 == 0) {
                    ret = ret + kurz + "\n";
                }
                else {
                    ret = ret + kurz + "\t";
                }
            }
            Console.WriteLine(ret);
        }
    }
}