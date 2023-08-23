using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'    Náročnější x2
//'Dvojitý cyklus For
//'17) Počítač popíše 20 řádků náhodným počtem hvězdiček.(použijte vnořenou smyčku)
namespace C {
    internal class C17_radky_nah_hvezdicek {
        public static void Mainx(string[] args) {
            int pocetHvezdicek;
            string retRadek = "", ret = "";
            Random rnd = new Random();

            Console.WriteLine("20 řádků s náhodným počtem hvězdiček");
            for (int i = 1; i <= 20; i++) {
                pocetHvezdicek = rnd.Next(1, 71);
                retRadek = "";
                for (int j = 1; j <= pocetHvezdicek; j++) {
                    retRadek += "*";
                }
                Console.WriteLine(ret + i + "ř " + retRadek);
            }
        }
    }
}
