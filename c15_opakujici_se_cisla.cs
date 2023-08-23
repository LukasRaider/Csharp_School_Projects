using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'    Náročnější x2
//'Dvojitý cyklus For
//'15) Vygenerujte 100 náhodných celých čísel od 1 do 5. Zjistěte, zda jsou někdy dvě stejná vedle sebe, která to jsou a jaké je
//'jejich pořadové číslo.
namespace C {
    internal class C15_opakujici_se_cisla {
        public static void Mainx(string[] args) {
            Random rnd = new Random();
            string ret, retPosobe;
            int nahCislo, nahCisloPamet = 0;
            ret = "Vygenerovana cisla: \n";
            retPosobe = "Dve stejna vedle sebe:\n";

            for (int i = 1; i <= 100; i++) {
                nahCislo = rnd.Next(1, 6);
                if (nahCislo == nahCisloPamet) {
                    retPosobe += "pořadí " + i + " se opakuje " + nahCislo + "\n";
                }
                nahCisloPamet = nahCislo;
                if (i % 10 == 0) {
                    ret += nahCislo + "\n";
                }
                else {
                    ret += nahCislo + " ";
                }
            }
            Console.WriteLine(ret + "\n" + retPosobe);
        }
    }
}
