using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'    Náročnější
//'Dvojitý cyklus For
//'14) Vytisknete na prvním řádku jednu hvězdu, na druhém dvě až do desátého.
//'Potom se začnou hvězdy ubírat.
//'Varianta: Totéž, ale na prvním řádku se vytisknou dvě hvězdy, na druhém
//'čtyři atd.
//'Varianta 2: Totéž, ale na prvnim i druhem řádku se vytiskne hvězda, na
//'třetím a čtvrtém dvě hvězdy atd.
namespace C {
    internal class C14_sekvence_hvezdicek {
        public static void Mainx(string[] args) {
            string ret = "", retRadek;

            for (int i = 1; i <= 10; ++i) {
                retRadek = "";
                for (int j = 1; j <= i; ++j) {
                    retRadek += "*";          //první zadání
                    //retRadek += "**";           //varianta  **
                }
                ret += retRadek + "\n";
            }
            Console.Write(ret);
            for (int j = ret.Length - 2; j > -1; j--) {
                Console.Write("{0:i}", ret[j]);
            }
            Console.WriteLine();
        }
    }
}

